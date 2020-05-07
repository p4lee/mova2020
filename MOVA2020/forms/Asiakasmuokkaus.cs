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
namespace MOVA2020.forms
{
    /*
     *  MOVA2020
     * Tekijä: Teija Tilli
     * 
     * Toteuttaa  toiminnallisuusmäärittelyn 
     *      4.2.1 Asiakkaan lisäys  
     *      4.2.2 Asiakkaan muokkaus 
     * 
     */
    public partial class Asiakasmuokkaus : Form
    {
        Primary lomake;
        private Asiakas asiakas;        
       

        public Asiakasmuokkaus(Primary t, Asiakas asiakas)
        {
            InitializeComponent();
            lomake = t;
            this.asiakas = asiakas;
            
            this.tbEtunimi.Text = asiakas.Etunimi;
            this.tbSukunimi.Text = asiakas.Sukunimi;
            this.tbLahiosoite.Text = asiakas.Lahiosoite;
            this.tbPostinumero.Text = asiakas.Posti.Postinro; 
            this.tbPostitoimipaikka.Text = asiakas.Posti.Toimipaikka; 
            this.tbPuhelinnumero.Text = asiakas.Puhelinnro;
            this.tbSahkopostiosoite.Text = asiakas.Email;  
        }

        public Asiakasmuokkaus(Primary t) 
        {
            InitializeComponent();
            lomake = t;           
        }

        private void btTallenna_Click(object sender, EventArgs e)
        {
            /*
             * Tarkastetaan, että kaikki palkolliset kentät on täytetty. 
             */
            if (tbEtunimi .Text == "" || tbSukunimi.Text == "" || tbLahiosoite.Text  == "" || tbPostinumero.Text == "" || tbPuhelinnumero.Text == "")
            {
                MessageBox.Show("Kaikki kentät täytettävä paitsi sähköposti.");
                return;
            }
            else {
                // Jos asiakkaalla ei ole aiempia asiakastietoja (4.2.2), lisätään tietokantaan uusi asiakas (4.2.1).  
                string query;

            Dictionary<string, object> pairs = new Dictionary<string, object>();          
            pairs.Add("$etunimi", tbEtunimi.Text);
            pairs.Add("$sukunimi", tbSukunimi.Text);
            pairs.Add("$lahiosoite", tbLahiosoite.Text);
            pairs.Add("$email", tbSahkopostiosoite .Text);
            pairs.Add("$puhelinnro", tbPuhelinnumero.Text);
            pairs.Add("$postinro", tbPostinumero.Text);       

            if (this.asiakas == null)
            {
                query = "INSERT INTO asiakas(etunimi, sukunimi, lahiosoite, email, puhelinnro, postinro) " +
                    "VALUES($etunimi, $sukunimi, $lahiosoite, $email, $puhelinnro, $postinro)";

                this.lomake.Db.DMquery(query, pairs);
                this.lomake.paivita();
                MessageBox.Show("Uusi asiakas tallennettu.");
                this.Close();
            }
            else
            {
                query = "UPDATE asiakas SET etunimi=$etunimi, sukunimi=$sukunimi, " +
                    "lahiosoite=$lahiosoite, email=$email, puhelinnro=$puhelinnro, postinro=$postinro WHERE asiakas_id=$asiakas_id";
                pairs.Add("$asiakas_id", this.asiakas.Asiakas_id);
                this.lomake.Db.DMquery(query, pairs);
                lomake.paivita();
                MessageBox.Show("Asiakkaan tiedot muutettu ja tallennettu.");
                this.Close();
            }
            }
        }

        private void btPeruuta_Click(object sender, EventArgs e)
        {
            this.Close(); //Suljetaan ko formi, ei tallenneta muutoksia.
        }

        private void tbPostinumero_Leave(object sender, EventArgs e)
        {
            // Kun tbpostinumero-kentästä poistuu, asettuu toimipaikka automaattisesti kenttäänsä. 
            if (tbPostinumero.Text == "")
            {
                MessageBox.Show("Postinumerokenttä on pakollinen.");
                return;
            }
            else
            {
                Posti p = this.lomake.Postinumerot.Find(i => i.Postinro == tbPostinumero.Text);
                if (p == null)
                {
                    MessageBox.Show("Postinumeroa ei löydy Suomesta.");
                    tbPostinumero.Text = "";
                    return;
                }
                else
                {
                    tbPostitoimipaikka.Text = p.Toimipaikka;
                }
            }
        }


        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Varmistetaan ainoastaan numeroiden syöttö Asiakasmuokkaus -formin postinumero-kenttään.
            if ((char.IsControl(e.KeyChar)) | (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPuhelinnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char.IsControl(e.KeyChar)) | (char.IsNumber(e.KeyChar) | (e.KeyChar.ToString().Equals("+") && tbPuhelinnumero.Text.Length==0)))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
    }
}
