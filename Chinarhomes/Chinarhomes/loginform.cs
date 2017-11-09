using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Chinarhomes
{
    public partial class loginform : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;

        private container cn = null;
        private mainform mf = null;

        public loginform(Form cncopy, Form mfcopy)
        {
            mf = mfcopy as mainform;
            cn = cncopy as container;
            InitializeComponent();
        }

        private void usrtxt_Enter(object sender, EventArgs e)
        {
            namelbl.Visible = true;
            if (usernametxt.Text == "Username" || usernametxt.Text == "")
                usernametxt.Text = "";
            usernametxt.ForeColor = Color.Black;
        }

        private void usernametxt_Leave(object sender, EventArgs e)
        {
            if (usernametxt.Text == "" || usernametxt.Text == " ")
            {
                usernametxt.Text = "Username";
                namelbl.Visible = false;
                usernametxt.ForeColor = SystemColors.ActiveCaption;
            }
            else { namelbl.Visible = true; }
        }

        private void pwdtxt_Enter(object sender, EventArgs e)
        {
            pwdlbl.Visible = true;
            if (pwdtxt.Text == "Password")
                pwdtxt.Text = "";
            pwdtxt.ForeColor = Color.Black;
            pwdtxt.PasswordChar = '*';
        }

        private void pwdtxt_Leave(object sender, EventArgs e)
        {
            if (pwdtxt.Text == "")
            {
                pwdtxt.Text = "Password";
                pwdtxt.PasswordChar = '\0';
                pwdlbl.Visible = false;
                pwdtxt.ForeColor = SystemColors.ActiveCaption;
            }
            else
            {
                pwdlbl.Visible = true;
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string pwd = md5hash(pwdtxt.Text);

            if (usernametxt.Text.Contains("'") || pwdtxt.Text.Contains("'") || usernametxt.Text.Contains("\\") || pwdtxt.Text.Contains("\\"))
            {

                error.Text = "Username incorrect";
                error.Visible = true;
                namelbl.Visible = true;
                pwdlbl.Visible = true;
                usernametxt.Text = "";
                pwdtxt.Text = "";

            }
            else if (usernametxt.Text != "" && pwdtxt.Text != "")
            {
                int i;
                i = obj.Count("Select Count(sid) from staff where username='" + usernametxt.Text + "';");
                if (i == 1)
                {
                    MySqlDataReader dr;
                    dr = obj.Query("Select username,password,admin from staff where username='" + usernametxt.Text + "';");
                    dr.Read();
                    if (dr[1].Equals(pwd))
                    {
                        userinfo.loggedin = true;
                        userinfo.username = dr[0].ToString();

                        mainform mf = new mainform(cn);
                        mf.changelabel(dr[0].ToString());

                        this.Close();
                        if (dr[2].ToString() == "1")
                        {
                            MessageBox.Show("admin");
                        }
                        else
                        {
                            MessageBox.Show("agent");
                        }
                        cn.mainpnl.Controls.Clear();
                        mf.TopLevel = false;
                        cn.mainpnl.Controls.Add(mf);

                        mf.Show();

                    }
                    else
                    {
                        error.Text = "Please enter correct password";
                        error.Visible = true;
                        usernametxt.Text = "";
                        pwdtxt.Text = "";
                        namelbl.Visible = true;
                        pwdlbl.Visible = true;

                    }


                    obj.closeConnection();
                }
                else
                {
                    error.Text = "Username does not exist";
                    error.Visible = true;
                    usernametxt.Text = "";
                    pwdtxt.Text = "";
                    namelbl.Visible = true;
                    pwdlbl.Visible = true;
                }



            }

            else
            {
                error.Text = "Enter username and password";
                error.Visible = true;
                usernametxt.Text = "";
                pwdtxt.Text = "";
                namelbl.Visible = true;
                pwdlbl.Visible = true;
            }
        }
    }
}

