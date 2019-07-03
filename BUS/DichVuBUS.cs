using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DichVuBUS
    {
        private DichVuDAL dvdal;
        public DichVuBUS()
        {
            dvdal = new DichVuDAL();
        }
        public bool them(DichVuDTO dv)
        {
            bool kq = dvdal.them(dv);
            return kq;
        }
        public bool xoa(DichVuDTO dv)
        {
            bool kq = dvdal.xoa(dv);
            return kq;
        }
        public bool sua(DichVuDTO dv)
        {
            bool kq = dvdal.sua(dv);
            return kq;
        }
        public List<DichVuDTO> select()
        {
            return dvdal.select();
        }
        public List<DichVuDTO> timkiem(string key)
        {
            return dvdal.timkiem(key);
        }
    }
}
