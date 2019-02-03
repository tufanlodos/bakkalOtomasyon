namespace PL.Bakkal
{
    partial class frmYeniTedarikciEkle
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
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.lblIletisimNo = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.txtIletisimNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(89, 71);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(90, 17);
            this.lblTedarikciAdi.TabIndex = 0;
            this.lblTedarikciAdi.Text = "Tedarikçi Adı";
            // 
            // lblIletisimNo
            // 
            this.lblIletisimNo.AutoSize = true;
            this.lblIletisimNo.Location = new System.Drawing.Point(89, 113);
            this.lblIletisimNo.Name = "lblIletisimNo";
            this.lblIletisimNo.Size = new System.Drawing.Size(72, 17);
            this.lblIletisimNo.TabIndex = 1;
            this.lblIletisimNo.Text = "İletişim No";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(89, 152);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(188, 68);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtTedarikciAdi.TabIndex = 4;
            // 
            // txtIletisimNo
            // 
            this.txtIletisimNo.Location = new System.Drawing.Point(188, 113);
            this.txtIletisimNo.Name = "txtIletisimNo";
            this.txtIletisimNo.Size = new System.Drawing.Size(100, 22);
            this.txtIletisimNo.TabIndex = 5;
            this.txtIletisimNo.TextChanged += new System.EventHandler(this.txtIletisimNo_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(188, 152);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 46);
            this.txtAdres.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(205, 225);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 30);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmYeniTedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 315);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtIletisimNo);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblIletisimNo);
            this.Controls.Add(this.lblTedarikciAdi);
            this.Name = "frmYeniTedarikciEkle";
            this.Text = "frmYeniTedarikciEkle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.Label lblIletisimNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.TextBox txtIletisimNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}