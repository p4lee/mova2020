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
using MOVA2020;
namespace MOVA2020.forms
{
    public partial class Varauksentiedot : Form
    {
        private Varaus varaus;
        private Primary p;
        public Varauksentiedot(Primary p, Varaus v)
        {
            this.varaus = v;
            this.p = p;
            InitializeComponent();

            tbAsiakasnimi.Text = v.Asiakas.Etunimi + " " + v.Asiakas.Sukunimi;
            tbMokkinimi.Text = v.Mokki.Mokkinimi;
            dtpVarattupvm.Value = v.Varattu_pvm;
            calVaraus.SelectionStart = v.Varattu_alkupvm;
            calVaraus.SelectionEnd = v.Varattu_loppupvm;
            calVaraus.TodayDate = v.Varattu_alkupvm;
        }

        private void btnAsiakkaantiedot_Click(object sender, EventArgs e)
        {
            Asiakastiedot at = new Asiakastiedot(this.p, this.varaus.Asiakas);
            at.Show();
        }

        private void btnMokintiedot_Click(object sender, EventArgs e)
        {
            mokkitiedot mt = new mokkitiedot(this.p, this.varaus.Mokki);
            mt.Show();
        }
    }
}
