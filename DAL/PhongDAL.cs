using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class PhongDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public PhongDAL()
        {
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }
        public bool them(PhongDTO phong)
        {
            string query = string.Empty;
            query += "INSERT INTO [PHONG] ([soPhong], [loaiPhong], [giaPhong])";
            query += "VALUES (@soPhong,@loaiPhong,@giaPhong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@soPhong", phong.SoPhong);
                    cmd.Parameters.AddWithValue("@loaiPhong", phong.LoaiPhong);
                    cmd.Parameters.AddWithValue("@giaPhong", phong.GiaPhong);
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
                        MessageBox.Show("thêm phòng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm phòng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool xoa(PhongDTO phong)
        {
            string query = string.Empty;
            query += "DELETE FROM [PHONG] WHERE [soPhong] = @soPhong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@soPhong", phong.SoPhong);
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
                        MessageBox.Show("xóa phòng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa phòng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool sua(PhongDTO phong)
        {
            string query = string.Empty;
            query += "UPDATE [PHONG] SET [loaiPhong] = @loaiPhong, [giaPhong]=@giaPhong WHERE [soPhong] = @soPhong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                   // cmd.Parameters.AddWithValue("@soPhong", phong.SoPhong);
                    cmd.Parameters.AddWithValue("@loaiPhong", phong.LoaiPhong);
                    cmd.Parameters.AddWithValue("@giaPhong", phong.GiaPhong);
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
                        MessageBox.Show("cập nhật phòng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật phòng thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }



        public bool timkiem(PhongDTO key)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PHONG] ";
            query += "WHERE ([soPhong] LIKE CONKAT ('%',@key,'%')) ";
            query+= "OR ([loaiPhong] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([giaPhong] LIKE CONKAT ('%',@key,'%'))";
            List<PhongDTO> listPhong = new List<PhongDTO>();
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
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("không tìm thấy phòng", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("đã tìm thấy phòng", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public List<PhongDTO> select()
        {
            return null;
        }
    }
}

