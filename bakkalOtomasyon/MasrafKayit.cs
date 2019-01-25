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
    public partial class MasrafKayit : Form
    {
        public MasrafKayit()
        {
            InitializeComponent();
        }
        MasrafRepository mr = new MasrafRepository();
        BCDContext ent = new BCDContext();
        private void Masraf_Load(object sender, EventArgs e)
        {
            BaslangicHalineDon();
        }
        private void DgvDoldurDuzenle()
        {
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
            //dgvMasraflar.Columns[1].HeaderText = "Masraf Adı";
            dgvMasraflar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgvMasraflar.Columns[2].HeaderText = "Tutar";
            dgvMasraflar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvMasraflar.Columns[3].HeaderText = "Kayıt Tarihi";
            dgvMasraflar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void dgvMasraflar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvMasraflar.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
            btnDegistir.Enabled = true;
            btnSil.Enabled = false;
            txtMasrafAdi.ReadOnly = false;
            txtMasrafTutari.ReadOnly = false;
            btnVazgec.Visible = false;
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
            if (!string.IsNullOrEmpty(txtMasrafAdi.Text) && !string.IsNullOrEmpty(txtMasrafTutari.Text))
            {
                Masraf m = new Masraf();
                m.MasrafAdi = txtMasrafAdi.Text;
                m.Tutar = Convert.ToDecimal(txtMasrafTutari.Text);
                if (mr.MasrafEkle(m))
                {
                    MessageBox.Show("Masraf kayıtlarına yeni kayıt ekleme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaslangicHalineDon();
                }
                else
                {
                    MessageBox.Show("Masraf kayıtlarına yeni kayıt ekleme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BaslangicHalineDon();

                }
            }
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

        private void txtMasrafAdi_TextChanged(object sender, EventArgs e)
        {
            foreach (char harf in txtMasrafAdi.Text)
            {
                if (!char.IsLetter(harf))
                {
                    MessageBox.Show("Bu alana sadece harf girişi yapılabilir.");
                    txtMasrafAdi.Text = txtMasrafAdi.Text.Substring(0, txtMasrafAdi.Text.Length - 1);
                    txtMasrafAdi.Select(txtMasrafAdi.Text.Length, 0);    
                    return;
                }
            }
        }

        private void txtMasrafTutari_TextChanged(object sender, EventArgs e)
        {
            foreach (char sayi in txtMasrafTutari.Text)
            {
                if (!char.IsDigit(sayi))
                {
                    if (sayi == ',')
                    {
                        return;
                    }
                    else
                    { 
                        MessageBox.Show("Bu alana sadece rakam girişi yapılabilir.");
                        txtMasrafTutari.Text = txtMasrafTutari.Text.Substring(0, txtMasrafTutari.Text.Length - 1);
                        txtMasrafTutari.Select(txtMasrafTutari.Text.Length, 0);
                        return;
                    }
                }
            }
        }
    }
}
