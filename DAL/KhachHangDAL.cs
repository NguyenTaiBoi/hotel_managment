using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    class KhachHangDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        public bool them(KhachHangDTO khachhang)
        {
            string query = string.Empty;
            query += "INSERT INTO [KHACHHANG] ([maKH], [hoten], [tuoi], [email], [cmnd], [sdt], [quoctich], [gioitinh] )";
            query += "VALUES (@maKH, @hoten, @tuoi, @email, @sdt, @quoctich, @gioitinh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKH", khachhang.MaKH);
                    cmd.Parameters.AddWithValue("@hoten", khachhang.Hoten);
                    cmd.Parameters.AddWithValue("@tuoi", khachhang.Tuoi);
                    cmd.Parameters.AddWithValue("@email", khachhang.Email);
                    cmd.Parameters.AddWithValue("@cmnd", khachhang.Cmnd);
                    cmd.Parameters.AddWithValue("@sdt", khachhang.Sdt);
                    cmd.Parameters.AddWithValue("@quoctich", khachhang.Quoctich);
                    cmd.Parameters.AddWithValue("@gioitinh", khachhang.Gioitinh);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("thêm khách hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            MessageBox.Show("thêm khách hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool xoa(KhachHangDTO khachhang)
        {

            string query = string.Empty;
            query += "DELETE FROM [KHACHHANG] WHERE [maKH] = @maKH";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKH", khachhang.MaKH);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
                    {
                        con.Close();
                        MessageBox.Show("xóa nhân viên thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa khách hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool sua(KhachHangDTO khachhang)
        {
            string query = string.Empty;
            query += "UPDATE [KHACHHANG] SET ([maKH] = @maKH, [hoten] = @hoten, [tuoi] = @tuoi, [email] = @email, [cmnd] = @cmnd, [sdt] = @sdt, [quoctich] = @quoctich, [gioitinh] = @gioitinh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKH", khachhang.MaKH);
                    cmd.Parameters.AddWithValue("@hoten", khachhang.Hoten);
                    cmd.Parameters.AddWithValue("@tuoi", khachhang.Tuoi);
                    cmd.Parameters.AddWithValue("@email", khachhang.Email);
                    cmd.Parameters.AddWithValue("@cmnd", khachhang.Cmnd);
                    cmd.Parameters.AddWithValue("@sdt", khachhang.Sdt);
                    cmd.Parameters.AddWithValue("@quoctich", khachhang.Quoctich);
                    cmd.Parameters.AddWithValue("@gioitinh", khachhang.Gioitinh);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("cập nhật khách hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật khách hàng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool tiemkiem(KhachHangDTO khachhang)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [KHACHHANG] ";
            query += "WHERE ([maKH] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([cmnd] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([hoten] LIKE CONKAT ('%',@key,'%'))";
            List<KhachHangDTO> listPhong = new List<KhachHangDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
                    {
                        con.Close();
                        MessageBox.Show("không tìm thấy khách hàng", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("đã tìm thấy khách hàng", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public List<KhachHangDTO> select()
        {
            return null;
        }
    }
}
