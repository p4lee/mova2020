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
    public partial class Asiakastiedot : Form
    {
        Primary pri;
        private Asiakas asiakas;        
       

        public Asiakastiedot(Primary t, Asiakas asiakas)
        {
            InitializeComponent();
            pri = t;
            this.asiakas = asiakas;
            
            tbEtunimi.Text = asiakas.Etunimi;
            tbSukunimi.Text = asiakas.Sukunimi;
            tbLahiosoite.Text = asiakas.Lahiosoite;           
            tbPostinumero.Text = asiakas.Posti.Postinro; //tätä herjaa kun painaa muokkaa!
            tbPostitoimipaikka.Text = asiakas.Posti.Toimipaikka; //tätä herjaa kun painaa muokkaa!
            tbPuhelinnumero.Text = asiakas.Puhelinnro;
            tbSahkopostiosoite.Text = asiakas.Email;  
        }


        public Asiakastiedot(Primary t) //luotu uusi konstruktori
        {
            InitializeComponent();
            pri = t;           
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


        private void btTallenna_Click(object sender, EventArgs e)
        {
            Posti posti2 = new Posti(tbPostinumero.Text, tbPostitoimipaikka.Text);
        
            //if (asiakas == null)
            //{
                asiakas = new Asiakas(999, tbEtunimi.Text, tbSukunimi.Text,
                    tbLahiosoite.Text, tbSahkopostiosoite.Text,tbPuhelinnumero.Text, posti2); //uusi olio
                
                pri.paivita();
                MessageBox.Show("Uusi asiakas tallennettu.");
                this.Close();

            //}
            //else
            //{
            //    asiakas = new Asiakas(999, tbEtunimi.Text, tbSukunimi.Text, 
            //        tbLahiosoite.Text, tbSahkopostiosoite.Text, tbPuhelinnumero.Text, posti2);
                
            //    asiakas.Etunimi = tbEtunimi.Text; 
            //    asiakas.Sukunimi = tbSukunimi.Text;
            //    asiakas.Lahiosoite = tbLahiosoite.Text;
            //    asiakas.Email = tbSahkopostiosoite.Text;
            //    asiakas.Puhelinnro = tbPuhelinnumero.Text;

            //    pri.paivita();
            //    MessageBox.Show("Uusi asiakas tallennettu.");
            //    this.Close();

            //} 
        }


        private void btPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
