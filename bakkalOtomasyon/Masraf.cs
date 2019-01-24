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
    public partial class Masraf : Form
    {
        public Masraf()
        {
            InitializeComponent();
        }
        MasrafRepository mr = new MasrafRepository();
        private void Masraf_Load(object sender, EventArgs e)
        {
            DgvDoldurDuzenle();   
        }
        private void DgvDoldurDuzenle()
        {
            dgvMasraflar.DataSource = mr.MasraflariGetir();
            dgvMasraflar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMasraflar.AllowUserToAddRows = false;
            dgvMasraflar.AllowUserToDeleteRows = false;
            dgvMasraflar.AllowUserToResizeColumns = false;
            dgvMasraflar.AllowUserToResizeRows = false;
            dgvMasraflar.RowHeadersVisible = false;
            dgvMasraflar.BorderStyle = BorderStyle.None;
            dgvMasraflar.BackgroundColor = this.BackColor;
            dgvMasraflar.Columns[0].Visible = false;
            dgvMasraflar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMasraflar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMasraflar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (mr.MasrafDegistir())
            { 
                MessageBox.Show("Masraf kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDoldurDuzenle();
                Temizle();
                btnGuncelle.Enabled = false;
            }
            else
                MessageBox.Show("Masraf kayıtları üzerindeki güncellemeler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvMasraflar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            Temizle();
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
        int Id;
        private void dgvMasraflar_DoubleClick(object sender, EventArgs e)
        {
            txtMasrafAdi.Text = dgvMasraflar.SelectedRows[0].Cells[1].Value.ToString();
            txtMasrafTutari.Text = dgvMasraflar.SelectedRows[0].Cells[2].Value.ToString();
            Id = Convert.ToInt32(dgvMasraflar.SelectedRows[0].Cells[0].Value);
            btnSil.Enabled = true;
            txtMasrafAdi.ReadOnly = true;
            txtMasrafTutari.ReadOnly = true;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
                if(MessageBox.Show("Seçilen masrafın silinmesini istiyor musunuz ?","Silme işlemini onaylıyor musunuz ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mr.MasrafSil(Id))
                    {
                        MessageBox.Show("Masraf kayıtları üzerindeki silme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvDoldurDuzenle();
                        Temizle();
                        btnSil.Enabled = false;
                    }
                    else
                        MessageBox.Show("Masraf kayıtları üzerindeki silme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
