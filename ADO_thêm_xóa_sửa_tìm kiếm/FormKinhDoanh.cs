using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormKinhDoanh : Form
    {
        public FormKinhDoanh()
        {
            InitializeComponent();
        }
        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_MaKhachHang.Text == "")
            {
                MessageBox.Show("Xin nhập mã khách hàng");
                txt_MaKhachHang.Focus();
                return;
            }
            if (txt_MaPhong.Text == "")
            {
                MessageBox.Show("Xin nhập mã phòng");
                txt_MaPhong.Focus();
                return;
            }
            //Xử lí
            if (txt_ThanhTien.Text != "")
            {
                bt_XuatHoaDon.Enabled = true;
            }
        }

        private void bt_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_XuatHoaDon_Click(object sender, EventArgs e)
        {
            if (txt_ThanhTien.Text == "")
            {
                MessageBox.Show("Xin kiểm tra lại thông tin");
                return;
            }
        }
    }
}
