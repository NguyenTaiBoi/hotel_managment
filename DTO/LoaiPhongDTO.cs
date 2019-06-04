using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private string loaiphong;
        private int sodichvu;
        private string maDV;
        private decimal phi;

        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public int Sodichvu { get => sodichvu; set => sodichvu = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public decimal Phi { get => phi; set => phi = value; }

        //public LoaiPhongDTO(string loaiphong,int sodichvu,string maDV,decimal phi)
        //{
        //    this.loaiphong = loaiphong;
        //    this.sodichvu = sodichvu;
        //    this.maDV = maDV;
        //    this.phi = phi;
        //}
    }
}
