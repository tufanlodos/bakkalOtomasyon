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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbTedarikIcinUrunSecin = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lvSiparisListe = new System.Windows.Forms.ListView();
            this.txtBirimAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblBirimAlisFiyati = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblKategoriSecin = new System.Windows.Forms.Label();
            this.cbKategoriSecin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(105, 380);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 29);
            this.btnGuncelle.TabIndex = 125;
            this.btnGuncelle.Text = "Güncelle";
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
            this.cbTedarikciSecin.Location = new System.Drawing.Point(201, 97);
            this.cbTedarikciSecin.Name = "cbTedarikciSecin";
            this.cbTedarikciSecin.Size = new System.Drawing.Size(162, 21);
            this.cbTedarikciSecin.TabIndex = 123;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(192, 380);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 122;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(281, 380);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 121;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
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
            this.cbTedarikIcinUrunSecin.Location = new System.Drawing.Point(201, 56);
            this.cbTedarikIcinUrunSecin.Name = "cbTedarikIcinUrunSecin";
            this.cbTedarikIcinUrunSecin.Size = new System.Drawing.Size(162, 21);
            this.cbTedarikIcinUrunSecin.TabIndex = 119;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(105, 343);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(257, 20);
            this.txtToplamTutar.TabIndex = 118;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(21, 347);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 117;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lvSiparisListe
            // 
            this.lvSiparisListe.Location = new System.Drawing.Point(23, 220);
            this.lvSiparisListe.Name = "lvSiparisListe";
            this.lvSiparisListe.Size = new System.Drawing.Size(340, 97);
            this.lvSiparisListe.TabIndex = 116;
            this.lvSiparisListe.UseCompatibleStateImageBehavior = false;
            // 
            // txtBirimAlisFiyati
            // 
            this.txtBirimAlisFiyati.Location = new System.Drawing.Point(201, 180);
            this.txtBirimAlisFiyati.Name = "txtBirimAlisFiyati";
            this.txtBirimAlisFiyati.ReadOnly = true;
            this.txtBirimAlisFiyati.Size = new System.Drawing.Size(161, 20);
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
            this.txtAdet.Location = new System.Drawing.Point(201, 144);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(161, 20);
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
            this.cbKategoriSecin.Location = new System.Drawing.Point(201, 18);
            this.cbKategoriSecin.Name = "cbKategoriSecin";
            this.cbKategoriSecin.Size = new System.Drawing.Size(162, 21);
            this.cbKategoriSecin.TabIndex = 110;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 419);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciSecin);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbTedarikIcinUrunSecin);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lvSiparisListe);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriSecin);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciSecin;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.ComboBox cbTedarikIcinUrunSecin;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListView lvSiparisListe;
        private System.Windows.Forms.TextBox txtBirimAlisFiyati;
        private System.Windows.Forms.Label lblBirimAlisFiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblKategoriSecin;
        private System.Windows.Forms.ComboBox cbKategoriSecin;
    }
}