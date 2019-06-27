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
using GUI;
using DTO;



namespace GUI
{
    public partial class FormDangNhap : Form
    {
       // NhanVienDTO nv = new NhanVienDTO();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        //NhanVienDTO nv;
     
        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            //nv = new NhanVienDTO();
            //quyen=nv.Chucvu ;
            SqlConnection con = new SqlConnection(@"Data Source=MR-WOODPECKER\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE maNV= '" + txtUser.Text + "' AND mkNV='" + txtPass.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
           
            if (dt.Rows.Count > 0)
            {
               
                this.Hide();
                if (dt.Rows[0][6].ToString()== "Manager")
                {
                    FormQuanLy fql = new FormQuanLy();
                    fql.Show();
                }
            }
            else
            {

            }
        }
    }
}
