﻿namespace PL.Bakkal
{
    partial class frmUrunIslemleri
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
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.lblUrunSecin = new System.Windows.Forms.Label();
            this.cbKategoriSec = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblUrunAdiGiriniz = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(83, 366);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 52;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(203, 277);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 72);
            this.txtAciklama.TabIndex = 48;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(78, 280);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 47;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(203, 248);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(202, 20);
            this.txtUrunAdi.TabIndex = 46;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(78, 248);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAdi.TabIndex = 45;
            this.lblUrunAdi.Text = "Ürün Adı ";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(21, 104);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(823, 125);
            this.dgvUrunler.TabIndex = 44;
            // 
            // lblUrunSecin
            // 
            this.lblUrunSecin.AutoSize = true;
            this.lblUrunSecin.Location = new System.Drawing.Point(20, 49);
            this.lblUrunSecin.Name = "lblUrunSecin";
            this.lblUrunSecin.Size = new System.Drawing.Size(76, 13);
            this.lblUrunSecin.TabIndex = 43;
            this.lblUrunSecin.Text = "Kategori Seçin";
            // 
            // cbKategoriSec
            // 
            this.cbKategoriSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriSec.FormattingEnabled = true;
            this.cbKategoriSec.Location = new System.Drawing.Point(150, 45);
            this.cbKategoriSec.Name = "cbKategoriSec";
            this.cbKategoriSec.Size = new System.Drawing.Size(172, 21);
            this.cbKategoriSec.TabIndex = 42;
            this.cbKategoriSec.SelectedIndexChanged += new System.EventHandler(this.cbKategoriSec_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(443, 42);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(130, 20);
            this.txtArama.TabIndex = 54;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblUrunAdiGiriniz
            // 
            this.lblUrunAdiGiriniz.AutoSize = true;
            this.lblUrunAdiGiriniz.Location = new System.Drawing.Point(358, 45);
            this.lblUrunAdiGiriniz.Name = "lblUrunAdiGiriniz";
            this.lblUrunAdiGiriniz.Size = new System.Drawing.Size(79, 13);
            this.lblUrunAdiGiriniz.TabIndex = 53;
            this.lblUrunAdiGiriniz.Text = "Ürün Adı Giriniz";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(257, 365);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(92, 38);
            this.btnDegistir.TabIndex = 123;
            this.btnDegistir.Text = "Değişiklikleri Kaydet";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(357, 365);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 29);
            this.btnVazgec.TabIndex = 122;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(170, 365);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 121;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(18, 84);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(118, 13);
            this.lblSiralamaOlcutu.TabIndex = 125;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü Seçiniz";
            // 
            // cbSiralama
            // 
            this.cbSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Items.AddRange(new object[] {
            "Ürün İsmine Göre : A->Z",
            "Ürün İsmine Göre : Z->A",
            "Kategori İsmine Göre : A->Z",
            "Kategori İsmine Göre : Z->A",
            "Stok Miktarına Göre : Önce En Düşük",
            "Stok Miktarına Göre : Önce En Yüksek"});
            this.cbSiralama.Location = new System.Drawing.Point(151, 79);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(171, 21);
            this.cbSiralama.TabIndex = 124;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // frmUrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 431);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblUrunAdiGiriniz);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.lblUrunSecin);
            this.Controls.Add(this.cbKategoriSec);
            this.Name = "frmUrunIslemleri";
            this.Text = "UrunIslemleri";
            this.Load += new System.EventHandler(this.frmUrunIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label lblUrunSecin;
        private System.Windows.Forms.ComboBox cbKategoriSec;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblUrunAdiGiriniz;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
    }
}