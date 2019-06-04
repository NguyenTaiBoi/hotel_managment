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
    class NhanVienDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public NhanVienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }
        public bool them(NhanVienDTO nhanvien)
        {
            string query = string.Empty;
            query += "INSERT INTO [NHANVIEN] ([maNV], [hoten], [ngaysinh],[sdt],[gioitinh],[cmnd],[chucvu])";
            query += "VALUES (@maNV,@hoten,@ngaysinh,@sdt,@gioitinh,@cmnd,@chucvu)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maNV", nhanvien.MaNV);
                    cmd.Parameters.AddWithValue("@hoten", nhanvien.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanvien.Ngaysinh);
                    cmd.Parameters.AddWithValue("@sdt", nhanvien.Sdt);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanvien.Gioitinh);
                    cmd.Parameters.AddWithValue("@cmnd", nhanvien.Cmnd);
                    cmd.Parameters.AddWithValue("@chucvu", nhanvien.Chucvu);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("thêm nhân viên thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm nhân viên thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool xoa(NhanVienDTO nhanvien)
        {
            string query = string.Empty;
            query += "DELETE FROM [NHANVIEN] WHERE [maNV] = @maNV";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maNV", nhanvien.MaNV);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("xóa nhân viên thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa nhân viên thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool sua(NhanVienDTO nhanvien)
        {
            string query = string.Empty;
            query += "UPDATE [NHANVIEN] SET [hoten] = @hoten, [ngaysinh]=@ngaysinh,[sdt]=@sdt,[gioitinh]=@gioitinh,[cmnd]=@cmnd,[chucvu]=@chucvu WHERE [soPhong] = @soPhong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@hoten", nhanvien.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanvien.Ngaysinh);
                    cmd.Parameters.AddWithValue("@sdt", nhanvien.Sdt);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanvien.Gioitinh);
                    cmd.Parameters.AddWithValue("@cmnd", nhanvien.Cmnd);
                    cmd.Parameters.AddWithValue("@chucvu", nhanvien.Chucvu);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("cập nhật nhân viên thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật nhân viên thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }



        public bool timkiem(NhanVienDTO key)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [NHANVIEN] ";
            query += "WHERE ([maNV] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([hoten] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([ngaysinh] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([sdt] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([gioitinh] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([cmnd] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([chucvu] LIKE CONKAT ('%',@key,'%')) ";
            List<NhanVienDTO> listPhong = new List<NhanVienDTO>();
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
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("không tìm thấy nhân viên", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("đã tìm thấy nhân viên", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public List<NhanVienDTO> select()
        {
            return null;
        }
    }

}

