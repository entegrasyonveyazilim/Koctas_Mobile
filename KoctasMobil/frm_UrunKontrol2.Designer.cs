namespace KoctasMobil
{
    partial class frm_UrunKontrol2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UrunKontrol2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.txt_matnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_bilgiler = new System.Windows.Forms.TabPage();
            this.txt_ayliksatis = new System.Windows.Forms.TextBox();
            this.txt_KonsinyeBirim = new System.Windows.Forms.TextBox();
            this.txt_Malgrubu2 = new System.Windows.Forms.TextBox();
            this.txt_Malgrubu1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_KonsinyeMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SayiciTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Satici2 = new System.Windows.Forms.TextBox();
            this.txt_Satici1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_malzdurum1 = new System.Windows.Forms.TextBox();
            this.txt_malzdurum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_depoStoklari = new System.Windows.Forms.TabPage();
            this.grd_depostok = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tab_BolgeStoklari = new System.Windows.Forms.TabPage();
            this.grd_StokR = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tab_AcikSiparis = new System.Windows.Forms.TabPage();
            this.grd_acikSip = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_ParoKartliTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.pictureButton1 = new KoctasMobil.PictureButton();
            this.tabControl1.SuspendLayout();
            this.tab_bilgiler.SuspendLayout();
            this.tab_depoStoklari.SuspendLayout();
            this.tab_BolgeStoklari.SuspendLayout();
            this.tab_AcikSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Barkod:";
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.BackColor = System.Drawing.Color.Tomato;
            this.txt_Barkod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Barkod.ForeColor = System.Drawing.Color.White;
            this.txt_Barkod.Location = new System.Drawing.Point(205, 3);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(112, 22);
            this.txt_Barkod.TabIndex = 2;
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_matnr
            // 
            this.txt_matnr.BackColor = System.Drawing.Color.Tomato;
            this.txt_matnr.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_matnr.ForeColor = System.Drawing.Color.White;
            this.txt_matnr.Location = new System.Drawing.Point(69, 3);
            this.txt_matnr.Name = "txt_matnr";
            this.txt_matnr.Size = new System.Drawing.Size(88, 22);
            this.txt_matnr.TabIndex = 1;
            this.txt_matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.Text = "Ürün Kodu:";
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(69, 28);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(221, 22);
            this.txt_maktx.TabIndex = 3;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-1, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı   :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_bilgiler);
            this.tabControl1.Controls.Add(this.tab_depoStoklari);
            this.tabControl1.Controls.Add(this.tab_BolgeStoklari);
            this.tabControl1.Controls.Add(this.tab_AcikSiparis);
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 210);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_bilgiler
            // 
            this.tab_bilgiler.BackColor = System.Drawing.Color.White;
            this.tab_bilgiler.Controls.Add(this.txt_ParoKartliTutar);
            this.tab_bilgiler.Controls.Add(this.label11);
            this.tab_bilgiler.Controls.Add(this.txt_ayliksatis);
            this.tab_bilgiler.Controls.Add(this.txt_KonsinyeBirim);
            this.tab_bilgiler.Controls.Add(this.txt_Malgrubu2);
            this.tab_bilgiler.Controls.Add(this.txt_Malgrubu1);
            this.tab_bilgiler.Controls.Add(this.label9);
            this.tab_bilgiler.Controls.Add(this.txt_KonsinyeMiktar);
            this.tab_bilgiler.Controls.Add(this.label10);
            this.tab_bilgiler.Controls.Add(this.txt_SayiciTel);
            this.tab_bilgiler.Controls.Add(this.label8);
            this.tab_bilgiler.Controls.Add(this.txt_Satici2);
            this.tab_bilgiler.Controls.Add(this.txt_Satici1);
            this.tab_bilgiler.Controls.Add(this.label7);
            this.tab_bilgiler.Controls.Add(this.txt_fiyat);
            this.tab_bilgiler.Controls.Add(this.label6);
            this.tab_bilgiler.Controls.Add(this.txt_malzdurum1);
            this.tab_bilgiler.Controls.Add(this.txt_malzdurum2);
            this.tab_bilgiler.Controls.Add(this.label4);
            this.tab_bilgiler.Controls.Add(this.label2);
            this.tab_bilgiler.Location = new System.Drawing.Point(4, 25);
            this.tab_bilgiler.Name = "tab_bilgiler";
            this.tab_bilgiler.Size = new System.Drawing.Size(311, 181);
            this.tab_bilgiler.Text = "Bilgiler ";
            // 
            // txt_ayliksatis
            // 
            this.txt_ayliksatis.BackColor = System.Drawing.Color.Tomato;
            this.txt_ayliksatis.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_ayliksatis.ForeColor = System.Drawing.Color.White;
            this.txt_ayliksatis.Location = new System.Drawing.Point(108, 3);
            this.txt_ayliksatis.Name = "txt_ayliksatis";
            this.txt_ayliksatis.Size = new System.Drawing.Size(65, 22);
            this.txt_ayliksatis.TabIndex = 73;
            this.txt_ayliksatis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_KonsinyeBirim
            // 
            this.txt_KonsinyeBirim.BackColor = System.Drawing.Color.Tomato;
            this.txt_KonsinyeBirim.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_KonsinyeBirim.ForeColor = System.Drawing.Color.White;
            this.txt_KonsinyeBirim.Location = new System.Drawing.Point(221, 78);
            this.txt_KonsinyeBirim.Name = "txt_KonsinyeBirim";
            this.txt_KonsinyeBirim.Size = new System.Drawing.Size(51, 22);
            this.txt_KonsinyeBirim.TabIndex = 83;
            this.txt_KonsinyeBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_Malgrubu2
            // 
            this.txt_Malgrubu2.BackColor = System.Drawing.Color.Tomato;
            this.txt_Malgrubu2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Malgrubu2.ForeColor = System.Drawing.Color.White;
            this.txt_Malgrubu2.Location = new System.Drawing.Point(157, 103);
            this.txt_Malgrubu2.Name = "txt_Malgrubu2";
            this.txt_Malgrubu2.Size = new System.Drawing.Size(151, 22);
            this.txt_Malgrubu2.TabIndex = 82;
            this.txt_Malgrubu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_Malgrubu1
            // 
            this.txt_Malgrubu1.BackColor = System.Drawing.Color.Tomato;
            this.txt_Malgrubu1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Malgrubu1.ForeColor = System.Drawing.Color.White;
            this.txt_Malgrubu1.Location = new System.Drawing.Point(108, 103);
            this.txt_Malgrubu1.Name = "txt_Malgrubu1";
            this.txt_Malgrubu1.Size = new System.Drawing.Size(48, 22);
            this.txt_Malgrubu1.TabIndex = 81;
            this.txt_Malgrubu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.Text = "Mal Grubu:";
            // 
            // txt_KonsinyeMiktar
            // 
            this.txt_KonsinyeMiktar.BackColor = System.Drawing.Color.Tomato;
            this.txt_KonsinyeMiktar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_KonsinyeMiktar.ForeColor = System.Drawing.Color.White;
            this.txt_KonsinyeMiktar.Location = new System.Drawing.Point(108, 78);
            this.txt_KonsinyeMiktar.Name = "txt_KonsinyeMiktar";
            this.txt_KonsinyeMiktar.Size = new System.Drawing.Size(112, 22);
            this.txt_KonsinyeMiktar.TabIndex = 80;
            this.txt_KonsinyeMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.Text = "Konsinye Stok:";
            // 
            // txt_SayiciTel
            // 
            this.txt_SayiciTel.BackColor = System.Drawing.Color.Tomato;
            this.txt_SayiciTel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_SayiciTel.ForeColor = System.Drawing.Color.White;
            this.txt_SayiciTel.Location = new System.Drawing.Point(208, 128);
            this.txt_SayiciTel.Name = "txt_SayiciTel";
            this.txt_SayiciTel.Size = new System.Drawing.Size(100, 22);
            this.txt_SayiciTel.TabIndex = 78;
            this.txt_SayiciTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(175, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.Text = "Tel :";
            // 
            // txt_Satici2
            // 
            this.txt_Satici2.BackColor = System.Drawing.Color.Tomato;
            this.txt_Satici2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Satici2.ForeColor = System.Drawing.Color.White;
            this.txt_Satici2.Location = new System.Drawing.Point(4, 153);
            this.txt_Satici2.Name = "txt_Satici2";
            this.txt_Satici2.Size = new System.Drawing.Size(304, 22);
            this.txt_Satici2.TabIndex = 79;
            this.txt_Satici2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_Satici1
            // 
            this.txt_Satici1.BackColor = System.Drawing.Color.Tomato;
            this.txt_Satici1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Satici1.ForeColor = System.Drawing.Color.White;
            this.txt_Satici1.Location = new System.Drawing.Point(108, 128);
            this.txt_Satici1.Name = "txt_Satici1";
            this.txt_Satici1.Size = new System.Drawing.Size(65, 22);
            this.txt_Satici1.TabIndex = 77;
            this.txt_Satici1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.Text = "Satıcı :";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BackColor = System.Drawing.Color.Tomato;
            this.txt_fiyat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_fiyat.ForeColor = System.Drawing.Color.White;
            this.txt_fiyat.Location = new System.Drawing.Point(218, 3);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(90, 22);
            this.txt_fiyat.TabIndex = 76;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(175, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.Text = "Fiyat :";
            // 
            // txt_malzdurum1
            // 
            this.txt_malzdurum1.BackColor = System.Drawing.Color.Tomato;
            this.txt_malzdurum1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_malzdurum1.ForeColor = System.Drawing.Color.White;
            this.txt_malzdurum1.Location = new System.Drawing.Point(108, 53);
            this.txt_malzdurum1.Name = "txt_malzdurum1";
            this.txt_malzdurum1.Size = new System.Drawing.Size(48, 22);
            this.txt_malzdurum1.TabIndex = 75;
            this.txt_malzdurum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // txt_malzdurum2
            // 
            this.txt_malzdurum2.BackColor = System.Drawing.Color.Tomato;
            this.txt_malzdurum2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_malzdurum2.ForeColor = System.Drawing.Color.White;
            this.txt_malzdurum2.Location = new System.Drawing.Point(157, 53);
            this.txt_malzdurum2.Name = "txt_malzdurum2";
            this.txt_malzdurum2.Size = new System.Drawing.Size(151, 22);
            this.txt_malzdurum2.TabIndex = 74;
            this.txt_malzdurum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.Text = "Malzeme Durumu:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.Text = "Bir Aylık Satış:";
            // 
            // tab_depoStoklari
            // 
            this.tab_depoStoklari.BackColor = System.Drawing.Color.White;
            this.tab_depoStoklari.Controls.Add(this.grd_depostok);
            this.tab_depoStoklari.Location = new System.Drawing.Point(4, 25);
            this.tab_depoStoklari.Name = "tab_depoStoklari";
            this.tab_depoStoklari.Size = new System.Drawing.Size(311, 181);
            this.tab_depoStoklari.Text = "Depo Stok ";
            // 
            // grd_depostok
            // 
            this.grd_depostok.BackColor = System.Drawing.Color.White;
            this.grd_depostok.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_depostok.ColumnHeadersVisible = false;
            this.grd_depostok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_depostok.Location = new System.Drawing.Point(0, 0);
            this.grd_depostok.Name = "grd_depostok";
            this.grd_depostok.RowHeadersVisible = false;
            this.grd_depostok.Size = new System.Drawing.Size(311, 181);
            this.grd_depostok.TabIndex = 31;
            this.grd_depostok.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
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
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.MappingName = "menge";
            this.dataGridTextBoxColumn8.Width = 66;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.MappingName = "meins";
            this.dataGridTextBoxColumn9.Width = 44;
            // 
            // tab_BolgeStoklari
            // 
            this.tab_BolgeStoklari.BackColor = System.Drawing.Color.White;
            this.tab_BolgeStoklari.Controls.Add(this.grd_StokR);
            this.tab_BolgeStoklari.Location = new System.Drawing.Point(4, 25);
            this.tab_BolgeStoklari.Name = "tab_BolgeStoklari";
            this.tab_BolgeStoklari.Size = new System.Drawing.Size(311, 181);
            this.tab_BolgeStoklari.Text = "Blg. Market Stok ";
            // 
            // grd_StokR
            // 
            this.grd_StokR.BackColor = System.Drawing.Color.White;
            this.grd_StokR.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_StokR.ColumnHeadersVisible = false;
            this.grd_StokR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StokR.Location = new System.Drawing.Point(0, 0);
            this.grd_StokR.Name = "grd_StokR";
            this.grd_StokR.RowHeadersVisible = false;
            this.grd_StokR.Size = new System.Drawing.Size(311, 181);
            this.grd_StokR.TabIndex = 32;
            this.grd_StokR.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.MappingName = "werks";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.MappingName = "lgort";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.MappingName = "lgobe";
            this.dataGridTextBoxColumn3.Width = 90;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.MappingName = "menge";
            this.dataGridTextBoxColumn4.Width = 66;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.MappingName = "meins";
            this.dataGridTextBoxColumn10.Width = 44;
            // 
            // tab_AcikSiparis
            // 
            this.tab_AcikSiparis.BackColor = System.Drawing.Color.White;
            this.tab_AcikSiparis.Controls.Add(this.grd_acikSip);
            this.tab_AcikSiparis.Controls.Add(this.pictureButton1);
            this.tab_AcikSiparis.Location = new System.Drawing.Point(4, 25);
            this.tab_AcikSiparis.Name = "tab_AcikSiparis";
            this.tab_AcikSiparis.Size = new System.Drawing.Size(311, 181);
            this.tab_AcikSiparis.Text = "Açık Sip.";
            // 
            // grd_acikSip
            // 
            this.grd_acikSip.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_acikSip.Location = new System.Drawing.Point(-4, 38);
            this.grd_acikSip.Name = "grd_acikSip";
            this.grd_acikSip.Size = new System.Drawing.Size(315, 147);
            this.grd_acikSip.TabIndex = 1;
            this.grd_acikSip.TableStyles.Add(this.dataGridTableStyle3);
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn12);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn13);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn14);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn15);
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.HeaderText = "Belge";
            this.dataGridTextBoxColumn11.MappingName = "ebeln";
            this.dataGridTextBoxColumn11.Width = 88;
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            this.dataGridTextBoxColumn12.HeaderText = "Tarih";
            this.dataGridTextBoxColumn12.MappingName = "bedat";
            this.dataGridTextBoxColumn12.Width = 66;
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            this.dataGridTextBoxColumn13.HeaderText = "Miktar";
            this.dataGridTextBoxColumn13.MappingName = "menge";
            this.dataGridTextBoxColumn13.Width = 60;
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            this.dataGridTextBoxColumn14.HeaderText = "TÖB";
            this.dataGridTextBoxColumn14.MappingName = "meins";
            this.dataGridTextBoxColumn14.Width = 40;
            // 
            // dataGridTextBoxColumn15
            // 
            this.dataGridTextBoxColumn15.Format = "";
            this.dataGridTextBoxColumn15.FormatInfo = null;
            this.dataGridTextBoxColumn15.HeaderText = "AR";
            this.dataGridTextBoxColumn15.MappingName = "ear";
            this.dataGridTextBoxColumn15.Width = 40;
            // 
            // txt_ParoKartliTutar
            // 
            this.txt_ParoKartliTutar.BackColor = System.Drawing.Color.Tomato;
            this.txt_ParoKartliTutar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_ParoKartliTutar.ForeColor = System.Drawing.Color.White;
            this.txt_ParoKartliTutar.Location = new System.Drawing.Point(108, 28);
            this.txt_ParoKartliTutar.Name = "txt_ParoKartliTutar";
            this.txt_ParoKartliTutar.Size = new System.Drawing.Size(90, 22);
            this.txt_ParoKartliTutar.TabIndex = 92;
            this.txt_ParoKartliTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.Text = "Paro Kartlı Tutar :";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(291, 28);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = null;
            this.btn_Ekle.Size = new System.Drawing.Size(24, 22);
            this.btn_Ekle.TabIndex = 156;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // pictureButton1
            // 
            this.pictureButton1.BackColor = System.Drawing.Color.Tomato;
            this.pictureButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureButton1.BackgroundImage")));
            this.pictureButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pictureButton1.ForeColor = System.Drawing.Color.White;
            this.pictureButton1.Location = new System.Drawing.Point(132, 3);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("pictureButton1.PressedImage")));
            this.pictureButton1.Size = new System.Drawing.Size(180, 29);
            this.pictureButton1.TabIndex = 0;
            this.pictureButton1.Text = "     Açık Sip. Getir";
            this.pictureButton1.Click += new System.EventHandler(this.pictureButton1_Click);
            // 
            // frm_UrunKontrol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_matnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UrunKontrol2";
            this.Text = "Ürün Kontrol";
            this.Load += new System.EventHandler(this.frm_UrunKontrol2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_bilgiler.ResumeLayout(false);
            this.tab_depoStoklari.ResumeLayout(false);
            this.tab_BolgeStoklari.ResumeLayout(false);
            this.tab_AcikSiparis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.TextBox txt_matnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_bilgiler;
        private System.Windows.Forms.TextBox txt_KonsinyeBirim;
        private System.Windows.Forms.TextBox txt_Malgrubu2;
        private System.Windows.Forms.TextBox txt_Malgrubu1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_KonsinyeMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SayiciTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Satici2;
        private System.Windows.Forms.TextBox txt_Satici1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_malzdurum1;
        private System.Windows.Forms.TextBox txt_malzdurum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ayliksatis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab_depoStoklari;
        private System.Windows.Forms.TabPage tab_BolgeStoklari;
        private System.Windows.Forms.DataGrid grd_depostok;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
        private System.Windows.Forms.DataGrid grd_StokR;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.TabPage tab_AcikSiparis;
        private PictureButton pictureButton1;
        private System.Windows.Forms.DataGrid grd_acikSip;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
        private PictureButton btn_Ekle;
        private System.Windows.Forms.TextBox txt_ParoKartliTutar;
        private System.Windows.Forms.Label label11;
    }
}