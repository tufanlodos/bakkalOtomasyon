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
    public partial class frmIade : Form
    {
        public frmIade()
        {
            InitializeComponent();
        }
        SatisRepo sr = new SatisRepo();
        private void frmIade_Load(object sender, EventArgs e)
        {
            SatislariDoldur();
            btnSDSil.Enabled = false;
        }

        private void SatislariDoldur()
        {
            int i = 0;
            foreach (Satis sat in sr.SatislariGetir())
            {
                lvSatislar.Items.Add(sat.Id.ToString());
                lvSatislar.Items[i].SubItems.Add(sat.ToplamTutar.ToString());
                lvSatislar.Items[i].SubItems.Add(sat.OdemeTipi);
                lvSatislar.Items[i].SubItems.Add(sat.IslemTarihi.ToString());
                i++;
            }
        }
        private void lvSatislar_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvSatislar.Columns[e.ColumnIndex].Width;
        }

        private void lvSatisDetaylar_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvSatisDetaylar.Columns[e.ColumnIndex].Width;
        }

        private void lvSatislar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lvSatisDetaylar.Items.Clear();
            int i = 0;
            int SatisId = Convert.ToInt32(e.Item.SubItems[0].Text);
            foreach (SatisDetay sd in sr.IdyeGoreSatisDetaylariGetir(SatisId))
            {
                lvSatisDetaylar.Items.Add(sd.Id.ToString());
                lvSatisDetaylar.Items[i].SubItems.Add(sd.IslemId.ToString());
                lvSatisDetaylar.Items[i].SubItems.Add(sd.UrunId.ToString());
                lvSatisDetaylar.Items[i].SubItems.Add(sr.UrunAdBul(sd.UrunId));
                lvSatisDetaylar.Items[i].SubItems.Add(sd.BirimFiyat.ToString());
                lvSatisDetaylar.Items[i].SubItems.Add(sd.Adet.ToString());
                lvSatisDetaylar.Items[i].SubItems.Add(sd.ToplamTutar.ToString());
                i++;
            }
        }
        int SilinecekSDId, SecileninSatisId;
        private void lvSatisDetaylar_DoubleClick(object sender, EventArgs e)
        {
            btnSDSil.Enabled = true;
            SilinecekSDId = Convert.ToInt32(lvSatisDetaylar.SelectedItems[0].SubItems[0].Text);
            SecileninSatisId = Convert.ToInt32(lvSatisDetaylar.SelectedItems[0].SubItems[1].Text);
        }

        private void lvSatisDetaylar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnSDSil.Enabled = false;
        }

        private void btnSDSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu hareketi silmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sr.SatisDetaySil(SilinecekSDId))
                {
                    MessageBox.Show("Seçilen silme işlemi gerçekleşti.", "Silme gerçekleşti.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lvSatisDetaylar.Items.Clear();
                    btnSDSil.Enabled = false;
                    if (!sr.SatisKaldiMi(SecileninSatisId))
                    {
                        sr.SatisSil(SecileninSatisId);
                    }
                    else
                    {
                        sr.SatisToplamTutarGuncelle(SecileninSatisId, sr.SatisToplamTutarHesaplat(SecileninSatisId));
                    }
                    lvSatislar.Items.Clear();
                    SatislariDoldur();
                }
                else
                    MessageBox.Show("Var bi' terslikler..", "..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
