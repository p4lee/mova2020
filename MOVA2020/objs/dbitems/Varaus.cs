using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Varaus
    {
        private int varaus_id;
        private DateTime varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm;
        private Asiakas asiakas;
        private Mokki mokki;

        public Varaus(int varaus_id, DateTime varattu_pvm, DateTime vahvistus_pvm, DateTime varattu_alkupvm, DateTime varattu_loppupvm, Asiakas asiakas, Mokki mokki)
        {
            this.varaus_id = varaus_id;
            Varattu_pvm = varattu_pvm;
            Vahvistus_pvm = vahvistus_pvm;
            Varattu_alkupvm = varattu_alkupvm;
            Varattu_loppupvm = varattu_loppupvm;
            Asiakas = asiakas;
            Mokki = mokki;
        }

        public int Varaus_id { get => varaus_id; }
        public DateTime Varattu_pvm { get => varattu_pvm; set => varattu_pvm = value; }
        public DateTime Vahvistus_pvm { get => vahvistus_pvm; set => vahvistus_pvm = value; }
        public DateTime Varattu_alkupvm { get => varattu_alkupvm; set => varattu_alkupvm = value; }
        public DateTime Varattu_loppupvm { get => varattu_loppupvm; set => varattu_loppupvm = value; }
        public Asiakas Asiakas { get => asiakas; set => asiakas = value; }
        public Mokki Mokki { get => mokki; set => mokki = value; }
    }
}
