using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Posti
    {
        private string postinro;
        private string toimipaikka;

        public Posti(string postinro, string toimipaikka)
        {
            Postinro = postinro;
            Toimipaikka = toimipaikka;
        }

        public string Postinro { get => postinro; set => postinro = value; }
        public string Toimipaikka { get => toimipaikka; set => toimipaikka = value; }

        override
        public string ToString()
        {
            return this.postinro + " " +this.Toimipaikka;
        }
    }
}
