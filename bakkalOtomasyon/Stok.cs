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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        StokRepository sr = new StokRepository();
        private void Stok_Load(object sender, EventArgs e)
        {
            DgvDoldurDuzenle();
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "Id";
            cbKategori.DataSource = sr.KategoriGetir();
            dgvStok.DataSource = sr.UrunleriGetir();
        }
        private void DgvDoldurDuzenle()
        {
            dgvStok.DataSource = sr.UrunleriGetir();
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dgvStok.AllowUserToResizeColumns = false;
            dgvStok.AllowUserToResizeRows = false;
            dgvStok.RowHeadersVisible = false;
            dgvStok.BorderStyle = BorderStyle.None;
            dgvStok.BackgroundColor = this.BackColor;
            dgvStok.Columns[0].Visible = false;
            dgvStok.Columns[1].Visible = false;
            dgvStok.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvStok.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvStok.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStok.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvStok.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvStok.Columns[6].Visible = false;
            //dgvStok.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvStok.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStok.Columns[8].Visible = false;
            dgvStok.Columns[9].Visible = false;

        }

        private void Temizle()
        {
            foreach (Control knt in this.Controls)
            {
                if (knt is TextBox)
                {
                    knt.Text = string.Empty;
                }
            }
        }
        int KategoriId,UrunId;

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler secilen = (Kategoriler)cbKategori.SelectedItem;
            txtKategoriSec.Text = secilen.KategoriAdi;
            KategoriId = secilen.Id;
            //dgvStok.DataSource = sr.UrunGetirByKategoriID(KategoriId);
            txtUrunSec.Clear();
            cbUrunSecin.DisplayMember = "UrunAdi";
            cbUrunSecin.ValueMember = "Id";
            cbUrunSecin.DataSource = sr.UrunGetirByKategoriID(KategoriId);
            dgvStok.DataSource = sr.UrunGetirByKategoriID(KategoriId);
        }

        private void txtKategoriSec_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUrunSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urunler secilen = (Urunler)cbUrunSecin.SelectedItem;
            txtUrunSec.Text = secilen.UrunAdi;
            UrunId = secilen.Id;
            cbUrunSecin.DisplayMember = "UrunAdi";
            cbUrunSecin.ValueMember = "Id";
            cbUrunSecin.DataSource = sr.UrunGetirByKategoriID(UrunId);
            dgvStok.DataSource = sr.UrunGetirByUrunID(UrunId);
        }
    }
}
