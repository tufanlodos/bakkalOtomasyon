namespace PL.Bakkal
{
    partial class frmKategoriEkle
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
            this.components = new System.ComponentModel.Container();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblMasrafTutari = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblMasrafAdi = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(454, 29);
            this.formKapatici1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "KATEGORİ EKLEME EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(187, 151);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(169, 108);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(216, 20);
            this.txtAciklama.TabIndex = 126;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // lblMasrafTutari
            // 
            this.lblMasrafTutari.AutoSize = true;
            this.lblMasrafTutari.Location = new System.Drawing.Point(44, 108);
            this.lblMasrafTutari.Name = "lblMasrafTutari";
            this.lblMasrafTutari.Size = new System.Drawing.Size(50, 13);
            this.lblMasrafTutari.TabIndex = 125;
            this.lblMasrafTutari.Text = "Açıklama";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(169, 71);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(216, 20);
            this.txtKategoriAdi.TabIndex = 0;
            this.txtKategoriAdi.TextChanged += new System.EventHandler(this.txtKategoriAdi_TextChanged);
            // 
            // lblMasrafAdi
            // 
            this.lblMasrafAdi.AutoSize = true;
            this.lblMasrafAdi.Location = new System.Drawing.Point(44, 71);
            this.lblMasrafAdi.Name = "lblMasrafAdi";
            this.lblMasrafAdi.Size = new System.Drawing.Size(64, 13);
            this.lblMasrafAdi.TabIndex = 123;
            this.lblMasrafAdi.Text = "Kategori Adı";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 228);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblMasrafTutari);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.lblMasrafAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKategoriEkle";
            this.Text = "frmKategoriEkle";
            this.Load += new System.EventHandler(this.frmKategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblMasrafTutari;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label lblMasrafAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}