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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSimge_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void btnSiparis_Click_1(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            FormAc(frm);
        }

        private void btnMasraf_Click_1(object sender, EventArgs e)
        {
            frmMasraflar frm = new frmMasraflar();
            FormAc(frm);
        }
    }
}
