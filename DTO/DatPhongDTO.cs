using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DatPhongDTO
    {
        private string soPhong;
        private string maKH;
        private DateTime ngaythue;
        private DateTime ngaytra;
        private int soluongnguoi;
        private decimal tienphong;

        public string SoPhong { get => soPhong; set => soPhong = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public int Soluongnguoi { get => soluongnguoi; set => soluongnguoi = value; }
        public decimal Tienphong { get => tienphong; set => tienphong = value; }

        //public DatPhongDTO(string soPhong,string maKH,DateTime ngaythue,DateTime ngaytra,int soluongnguoi,decimal tienphong)
        //{
        //    this.soPhong = soPhong;
        //    this.maKH = maKH;
        //    this.ngaythue = ngaythue;
        //    this.ngaytra = ngaytra;
        //    this.soluongnguoi = soluongnguoi;
        //    this.tienphong =tienphong;
        //}
    }
}
