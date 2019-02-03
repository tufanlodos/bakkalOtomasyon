namespace PL.Bakkal
{
    partial class frmUrunEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTedarikciSecin = new System.Windows.Forms.Label();
            this.lblTedarikIcinUrunSecin = new System.Windows.Forms.Label();
            this.txtBirimSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblBirimAlisFiyati = new System.Windows.Forms.Label();
            this.txtBirimAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblKategoriSecin = new System.Windows.Forms.Label();
            this.cbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunMarkasi = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(127, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(204, 29);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTedarikciSecin
            // 
            this.lblTedarikciSecin.AutoSize = true;
            this.lblTedarikciSecin.Location = new System.Drawing.Point(22, 157);
            this.lblTedarikciSecin.Name = "lblTedarikciSecin";
            this.lblTedarikciSecin.Size = new System.Drawing.Size(48, 13);
            this.lblTedarikciSecin.TabIndex = 148;
            this.lblTedarikciSecin.Text = "Ürün Adı";
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(22, 116);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(70, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 146;
            this.lblTedarikIcinUrunSecin.Text = "Ürün Markası";
            // 
            // txtBirimSatisFiyati
            // 
            this.txtBirimSatisFiyati.Location = new System.Drawing.Point(126, 224);
            this.txtBirimSatisFiyati.Name = "txtBirimSatisFiyati";
            this.txtBirimSatisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimSatisFiyati.TabIndex = 5;
            this.txtBirimSatisFiyati.TextChanged += new System.EventHandler(this.txtBirimSatisFiyati_TextChanged);
            // 
            // lblBirimAlisFiyati
            // 
            this.lblBirimAlisFiyati.AutoSize = true;
            this.lblBirimAlisFiyati.Location = new System.Drawing.Point(22, 196);
            this.lblBirimAlisFiyati.Name = "lblBirimAlisFiyati";
            this.lblBirimAlisFiyati.Size = new System.Drawing.Size(75, 13);
            this.lblBirimAlisFiyati.TabIndex = 143;
            this.lblBirimAlisFiyati.Text = "Birim Alış Fiyatı";
            // 
            // txtBirimAlisFiyati
            // 
            this.txtBirimAlisFiyati.Location = new System.Drawing.Point(126, 189);
            this.txtBirimAlisFiyati.Name = "txtBirimAlisFiyati";
            this.txtBirimAlisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimAlisFiyati.TabIndex = 4;
            this.txtBirimAlisFiyati.TextChanged += new System.EventHandler(this.txtBirimAlisFiyati_TextChanged);
            // 
            // lblKategoriSecin
            // 
            this.lblKategoriSecin.AutoSize = true;
            this.lblKategoriSecin.Location = new System.Drawing.Point(22, 75);
            this.lblKategoriSecin.Name = "lblKategoriSecin";
            this.lblKategoriSecin.Size = new System.Drawing.Size(64, 13);
            this.lblKategoriSecin.TabIndex = 141;
            this.lblKategoriSecin.Text = "Kategori Adi";
            // 
            // cbKategoriAdi
            // 
            this.cbKategoriAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriAdi.DropDownWidth = 120;
            this.cbKategoriAdi.FormattingEnabled = true;
            this.cbKategoriAdi.Location = new System.Drawing.Point(310, 70);
            this.cbKategoriAdi.Name = "cbKategoriAdi";
            this.cbKategoriAdi.Size = new System.Drawing.Size(21, 21);
            this.cbKategoriAdi.TabIndex = 140;
            this.cbKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cbKategoriAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Birim Satış Fiyatı";
            // 
            // txtUrunMarkasi
            // 
            this.txtUrunMarkasi.Location = new System.Drawing.Point(127, 109);
            this.txtUrunMarkasi.Name = "txtUrunMarkasi";
            this.txtUrunMarkasi.Size = new System.Drawing.Size(203, 20);
            this.txtUrunMarkasi.TabIndex = 2;
            this.txtUrunMarkasi.TextChanged += new System.EventHandler(this.txtUrunMarkasi_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(127, 150);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(203, 20);
            this.txtUrunAdi.TabIndex = 3;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(127, 71);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.ReadOnly = true;
            this.txtKategoriAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(127, 260);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(204, 20);
            this.txtAdet.TabIndex = 6;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "ÜRÜN EKLEME EKRANI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKategori.Location = new System.Drawing.Point(337, 67);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(94, 26);
            this.btnYeniKategori.TabIndex = 151;
            this.btnYeniKategori.Text = "Yeni Kategori";
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(443, 29);
            this.formKapatici1.TabIndex = 149;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 337);
            this.Controls.Add(this.btnYeniKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formKapatici1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBirimSatisFiyati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunMarkasi);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunEkle";
            this.Text = "frmUrunEkle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblTedarikciSecin;
        private System.Windows.Forms.Label lblTedarikIcinUrunSecin;
        private System.Windows.Forms.TextBox txtBirimSatisFiyati;
        private System.Windows.Forms.Label lblBirimAlisFiyati;
        private System.Windows.Forms.TextBox txtBirimAlisFiyati;
        private System.Windows.Forms.Label lblKategoriSecin;
        private System.Windows.Forms.ComboBox cbKategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunMarkasi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniKategori;
    }
}