namespace PL.Bakkal
{
    partial class Masraf
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
            this.lvListe = new System.Windows.Forms.ListView();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtMasrafTutari = new System.Windows.Forms.TextBox();
            this.lblMasrafTutari = new System.Windows.Forms.Label();
            this.txtMasrafAdi = new System.Windows.Forms.TextBox();
            this.lblMasrafAdi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListe
            // 
            this.lvListe.Location = new System.Drawing.Point(12, 51);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(354, 128);
            this.lvListe.TabIndex = 117;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(15, 21);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(121, 13);
            this.lblSiralamaOlcutu.TabIndex = 115;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü Seçiniz.";
            // 
            // cbSiralama
            // 
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Location = new System.Drawing.Point(148, 14);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 114;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(281, 267);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 113;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtMasrafTutari
            // 
            this.txtMasrafTutari.Location = new System.Drawing.Point(146, 233);
            this.txtMasrafTutari.Name = "txtMasrafTutari";
            this.txtMasrafTutari.Size = new System.Drawing.Size(216, 20);
            this.txtMasrafTutari.TabIndex = 112;
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
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(107, 267);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 29);
            this.btnGuncelle.TabIndex = 119;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(194, 267);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 118;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // Masraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 317);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lvListe);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMasrafTutari);
            this.Controls.Add(this.lblMasrafTutari);
            this.Controls.Add(this.txtMasrafAdi);
            this.Controls.Add(this.lblMasrafAdi);
            this.Name = "Masraf";
            this.Text = "Masraf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMasrafTutari;
        private System.Windows.Forms.Label lblMasrafTutari;
        private System.Windows.Forms.TextBox txtMasrafAdi;
        private System.Windows.Forms.Label lblMasrafAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}