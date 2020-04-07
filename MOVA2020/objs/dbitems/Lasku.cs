using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    class Lasku
    {
        private int lasku_id;
        private Varaus varaus;
        private double summa, alv;

        public Lasku(int lasku_id, double summa, double alv, Varaus varaus)
        {
            this.lasku_id = lasku_id;
            Summa = summa;
            Alv = alv;
            Varaus = varaus;
        }

        public int Lasku_id { get => lasku_id;}
        public double Summa { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }
        internal Varaus Varaus { get => varaus; set => varaus = value; }
    }
}
