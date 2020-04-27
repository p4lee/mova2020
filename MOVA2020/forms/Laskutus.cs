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
    public partial class Laskutus : Form
    {
        private Lasku l;
        // UC ID 3.3 Laskutuksen koodi.
        
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // UC ID 3.3.2 Luo paneelista tulostettavan alueen.
            Panel grd = new Panel();
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        public Laskutus(Lasku l)
        {
            InitializeComponent();
            this.l = l;
        }
        
        private void bttulosta_Click(object sender, EventArgs e)
        {
            // UC ID 3.3.2 Nappi, jota painamalla lasku tulostetaan
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }
        
        private void btlaheta_Click(object sender, EventArgs e)
        {
            // UC ID 3.3.1 Nappi, jota painamalla lasku lähetetään asiakkaan sähköpostiin
        }

        private void btnVaraustiedot_Click(object sender, EventArgs e)
        {
            Varauksentiedot vt = new Varauksentiedot(l.Varaus);
            vt.Show();
        }
    }
}
