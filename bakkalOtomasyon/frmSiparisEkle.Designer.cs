namespace PL.Bakkal
{
    partial class frmSiparisEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTedarikciSecin = new System.Windows.Forms.Label();
            this.cbTedarikciler = new System.Windows.Forms.ComboBox();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.txtBirimAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblBirimAlisFiyati = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblKategoriSecin = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            this.btnYeniUrun = new System.Windows.Forms.Button();
            this.btnYeniTedarikci = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "SİPARİŞ EKLEME EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(255, 248);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTedarikciSecin
            // 
            this.lblTedarikciSecin.AutoSize = true;
            this.lblTedarikciSecin.Location = new System.Drawing.Point(64, 155);
            this.lblTedarikciSecin.Name = "lblTedarikciSecin";
            this.lblTedarikciSecin.Size = new System.Drawing.Size(81, 13);
            this.lblTedarikciSecin.TabIndex = 137;
            this.lblTedarikciSecin.Text = "Tedarikçi Seçin";
            // 
            // cbTedarikciler
            // 
            this.cbTedarikciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTedarikciler.FormattingEnabled = true;
            this.cbTedarikciler.Location = new System.Drawing.Point(202, 147);
            this.cbTedarikciler.Name = "cbTedarikciler";
            this.cbTedarikciler.Size = new System.Drawing.Size(205, 21);
            this.cbTedarikciler.TabIndex = 136;
            this.cbTedarikciler.SelectedIndexChanged += new System.EventHandler(this.cbTedarikciler_SelectedIndexChanged);
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(64, 114);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(60, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 135;
            this.lblTedarikIcinUrunSecin.Text = "Ürün Seçin";
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(202, 106);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(205, 21);
            this.cbUrunler.TabIndex = 134;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            // 
            // txtBirimAlisFiyati
            // 
            this.txtBirimAlisFiyati.Location = new System.Drawing.Point(202, 222);
            this.txtBirimAlisFiyati.Name = "txtBirimAlisFiyati";
            this.txtBirimAlisFiyati.ReadOnly = true;
            this.txtBirimAlisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimAlisFiyati.TabIndex = 133;
            // 
            // lblBirimAlisFiyati
            // 
            this.lblBirimAlisFiyati.AutoSize = true;
            this.lblBirimAlisFiyati.Location = new System.Drawing.Point(66, 222);
            this.lblBirimAlisFiyati.Name = "lblBirimAlisFiyati";
            this.lblBirimAlisFiyati.Size = new System.Drawing.Size(75, 13);
            this.lblBirimAlisFiyati.TabIndex = 132;
            this.lblBirimAlisFiyati.Text = "Birim Alış Fiyatı";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(202, 187);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(204, 20);
            this.txtAdet.TabIndex = 0;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(66, 190);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 131;
            this.lblAdet.Text = "Adet";
            // 
            // lblKategoriSecin
            // 
            this.lblKategoriSecin.AutoSize = true;
            this.lblKategoriSecin.Location = new System.Drawing.Point(64, 73);
            this.lblKategoriSecin.Name = "lblKategoriSecin";
            this.lblKategoriSecin.Size = new System.Drawing.Size(76, 13);
            this.lblKategoriSecin.TabIndex = 130;
            this.lblKategoriSecin.Text = "Kategori Seçin";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(202, 68);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(205, 21);
            this.cbKategoriler.TabIndex = 129;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.Location = new System.Drawing.Point(413, 68);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(107, 21);
            this.btnYeniKategori.TabIndex = 138;
            this.btnYeniKategori.Text = "Yeni Kategori";
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.Location = new System.Drawing.Point(413, 106);
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.Size = new System.Drawing.Size(107, 21);
            this.btnYeniUrun.TabIndex = 139;
            this.btnYeniUrun.Text = "Yeni Ürün";
            this.btnYeniUrun.UseVisualStyleBackColor = true;
            this.btnYeniUrun.Click += new System.EventHandler(this.btnYeniUrun_Click);
            // 
            // btnYeniTedarikci
            // 
            this.btnYeniTedarikci.Location = new System.Drawing.Point(413, 147);
            this.btnYeniTedarikci.Name = "btnYeniTedarikci";
            this.btnYeniTedarikci.Size = new System.Drawing.Size(107, 21);
            this.btnYeniTedarikci.TabIndex = 140;
            this.btnYeniTedarikci.Text = "Yeni Tedarikçi";
            this.btnYeniTedarikci.UseVisualStyleBackColor = true;
            this.btnYeniTedarikci.Click += new System.EventHandler(this.btnYeniTedarikci_Click);
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(551, 29);
            this.formKapatici1.TabIndex = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 307);
            this.Controls.Add(this.btnYeniTedarikci);
            this.Controls.Add(this.btnYeniUrun);
            this.Controls.Add(this.btnYeniKategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.cbTedarikciler);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbUrunler);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisEkle";
            this.Text = "frmSiparisEkle";
            this.Load += new System.EventHandler(this.frmSiparisEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.ComboBox cbTedarikciler;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.TextBox txtBirimAlisFiyati;
        private System.Windows.Forms.Label lblBirimAlisFiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblKategoriSecin;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Button btnYeniKategori;
        private System.Windows.Forms.Button btnYeniUrun;
        private System.Windows.Forms.Button btnYeniTedarikci;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}