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
    public partial class frmTedarikEkrani : Form
    {
        public frmTedarikEkrani()
        {
            InitializeComponent();
        }
        TedarikEkraniRepository ter = new TedarikEkraniRepository();
        int tedarikciId;
        decimal toplamTutar;
        private void TedarikEkrani_Load(object sender, EventArgs e)
        {
            cbTedarikciSecin.DisplayMember = "TedarikciAdi";
            cbTedarikciSecin.ValueMember = "Id";
            cbTedarikciSecin.DataSource = ter.TedarikciListele();
            
        }

        private void cbTedarikciSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBirimFiyat.Clear();
            txtAdet.Clear();
            Tedarikci t = new Tedarikci();
            Tedarikci secilen = (Tedarikci)cbTedarikciSecin.SelectedItem;
            tedarikciId = secilen.Id;
            t = ter.TedarikciGetirbByID(tedarikciId);


            
            txtAdSoyad.Text = t.TedarikciAdi;
            txtTelefonNumarasi.Text = t.IletisimNo;
            txtAdres.Text = t.Adres;

            lbTedarikEdilmisUrunler.DataSource = ter.UrunleriGetirByTedarikciId(tedarikciId);

           
            cbTedarikIcinUrunSecin.DataSource = ter.DistinctUrunleriGetir();
           
           


        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void lvTedarikEdilmisUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTedarikIcinUrunSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal birimF = ter.BirimFiyatGetirByUrunAd(cbTedarikIcinUrunSecin.Text);
            txtBirimFiyat.Text = birimF.ToString();
        }

       
        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {

            lvUrunler.Items.Add(txtAdSoyad.Text) ;
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add(cbTedarikIcinUrunSecin.SelectedItem.ToString());
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add(txtBirimFiyat.Text);
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add(txtAdet.Text);
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add((Convert.ToDecimal(txtBirimFiyat.Text) * Convert.ToInt32(txtAdet.Text)).ToString());
            ToplamTutarHesapla();
            txtAdet.Clear();
            txtAdet.Focus();
            txtBirimFiyat.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lvUrunler.SelectedItems[0].Remove();
            ToplamTutarHesapla();
            txtAdet.Clear();
            txtAdet.Focus();
            txtBirimFiyat.Clear();
        }
    

        private void ToplamTutarHesapla()
        {
            toplamTutar = 0;
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                toplamTutar += Convert.ToDecimal(lvUrunler.Items[i].SubItems[4].Text);

            }
            txtToplamTutar.Text = toplamTutar.ToString();
            if (toplamTutar != 0)
                btnIslemiKaydet.Enabled = true;
            if (txtToplamTutar.Text == "0")
                btnIslemiKaydet.Enabled = false;
        }

        private void btnIslemiKaydet_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                TedarikDetay td = new TedarikDetay();
                td.TedarikciId = ter.TedarikciIdGetirByTedarikciAdi(lvUrunler.Items[i].Text);
                td.UrunId = ter.UrunIdGetirByUrunAdi(lvUrunler.Items[i].SubItems[1].Text);
                td.BirimTutar = Convert.ToDecimal(lvUrunler.Items[i].SubItems[2].Text);
                td.Adet = Convert.ToInt32(lvUrunler.Items[i].SubItems[3].Text);
                td.ToplamTutar = Convert.ToDecimal(lvUrunler.Items[i].SubItems[4].Text);
                td.IslemTarihi = DateTime.Now;
                ter.TedarikDetayEkle(td);
                ter.UrunStokMiktariniArttir(td.UrunId, td.Adet);
            }
            MessageBox.Show("Yeni Tedarikler Eklendi");
            Temizle();
            lvUrunler.Items.Clear();
            lbTedarikEdilmisUrunler.Items.Clear();
        }

        private void btnYeniTedarikci_Click(object sender, EventArgs e)
        {
            frmYeniTedarikciEkle frm = new frmYeniTedarikciEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void Temizle()
        {
            foreach (Control knt in this.Controls)
            {
                if (knt is TextBox)
                {
                    knt.Text = "";
                }
            }
        }
    }
}
