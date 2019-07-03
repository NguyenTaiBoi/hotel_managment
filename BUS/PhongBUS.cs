using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class PhongBUS
    {
        private PhongDAL pdal;
        public PhongBUS()
        {
            pdal = new PhongDAL();
        }
        public bool them(PhongDTO p)
        {
            bool kq = pdal.them(p);
            return kq;
        }
        public bool xoa(PhongDTO p)
        {
            bool kq = pdal.xoa(p);
            return kq;
        }
        public bool sua(PhongDTO p)
        {
            bool kq = pdal.sua(p);
            return kq;
        }
        public List<PhongDTO> select()
        {
            return pdal.select();
        }
        public List<PhongDTO> timkiem(string key)
        {
            return pdal.timkiem(key);
        }
    }
}
