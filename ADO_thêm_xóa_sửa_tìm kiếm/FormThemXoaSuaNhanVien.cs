using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using BUS;

//namespace ADO_thêm_xóa_sửa_tìm_kiếm
namespace GUI
{
    public partial class FormThemXoaSuaNhanVien : Form
    {
        public FormThemXoaSuaNhanVien()
        {
            InitializeComponent();
        }
        private NhanVienBUS nvbus;
        //private void Load()
        //{
        //    nvbus = new NhanVienBUS();
        //}
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
            nv.MaNV = txtmanv.Text;
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

        private void FormThemXoaSuaNhanVien_Load(object sender, EventArgs e)
        {
            nvbus = new NhanVienBUS();
        }
        public void Load_Datagridview(List<NhanVienDTO> lsnv)
        {
            if (lsnv == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm nhân viên");
                //MessageBox.Show("không tìm thấy nhân viên");
                return;
            }
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = lsnv;
           
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvNhanVien.DataSource];
            myCurrencyManager.Refresh();
        }
        private void Btxem_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> lsnv = nvbus.select();
            Load_Datagridview(lsnv);
        }

        private void Bttimkiem_Click(object sender, EventArgs e)
        {
            string key = txttimkiem.Text.Trim();
           if(key==null||key==string.Empty||key.Length==0)
            {
                List<NhanVienDTO> lsnv = nvbus.select();
                this.Load_Datagridview(lsnv);
            }
           else
            {
                List<NhanVienDTO> lsnv = nvbus.timkiem(key);
                this.Load_Datagridview(lsnv);
            }
        }

        private void DgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //int index = dgvNhanVien.CurrentRow.Index;
            //txthoten.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            //txthoten.Text = txthoten.Text.Trim();
            //txtngaysinh.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            //txtsdt.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            //txtgioitinh.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            //txtcmnd.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            //txtchucvu.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            //txtmanv.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            //txtmk.Text = dgvNhanVien.Rows[index].Cells[7].Value.ToString();
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                txthoten.Text = row.Cells["Họ tên"].Value.ToString();
                txtmanv.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txtngaysinh.Text = row.Cells["Ngày sinh"].Value.ToString();
                txtsdt.Text = row.Cells["Sđt"].Value.ToString();
                txtgioitinh.Text = row.Cells["Giới tính"].Value.ToString();
                txtcmnd.Text = row.Cells["Cmnd"].Value.ToString();
                txtchucvu.Text = row.Cells["Chức vụ"].Value.ToString();
                txtmk.Text = row.Cells["Mật khẩu"].Value.ToString();
            }
        }

        
    }
}