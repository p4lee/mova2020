using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
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
            string nimi = tbLisaaToimintaalueNimi.Text;
            // SQL kysely
            string query = "INSERT INTO toimintaalue(nimi) VALUES($nimi)";
            /*
                Luodaan dictionary jossa lisätään kyselyssä olevat $nimi, muuttujaksi nimi
            */ 
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$nimi", nimi);
            if(this.db.DMquery(query, pairs) !=-1)
            {
                this.paivita();
            } else
            {
                MessageBox.Show("error");
            }
            
        }

        private void Primary_Load(object sender, EventArgs e)
        {

        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            //aukaisee mokkimuokkaus filen
            mokkimuokkaus lisaamokki = new mokkimuokkaus();
            lisaamokki.ShowDialog();
        }

        private void btnMuokkaaMokki_Click(object sender, EventArgs e)
        {
            //KESKEN
            //Muokkaa vielä, että valitsee valitun mökin muokattavaksi
            //aukaiseen mokkimuokkaus filen valitun mokin tiedoista
            mokkimuokkaus mokkimuokkaus = new mokkimuokkaus();
            mokkimuokkaus.ShowDialog();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            //tekee merkkiäänen ja aukaisee varmennuskyselupoistosta-messageboxin
            SystemSounds.Beep.Play();
            varmennus_kysely_poistosta varmennus = new varmennus_kysely_poistosta();
            varmennus.ShowDialog();
        }

        private void btnMokinTiedotJaPalvelut_Click(object sender, EventArgs e)
        {
            //KESKEN
            //aukaisee mokkitiedot filen valitusta mokista
            mokkitiedot mokkitiedotjapalvelut = new mokkitiedot();
            mokkitiedotjapalvelut.ShowDialog();
        }
    }
}
