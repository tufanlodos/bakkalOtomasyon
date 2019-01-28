namespace PL.Bakkal
{
    partial class frmSiparis
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblTedarikciSecin = new System.Windows.Forms.Label();
            this.cbTedarikciler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtBirimAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblBirimAlisFiyati = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblKategoriSecin = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(624, 200);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 29);
            this.btnGuncelle.TabIndex = 125;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblTedarikciSecin
            // 
            this.lblTedarikciSecin.AutoSize = true;
            this.lblTedarikciSecin.Location = new System.Drawing.Point(20, 105);
            this.lblTedarikciSecin.Name = "lblTedarikciSecin";
            this.lblTedarikciSecin.Size = new System.Drawing.Size(81, 13);
            this.lblTedarikciSecin.TabIndex = 124;
            this.lblTedarikciSecin.Text = "Tedarikçi Seçin";
            // 
            // cbTedarikciler
            // 
            this.cbTedarikciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikciler.FormattingEnabled = true;
            this.cbTedarikciler.Location = new System.Drawing.Point(158, 97);
            this.cbTedarikciler.Name = "cbTedarikciler";
            this.cbTedarikciler.Size = new System.Drawing.Size(205, 21);
            this.cbTedarikciler.TabIndex = 123;
            this.cbTedarikciler.SelectedIndexChanged += new System.EventHandler(this.cbTedarikciler_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(477, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 29);
            this.btnSil.TabIndex = 122;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(20, 64);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(60, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 120;
            this.lblTedarikIcinUrunSecin.Text = "Ürün Seçin";
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(158, 56);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(205, 21);
            this.cbUrunler.TabIndex = 119;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(549, 242);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(257, 20);
            this.txtToplamTutar.TabIndex = 118;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(426, 245);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(117, 13);
            this.lblToplamTutar.TabIndex = 117;
            this.lblToplamTutar.Text = "Bekleyen Toplam Tutar";
            // 
            // txtBirimAlisFiyati
            // 
            this.txtBirimAlisFiyati.Location = new System.Drawing.Point(158, 180);
            this.txtBirimAlisFiyati.Name = "txtBirimAlisFiyati";
            this.txtBirimAlisFiyati.ReadOnly = true;
            this.txtBirimAlisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimAlisFiyati.TabIndex = 115;
            // 
            // lblBirimAlisFiyati
            // 
            this.lblBirimAlisFiyati.AutoSize = true;
            this.lblBirimAlisFiyati.Location = new System.Drawing.Point(22, 180);
            this.lblBirimAlisFiyati.Name = "lblBirimAlisFiyati";
            this.lblBirimAlisFiyati.Size = new System.Drawing.Size(75, 13);
            this.lblBirimAlisFiyati.TabIndex = 114;
            this.lblBirimAlisFiyati.Text = "Birim Alış Fiyatı";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(158, 144);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(204, 20);
            this.txtAdet.TabIndex = 0;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(22, 144);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 112;
            this.lblAdet.Text = "Adet";
            // 
            // lblKategoriSecin
            // 
            this.lblKategoriSecin.AutoSize = true;
            this.lblKategoriSecin.Location = new System.Drawing.Point(20, 23);
            this.lblKategoriSecin.Name = "lblKategoriSecin";
            this.lblKategoriSecin.Size = new System.Drawing.Size(76, 13);
            this.lblKategoriSecin.TabIndex = 111;
            this.lblKategoriSecin.Text = "Kategori Seçin";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(158, 18);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(205, 21);
            this.cbKategoriler.TabIndex = 110;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(420, 50);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(477, 144);
            this.dgvSiparisler.TabIndex = 126;
            this.dgvSiparisler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellDoubleClick);
            this.dgvSiparisler.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellValueChanged);
            this.dgvSiparisler.DoubleClick += new System.EventHandler(this.dgvSiparisler_DoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(158, 218);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 127;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(458, 9);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(118, 13);
            this.lblSiralamaOlcutu.TabIndex = 130;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü Seçiniz";
            // 
            // cbSiralama
            // 
            this.cbSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Items.AddRange(new object[] {
            "Önce en yeniler",
            "Önce en eskiler",
            "Tutara göre azalan",
            "Tutara göre artan",
            "Miktara göre azalan",
            "Miktara göre artan"});
            this.cbSiralama.Location = new System.Drawing.Point(591, 4);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 129;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Kayıtlı Siparişler";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(761, 200);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(128, 29);
            this.btnVazgec.TabIndex = 132;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // frmSiparis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 361);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbUrunler);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriler);
            this.Name = "frmSiparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox txtBirimAlisFiyati;
        private System.Windows.Forms.Label lblBirimAlisFiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblKategoriSecin;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
    }
}