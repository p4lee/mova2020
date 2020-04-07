using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    class Posti
    {
        private int postinro;
        private string toimipaikka;

        public Posti(int postinro, string toimipaikka)
        {
            Postinro = postinro;
            Toimipaikka = toimipaikka;
        }

        public int Postinro { get => postinro; set => postinro = value; }
        public string Toimipaikka { get => toimipaikka; set => toimipaikka = value; }

        public string GetToString()
        {
            return this.Toimipaikka;
        }
    }
}
