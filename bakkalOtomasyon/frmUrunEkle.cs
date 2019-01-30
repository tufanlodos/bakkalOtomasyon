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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        //UrunRepository ur = new UrunRepository();
        private void txtKategoriAdi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char harf in txtKategoriAdi.Text)
            {
                if (!char.IsLetter(harf))
                {
                    if (harf == ' ')
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bu alana sadece harf girişi yapılabilir.");
                        txtKategoriAdi.Text = txtKategoriAdi.Text.Substring(0, txtKategoriAdi.Text.Length - 1);
                        txtKategoriAdi.Select(txtKategoriAdi.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtUrunMarkasi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char harf in txtUrunMarkasi.Text)
            {
                if (!char.IsLetter(harf))
                {
                    if (harf == ' ')
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bu alana sadece harf girişi yapılabilir.");
                        txtUrunMarkasi.Text = txtUrunMarkasi.Text.Substring(0, txtUrunMarkasi.Text.Length - 1);
                        txtUrunMarkasi.Select(txtUrunMarkasi.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char harf in txtUrunAdi.Text)
            {
                if (!char.IsLetter(harf))
                {
                    if (harf == ' ')
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bu alana sadece harf girişi yapılabilir.");
                        txtUrunAdi.Text = txtUrunAdi.Text.Substring(0, txtUrunAdi.Text.Length - 1);
                        txtUrunAdi.Select(txtUrunAdi.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtAlisFiyati_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtAlisFiyati.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    if (sayi == ',')
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.");
                        txtAlisFiyati.Text = txtAlisFiyati.Text.Substring(0, txtAlisFiyati.Text.Length - 1);
                        txtAlisFiyati.Select(txtAlisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtAlisFiyati.Text.Length; i++)
            {
                if (txtAlisFiyati.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtAlisFiyati.Text = txtAlisFiyati.Text.Substring(0, txtAlisFiyati.Text.Length - 1);
                        txtAlisFiyati.Select(txtAlisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtSatisFiyati.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    if (sayi == ',')
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.");
                        txtSatisFiyati.Text = txtSatisFiyati.Text.Substring(0, txtSatisFiyati.Text.Length - 1);
                        txtSatisFiyati.Select(txtSatisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtAlisFiyati.Text.Length; i++)
            {
                if (txtSatisFiyati.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtSatisFiyati.Text = txtSatisFiyati.Text.Substring(0, txtSatisFiyati.Text.Length - 1);
                        txtSatisFiyati.Select(txtSatisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
        }
    }
}
