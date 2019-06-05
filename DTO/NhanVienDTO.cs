using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string hoten;
        private DateTime ngaysinh;
        private string sdt;
        private string gioitinh;
        private string cmnd;
        private string chucvu;

        public string MaNV { get => maNV; set => maNV = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        //public NhanVienDTO(string maNV, string hoten, DateTime ngaysinh,string sdt,string gioitinh,string cmnd,string chucvu)
        //{
        //    this.maNV = maNV;
        //    this.hoten = hoten;
        //    this.ngaysinh = ngaysinh;
        //    this.sdt = sdt;
        //    this.gioitinh = gioitinh;
        //    this.cmnd = cmnd;
        //    this.chucvu = chucvu;
        //}
    }
}