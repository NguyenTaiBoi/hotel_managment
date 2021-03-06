﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL khdal;
        public KhachHangBUS()
        {
            khdal = new KhachHangDAL();
        }
        public bool them(KhachHangDTO kh)
        {
            bool kq = khdal.them(kh);
            return kq;
        }
        public bool xoa(KhachHangDTO kh)
        {
            bool kq = khdal.xoa(kh);
            return kq;
        }
        public bool sua(KhachHangDTO kh)
        {
            bool kq = khdal.sua(kh);
            return kq;
        }
        public List<KhachHangDTO> select()
        {
            return khdal.select();
        }
        public List<KhachHangDTO> timkiem(string key)
        {
            return khdal.timkiem(key);
        }
    }
}
