namespace KoctasMobil
{
    partial class frm_Transfer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Transfer2));
            this.grd_Transfer = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtAdt = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_iptal = new KoctasMobil.PictureButton();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // grd_Transfer
            // 
            this.grd_Transfer.BackColor = System.Drawing.Color.White;
            this.grd_Transfer.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Transfer.Location = new System.Drawing.Point(0, 10);
            this.grd_Transfer.Name = "grd_Transfer";
            this.grd_Transfer.Size = new System.Drawing.Size(315, 163);
            this.grd_Transfer.TabIndex = 66;
            this.grd_Transfer.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_Transfer.Click += new System.EventHandler(this.grd_Transfer_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Ürün Kodu";
            this.dataGridTextBoxColumn1.MappingName = "Matnr";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 65;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Ürün Adı";
            this.dataGridTextBoxColumn2.MappingName = "Maktx";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 140;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "SA Miktar";
            this.dataGridTextBoxColumn3.MappingName = "Menge";
            this.dataGridTextBoxColumn3.Width = 40;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Top. Mikt.";
            this.dataGridTextBoxColumn4.MappingName = "Tmenge";
            this.dataGridTextBoxColumn4.Width = 40;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Sipariş No";
            this.dataGridTextBoxColumn5.MappingName = "Ebeln";
            this.dataGridTextBoxColumn5.Width = 0;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Kalem No";
            this.dataGridTextBoxColumn6.MappingName = "Ebelp";
            this.dataGridTextBoxColumn6.Width = 0;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Birim";
            this.dataGridTextBoxColumn7.MappingName = "Meins";
            this.dataGridTextBoxColumn7.Width = 0;
            // 
            // txtAdt
            // 
            this.txtAdt.BackColor = System.Drawing.Color.Tomato;
            this.txtAdt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdt.ForeColor = System.Drawing.Color.White;
            this.txtAdt.Location = new System.Drawing.Point(135, 179);
            this.txtAdt.MaxLength = 18;
            this.txtAdt.Name = "txtAdt";
            this.txtAdt.Size = new System.Drawing.Size(36, 22);
            this.txtAdt.TabIndex = 98;
            this.txtAdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdt_KeyPress);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtMiktar.Location = new System.Drawing.Point(73, 180);
            this.txtMiktar.MaxLength = 18;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(61, 20);
            this.txtMiktar.TabIndex = 97;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.Text = "Miktar :";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.BackgroundImage")));
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(3, 214);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.PressedImage")));
            this.btn_iptal.Size = new System.Drawing.Size(110, 26);
            this.btn_iptal.TabIndex = 104;
            this.btn_iptal.Text = "     Vazgeç";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(202, 214);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(116, 26);
            this.btn_Kaydet.TabIndex = 102;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // frm_Transfer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdt);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.grd_Transfer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Transfer2";
            this.Text = "Transfer Değişiklik";
            this.Load += new System.EventHandler(this.frm_Transfer2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid grd_Transfer;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TextBox txtAdt;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private PictureButton btn_Kaydet;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private PictureButton btn_iptal;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;

    }
}

