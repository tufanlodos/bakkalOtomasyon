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
    public partial class TedarikEkrani : Form
    {
        public TedarikEkrani()
        {
            InitializeComponent();
        }
        TedarikciEkraniRepository Ter = new TedarikciEkraniRepository();
        BCDContext ent = new BCDContext();
        int ID;

        private void cbTedarikciSecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTedarikciSecin_Click(object sender, EventArgs e)
        {

            txtAdSoyad.Text 
        }

        private void TedarikEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
