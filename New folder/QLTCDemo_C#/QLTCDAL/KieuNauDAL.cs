using QLTCDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCDAL
{
    public class KieuNauDAL
    {
        private string connectionString;

        public KieuNauDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them(KieuNauDTO kn)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblKieuNau] ([maKieuNau], [tenKieuNau], [mota])";
            query += "VALUES (@maKieuNau,@tenKieuNau,@mota)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKieuNau", kn.Ma);
                    cmd.Parameters.AddWithValue("@tenKieuNau", kn.Ten);
                    cmd.Parameters.AddWithValue("@mota", kn.Mota);
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
                        return false;
                    }
                }
            }
            return true;
        }

        public bool xoa(KieuNauDTO kn)
        {
            return true;
        }

        public bool sua(KieuNauDTO kn)
        {
            return true;
        }

        public List<KieuNauDTO> select()
        {
            return null;
        }
    }
}
