using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class PhongBUS
    {
        private PhongDAL phongdal;
        public PhongBUS()
        {
            phongdal = new PhongDAL();
        }
        public List<PhongDTO> select()
        {
            return phongdal.select();
        }
        
    }
}
