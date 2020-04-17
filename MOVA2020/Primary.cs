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
using MOVA2020.forms;
namespace MOVA2020
{
    public partial class Primary : Form
    {
        private DBHandler db = new DBHandler();
        private List<Mokki> mokit = new List<Mokki>();
        private List<Toimintaalue> toimintaalueet = new List<Toimintaalue>();
        private List<Varaus> varaukset = new List<Varaus>();
        public Primary()
        {

            InitializeComponent();
            this.paivita();
        }
        public void paivita()
        {
            this.toimintaalueet.Clear();
            List<Object[]> toimintaalueetquery = this.db.SelectQuery("SELECT * FROM toimintaalue");
            foreach (Object[] itemarr in toimintaalueetquery)
            {
                Toimintaalue t = new Toimintaalue((long)itemarr[0], (string)itemarr[1]);
                this.toimintaalueet.Add(t);
            }
            dgvToimintaalueet.DataSource = null;
            dgvToimintaalueet.DataSource = this.toimintaalueet;
        }

        private void btnLisaatoimintaalue_Click(object sender, EventArgs e)
        {
            // SQL kysely
            string query = "INSERT INTO toimintaalue(nimi) VALUES($nimi)";
            /*
                Luodaan dictionary jossa lisätään kyselyssä olevat $nimi, muuttujaksi nimi
            */ 
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$nimi", tbLisaaToimintaalueNimi.Text);
            if(this.db.DMquery(query, pairs) !=-1)
            {
                this.paivita();
            } else
            {
                MessageBox.Show("error");
            }
            
        }

        private void btMuokkaa_Click(object sender, EventArgs e)
        {
            Posti posti = new Posti(70500, "kuopio");
            Asiakas asiakas = new Asiakas(2,"tommi","puurunen","hermanninkatu","tommi.puurunen@edu.savonia.fi","3232323", posti);
            Asiakastiedot t = new Asiakastiedot(asiakas);
            t.Show();
        }
    }
}
