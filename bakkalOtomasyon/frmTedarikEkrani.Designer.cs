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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIslemiKaydet = new System.Windows.Forms.Button();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbTedarikIcinUrunSecin = new System.Windows.Forms.ComboBox();
            this.lblTedarikEdilmisUrunler = new System.Windows.Forms.Label();
            this.lvTedarikEdilmisUrunler = new System.Windows.Forms.ListView();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.lblTelefonNumarasi = new System.Windows.Forms.Label();
            this.lblTedarikciSecin = new System.Windows.Forms.Label();
            this.cbTedarikciSecin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(446, 367);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 29);
            this.btnGuncelle.TabIndex = 112;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(547, 319);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(202, 20);
            this.txtToplamTutar.TabIndex = 111;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(434, 326);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 110;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Location = new System.Drawing.Point(438, 194);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(324, 97);
            this.lvUrunler.TabIndex = 109;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(560, 159);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(202, 20);
            this.txtBirimFiyat.TabIndex = 108;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(435, 159);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(54, 13);
            this.lblBirimFiyat.TabIndex = 107;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(560, 123);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(202, 20);
            this.txtAdet.TabIndex = 106;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(435, 123);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 105;
            this.lblAdet.Text = "Adet";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(533, 367);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 104;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnIslemiKaydet
            // 
            this.btnIslemiKaydet.Enabled = false;
            this.btnIslemiKaydet.Location = new System.Drawing.Point(620, 367);
            this.btnIslemiKaydet.Name = "btnIslemiKaydet";
            this.btnIslemiKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnIslemiKaydet.TabIndex = 103;
            this.btnIslemiKaydet.Text = "İşlemi Kaydet";
            this.btnIslemiKaydet.UseVisualStyleBackColor = true;
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(435, 55);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(119, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 102;
            this.lblTedarikIcinUrunSecin.Text = "Tedarik İçin Ürün Seçin";
            // 
            // cbTedarikIcinUrunSecin
            // 
            this.cbTedarikIcinUrunSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikIcinUrunSecin.FormattingEnabled = true;
            this.cbTedarikIcinUrunSecin.Location = new System.Drawing.Point(438, 80);
            this.cbTedarikIcinUrunSecin.Name = "cbTedarikIcinUrunSecin";
            this.cbTedarikIcinUrunSecin.Size = new System.Drawing.Size(162, 21);
            this.cbTedarikIcinUrunSecin.TabIndex = 101;
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
            // lvTedarikEdilmisUrunler
            // 
            this.lvTedarikEdilmisUrunler.Location = new System.Drawing.Point(163, 242);
            this.lvTedarikEdilmisUrunler.Name = "lvTedarikEdilmisUrunler";
            this.lvTedarikEdilmisUrunler.Size = new System.Drawing.Size(202, 97);
            this.lvTedarikEdilmisUrunler.TabIndex = 99;
            this.lvTedarikEdilmisUrunler.UseCompatibleStateImageBehavior = false;
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
            // 
            // frmTedarikEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
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
            this.Controls.Add(this.lvTedarikEdilmisUrunler);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtTelefonNumarasi);
            this.Controls.Add(this.lblTelefonNumarasi);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciSecin);
            this.Name = "frmTedarikEkrani";
            this.Text = "TedarikEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
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
        private System.Windows.Forms.ListView lvTedarikEdilmisUrunler;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtTelefonNumarasi;
        private System.Windows.Forms.Label lblTelefonNumarasi;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciSecin;
    }
}