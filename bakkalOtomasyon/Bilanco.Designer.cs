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
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cbSiralama = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvGoruntulenenListe
            // 
            this.lvGoruntulenenListe.Location = new System.Drawing.Point(151, 114);
            this.lvGoruntulenenListe.Name = "lvGoruntulenenListe";
            this.lvGoruntulenenListe.Size = new System.Drawing.Size(222, 82);
            this.lvGoruntulenenListe.TabIndex = 116;
            this.lvGoruntulenenListe.UseCompatibleStateImageBehavior = false;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Enabled = false;
            this.btnGoruntule.Location = new System.Drawing.Point(151, 79);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(81, 29);
            this.btnGoruntule.TabIndex = 115;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(26, 38);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(81, 13);
            this.lblSiralamaOlcutu.TabIndex = 114;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü";
            // 
            // cbSiralama
            // 
            this.cbSiralama.FormattingEnabled = true;
            this.cbSiralama.Location = new System.Drawing.Point(151, 38);
            this.cbSiralama.Name = "cbSiralama";
            this.cbSiralama.Size = new System.Drawing.Size(121, 21);
            this.cbSiralama.TabIndex = 113;
            // 
            // Bilanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 237);
            this.Controls.Add(this.lvGoruntulenenListe);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.lblSiralamaOlcutu);
            this.Controls.Add(this.cbSiralama);
            this.Name = "Bilanco";
            this.Text = "Bilanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGoruntulenenListe;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cbSiralama;
    }
}