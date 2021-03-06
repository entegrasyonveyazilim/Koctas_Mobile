using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SiparisSil : Form
    {
        public frm_SiparisSil()
        {
            InitializeComponent();
        }
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBelgeNo.Text))
            {
                return;
            }
            if (MessageBox.Show("Silmek istediðinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
                    WS_Satis.ZktmobilDeleteOrder deleteorder = new KoctasMobil.WS_Satis.ZktmobilDeleteOrder();
                    WS_Satis.ZktmobilDeleteOrderResponse response = new KoctasMobil.WS_Satis.ZktmobilDeleteOrderResponse();
                    deleteorder.IVbeln = txtBelgeNo.Text.Trim();
                    deleteorder.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;

                    response = SRV.ZktmobilDeleteOrder(deleteorder);
                    //MessageBox.Show(response.TeReturn[0].RcText);
                    if (response.TeReturn[0].RcCode == "S")
                    {
                        txtBelgeNo.Text = "";
                        MessageBox.Show("Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(response.TeReturn[0].RcText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }     
            }
        }

        private void frm_SiparisSil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}