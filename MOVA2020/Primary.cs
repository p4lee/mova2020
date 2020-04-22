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
            this.asiakkaat.Clear();
            List<Object[]> asiakkaatquery = this.db.SelectQuery("SELECT * FROM asiakas");
            foreach (Object[] itemarr in asiakkaatquery)
            {
                Posti p = postinumerot.Find(i => i.Postinro == (string)itemarr[1]);
                Asiakas a = new Asiakas((long)itemarr[0], (string)itemarr[2], (string)itemarr[3], (string)itemarr[4], (string)itemarr[5], (string)itemarr[6], p);
                this.asiakkaat.Add(a);
            }
            dgvAsiakkaat.DataSource = null;
            dgvAsiakkaat.DataSource = asiakkaat;

        }
        private void PaivitaPostinumerot()
        {
            this.postinumerot.Clear();
            List<Object[]> postinumerotquery = this.db.SelectQuery("SELECT * FROM posti");
            foreach (Object[] itemarr in postinumerotquery)
            {
                Posti p = new Posti((string)itemarr[0], (string)itemarr[1]);
                this.postinumerot.Add(p);
            }

        }
        private void PaivitaToimintaalueet()
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
        private void PaivitaMokit()
        {
            this.mokit.Clear();
            List<Object[]> mokitquery = this.db.SelectQuery("SELECT * FROM mokki");
            foreach (Object[] itemarr in mokitquery)
            {
                Toimintaalue t = toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Posti p = postinumerot.Find(i => i.Postinro == (string)itemarr[2]);
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
                this.mokit.Add(m);
            }
            dgvMokit.DataSource = null;
            dgvMokit.DataSource = this.mokit;
        }
        private void PaivitaPalvelut()
        {
            this.palvelut.Clear();
            List<Object[]> palvelutquery = this.db.SelectQuery("SELECT * FROM palvelu");
            foreach (Object[] itemarr in palvelutquery)
            {
                Toimintaalue t = toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Palvelu p = new Palvelu((long)itemarr[0], (int)(long)itemarr[3], (string)itemarr[2], (string)itemarr[4], (double)itemarr[5], (double)itemarr[6], t);
                this.palvelut.Add(p);
            }
            this.dgvPalvelut.DataSource = null;
            this.dgvPalvelut.DataSource = this.palvelut;
        }
        private void PaivitaLaskut()
        {
            this.laskut.Clear();
            List<Object[]> laskuquery = this.db.SelectQuery("SELECT * FROM lasku");
            foreach (Object[] itemarr in laskuquery)
            {
                Varaus v = varaukset.Find(i => i.Varaus_id == (long)itemarr[1]);
                Lasku l = new Lasku((long)itemarr[0], (double)itemarr[2], (double)itemarr[3], v);
                laskut.Add(l);
            }
            this.dgvLaskut.DataSource = null;
            this.dgvLaskut.DataSource = laskut;
        }
        private void PaivitaVaraukset()
        {
            this.varaukset.Clear();
            List<Object[]> varausquery = this.db.SelectQuery("SELECT * FROM varaus");
            foreach (Object[] itemarr in varausquery)
            {
                List<Palvelu> varauksenpalvelut = new List<Palvelu>();
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$varausid", itemarr[0]);
                List<Object[]> varauksenpalvelutquery = this.db.SelectQuery("SELECT * FROM varauksen_palvelut WHERE varaus_id=$varausid", pairs);
                foreach (Object[] palvelu in varauksenpalvelutquery)
                {
                    varauksenpalvelut.Add(palvelut.Find(i => i.Palvelu_id == (long)palvelu[0]));
                }

                Asiakas a = asiakkaat.Find(i => i.Asiakas_id == (long)itemarr[1]);
                Mokki m = mokit.Find(i => i.Mokki_id == (long)itemarr[2]);
                var date = itemarr[4] as String;
                DateTime t = DateTime.Parse("1970-01-01 00:00:00");
                if (date != null)
                {
                    t = DateTime.Parse(date);
                }

                Varaus v = new Varaus((long)itemarr[0], DateTime.Parse((string)itemarr[3]), t, DateTime.Parse((string)itemarr[5]), DateTime.Parse((string)itemarr[6]), a, m, varauksenpalvelut);
                this.varaukset.Add(v);
            }
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = varaukset;
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
            if (this.db.DMquery(query, pairs) != -1)
            {
                this.paivita();
            }
            else
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

        private void dgvMokit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            string column = grid.Columns[e.ColumnIndex].Name;
            if (column.Equals("Varustelu"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.mokit.OrderBy(x => x.Varustelu).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.mokit.OrderByDescending(x => x.Varustelu).ToList();
                }
            }

            else if (column.Equals("Toimintaalue"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.mokit.OrderBy(x => x.Toimintaalue.Nimi).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.mokit.OrderByDescending(x => x.Toimintaalue.Nimi).ToList();
                }

            }
            else
            {
                dgvMokit.DataSource = this.mokit;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }

        private void dgvPalvelut_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else{
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Nimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderBy(x => x.Nimi).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderByDescending(x => x.Nimi).ToList();
                }
            }
            else if (column.Equals("Palvelu_id"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderBy(x => x.Palvelu_id).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderByDescending(x => x.Palvelu_id).ToList();
                }
            }
            else if (column.Equals("Toimintaalue"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderBy(x => x.Toimintaalue.Nimi).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderByDescending(x => x.Toimintaalue.Nimi).ToList();
                }
            }
            else if (column.Equals("Hinta"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderBy(x => x.Hinta).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.palvelut.OrderByDescending(x => x.Hinta).ToList();
                }
            }
            else
            {
                dgvPalvelut.DataSource = this.palvelut;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }

        private void dgvToimintaalueet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Toiminta_alueid"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderBy(x => x.Toiminta_alueid).ToList();
                }
                else
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderByDescending(x => x.Toiminta_alueid).ToList();
                }
            }
            else if (column.Equals("Nimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderBy(x => x.Nimi).ToList();
                }
                else
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderByDescending(x => x.Nimi).ToList();
                }
            }

            else
            {
                dgvToimintaalueet.DataSource = this.toimintaalueet;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
    }
}

