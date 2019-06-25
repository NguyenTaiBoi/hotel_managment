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
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
            dtpNgayDatPhong.MinDate = dtpNgayDatPhong.Value;
        }
        private void dtpNgayDatPhong_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayTraPhong.MinDate = dtpNgayDatPhong.Value;
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtCMND.Enabled = false;
            txtHoTen.Enabled = false;
            txtQuocTich.Enabled = false;
            txtSDT.Enabled = false;
            txtTuoi.Enabled = false;
            dtpNgayDatPhong.Enabled = false;
            dtpNgayTraPhong.Enabled = false;
            btLuu.Visible = false;
            btThem.Visible = true;
            btHuy.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtCMND.Enabled = true;
            txtHoTen.Enabled = true;
            txtQuocTich.Enabled = true;
            txtSDT.Enabled = true;
            txtTuoi.Enabled = true;
            dtpNgayDatPhong.Enabled = true;
            dtpNgayTraPhong.Enabled = true;
            btLuu.Visible = true;
            btThem.Visible = false;
            btHuy.Enabled = true;
            txtCMND.Clear();
            txtHoTen.Clear();
            txtQuocTich.Clear();
            txtSDT.Clear();
            txtTuoi.Clear();
            dtpNgayDatPhong.Value = System.DateTime.Now;
            dtpNgayTraPhong.Value = dtpNgayDatPhong.Value;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void txtQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Xin điền vào họ tên khách hàng");
                txtHoTen.Focus();
                return;
            }
            if (txtTuoi.Text == "")
            {
                MessageBox.Show("Xin điền vào tuổi khách hàng");
                txtTuoi.Focus();
                return;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Xin điền vào chứng minh thư của khách hàng");
                txtCMND.Focus();
                return;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Xin điền vào quốc tịch của khách hàng");
                txtQuocTich.Focus();
                return;
            }
            /*
            if (txtPhong.Text == "")
            {
                MessageBox.Show("Xin chọn phòng cho khách hàng");
                btDanhSachPhong.Focus();
                return;
            }
            */
            if (true)
            {
                MessageBox.Show("Đặt phòng thành công");
                txtCMND.Enabled = false;
                txtHoTen.Enabled = false;
                txtQuocTich.Enabled = false;
                txtSDT.Enabled = false;
                txtTuoi.Enabled = false;
                dtpNgayDatPhong.Enabled = false;
                dtpNgayTraPhong.Enabled = false;
                btLuu.Visible = false;
                btThem.Visible = true;
                btHuy.Enabled = false;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, xin kiểm tra lại");
            }
        }

        private void TxtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
