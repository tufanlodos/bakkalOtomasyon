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
    public partial class frmTedarikEkrani : Form
    {
        public frmTedarikEkrani()
        {
            InitializeComponent();
        }
        BilancoRepository br = new BilancoRepository(); 
        private void cbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            lvGoruntulenenListe.Items.Clear();
            if (cbSiralama.SelectedIndex == 0)
                x = 0;
            else if (cbSiralama.SelectedIndex == 1)
                x = 1;
            else if (cbSiralama.SelectedIndex == 2)
                x = 2;

                lvGoruntulenenListe.Items.Add("Masraf");
                lvGoruntulenenListe.Items[0].SubItems.Add(br.MasrafTutar(x).ToString("c"));
                lvGoruntulenenListe.Items.Add("Tedarik");
                lvGoruntulenenListe.Items[1].SubItems.Add(br.TedarikTutar(x).ToString("c"));
                lvGoruntulenenListe.Items.Add("Satış");
                lvGoruntulenenListe.Items[2].SubItems.Add(br.SatisTutar(x).ToString("c"));
                lvGoruntulenenListe.Items.Add("Bilanço");
                lvGoruntulenenListe.Items[3].Font = new Font("Arial", 10, FontStyle.Bold);
                lvGoruntulenenListe.Items[3].SubItems.Add((br.SatisTutar(x)-br.MasrafTutar(x)-br.TedarikTutar(x)).ToString("c"));
        }

        private void Bilanco_Load(object sender, EventArgs e)  
        {
            cbSiralama.SelectedIndex = 0;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
