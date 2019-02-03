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
    public partial class frmKategoriEkle : Form
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }
        KategoriRepository Kr = new KategoriRepository();

        private void frmKategoriEkle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEkle;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text.Trim()))
            {
                Kategoriler yeni = new Kategoriler();
                yeni.KategoriAdi = txtKategoriAdi.Text;
                if (Kr.KategoriKontrol(yeni))
                {
                    MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
                    txtKategoriAdi.SelectAll();
                    errorProvider1.SetError(txtKategoriAdi, "Bu kategori isminde bir kayıt mevcut");
                }
                else
                {
                    if (txtAciklama.Text.Trim()=="")
                    {
                        yeni.Aciklama = "-açıklama girilmemiş-";
                    }
                    else
                    { 
                    yeni.Aciklama = txtAciklama.Text;
                    }
                        if (Kr.KategoriEkle(yeni))
                        {
                            MessageBox.Show("Yeni kategori eklendi.", "Kayıt gerçekleşti.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kategorilere yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtKategoriAdi.Text = string.Empty;
                            txtAciklama.Text = string.Empty;
                            txtKategoriAdi.Focus();
                        }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtKategoriAdi, "Bu alan boş geçilemez");
                txtKategoriAdi.Focus();
            }
            txtKategoriAdi.Focus();
        }

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

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            foreach (char harf in txtAciklama.Text)
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
                        txtKategoriAdi.Text = txtAciklama.Text.Substring(0, txtAciklama.Text.Length - 1);
                        txtAciklama.Select(txtAciklama.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        
    }
}
