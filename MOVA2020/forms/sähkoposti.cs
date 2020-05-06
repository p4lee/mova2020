using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;

namespace MOVA2020.forms
{
    public partial class sähkoposti : Form
    {
        private Attachment file;
        public sähkoposti(string filename)
        {
            InitializeComponent();
            this.file = new Attachment(filename);
        }

        private void btkirjaudu_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(tbosoite.Text);
                message.To.Add(new MailAddress("jonna.rasanen@edu.savonia.fi"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "This is a test message";
                message.Attachments.Add(file);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(tbosoite.Text, tbsalasana.Text);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}
