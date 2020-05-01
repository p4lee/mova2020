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
     * Palvelun muokkaus ja lisäys
     * 
     * 
     */
    public partial class Palvelunmuokkaus : Form
    {

        /*
         * Palveluitten lisäys ja muokkaus
         */
        private Toimintaalueentiedot t;
        private Primary lomake;
        private Palvelu palvelu;
        public Palvelunmuokkaus(Toimintaalueentiedot t)
        {
            /*
             * Otetaan päälomakkeen tieto ja laitetaan palvelu muuttuja nulliksi
             * Ohjelma tekee muokkauksen ja lisäyksen samassa lomakkeessa, riippuen mitä konstruktoria käyttää.
             */
            this.t = t;
            this.lomake = t.P;
            this.palvelu = null;
            InitializeComponent();
            this.btnPalvelu.Text = "Lisää palvelu";
        }
        public Palvelunmuokkaus(Toimintaalueentiedot t, Palvelu p)
        {
            /*
             * Palvelun muokkaamisen konstruktori
             */
            this.t = t;
            this.palvelu = p;
            this.lomake = t.P;
            InitializeComponent();
            this.tbNimi.Text = palvelu.Nimi;
            this.rtbKuvaus.Text = palvelu.Kuvaus;
            this.tbHintaEiAlv.Text = palvelu.Hinta.ToString();
            this.tbALV.Text = palvelu.Alv.ToString();
            this.tbHintaSisALV.Text = (palvelu.Alv + palvelu.Hinta).ToString();
            this.btnPalvelu.Text = "Muokkaa palvelua";
        }

        private void btnPalvelu_Click(object sender, EventArgs e)
        {
            /*
             * Lisää Palvelu
             * Muokkaa Palvelua
             */

            if(tbNimi.Text.Length == 0 || tbHintaEiAlv.Text.Length == 0 || tbALV.Text.Length == 0 || tbHintaSisALV.Text.Length == 0)
            {
                MessageBox.Show("Täytä kaikki kentät!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query;
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$toimintaalue", this.t.T.Toiminta_alueid);
            pairs.Add("$nimi", tbNimi.Text);
            pairs.Add("$tyyppi", 1);
            pairs.Add("$kuvaus", rtbKuvaus.Text);
            pairs.Add("$hinta", Double.Parse(tbHintaEiAlv.Text));
            pairs.Add("$alv", Double.Parse(tbALV.Text));
            if (this.palvelu == null)
            {
                query = "INSERT INTO palvelu(toimintaalue_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES($toimintaalue, $nimi, $tyyppi, $kuvaus, $hinta, $alv)";

                this.lomake.Db.DMquery(query, pairs);
                this.t.paivita();
                this.Close();
            } else
            {
                query = "UPDATE palvelu SET toimintaalue_id=$toimintaalue, nimi=$nimi, tyyppi=$tyyppi, kuvaus=$kuvaus, hinta=$hinta, alv=$alv WHERE palvelu_id=$palvelu_id";
                pairs.Add("$palvelu_id", this.palvelu.Palvelu_id);

                this.lomake.Db.DMquery(query, pairs);
                this.t.paivita();
                this.Close();
            }
        }



        private void tbHintaEiAlv_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Estetään kirjainten ja muitten erikoismerkkien kuin pilkun käyttö
             * 
             */
            if ((char.IsControl(e.KeyChar)) | (char.IsNumber(e.KeyChar)) | (e.KeyChar == char.Parse(",")&&!tbHintaEiAlv.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbHintaEiAlv_TextChanged(object sender, EventArgs e)
        {
            if (tbHintaEiAlv.Text.Length > 1)
            {
                tbALV.Text = ((1.24 * Double.Parse(tbHintaEiAlv.Text)) - Double.Parse(tbHintaEiAlv.Text)).ToString();
                tbHintaSisALV.Text = (Double.Parse(tbALV.Text) + Double.Parse(tbHintaEiAlv.Text)).ToString();
            }
        }
    }
}
