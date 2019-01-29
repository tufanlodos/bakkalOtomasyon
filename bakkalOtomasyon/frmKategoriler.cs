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
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        KategoriRepository Kr = new KategoriRepository();
        BCDContext ent = new BCDContext();
        int ID;

        private void Kategori_Load(object sender, EventArgs e)
        {
            DgvDoldurDuzenle();
            txtArama.Focus();
            this.AcceptButton = btnYeni;
        }
        private void DgvDoldurDuzenle()
        {
            dgvKategori.DataSource = Kr.KategoriListele();
            dgvKategori.Columns[0].Visible = false;
            dgvKategori.Columns[3].Visible = false;
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.AllowUserToDeleteRows = false;
            dgvKategori.AllowUserToResizeColumns = false;
            dgvKategori.AllowUserToResizeRows = false;
            dgvKategori.RowHeadersVisible = false;
            dgvKategori.BorderStyle = BorderStyle.None;
            dgvKategori.BackgroundColor = this.BackColor;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgvKategori.ClearSelection();

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
                    btnYeni.Enabled = true;
                }
            }
        }

        private void dgvKategori_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells[0].Value);
            btnSil.Enabled = true;
            btnYeni.Enabled = false;
            btnGuncelle.Enabled = true;
            btnVazgec.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtKategoriAdi.Text))
            //{
            //    Kategoriler yeni = new Kategoriler();
            //    yeni.KategoriAdi = txtKategoriAdi.Text;
            //    if (Kr.KategoriKontrol(yeni))
            //    {
            //        MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
            //    }
            //    else
            //    {
            //        yeni.Aciklama = txtAciklama.Text;
            //        if (Kr.KategoriEkle(yeni))
            //        {
            //            MessageBox.Show("Yeni kategori eklendi.", "Kayıt gerçekleşti.");
            //            dgvKategori.DataSource = Kr.KategoriListele();

            //            Temizle();
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //Temizle();
            //txtKategoriAdi.Focus();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnYeni.Enabled = true;
            btnGuncelle.Enabled = false;
            btnVazgec.Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Kr.KategoriGuncelle())
            {
                MessageBox.Show("Kategori kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDoldurDuzenle();
                btnGuncelle.Enabled = false;
            }
            else
            {
                MessageBox.Show("Kategori kayıtları üzerindeki güncellemeler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DgvDoldurDuzenle();

            }


        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvKategori.DataSource = Kr.KategoriGetirByArama(txtArama.Text);
        }
    }
}

