using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVA2020.forms
{
    /*
     * Tehnyt: Tommi Puurunen
     * 
     * Toteuttaa toiminnallisuusmäärittelyn
     *      4.2.9 Mökin haku
     * 
     */
    public partial class Mokinhaku : Form
    {
        private Primary p;
        public Mokinhaku(Primary p)
        {
            this.p = p;
            InitializeComponent();
            dgvMokit.DataSource = null;
            dgvMokit.DataSource = p.Mokit;
            cbJarjestely.Items.Add("Nimi");
            cbJarjestely.Items.Add("Hinta");
            cbJarjestely.Items.Add("Toiminta-alue");
            cbJarjestely.Items.Add("Henkilömäärä");
        }
        private void tbHaku_TextChanged(object sender, EventArgs e)
        {
            /*
             * Otetaan sarake ja sen eri hakuvaihtoehtoja, ja etsitään mökkiä
             */
            if(cbJarjestely.SelectedIndex != -1)
            {
                switch(cbJarjestely.SelectedItem.ToString().ToLower())
                {
                    case "nimi":
                        dgvMokit.DataSource = null;
                        dgvMokit.DataSource = p.Mokit.FindAll(i => i.Mokkinimi.ToLower().StartsWith(tbHaku.Text.ToLower()));
                        break;
                    case "hinta":
                        dgvMokit.DataSource = null;
                        dgvMokit.DataSource = p.Mokit.FindAll(i => i.Hinta.ToString().StartsWith(tbHaku.Text));
                        break;
                    case "toiminta-alue":
                        dgvMokit.DataSource = null;
                        dgvMokit.DataSource = p.Mokit.FindAll(i => i.Toimintaalue.Nimi.ToLower().StartsWith(tbHaku.Text.ToLower()));
                        break;
                    case "henkilömäärä":
                        dgvMokit.DataSource = null;
                        dgvMokit.DataSource = p.Mokit.FindAll(i => i.Henkilomaara.ToString().StartsWith(tbHaku.Text));
                        break;
                }
            }
        }
    }
}
