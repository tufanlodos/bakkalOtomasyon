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

        

        private void frmUrunIslemleri_Load(object sender, EventArgs e)
        {
            BaslangicHalineDon();
            dgvUrunler.ClearSelection();
        }
        KategoriRepository kr = new KategoriRepository();
        UrunRepository ur = new UrunRepository();
        private void BaslangicHalineDon()
        {
            this.AcceptButton = btnYeni;
            DgvDoldurDuzenle(ur.("desc"));
            dgvUrunler.ClearSelection();
            btnSil.Enabled = false;
            btnVazgec.Visible = false;
            btnYeni.Enabled = true;
            btnDegistir.Enabled = false;
            cbSiralama.SelectedIndex = 0;
        }
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
            dgvUrunler.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Columns[0].Visible = false;
            dgvUrunler.Columns[1].HeaderText = "Kategori Adı";
            dgvUrunler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[2].HeaderText = "Ürün Markası";
            dgvUrunler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[3].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[4].HeaderText = "Tutar";
            dgvUrunler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUrunler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunler.Columns[5].HeaderText = "Kayıt Tarihi";
            dgvUrunler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HeaderText++;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            BaslangicHalineDon();
        }
        int UrunId;
        int SecilenSatir;
        int HeaderText = 0;
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
        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
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
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (ur.UrunGuncelle())
            {
                MessageBox.Show("Masraf kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaslangicHalineDon();
            }
            else
            {
                MessageBox.Show("Masraf kayıtları üzerindeki güncellemeler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BaslangicHalineDon();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen ürünün silinmesini istiyor musunuz ?", "Silme işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ur.UrunSil(UrunId))
                {
                    MessageBox.Show("Masraf kayıtları üzerindeki silme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaslangicHalineDon();

                }
                else
                {
                    MessageBox.Show("Masraf kayıtları üzerindeki silme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BaslangicHalineDon();

                }
            }
            else
            {
                BaslangicHalineDon();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            ur.ContextteBekleyenleriTemizle();
            BaslangicHalineDon();
            this.AcceptButton = btnYeni;
            btnYeni.Focus();
        }

        private void cbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSiralama.SelectedIndex == 0)
            {
                dgvUrunler.DataSource = ur.UrunSiralaByUrunAdi("desc");
            }
            if (cbSiralama.SelectedIndex == 1)
            {
                dgvUrunler.DataSource = ur.UrunSiralaByUrunAdi("asc");
            }
            //if (cbSiralama.SelectedIndex == 2)
            //{
            //    dgvMasraflar.DataSource = mr.TutaraGoreMasrafSirala("desc");
            //}
            //if (cbSiralama.SelectedIndex == 3)
            //{
            //    dgvMasraflar.DataSource = mr.TutaraGoreMasrafSirala("asc");
            //}
        }
    }
}
