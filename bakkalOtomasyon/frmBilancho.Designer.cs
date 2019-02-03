namespace PL.Bakkal
{
    partial class frmBilancho
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
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvGoruntulenenListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "BİLANÇO EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSiralama
            // 
            this.cbSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Items.AddRange(new object[] {
            "Günlük Bilanço",
            "Haftalık Bilanço (Son 7 gün)",
            "Aylık Bilanço (Son 30 gün)"});
            this.cbSiralama.Location = new System.Drawing.Point(22, 103);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(227, 21);
            this.cbSiralama.TabIndex = 127;
            this.cbSiralama.SelectedIndexChanged += new System.EventHandler(this.cbSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Bilanço Kıstasını Seçiniz";
            // 
            // lvGoruntulenenListe
            // 
            this.lvGoruntulenenListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvGoruntulenenListe.Location = new System.Drawing.Point(22, 130);
            this.lvGoruntulenenListe.Name = "lvGoruntulenenListe";
            this.lvGoruntulenenListe.Size = new System.Drawing.Size(227, 153);
            this.lvGoruntulenenListe.TabIndex = 129;
            this.lvGoruntulenenListe.UseCompatibleStateImageBehavior = false;
            this.lvGoruntulenenListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kaynak";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tutar";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 97;
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(271, 29);
            this.formKapatici1.TabIndex = 0;
            // 
            // frmBilancho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 324);
            this.Controls.Add(this.lvGoruntulenenListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSiralama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilancho";
            this.Text = "frmBilancho";
            this.Load += new System.EventHandler(this.frmBilancho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvGoruntulenenListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}