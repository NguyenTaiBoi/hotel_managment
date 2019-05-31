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
using System.Data;

namespace ADO_thêm_xóa_sửa_tìm_kiếm
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlConnection con = new SqlConnection("");///add data source vào (***********)
            SqlDataAdapter adap = new SqlDataAdapter();///add câu  lệnh query vào(********)
            DataTable dtb = new System.Data.DataTable();
            adap.Fill(dtb);
        }
    }
}
