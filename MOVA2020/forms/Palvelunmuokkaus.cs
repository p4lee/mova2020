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
    public partial class Palvelunmuokkaus : Form
    {
        private Primary lomake;
        private Palvelu palvelu;
        public Palvelunmuokkaus(Primary lomake)
        {
            this.lomake = lomake;
            this.palvelu = null;
            InitializeComponent();
            cbToimintaalueet.DataSource = this.lomake.Toimintaalueet;
            this.btnPalvelu.Text = "Lisää palvelu";
        }
        public Palvelunmuokkaus(Primary lomake, Palvelu p)
        {
            this.palvelu = p;
            this.lomake = lomake;
            InitializeComponent();
            cbToimintaalueet.DataSource = this.lomake.Toimintaalueet;
            this.tbNimi.Text = palvelu.Nimi;
            this.rtbKuvaus.Text = palvelu.Kuvaus;
            this.tbHintaEiAlv.Text = palvelu.Hinta.ToString();
            this.tbALV.Text = palvelu.Alv.ToString();
            this.tbHintaSisALV.Text = (palvelu.Alv + palvelu.Hinta).ToString();
            this.btnPalvelu.Text = "Muokkaa palvelua";
        }

        private void btnPalvelu_Click(object sender, EventArgs e)
        {
            string query;
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$toimintaalue", this.lomake.Toimintaalueet[this.cbToimintaalueet.SelectedIndex].Toiminta_alueid);
            pairs.Add("$nimi", tbNimi.Text);
            pairs.Add("$tyyppi", 1);
            pairs.Add("$kuvaus", rtbKuvaus.Text);
            pairs.Add("$hinta", Double.Parse(tbHintaEiAlv.Text));
            pairs.Add("$alv", Double.Parse(tbALV.Text));
            if (this.palvelu == null)
            {
                query = "INSERT INTO palvelu(toimintaalue_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES($toimintaalue, $nimi, $tyyppi, $kuvaus, $hinta, $alv)";

                this.lomake.Db.DMquery(query, pairs);
                this.lomake.paivita();
                this.Close();
            } else
            {
                query = "UPDATE palvelu SET toimintaalue_id=$toimintaalue, nimi=$nimi, tyyppi=$tyyppi, kuvaus=$kuvaus, hinta=$hinta, alv=$alv WHERE palvelu_id=$palvelu_id";
                pairs.Add("$palvelu_id", this.palvelu.Palvelu_id);

                this.lomake.Db.DMquery(query, pairs);
                this.lomake.paivita();
                this.Close();
            }
        }



        private void tbHintaEiAlv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsControl(e.KeyChar)) | (char.IsNumber(e.KeyChar)) | (char.IsPunctuation(e.KeyChar)))
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
