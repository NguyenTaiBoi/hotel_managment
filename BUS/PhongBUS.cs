using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class PhongBUS
    {
        private static PhongBUS instance;

        public static PhongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongBUS();
                return instance;
            }
        }
        private PhongBUS() { }
        public void Load(DataGridView data)
        {
            data.DataSource = PhongDAL.Instance.Load();
        }
    }
}
