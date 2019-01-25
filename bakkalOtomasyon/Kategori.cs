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
            DgvDoldurDuzenle();
        }
        private void DgvDoldurDuzenle()
        {
            dgvKategori.DataSource = Kr.KategoriListele();
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.AllowUserToDeleteRows = false;
            dgvKategori.AllowUserToResizeColumns = false;
            dgvKategori.AllowUserToResizeRows = false;
            dgvKategori.RowHeadersVisible = false;
            dgvKategori.BorderStyle = BorderStyle.None;
            dgvKategori.BackgroundColor = this.BackColor;
        }
        private void Temizle()
        {
            txtKategoriAdi.Clear();
            txtAciklama.Clear();
        }
       
        private void btnSil_Click(object sender, EventArgs e)
        {  
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Kr.KategoriSil(ID))
                {
                    MessageBox.Show("Kategori bilgileri silindi.", "Silme gerçekleşti.");
                    dgvKategori.DataSource = Kr.KategoriListele();
                 
                    btnSil.Enabled = false;
                    Temizle();
                    txtKategoriAdi.ReadOnly = false;
                    txtAciklama.ReadOnly = false;
                    btnEkle.Enabled = true;
                }
            }
        }

        private void dgvKategori_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells[0].Value);
            txtKategoriAdi.Text = dgvKategori.SelectedRows[0].Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategori.SelectedRows[0].Cells[2].Value == null ? "" : dgvKategori.SelectedRows[0].Cells[2].Value.ToString();
            txtKategoriAdi.ReadOnly = true;
            txtAciklama.ReadOnly = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = false;
            

            
            txtKategoriAdi.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
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
                      
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
            txtKategoriAdi.Focus();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
            btnSil.Enabled = false;
            txtKategoriAdi.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            btnEkle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Kr.KategoriGuncelle())
            {
                MessageBox.Show("Kategori kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDoldurDuzenle();
                Temizle();
                btnGuncelle.Enabled = false;
            }
            else
                MessageBox.Show("Masraf kayıtları üzerindeki güncelleme    //private void txtArama_TextChanged(object sender, EventArgs e)
        //{
        //    txtArama.Text = (from c in ent.Kategorilers
        //                     where KategoriAdi == '%%'
        //}ler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    
    }
}
