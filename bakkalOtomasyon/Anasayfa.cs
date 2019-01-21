using bakkalOtomasyon.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakkalOtomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        BCDContext ent = new BCDContext();


        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
