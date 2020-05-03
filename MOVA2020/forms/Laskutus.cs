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
        private Primary p;
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
        public Laskutus(Primary p, Lasku l)
        {
            InitializeComponent();
            this.p = p;
            this.l = l;

            if(this.l.Varaus.Vahvistus_pvm.Equals(DateTime.Parse("1970-01-01 00:00:00")))
            {
                btnVarmenna.Enabled = true;
            }
            TByht.Text = l.Summa.ToString();
            TBAsiakas.Text = l.Varaus.Asiakas.ToString();
            TBnum.Text = l.Lasku_id.ToString();
            TBerapvm.Text = l.Erapaiva.ToString("yyyy-MM-dd");
            TBpvm.Text = l.Varaus.Vahvistus_pvm.ToString("yyyy-MM-dd");
            string lisatiedot = l.Varaus.Mokki.Kuvaus + "\r\n" + l.Varaus.Mokki.Varustelu + "\r\n";
            string summat = l.Varaus.Varattu_alkupvm.ToString("yyyy-MM-dd")+" - "+l.Varaus.Varattu_loppupvm.ToString("yyyy-MM-dd")+ "\r\n";
            summat += (l.Varaus.Varattu_loppupvm - l.Varaus.Varattu_alkupvm).TotalDays.ToString() + " päivä(ä), " +
                l.Varaus.Mokki.Hinta * (l.Varaus.Varattu_loppupvm - l.Varaus.Varattu_alkupvm).TotalDays;

            foreach (KeyValuePair<int, int> item in l.Varaus.Varauksenpalvelut)
            {
                Palvelu pa = this.p.Palvelut.Find(i => i.Palvelu_id == item.Key);
                lisatiedot += "\r\n" + pa.Nimi + pa.Hinta.ToString() + " €/kpl\r\nx" + item.Value;
                summat += "\r\nx" + item.Value +" * " + pa.Hinta.ToString() + " = "+(item.Value * pa.Hinta);
            }
            TBlisatiedot.Text = lisatiedot;
            summat += "\r\nSumma (ilman ALV):" + l.SummaEiAlv;
            summat += "\r\nALV (24%):" + l.Alv;
            TBLaskutus.Text = summat;
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
            Varauksentiedot vt = new Varauksentiedot(p, l.Varaus);
            vt.Show();
        }

        private void btnVarmenna_Click(object sender, EventArgs e)
        {
            Varaus var = this.l.Varaus;
            DialogResult dr = MessageBox.Show("Onko kyseinen maksu suoritettu ?", "Maksun varmennus", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$vahvistus_pvm", DateTime.Now);
                pairs.Add("$varaus_id", var.Varaus_id);
                string query = "UPDATE varaus SET vahvistus_pvm=$vahvistus_pvm WHERE varaus_id=$varaus_id";
                this.p.Db.DMquery(query, pairs);
                MessageBox.Show("Maksu on merkattu suoritetuksi!", "Maksun varmennus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVarmenna.Enabled = false;
                this.p.paivita();
            }
        }

    }
}
