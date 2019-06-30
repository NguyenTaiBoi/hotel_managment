using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace GUI
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void ThêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemXoaSuaNhanVien ftxs = new FormThemXoaSuaNhanVien();
            ftxs.Show();
        }
    }
}
