namespace PL.Bakkal
{
    partial class MasrafKayit
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
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtMasrafTutari = new System.Windows.Forms.TextBox();
            this.lblMasrafTutari = new System.Windows.Forms.Label();
            this.txtMasrafAdi = new System.Windows.Forms.TextBox();
            this.lblMasrafAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvMasraflar = new System.Windows.Forms.DataGridView();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasraflar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(24, 16);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(118, 13);
            this.lblSiralamaOlcutu.TabIndex = 115;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü Seçiniz";
            // 
            // cbSiralama
            // 
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Location = new System.Drawing.Point(157, 11);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 114;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 267);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 113;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMasrafTutari
            // 
            this.txtMasrafTutari.Location = new System.Drawing.Point(146, 233);
            this.txtMasrafTutari.Name = "txtMasrafTutari";
            this.txtMasrafTutari.Size = new System.Drawing.Size(216, 20);
            this.txtMasrafTutari.TabIndex = 112;
            this.txtMasrafTutari.TextChanged += new System.EventHandler(this.txtMasrafTutari_TextChanged);
            // 
            // lblMasrafTutari
            // 
            this.lblMasrafTutari.AutoSize = true;
            this.lblMasrafTutari.Location = new System.Drawing.Point(21, 233);
            this.lblMasrafTutari.Name = "lblMasrafTutari";
            this.lblMasrafTutari.Size = new System.Drawing.Size(69, 13);
            this.lblMasrafTutari.TabIndex = 111;
            this.lblMasrafTutari.Text = "Masraf Tutarı";
            // 
            // txtMasrafAdi
            // 
            this.txtMasrafAdi.Location = new System.Drawing.Point(146, 196);
            this.txtMasrafAdi.Name = "txtMasrafAdi";
            this.txtMasrafAdi.Size = new System.Drawing.Size(216, 20);
            this.txtMasrafAdi.TabIndex = 110;
            this.txtMasrafAdi.TextChanged += new System.EventHandler(this.txtMasrafAdi_TextChanged);
            // 
            // lblMasrafAdi
            // 
            this.lblMasrafAdi.AutoSize = true;
            this.lblMasrafAdi.Location = new System.Drawing.Point(21, 196);
            this.lblMasrafAdi.Name = "lblMasrafAdi";
            this.lblMasrafAdi.Size = new System.Drawing.Size(57, 13);
            this.lblMasrafAdi.TabIndex = 109;
            this.lblMasrafAdi.Text = "Masraf Adı";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(99, 267);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 118;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvMasraflar
            // 
            this.dgvMasraflar.AllowUserToAddRows = false;
            this.dgvMasraflar.AllowUserToDeleteRows = false;
            this.dgvMasraflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasraflar.Location = new System.Drawing.Point(24, 37);
            this.dgvMasraflar.Name = "dgvMasraflar";
            this.dgvMasraflar.Size = new System.Drawing.Size(339, 150);
            this.dgvMasraflar.TabIndex = 0;
            this.dgvMasraflar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasraflar_CellValueChanged);
            this.dgvMasraflar.DoubleClick += new System.EventHandler(this.dgvMasraflar_DoubleClick);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(286, 267);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 29);
            this.btnVazgec.TabIndex = 119;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(186, 267);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(92, 38);
            this.btnDegistir.TabIndex = 120;
            this.btnDegistir.Text = "Değişiklikleri Kaydet";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // MasrafKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.dgvMasraflar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMasrafTutari);
            this.Controls.Add(this.lblMasrafTutari);
            this.Controls.Add(this.txtMasrafAdi);
            this.Controls.Add(this.lblMasrafAdi);
            this.Name = "MasrafKayit";
            this.Text = "Masraf";
            this.Load += new System.EventHandler(this.Masraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasraflar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMasrafTutari;
        private System.Windows.Forms.Label lblMasrafTutari;
        private System.Windows.Forms.TextBox txtMasrafAdi;
        private System.Windows.Forms.Label lblMasrafAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvMasraflar;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnDegistir;
    }
}