using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunKontrol2 : Form
    {        
        public frm_UrunKontrol2()
        {
            InitializeComponent();            
        }

        public WS_Kontrol.ZktmobilCheckProductResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilCheckProductResponse();
        public 
        
        DataTable dtstok = new DataTable();
        DataTable dtstokR = new DataTable(); //bölge market stok

        private void frm_UrunKontrol2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
            try
            {
                if (resp != null)
                {
                    txt_ayliksatis.Text = resp.EMenge.ToString("N2") + " " + resp.EMeins;
                    txt_Barkod.Text = resp.EEan11;
                    txt_fiyat.Text = resp.EPrice.ToString("N2");
                    txt_ParoKartliTutar.Text = resp.EParoTotal.ToString("N2");
                    txt_KonsinyeBirim.Text = resp.EKmeins;
                    txt_KonsinyeMiktar.Text = resp.EKmenge.ToString("N2");
                    txt_maktx.Text = resp.EMaktx;
                    txt_Malgrubu1.Text = resp.EMatkl;
                    txt_Malgrubu2.Text = resp.EWgbez;
                    txt_malzdurum1.Text = resp.EStatus;
                    txt_malzdurum2.Text = resp.EDescr;
                    txt_matnr.Text = resp.EMatnr;
                    txt_Satici1.Text = resp.ELifnr;
                    txt_Satici2.Text = resp.EName1;
                    txt_SayiciTel.Text = resp.ETelf;
                    grd_acikSip.DataSource = null;

                    dtstok.Columns.Add("werks");
                    dtstok.Columns.Add("lgort");
                    dtstok.Columns.Add("lgobe");
                    dtstok.Columns.Add("menge");
                    dtstok.Columns.Add("meins");                    

                    for (int i = 0; i < resp.ItDepostk.Length; i++)
                    {
                        DataRow row = dtstok.NewRow();
                        row["werks"] = resp.ItDepostk[i].Werks;
                        row["lgort"] = resp.ItDepostk[i].Lgort;
                        row["lgobe"] = resp.ItDepostk[i].Lgobe;
                        row["meins"] = resp.ItDepostk[i].Meins;
                        row["menge"] = resp.ItDepostk[i].Menge;
                        dtstok.Rows.Add(row);
                    }
                    grd_depostok.DataSource = dtstok;

                    WS_Kontrol.ZktmobilRegionStock reg = new KoctasMobil.WS_Kontrol.ZktmobilRegionStock();
                    WS_Kontrol.ZktmobilRegionStockResponse respR = new KoctasMobil.WS_Kontrol.ZktmobilRegionStockResponse();
                    reg.ItBolgstk = new KoctasMobil.WS_Kontrol.ZktmobilDepostk[0];
                    try
                    {
                        WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
                        srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                        srv.Credentials = ProgramGlobalData.g_credential;
                        reg.IMatnr = txt_matnr.Text.Trim();
                        respR = srv.ZktmobilRegionStock(reg);

                        dtstokR.Columns.Add("werks");
                        dtstokR.Columns.Add("lgort");
                        dtstokR.Columns.Add("lgobe");
                        dtstokR.Columns.Add("menge");
                        dtstokR.Columns.Add("meins");

                        for (int i = 0; i < respR.ItBolgstk.Length; i++)
                        {
                            DataRow row = dtstokR.NewRow();
                            row["werks"] = respR.ItBolgstk[i].Werks;
                            row["lgort"] = respR.ItBolgstk[i].Lgort;
                            row["lgobe"] = respR.ItBolgstk[i].Lgobe;
                            row["meins"] = respR.ItBolgstk[i].Meins;
                            row["menge"] = respR.ItBolgstk[i].Menge;
                            dtstokR.Rows.Add(row);
                        }
                        grd_StokR.DataSource = dtstokR;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conversion error: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            
        }
        private void GeneralKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt_sip = new DataTable();
            dt_sip.Columns.Add("ebeln");
            dt_sip.Columns.Add("bedat");
            dt_sip.Columns.Add("menge");
            dt_sip.Columns.Add("meins");
            dt_sip.Columns.Add("ear");

            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilGetOpnPo po = new KoctasMobil.WS_Kontrol.ZktmobilGetOpnPo();
            WS_Kontrol.ZktmobilGetOpnPoResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilGetOpnPoResponse();
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
                
                if (!String.IsNullOrEmpty(txt_Barkod.Text))
                {
                    po.IMatnr = txt_Barkod.Text.Trim();
                }
                else if (!String.IsNullOrEmpty(txt_matnr.Text))
                {
                    po.IMatnr = txt_matnr.Text.Trim();
                }
                else
                {
                    return;
                }
                
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;

                mtnr.IMatnr = po.IMatnr;

                matresp = srv.ZktmobilChckMtnr(mtnr);
                if (String.IsNullOrEmpty(matresp.EMaktx.Trim()))
                {
                    dt_sip.Clear();
                    grd_acikSip.DataSource = dt_sip;
                    return;
                }
                po.IMatnr = matresp.EMatnr;
                po.ItOpnpo = new KoctasMobil.WS_Kontrol.ZktmobilOpnPo[0];

                resp = srv.ZktmobilGetOpnPo(po);

                if (resp.ItOpnpo.Length == 0)
                {
                    MessageBox.Show("Ürüne ait açık sipariş bulunamadı.");
                    dt_sip.Clear();
                    grd_acikSip.DataSource = dt_sip;
                    return;
                }
                foreach (WS_Kontrol.ZktmobilOpnPo opn in resp.ItOpnpo)
                {
                    DataRow row = dt_sip.NewRow();
                    row["ebeln"] = opn.EEbeln;
                    row["bedat"] = Convert.ToDateTime(opn.EBedat).ToString("dd/MM/yyyy");
                    row["menge"] = opn.EMenge;
                    row["meins"] = opn.EMeins;
                    if (opn.EAr == "X")
                        row["ear"] = opn.EAr;
                    else
                        row["ear"] = "";

                    dt_sip.Rows.Add(row);
                }
                grd_acikSip.DataSource = dt_sip;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



  
    }
}

