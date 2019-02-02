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
            btnSKaldir.Enabled = false;
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
                    txtTutar.Text = TopTutar.ToString();
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
            txtTutar.Text = TopTutar.ToString();
            this.AcceptButton = btnSepeteEkle;
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            if (Miktar > 1)
            {
                Miktar--;
                txtMiktar.Text = Miktar.ToString();
                decimal Fiyat = Convert.ToDecimal(txtFiyat.Text);
                decimal TopTutar = Miktar * Fiyat;
                txtTutar.Text = TopTutar.ToString();
                this.AcceptButton = btnSepeteEkle;
            }
        }
        int r = 0;
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            int Miktar = Convert.ToInt32(txtMiktar.Text);
            if (Miktar>=1 && txtUrunAdi.Text != "")
            {
                lvAlisverisSepeti.Items.Add(txtUrunAdi.Text);
                lvAlisverisSepeti.Items[r].SubItems.Add(txtMiktar.Text);
                lvAlisverisSepeti.Items[r].SubItems.Add(txtFiyat.Text);
                lvAlisverisSepeti.Items[r].SubItems.Add(txtTutar.Text);
                ToplamTutarHesaplat();
                r++;
                btnTemizle.PerformClick();
            }
            else
            {
                if (Miktar < 1)
                {
                    MessageBox.Show("Miktar girdisi 1' den büyük olmalıdır", "Miktar girdisi sıkıntılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMiktar.Focus();
                }
                else
                { 
                    MessageBox.Show("Sepete eklenecek ürün bulunmamaktadır", "Ürün girdisi sıkıntılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarkod.Focus();
                }

            }
        }
        private void ToplamTutarHesaplat()
        {
            decimal ToplamTutar = 0;
            for (int i = 0; i < lvAlisverisSepeti.Items.Count; i++)
            {
                ToplamTutar += Convert.ToDecimal(lvAlisverisSepeti.Items[i].SubItems[3].Text);
            }
            txtToplamTutar.Text = ToplamTutar.ToString();
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
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
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
                txtTutar.Text = TopTutar.ToString();
                btnArttır.Enabled = true;
                btnEksilt.Enabled = true;
                txtMiktar.ReadOnly = false;
                this.AcceptButton = btnSepeteEkle;
                btnSepeteEkle.Focus();
            }
        }

        private void btnSTemizle_Click(object sender, EventArgs e)
        {
            lvAlisverisSepeti.Items.Clear();
            r = 0;
            txtToplamTutar.Text = 0.ToString();
            txtBarkod.Focus();
            btnSKaldir.Enabled = false;
            rbtnNakit.Checked = true;
            txtNakit.Text = "";
            txtParaUstu.Text = "";
            this.AcceptButton = btnBul;
        }

        private void btnSKaldir_Click(object sender, EventArgs e)
        {
            if (lvAlisverisSepeti.Items.Count > 0)
            {
                lvAlisverisSepeti.SelectedItems[0].Remove();
                ToplamTutarHesaplat();
                r--;
                btnSKaldir.Enabled = false;
                btnParaUstuHesapla.PerformClick();
            }
            else
            { 
                txtToplamTutar.Text = 0.ToString();
                btnSKaldir.Enabled = false;
            }
        }

        private void lvAlisverisSepeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSKaldir.Enabled = true;
        }

        private void rbtnKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKrediKarti.Checked)
            {
                txtNakit.Text = "";
                txtParaUstu.Text = "";
                txtNakit.Enabled = false;
                txtParaUstu.Enabled = false;
                btnParaUstuHesapla.Enabled = false;
            }
        }

        private void rbtnNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNakit.Checked)
            {
                txtNakit.Text = "";
                txtParaUstu.Text = "";
                txtNakit.Enabled = true;
                txtParaUstu.Enabled = true;
                btnParaUstuHesapla.Enabled = true;
                txtNakit.Focus();
            }
        }

        private void btnParaUstuHesapla_Click(object sender, EventArgs e)
        {
            decimal Tutar = Convert.ToDecimal(txtToplamTutar.Text);
            decimal Nakit = Convert.ToDecimal(txtNakit.Text);
            decimal PUstu = Nakit - Tutar;
            if (PUstu >= 0)
            {
                txtParaUstu.Text = PUstu.ToString();
                this.AcceptButton = btnIslemKaydet;
            }
            else
            {
                txtNakit.Text = "";
                txtParaUstu.Text = "";
                txtNakit.Focus();
                this.AcceptButton = btnParaUstuHesapla;
            }
        }

        private void txtNakit_TextChanged(object sender, EventArgs e)
        {
            foreach (char sayi in txtNakit.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.", "Yanlış girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNakit.Text = txtNakit.Text.Substring(0, txtNakit.Text.Length - 1);
                    txtNakit.Select(txtNakit.Text.Length, 0);
                    return;
                }
            }
            this.AcceptButton = btnParaUstuHesapla;
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
                                txtTutar.Text = TopTutar.ToString();
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
