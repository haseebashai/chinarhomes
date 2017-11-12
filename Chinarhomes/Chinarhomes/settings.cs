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
        }

        private void settings_Load(object sender, EventArgs e)
        {
            dr = obj.Query("select * from staff where username='"+userinfo.username+"'");
            dr.Read();
            nametxt.Text = dr["name"].ToString();
            mailtxt.Text = dr["email"].ToString();
            usertxt.Text = dr["username"].ToString();
            contacttxt.Text = dr["contact"].ToString();
            mail = dr["mail"].ToString();
            obj.closeConnection();
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
            string encmail = md5hash(mailtxt.Text);
            string encpwd = md5hash(pwdtxt.Text);
            if (pwdtxt.Text == cpwdtxt.Text)
            {
                errorlbl.Visible = false;
                string cmd = "update staff set `email`='" + mailtxt.Text + "',`mail`='" + encmail + "',`password`='"+encpwd+"', `name`='" + nametxt.Text + "', `contact`='" + contacttxt.Text + "',`username`='" + usertxt.Text + "' where mail='" + mail + "'";
                obj.nonQuery(cmd);
                obj.closeConnection();
            }else
            {
                errorlbl.Visible = true;
            }
          
        }
    }
}
