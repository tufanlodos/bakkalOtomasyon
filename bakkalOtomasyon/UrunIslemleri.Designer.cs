namespace PL.Bakkal
{
    partial class UrunIslemleri
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.lblUrunSecin = new System.Windows.Forms.Label();
            this.cbUrunSecin = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblUrunAdiGiriniz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(83, 346);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 52;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(344, 346);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(257, 346);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(81, 29);
            this.btnDegistir.TabIndex = 50;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(170, 346);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 49;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(203, 257);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 72);
            this.txtAciklama.TabIndex = 48;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(78, 260);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 47;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(203, 228);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(202, 20);
            this.txtUrunAdi.TabIndex = 46;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(78, 228);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAdi.TabIndex = 45;
            this.lblUrunAdi.Text = "Ürün Adı ";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(23, 85);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(502, 125);
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
            // cbUrunSecin
            // 
            this.cbUrunSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunSecin.FormattingEnabled = true;
            this.cbUrunSecin.Location = new System.Drawing.Point(102, 45);
            this.cbUrunSecin.Name = "cbUrunSecin";
            this.cbUrunSecin.Size = new System.Drawing.Size(122, 21);
            this.cbUrunSecin.TabIndex = 42;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(413, 46);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(112, 20);
            this.txtArama.TabIndex = 54;
            // 
            // lblUrunAdiGiriniz
            // 
            this.lblUrunAdiGiriniz.AutoSize = true;
            this.lblUrunAdiGiriniz.Location = new System.Drawing.Point(328, 49);
            this.lblUrunAdiGiriniz.Name = "lblUrunAdiGiriniz";
            this.lblUrunAdiGiriniz.Size = new System.Drawing.Size(79, 13);
            this.lblUrunAdiGiriniz.TabIndex = 53;
            this.lblUrunAdiGiriniz.Text = "Ürün Adı Giriniz";
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 431);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblUrunAdiGiriniz);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.lblUrunSecin);
            this.Controls.Add(this.cbUrunSecin);
            this.Name = "UrunIslemleri";
            this.Text = "UrunIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label lblUrunSecin;
        private System.Windows.Forms.ComboBox cbUrunSecin;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblUrunAdiGiriniz;
    }
}