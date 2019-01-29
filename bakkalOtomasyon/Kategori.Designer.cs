namespace PL.Bakkal
{
    partial class Kategori
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
            this.dgvKategori = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblKategoriAdi = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblKategoriAdiGiriniz = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKategori
            // 
            this.dgvKategori.AllowUserToAddRows = false;
            this.dgvKategori.AllowUserToDeleteRows = false;
            this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategori.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvKategori.Location = new System.Drawing.Point(93, 71);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategori.Size = new System.Drawing.Size(440, 156);
            this.dgvKategori.TabIndex = 33;
            this.dgvKategori.DoubleClick += new System.EventHandler(this.dgvKategori_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(243, 351);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(156, 351);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(189, 262);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 72);
            this.txtAciklama.TabIndex = 29;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(64, 265);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 28;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(189, 233);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(202, 20);
            this.txtKategoriAdi.TabIndex = 27;
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.Location = new System.Drawing.Point(64, 233);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(67, 13);
            this.lblKategoriAdi.TabIndex = 26;
            this.lblKategoriAdi.Text = "Kategori Adı ";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(126, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(112, 20);
            this.txtArama.TabIndex = 56;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblKategoriAdiGiriniz
            // 
            this.lblKategoriAdiGiriniz.AutoSize = true;
            this.lblKategoriAdiGiriniz.Location = new System.Drawing.Point(18, 15);
            this.lblKategoriAdiGiriniz.Name = "lblKategoriAdiGiriniz";
            this.lblKategoriAdiGiriniz.Size = new System.Drawing.Size(95, 13);
            this.lblKategoriAdiGiriniz.TabIndex = 55;
            this.lblKategoriAdiGiriniz.Text = "Kategori Adı Giriniz";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(330, 354);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 57;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(75, 354);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 58;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 489);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblKategoriAdiGiriniz);
            this.Controls.Add(this.dgvKategori);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.lblKategoriAdi);
            this.Name = "Kategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKategori;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label lblKategoriAdi;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblKategoriAdiGiriniz;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnGuncelle;
    }
}