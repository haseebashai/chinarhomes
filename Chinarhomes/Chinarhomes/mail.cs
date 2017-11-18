using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Chinarhomes
{
    public partial class mail : Form
    {
        string sendername;
        public mail(string email)
        {
           
           
            InitializeComponent();
            if (email == "")
            {
                totxt.Text = "";
            }
            else
            {
                totxt.Text = email;
            }
        }

        private void sendmail()
        {
            Cursor = Cursors.WaitCursor;
            try
            {

                SmtpClient Smtpobj = new SmtpClient();
                Smtpobj.Host = "smtp.zoho.com";
                Smtpobj.Port = 587;
                Smtpobj.UseDefaultCredentials = false;
                Smtpobj.EnableSsl = true;
                Smtpobj.Credentials = new NetworkCredential(frombox.Text, pwdtxt.Text);
                Smtpobj.DeliveryMethod = SmtpDeliveryMethod.Network;


                MailMessage mail = new MailMessage(frombox.Text, totxt.Text);
                mail.From = new MailAddress(frombox.Text, sendername);
                mail.Subject = subtxt.Text;
                mail.Body = bodytxt.Text;

                Smtpobj.Send(mail);
                Cursor = Cursors.Arrow;

                MessageBox.Show("Mail Sent.");
                
              
            }

            catch (SmtpException ex)
            {
                Cursor = Cursors.Arrow;
                MessageBox.Show("Password incorrect.", "Error!");
                pwdtxt.Focus();
            }
            catch(Exception e)
            {
                Cursor = Cursors.Arrow;
                MessageBox.Show(e.Message);
            }

        }

        private void frombox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            switch (frombox.Text)
            {
                case "support@chinarhomes.com":
                    sendername = "Chinar Homes Support";
                    pwdpnl.Visible = true;
                    break;
                case "care@chinarhomes.com":
                    sendername = "Chinar Homes Customer Care";
                    pwdpnl.Visible = true;
                    break;
                default:
                    pwdpnl.Visible = false;
                    break;
            }
            pwdtxt.Text = "";
        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
            if (totxt.Text != "" && subtxt.Text != "" && bodytxt.Text != "" && pwdtxt.Text !="")
            {
                sendmail();
            }
            else
                MessageBox.Show("Please fill all details first.","Error!");
            totxt.Focus();
        }


        private void mail_Load(object sender, EventArgs e)
        {
            frombox.DisplayMember = "Text";
            var items = new[]
            {
                new {Text="support@chinarhomes.com"},
                new {Text="care@chinarhomes.com"}

            };
            frombox.DataSource = items;
            frombox.SelectedIndex = -1;
        }

        private void pwdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pwdtxt.Text == null||pwdtxt.Text=="")
                mailbtn.Visible = false;
            else
                mailbtn.Visible = true;
        }
    }
}
