using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DTO
{
    public class PhongDTO
    {
        private string soPhong;
        private string loaiPhong;
        private decimal giaPhong;

        public string SoPhong { get => soPhong; set => soPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }

        //public PhongDTO(string soPhong,string loaiPhong,decimal giaPhong)
        //{
        //    this.soPhong = soPhong;
        //    this.loaiPhong = loaiPhong;
        //    this.giaPhong = giaPhong;
        //}
    }
}
