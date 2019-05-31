using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_thêm_xóa_sửa_tìm_kiếm
{
    public partial class FormThemXoaSuaTimkiem : Form
    {
        public FormThemXoaSuaTimkiem()
        {
            InitializeComponent();
        }

     public void HienThi()
        {
            string sql = "select *from ";////chưa chọn bảng 
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dtr = cmd.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Load(dtr);
            ///if( user=ketoan) ds_ketoan.datasource=dtb
            ///the same with the others
        }
        public void Them(string type)
        {
            if (type=="LeTan")///nhan lenh insert le tan
            {

            }
            
        }
    }
}
