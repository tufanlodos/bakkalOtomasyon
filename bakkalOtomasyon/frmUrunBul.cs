using BLL.Bakkal.Repositories;
using DAL.Bakkal.DataModel;
using DAL.Bakkal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Bakkal
{
    public partial class frmUrunBul : Form
    {
        public frmUrunBul()
        {
            InitializeComponent();
        }

        //autosize true olacak
        //location 
        SatisRepo sr = new SatisRepo();
        int x = 40, y=45, xler = 0, yler = 0;
        private void frmUrunBul_Load(object sender, EventArgs e)
        {
            List<Urunler> liste = sr.UrunleriGetir();
            foreach (Urunler urun in liste)
            {
                Button btn = new Button();
                btn.Click += new EventHandler(button_Click);
                btn.Width = 75;
                btn.Height = 75;
                btn.Text = urun.UrunAdi;
                Point loc = new Point(x, y);
                btn.Location = loc;
                this.Controls.Add(btn);
                if (xler < 8)
                {
                    x += 80;
                    xler++;
                }
                else
                {
                    y += 80;
                    xler = 0;
                    x = 40;
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Genel.UrunAdi = button.Text;
            this.Close();
        }
    }
}
