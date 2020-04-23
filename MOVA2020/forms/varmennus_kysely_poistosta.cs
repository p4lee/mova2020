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
    public partial class varmennus_kysely_poistosta : Form
    {
        Primary p;
        Mokki m;
        public varmennus_kysely_poistosta(Primary pr, Mokki mo)
        {
            InitializeComponent();
            this.m = mo;
            this.p = pr;
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            //sulkee ikkunan Peruuta-nappia painaessa
            this.Close();
        }

        private void btnKylla_Click(object sender, EventArgs e)
        {
            //poistaa valitun kohteen tietokannasta/dgvMokista
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$mokki_id", m.Mokki_id);
            string query = "DELETE FROM mokki WHERE mokki_id = $mokki_id";
            this.p.Db.DMquery(query, pairs);
            this.p.paivita();
            this.Close();
        }
    }
}
