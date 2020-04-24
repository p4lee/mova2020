using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs;
using MOVA2020.objs.dbitems;

namespace MOVA2020.forms
{
    public partial class mokkimuokkaus : Form
    {
        //fix
        Primary p;
        Mokki m;

        public mokkimuokkaus(Primary pr)
        {
            this.Text = "Mökin lisäys";
            InitializeComponent();
            this.p = pr;
            this.m = null;
            cbToimialue.DataSource = this.p.Toimintaalueet;
            this.btnMokinLisays.Text = "Lisää Mökki";
        }
        public mokkimuokkaus(Primary pr, Mokki mo)
        {
            this.Text = "Muokkaa mökkiä";
            InitializeComponent();
            this.m = mo;
            this.p = pr;
            cbToimialue.DataSource = this.p.Toimintaalueet;
            this.tbMokkiNimi.Text = m.Mokkinimi;
            this.tbPostinumero.Text = m.Posti.Postinro;
            this.tbKatuosoite.Text = m.Katuosoite;
            this.tbMokkiHinta.Text = m.Hinta.ToString();
            this.nmbHenkilomaara.Value = m.Henkilomaara;
            this.rtbVarustelu.Text = m.Varustelu;
            this.rtbKuvaus.Text = m.Kuvaus;
            this.btnMokinLisays.Text = "Tallenna Muokkaus";
        }

        private void btnLisays_Click(object sender, EventArgs e)
        {
            //ei tämä
        }

        private void btnMokinLisays_Click(object sender, EventArgs e)
        {
            //jos kaikki kentät eivät ole täytettynä, se ei anna lisätä mökkiä tietokantaan
            if (cbToimialue.Text.Length == 0 || tbMokkiNimi.TextLength == 0 || tbPostinumero.TextLength == 0
                || tbKatuosoite.TextLength == 0 || tbMokkiHinta.TextLength == 0 || rtbVarustelu.Text.Length == 0
                || rtbKuvaus.Text.Length == 0)
            {
                MessageBox.Show("Kaikki kentät tulee olla täytettynä, ennen kuin voit lisätä mökin.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SQL kysely
                string query;
                /*
                    Luodaan dictionary jossa lisätään kyselyssä olevat $nimi, muuttujaksi nimi
                */
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$toimialue", this.p.Toimintaalueet[this.cbToimialue.SelectedIndex].Toiminta_alueid);
                pairs.Add("$mokkinimi", tbMokkiNimi.Text);
                pairs.Add("$postinumero", tbPostinumero.Text);
                pairs.Add("$katuosoite", tbKatuosoite.Text);
                pairs.Add("$hinta", Double.Parse(tbMokkiHinta.Text));
                pairs.Add("$henkilomaara", nmbHenkilomaara.Value);
                pairs.Add("$varustelu", rtbVarustelu.Text);
                pairs.Add("$kuvaus", rtbKuvaus.Text);

                if (this.m == null)
                {
                    query = "INSERT INTO mokki(toimintaalue_id, mokkinimi, postinro, katuosoite, hinta, henkilomaara, varustelu, kuvaus) VALUES($toimialue, $mokkinimi, $postinumero, $katuosoite, $hinta, $henkilomaara, $varustelu, $kuvaus)";

                    this.p.Db.DMquery(query, pairs);
                    this.p.paivita();
                    this.Close();
                }
                else
                {
                    query = "UPDATE mokki SET toimintaalue_id=$toimialue, mokkinimi=$mokkinimi, postinro=$postinumero, katuosoite=$katuosoite, hinta=$hinta, henkilomaara=$henkilomaara, varustelu=$varustelu, kuvaus=$kuvaus WHERE mokki_id=$mokki_id";
                    pairs.Add("$mokki_id", this.m.Mokki_id);

                    this.p.Db.DMquery(query, pairs);
                    this.p.paivita();
                    this.Close();
                }
            }
        }

        private void tbMokkiHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vain numerot, backspace ja pilkku sallitaan
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // ainoastaan yksi pilkku on mahdollista laittaa
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
