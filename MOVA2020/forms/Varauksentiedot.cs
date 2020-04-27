using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs.dbitems;
using MOVA2020;
namespace MOVA2020.forms
{
    public partial class Varauksentiedot : Form
    {
        private Varaus varaus;
        public Varauksentiedot(Varaus v)
        {
            this.varaus = v;
            InitializeComponent();

            tbEtunimi.Text = v.Asiakas.Etunimi;
            tbSukunimi.Text = v.Asiakas.Sukunimi;
            tbPuhnro.Text = v.Asiakas.Puhelinnro;
            tbSahkoposti.Text = v.Asiakas.Email;
            tbAsiakasPaikkakunta.Text = v.Asiakas.Posti.Toimipaikka;
            tbAsiakaspostinro.Text = v.Asiakas.Posti.Postinro;
            tbAsiakasosoite.Text = v.Asiakas.Lahiosoite;

            tbMokkinimi.Text = v.Mokki.Mokkinimi;
            tbMokkiPaikkakunta.Text = v.Mokki.Posti.Toimipaikka;
            tbMokkiPostinro.Text = v.Mokki.Posti.Postinro;
            tbToimintaalue.Text = v.Mokki.Toimintaalue.Nimi;
            tbHinta.Text = v.Mokki.Hinta.ToString();
            nmrHenkilomaara.Value = v.Mokki.Henkilomaara;
            rtbKuvaus.Text = v.Mokki.Kuvaus;
            rtbVarustelu.Text = v.Mokki.Varustelu;
            tbMokkiOsoite.Text = v.Mokki.Katuosoite;

            dtpVarattupvm.Value = v.Varattu_pvm;

            calVaraus.SelectionStart = v.Varattu_alkupvm;
            calVaraus.SelectionEnd = v.Varattu_loppupvm;
        }

    }
}
