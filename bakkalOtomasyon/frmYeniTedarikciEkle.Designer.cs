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
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(67, 58);
            this.lblTedarikciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(69, 13);
            this.lblTedarikciAdi.TabIndex = 0;
            this.lblTedarikciAdi.Text = "Tedarikçi Adı";
            // 
            // lblIletisimNo
            // 
            this.lblIletisimNo.AutoSize = true;
            this.lblIletisimNo.Location = new System.Drawing.Point(67, 92);
            this.lblIletisimNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIletisimNo.Name = "lblIletisimNo";
            this.lblIletisimNo.Size = new System.Drawing.Size(55, 13);
            this.lblIletisimNo.TabIndex = 1;
            this.lblIletisimNo.Text = "İletişim No";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(67, 124);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(141, 55);
            this.txtTedarikciAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(76, 20);
            this.txtTedarikciAdi.TabIndex = 4;
            // 
            // txtIletisimNo
            // 
            this.txtIletisimNo.Location = new System.Drawing.Point(141, 92);
            this.txtIletisimNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIletisimNo.Name = "txtIletisimNo";
            this.txtIletisimNo.Size = new System.Drawing.Size(76, 20);
            this.txtIletisimNo.TabIndex = 5;
            this.txtIletisimNo.TextChanged += new System.EventHandler(this.txtIletisimNo_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(141, 124);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(76, 38);
            this.txtAdres.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(154, 183);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(62, 24);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(282, 29);
            this.formKapatici1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "TEDARİKÇİ EKLEME EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmYeniTedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtIletisimNo);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblIletisimNo);
            this.Controls.Add(this.lblTedarikciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
    }
}