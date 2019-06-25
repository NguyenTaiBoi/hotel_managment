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

namespace ADO_thêm_xóa_sửa_tìm_kiếm
{
    public partial class FormThemXoaSuaNhanVien : Form
    {
        public FormThemXoaSuaNhanVien()
        {
            InitializeComponent();
        }
        private NhanVienBUS nvbus;
        private void Btthem_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Hoten = txthoten.Text;
            nv.Ngaysinh = txtngaysinh.Value;
            nv.Sdt = txtsdt.Text;
            nv.Gioitinh = txtgioitinh.Text;
            nv.Cmnd = txtcmnd.Text;
            nv.Chucvu = txtchucvu.Text;
            nv.MaNV = txtmanv.Text;
            nv.MkNV = txtmk.Text;
            nvbus.them(nv);
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MkNV = txtmanv.Text;
            nvbus.xoa(nv);
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Hoten = txthoten.Text;
            nv.Ngaysinh = txtngaysinh.Value;
            nv.Sdt = txtsdt.Text;
            nv.Gioitinh = txtgioitinh.Text;
            nv.Cmnd = txtcmnd.Text;
            nv.Chucvu = txtchucvu.Text;
            nv.MaNV = txtmanv.Text;
            nv.MkNV = txtmk.Text;
            nvbus.sua(nv);
        }
    }
}
