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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        KategoriRepository Kr= new KategoriRepository();
        BCDContext ent = new BCDContext();
        int ID;

        private void Kategori_Load(object sender, EventArgs e)
        {
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                Kategoriler yeni = new Kategoriler();
                yeni.KategoriAdi = txtKategoriAdi.Text;
                if (Kr.KategoriKontrol(yeni))
                {
                    MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
                }
                else
                {
                    yeni.Aciklama = txtAciklama.Text;
                    if (Kr.KategoriEkle(yeni))
                    {
                        MessageBox.Show("Yeni kategori eklendi.", "Kayıt gerçekleşti.");
                        dgvKategori.DataSource = Kr.KategoriListele();
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtKategoriAdi.Focus();
        }
        private void Temizle()
        {
            txtKategoriAdi.Clear();
            txtAciklama.Clear();
        }
        private void dgvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells[0].Value);
            txtKategoriAdi.Text = dgvKategori.SelectedRows[0].Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategori.SelectedRows[0].Cells[2].Value == null ? "" : dgvKategori.SelectedRows[0].Cells[2].Value.ToString();
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtKategoriAdi.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                Kategoriler degisen = Kr.KategoriGetirByID(ID);
                degisen.KategoriAdi = txtKategoriAdi.Text;
                degisen.Aciklama = txtAciklama.Text;
                if (Kr.KategoriKontrolFromDegistir(degisen))
                {
                    MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
                }
                else
                {
                    if (Kr.KategoriGuncelle())
                    {
                        MessageBox.Show("Kategori bilgileri değiştirildi.", "Update gerçekleşti.");
                        dgvKategori.DataSource = Kr.KategoriListele();
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtKategoriAdi.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Kr.KategoriSil(ID))
                {
                    MessageBox.Show("Kategori bilgileri silindi.", "Silme gerçekleşti.");
                    dgvKategori.DataSource = Kr.KategoriListele();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }
    }
}
