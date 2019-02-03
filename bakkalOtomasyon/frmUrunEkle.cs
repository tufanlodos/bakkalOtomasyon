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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        KategoriRepository kr = new KategoriRepository();
        UrunRepository ur = new UrunRepository();

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            cbKategoriAdi.DisplayMember = "KategoriAdi";
            cbKategoriAdi.ValueMember = "Id";
            cbKategoriAdi.DataSource = kr.KategoriListele();
        }
        int KategoriID, UrunId;
        string KategoriAdi, UrunMarkasi;
        private void cbKategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler secilenK = (Kategoriler)cbKategoriAdi.SelectedItem;
            KategoriAdi = secilenK.KategoriAdi;
            KategoriID=secilenK.Id;
            txtKategoriAdi.Text = KategoriAdi;          
        }
       
        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            //KAtegoriAdi listede yoksa
                frmKategoriEkle frm = new frmKategoriEkle();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                cbKategoriAdi.DataSource = kr.KategoriListele();
                cbKategoriAdi.SelectedIndex = cbKategoriAdi.Items.Count - 1;
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
        private void txtBirimAlisFiyati_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtBirimAlisFiyati.Text)
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
                        txtBirimAlisFiyati.Text = txtBirimAlisFiyati.Text.Substring(0, txtBirimAlisFiyati.Text.Length - 1);
                        txtBirimAlisFiyati.Select(txtBirimAlisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtBirimAlisFiyati.Text.Length; i++)
            {
                if (txtBirimAlisFiyati.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtBirimAlisFiyati.Text = txtBirimAlisFiyati.Text.Substring(0, txtBirimAlisFiyati.Text.Length - 1);
                        txtBirimAlisFiyati.Select(txtBirimAlisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtAdet.Text)
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
                        txtAdet.Text = txtAdet.Text.Substring(0, txtAdet.Text.Length - 1);
                        txtAdet.Select(txtAdet.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtAdet.Text.Length; i++)
            {
                if (txtAdet.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtAdet.Text = txtAdet.Text.Substring(0, txtAdet.Text.Length - 1);
                        txtAdet.Select(txtAdet.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void txtBirimSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtBirimSatisFiyati.Text)
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
                        txtBirimSatisFiyati.Text = txtBirimSatisFiyati.Text.Substring(0, txtBirimSatisFiyati.Text.Length - 1);
                        txtBirimSatisFiyati.Select(txtBirimSatisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
            int Sayac = 0;
            for (int i = 0; i < txtBirimSatisFiyati.Text.Length; i++)
            {
                if (txtBirimSatisFiyati.Text[i] == ',')
                {
                    Sayac++;
                    if (Sayac > 1)
                    {
                        MessageBox.Show("Bu alana sadece bir adet virgül girilebilir.");
                        txtBirimSatisFiyati.Text = txtBirimSatisFiyati.Text.Substring(0, txtBirimSatisFiyati.Text.Length - 1);
                        txtBirimSatisFiyati.Select(txtBirimSatisFiyati.Text.Length, 0);
                        return;
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrunAdi.Text.Trim()) && !string.IsNullOrEmpty(txtUrunMarkasi.Text.Trim()))
            {
                Urunler u = new Urunler();
                u.KategoriId = KategoriID;
                u.UrunMarka = txtUrunMarkasi.Text;
                u.UrunAdi = txtUrunAdi.Text;
                u.AlisFiyat = Convert.ToDecimal(txtBirimAlisFiyati.Text);
                u.SatisFiyat = Convert.ToDecimal(txtBirimSatisFiyati.Text);
                if (txtAdet.Text != "")
                {
                    u.StokMiktari = Convert.ToInt32(txtAdet.Text);
                }
                else
                    u.StokMiktari = 0;
                if (ur.UrunKontrol(u))
                {
                    if (MessageBox.Show("Aynı özelliklere sahip sahip bir kayıt bulundu. Yine de yeni kayıt olarak eklemek istiyor musunuz?", "Aynı kayıt şüphesi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ur.UrunEkle(u))
                        {
                            MessageBox.Show("Ürün kayıtlarına yeni kayıt ekleme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ürün kayıtlarına yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Temizle();
                        }
                    }
                    else
                    {
                        txtUrunAdi.SelectAll();
                        errorProvider1.SetError(btnEkle, "Bu isimde kayıt mevcut");
                    }
                }
                else
                {
                    if (ur.UrunEkle(u))
                    {
                        MessageBox.Show("Ürün kayıtlarına yeni kayıt ekleme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ürün kayıtlarına yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Temizle();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUrunMarkasi.Text.Trim()) && string.IsNullOrEmpty(txtUrunAdi.Text.Trim()))
                {
                    MessageBox.Show("Ürün bilgilerini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtUrunMarkasi, "Bu kolon boş geçilemez");
                    errorProvider1.SetError(txtUrunAdi, "Bu kolon boş geçilemez");
                    txtKategoriAdi.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtUrunMarkasi.Text.Trim()))
                    {
                        MessageBox.Show("Ürün Markasını Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtUrunMarkasi, "Bu kolon boş geçilemez");
                        txtUrunMarkasi.Focus();
                    }
                    if (string.IsNullOrEmpty(txtUrunAdi.Text.Trim()))
                    {
                        MessageBox.Show("Ürün Adını Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtUrunAdi, "Bu kolon boş geçilemez");
                        txtUrunAdi.Focus();
                    }
                    if (string.IsNullOrEmpty(txtBirimAlisFiyati.Text.Trim()))
                    {
                        MessageBox.Show("Birim Alış Fiyatını Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtUrunAdi, "Bu kolon boş geçilemez");
                        txtUrunAdi.Focus();
                    }
                    if (string.IsNullOrEmpty(txtBirimSatisFiyati.Text.Trim()))
                    {
                        MessageBox.Show("Birim Satış Fiyatını Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtUrunAdi, "Bu kolon boş geçilemez");
                        txtUrunAdi.Focus();
                    }
                }
            }
        }
        private void Temizle()
        {
            txtKategoriAdi.Clear();
            txtUrunMarkasi.Clear();
            txtUrunAdi.Clear();
            txtBirimAlisFiyati.Clear();
            txtBirimSatisFiyati.Clear();
            txtAdet.Clear();
        }
    }
}
