using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        private string maDV;
        private string tenDV;
        private decimal giaDV;
        private string maNV;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public decimal GiaDV { get => giaDV; set => giaDV = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        //public DichVuDTO(string maDV,string tenDV,decimal giaDV,string maNV)
        //{
        //    this.maDV = maDV;
        //    this.tenDV = tenDV;
        //    this.giaDV = giaDV;
        //    this.maNV = maNV;
        //}
    }
}
