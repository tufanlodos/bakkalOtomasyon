using BLL.Bakkal.Repositories;
using DAL.Bakkal.DataModel;
using DAL.Bakkal.Models;
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
    public partial class frmSatisEkrani : Form
    {
        public frmSatisEkrani()
        {
            InitializeComponent();
        }
        int Miktar = 0 , IlkAcilis = 0;
        SatisRepo sr = new SatisRepo();
        private void frmSatisEkrani_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnBul;
            txtBarkod.Focus();
            Miktar = 1;
            txtMiktar.Text = Miktar.ToString();
            rbtnNakit.Checked = true;
            btnArttır.Enabled = false;
            btnEksilt.Enabled = false;
            txtMiktar.ReadOnly = true;
            IlkAcilis++;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarkod.Text.Trim()))
            {
                if (sr.UrunBul(txtBarkod.Text) != null)
                {
                    Urunler u = sr.UrunBul(txtBarkod.Text);
                    txtUrunAdi.Text = u.UrunAdi;
                    txtFiyat.Text = u.SatisFiyat.ToString();
                    decimal TopTutar = Miktar * u.SatisFiyat;
                    txtTutar.Text = TopTutar.ToString("c");
                    btnArttır.Enabled = true;
                    btnEksilt.Enabled = true;
                    txtMiktar.ReadOnly = false;
                    btnUrunSec.Enabled = false;
                    this.AcceptButton = btnSepeteEkle;

                }
                else
                {   
                    MessageBox.Show("Doğru bir barkod kodu girildiğinden emin olun", "Ürün bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarkod.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Barkod girişi yapmalısınız", "Barkod numarası girilmemiş",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarkod.Focus();
            }
        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            Miktar++;
            txtMiktar.Text = Miktar.ToString();
            decimal Fiyat = Convert.ToDecimal(txtFiyat.Text);
            decimal TopTutar = Miktar * Fiyat;
            txtTutar.Text = TopTutar.ToString("c");
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            if (Miktar > 1)
            {
                Miktar--;
                txtMiktar.Text = Miktar.ToString();
                decimal Fiyat = Convert.ToDecimal(txtFiyat.Text);
                decimal TopTutar = Miktar * Fiyat;
                txtTutar.Text = TopTutar.ToString("c");
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            int Miktar = Convert.ToInt32(txtMiktar.Text);
            if (Miktar>=1)
            {

            }
            else
            {
                MessageBox.Show("Miktar girdisi 1' den büyük olmalıdır", "Miktar girilmemiş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMiktar.Focus();
            }

        }

        private void txtMiktar_MouseClick(object sender, MouseEventArgs e)
        {
            txtMiktar.Select(txtMiktar.Text.Length, 0);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = string.Empty;
            txtBarkod.ReadOnly = false;
            txtUrunAdi.Text = string.Empty;
            txtFiyat.Text = string.Empty;
            txtTutar.Text = string.Empty;
            this.AcceptButton = btnBul;
            Miktar = 1;
            txtMiktar.Text = Miktar.ToString();
            btnArttır.Enabled = false;
            btnEksilt.Enabled = false;
            txtMiktar.ReadOnly = true;
            btnUrunSec.Enabled = true;
            Genel.UrunAdi = "";
            Genel.SecimYapildi = false;
            txtBarkod.Focus();
            
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            frmUrunBul frm = new frmUrunBul();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (Genel.SecimYapildi)
            {
                Urunler u = sr.AdaGoreUrunBul(Genel.UrunAdi);
                txtBarkod.Text = "";
                txtBarkod.ReadOnly = true;
                txtUrunAdi.Text = u.UrunAdi;
                txtFiyat.Text = u.SatisFiyat.ToString();
                decimal TopTutar = Miktar * u.SatisFiyat;
                txtTutar.Text = TopTutar.ToString("c");
                btnArttır.Enabled = true;
                btnEksilt.Enabled = true;
                txtMiktar.ReadOnly = false;
                this.AcceptButton = btnSepeteEkle;
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (IlkAcilis >= 1)
            {
                foreach (char sayi in txtMiktar.Text)
                {
                    if (!char.IsDigit(sayi))
                    {
                            MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.","Yanlış girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMiktar.Text = "1";
                            return;
                    }
                    else
                    {
                            int Miktar = Convert.ToInt32(txtMiktar.Text);
                            if (Miktar > 0)
                            {
                                decimal Fiyat = Convert.ToDecimal(txtFiyat.Text);
                                decimal TopTutar = Miktar * Fiyat;
                                txtTutar.Text = TopTutar.ToString("c");
                            }
                            else
                            {
                                MessageBox.Show("Miktar en az 1 olmalıdır", "Miktar girişi yanlışlığı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMiktar.Text = "1";
                                txtMiktar.Focus();
                            }
                    }
                }
            }
            else
                return;
        }
    }
}
