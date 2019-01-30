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
            this.cbUrunMarkasi = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(160, 278);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(204, 29);
            this.btnEkle.TabIndex = 139;
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
            this.lblTedarikciSecin.Text = "Ürün Adi";
            // 
            // lblTedarikIcinUrunSecin
            // 
            this.lblTedarikIcinUrunSecin.AutoSize = true;
            this.lblTedarikIcinUrunSecin.Location = new System.Drawing.Point(22, 116);
            this.lblTedarikIcinUrunSecin.Name = "lblTedarikIcinUrunSecin";
            this.lblTedarikIcinUrunSecin.Size = new System.Drawing.Size(67, 13);
            this.lblTedarikIcinUrunSecin.TabIndex = 146;
            this.lblTedarikIcinUrunSecin.Text = "ÜrünMarkası";
            // 
            // cbUrunMarkasi
            // 
            this.cbUrunMarkasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunMarkasi.DropDownWidth = 120;
            this.cbUrunMarkasi.FormattingEnabled = true;
            this.cbUrunMarkasi.Location = new System.Drawing.Point(344, 108);
            this.cbUrunMarkasi.Name = "cbUrunMarkasi";
            this.cbUrunMarkasi.Size = new System.Drawing.Size(21, 21);
            this.cbUrunMarkasi.TabIndex = 145;
            this.cbUrunMarkasi.SelectedIndexChanged += new System.EventHandler(this.cbUrunMarkasi_SelectedIndexChanged);
            // 
            // txtBirimSatisFiyati
            // 
            this.txtBirimSatisFiyati.Location = new System.Drawing.Point(160, 224);
            this.txtBirimSatisFiyati.Name = "txtBirimSatisFiyati";
            this.txtBirimSatisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimSatisFiyati.TabIndex = 144;
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
            this.txtBirimAlisFiyati.Location = new System.Drawing.Point(160, 189);
            this.txtBirimAlisFiyati.Name = "txtBirimAlisFiyati";
            this.txtBirimAlisFiyati.Size = new System.Drawing.Size(204, 20);
            this.txtBirimAlisFiyati.TabIndex = 138;
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
            this.cbKategoriAdi.Location = new System.Drawing.Point(344, 70);
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
            this.txtUrunMarkasi.Location = new System.Drawing.Point(161, 109);
            this.txtUrunMarkasi.Name = "txtUrunMarkasi";
            this.txtUrunMarkasi.Size = new System.Drawing.Size(183, 20);
            this.txtUrunMarkasi.TabIndex = 138;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(161, 150);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(203, 20);
            this.txtUrunAdi.TabIndex = 138;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(161, 71);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKategoriAdi.TabIndex = 138;
            this.txtKategoriAdi.TextChanged += new System.EventHandler(this.txtKategoriAdi_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 337);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTedarikciSecin);
            this.Controls.Add(this.lblTedarikIcinUrunSecin);
            this.Controls.Add(this.cbUrunMarkasi);
            this.Controls.Add(this.txtBirimSatisFiyati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBirimAlisFiyati);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunMarkasi);
            this.Controls.Add(this.txtBirimAlisFiyati);
            this.Controls.Add(this.lblKategoriSecin);
            this.Controls.Add(this.cbKategoriAdi);
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
        private System.Windows.Forms.ComboBox cbUrunMarkasi;
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
    }
}