using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Mokki
    {
        private int mokki_id, henkilomaara;
        private Toimintaalue toimintaalue;
        private Posti postinro;
        private string mokkinimi, katuosoite, kuvaus, varustelu;

        public Mokki(int mokki_id, int henkilomaara, string mokkinimi, string katuosoite, string kuvaus, string varustelu, Toimintaalue toimintaalue, Posti postinro)
        {
            this.mokki_id = mokki_id;
            Henkilomaara = henkilomaara;
            Mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Kuvaus = kuvaus;
            Varustelu = varustelu;
            Toimintaalue = toimintaalue;
            Postinro = postinro;
        }

        public int Mokki_id { get => mokki_id;}
        public int Henkilomaara { get => henkilomaara; set => henkilomaara = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite { get => katuosoite; set => katuosoite = value; }
        public string Kuvaus { get => kuvaus; set => kuvaus = value; }
        public string Varustelu { get => varustelu; set => varustelu = value; }
        public Toimintaalue Toimintaalue { get => toimintaalue; set => toimintaalue = value; }
        public Posti Postinro { get => postinro; set => postinro = value; }
    }
}
