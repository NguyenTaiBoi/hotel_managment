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
        public bool them(PhongDTO phong)
        {
            bool kq = phongdal.them(phong);
            return kq;
        }
        public bool xoa(PhongDTO phong)
        {
            bool kq = phongdal.xoa(phong);
            return kq;
        }
        public bool sua(PhongDTO phong)
        {
            bool kq = phongdal.sua(phong);
            return kq;
        }

        public List<PhongDTO> select()
        {
            return phongdal.select();
        }
        
    }
}
