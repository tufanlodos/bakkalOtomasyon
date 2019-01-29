namespace PL.Bakkal
{
    partial class frmKategoriler
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
            this.btnYeni = new System.Windows.Forms.Button();
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
            this.dgvKategori.Location = new System.Drawing.Point(21, 43);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategori.Size = new System.Drawing.Size(440, 156);
            this.dgvKategori.TabIndex = 33;
            this.dgvKategori.DoubleClick += new System.EventHandler(this.dgvKategori_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(230, 216);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(21, 216);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(126, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(112, 20);
            this.txtArama.TabIndex = 0;
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
            this.btnVazgec.Location = new System.Drawing.Point(317, 216);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(86, 29);
            this.btnVazgec.TabIndex = 57;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(108, 217);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 28);
            this.btnGuncelle.TabIndex = 58;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 296);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblKategoriAdiGiriniz);
            this.Controls.Add(this.dgvKategori);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
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
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblKategoriAdiGiriniz;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnGuncelle;
    }
}