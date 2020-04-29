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
using MOVA2020.objs;
using MOVA2020;
namespace MOVA2020.forms
{
    public partial class Asiakastiedot : Form
    {
        private Asiakas asiakas;
        private Primary paalomake;
        public Asiakastiedot(Primary p,Asiakas a)
        {
            this.asiakas = a;
            this.paalomake = p;
            InitializeComponent();
            tbEtunimi.Text = a.Etunimi;
            tbSukunimi.Text = a.Sukunimi;

            tbKatuosoite.Text = a.Lahiosoite;
            tbPaikkakunta.Text = a.Posti.Toimipaikka;
            tbPostinumero.Text = a.Posti.Postinro;

            tbPuhnro.Text = a.Puhelinnro;
            tbSahkoposti.Text = a.Email;

            this.paivita();
        }
        public void paivita()
        {
            this.paalomake.paivita();
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = this.HaeVaraukset;
        }
        private List<Varaus> HaeVaraukset => this.paalomake.Varaukset.FindAll(i => i.Asiakas.Asiakas_id == this.asiakas.Asiakas_id);

        private void dgvVaraukset_Click(object sender, EventArgs e)
        {
            if(dgvVaraukset.SelectedRows.Count > 0)
            {
                btnPoistaVaraus.Enabled = true;
            } else
            {
                btnPoistaVaraus.Enabled = false;
            }
        }

        private void btnLisaaVaraus_Click(object sender, EventArgs e)
        {

        }
    }
}
