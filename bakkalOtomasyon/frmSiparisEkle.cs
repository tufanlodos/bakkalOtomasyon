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
    public partial class frmSiparisEkle : Form
    {
        public frmSiparisEkle()
        {
            InitializeComponent();
        }
        int KatId, UrId, TedId;
        SiparisRepository srepo = new SiparisRepository();
        private void frmSiparisEkle_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
            txtAdet.Focus();
            this.AcceptButton = btnEkle;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdet.Text))
            {
                Siparis s = new Siparis();
                s.UrunId = UrId;
                s.TedarikciId = TedId;
                int Miktar = Convert.ToInt32(txtAdet.Text);
                decimal AlisFiyat = Convert.ToDecimal(txtBirimAlisFiyati.Text);
                s.Miktar = Miktar;
                s.Tutar = Convert.ToDecimal(Miktar * AlisFiyat);
                if (srepo.SiparisEkle(s))
                {
                    MessageBox.Show("Sipariş kayıtlarına yeni kayıt ekleme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sipariş kayıtlarına yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sipariş kaydı oluşturmak için adet girişi yapmanız gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdet.Focus();
            }
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler secilen = cbKategoriler.SelectedItem as Kategoriler;
            KatId = secilen.Id;
            cbUrunler.DataSource = srepo.UrunleriGetirByKategoriId(KatId);
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
            txtAdet.Focus();
        }

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urunler secilen = cbUrunler.SelectedItem as Urunler;
            UrId = secilen.Id;
            txtBirimAlisFiyati.Text = srepo.UrunFiyatiGetirById(UrId).ToString();
            txtAdet.Focus();
        }

        private void cbTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdet.Focus();
            Tedarikci secilen = cbTedarikciler.SelectedItem as Tedarikci;
            TedId = secilen.Id;
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            foreach (char sayi in txtAdet.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.");
                    txtAdet.Text = txtAdet.Text.Substring(0, txtAdet.Text.Length - 1);
                    txtAdet.Select(txtAdet.Text.Length, 0);
                    return;
                }
            }
        }

        private void ComboboxlariDoldur()
        {
            cbKategoriler.DisplayMember = "KategoriAdi";
            cbKategoriler.ValueMember = "Id";
            cbKategoriler.DataSource = srepo.KategorileriGetir();
            cbKategoriler.SelectedIndex = 0;
            Kategoriler secilen = cbKategoriler.SelectedItem as Kategoriler;
            KatId = secilen.Id;
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
            cbUrunler.DataSource = srepo.UrunleriGetirByKategoriId(KatId);
            cbUrunler.SelectedIndex = 0;
            cbTedarikciler.DisplayMember = "TedarikciAdi";
            cbTedarikciler.ValueMember = "Id";
            cbTedarikciler.DataSource = srepo.TedarikcileriGetir();
            cbTedarikciler.SelectedIndex = 0;
        }

        
    }
}
