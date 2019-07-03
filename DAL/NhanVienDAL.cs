 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;



namespace DAL
{
    public class NhanVienDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public NhanVienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(NhanVienDTO nhanvien)
        {
            string query = string.Empty;
            query += "INSERT INTO [NHANVIEN] ([maNV], [hoten], [ngaysinh],[sdt],[gioitinh],[cmnd],[chucvu],[mkNV]) ";
            query += "VALUES (@maNV,@hoten,@ngaysinh,@sdt,@gioitinh,@cmnd,@chucvu,@mkNV)";
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
                    cmd.Parameters.AddWithValue("@mkNV", nhanvien.MkNV);
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
                    catch (Exception)
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
            query += "UPDATE [NHANVIEN] SET [hoten] = @hoten, [ngaysinh]=@ngaysinh,[sdt]=@sdt,[gioitinh]=@gioitinh,[cmnd]=@cmnd,[chucvu]=@chucvu,[mkNV]=@mkNV WHERE [maNV] = @maNV";
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
                    cmd.Parameters.AddWithValue("@mkNV", nhanvien.MkNV);
                    cmd.Parameters.AddWithValue("@maNV", nhanvien.MaNV);
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
                        MessageBox.Show("cập nhật nhân viên thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật nhân viên thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public List<NhanVienDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [NHANVIEN]";

            List<NhanVienDTO> lsNhanVien = new List<NhanVienDTO>();

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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                NhanVienDTO nhanvien = new NhanVienDTO();
                                nhanvien.MaNV = reader["maNV"].ToString();
                                nhanvien.Hoten = reader["hoten"].ToString();
                                nhanvien.Ngaysinh = DateTime.Parse(reader["ngaysinh"].ToString());
                                nhanvien.Gioitinh = reader["gioitinh"].ToString();
                                nhanvien.Cmnd = reader["cmnd"].ToString();
                                nhanvien.Sdt = reader["sdt"].ToString();
                                nhanvien.Chucvu = reader["chucvu"].ToString();
                                nhanvien.MkNV = reader["mkNV"].ToString();
                                lsNhanVien.Add(nhanvien);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsNhanVien;
        }

        public List<NhanVienDTO> timkiem(string key)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM [NHANVIEN]";
            query += " WHERE ([maNV] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([hoten] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([ngaysinh] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([sdt] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([cmnd] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([gioitinh] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([chucvu] LIKE CONCAT('%',@key,'%'))";
           // query += " OR ([mkNV] LIKE CONCAT('%',@key,'%'))";
            List<NhanVienDTO> lsNhanVien = new List<NhanVienDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@key", key);

                    try
                    {
                        con.Open();

                        SqlDataReader reader = null;
                        //cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                NhanVienDTO nv = new NhanVienDTO();
                                nv.MaNV = reader["maNV"].ToString();
                                nv.Hoten = reader["hoten"].ToString();
                                nv.Ngaysinh = DateTime.Parse(reader["ngaysinh"].ToString());
                                nv.Sdt = reader["sdt"].ToString();
                                nv.Gioitinh = reader["gioitinh"].ToString();
                                nv.Cmnd = reader["cmnd"].ToString();
                                nv.Chucvu = reader["chucvu"].ToString();
                                nv.MkNV = reader["mkNV"].ToString();
                                lsNhanVien.Add(nv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }


<<<<<<< HEAD
                    catch (Exception)
=======
                    catch (Exception )
>>>>>>> 4bfa102ad4ad01dc157763309adab52bb86667d3
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsNhanVien;
        }
    }
}


