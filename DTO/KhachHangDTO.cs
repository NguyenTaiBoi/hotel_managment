﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
       
        public string MaKH { get => maKH; set => maKH = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }

        private string maKH;
        private string hoten;
        private int tuoi;
        private string email;
        private string cmnd;
        private string gioitinh;
        private string sdt;
        private string quoctich;

        //public KhachHangDTO(string maKH, string hoten,int tuoi,string email,string cmnd,string gioitinh)
        //{
        //    this.maKH = maKH;
        //    this.hoten = hoten;
        //    this.tuoi = tuoi;
        //    this.email = email;
        //    this.cmnd = cmnd;
        //    this.gioitinh = gioitinh;
        //}
    }
}
