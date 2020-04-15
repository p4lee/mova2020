using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Toimintaalue
    {
        private long toiminta_alueid;
        private string nimi;

        public Toimintaalue(long id, string nimi)
        {
            this.toiminta_alueid = id;
            this.nimi = nimi;
            //sadasdasd
        }
        public long Toiminta_alueid { get => toiminta_alueid; }
        public string Nimi { get => nimi; set => nimi = value; }
    }
}
