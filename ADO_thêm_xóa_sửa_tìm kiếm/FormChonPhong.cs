using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormChonPhong : Form
    {
        public FormChonPhong()
        {
            InitializeComponent();
            

        }
        public static string ValueChonPhong = "";
        private PhongBUS phongbus;

        private void FormChonPhong_Load(object sender, EventArgs e)
        {
            phongbus = new PhongBUS();
        }

        public void Load_DatagridviewChonPhong(List<PhongDTO> lsp)
        {
            if (lsp == null)
            {
                MessageBox.Show("không tìm thấy phòng");
                return;
            }
            dgvChonPhong.DataSource = null;
            dgvChonPhong.DataSource = lsp;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvChonPhong.DataSource];
            myCurrencyManager.Refresh();
        }



        private void dgvChonPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btChonPhong_Click(object sender, EventArgs e)
        {
            ValueChonPhong = dgvChonPhong.CurrentCell.Value.ToString();
            this.Close();
        }
    }
}
