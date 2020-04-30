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
using MOVA2020.objs;
namespace MOVA2020.forms
{
    public partial class Varausmuokkaus : Form
    {
        public Varausmuokkaus(Primary p, Varaus v)
        {
            InitializeComponent();
            this.btmuokkaa.Text = "Muokkaa varausta";
        }

        private void btmuokkaa_Click(object sender, EventArgs e)
        {

        }
    }
}
