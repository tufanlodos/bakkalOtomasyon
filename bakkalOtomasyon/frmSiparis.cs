using BLL.Bakkal.Repositories;
using DAL.Bakkal.DataModel;
using DAL.Bakkal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Bakkal
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        SiparisRepository srepo = new SiparisRepository();
        int HeaderText = 0, SilinecekId, DgvUrunId;
        private void Siparis_Load(object sender, EventArgs e)
        {
            DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
            cbSiralama.Focus();
        }
        private void DgvDoldurDuzenle(List<SiparisModel> liste)
        {
            dgvSiparisler.DataSource = liste;
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
            dgvSiparisler.Columns[1].ReadOnly = true;
            dgvSiparisler.Columns[2].HeaderText = "Ürün Adı";
            dgvSiparisler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[2].ReadOnly = true;
            dgvSiparisler.Columns[3].HeaderText = "Miktar";
            dgvSiparisler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSiparisler.Columns[4].HeaderText = "Tutar";
            dgvSiparisler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSiparisler.Columns[4].ReadOnly = true;
            dgvSiparisler.Columns[5].HeaderText = "Kayıt Tarihi";
            dgvSiparisler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSiparisler.Columns[5].ReadOnly = true;
            HeaderText++;
            txtToplamTutar.Text = srepo.ToplamTutarHesapla().ToString();
            this.AcceptButton = btnYeni;
            cbSiralama.SelectedIndex = 0;
            dgvSiparisler.ClearSelection();
        }
        int SecilenSatir;
        private void dgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatir = e.RowIndex;
        }
        private void dgvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            DgvUrunId=srepo.UrunIdBul(dgvSiparisler.SelectedRows[0].Cells[2].Value.ToString());
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen sipariş kaydının silinmesini istiyor musunuz ?", "Silme işlemini onaylıyor musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (srepo.SiparisSil(SilinecekId))
                {
                    MessageBox.Show("Sipariş kayıtları üzerindeki silme işlemi gerçekleştirildi", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
                    dgvSiparisler.ClearSelection();
                    btnSil.Enabled = false;
                    btnVazgec.Visible = false;
                    this.AcceptButton = btnYeni;
                }
                else
                {
                    MessageBox.Show("Siparis kayıtları üzerindeki silme işlemi gerçekleştirilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvSiparisler.ClearSelection();
                    btnSil.Enabled = false;
                    btnVazgec.Visible = false;
                    this.AcceptButton = btnYeni;
                }
            }
            else
            {
                btnSil.Enabled = false;
                DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
                dgvSiparisler.ClearSelection();
                btnVazgec.Visible = false;
                this.AcceptButton = btnYeni;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnVazgec.Visible = false;
            DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
            cbSiralama.SelectedIndex = 0;
            srepo.ContextteBekleyenleriTemizle();
            dgvSiparisler.ClearSelection();
            this.AcceptButton = btnYeni;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (srepo.SiparisGuncelle())
            {
                MessageBox.Show("Sipariş kayıtları üzerindeki güncellemeler kaydedildi.", "İşlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
                btnVazgec.Visible = false;
            }
            else
            {
                MessageBox.Show("Sipariş kayıtları üzerindeki güncellemeler kaydedilemedi", "İşlem tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
                btnVazgec.Visible = false;
            }
        }

        private void cbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSiralama.SelectedIndex == 0)
            {
                dgvSiparisler.DataSource = srepo.TariheGoreSiparisSirala("desc");
                dgvSiparisler.ClearSelection();
            }
            if (cbSiralama.SelectedIndex == 1)
            {
                dgvSiparisler.DataSource = srepo.TariheGoreSiparisSirala("asc");
                dgvSiparisler.ClearSelection();
            }
            if (cbSiralama.SelectedIndex == 2)
            {
                dgvSiparisler.DataSource = srepo.TutaraGoreSiparisSirala("desc");
                dgvSiparisler.ClearSelection();
            }
            if (cbSiralama.SelectedIndex == 3)
            {
                dgvSiparisler.DataSource = srepo.TutaraGoreSiparisSirala("asc");
                dgvSiparisler.ClearSelection();
            }
            if (cbSiralama.SelectedIndex == 4)
            {
                dgvSiparisler.DataSource = srepo.MiktaraGoreSiparisSirala("desc");
                dgvSiparisler.ClearSelection();
            }
            if (cbSiralama.SelectedIndex == 5)
            {
                dgvSiparisler.DataSource = srepo.MiktaraGoreSiparisSirala("asc");
                dgvSiparisler.ClearSelection();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmSiparisEkle frm = new frmSiparisEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            DgvDoldurDuzenle(srepo.TariheGoreSiparisSirala("desc"));
            cbSiralama.SelectedIndex = 0;
        }

        int Adet = 0, RIndex, CIndex;
        decimal ToplamTutar = 0;
        bool Etkile = true;
        private void dgvSiparisler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            txtToplamTutar.Text = string.Empty;
            if (HeaderText >= 1 && Etkile)
            {
                dgvSiparisler.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dgvSiparisler.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                RIndex = e.RowIndex;
                CIndex = e.ColumnIndex;
                btnVazgec.Visible = true;
                btnGuncelle.Enabled = true;
                this.AcceptButton = btnGuncelle;
                btnSil.Enabled = false;
                ToplamTutarGuncelle();
            }
            if (HeaderText >= 1 && !Etkile)
            {
                dgvSiparisler.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                Etkile = true;
            }

        }
        private void ToplamTutarGuncelle() //miktara göre tutar güncellerken tekrar cellvaluechanged e gideceği için bu durum Etkile değişkeniyle kontrol altına alındı.
        {
            Adet = Convert.ToInt32(dgvSiparisler.Rows[RIndex].Cells[CIndex].Value.ToString());
            ToplamTutar = srepo.YeniToplamTutarHesapla(DgvUrunId, Adet);
            srepo.DegisiklikleriContexteAl(SilinecekId, Adet, ToplamTutar);
            Etkile = false;
            dgvSiparisler.Rows[RIndex].Cells[CIndex + 1].Value = ToplamTutar.ToString();
        }

        
    }
}
