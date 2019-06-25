using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nvdal;
        public NhanVienBUS()
        {
            nvdal = new NhanVienDAL();
        }
        public bool them(NhanVienDTO nv)
        {
            bool kq = nvdal.them(nv);
            return kq;
        }
        public bool xoa(NhanVienDTO nv)
        {
            bool kq = nvdal.xoa(nv);
            return kq;
        }
        public bool sua(NhanVienDTO nv)
        {
            bool kq = nvdal.sua(nv);
            return kq;
        }
        public List<NhanVienDTO>timkiem()
        {
            return nvdal.timkiem();
        }
    }
}
