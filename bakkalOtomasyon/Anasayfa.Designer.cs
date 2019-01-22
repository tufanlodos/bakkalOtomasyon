namespace bakkalOtomasyon
{
    partial class Anasayfa
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
            this.btnIade = new System.Windows.Forms.Button();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.rbtnKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbtnNakit = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNakitGiris = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkot = new System.Windows.Forms.Label();
            this.btnIslemBitti = new System.Windows.Forms.Button();
            this.lvAlisveris = new System.Windows.Forms.ListView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnArkaPlanaAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIade
            // 
            this.btnIade.Location = new System.Drawing.Point(585, 154);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(51, 23);
            this.btnIade.TabIndex = 45;
            this.btnIade.Text = "İade";
            this.btnIade.UseVisualStyleBackColor = true;
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(475, 227);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(95, 22);
            this.txtParaUstu.TabIndex = 44;
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Location = new System.Drawing.Point(379, 227);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(71, 17);
            this.lblParaUstu.TabIndex = 43;
            this.lblParaUstu.Text = "Para Üstü";
            // 
            // rbtnKrediKarti
            // 
            this.rbtnKrediKarti.AutoSize = true;
            this.rbtnKrediKarti.Location = new System.Drawing.Point(468, 154);
            this.rbtnKrediKarti.Name = "rbtnKrediKarti";
            this.rbtnKrediKarti.Size = new System.Drawing.Size(95, 21);
            this.rbtnKrediKarti.TabIndex = 42;
            this.rbtnKrediKarti.TabStop = true;
            this.rbtnKrediKarti.Text = "Kredi Kartı";
            this.rbtnKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbtnNakit
            // 
            this.rbtnNakit.AutoSize = true;
            this.rbtnNakit.Location = new System.Drawing.Point(382, 154);
            this.rbtnNakit.Name = "rbtnNakit";
            this.rbtnNakit.Size = new System.Drawing.Size(61, 21);
            this.rbtnNakit.TabIndex = 41;
            this.rbtnNakit.TabStop = true;
            this.rbtnNakit.Text = "Nakit";
            this.rbtnNakit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 22);
            this.textBox2.TabIndex = 40;
            // 
            // lblNakitGiris
            // 
            this.lblNakitGiris.AutoSize = true;
            this.lblNakitGiris.Location = new System.Drawing.Point(379, 192);
            this.lblNakitGiris.Name = "lblNakitGiris";
            this.lblNakitGiris.Size = new System.Drawing.Size(73, 17);
            this.lblNakitGiris.TabIndex = 39;
            this.lblNakitGiris.Text = "Nakit Giriş";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(475, 53);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(161, 56);
            this.txtToplamTutar.TabIndex = 38;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(370, 74);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(93, 17);
            this.lblToplamTutar.TabIndex = 37;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(160, 350);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(95, 22);
            this.txtTutar.TabIndex = 36;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(160, 319);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(95, 22);
            this.txtFiyat.TabIndex = 35;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(160, 287);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(95, 22);
            this.txtMiktar.TabIndex = 34;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(266, 287);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(29, 22);
            this.btnArttır.TabIndex = 33;
            this.btnArttır.Text = "+";
            this.btnArttır.UseVisualStyleBackColor = true;
            // 
            // btnEksilt
            // 
            this.btnEksilt.Location = new System.Drawing.Point(126, 287);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(28, 22);
            this.btnEksilt.TabIndex = 32;
            this.btnEksilt.Text = "-";
            this.btnEksilt.UseVisualStyleBackColor = true;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(62, 287);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(46, 17);
            this.lblMiktar.TabIndex = 31;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(62, 319);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 30;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(62, 350);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(42, 17);
            this.lblTutar.TabIndex = 29;
            this.lblTutar.Text = "Tutar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 27;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(62, 76);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(55, 17);
            this.lblUrun.TabIndex = 26;
            this.lblUrun.Text = "Ürünler";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(143, 41);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(126, 22);
            this.txtBarkod.TabIndex = 25;
            // 
            // lblBarkot
            // 
            this.lblBarkot.AutoSize = true;
            this.lblBarkot.Location = new System.Drawing.Point(62, 44);
            this.lblBarkot.Name = "lblBarkot";
            this.lblBarkot.Size = new System.Drawing.Size(75, 17);
            this.lblBarkot.TabIndex = 24;
            this.lblBarkot.Text = "Barkod No";
            // 
            // btnIslemBitti
            // 
            this.btnIslemBitti.Location = new System.Drawing.Point(477, 275);
            this.btnIslemBitti.Name = "btnIslemBitti";
            this.btnIslemBitti.Size = new System.Drawing.Size(88, 29);
            this.btnIslemBitti.TabIndex = 46;
            this.btnIslemBitti.Text = "İşlem Bitti";
            this.btnIslemBitti.UseVisualStyleBackColor = true;
            // 
            // lvAlisveris
            // 
            this.lvAlisveris.Location = new System.Drawing.Point(65, 118);
            this.lvAlisveris.Name = "lvAlisveris";
            this.lvAlisveris.Size = new System.Drawing.Size(230, 153);
            this.lvAlisveris.TabIndex = 47;
            this.lvAlisveris.UseCompatibleStateImageBehavior = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(998, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 23);
            this.btnKapat.TabIndex = 48;
            this.btnKapat.Text = "x";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnArkaPlanaAl
            // 
            this.btnArkaPlanaAl.Location = new System.Drawing.Point(961, 12);
            this.btnArkaPlanaAl.Name = "btnArkaPlanaAl";
            this.btnArkaPlanaAl.Size = new System.Drawing.Size(31, 23);
            this.btnArkaPlanaAl.TabIndex = 49;
            this.btnArkaPlanaAl.Text = "-";
            this.btnArkaPlanaAl.UseVisualStyleBackColor = true;
            this.btnArkaPlanaAl.Click += new System.EventHandler(this.btnArkaPlanaAl_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnArkaPlanaAl);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lvAlisveris);
            this.Controls.Add(this.btnIslemBitti);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.txtParaUstu);
            this.Controls.Add(this.lblParaUstu);
            this.Controls.Add(this.rbtnKrediKarti);
            this.Controls.Add(this.rbtnNakit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNakitGiris);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.RadioButton rbtnKrediKarti;
        private System.Windows.Forms.RadioButton rbtnNakit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNakitGiris;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnEksilt;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkot;
        private System.Windows.Forms.Button btnIslemBitti;
        private System.Windows.Forms.ListView lvAlisveris;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnArkaPlanaAl;
    }
}

