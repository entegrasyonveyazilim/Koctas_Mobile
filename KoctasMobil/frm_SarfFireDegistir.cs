using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SarfFireDegistir : Form
    {
        public frm_SarfFireDegistir()
        {
            InitializeComponent();
        }

        string sMiktar = "";
        public DataTable sarf_mal = new DataTable();

        
        
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            sarf_mal.Columns.Add("Matnr");
            sarf_mal.Columns.Add("Lgort");
            sarf_mal.Columns.Add("Aciklama");
            sarf_mal.Columns.Add("Menge");
            sarf_mal.Columns.Add("Meins");
            sarf_mal.Columns.Add("Sarf");
        }       

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            try
            {
                try { int.Parse(txt_FormNo.Text.Trim()); }
                catch { throw new Exception("Form no alanýna sayısal bir değer giriniz!"); }

                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service SRV = new WS_Stok.service();

                SRV.Url = Utility.getWsUrl("zktmobil_stok");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Stok.ZktmobilGetSarf GetSarf = new WS_Stok.ZktmobilGetSarf();
                GetSarf.ISarfno = txt_FormNo.Text.Trim();
                GetSarf.ItShow = new KoctasMobil.WS_Stok.ZktmobilSarf[1];
                
                WS_Stok.ZktmobilGetSarfResponse Response = SRV.ZktmobilGetSarf(GetSarf);

                if (Response.EReturn.RcCode == "E")
                    throw new Exception(Response.EReturn.RcText);  

                //dataGridTableStyle1.MappingName = Response.ItShow.GetType().Name;
                sarf_mal.Rows.Clear();
                

                foreach (WS_Stok.ZktmobilSarf sarfi in Response.ItShow)
                {
                    DataRow row = sarf_mal.NewRow();
                    row["Aciklama"] = sarfi.Aciklama;
                    row["Lgort"] = sarfi.Lgort;
                    row["Matnr"] = sarfi.Matnr;
                    row["Meins"] = sarfi.Meins;
                    row["Menge"] = sarfi.Menge;
                    row["Sarf"] = sarfi.Sarf;

                    sarf_mal.Rows.Add(row);
                }

                grd_SarfFire.DataSource = null;
                grd_SarfFire.DataSource = sarf_mal;        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }


        }

        private void txt_FormNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Getir_Click(null, null);
            }
        }

        private void grd_SarfFire_Click(object sender, EventArgs e)
        {
              //for (int i = dtGAP.Rows.Count - 1; i >= 0; i--)
              //  if (grd_GAP.IsSelected(i))
              //      dtGAP.Rows.RemoveAt(i);
            if (grd_SarfFire.CurrentRowIndex > -1)
            {
                grd_SarfFire.Select(grd_SarfFire.CurrentRowIndex);
                txtAciklama.Text = grd_SarfFire[grd_SarfFire.CurrentRowIndex, 2].ToString();
                txtMiktar.Text = grd_SarfFire[grd_SarfFire.CurrentRowIndex, 3].ToString();
                txtAdt.Text = grd_SarfFire[grd_SarfFire.CurrentRowIndex, 4].ToString();
                txtAciklama.Focus();
                txtAciklama.SelectAll();
            }
        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMiktar.Focus();
                txtMiktar.SelectAll();
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (grd_SarfFire.VisibleRowCount == 0)
                    return;

                /*
                if (!grd_SarfFire.IsSelected(grd_SarfFire.CurrentRowIndex))
                    throw new Exception("Lütfen bir kayıt seçiniz!");

                if (txtAciklama.Text.Trim() == string.Empty)
                    throw new Exception("Açıklama alanı boş geçilemez!");

                try { int.Parse(txt_FormNo.Text.Trim()); }
                catch { throw new Exception("Form no alanına sayısal bir değer giriniz!"); }
                
                try { decimal.Parse(txtMiktar.Text.Trim()); }
                catch { throw new Exception("Miktar alanına sayısal bir değer giriniz!"); }
                */

                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service SRV = new WS_Stok.service();

                SRV.Url = Utility.getWsUrl("zktmobil_stok");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Stok.ZktmobilChngSarf ChangeSarf = new WS_Stok.ZktmobilChngSarf();
                ChangeSarf.ISarfno = txt_FormNo.Text.Trim();

                //int Length = (grd_SarfFire.DataSource as WS_Stok.ZktmobilSarf[]).Length;
                WS_Stok.ZktmobilSarf[] sarf = new KoctasMobil.WS_Stok.ZktmobilSarf[sarf_mal.Rows.Count];

                for (int i = 0; i < sarf_mal.Rows.Count; i++)
                {
                    WS_Stok.ZktmobilSarf item = new WS_Stok.ZktmobilSarf();
                    item.Aciklama = sarf_mal.Rows[i]["Aciklama"].ToString();
                    item.Lgort = sarf_mal.Rows[i]["Lgort"].ToString();
                    item.Matnr = sarf_mal.Rows[i]["Matnr"].ToString();
                    item.Meins = sarf_mal.Rows[i]["Meins"].ToString();
                    item.Menge = Convert.ToDecimal(sarf_mal.Rows[i]["Menge"].ToString());
                    item.Sarf = sarf_mal.Rows[i]["Sarf"].ToString();

                    sarf[i] = item;

                }

                
                ChangeSarf.ItChng = sarf;

                WS_Stok.ZktmobilChngSarfResponse Response = SRV.ZktmobilChngSarf(ChangeSarf);

                if (Response.EReturn.RcCode == "E")
                    throw new Exception(Response.EReturn.RcText);
                else
                {
                    MessageBox.Show("Form Güncellendi.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


                //grd_SarfFire.UnSelect(grd_SarfFire.CurrentRowIndex);
                btn_Getir_Click(null, null);
                txtAciklama.Text = txtAdt.Text = txtMiktar.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtAdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Degistir();
            }
        }

        private void btn_Iptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            Degistir();
        }

        private void Degistir()
        {
            try
            {
                if (grd_SarfFire.VisibleRowCount == 0)
                    return;

                if (!grd_SarfFire.IsSelected(grd_SarfFire.CurrentRowIndex))
                    throw new Exception("Lütfen bir kayıt seçiniz!");
                /*
                if (txtAciklama.Text.Trim() == string.Empty)
                    throw new Exception("Açıklama alanı boş geçilemez!");
                */
                try { int.Parse(txt_FormNo.Text.Trim()); }
                catch { throw new Exception("Form no alanına sayısal bir değer giriniz!"); }

                try {
                    decimal miktar = decimal.Parse(txtMiktar.Text.Trim());
                    if (!(miktar > 0))
                    {
                        MessageBox.Show("Miktar alanına 0'dan büyük bir değer giriniz!");
                        return;
                    }
                }
                catch { throw new Exception("Miktar alanına sayısal bir değer giriniz!"); }

                sarf_mal.Rows[grd_SarfFire.CurrentRowIndex]["Aciklama"] = txtAciklama.Text.Trim().ToString();

                sMiktar = txtMiktar.Text.Trim();
                sMiktar = sMiktar.Replace(',', '.');
                sarf_mal.Rows[grd_SarfFire.CurrentRowIndex]["Menge"] = Convert.ToDecimal(sMiktar);

                grd_SarfFire.DataSource = null;
                grd_SarfFire.DataSource = sarf_mal;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

   
    }
}