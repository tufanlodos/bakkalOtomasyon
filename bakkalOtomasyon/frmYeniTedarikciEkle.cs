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

        //harf kolonlarına yalnızca harf girilebilir kontrolleri

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //ekleme yaparken aynı var mı kontrolü
         
            Tedarikci td = new Tedarikci();
            td.TedarikciAdi = txtTedarikciAdi.Text;
            td.IletisimNo = txtIletisimNo.Text;
            td.Adres = txtAdres.Text;
            if( txtAdres.Text.Trim() != "" && txtIletisimNo.Text.Trim() != "" && txtTedarikciAdi.Text.Trim() != "" && ter.TedarikciKontrolByKAdi(txtTedarikciAdi.Text) == false)
            {
                ter.YeniTedarikciEkle(td);
                MessageBox.Show("Yeni Tedarikci Eklendi");
                txtTedarikciAdi.Clear();
                txtIletisimNo.Clear();
                txtAdres.Clear();
            }else if(ter.TedarikciKontrolByKAdi(txtTedarikciAdi.Text) == true)
            {
                MessageBox.Show("Var olan bir tedarikçi eklemeye çalıştınız");
                txtTedarikciAdi.Clear();
                txtTedarikciAdi.Focus();
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz");
            }
        
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

        private void txtTedarikciAdi_TextChanged(object sender, EventArgs e)
        {
            
            foreach (char harf in txtTedarikciAdi.Text)
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
                        txtTedarikciAdi.Text = txtTedarikciAdi.Text.Substring(0, txtTedarikciAdi.Text.Length - 1);
                        txtTedarikciAdi.Select(txtTedarikciAdi.Text.Length, 0);

                        return;
                    }
                }
            }

        }

        
    }
}
