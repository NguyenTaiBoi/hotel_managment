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
    public partial class FormGiaHanPhong : Form
    {
        public FormGiaHanPhong()
        {
            InitializeComponent();
        }
        private void btXacThuc_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Xin điền vào họ tên khách hàng");
                txtHoTen.Focus();
                return;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Xin điền vào chứng minh thư của khách hàng");
                txtCMND.Focus();
                return;
            }
            /*
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Xin nhập mã phòng của khách hàng");
                txtMaPhong.Focus();
                return;
            }
            */
            if (true)
            {
                dtpNgayTraPhongMoi.Enabled = true;
                btXacNhan.Enabled = true;
                btHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin");
                dtpNgayTraPhongMoi.Enabled = false;
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Gia hạn phòng thành công");
                txtCMND.Enabled = false;
                txtHoTen.Enabled = false;
                txtMaPhong.Enabled = false;
                dtpNgayTraPhongMoi.Enabled = false;
                btXacNhan.Visible = false;
                btTaoMoi.Visible = true;
                btHuy.Enabled = false;
                btXacThuc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, xin kiểm tra lại thông tin");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtCMND.Enabled = false;
            txtHoTen.Enabled = false;
            txtMaPhong.Enabled = false;
            dtpNgayTraPhongMoi.Enabled = false;
            btXacNhan.Visible = false;
            btTaoMoi.Visible = true;
            btHuy.Enabled = false;
            btXacThuc.Enabled = false;
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            txtCMND.Enabled = true;
            txtHoTen.Enabled = true;
            txtMaPhong.Enabled = true;
            dtpNgayTraPhongMoi.Enabled = true;
            btXacNhan.Visible = true;
            btTaoMoi.Visible = false;
            btHuy.Enabled = true;
            btXacNhan.Enabled = false;
            btXacThuc.Enabled = true;
            txtCMND.Clear();
            txtHoTen.Clear();
            dtpNgayTraPhong.Value = System.DateTime.Now;
            dtpNgayTraPhongMoi.Value = dtpNgayTraPhong.Value;
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            btXacNhan.Enabled = false;
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            btXacNhan.Enabled = false;
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            btXacNhan.Enabled = false;
        }
        private void TxtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
