﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nhậnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();
            frm.Show();
        }

        private void giaHạnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaHanPhong frm = new frmGiaHanPhong();
            frm.Show();
        }
    }
}
