using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020;
using MOVA2020.objs.dbitems;
namespace MOVA2020.forms
{
    public partial class Mokkitiedot : Form
    {
        private Primary p;
        private Mokki m;
        public Mokkitiedot(Primary p, Mokki m)
        {
            InitializeComponent();
            this.p = p;
            this.m = m;
            tbNimi.Text = m.Mokkinimi;
            tbToimintaalue.Text = m.Toimintaalue.Nimi;

            tbKatuosoite.Text = m.Katuosoite;
            tbPostinumero.Text = m.Posti.Postinro;
            tbPaikkakunta.Text = m.Posti.Toimipaikka;

            tbHinta.Text = m.Hinta.ToString();
            nmrHenkilomaara.Value = m.Henkilomaara;

            rtbVarustelu.Text = m.Varustelu;
            rtbKuvaus.Text = m.Kuvaus;

            this.paivita();
            
        }
        public void paivita()
        {
            this.p.paivita();
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = this.Varaukset;
        }
        public List<Varaus> Varaukset => p.Varaukset.FindAll(i => i.Mokki.Mokki_id == this.m.Mokki_id);

        private void dgvVaraukset_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
            if (column.Equals("Varattu_pvm"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderBy(x => x.Varattu_pvm).ToList();
                }
                else
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderByDescending(x => x.Varattu_pvm).ToList();
                }
            } else if(column.Equals("Vahvistus_pvm"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderBy(x => x.Vahvistus_pvm).ToList();
                }
                else
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderByDescending(x => x.Vahvistus_pvm).ToList();
                }
            }
            else if (column.Equals("Varattu_alkupvm"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderBy(x => x.Varaus_alkupvm).ToList();
                }
                else
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderByDescending(x => x.Varaus_alkupvm).ToList();
                }
            }
            else if (column.Equals("Varattu_loppupvm"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderBy(x => x.Varaus_loppupvm).ToList();
                }
                else
                {
                    dgvVaraukset.DataSource = null;
                    dgvVaraukset.DataSource = this.Varaukset.OrderByDescending(x => x.Varaus_loppupvm).ToList();
                }
            }
            
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
    }
}
