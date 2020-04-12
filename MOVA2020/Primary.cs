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
namespace MOVA2020
{
    public partial class Primary : Form
    {
        private DBHandler db;
        public Primary()
        {
            this.db = new DBHandler();
            List<Mokki> mokit = new List<Mokki>();
            List<Object[]> test = this.db.SelectQuery("SELECT * FROM mokki");
            foreach(Object[] itemarr in test)
            {
                MessageBox.Show("asd");
                //Mokki m = new Mokki(itemarr[0], );
            }
            InitializeComponent();
        }
    }
}
