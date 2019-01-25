using BLL.Bakkal.Repositories;
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
    public partial class MasrafKayit : Form
    {
        public MasrafKayit()
        {
            InitializeComponent();
        }
        MasrafRepository mr = new MasrafRepository();
        private void Masraf_Load(object sender, EventArgs e)
        {
            BaslangicHalineDon();
        }
        private void DgvDoldurDuzenle()
        {
            //List<Masraf> liste = new List<Masraf>();
            //dgvMasraflar.DataSource = liste;
            dgvMasraflar.DataSource=mr.MasraflariGetir();
            dgvMasraflar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMasraflar.AllowUserToAddRows = false;
            dgvMasraflar.AllowUserToDeleteRows = false;
            dgvMasraflar.AllowUserToResizeColumns = false;
            dgvMasraflar.AllowUserToResizeRows = false;
            dgvMasraflar.RowHeadersVisible = false;
            dgvMasraflar.BorderStyle = BorderStyle.None;
            dgvMasraflar.BackgroundColor = this.BackColor;
            dgvMasraflar.Columns[0].Visible = false;
            dgvMasraflar.Columns[1].HeaderText = "Masraf Adı";
            dgvMasraflar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].HeaderText = "Tutar";
            dgvMasraflar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMasraflar.Columns[3].HeaderText = "Kayıt Tarihi";
            dgvMasraflar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void dgvMasraflar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnDegistir.Enabled = true;
            btnSil.Enabled = false;
            txtMasrafAdi.ReadOnly = false;
            txtMasrafTutari.ReadOnly = false;
            Temizle();
        }
        int Id;
        private void dgvMasraflar_DoubleClick(object sender, EventArgs e)
        {
            txtMasrafAdi.Text = dgvMasraflar.SelectedRows[0].Cells[1].Value.ToString();
            txtMasrafTutari.Text = dgvMasraflar.SelectedRows[0].Cells[2].Value.ToString();
            Id = Convert.ToInt32(dgvMasraflar.SelectedRows[0].Cells[0].Value);
            btnSil.Enabled = true;
            txtMasrafAdi.ReadOnly = true;
            txtMasrafTutari.ReadOnly = true;
            btnVazgec.Visible = true;
            btnKaydet.Enabled=false;
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yapılan değişiklikleri kaydetmek istiyor musunuz ?", "Kayıt işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            else
            {
                BaslangicHalineDon();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen masrafın silinmesini istiyor musunuz ?", "Silme işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mr.MasrafSil(Id))
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
            BaslangicHalineDon();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
        private void BaslangicHalineDon()
        {
            DgvDoldurDuzenle();
            Temizle();
            txtMasrafAdi.ReadOnly = false;
            txtMasrafTutari.ReadOnly = false;
            btnSil.Enabled = false;
            btnVazgec.Visible = false;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            txtMasrafAdi.Focus();
        }
    }
}
