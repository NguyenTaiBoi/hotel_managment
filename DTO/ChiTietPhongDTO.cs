using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhongDTO
    {
        private string soPhong;
        private string maKH;
        private DateTime thoigian;

        public string SoPhong { get => soPhong; set => soPhong = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public string MaKH { get => maKH; set => maKH = value; }

        //public ChiTietPhongDTO(string soPhong,DateTime thoigian)
        //{
        //    this.soPhong = soPhong;
        //    this.maKH = maKH;
        //    this.thoigian = thoigian;
        //}
    }
}
