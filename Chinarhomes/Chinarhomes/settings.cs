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
using System.Text.RegularExpressions;

namespace Chinarhomes
{
    public partial class settings : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        string mail;

        public settings()
        {
            InitializeComponent();
            loading.Visible = true;
            loadinglbl.Visible = true;
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();

        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nametxt.Text = name;
            mailtxt.Text = vmail;
            contacttxt.Text = con;
            addtxt.Text = add;
            loading.Visible = false;
            loadinglbl.Visible = false;
            spnl.Visible = true;
        }
        string name, vmail, con, add;
        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dr = obj.Query("select * from staff where username='" + userinfo.username + "'");
                dr.Read();
                name = dr["name"].ToString();
                vmail = dr["email"].ToString();
                con = dr["contact"].ToString();
                add = dr["address"].ToString();
                mail = dr["mail"].ToString();
                obj.closeConnection();
            }catch
            {

            }
        }

       
        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            contacttxt.MaxLength = 10;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string encmail = md5hash(mailtxt.Text);
                Cursor = Cursors.WaitCursor;
                if (pwdtxt.Text == "" && cpwdtxt.Text == "")
                {

                    StringBuilder trumail = new StringBuilder(mailtxt.Text);
                    mail.Replace(@"\", @"\\").Replace("'", "\\'");
                    StringBuilder name = new StringBuilder(nametxt.Text);
                    name.Replace(@"\", @"\\").Replace("'", "\\'");
                    StringBuilder add = new StringBuilder(addtxt.Text);
                    add.Replace(@"\", @"\\").Replace("'", "\\'");


                    errorlbl.Visible = false;
                    string cmd = "update staff set `email`='" + trumail + "',`mail`='" + encmail + "', `name`='" + name + "', `contact`='" + contacttxt.Text + "',`address`='" + add + "' where mail='" + mail + "'";
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                    MessageBox.Show("Successfully Updated.", "Success!");
                }
                else if (pwdtxt.Text != "" || cpwdtxt.Text != "")
                {
                    if (pwdtxt.Text == cpwdtxt.Text)
                    {
                        string encpwd = md5hash(pwdtxt.Text);
                        StringBuilder trumail = new StringBuilder(mailtxt.Text);
                        mail.Replace(@"\", @"\\").Replace("'", "\\'");
                        StringBuilder name = new StringBuilder(nametxt.Text);
                        name.Replace(@"\", @"\\").Replace("'", "\\'");
                        StringBuilder add = new StringBuilder(addtxt.Text);
                        add.Replace(@"\", @"\\").Replace("'", "\\'");


                        errorlbl.Visible = false;
                        string cmd = "update staff set `email`='" + trumail + "',`mail`='" + encmail + "',`password`='" + encpwd + "', `name`='" + name + "', `contact`='" + contacttxt.Text + "',`address`='" + add + "' where mail='" + mail + "'";
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully Updated.", "Success!");

                    }

                    else
                    {
                        errorlbl.Visible = true;
                    }
                }
                Cursor = Cursors.Arrow;
            }
            catch
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void contacttxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(contacttxt.Text, @"^([0-9]+)$") && contacttxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
               contacttxt.Focus();

            }
        }
    }
}
