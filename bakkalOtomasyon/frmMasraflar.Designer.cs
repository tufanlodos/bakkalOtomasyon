namespace PL.Bakkal
{
    partial class frmMasraflar
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
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvMasraflar = new System.Windows.Forms.DataGridView();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasraflar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(64, 22);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(118, 13);
            this.lblSiralamaOlcutu.TabIndex = 115;
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
            this.cbSiralama.Location = new System.Drawing.Point(197, 17);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 114;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 292);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 113;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(99, 292);
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
            this.dgvMasraflar.Location = new System.Drawing.Point(24, 62);
            this.dgvMasraflar.Name = "dgvMasraflar";
            this.dgvMasraflar.Size = new System.Drawing.Size(339, 224);
            this.dgvMasraflar.TabIndex = 0;
            this.dgvMasraflar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasraflar_CellValueChanged);
            this.dgvMasraflar.DoubleClick += new System.EventHandler(this.dgvMasraflar_DoubleClick);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(286, 292);
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
            this.btnDegistir.Location = new System.Drawing.Point(186, 292);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(92, 38);
            this.btnDegistir.TabIndex = 120;
            this.btnDegistir.Text = "Değişiklikleri Kaydet";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Kayıtlı Masraflar";
            // 
            // frmMasraflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.dgvMasraflar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnYeni);
            this.Name = "frmMasraflar";
            this.Text = "Masraf";
            this.Load += new System.EventHandler(this.Masraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasraflar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvMasraflar;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label label1;
    }
}