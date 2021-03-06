using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_IadeTipi : Form
    {
        public frm_IadeTipi()
        {
            InitializeComponent();
        }

        string _iadetipi;
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Tamam_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txt_Miktar.Text.Trim());
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygun bir sayısal değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void txt_Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char dot = '.';
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != dot;
        }
        private void rdb_Tedarik_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Tedarik.Checked)
            {
                _iadetipi = "T";
            }            
        }

        private void rdb_Raf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Raf.Checked)
            {
                _iadetipi = "R";
            }            
        }

        private void rdb_Sarf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Sarf.Checked)
            {
                _iadetipi = "S";
            }            
        }

        public decimal Iade
        {
            get
            {
                try
                {
                    return Convert.ToDecimal(txt_Miktar.Text.Trim());
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            set { txt_Miktar.Text = value.ToString(); }
        }
        public string Iadetipi
        {
            get { return _iadetipi; }
            set { _iadetipi = value; }
        }

        private void frm_IadeTipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Tamam_Click(new object(), e);
            }
        }        
    }
}