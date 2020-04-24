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
    public partial class Varauksenperuminen : Form
    {
        public Varauksenperuminen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult poisto = MessageBox.Show("Oletko varma, että haluat poistaa varauksen?", "Poista varaus" ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (poisto == DialogResult.Yes) 
            {
            
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
