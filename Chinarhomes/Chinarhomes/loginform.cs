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
                usernametxt.ForeColor = SystemColors.ActiveCaption ;
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            /*
                        if (usernametxt.Text.Contains("'") || pwdtxt.Text.Contains("'") || usernametxt.Text.Contains("\\") || pwdtxt.Text.Contains("\\"))
                        {

                            error.Text = "Username incorrect";
                            error.Visible = true;
                            usernametxt.Text = "";
                            pwdtxt.Text = "";
                        }
                        else if (usernametxt.Text != "" && pwdtxt.Text != "")
                        {
                            int i;
                            i = obj.Count("Select Count(*) from admin where username='" + usernametxt.Text + "';");
                            if (i == 1)
                            {
                                MySqlDataReader dr;
                                dr = obj.Query("Select * from admin where username='" + usernametxt.Text + "';");
                                dr.Read();
                                if (dr[4].Equals(pwdtxt.Text))
                                {
                                    userinfo.loggedin = true;
                                    userinfo.username = dr[0].ToString(); */

            mainform mf = new mainform(cn);
            //   mf.changelabel("Welcome User");
            //  mf.signout();

            this.Close();

            cn.mainpnl.Controls.Clear();
            mf.TopLevel = false;
            cn.mainpnl.Controls.Add(mf);

            mf.Show();

            /*     }
                 else
                 {
                     error.Text = "Please Enter Correct Password";
                     error.Visible = true;
                     usernametxt.Text = "";
                     pwdtxt.Text = "";

                 }
                 obj.closeConnection();
             }
             else
             {
                 error.Text = "Username does not exist";
                 error.Visible = true;
                 usernametxt.Text = "";
                 pwdtxt.Text = "";
             }

         }

             else
             {
                 error.Text = "Enter username and password";
                 error.Visible = true;
                 usernametxt.Text = "";
                 pwdtxt.Text = "";
             }
         }
        */
        }
    }
}
