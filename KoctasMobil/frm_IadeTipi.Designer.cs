namespace KoctasMobil
{
    partial class frm_IadeTipi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdb_Tedarik = new System.Windows.Forms.RadioButton();
            this.rdb_Raf = new System.Windows.Forms.RadioButton();
            this.rdb_Sarf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tamam = new System.Windows.Forms.Button();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Tedarik
            // 
            this.rdb_Tedarik.ForeColor = System.Drawing.Color.White;
            this.rdb_Tedarik.Location = new System.Drawing.Point(112, 2);
            this.rdb_Tedarik.Name = "rdb_Tedarik";
            this.rdb_Tedarik.Size = new System.Drawing.Size(83, 23);
            this.rdb_Tedarik.TabIndex = 0;
            this.rdb_Tedarik.Text = "Tedarikçi";
            this.rdb_Tedarik.CheckedChanged += new System.EventHandler(this.rdb_Tedarik_CheckedChanged);
            // 
            // rdb_Raf
            // 
            this.rdb_Raf.ForeColor = System.Drawing.Color.White;
            this.rdb_Raf.Location = new System.Drawing.Point(62, 3);
            this.rdb_Raf.Name = "rdb_Raf";
            this.rdb_Raf.Size = new System.Drawing.Size(68, 20);
            this.rdb_Raf.TabIndex = 1;
            this.rdb_Raf.Text = "Raf";
            this.rdb_Raf.CheckedChanged += new System.EventHandler(this.rdb_Raf_CheckedChanged);
            // 
            // rdb_Sarf
            // 
            this.rdb_Sarf.ForeColor = System.Drawing.Color.White;
            this.rdb_Sarf.Location = new System.Drawing.Point(3, 3);
            this.rdb_Sarf.Name = "rdb_Sarf";
            this.rdb_Sarf.Size = new System.Drawing.Size(68, 20);
            this.rdb_Sarf.TabIndex = 2;
            this.rdb_Sarf.Text = "Sarf";
            this.rdb_Sarf.CheckedChanged += new System.EventHandler(this.rdb_Sarf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.Text = "İade Miktarı :";
            // 
            // btn_Tamam
            // 
            this.btn_Tamam.Location = new System.Drawing.Point(112, 73);
            this.btn_Tamam.Name = "btn_Tamam";
            this.btn_Tamam.Size = new System.Drawing.Size(83, 41);
            this.btn_Tamam.TabIndex = 4;
            this.btn_Tamam.Text = "Tamam";
            this.btn_Tamam.Click += new System.EventHandler(this.btn_Tamam_Click);
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(86, 35);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(109, 23);
            this.txt_Miktar.TabIndex = 5;
            this.txt_Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Miktar_KeyPress);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(3, 73);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(83, 41);
            this.btn_Iptal.TabIndex = 6;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_IadeTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(198, 118);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.btn_Tamam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_Tedarik);
            this.Controls.Add(this.rdb_Raf);
            this.Controls.Add(this.rdb_Sarf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_IadeTipi";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_IadeTipi_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Tedarik;
        private System.Windows.Forms.RadioButton rdb_Raf;
        private System.Windows.Forms.RadioButton rdb_Sarf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tamam;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.Button btn_Iptal;
    }
}