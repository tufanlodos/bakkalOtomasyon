namespace PL.Bakkal
{
    partial class frmStok
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
            this.lblUrunSecin = new System.Windows.Forms.Label();
            this.cbUrunSecin = new System.Windows.Forms.ComboBox();
            this.txtUrunSec = new System.Windows.Forms.TextBox();
            this.txtKategoriSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.lblKritik = new System.Windows.Forms.Label();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunSecin
            // 
            this.lblUrunSecin.AutoSize = true;
            this.lblUrunSecin.Location = new System.Drawing.Point(20, 48);
            this.lblUrunSecin.Name = "lblUrunSecin";
            this.lblUrunSecin.Size = new System.Drawing.Size(60, 13);
            this.lblUrunSecin.TabIndex = 75;
            this.lblUrunSecin.Text = "Ürün Seçin";
            // 
            // cbUrunSecin
            // 
            this.cbUrunSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunSecin.DropDownWidth = 150;
            this.cbUrunSecin.FormattingEnabled = true;
            this.cbUrunSecin.Location = new System.Drawing.Point(375, 48);
            this.cbUrunSecin.Name = "cbUrunSecin";
            this.cbUrunSecin.Size = new System.Drawing.Size(19, 21);
            this.cbUrunSecin.TabIndex = 74;
            this.cbUrunSecin.SelectedIndexChanged += new System.EventHandler(this.cbUrunSecin_SelectedIndexChanged);
            // 
            // txtUrunSec
            // 
            this.txtUrunSec.Location = new System.Drawing.Point(192, 49);
            this.txtUrunSec.Name = "txtUrunSec";
            this.txtUrunSec.Size = new System.Drawing.Size(184, 20);
            this.txtUrunSec.TabIndex = 84;
            // 
            // txtKategoriSec
            // 
            this.txtKategoriSec.Location = new System.Drawing.Point(192, 20);
            this.txtKategoriSec.Name = "txtKategoriSec";
            this.txtKategoriSec.Size = new System.Drawing.Size(184, 20);
            this.txtKategoriSec.TabIndex = 87;
            this.txtKategoriSec.TextChanged += new System.EventHandler(this.txtKategoriSec_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Kategori Seçin";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.DropDownWidth = 150;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(375, 19);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(19, 21);
            this.cbKategori.TabIndex = 85;
            // 
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(14, 95);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(121, 13);
            this.lblSiralamaOlcutu.TabIndex = 119;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü Seçiniz.";
            // 
            // cbSiralama
            // 
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Location = new System.Drawing.Point(192, 88);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(202, 21);
            this.cbSiralama.TabIndex = 118;
            // 
            // lblKritik
            // 
            this.lblKritik.AutoSize = true;
            this.lblKritik.BackColor = System.Drawing.Color.Red;
            this.lblKritik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKritik.Location = new System.Drawing.Point(70, 283);
            this.lblKritik.Name = "lblKritik";
            this.lblKritik.Size = new System.Drawing.Size(411, 17);
            this.lblKritik.TabIndex = 121;
            this.lblKritik.Text = "Stok miktarı kritik seviyede olan ürünler bulunmaktadır !";
            // 
            // dgvStok
            // 
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Location = new System.Drawing.Point(23, 125);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.Size = new System.Drawing.Size(527, 139);
            this.dgvStok.TabIndex = 122;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 150);
            this.dataGridView1.TabIndex = 122;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 370);
            this.Controls.Add(this.dgvStok);
            this.ClientSize = new System.Drawing.Size(423, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKritik);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.txtKategoriSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txtUrunSec);
            this.Controls.Add(this.lblUrunSecin);
            this.Controls.Add(this.cbUrunSecin);
            this.Name = "Stok";
            this.Text = "Stok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrunSecin;
        private System.Windows.Forms.ComboBox cbUrunSecin;
        private System.Windows.Forms.TextBox txtUrunSec;
        private System.Windows.Forms.TextBox txtKategoriSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Label lblKritik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvStok;
    }
}