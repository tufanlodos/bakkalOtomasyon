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
    public partial class frmKritikStok : Form
    {
        public frmKritikStok()
        {
            InitializeComponent();
        }
        UrunRepository ur = new UrunRepository();
        private void frmKritikStok_Load(object sender, EventArgs e)
        {
            dgvKritikUrunler.DataSource = ur.KritikUrunleriGetir();
            dgvKritikUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKritikUrunler.AllowUserToAddRows = false;
            dgvKritikUrunler.AllowUserToDeleteRows = false;
            dgvKritikUrunler.AllowUserToResizeColumns = false;
            dgvKritikUrunler.AllowUserToResizeRows = false;
            dgvKritikUrunler.RowHeadersVisible = false;
            dgvKritikUrunler.BorderStyle = BorderStyle.None;
            dgvKritikUrunler.BackgroundColor = this.BackColor;
            dgvKritikUrunler.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.7F, FontStyle.Bold);
            dgvKritikUrunler.MultiSelect = false;
            dgvKritikUrunler.Columns[0].Visible = false;
            dgvKritikUrunler.Columns[1].HeaderText = "Ürün Kodu";
            dgvKritikUrunler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[2].HeaderText = "Ürün Markası";
            dgvKritikUrunler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[3].HeaderText = "Ürün Adı";
            dgvKritikUrunler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[4].HeaderText = "Satış Fiyatı";
            dgvKritikUrunler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKritikUrunler.Columns[5].HeaderText = "Alış Fiyatı";
            dgvKritikUrunler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKritikUrunler.Columns[6].Visible = false;
            dgvKritikUrunler.Columns[7].HeaderText = "Stok Miktarı";
            dgvKritikUrunler.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKritikUrunler.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKritikUrunler.Columns[7].DefaultCellStyle.BackColor = Color.Red;
            dgvKritikUrunler.Columns[8].Visible = false;
            dgvKritikUrunler.Columns[9].HeaderText = "Kategori Adı";
            dgvKritikUrunler.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void btnSiparisKaydi_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSiparisEkle frm = new frmSiparisEkle();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
