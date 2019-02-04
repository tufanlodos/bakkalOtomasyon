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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(420, 301);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 29);
            this.btnGuncelle.TabIndex = 125;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(302, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 29);
            this.btnSil.TabIndex = 122;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(319, 343);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(257, 20);
            this.txtToplamTutar.TabIndex = 118;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(196, 346);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(117, 13);
            this.lblToplamTutar.TabIndex = 117;
            this.lblToplamTutar.Text = "Bekleyen Toplam Tutar";
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(150, 151);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(546, 144);
            this.dgvSiparisler.TabIndex = 126;
            this.dgvSiparisler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellDoubleClick);
            this.dgvSiparisler.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellValueChanged);
            this.dgvSiparisler.DoubleClick += new System.EventHandler(this.dgvSiparisler_DoubleClick);
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(186, 107);
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
            this.cbSiralama.Location = new System.Drawing.Point(319, 102);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 0;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Kayıtlı Siparişler";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(545, 301);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 29);
            this.btnVazgec.TabIndex = 132;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(216, 301);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(748, 29);
            this.formKapatici1.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "SİPARİŞLER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnYeni;
        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
    }
}