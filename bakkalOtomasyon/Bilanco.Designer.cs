namespace PL.Bakkal
{
    partial class Bilanco
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
            this.lvGoruntulenenListe = new System.Windows.Forms.ListView();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGoruntulenenListe
            // 
            this.lvGoruntulenenListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvGoruntulenenListe.Location = new System.Drawing.Point(29, 81);
            this.lvGoruntulenenListe.Name = "lvGoruntulenenListe";
            this.lvGoruntulenenListe.Size = new System.Drawing.Size(243, 134);
            this.lvGoruntulenenListe.TabIndex = 116;
            this.lvGoruntulenenListe.UseCompatibleStateImageBehavior = false;
            this.lvGoruntulenenListe.View = System.Windows.Forms.View.Details;
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(26, 38);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(62, 13);
            this.lblSiralamaOlcutu.TabIndex = 114;
            this.lblSiralamaOlcutu.Text = "Tarih Aralığı";
            // 
            // cbSiralama
            // 
            this.cbSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Items.AddRange(new object[] {
            "Günlük Bilanço",
            "Haftalık Bilanço",
            "Aylık Bilanço"});
            this.cbSiralama.Location = new System.Drawing.Point(151, 38);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 113;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kaynak";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tutar";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 115;
            // 
            // Bilanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 236);
            this.Controls.Add(this.lvGoruntulenenListe);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Name = "Bilanco";
            this.Text = "Bilanco";
            this.Load += new System.EventHandler(this.Bilanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGoruntulenenListe;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}