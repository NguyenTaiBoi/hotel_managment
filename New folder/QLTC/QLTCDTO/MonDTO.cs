using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCDTO
{
    public class MonDTO
    {
        private string tenmon;
        private string mota;
        private float gia;
        private KieuNauDTO kn;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Mota { get => mota; set => mota = value; }
        public float Gia { get => gia; set => gia = value; }
        internal KieuNauDTO Kn { get => kn; set => kn = value; }
    }
}
