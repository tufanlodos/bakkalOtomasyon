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
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtMasrafTutari = new System.Windows.Forms.TextBox();
            this.lblMasrafTutari = new System.Windows.Forms.Label();
            this.txtMasrafAdi = new System.Windows.Forms.TextBox();
            this.lblMasrafAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvListe
            // 
            this.lvListe.Location = new System.Drawing.Point(144, 251);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(222, 82);
            this.lvListe.TabIndex = 117;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Enabled = false;
            this.btnGoruntule.Location = new System.Drawing.Point(144, 216);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(81, 29);
            this.btnGoruntule.TabIndex = 116;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(19, 175);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(81, 13);
            this.lblSiralamaOlcutu.TabIndex = 115;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü";
            // 
            // cbSiralama
            // 
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Location = new System.Drawing.Point(144, 175);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 114;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(144, 112);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 113;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtMasrafTutari
            // 
            this.txtMasrafTutari.Location = new System.Drawing.Point(144, 70);
            this.txtMasrafTutari.Name = "txtMasrafTutari";
            this.txtMasrafTutari.Size = new System.Drawing.Size(202, 20);
            this.txtMasrafTutari.TabIndex = 112;
            // 
            // lblMasrafTutari
            // 
            this.lblMasrafTutari.AutoSize = true;
            this.lblMasrafTutari.Location = new System.Drawing.Point(19, 70);
            this.lblMasrafTutari.Name = "lblMasrafTutari";
            this.lblMasrafTutari.Size = new System.Drawing.Size(69, 13);
            this.lblMasrafTutari.TabIndex = 111;
            this.lblMasrafTutari.Text = "Masraf Tutarı";
            // 
            // txtMasrafAdi
            // 
            this.txtMasrafAdi.Location = new System.Drawing.Point(144, 19);
            this.txtMasrafAdi.Name = "txtMasrafAdi";
            this.txtMasrafAdi.Size = new System.Drawing.Size(202, 20);
            this.txtMasrafAdi.TabIndex = 110;
            // 
            // lblMasrafAdi
            // 
            this.lblMasrafAdi.AutoSize = true;
            this.lblMasrafAdi.Location = new System.Drawing.Point(19, 19);
            this.lblMasrafAdi.Name = "lblMasrafAdi";
            this.lblMasrafAdi.Size = new System.Drawing.Size(57, 13);
            this.lblMasrafAdi.TabIndex = 109;
            this.lblMasrafAdi.Text = "Masraf Adı";
            // 
            // Masraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 354);
            this.Controls.Add(this.lvListe);
            this.Controls.Add(this.btnGoruntule);
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
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMasrafTutari;
        private System.Windows.Forms.Label lblMasrafTutari;
        private System.Windows.Forms.TextBox txtMasrafAdi;
        private System.Windows.Forms.Label lblMasrafAdi;
    }
}