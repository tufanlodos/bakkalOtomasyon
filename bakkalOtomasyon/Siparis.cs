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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        SiparisRepository srepo = new SiparisRepository();
        int KatId, UrId;
        private void Siparis_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
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
        private void Temizle()
        {
            foreach (Control knt in this.Controls)
            {
                if (knt is TextBox)
                {
                    knt.Text = string.Empty;
                }
            }
        }

        private void cbTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdet.Focus();
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
        
    }
}
