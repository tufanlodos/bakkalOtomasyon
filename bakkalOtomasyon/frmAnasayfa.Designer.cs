namespace PL.Bakkal
{
    partial class frmAnasayfa
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSimge = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnBilanco = new System.Windows.Forms.Button();
            this.btnMasraf = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnTedarik = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnSimge);
            this.pnlHeader.Controls.Add(this.btnKapat);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 131);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnSimge
            // 
            this.btnSimge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimge.Location = new System.Drawing.Point(728, 12);
            this.btnSimge.Name = "btnSimge";
            this.btnSimge.Size = new System.Drawing.Size(27, 23);
            this.btnSimge.TabIndex = 7;
            this.btnSimge.Text = "--";
            this.btnSimge.UseVisualStyleBackColor = true;
            this.btnSimge.Click += new System.EventHandler(this.btnSimge_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(761, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(27, 23);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 131);
            this.label1.TabIndex = 5;
            this.label1.Text = "ERDAL BAKKAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 100);
            this.pnlFooter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 5;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(235, 156);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(565, 251);
            this.pnlContent.TabIndex = 8;
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnBilanco);
            this.pnlNav.Controls.Add(this.btnMasraf);
            this.pnlNav.Controls.Add(this.btnSiparis);
            this.pnlNav.Controls.Add(this.btnTedarik);
            this.pnlNav.Controls.Add(this.btnStok);
            this.pnlNav.Controls.Add(this.btnUrun);
            this.pnlNav.Controls.Add(this.btnKategori);
            this.pnlNav.Controls.Add(this.btnSatis);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 156);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(235, 251);
            this.pnlNav.TabIndex = 7;
            // 
            // btnBilanco
            // 
            this.btnBilanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBilanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilanco.Location = new System.Drawing.Point(0, 217);
            this.btnBilanco.Name = "btnBilanco";
            this.btnBilanco.Size = new System.Drawing.Size(235, 31);
            this.btnBilanco.TabIndex = 7;
            this.btnBilanco.Text = "BİLANÇO";
            this.btnBilanco.UseVisualStyleBackColor = true;
            // 
            // btnMasraf
            // 
            this.btnMasraf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasraf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasraf.Location = new System.Drawing.Point(0, 186);
            this.btnMasraf.Name = "btnMasraf";
            this.btnMasraf.Size = new System.Drawing.Size(235, 31);
            this.btnMasraf.TabIndex = 6;
            this.btnMasraf.Text = "MASRAF İŞLEMLERİ";
            this.btnMasraf.UseVisualStyleBackColor = true;
            this.btnMasraf.Click += new System.EventHandler(this.btnMasraf_Click_1);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparis.Location = new System.Drawing.Point(0, 155);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(235, 31);
            this.btnSiparis.TabIndex = 5;
            this.btnSiparis.Text = "SİPARİŞ İŞLEMLERİ";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click_1);
            // 
            // btnTedarik
            // 
            this.btnTedarik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTedarik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTedarik.Location = new System.Drawing.Point(0, 124);
            this.btnTedarik.Name = "btnTedarik";
            this.btnTedarik.Size = new System.Drawing.Size(235, 31);
            this.btnTedarik.TabIndex = 4;
            this.btnTedarik.Text = "TEDARİK İŞLEMLERİ";
            this.btnTedarik.UseVisualStyleBackColor = true;
            // 
            // btnStok
            // 
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStok.Location = new System.Drawing.Point(0, 93);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(235, 31);
            this.btnStok.TabIndex = 3;
            this.btnStok.Text = "STOK DURUMU";
            this.btnStok.UseVisualStyleBackColor = true;
            // 
            // btnUrun
            // 
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrun.Location = new System.Drawing.Point(0, 62);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(235, 31);
            this.btnUrun.TabIndex = 2;
            this.btnUrun.Text = "ÜRÜN İŞLEMLERİ";
            this.btnUrun.UseVisualStyleBackColor = true;
            // 
            // btnKategori
            // 
            this.btnKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKategori.Location = new System.Drawing.Point(0, 31);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(235, 31);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "KATEGORİ İŞLEMLERİ";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnSatis
            // 
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatis.Location = new System.Drawing.Point(0, 0);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(235, 31);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "SATIŞ EKRANI";
            this.btnSatis.UseVisualStyleBackColor = true;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSimge;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnBilanco;
        private System.Windows.Forms.Button btnMasraf;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnTedarik;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnSatis;
    }
}