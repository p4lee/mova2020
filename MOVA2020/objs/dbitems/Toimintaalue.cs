using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Toimintaalue
    {
        private int toiminta_alueid;
        private string nimi;

        public Toimintaalue(int id, string nimi)
        {
            this.toiminta_alueid = id;
            this.nimi = nimi;
        }

        public string Nimi { get => nimi; set => nimi = value; }
        public int Toiminta_alueid { get => toiminta_alueid;}
    }
}
