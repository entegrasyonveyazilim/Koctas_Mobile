namespace KoctasMobil
{
    partial class frm_Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Transfer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.btn_Vazgec = new KoctasMobil.PictureButton();
            this.btn_Transfer = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.Text = "Belge No :";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.txtBelgeNo.ForeColor = System.Drawing.Color.Black;
            this.txtBelgeNo.Location = new System.Drawing.Point(148, 76);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(147, 31);
            this.txtBelgeNo.TabIndex = 1;
            this.txtBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRafAdresi_KeyPress);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.BackColor = System.Drawing.Color.Tomato;
            this.btn_Vazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.BackgroundImage")));
            this.btn_Vazgec.ForeColor = System.Drawing.Color.White;
            this.btn_Vazgec.Location = new System.Drawing.Point(21, 128);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.PressedImage")));
            this.btn_Vazgec.Size = new System.Drawing.Size(135, 54);
            this.btn_Vazgec.TabIndex = 6;
            this.btn_Vazgec.Text = "     Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.bntVazgec_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.BackColor = System.Drawing.Color.Tomato;
            this.btn_Transfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Transfer.BackgroundImage")));
            this.btn_Transfer.ForeColor = System.Drawing.Color.White;
            this.btn_Transfer.Location = new System.Drawing.Point(162, 128);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Transfer.PressedImage")));
            this.btn_Transfer.Size = new System.Drawing.Size(135, 54);
            this.btn_Transfer.TabIndex = 5;
            this.btn_Transfer.Text = "      Tamam";
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // frm_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Transfer";
            this.Text = "Transfer İşlemleri";
            this.Load += new System.EventHandler(this.frm_Transfer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private PictureButton btn_Transfer;
        private PictureButton btn_Vazgec;
    }
}