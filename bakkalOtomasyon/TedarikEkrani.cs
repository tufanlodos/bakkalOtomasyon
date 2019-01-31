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
    public partial class TedarikEkrani : Form
    {
        public TedarikEkrani()
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
            Tedarikci t = new Tedarikci();
            Tedarikci secilen = (Tedarikci)cbTedarikciSecin.SelectedItem;
            tedarikciId = secilen.Id;
            t = ter.TedarikciGetirbByID(tedarikciId);


            
            txtAdSoyad.Text = t.TedarikciAdi;
            txtTelefonNumarasi.Text = t.IletisimNo;
            txtAdres.Text = t.Adres;
            lbTedarikEdilmisUrunler.DataSource = ter.UrunleriGetirByTedarikciId(tedarikciId);
          

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTedarikIcinUrunSecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvTedarikEdilmisUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
