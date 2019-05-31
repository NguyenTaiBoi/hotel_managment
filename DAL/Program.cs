using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }   
    }
    class DAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        public DAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAll(string table)///lấy dữ liệu toán bảng
        {
            string sql = "select * from ";
            sql += table;
            SqlConnection con = new SqlConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Insert()
    }
}
