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
namespace MOVA2020
{
    public partial class Primary : Form
    {
        private DBHandler db;
        public Primary()
        {
            this.db = new DBHandler();
            List<Object[]> test = this.db.SelectQuery("SELECT * FROM asiakas");
            foreach(Object[] itemarr in test)
            {
                foreach(Object item in itemarr)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            InitializeComponent();
        }
    }
}
