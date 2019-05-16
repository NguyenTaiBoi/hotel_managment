using QLTCDAL;
using QLTCDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCBUS
{
    public class KieuNauBUS
    {
        private KieuNauDAL knDal;
        public KieuNauBUS()
        {
            knDal = new KieuNauDAL();
        }
        public bool them(KieuNauDTO kn)
        {
            bool re = knDal.them(kn);
            return re;
        }

        public bool xoa(KieuNauDTO kn)
        {
            return true;
        }

        public bool sua(KieuNauDTO kn)
        {
            return true;
        }

        public List<KieuNauDTO> select()
        {
            return null;
        }
    }
}
