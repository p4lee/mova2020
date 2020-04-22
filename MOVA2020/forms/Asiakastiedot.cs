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
namespace MOVA2020.forms
{
    public partial class Asiakastiedot : Form
    {
        Primary lomake;
        private Asiakas asiakas;
        private DBHandler db = new DBHandler();

        public Asiakastiedot(Primary t) //luotu uusi konstruktori
        {
            this.lomake = t;
            this.asiakas = null;
            InitializeComponent();
            
            //cbToimintaalueet.DataSource = this.lomake.Toimintaalueet;
            //this.btnPalvelu.Text = "Lisää palvelu";
        }

        public Asiakastiedot(Primary t, Asiakas asiakas)
        {           
            this.lomake = t;
            this.asiakas = asiakas;
            InitializeComponent();
            //cbToimintaalueet.DataSource = this.lomake.Toimintaalueet;
            
            this.tbEtunimi.Text = asiakas.Etunimi;
            this.tbSukunimi.Text = asiakas.Sukunimi;
            this.tbLahiosoite.Text = asiakas.Lahiosoite;           
            this.tbPostinumero.Text = asiakas.Postinro.Postinro; //tätä herjaa kun painaa muokkaa!
            this.tbPostitoimipaikka.Text = asiakas.Postinro.Toimipaikka; //tätä herjaa kun painaa muokkaa!
            this.tbPuhelinnumero.Text = asiakas.Puhelinnro;
            this.tbSahkopostiosoite.Text = asiakas.Email;  
        }
     



        private void btTallenna_Click(object sender, EventArgs e)
        {
            Posti posti2 = new Posti(tbPostinumero.Text, tbPostitoimipaikka.Text);
        
            asiakas = new Asiakas(999, tbEtunimi.Text, tbSukunimi.Text,
            tbLahiosoite.Text, tbSahkopostiosoite.Text,tbPuhelinnumero.Text, posti2); 

                // SQL kysely, päivitetään siis tietokantaa
                string query = "INSERT INTO asiakas(etunimi) VALUES($etunimi)";
                /*
                Luodaan dictionary jossa lisätään kyselyssä olevat $nimi, muuttujaksi nimi
                */
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$etunimi", tbEtunimi.Text);
                if (this.db.DMquery(query, pairs) != -1)
                {
                     lomake.paivita();
                }
                else
                {
                    MessageBox.Show("error");
                }

            //lomake.paivita();
            MessageBox.Show("Uusi asiakas tallennettu.");
            this.Close();

        }


        private void btPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsControl(e.KeyChar)) | (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
