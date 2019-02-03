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

           
            cbTedarikIcinUrunSecin.DataSource = ter.UrunleriGetirByTedarikciId(tedarikciId);
           
           


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
            decimal birimF = ter.BirimFiyatGetirByUrunAd(cbTedarikIcinUrunSecin.Text,tedarikciId);
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
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add(txtAdet.Text);
            lvUrunler.Items[lvUrunler.Items.Count - 1].SubItems.Add(txtAdet.Text);
        }
    }
}
