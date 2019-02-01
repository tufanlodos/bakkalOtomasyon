namespace PL.Bakkal
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
            this.lblUrunSecin = new System.Windows.Forms.Label();
            this.cbKategoriSec = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblUrunAdiGiriniz = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(21, 259);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(92, 38);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblUrunSecin
            // 
            this.lblUrunSecin.AutoSize = true;
            this.lblUrunSecin.Location = new System.Drawing.Point(20, 57);
            this.lblUrunSecin.Name = "lblUrunSecin";
            this.lblUrunSecin.Size = new System.Drawing.Size(76, 13);
            this.lblUrunSecin.TabIndex = 43;
            this.lblUrunSecin.Text = "Kategori Seçin";
            // 
            // cbKategoriSec
            // 
            this.cbKategoriSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriSec.FormattingEnabled = true;
            this.cbKategoriSec.Location = new System.Drawing.Point(150, 53);
            this.cbKategoriSec.Name = "cbKategoriSec";
            this.cbKategoriSec.Size = new System.Drawing.Size(214, 21);
            this.cbKategoriSec.TabIndex = 0;
            this.cbKategoriSec.SelectedIndexChanged += new System.EventHandler(this.cbKategoriSec_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(477, 70);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(130, 20);
            this.txtArama.TabIndex = 54;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblUrunAdiGiriniz
            // 
            this.lblUrunAdiGiriniz.AutoSize = true;
            this.lblUrunAdiGiriniz.Location = new System.Drawing.Point(474, 53);
            this.lblUrunAdiGiriniz.Name = "lblUrunAdiGiriniz";
            this.lblUrunAdiGiriniz.Size = new System.Drawing.Size(79, 13);
            this.lblUrunAdiGiriniz.TabIndex = 53;
            this.lblUrunAdiGiriniz.Text = "Ürün Adı Giriniz";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(242, 259);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(92, 38);
            this.btnDegistir.TabIndex = 123;
            this.btnDegistir.Text = "Değişiklikleri Kaydet";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(345, 259);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(92, 38);
            this.btnVazgec.TabIndex = 122;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(134, 259);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 38);
            this.btnSil.TabIndex = 121;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(18, 85);
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
            this.cbSiralama.Location = new System.Drawing.Point(151, 80);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(213, 21);
            this.cbSiralama.TabIndex = 1;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 111);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(600, 139);
            this.dgvUrunler.TabIndex = 126;
            this.dgvUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellDoubleClick);
            this.dgvUrunler.DoubleClick += new System.EventHandler(this.dgvUrunler_DoubleClick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(752, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "ÜRÜN İŞLEMLERİ EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(752, 29);
            this.formKapatici1.TabIndex = 127;
            // 
            // frmUrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblUrunAdiGiriniz);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblUrunSecin);
            this.Controls.Add(this.cbKategoriSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunIslemleri";
            this.Text = "UrunIslemleri";
            this.Load += new System.EventHandler(this.frmUrunIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblUrunSecin;
        private System.Windows.Forms.ComboBox cbKategoriSec;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblUrunAdiGiriniz;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
    }
}