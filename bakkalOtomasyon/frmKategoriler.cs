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
        int ID,HeaderText=0;

        private void Kategori_Load(object sender, EventArgs e)
        {
            DgvDoldurDuzenle();
            txtArama.Focus();
            this.AcceptButton = btnYeni;
            dgvKategori.ClearSelection();
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
            dgvKategori.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgvKategori.MultiSelect = false;
            dgvKategori.BorderStyle = BorderStyle.None;
            dgvKategori.BackgroundColor = this.BackColor;
            dgvKategori.Columns[0].Visible = false;
            dgvKategori.Columns[1].HeaderText = "Kategori Adı";
            dgvKategori.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKategori.Columns[2].HeaderText = "Açıklama";
            dgvKategori.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKategori.Columns[3].Visible = false;
            txtArama.Text = "";
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            HeaderText++;
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
                    btnVazgec.Visible = false;
                    btnGuncelle.Enabled = false;
                }
            }
        }
        int SecilenSatir;
        private void dgvKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
        }
        private void dgvKategori_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                return;
            }
            if (ID > 0)
            {
                if (!btnGuncelle.Enabled)
                {
                    btnSil.Enabled = true;
                }
                btnVazgec.Visible = true;
                btnYeni.Enabled = false;
                this.AcceptButton = btnSil;
            }
            if (SecilenSatir >= 0)
            {
                dgvKategori.Rows[SecilenSatir].DefaultCellStyle.BackColor = Color.White;
            }
            if (!btnGuncelle.Enabled)
            {
                dgvKategori.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dgvKategori_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (HeaderText >= 1)
            {
                dgvKategori.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dgvKategori.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                btnGuncelle.Enabled = true;
                this.AcceptButton = btnGuncelle;
                btnSil.Enabled = false;
                btnVazgec.Visible = true;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnVazgec.Visible = false;
            frmKategoriEkle frm = new frmKategoriEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            DgvDoldurDuzenle();
            txtArama.Focus();
            this.AcceptButton = btnYeni;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Kr.ContextteBekleyenleriTemizle();
            btnSil.Enabled = false;
            btnYeni.Enabled = true;
            btnGuncelle.Enabled = false;
            btnVazgec.Visible = false;
            DgvDoldurDuzenle();
            txtArama.Focus();
            this.AcceptButton = btnYeni;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Kr.KategoriGuncelle())
            {
                MessageBox.Show("Kategori kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDoldurDuzenle();
                btnGuncelle.Enabled = false;
                btnVazgec.Visible = false;
                btnYeni.Enabled = true;
                this.AcceptButton = btnYeni;
                txtArama.Focus();
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

