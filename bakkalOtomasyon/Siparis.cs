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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        SiparisRepository srepo = new SiparisRepository();
        int KatId, UrId,HeaderText = 0, SilinecekId;
        private void Siparis_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
            DgvDoldurDuzenle();
        }
        private void ComboboxlariDoldur()
        {
            cbKategoriler.DisplayMember = "KategoriAdi";
            cbKategoriler.ValueMember = "Id";
            cbKategoriler.DataSource = srepo.KategorileriGetir();
            cbKategoriler.SelectedIndex = 0;
            Kategoriler secilen = cbKategoriler.SelectedItem as Kategoriler;
            KatId = secilen.Id;
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
            cbUrunler.DataSource = srepo.UrunleriGetirByKategoriId(KatId);
            cbUrunler.SelectedIndex = 0;
            cbTedarikciler.DisplayMember = "TedarikciAdi";
            cbTedarikciler.ValueMember = "Id";
            cbTedarikciler.DataSource = srepo.TedarikcileriGetir();
            cbTedarikciler.SelectedIndex = 0;
            cbSiralama.SelectedIndex = 0;
        }
        private void DgvDoldurDuzenle()
        {
            dgvSiparisler.DataSource = srepo.SiparisleriGetir();
            dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.AllowUserToResizeColumns = false;
            dgvSiparisler.AllowUserToResizeRows = false;
            dgvSiparisler.RowHeadersVisible = false;
            dgvSiparisler.BorderStyle = BorderStyle.None;
            dgvSiparisler.BackgroundColor = this.BackColor;
            dgvSiparisler.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma",9, FontStyle.Bold);
            dgvSiparisler.MultiSelect = false;
            dgvSiparisler.Columns[0].Visible = false;
            dgvSiparisler.Columns[1].HeaderText = "Tedarikçi Adı";
            dgvSiparisler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[2].HeaderText = "Ürün Adı";
            dgvSiparisler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[3].HeaderText = "Miktar";
            dgvSiparisler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSiparisler.Columns[4].HeaderText = "Tutar";
            dgvSiparisler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSiparisler.Columns[5].HeaderText = "Kayıt Tarihi";
            dgvSiparisler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HeaderText++;
        }
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler secilen = cbKategoriler.SelectedItem as Kategoriler;
            KatId = secilen.Id;
            cbUrunler.DataSource = srepo.UrunleriGetirByKategoriId(KatId);
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
            txtAdet.Focus();
        }
        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urunler secilen = cbUrunler.SelectedItem as Urunler;
            UrId = secilen.Id;
            txtBirimAlisFiyati.Text = srepo.UrunFiyatiGetirById(UrId).ToString();
            txtAdet.Focus();
        }
        private void cbTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdet.Focus();
        }
        int SecilenSatir;
        private void dgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
        }
        private void dgvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SilinecekId = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                return; 
            }
            if (SilinecekId>=0)
            {
                if (!btnGuncelle.Enabled)
                {
                    btnSil.Enabled = true;
                }
                btnVazgec.Visible = true;
                this.AcceptButton = btnSil;
            }
            if (SecilenSatir >= 0)
            {
                dgvSiparisler.Rows[SecilenSatir].DefaultCellStyle.BackColor = Color.White;
            }
            if (!btnGuncelle.Enabled)
            {
                dgvSiparisler.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnVazgec.Visible = false;
            DgvDoldurDuzenle();
            cbSiralama.SelectedIndex = 0;
            dgvSiparisler.ClearSelection();
            this.AcceptButton = btnEkle;
        }

        private void dgvSiparisler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (HeaderText >= 1)
            {
                dgvSiparisler.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dgvSiparisler.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                btnVazgec.Visible = true;
                btnGuncelle.Enabled = true;
                this.AcceptButton = btnGuncelle;
                btnSil.Enabled = false;
            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
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
        
    }
}
