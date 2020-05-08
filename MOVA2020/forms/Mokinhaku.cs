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
     * Tehnyt: Tommi Puurunen
     * 
     * Toteuttaa toiminnallisuusmäärittelyn
     *      4.2.9 Mökin haku
     * 
     */
    public partial class Mokinhaku : Form
    {
        private Primary p;
        private Varauksenmuokkaus vm;
        public Mokinhaku(Varauksenmuokkaus vm)
        {
            this.vm = vm;
            this.p = vm.Lomake;
            InitializeComponent();
            dgvMokit.DataSource = null;
            dgvMokit.DataSource = p.Mokit;
            cbJarjestely.Items.Add("Nimi");
            cbJarjestely.Items.Add("Hinta");
            cbJarjestely.Items.Add("Toiminta-alue");
            cbJarjestely.Items.Add("Henkilömäärä");
        }
        public Mokinhaku(Primary p)
        {
            this.p = p;
            InitializeComponent();
            btnValitsemokki.Visible = false;

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

        private void btnValitsemokki_Click(object sender, EventArgs e)
        {
            /*
             * Laitetaan mökkihaun tulos Varauksen lisäys lomakkeeseen
             */
            if(dgvMokit.SelectedRows.Count > 0)
            {
                Mokki m = (Mokki)dgvMokit.SelectedRows[0].DataBoundItem;
                this.vm.ValitseMokki(m);
                this.Close();
            } else
            {
                MessageBox.Show("Mökki pitää olla valittuna!", "Virhe");
            }
        }

        private void btnMokintiedot_Click(object sender, EventArgs e)
        {
            if (dgvMokit.SelectedRows.Count > 0)
            {
                Mokki m = (Mokki)dgvMokit.SelectedRows[0].DataBoundItem;
                Mokkitiedot mt = new Mokkitiedot(this.p, m);
                mt.Show();
            }
            else
            {
                MessageBox.Show("Mökki pitää olla valittuna!", "Virhe");
            }
        }
    }
}
