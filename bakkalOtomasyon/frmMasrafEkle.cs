using BLL.Bakkal.Repositories;
using DAL.Bakkal.DataModel;
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
    public partial class frmMasrafEkle : Form
    {
        public frmMasrafEkle()
        {
            InitializeComponent();
        }
        MasrafRepository mr = new MasrafRepository();
        private void frmMasrafEkle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEkle;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMasrafAdi.Text) && !string.IsNullOrEmpty(txtMasrafTutari.Text))
            {
                Masraf m = new Masraf();
                m.MasrafAdi = txtMasrafAdi.Text;
                m.Tutar = Convert.ToDecimal(txtMasrafTutari.Text);
                if (mr.MasrafEkle(m))
                {
                    MessageBox.Show("Masraf kayıtlarına yeni kayıt ekleme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Masraf kayıtlarına yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMasrafAdi.Text = string.Empty;
                    txtMasrafTutari.Text = string.Empty;
                    txtMasrafAdi.Focus();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtMasrafAdi.Text) && string.IsNullOrEmpty(txtMasrafTutari.Text))
                {
                    MessageBox.Show("Masraf adı ve tutarı kolonları boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtMasrafAdi, "Bu kolon boş geçilemez");
                    errorProvider2.SetError(txtMasrafTutari, "Bu kolon boş geçilemez");
                    txtMasrafAdi.Focus();
                }
                else
                { 
                    if (string.IsNullOrEmpty(txtMasrafAdi.Text))
                    {
                        MessageBox.Show("Masraf adı kolonu boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtMasrafAdi, "Bu kolon boş geçilemez");
                        txtMasrafAdi.Focus();
                    }
                    if (string.IsNullOrEmpty(txtMasrafTutari.Text))
                    {
                        MessageBox.Show("Masraf tutarı kolonu boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider2.SetError(txtMasrafTutari, "Bu kolon boş geçilemez");
                        txtMasrafTutari.Focus();
                    }
                }

            }
        }

        private void txtMasrafAdi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char harf in txtMasrafAdi.Text)
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
                        txtMasrafAdi.Text = txtMasrafAdi.Text.Substring(0, txtMasrafAdi.Text.Length - 1);
                        txtMasrafAdi.Select(txtMasrafAdi.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtMasrafTutari_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            foreach (char sayi in txtMasrafTutari.Text)
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
                        txtMasrafTutari.Text = txtMasrafTutari.Text.Substring(0, txtMasrafTutari.Text.Length - 1);
                        txtMasrafTutari.Select(txtMasrafTutari.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtMasrafTutari.Text.Length; i++)
            {
                if (txtMasrafTutari.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtMasrafTutari.Text = txtMasrafTutari.Text.Substring(0, txtMasrafTutari.Text.Length - 1);
                        txtMasrafTutari.Select(txtMasrafTutari.Text.Length, 0);
                        return;
                    }
                }
            }
        }
    }
}
