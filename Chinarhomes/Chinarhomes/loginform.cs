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
    //    private mainform mf = null;

        public loginform(Form cncopy)
        {
         //   mf = mfcopy as mainform;
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
            usernametxt.Enabled = false;
            pwdtxt.Enabled = false;
            error.Visible = false;
            loginbtn.Enabled = false;
            forgotbtn.Enabled = false;
            loading.Visible = true;
            BackgroundWorker login = new BackgroundWorker();
            login.DoWork += Login_DoWork;
            login.RunWorkerCompleted += Login_RunWorkerCompleted;
            login.RunWorkerAsync();

           
        }


        private void Login_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                usernametxt.Enabled = true;
                pwdtxt.Enabled = true;
                loading.Visible = false;
                string result = e.Result.ToString();

                if (result == "404")
                {

                    error.Text = "Username incorrect";
                    error.Visible = true;
                    namelbl.Visible = true;
                    pwdlbl.Visible = true;
                    usernametxt.Text = "";
                    pwdtxt.Text = "";
                    usernametxt.Focus();
                }
                else if (result == "incorrect password")
                {

                    error.Text = "Please enter correct password";
                    error.Visible = true;
                    pwdtxt.Text = "";
                    pwdtxt.Focus();
                    namelbl.Visible = true;
                    pwdlbl.Visible = true;
                }
                else if (result == "Username")
                {

                    error.Text = "Username does not exist";
                    error.Visible = true;
                    usernametxt.Text = "";
                    pwdtxt.Text = "";
                    namelbl.Visible = true;
                    pwdlbl.Visible = true;
                    usernametxt.Focus();
                }
                else if (result == "enter details")
                {

                    error.Text = "Enter username and password";
                    error.Visible = true;
                    usernametxt.Text = "";
                    pwdtxt.Text = "";
                    namelbl.Visible = true;
                    pwdlbl.Visible = true;
                }
                else if (result == "connection")
                {
                    error.Text = "Please check your internet connection.";
                    error.Visible = true;
                }
                else if (result == "success")
                {
                    mainform mf = new mainform(cn);
                    mf.TopLevel = false;
                    cn.mainpnl.Controls.Clear();
                    if (usertype == "1")
                    {
                        userinfo.admin = true;

                    }
                    else if (usertype == "0")
                    {
                        userinfo.admin = false;

                    }



                    userinfo.loggedin = true;
                    userinfo.username = username;
                    userinfo.email = email;
                    userinfo.encmail = encmail;





                    cn.mainpnl.Controls.Add(mf);

                    this.Close();
                    mf.Show();
                    mf.changelabel(username);


                }
                loginbtn.Enabled = true;
                forgotbtn.Enabled = true;

            }catch { }
        }

        string usertype,username,email,encmail;

       

        private void forgotbtn_Click(object sender, EventArgs e)
        {
            dialogcontainer dg = new dialogcontainer();
            forgotpwd fgt = new forgotpwd(dg);
            fgt.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(fgt);
            dg.Size = new Size(470, 400);
            dg.lbl.Text = "Reset Password";
            dg.Show();
            fgt.Show();
            
           
        }

        private void Login_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string pwd = md5hash(pwdtxt.Text);

                if (usernametxt.Text.Contains("'") || pwdtxt.Text.Contains("'") || usernametxt.Text.Contains("\\") || pwdtxt.Text.Contains("\\"))
                {
                    e.Result = "404";
                    return;
                }
                else if (usernametxt.Text != "" && pwdtxt.Text != "")
                {
                   
                        int i;
                        i = obj.Count("Select Count(sid) from staff where username='" + usernametxt.Text + "';");
                        if (i == 1)
                        {

                            MySqlDataReader dr;
                            dr = obj.Query("Select username,password,admin,email,mail from staff where username='" + usernametxt.Text + "';");
                            dr.Read();
                            if (dr[1].Equals(pwd))
                            {
                                usertype = dr[2].ToString();
                                username = dr[0].ToString();
                                email = dr[3].ToString();
                                encmail = dr[4].ToString();
                                e.Result = "success";
                                obj.closeConnection();
                                return;
                            }
                            else
                            {
                                obj.closeConnection();
                                e.Result = "incorrect password";

                                return;

                            }



                        }
                        else
                        {
                            e.Result = "Username";
                            return;
                        }
                    
                    }

                else
                {
                    e.Result = "enter details";
                    return;
                }
            }
            catch
            {
                e.Result = "connection";
                return;
            }
        }
    }
}

