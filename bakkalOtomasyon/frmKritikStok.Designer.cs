namespace PL.Bakkal
{
    partial class frmKritikStok
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
            this.formKapatici1 = new PL.Bakkal.FormKapatici();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKritikUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // formKapatici1
            // 
            this.formKapatici1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formKapatici1.Location = new System.Drawing.Point(0, 0);
            this.formKapatici1.Name = "formKapatici1";
            this.formKapatici1.Size = new System.Drawing.Size(669, 29);
            this.formKapatici1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "STOK MİKTARI KRİTİK DURUMDA OLAN ÜRÜNLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKritikUrunler
            // 
            this.dgvKritikUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKritikUrunler.Location = new System.Drawing.Point(3, 56);
            this.dgvKritikUrunler.Name = "dgvKritikUrunler";
            this.dgvKritikUrunler.Size = new System.Drawing.Size(666, 211);
            this.dgvKritikUrunler.TabIndex = 124;
            // 
            // frmKritikStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 329);
            this.Controls.Add(this.dgvKritikUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formKapatici1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKritikStok";
            this.Text = "frmKritikStok";
            this.Load += new System.EventHandler(this.frmKritikStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormKapatici formKapatici1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKritikUrunler;
    }
}