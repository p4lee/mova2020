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
        private Asiakas asiakas;
        public Asiakastiedot(Asiakas asiakas)
        {
            InitializeComponent();
            this.asiakas = asiakas;
            tbEtunimi.Text = asiakas.Etunimi;
            tbSukunimi.Text = asiakas.Sukunimi;
            tbLahiosoite.Text = asiakas.Lahiosoite;
            tbPostinumero.Text = asiakas.Posti.Postinro.ToString();
            tbPostitoimipaikka.Text = asiakas.Posti.Toimipaikka;
            tbPuhelinnumero.Text = asiakas.Puhelinnro;
            tbSahkopostiosoite.Text = asiakas.Email;
            
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
 
        }
    }
}
