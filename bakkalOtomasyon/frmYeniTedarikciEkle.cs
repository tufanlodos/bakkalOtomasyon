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
    public partial class frmYeniTedarikciEkle : Form
    {
        public frmYeniTedarikciEkle()
        {
            InitializeComponent();
        }
        TedarikEkraniRepository ter = new TedarikEkraniRepository();
       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tedarikci td = new Tedarikci();
            td.TedarikciAdi = txtTedarikciAdi.Text;
            td.IletisimNo = txtIletisimNo.Text;
            td.Adres = txtAdres.Text;
            ter.YeniTedarikciEkle(td);
            MessageBox.Show("Yeni Tedarikci Eklendi");
            txtTedarikciAdi.Clear();
            txtIletisimNo.Clear();
            txtAdres.Clear();
            





        }

        private void txtIletisimNo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char sayi in txtIletisimNo.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.");
                    txtIletisimNo.Text = txtIletisimNo.Text.Substring(0, txtIletisimNo.Text.Length - 1);
                    txtIletisimNo.Select(txtIletisimNo.Text.Length, 0);
                    return;

                }
            }
        }
    }
}
