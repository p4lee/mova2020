using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Asiakas
    {
        private Posti postinro;
        private long asiakas_id;
        private string etunimi, sukunimi, lahiosoite, email, puhelinnro;
        //asd
        public Asiakas(long asiakas_id, string etunimi, string sukunimi, string lahiosoite, string email, string puhelinnro, Posti postinro)
        {
            this.asiakas_id = asiakas_id;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Lahiosoite = lahiosoite;
            Email = email;
            Puhelinnro = puhelinnro;
            Postinro = postinro;
        }

        public long Asiakas_id { get => asiakas_id;}
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Lahiosoite { get => lahiosoite; set => lahiosoite = value; }
        public string Email { get => email; set => email = value; }
        public string Puhelinnro { get => puhelinnro; set => puhelinnro = value; }
        public Posti Postinro { get => postinro; set => postinro = value; }
    }
}
