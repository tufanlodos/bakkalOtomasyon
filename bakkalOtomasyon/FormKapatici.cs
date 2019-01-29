using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Bakkal
{
    public partial class FormKapatici : UserControl
    {
        public FormKapatici()
        {
            InitializeComponent();
        }

        private void FormKapatici_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
