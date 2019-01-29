namespace PL.Bakkal
{
    partial class frmMasrafEkle
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
            this.txtMasrafTutari = new System.Windows.Forms.TextBox();
            this.lblMasrafTutari = new System.Windows.Forms.Label();
            this.txtMasrafAdi = new System.Windows.Forms.TextBox();
            this.lblMasrafAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasrafTutari
            // 
            this.txtMasrafTutari.Location = new System.Drawing.Point(163, 69);
            this.txtMasrafTutari.Name = "txtMasrafTutari";
            this.txtMasrafTutari.Size = new System.Drawing.Size(216, 20);
            this.txtMasrafTutari.TabIndex = 116;
            this.txtMasrafTutari.TextChanged += new System.EventHandler(this.txtMasrafTutari_TextChanged);
            // 
            // lblMasrafTutari
            // 
            this.lblMasrafTutari.AutoSize = true;
            this.lblMasrafTutari.Location = new System.Drawing.Point(38, 69);
            this.lblMasrafTutari.Name = "lblMasrafTutari";
            this.lblMasrafTutari.Size = new System.Drawing.Size(69, 13);
            this.lblMasrafTutari.TabIndex = 115;
            this.lblMasrafTutari.Text = "Masraf Tutarı";
            // 
            // txtMasrafAdi
            // 
            this.txtMasrafAdi.Location = new System.Drawing.Point(163, 32);
            this.txtMasrafAdi.Name = "txtMasrafAdi";
            this.txtMasrafAdi.Size = new System.Drawing.Size(216, 20);
            this.txtMasrafAdi.TabIndex = 114;
            this.txtMasrafAdi.TextChanged += new System.EventHandler(this.txtMasrafAdi_TextChanged);
            // 
            // lblMasrafAdi
            // 
            this.lblMasrafAdi.AutoSize = true;
            this.lblMasrafAdi.Location = new System.Drawing.Point(38, 32);
            this.lblMasrafAdi.Name = "lblMasrafAdi";
            this.lblMasrafAdi.Size = new System.Drawing.Size(57, 13);
            this.lblMasrafAdi.TabIndex = 113;
            this.lblMasrafAdi.Text = "Masraf Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(181, 112);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 29);
            this.btnEkle.TabIndex = 117;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmMasrafEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 175);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMasrafTutari);
            this.Controls.Add(this.lblMasrafTutari);
            this.Controls.Add(this.txtMasrafAdi);
            this.Controls.Add(this.lblMasrafAdi);
            this.Name = "frmMasrafEkle";
            this.Text = "frmMasrafEkle";
            this.Load += new System.EventHandler(this.frmMasrafEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasrafTutari;
        private System.Windows.Forms.Label lblMasrafTutari;
        private System.Windows.Forms.TextBox txtMasrafAdi;
        private System.Windows.Forms.Label lblMasrafAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}