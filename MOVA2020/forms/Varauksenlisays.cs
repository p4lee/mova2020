using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVA2020.forms
{
    public partial class Varauksenlisays : Form
    {
        private Primary lomake;
        public Varauksenlisays(Primary lomake)
        {
            this.lomake = lomake;
            InitializeComponent();
            this.btvaraus.Text = "Tee varaus";
        }

        private void btvaraus_Click(object sender, EventArgs e)
        {
            string query;
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$asiakas", this.lomake.Asiakkaat[this.CBAsiakas.SelectedIndex].Asiakas_id);
            pairs.Add("$mokki", this.lomake.Mokit[this.CBMokki.SelectedIndex].Mokki_id);
            pairs.Add("$varattu_pvm", DTPvarauspv.Value);
            pairs.Add("$vahvistus_pvm", DTPvarauspv.Value);
            pairs.Add("$varattu_alkupvm", DTPVarausalku.Value);
            pairs.Add("$varattu_loppupvm",DTPVarausloppu.Value);


            query = "INSERT INTO varaus(varaus_id, mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) VALUES($varaus_id, $mokki_id, $varattu_pvm, $vahvistus_pvm, $varaus_alkupvm, $varaus_loppupvm)";

            this.lomake.Db.DMquery(query, pairs);
            this.lomake.paivita();
            this.Close();

        }

        
    }
}
