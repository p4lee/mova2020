using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs.dbitems;
namespace MOVA2020.forms
{
    public partial class Toimintaalueentiedot : Form
    {
        private Primary p;
        private Toimintaalue t;
        public Toimintaalueentiedot(Primary p, Toimintaalue t)
        {
            this.p = p;
            this.t = t;
            InitializeComponent();
            tbNimi.Text = t.Nimi;
            this.paivita();
        }
        public void paivita()
        {
            this.p.paivita();
            dgvMokit.DataSource = null;
            dgvMokit.DataSource = Mokit;

            dgvPalvelut.DataSource = null;
            dgvPalvelut.DataSource = Palvelut;
        }

        public List<Mokki> Mokit { get => this.p.Mokit.FindAll(i => i.Toimintaalue.Toiminta_alueid == t.Toiminta_alueid); }
        public List<Palvelu> Palvelut { get => this.p.Palvelut.FindAll(i => i.Toimintaalue.Toiminta_alueid == t.Toiminta_alueid); }
        public Primary P { get => p; set => p = value; }
        public Toimintaalue T { get => t; set => t = value; }

        private void btnVaihdanimi_Click(object sender, EventArgs e)
        {
            if (tbNimi.Text.Length > 0) {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$nimi", tbNimi.Text);
                pairs.Add("$toiminta_alueid", this.t.Toiminta_alueid);
                string query = "UPDATE toimintaalue SET nimi = $nimi WHERE toimintaalue_id = $toiminta_alueid";

                this.p.Db.DMquery(query, pairs);
                this.paivita();
            } else
            {
                MessageBox.Show("Nimi -kenttä pitää olla täytetty!");
            }
        }

        private void dgvPalvelut_Click(object sender, EventArgs e)
        {
            if (dgvPalvelut.SelectedRows.Count > 0)
            {
                btnMuokkaaPalvelu.Enabled = true;
                btnPoistaPalvelu.Enabled = true;
            }
            else
            {
                btnMuokkaaPalvelu.Enabled = false;
                btnPoistaPalvelu.Enabled = false;
            }
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelu palvelu = (Palvelu)dgvPalvelut.SelectedRows[0].DataBoundItem;
            SystemSounds.Beep.Play();
            DialogResult dr = MessageBox.Show("Haluatko poistaa palvelun " + palvelu.Nimi + " ?", "Poista Palvelu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$palvelu_id", palvelu.Palvelu_id);
                string query = "DELETE FROM palvelu WHERE palvelu_id = $palvelu_id";
                this.p.Db.DMquery(query, pairs);
                this.paivita();
            }
        }

        private void btnMuokkaaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelu palvelu = (Palvelu)dgvPalvelut.SelectedRows[0].DataBoundItem;

            Palvelunmuokkaus p = new Palvelunmuokkaus(this, palvelu);
            p.Show();
        }

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            Palvelunmuokkaus p = new Palvelunmuokkaus(this);
            p.Show();
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
            else
            {
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;
            dgvPalvelut.DataSource = null;
            if (column.Equals("Nimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderBy(x => x.Nimi).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderByDescending(x => x.Nimi).ToList();
                }
            }
            else if (column.Equals("Palvelu_id"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderBy(x => x.Palvelu_id).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderByDescending(x => x.Palvelu_id).ToList();
                }
            }
            else if (column.Equals("Toimintaalue"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderBy(x => x.Toimintaalue.Nimi).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderByDescending(x => x.Toimintaalue.Nimi).ToList();
                }
            }
            else if (column.Equals("Hinta"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderBy(x => x.Hinta).ToList();
                }
                else
                {
                    dgvPalvelut.DataSource = this.p.Palvelut.OrderByDescending(x => x.Hinta).ToList();
                }
            }
            else
            {
                dgvPalvelut.DataSource = this.p.Palvelut;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
    }
}
