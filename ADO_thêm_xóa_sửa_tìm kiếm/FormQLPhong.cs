using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormQLPhong : Form
    {
        
        public FormQLPhong()
        {
            InitializeComponent();
            
        }
        private PhongBUS phongbus;
        private void FormQLPhong_Load(object sender, EventArgs e)
        {
            phongbus = new PhongBUS();
        }

        public void Load_DatagridviewChonPhong1(List<PhongDTO> lsp)
        {
            if (lsp == null)
            {
                MessageBox.Show("không tìm thấy phòng");
                return;
            }
            dgvChonPhong1.DataSource = null;
            dgvChonPhong1.DataSource = lsp;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvChonPhong1.DataSource];
            myCurrencyManager.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PhongDTO phong = new PhongDTO();
            phong.SoPhong = txtsoPhong.Text;
            phong.LoaiPhong = txtloaiPhong.Text;
            phong.GiaPhong = txtgiaPhong.Text;
            phong.MoTa = txtmoTa.Text;
            phongbus.them(phong);
            List<PhongDTO> lsp = phongbus.select();
            this.Load_DatagridviewChonPhong1(lsp);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PhongDTO phong = new PhongDTO();
            phong.SoPhong = txtsoPhong.Text;
            phongbus.xoa(phong);
            List<PhongDTO> lsp = phongbus.select();
            this.Load_DatagridviewChonPhong1(lsp);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PhongDTO phong = new PhongDTO();
            phong.SoPhong = txtsoPhong.Text;
            phong.LoaiPhong = txtloaiPhong.Text;
            phong.GiaPhong = txtgiaPhong.Text;
            phong.MoTa = txtmoTa.Text;
            phongbus.sua(phong);
            List<PhongDTO> lsp = phongbus.select();
            this.Load_DatagridviewChonPhong1(lsp);
        }
    }
}
