namespace PL.Bakkal
{
    partial class frmSatisEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSKaldir = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.lvAlisverisSepeti = new System.Windows.Forms.ListView();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkot = new System.Windows.Forms.Label();
            this.btnIslemKaydet = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.rbtnKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbtnNakit = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNakitGiris = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSTemizle = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "SATIŞ EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(67, 233);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 24);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.TabStop = false;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Alışveriş Sepeti";
            // 
            // btnSKaldir
            // 
            this.btnSKaldir.Location = new System.Drawing.Point(507, 260);
            this.btnSKaldir.Name = "btnSKaldir";
            this.btnSKaldir.Size = new System.Drawing.Size(105, 23);
            this.btnSKaldir.TabIndex = 140;
            this.btnSKaldir.Text = "Sepetten Çıkar";
            this.btnSKaldir.UseVisualStyleBackColor = true;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(174, 233);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(87, 24);
            this.btnSepeteEkle.TabIndex = 4;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(129, 95);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(92, 23);
            this.btnUrunSec.TabIndex = 2;
            this.btnUrunSec.Text = "Ürün Bul";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            // 
            // lvAlisverisSepeti
            // 
            this.lvAlisverisSepeti.Location = new System.Drawing.Point(272, 72);
            this.lvAlisverisSepeti.Margin = new System.Windows.Forms.Padding(2);
            this.lvAlisverisSepeti.Name = "lvAlisverisSepeti";
            this.lvAlisverisSepeti.Size = new System.Drawing.Size(450, 180);
            this.lvAlisverisSepeti.TabIndex = 137;
            this.lvAlisverisSepeti.UseCompatibleStateImageBehavior = false;
            this.lvAlisverisSepeti.View = System.Windows.Forms.View.Details;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(129, 199);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(132, 20);
            this.txtTutar.TabIndex = 136;
            this.txtTutar.TabStop = false;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(129, 146);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(132, 20);
            this.txtFiyat.TabIndex = 135;
            this.txtFiyat.TabStop = false;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(154, 174);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(81, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiktar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMiktar_MouseClick);
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(239, 174);
            this.btnArttır.Margin = new System.Windows.Forms.Padding(2);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(22, 18);
            this.btnArttır.TabIndex = 133;
            this.btnArttır.Text = "+";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // btnEksilt
            // 
            this.btnEksilt.Location = new System.Drawing.Point(129, 174);
            this.btnEksilt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(21, 18);
            this.btnEksilt.TabIndex = 132;
            this.btnEksilt.Text = "-";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.btnEksilt_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(68, 174);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 131;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(68, 146);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 130;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(68, 199);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(32, 13);
            this.lblTutar.TabIndex = 129;
            this.lblTutar.Text = "Tutar";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(129, 122);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(132, 20);
            this.txtUrunAdi.TabIndex = 128;
            this.txtUrunAdi.TabStop = false;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(68, 126);
            this.lblUrun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(48, 13);
            this.lblUrun.TabIndex = 127;
            this.lblUrun.Text = "Ürün Adı";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(129, 72);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(96, 20);
            this.txtBarkod.TabIndex = 0;
            // 
            // lblBarkot
            // 
            this.lblBarkot.AutoSize = true;
            this.lblBarkot.Location = new System.Drawing.Point(68, 75);
            this.lblBarkot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkot.Name = "lblBarkot";
            this.lblBarkot.Size = new System.Drawing.Size(58, 13);
            this.lblBarkot.TabIndex = 125;
            this.lblBarkot.Text = "Barkod No";
            // 
            // btnIslemKaydet
            // 
            this.btnIslemKaydet.Location = new System.Drawing.Point(392, 436);
            this.btnIslemKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnIslemKaydet.Name = "btnIslemKaydet";
            this.btnIslemKaydet.Size = new System.Drawing.Size(106, 24);
            this.btnIslemKaydet.TabIndex = 152;
            this.btnIslemKaydet.Text = "İşlem Kaydet";
            this.btnIslemKaydet.UseVisualStyleBackColor = true;
            // 
            // btnIade
            // 
            this.btnIade.Location = new System.Drawing.Point(307, 436);
            this.btnIade.Margin = new System.Windows.Forms.Padding(2);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(81, 24);
            this.btnIade.TabIndex = 151;
            this.btnIade.Text = "İade İşlemleri";
            this.btnIade.UseVisualStyleBackColor = true;
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(377, 400);
            this.txtParaUstu.Margin = new System.Windows.Forms.Padding(2);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(122, 20);
            this.txtParaUstu.TabIndex = 150;
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Location = new System.Drawing.Point(305, 405);
            this.lblParaUstu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(54, 13);
            this.lblParaUstu.TabIndex = 149;
            this.lblParaUstu.Text = "Para Üstü";
            // 
            // rbtnKrediKarti
            // 
            this.rbtnKrediKarti.AutoSize = true;
            this.rbtnKrediKarti.Location = new System.Drawing.Point(407, 341);
            this.rbtnKrediKarti.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnKrediKarti.Name = "rbtnKrediKarti";
            this.rbtnKrediKarti.Size = new System.Drawing.Size(73, 17);
            this.rbtnKrediKarti.TabIndex = 148;
            this.rbtnKrediKarti.TabStop = true;
            this.rbtnKrediKarti.Text = "Kredi Kartı";
            this.rbtnKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbtnNakit
            // 
            this.rbtnNakit.AutoSize = true;
            this.rbtnNakit.Location = new System.Drawing.Point(342, 341);
            this.rbtnNakit.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNakit.Name = "rbtnNakit";
            this.rbtnNakit.Size = new System.Drawing.Size(50, 17);
            this.rbtnNakit.TabIndex = 147;
            this.rbtnNakit.TabStop = true;
            this.rbtnNakit.Text = "Nakit";
            this.rbtnNakit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 372);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 146;
            // 
            // lblNakitGiris
            // 
            this.lblNakitGiris.AutoSize = true;
            this.lblNakitGiris.Location = new System.Drawing.Point(305, 377);
            this.lblNakitGiris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNakitGiris.Name = "lblNakitGiris";
            this.lblNakitGiris.Size = new System.Drawing.Size(55, 13);
            this.lblNakitGiris.TabIndex = 145;
            this.lblNakitGiris.Text = "Nakit Giriş";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(377, 280);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(122, 46);
            this.txtToplamTutar.TabIndex = 144;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(299, 297);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 143;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(229, 71);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(40, 22);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSTemizle
            // 
            this.btnSTemizle.Location = new System.Drawing.Point(618, 260);
            this.btnSTemizle.Name = "btnSTemizle";
            this.btnSTemizle.Size = new System.Drawing.Size(105, 23);
            this.btnSTemizle.TabIndex = 154;
            this.btnSTemizle.Text = "Sepeti Temizle";
            this.btnSTemizle.UseVisualStyleBackColor = true;
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(800, 29);
            this.formKapatici1.TabIndex = 0;
            this.formKapatici1.TabStop = false;
            // 
            // frmSatisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnSTemizle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnIslemKaydet);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.txtParaUstu);
            this.Controls.Add(this.lblParaUstu);
            this.Controls.Add(this.rbtnKrediKarti);
            this.Controls.Add(this.rbtnNakit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNakitGiris);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSKaldir);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnUrunSec);
            this.Controls.Add(this.lvAlisverisSepeti);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatisEkrani";
            this.Text = "frmSatisEkrani";
            this.Load += new System.EventHandler(this.frmSatisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSKaldir;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.ListView lvAlisverisSepeti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnEksilt;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkot;
        private System.Windows.Forms.Button btnIslemKaydet;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.RadioButton rbtnKrediKarti;
        private System.Windows.Forms.RadioButton rbtnNakit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNakitGiris;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSTemizle;
    }
}