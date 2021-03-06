using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_UrunTutanak : Form
    {
        public frm_UrunTutanak()
        {
            InitializeComponent();
        }

        string ImzaTE = "";
        string ImzaTA = "";
        string ImzaMY = "";

        Bitmap bmp1, bmp2, bmp3;
        string UnvanTE, IsimTE, IsimMY, PlakaTE;
        DataTable dt_urun;

        private void btn_SipariþEkle_Click(object sender, EventArgs e)
        {

        }

        private void frm_UrunTutanak_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_imzalar_Click(object sender, EventArgs e)
        {
            if (txt_Tedarikci.Text.Trim() == "")
            {
                MessageBox.Show("Tedarikçi girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }
            if (txt_SipNo.Text.Trim() == "")
            {
                MessageBox.Show("Sipariş no girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txt_IrsNo.Text.Trim() == "")
            {
                MessageBox.Show("İrsaliye no girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            frm_UrunTutanakImza frm = new frm_UrunTutanakImza();
            frm.bmp1 = bmp1;
            frm.bmp2 = bmp2;
            frm.bmp3 = bmp3;
            frm.IsimMY = IsimMY;
            frm.IsimTE = IsimTE;
            frm.UnvanTE = UnvanTE;
            frm.PlakaTE = PlakaTE;

            frm.ShowDialog();

            bmp1 = frm.bmp1;
            bmp2 = frm.bmp2;
            bmp3 = frm.bmp3;
            IsimMY =  frm.IsimMY;
            IsimTE =  frm.IsimTE;
            UnvanTE = frm.UnvanTE;
            PlakaTE = frm.PlakaTE;      
        }

        private void btn_malzemeler_Click(object sender, EventArgs e)
        {
            frm_UrunTutanakEkle frm = new frm_UrunTutanakEkle();
            frm.tTedarikci = txt_Tedarikci.Text;
            if (dt_urun != null)
            {
                frm.Dt_urun = dt_urun;
            }
            frm.ShowDialog();
            dt_urun = frm.Dt_urun;
            if (frm.Change)
            {
                ImzaMY = ImzaTA = ImzaTE = "";
                bmp1 = bmp2 = bmp3 = null;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmp1 == null)
                {
                    MessageBox.Show("Teslim eden imzası eksik!");
                    return;
                }
                if (bmp2 == null)
                {
                    MessageBox.Show("Teslim alan imzası eksik!");
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;

                Size picsize = new Size(155, 80);
                

                WS_Tutanak.service srv = new KoctasMobil.WS_Tutanak.service();
                srv.Url = Utility.getWsUrl("ZKTMOBIL_URTUT");
                srv.Credentials = ProgramGlobalData.g_credential;
                //srv.Credentials = new System.Net.NetworkCredential("erdem", "Basla*123");

                WS_Tutanak.ZKTMOBIL_TUTANAK tutanak = new KoctasMobil.WS_Tutanak.ZKTMOBIL_TUTANAK();
                tutanak.IS_IMG_INFO1 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG_INFO();
                tutanak.IS_IMG_INFO2 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG_INFO();
                tutanak.IS_IMG_INFO3 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG_INFO();

                WS_Tutanak.ZKTMOBIL_ARIZA[] ariza = new KoctasMobil.WS_Tutanak.ZKTMOBIL_ARIZA[0];
                if (dt_urun != null)
                {
                   ariza = new KoctasMobil.WS_Tutanak.ZKTMOBIL_ARIZA[dt_urun.Rows.Count]; 
                }
                
                tutanak.IS_FORM_ALANLARI = new KoctasMobil.WS_Tutanak.ZFORM_ARIZA();
                
                //fill
                tutanak.IS_FORM_ALANLARI.IM_ACIKLM = txt_Aciklama.Text.Trim();
                tutanak.IS_FORM_ALANLARI.IM_DATUM = dtp_IrsTar.Value.ToString("yyyy-MM-dd");
                tutanak.IS_FORM_ALANLARI.IM_EBELN = txt_SipNo.Text.Trim();
                tutanak.IS_FORM_ALANLARI.IM_LIFNR = txt_Tedarikci.Text.Trim();
                tutanak.IS_FORM_ALANLARI.IM_REF = txt_IrsNo.Text.Trim();
                
                if (bmp1 != null)
                {
                    tutanak.IS_FORM_ALANLARI.PLAKA = PlakaTE;
                    tutanak.IS_FORM_ALANLARI.TE_AD = IsimTE;
                    tutanak.IS_FORM_ALANLARI.TE_UNV = UnvanTE;
                    
                    tutanak.IS_IMG_INFO1.NAME = ProgramGlobalData.ImzaTeFileName;
                    tutanak.IS_IMG_INFO1.FILENAME = tutanak.IS_IMG_INFO1.NAME + ".bmp";
                    tutanak.IS_IMG_INFO1.TITLE = tutanak.IS_IMG_INFO1.NAME;

                    //bmp1 = SignatureControl.ResizePicture(bmp1, picsize);
                    ImzaTE = SignatureControl.GetBytes(bmp1);
                    tutanak.IS_IMG_INFO1.FILELENGTH = ImzaTE.Length;
                    WS_Tutanak.ZKTMOBIL_S_IMG[] img1 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG[Convert.ToInt32(Math.Ceiling(ImzaTE.Length / 128)) + 1];

                    for (int i = 0; i < img1.Length - 1; i++)
                    {
                        img1[i] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                        img1[i].L = ImzaTE.Substring((i * 128), 128);
                    }
                    img1[img1.Length - 1] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                    img1[img1.Length - 1].L = ImzaTE.Substring((img1.Length - 1) * 128);
                    tutanak.IT_BMP1 = img1;

                }
                if (bmp2 != null)
                {
                    //tutanak.IS_FORM_ALANLARI.TA_AD         
           
                    tutanak.IS_IMG_INFO2.NAME = ProgramGlobalData.ImzaTaFileName;
                    tutanak.IS_IMG_INFO2.FILENAME = tutanak.IS_IMG_INFO2.NAME + ".bmp";
                    tutanak.IS_IMG_INFO2.TITLE = tutanak.IS_IMG_INFO2.NAME;
                    
                    //bmp2 = SignatureControl.ResizePicture(bmp2, picsize);
                    ImzaTA = SignatureControl.GetBytes(bmp2);
                    tutanak.IS_IMG_INFO2.FILELENGTH = ImzaTA.Length;
                    WS_Tutanak.ZKTMOBIL_S_IMG[] img2 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG[Convert.ToInt32(Math.Ceiling(ImzaTA.Length / 128)) + 1];
                   
                    for (int i = 0; i < img2.Length - 1; i++)
                    {
                        img2[i] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                        img2[i].L = ImzaTA.Substring((i * 128), 128);
                    }
                    img2[img2.Length - 1] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                    img2[img2.Length - 1].L = ImzaTA.Substring((img2.Length - 1) * 128);
                    tutanak.IT_BMP2 = img2;
                }
                if (bmp3 != null)
                {
                    tutanak.IS_FORM_ALANLARI.MY_AD = IsimMY;
                    
                    tutanak.IS_IMG_INFO3.NAME = ProgramGlobalData.ImzaMyFileName;
                    tutanak.IS_IMG_INFO3.FILENAME = tutanak.IS_IMG_INFO3.NAME + ".bmp";
                    tutanak.IS_IMG_INFO3.TITLE = tutanak.IS_IMG_INFO3.NAME;
                
                    //bmp3 = SignatureControl.ResizePicture(bmp3, picsize);
                    ImzaMY = SignatureControl.GetBytes(bmp3);
                    tutanak.IS_IMG_INFO3.FILELENGTH = ImzaMY.Length;
                    WS_Tutanak.ZKTMOBIL_S_IMG[] img3 = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG[Convert.ToInt32(Math.Ceiling(ImzaMY.Length / 128)) + 1];

                    for (int i = 0; i < img3.Length - 1; i++)
                    {
                        img3[i] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                        img3[i].L = ImzaMY.Substring((i * 128), 128);
                    }
                    img3[img3.Length - 1] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_IMG();
                    img3[img3.Length - 1].L = ImzaMY.Substring((img3.Length - 1) * 128);
                    tutanak.IT_BMP3 = img3;
                }

                if (dt_urun != null)
                {
                    for (int i = 0; i < dt_urun.Rows.Count; i++)
                    {
                        ariza[i] = new KoctasMobil.WS_Tutanak.ZKTMOBIL_ARIZA();
                        ariza[i].MATNR = dt_urun.Rows[i]["MATNR"].ToString();
                        ariza[i].MAKTX = dt_urun.Rows[i]["MAKTX"].ToString();
                        ariza[i].MENGE = dt_urun.Rows[i]["MENGE"].ToString();
                        ariza[i].TIP = dt_urun.Rows[i]["TIP"].ToString();
                    }
                }
                
                tutanak.IT_ARIZA = ariza;

                WS_Tutanak.ZKTMOBIL_TUTANAKResponse resp = srv.ZKTMOBIL_TUTANAK(tutanak);

                if (resp.E_RETURN.RC_CODE.ToUpper() == "E")
                {
                    throw new Exception("SAP Hata: " + resp.E_RETURN.RC_TEXT);
                }
                else
                {
                    MessageBox.Show("Tutanak gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İmzalar işlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            //Close();
        }

        private void frm_UrunTutanak_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtp_IrsTar.Format = DateTimePickerFormat.Custom;
            dtp_IrsTar.CustomFormat = "dd-MM-yyy";
        }
    }
}