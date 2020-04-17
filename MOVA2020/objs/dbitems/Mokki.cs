using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Mokki
    {
        private int henkilomaara;
        private long mokki_id;
        private double hinta;
        private Toimintaalue toimintaalue;
        private Posti postinro;
        private string mokkinimi, katuosoite, kuvaus, varustelu;

        public Mokki(long mokki_id, string mokkinimi, string katuosoite, string kuvaus, string varustelu, Posti postinro, Toimintaalue toimintaalue, double hinta, int henkilomaara)
        {
            this.mokki_id = mokki_id;
            Mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Kuvaus = kuvaus;
            Varustelu = varustelu;
            Posti = postinro;
            Toimintaalue = toimintaalue;
            Hinta = hinta;
            Henkilomaara = henkilomaara;
        }

        public long Mokki_id { get => mokki_id; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite { get => katuosoite; set => katuosoite = value; }
        public string Kuvaus { get => kuvaus; set => kuvaus = value; }
        public string Varustelu { get => varustelu; set => varustelu = value; }
        public Posti Posti { get => postinro; set => postinro = value; }
        public Toimintaalue Toimintaalue { get => toimintaalue; set => toimintaalue = value; }
        public double Hinta { get => hinta; set => hinta = value; }
        public int Henkilomaara { get => henkilomaara; set => henkilomaara = value; }

        override
        public string ToString()
        {
            return "ID:" + this.Mokki_id+" | "+this.Mokkinimi;
        }
    }
}
