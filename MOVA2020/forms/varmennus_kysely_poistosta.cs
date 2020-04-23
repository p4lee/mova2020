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
    public partial class varmennus_kysely_poistosta : Form
    {
        public varmennus_kysely_poistosta()
        {
            InitializeComponent();
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            //sulkee ikkunan Peruuta-nappia painaessa
            this.Close();
        }

        private void btnKylla_Click(object sender, EventArgs e)
        {
            //KESKEN
            //poistaa valitun kohteen tietokannasta/dgvMokista

            this.Close();
        }
    }
}
