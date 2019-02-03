namespace PL.Bakkal
{
    partial class frmIade
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
            this.lvSatislar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylar = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSDSil = new System.Windows.Forms.Button();
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "SATIŞ İPTAL EKRANI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvSatislar
            // 
            this.lvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSatislar.FullRowSelect = true;
            this.lvSatislar.Location = new System.Drawing.Point(12, 73);
            this.lvSatislar.MultiSelect = false;
            this.lvSatislar.Name = "lvSatislar";
            this.lvSatislar.Size = new System.Drawing.Size(324, 195);
            this.lvSatislar.TabIndex = 126;
            this.lvSatislar.UseCompatibleStateImageBehavior = false;
            this.lvSatislar.View = System.Windows.Forms.View.Details;
            this.lvSatislar.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvSatislar_ColumnWidthChanging);
            this.lvSatislar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSatislar_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satış Id";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Toplam Tutar";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme Tipi";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tarihi";
            this.columnHeader4.Width = 110;
            // 
            // lvSatisDetaylar
            // 
            this.lvSatisDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvSatisDetaylar.FullRowSelect = true;
            this.lvSatisDetaylar.Location = new System.Drawing.Point(342, 112);
            this.lvSatisDetaylar.MultiSelect = false;
            this.lvSatisDetaylar.Name = "lvSatisDetaylar";
            this.lvSatisDetaylar.Size = new System.Drawing.Size(328, 110);
            this.lvSatisDetaylar.TabIndex = 127;
            this.lvSatisDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylar.View = System.Windows.Forms.View.Details;
            this.lvSatisDetaylar.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvSatisDetaylar_ColumnWidthChanging);
            this.lvSatisDetaylar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSatisDetaylar_ItemSelectionChanged);
            this.lvSatisDetaylar.DoubleClick += new System.EventHandler(this.lvSatisDetaylar_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Satış Id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Id";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ürün Adı";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Birim Fiyat";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Adet";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Toplam Tutar";
            this.columnHeader11.Width = 78;
            // 
            // btnSDSil
            // 
            this.btnSDSil.Location = new System.Drawing.Point(595, 228);
            this.btnSDSil.Name = "btnSDSil";
            this.btnSDSil.Size = new System.Drawing.Size(75, 23);
            this.btnSDSil.TabIndex = 129;
            this.btnSDSil.Text = "Sil";
            this.btnSDSil.UseVisualStyleBackColor = true;
            this.btnSDSil.Click += new System.EventHandler(this.btnSDSil_Click);
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(685, 29);
            this.formKapatici1.TabIndex = 0;
            // 
            // frmIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 311);
            this.Controls.Add(this.btnSDSil);
            this.Controls.Add(this.lvSatisDetaylar);
            this.Controls.Add(this.lvSatislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIade";
            this.Text = "frmIade";
            this.Load += new System.EventHandler(this.frmIade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvSatislar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvSatisDetaylar;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnSDSil;
    }
}