using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs;
using MOVA2020.objs.dbitems;

namespace MOVA2020.forms
{
    public partial class mokkimuokkaus : Form
    {
        public mokkimuokkaus()
        {
            this.Text = "Mökin lisäys";
            InitializeComponent();
        }
        public mokkimuokkaus(Mokki m)
        {
            this.Text = "Muokkaa mökkiä";
            InitializeComponent();
        }

        private void btnLisays_Click(object sender, EventArgs e)
        {

        }
    }
}
