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
        private List<Posti> postinumerot = new List<Posti>();
        private List<Varaus> varaukset = new List<Varaus>();
        private List<Lasku> laskut = new List<Lasku>();
        private List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<Palvelu> palvelut = new List<Palvelu>();

        public DBHandler Db { get => db; set => db = value; }
        public List<Mokki> Mokit { get => mokit; set => mokit = value; }
        public List<Toimintaalue> Toimintaalueet { get => toimintaalueet; set => toimintaalueet = value; }
        public List<Posti> Postinumerot { get => postinumerot; set => postinumerot = value; }
        public List<Varaus> Varaukset { get => varaukset; set => varaukset = value; }
        public List<Lasku> Laskut { get => laskut; set => laskut = value; }
        public List<Asiakas> Asiakkaat { get => asiakkaat; set => asiakkaat = value; }
        public List<Palvelu> Palvelut { get => palvelut; set => palvelut = value; }

        public Primary()
        {

            InitializeComponent();
            this.paivita();
        }
        public void paivita()
        {
            this.PaivitaPostinumerot();
            this.PaivitaToimintaalueet();
            this.PaivitaMokit();
            this.PaivitaAsiakkaat();
            this.PaivitaPalvelut();
            this.PaivitaVaraukset();
            this.PaivitaLaskut();
        }
        private void PaivitaAsiakkaat()
        {
            this.Asiakkaat.Clear();
            List<Object[]> asiakkaatquery = this.Db.SelectQuery("SELECT * FROM asiakas");
            foreach(Object[] itemarr in asiakkaatquery)
            {
                Posti p = Postinumerot.Find(i => i.Postinro == (string)itemarr[1]);
                Asiakas a = new Asiakas((long)itemarr[0], (string)itemarr[2], (string)itemarr[3], (string)itemarr[4], (string)itemarr[5], (string)itemarr[6], p);
                this.Asiakkaat.Add(a);
            }
            dgvAsiakkaat.DataSource = null;
            dgvAsiakkaat.DataSource = Asiakkaat;
            
        }
        private void PaivitaPostinumerot()
        {
            this.Postinumerot.Clear();
            List<Object[]> postinumerotquery = this.Db.SelectQuery("SELECT * FROM posti");
            foreach (Object[] itemarr in postinumerotquery)
            {
                Posti p = new Posti((string)itemarr[0], (string)itemarr[1]);
                this.Postinumerot.Add(p);
            }

        }
        private void PaivitaToimintaalueet()
        {
            this.Toimintaalueet.Clear();
            List<Object[]> toimintaalueetquery = this.Db.SelectQuery("SELECT * FROM toimintaalue");
            foreach (Object[] itemarr in toimintaalueetquery)
            {
                Toimintaalue t = new Toimintaalue((long)itemarr[0], (string)itemarr[1]);
                this.Toimintaalueet.Add(t);
            }
            dgvToimintaalueet.DataSource = null;
            dgvToimintaalueet.DataSource = this.Toimintaalueet;
        }
        private void PaivitaMokit()
        {
            this.Mokit.Clear();
            List<Object[]> mokitquery = this.Db.SelectQuery("SELECT * FROM mokki");
            foreach (Object[] itemarr in mokitquery)
            {
                Toimintaalue t = Toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Posti p = Postinumerot.Find(i => i.Postinro == (string)itemarr[2]);
                Mokki m = new Mokki(
                    (long)itemarr[0],
                    (string)itemarr[3],
                    (string)itemarr[5],
                    (string)itemarr[6],
                    (string)itemarr[8],
                    p,
                    t,
                    (double)itemarr[4],
                    (int)(long)itemarr[7]);
                this.Mokit.Add(m);
            }
            dgvMokit.DataSource = null;
            dgvMokit.DataSource = this.Mokit;
        }
        private void PaivitaPalvelut()
        {
            this.Palvelut.Clear();
            List<Object[]> palvelutquery = this.Db.SelectQuery("SELECT * FROM palvelu");
            foreach(Object[] itemarr in palvelutquery)
            {
                Toimintaalue t = Toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Palvelu p = new Palvelu((long)itemarr[0], (int)(long)itemarr[3], (string)itemarr[2], (string)itemarr[4], (double)itemarr[5], (double)itemarr[6], t);
                this.Palvelut.Add(p);
            }
            this.dgvPalvelut.DataSource = null;
            this.dgvPalvelut.DataSource = this.Palvelut;
        }
        private void PaivitaLaskut()
        {
            this.Laskut.Clear();
            List<Object[]> laskuquery = this.Db.SelectQuery("SELECT * FROM lasku");
            foreach (Object[] itemarr in laskuquery)
            {
                Varaus v = Varaukset.Find(i => i.Varaus_id == (long)itemarr[1]);
                Lasku l = new Lasku((long)itemarr[0], (double)itemarr[2], (double)itemarr[3], v);
                Laskut.Add(l);
            }
            this.dgvLaskut.DataSource = null;
            this.dgvLaskut.DataSource = Laskut;
        }
        private void PaivitaVaraukset()
        {
            this.Varaukset.Clear();
            List<Object[]> varausquery = this.Db.SelectQuery("SELECT * FROM varaus");
            foreach(Object[] itemarr in varausquery)
            {
                List<Palvelu> varauksenpalvelut = new List<Palvelu>();
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$varausid", itemarr[0]);
                List<Object[]> varauksenpalvelutquery = this.Db.SelectQuery("SELECT * FROM varauksen_palvelut WHERE varaus_id=$varausid", pairs);
                foreach(Object[] palvelu in varauksenpalvelutquery)
                {
                    varauksenpalvelut.Add(Palvelut.Find(i => i.Palvelu_id == (long)palvelu[0]));
                }
                
                Asiakas a = Asiakkaat.Find(i => i.Asiakas_id == (long)itemarr[1]);
                Mokki m = Mokit.Find(i => i.Mokki_id == (long)itemarr[2]);
                var date = itemarr[4] as String;
                DateTime t = DateTime.Parse("1970-01-01 00:00:00");
                if(date != null)
                {
                    t = DateTime.Parse(date);
                }
                
                Varaus v = new Varaus((long)itemarr[0], DateTime.Parse((string)itemarr[3]), t, DateTime.Parse((string)itemarr[5]), DateTime.Parse((string)itemarr[6]), a, m, varauksenpalvelut);
                this.Varaukset.Add(v);
            }
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = Varaukset;
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
            if(this.Db.DMquery(query, pairs) !=-1)
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

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelunmuokkaus p = new Palvelunmuokkaus(this);
            p.Show();
        }

        private void btnMuokkaaPalvelua_Click(object sender, EventArgs e)
        {

            Palvelu palvelu = (Palvelu)dgvPalvelut.SelectedRows[0].DataBoundItem;

            Palvelunmuokkaus p = new Palvelunmuokkaus(this, palvelu);
            p.Show();
        }

        private void dgvPalvelut_Click(object sender, EventArgs e)
        {
            if(dgvPalvelut.SelectedRows.Count > 0)
            {
                btnMuokkaaPalvelua.Enabled = true;
                btnPoistaPalvelu.Enabled = true;
            } else
            {
                btnMuokkaaPalvelua.Enabled = false;
                btnPoistaPalvelu.Enabled = false;
            }
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelu palvelu = (Palvelu)dgvPalvelut.SelectedRows[0].DataBoundItem;

            DialogResult dr = MessageBox.Show("Haluatko poistaa palvelun "+palvelu.Nimi+" ?", "Poista Palvelu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$palvelu_id", palvelu.Palvelu_id);
                string query = "DELETE FROM palvelu WHERE palvelu_id = $palvelu_id";
                this.Db.DMquery(query, pairs);
                this.paivita();
            }
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            Laskutus l = new Laskutus();
            l.Show();
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            Asiakastiedot at = new Asiakastiedot(this);
            at.Show();
        }

        private void btnMuokkaaAsiakas_Click(object sender, EventArgs e)
        {
            Asiakas a = (Asiakas)dgvAsiakkaat.SelectedRows[0].DataBoundItem;
            Asiakastiedot at = new Asiakastiedot(this, a);
            at.Show();
        }

        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            Asiakas asiakas = (Asiakas)dgvAsiakkaat.SelectedRows[0].DataBoundItem;
            DialogResult dr = MessageBox.Show("Haluatko poistaa palvelun " + asiakas.ToString() + " ?", "Poista Palvelu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$asiakas_id", asiakas.Asiakas_id);
                string query = "DELETE FROM asiakas WHERE asiakas_id=$asiakas_id";
                this.Db.DMquery(query, pairs);
                this.paivita();
            }
        }
    }
}
