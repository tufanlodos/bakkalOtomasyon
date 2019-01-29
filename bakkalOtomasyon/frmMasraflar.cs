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
    public partial class frmMasraflar : Form
    {
        public frmMasraflar()
        {
            InitializeComponent();
        }
        MasrafRepository mr = new MasrafRepository();
        BCDContext ent = new BCDContext();
        List<Masraf> liste = new List<Masraf>();
        int HeaderText=0;
        private void Masraf_Load(object sender, EventArgs e)
        {
            BaslangicHalineDon();
            dgvMasraflar.ClearSelection();
        }
        private void DgvDoldurDuzenle(List<Masraf> liste)
        {
            dgvMasraflar.DataSource = liste;
            dgvMasraflar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMasraflar.AllowUserToAddRows = false;
            dgvMasraflar.AllowUserToDeleteRows = false;
            dgvMasraflar.AllowUserToResizeColumns = false;
            dgvMasraflar.AllowUserToResizeRows = false;
            dgvMasraflar.RowHeadersVisible = false;
            dgvMasraflar.BorderStyle = BorderStyle.None;
            dgvMasraflar.BackgroundColor = this.BackColor;
            dgvMasraflar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgvMasraflar.MultiSelect = false;
            dgvMasraflar.Columns[0].Visible = false;
            dgvMasraflar.Columns[1].HeaderText = "Masraf Adı";
            dgvMasraflar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].HeaderText = "Tutar";
            dgvMasraflar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMasraflar.Columns[3].HeaderText = "Kayıt Tarihi";
            dgvMasraflar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HeaderText++;
        }
        private void dgvMasraflar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (HeaderText >= 1)
            {
                dgvMasraflar.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dgvMasraflar.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                btnDegistir.Enabled = true;
                this.AcceptButton = btnDegistir;
                btnSil.Enabled = false;
                btnVazgec.Visible = true;
            }
        }
        int SecilenSatir;
        private void dgvMasraflar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
        }
        int MasrafId;
        private void dgvMasraflar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
            MasrafId = Convert.ToInt32(dgvMasraflar.SelectedRows[0].Cells[0].Value);
            }
            catch(Exception)
            {
                return;
            }
            if(MasrafId>0)
            { 
            btnSil.Enabled = true;
            this.AcceptButton = btnSil;
            btnDegistir.Enabled = false;
            btnVazgec.Visible = true;
            btnYeni.Enabled=false;
            }
            if (SecilenSatir >= 0)
            {
                dgvMasraflar.Rows[SecilenSatir].DefaultCellStyle.BackColor = Color.White;
            }
            if (!btnDegistir.Enabled)
            {
                dgvMasraflar.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
            }

        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
                if (mr.MasrafDegistir())
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
            if (MessageBox.Show("Seçilen masrafın silinmesini istiyor musunuz ?", "Silme işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mr.MasrafSil(MasrafId))
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
            mr.ContextteBekleyenleriTemizle();
            this.AcceptButton = btnYeni;
            BaslangicHalineDon();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmMasrafEkle frm = new frmMasrafEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            BaslangicHalineDon();
        }

        private void BaslangicHalineDon()
        {
            this.AcceptButton = btnYeni;
            DgvDoldurDuzenle(mr.TariheGoreMasrafSirala("desc"));
            dgvMasraflar.ClearSelection();
            btnSil.Enabled = false;
            btnVazgec.Visible = false;
            btnYeni.Enabled = true;
            btnDegistir.Enabled = false;
            cbSiralama.SelectedIndex = 0;
        }

        private void cbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSiralama.SelectedIndex == 0)
            {
                dgvMasraflar.DataSource = mr.TariheGoreMasrafSirala("desc");
            }
            if (cbSiralama.SelectedIndex == 1)
            {
                dgvMasraflar.DataSource = mr.TariheGoreMasrafSirala("asc");
            }
            if (cbSiralama.SelectedIndex == 2)
            {
                dgvMasraflar.DataSource = mr.TutaraGoreMasrafSirala("desc");
            }
            if (cbSiralama.SelectedIndex == 3)
            {
                dgvMasraflar.DataSource = mr.TutaraGoreMasrafSirala("asc");
            }
        }
        
    }
}
