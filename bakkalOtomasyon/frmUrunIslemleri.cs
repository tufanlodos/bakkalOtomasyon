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
    public partial class frmUrunIslemleri : Form
    {
        public frmUrunIslemleri()
        {
            InitializeComponent();
        }

        KategoriRepository kr = new KategoriRepository();
        UrunRepository ur = new UrunRepository();

        private void frmUrunIslemleri_Load(object sender, EventArgs e)
        {
            if (ur.KritikVarMi())
            {
                lblKritik.Visible = true;
                btnKritikGoruntule.Visible = true;
            }
            BaslangicHalineDon();
            dgvUrunler.ClearSelection();
            Kategoriler tumu = new Kategoriler();
            tumu.Id = 0;
            tumu.KategoriAdi = "Tümü";
            tumu.Aciklama = "";
            List<Kategoriler> liste=kr.KategoriListele();
            liste.Add(tumu);
            cbKategoriSec.DisplayMember = "KategoriAdi";
            cbKategoriSec.ValueMember = "Id";
            cbKategoriSec.DataSource = liste;
        }

        private void BaslangicHalineDon()
        {
            this.AcceptButton = btnYeni;
            DgvDoldurDuzenle(ur.UrunSiralaByUrunAdi("desc",kID));
            dgvUrunler.ClearSelection();
            btnSil.Enabled = false;
            btnVazgec.Visible = false;
            btnYeni.Enabled = true;
            btnDegistir.Enabled = false;
            cbSiralama.SelectedIndex = 0;
        }
        int UrunId,kID;
        int SecilenSatir;

        int HeaderText = 0;
        private void DgvDoldurDuzenle(List<Urunler> liste)
        {
            dgvUrunler.DataSource = liste;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.AllowUserToResizeColumns = false;
            dgvUrunler.AllowUserToResizeRows = false;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.BorderStyle = BorderStyle.None;
            dgvUrunler.BackgroundColor = this.BackColor;
            dgvUrunler.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.7F, FontStyle.Bold);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Columns[0].Visible = false;
            dgvUrunler.Columns[1].HeaderText = "Ürün Kodu";
            dgvUrunler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[2].HeaderText = "Ürün Markası";
            dgvUrunler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[3].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[4].HeaderText = "Satış Fiyatı";
            dgvUrunler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunler.Columns[5].HeaderText = "Alış Fiyatı";
            dgvUrunler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunler.Columns[6].Visible = false;
            dgvUrunler.Columns[7].HeaderText = "Stok Miktarı";
            dgvUrunler.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunler.Columns[8].Visible = false;
            dgvUrunler.Columns[9].HeaderText = "Kategori Adı";
            dgvUrunler.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HeaderText++;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            BaslangicHalineDon();
        }
        
        private void dgvUrunler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (HeaderText >= 1)
            {
                dgvUrunler.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dgvUrunler.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                btnDegistir.Enabled = true;
                this.AcceptButton = btnDegistir;
                btnSil.Enabled = false;
                btnVazgec.Visible = true;
            }
        }

        private void dgvUrunler_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                UrunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                return;
            }
            if (UrunId > 0)
            {
                btnSil.Enabled = true;
                this.AcceptButton = btnSil;
                btnDegistir.Enabled = false;
                btnVazgec.Visible = true;
                btnYeni.Enabled = false;
            }
            if (SecilenSatir >= 0)
            {
                dgvUrunler.Rows[SecilenSatir].DefaultCellStyle.BackColor = Color.White;
            }
            if (!btnDegistir.Enabled)
            {
                dgvUrunler.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (ur.UrunGuncelle())
            {
                MessageBox.Show("Ürün kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaslangicHalineDon();
            }
            else
            {
                MessageBox.Show("Ürün kayıtları üzerindeki güncellemeler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BaslangicHalineDon();
            }
        }

        private void cbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArama.Text = "";
           if (cbSiralama.SelectedIndex == 0)
                dgvUrunler.DataSource = ur.UrunSiralaByUrunAdi("asc",kID);
               
           if (cbSiralama.SelectedIndex == 1)
                dgvUrunler.DataSource = ur.UrunSiralaByUrunAdi("desc", kID);
                
           if (cbSiralama.SelectedIndex == 2)
                dgvUrunler.DataSource = ur.UrunSiralaByKategoriAdi("asc", kID);
           
           if (cbSiralama.SelectedIndex == 3)
                dgvUrunler.DataSource = ur.UrunSiralaByKategoriAdi("desc", kID);

           if (cbSiralama.SelectedIndex == 4)
                dgvUrunler.DataSource = ur.UrunSiralaByStok("asc", kID);

            if (cbSiralama.SelectedIndex == 5)
                dgvUrunler.DataSource = ur.UrunSiralaByStok("desc", kID);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = ur.UrunGetirByUrunAdi(txtArama.Text);
            cbKategoriSec.SelectedIndex = cbKategoriSec.Items.Count-1;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            ur.ContextteBekleyenleriTemizle();
            BaslangicHalineDon();
            this.AcceptButton = btnYeni;
            btnYeni.Focus();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen ürünün silinmesini istiyor musunuz ?", "Silme işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ur.UrunSil(UrunId))
                {
                    MessageBox.Show("Ürün kayıtları üzerindeki silme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaslangicHalineDon();

                }
                else
                {
                    MessageBox.Show("Ürün kayıtları üzerindeki silme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BaslangicHalineDon();

                }
            }
            else
            {
                BaslangicHalineDon();
            }
        }

        

        private void cbKategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArama.Text = "";
            Kategoriler secilenK = (Kategoriler)cbKategoriSec.SelectedItem;
            kID = secilenK.Id;
            if (kID == 0)
                dgvUrunler.DataSource = ur.UrunleriGetir();
            else
                dgvUrunler.DataSource = ur.UrunGetirByKategoriID(kID);

        }
    }
}
