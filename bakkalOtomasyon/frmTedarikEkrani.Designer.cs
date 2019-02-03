namespace PL.Bakkal
{
    partial class frmTedarikEkrani
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIslemiKaydet = new System.Windows.Forms.Button();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbTedarikIcinUrunSecin = new System.Windows.Forms.ComboBox();
            this.lblTedarikEdilmisUrunler = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.lblTelefonNumarasi = new System.Windows.Forms.Label();
            this.lblTedarikciSecin = new System.Windows.Forms.Label();
            this.cbTedarikciSecin = new System.Windows.Forms.ComboBox();
            this.lbTedarikEdilmisUrunler = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnYeniTedarikci = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(402, 367);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 112;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(503, 319);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(202, 20);
            this.txtToplamTutar.TabIndex = 111;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(390, 326);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 110;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.Location = new System.Drawing.Point(394, 194);
            this.lvUrunler.MultiSelect = false;
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(324, 97);
            this.lvUrunler.TabIndex = 109;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.SelectedIndexChanged += new System.EventHandler(this.lvUrunler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tedarikçi Adı";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birim Fiyat";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            this.columnHeader4.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Toplam Fiyat";
            this.columnHeader5.Width = 95;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(516, 159);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(202, 20);
            this.txtBirimFiyat.TabIndex = 108;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(391, 159);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(75, 13);
            this.lblBirimFiyat.TabIndex = 107;
            this.lblBirimFiyat.Text = "Birim Alış Fiyatı";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(516, 123);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(202, 20);
            this.txtAdet.TabIndex = 106;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(391, 123);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 105;
            this.lblAdet.Text = "Adet";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(489, 367);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 104;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIslemiKaydet
            // 
            this.btnIslemiKaydet.Enabled = false;
            this.btnIslemiKaydet.Location = new System.Drawing.Point(576, 367);
            this.btnIslemiKaydet.Name = "btnIslemiKaydet";
            this.btnIslemiKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnIslemiKaydet.TabIndex = 103;
            this.btnIslemiKaydet.Text = "İşlemi Kaydet";
            this.btnIslemiKaydet.UseVisualStyleBackColor = true;
            this.btnIslemiKaydet.Click += new System.EventHandler(this.btnIslemiKaydet_Click);
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(391, 55);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(119, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 102;
            this.lblTedarikIcinUrunSecin.Text = "Tedarik İçin Ürün Seçin";
            // 
            // cbTedarikIcinUrunSecin
            // 
            this.cbTedarikIcinUrunSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikIcinUrunSecin.FormattingEnabled = true;
            this.cbTedarikIcinUrunSecin.Location = new System.Drawing.Point(394, 80);
            this.cbTedarikIcinUrunSecin.Name = "cbTedarikIcinUrunSecin";
            this.cbTedarikIcinUrunSecin.Size = new System.Drawing.Size(162, 21);
            this.cbTedarikIcinUrunSecin.TabIndex = 101;
            this.cbTedarikIcinUrunSecin.SelectedIndexChanged += new System.EventHandler(this.cbTedarikIcinUrunSecin_SelectedIndexChanged);
            // 
            // lblTedarikEdilmisUrunler
            // 
            this.lblTedarikEdilmisUrunler.AutoSize = true;
            this.lblTedarikEdilmisUrunler.Location = new System.Drawing.Point(39, 251);
            this.lblTedarikEdilmisUrunler.Name = "lblTedarikEdilmisUrunler";
            this.lblTedarikEdilmisUrunler.Size = new System.Drawing.Size(115, 13);
            this.lblTedarikEdilmisUrunler.TabIndex = 100;
            this.lblTedarikEdilmisUrunler.Text = "Tedarik Edilmiş Ürünler";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(163, 200);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(202, 20);
            this.txtAdres.TabIndex = 98;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(38, 200);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 97;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(163, 123);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(202, 20);
            this.txtAdSoyad.TabIndex = 96;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(38, 123);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 95;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(163, 162);
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.ReadOnly = true;
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(202, 20);
            this.txtTelefonNumarasi.TabIndex = 94;
            // 
            // lblTelefonNumarasi
            // 
            this.lblTelefonNumarasi.AutoSize = true;
            this.lblTelefonNumarasi.Location = new System.Drawing.Point(38, 162);
            this.lblTelefonNumarasi.Name = "lblTelefonNumarasi";
            this.lblTelefonNumarasi.Size = new System.Drawing.Size(90, 13);
            this.lblTelefonNumarasi.TabIndex = 93;
            this.lblTelefonNumarasi.Text = "Telefon Numarası";
            // 
            // lblTedarikciSecin
            // 
            this.lblTedarikciSecin.AutoSize = true;
            this.lblTedarikciSecin.Location = new System.Drawing.Point(38, 56);
            this.lblTedarikciSecin.Name = "lblTedarikciSecin";
            this.lblTedarikciSecin.Size = new System.Drawing.Size(81, 13);
            this.lblTedarikciSecin.TabIndex = 92;
            this.lblTedarikciSecin.Text = "Tedarikçi Seçin";
            // 
            // cbTedarikciSecin
            // 
            this.cbTedarikciSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikciSecin.FormattingEnabled = true;
            this.cbTedarikciSecin.Location = new System.Drawing.Point(42, 80);
            this.cbTedarikciSecin.Name = "cbTedarikciSecin";
            this.cbTedarikciSecin.Size = new System.Drawing.Size(162, 21);
            this.cbTedarikciSecin.TabIndex = 91;
            this.cbTedarikciSecin.SelectedIndexChanged += new System.EventHandler(this.cbTedarikciSecin_SelectedIndexChanged);
            // 
            // lbTedarikEdilmisUrunler
            // 
            this.lbTedarikEdilmisUrunler.FormattingEnabled = true;
            this.lbTedarikEdilmisUrunler.Location = new System.Drawing.Point(163, 244);
            this.lbTedarikEdilmisUrunler.Name = "lbTedarikEdilmisUrunler";
            this.lbTedarikEdilmisUrunler.Size = new System.Drawing.Size(202, 108);
            this.lbTedarikEdilmisUrunler.TabIndex = 113;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnYeniTedarikci
            // 
            this.btnYeniTedarikci.Location = new System.Drawing.Point(234, 72);
            this.btnYeniTedarikci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYeniTedarikci.Name = "btnYeniTedarikci";
            this.btnYeniTedarikci.Size = new System.Drawing.Size(113, 28);
            this.btnYeniTedarikci.TabIndex = 114;
            this.btnYeniTedarikci.Text = "Yeni Tedarikçi Ekle";
            this.btnYeniTedarikci.UseVisualStyleBackColor = true;
            this.btnYeniTedarikci.Click += new System.EventHandler(this.btnYeniTedarikci_Click);
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(741, 29);
            this.formKapatici1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(741, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "TEDARİK EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTedarikEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.Controls.Add(this.btnYeniTedarikci);
            this.Controls.Add(this.lbTedarikEdilmisUrunler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIslemiKaydet);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbTedarikIcinUrunSecin);
            this.Controls.Add(this.lblTedarikEdilmisUrunler);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtTelefonNumarasi);
            this.Controls.Add(this.lblTelefonNumarasi);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciSecin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTedarikEkrani";
            this.Text = "TedarikEkrani";
            this.Load += new System.EventHandler(this.TedarikEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIslemiKaydet;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.ComboBox cbTedarikIcinUrunSecin;
        private System.Windows.Forms.Label lblTedarikEdilmisUrunler;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtTelefonNumarasi;
        private System.Windows.Forms.Label lblTelefonNumarasi;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciSecin;
        private System.Windows.Forms.ListBox lbTedarikEdilmisUrunler;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnYeniTedarikci;
        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
    }
}