using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace Chinarhomes
{
    public partial class forgotpwd : Form
    {
        DBConnect obj = new DBConnect();

        private dialogcontainer dg = null;
        public forgotpwd(Form dgcopy)
        {
            dg = dgcopy as dialogcontainer;
            InitializeComponent();
        }

        public static string md5hash(string input)
        {

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + "Zohan123"));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        int numberOfPoints = 0;
        private void timer_Tick(object sender, EventArgs e)
        {

            int maxPoints = 5;             //loading sign on timer

            workinglbl.Visible = true;
            workinglbl.Text = "Working" + new string('.', numberOfPoints);
            numberOfPoints = (numberOfPoints + 1) % (maxPoints + 1);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                workinglbl.Visible = false;
                errlbl.Visible = false;
                object[] arg = { usrtxt.Text, emailtxt.Text };
                Cursor = Cursors.WaitCursor;
                int i = obj.Count("select Count(username) from staff where username='" + usrtxt.Text + "' && email='" + emailtxt.Text + "'");
                if (i == 1)
                {
                    Cursor = Cursors.Arrow;
                    DialogResult dgr = MessageBox.Show("Your password will be reset and a new password will be sent to your registred email id.\nUse that password to access your account and change the password afterwards.", "Confirm!", MessageBoxButtons.OKCancel);
                    if (dgr == DialogResult.OK)
                    {

                        workinglbl.Visible = true;


                       timer.Start();
                        loginbtn.Enabled = false;
                       BackgroundWorker pwd = new BackgroundWorker();
                       pwd.DoWork += Pwd_DoWork;
                       pwd.RunWorkerCompleted += Pwd_RunWorkerCompleted;
                       pwd.RunWorkerAsync(arg);
                    }

                }
                else
                {
                    errlbl.Visible = true;

                }
                Cursor = Cursors.Arrow;


            }
            catch(Exception ex)
            {
                workinglbl.Visible = false;
                Cursor = Cursors.Arrow;
                loginbtn.Enabled = true;
                MessageBox.Show("Please check your internet connection and try again.","Error!");
            }
        }

        private void Pwd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = (string)e.Result;
            if (result == "success")
            {
                MessageBox.Show("Password reset successful, please check your registred email for instructions.", "Password Reset");
                System.Threading.Thread.Sleep(500);
                this.Close();
                dg.Close();
            }else if (result == "fail")
            {
                MessageBox.Show("Something happened, please try again","Error!");
                
            }
            timer.Stop();
            workinglbl.Visible = false;
            loginbtn.Enabled = true;

        }

        private void Pwd_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                object[] arg = (object[])e.Argument;
                string user = (string)arg[0];
                string email = (string)arg[1];

                
                        string newpwd = RandomString(5);
                        string pwd = md5hash(newpwd);
                        string cmd = "update staff set password='" + pwd + "' where username='" + user + "'&& email='" + email + "'";
                        obj.nonQuery(cmd);
                        SmtpClient Smtpobj = new SmtpClient();
                        Smtpobj.Host = "smtp.zoho.com";
                        Smtpobj.Port = 587;
                        Smtpobj.UseDefaultCredentials = false;
                        Smtpobj.EnableSsl = true;
                        Smtpobj.Credentials = new NetworkCredential("support@chinarhomes.com", "Chinar@123chinar");
                        Smtpobj.DeliveryMethod = SmtpDeliveryMethod.Network;


                        MailMessage mail = new MailMessage("support@chinarhomes.com", email);
                        mail.From = new MailAddress("support@chinarhomes.com", "Chinar Homes Password Recovery");
                        mail.IsBodyHtml = true;
                        mail.Subject = "Request for Password Recovery";
                        mail.Body = "Dear " + user + ",<p>Your Request for password reset was successfully processed and a new password has been generated for your account.<p><p>Your new password is: <b><font size='6'> " + newpwd + " </ font ></b><p><p>Please use this new password " +
                            "to access your account and dont forget to change your password from User Profile settings.<p><p><p><p>Chinar Homes Support.";

                        Smtpobj.Send(mail);
                        
                        
                        e.Result = "success";
                   
            }catch
            {
                e.Result = "fail";
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void forgotpwd_Load(object sender, EventArgs e)
        {
            usrtxt.Focus();
        }
    }
}
