using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCDTO
{
    public class KieuNauDTO
    {
        private int ma;
        private string ten;
        private string mota;

        public int Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}
