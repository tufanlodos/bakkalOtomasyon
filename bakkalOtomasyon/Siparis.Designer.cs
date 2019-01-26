namespace PL.Bakkal
{
    partial class Siparis
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
            this.cbTedarikciSecin = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbTedarikIcinUrunSecin = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtBirimAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblBirimAlisFiyati = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblKategoriSecin = new System.Windows.Forms.Label();
            this.cbKategoriSecin = new System.Windows.Forms.ComboBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(636, 200);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 29);
            this.btnGuncelle.TabIndex = 125;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
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
            // cbTedarikciSecin
            // 
            this.cbTedarikciSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikciSecin.FormattingEnabled = true;
            this.cbTedarikciSecin.Location = new System.Drawing.Point(158, 97);
            this.cbTedarikciSecin.Name = "cbTedarikciSecin";
            this.cbTedarikciSecin.Size = new System.Drawing.Size(205, 21);
            this.cbTedarikciSecin.TabIndex = 123;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(477, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 122;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
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
            // cbTedarikIcinUrunSecin
            // 
            this.cbTedarikIcinUrunSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikIcinUrunSecin.FormattingEnabled = true;
            this.cbTedarikIcinUrunSecin.Location = new System.Drawing.Point(158, 56);
            this.cbTedarikIcinUrunSecin.Name = "cbTedarikIcinUrunSecin";
            this.cbTedarikIcinUrunSecin.Size = new System.Drawing.Size(205, 21);
            this.cbTedarikIcinUrunSecin.TabIndex = 119;
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
            this.txtAdet.TabIndex = 113;
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
            // cbKategoriSecin
            // 
            this.cbKategoriSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriSecin.FormattingEnabled = true;
            this.cbKategoriSecin.Location = new System.Drawing.Point(158, 18);
            this.cbKategoriSecin.Name = "cbKategoriSecin";
            this.cbKategoriSecin.Size = new System.Drawing.Size(205, 21);
            this.cbKategoriSecin.TabIndex = 110;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(420, 50);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(386, 144);
            this.dgvSiparisler.TabIndex = 126;
            // 
            // btnEkle
            // 
            this.btnEkle.Enabled = false;
            this.btnEkle.Location = new System.Drawing.Point(105, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 127;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.Location = new System.Drawing.Point(216, 209);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(81, 29);
            this.btnVazgec.TabIndex = 128;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
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
            "Tutara göre artan"});
            this.cbSiralama.Location = new System.Drawing.Point(591, 4);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 129;
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
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciSecin);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbTedarikIcinUrunSecin);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriSecin);
            this.Name = "Siparis";
            this.Text = "Siparis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciSecin;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.ComboBox cbTedarikIcinUrunSecin;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox txtBirimAlisFiyati;
        private System.Windows.Forms.Label lblBirimAlisFiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblKategoriSecin;
        private System.Windows.Forms.ComboBox cbKategoriSecin;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Label label1;
    }
}