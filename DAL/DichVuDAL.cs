using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class DichVuDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DichVuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(DichVuDTO dichvu)
        {
            string query = string.Empty;
            query += "INSERT INTO [DICHVU] ([maDV], [tenDV], [giaDV]) ";
            query += "VALUES (@maDV,@tenDV,@giaDV)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDV", dichvu.MaDV);
                    cmd.Parameters.AddWithValue("@tenDV", dichvu.TenDV);
                    cmd.Parameters.AddWithValue("@ngaysinh", dichvu.GiaDV);
                    
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
                        MessageBox.Show("thêm dịch vụ thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("thêm dịch vụ thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public bool xoa(DichVuDTO dichvu)
        {
            string query = string.Empty;
            query += "DELETE FROM [DICHVU] WHERE [maDV] = @maDV";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDV", dichvu.MaDV);
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
                        MessageBox.Show("xóa dịch vụ thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("xóa dịch vụ thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }

        public bool sua(DichVuDTO dichvu)
        {
            string query = string.Empty;
            query += "UPDATE [DICHVU] SET [tenDV]=@tenDV, [giaDV]=@giaDV WHERE [maDV] = @maDV";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenDV", dichvu.TenDV);
                    cmd.Parameters.AddWithValue("@giaDV", dichvu.GiaDV);
                    cmd.Parameters.AddWithValue("@maDV", dichvu.MaDV);
                    
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
                        MessageBox.Show("cập nhật dịch vụ thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            MessageBox.Show("cập nhật dịch vụ thành công", "thông báo", MessageBoxButtons.OK);
            return true;
        }
        public List<DichVuDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [DICHVU]";

            List<DichVuDTO> lsDichVu = new List<DichVuDTO>();

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
                                DichVuDTO dichvu = new DichVuDTO();
                                dichvu.MaDV = reader["maDV"].ToString();
                                dichvu.TenDV = reader["tenDV"].ToString();
                                dichvu.GiaDV = Decimal.Parse(reader["giaDV"].ToString());
                               
                                lsDichVu.Add(dichvu);
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
            return lsDichVu;
        }

        public List<DichVuDTO> timkiem(string key)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM [DICHVU]";
            query += " WHERE ([maDV] LIKE CONCAT('%',@key,'%'))";
            query += " OR ([tenDV] LIKE CONCAT('%',@key,'%'))";
            List<DichVuDTO> lsDichVu = new List<DichVuDTO>();
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
                                DichVuDTO dv = new DichVuDTO();
                                dv.MaDV = reader["maDV"].ToString();
                                dv.TenDV = reader["tenDV"].ToString();
                                dv.GiaDV = Decimal.Parse(reader["giaDV"].ToString());
                               
                                lsDichVu.Add(dv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }


                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsDichVu;
        }
    }
}
