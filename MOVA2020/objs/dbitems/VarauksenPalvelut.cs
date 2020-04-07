using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    class VarauksenPalvelut
    {
        private Varaus varaus;
        private Palvelu palvelu;
        private int lkm;

        public int Lkm { get => lkm; set => lkm = value; }
        internal Varaus Varaus { get => varaus; set => varaus = value; }
        internal Palvelu Palvelu { get => palvelu; set => palvelu = value; }
    }
}
