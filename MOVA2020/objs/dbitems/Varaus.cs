using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Varaus
    {
        private long varaus_id;
        private DateTime varattu_pvm, vahvistus_pvm, alkupvm_varaus, loppupvm_varaus;
        private Asiakas asiakas;
        private Mokki mokki;
        private Dictionary<int, int> varauksenpalvelut;

        public Varaus(long varaus_id, DateTime varattu_pvm, DateTime vahvistus_pvm, DateTime varattu_alkupvm, DateTime varattu_loppupvm, Asiakas asiakas, Mokki mokki, Dictionary<int, int> varauksenpalvelut)
        {
            this.varaus_id = varaus_id;
            Varattu_pvm = varattu_pvm;
            Vahvistus_pvm = vahvistus_pvm;
            Alkupvm_varaus = varattu_alkupvm;
            Loppupvm_varaus = varattu_loppupvm;
            Asiakas = asiakas;
            Mokki = mokki;
            this.varauksenpalvelut = varauksenpalvelut;
        }

        public long Varaus_id { get => varaus_id; }

        
        public DateTime Varattu_pvm { get => varattu_pvm; set => varattu_pvm = value; }
        public DateTime Vahvistus_pvm { get => vahvistus_pvm; set => vahvistus_pvm = value; }
        public DateTime Alkupvm_varaus { get => alkupvm_varaus; set => alkupvm_varaus = value; }
        public DateTime Loppupvm_varaus { get => loppupvm_varaus; set => loppupvm_varaus = value; }
        public Asiakas Asiakas { get => asiakas; set => asiakas = value; }
        public Mokki Mokki { get => mokki; set => mokki = value; }
        
        public Dictionary<int, int> Varauksenpalvelut { get => varauksenpalvelut; set => varauksenpalvelut = value; }
        override
        public string ToString()
        {
            return "VarausID:"+this.Varaus_id + " | MökkiID:"+this.mokki.Mokki_id+" | " + this.Alkupvm_varaus + " - " + this.loppupvm_varaus;
        }
    }
}
