namespace KoctasMobil
{
    partial class frm_UrunKontrol3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.txt_matnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_depostok = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Barkod :";
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.BackColor = System.Drawing.Color.Tomato;
            this.txt_Barkod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Barkod.ForeColor = System.Drawing.Color.White;
            this.txt_Barkod.Location = new System.Drawing.Point(208, 3);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(106, 22);
            this.txt_Barkod.TabIndex = 1;
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_matnr
            // 
            this.txt_matnr.BackColor = System.Drawing.Color.Tomato;
            this.txt_matnr.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_matnr.ForeColor = System.Drawing.Color.White;
            this.txt_matnr.Location = new System.Drawing.Point(73, 3);
            this.txt_matnr.Name = "txt_matnr";
            this.txt_matnr.Size = new System.Drawing.Size(78, 22);
            this.txt_matnr.TabIndex = 8;
            this.txt_matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.Text = "Ürün Kodu:";
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(73, 28);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(241, 22);
            this.txt_maktx.TabIndex = 13;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı   :";
            // 
            // grd_depostok
            // 
            this.grd_depostok.BackColor = System.Drawing.Color.White;
            this.grd_depostok.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_depostok.ColumnHeadersVisible = false;
            this.grd_depostok.Location = new System.Drawing.Point(2, 52);
            this.grd_depostok.Name = "grd_depostok";
            this.grd_depostok.RowHeadersVisible = false;
            this.grd_depostok.Size = new System.Drawing.Size(315, 201);
            this.grd_depostok.TabIndex = 30;
            this.grd_depostok.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.MappingName = "werks";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.MappingName = "lgort";
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.MappingName = "lgobe";
            this.dataGridTextBoxColumn7.Width = 90;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.MappingName = "menge";
            this.dataGridTextBoxColumn9.Width = 66;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.MappingName = "meins";
            this.dataGridTextBoxColumn8.Width = 44;
            // 
            // frm_UrunKontrol3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.grd_depostok);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_matnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UrunKontrol3";
            this.Text = "Ürün Kontrol";
            this.Load += new System.EventHandler(this.frm_UrunKontrol3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.TextBox txt_matnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGrid grd_depostok;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
    }
}