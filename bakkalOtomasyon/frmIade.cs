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
    }
}
