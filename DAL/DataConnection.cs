using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=MR-WOODPECKER\SQLEXPRESS;Initial Catalog=QLKS_database;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
