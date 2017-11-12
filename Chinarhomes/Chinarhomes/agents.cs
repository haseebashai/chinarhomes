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
    public partial class agents : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt;

        public agents()
        {
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


        private void agents_Load(object sender, EventArgs e)
        {

            genderbox.DisplayMember = "Text";
            var items = new[]
            {
                new {Text="Male"},
                new {Text="Female"}
            };
            genderbox.DataSource = items;

            dr = obj.Query("select * from staff");
            dt = new DataTable();
            dt.Load(dr);
            obj.closeConnection();
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            agentdataview.DataSource = bsource;
            agentdataview.Columns["mail"].Visible = false;
            agentdataview.Columns["password"].Visible = false;
        }

        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            contacttxt.MaxLength = 10;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int admin;
            string encmail, encpassword;

            if (ayes.Checked)
                admin = 1;
            else
                admin = 0;
            if (update == false)
            {
                encmail = md5hash(mailtxt.Text);
                encpassword = md5hash(pwdtxt.Text);
        
                if (ayes.Checked == false && ano.Checked == false)
                {
                    MessageBox.Show("Please select if admin or not.", "Select Option");
                }
                else if (mailtxt.Text == "" || nametxt.Text == "" || usertxt.Text == "" || contacttxt.Text == "" || pwdtxt.Text == "" || nametxt.Text == "")
                {
                    MessageBox.Show("Please enter all details.", "Error!");
                }
                else
                {
                    MessageBox.Show("new");
                    string cmd = "INSERT INTO `staff` (`email`, `mail`, `name`, `contact`, `password`, `gender`, `admin`,`username`) VALUES ('" + mailtxt.Text + "', '" + encmail + "', '" + nametxt.Text + "', '" + contacttxt.Text + "', '" + encpassword + "', '" + genderbox.Text + "', '" + admin + "','" + usertxt.Text + "')";
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("update");
                encmail = md5hash(mailtxt.Text);
                string cmd = "update staff set `email`='" + mailtxt.Text + "',`mail`='"+encmail+"', `name`='" + nametxt.Text + "', `contact`='" + contacttxt.Text + "', `gender`='" + genderbox.Text + "', `admin`='" + admin + "',`username`='" + usertxt.Text + "' where mail='"+mail+"'";
                obj.nonQuery(cmd);
                obj.closeConnection();
            }
        }
        private void ayes_CheckedChanged(object sender, EventArgs e)
        {
            if (ayes.Checked)
                ano.Checked = false;
        }

        private void ano_CheckedChanged(object sender, EventArgs e)
        {
            if (ano.Checked)
                ayes.Checked = false;
        }
        string mail;
        bool update = false;
        private void agentdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.agentdataview.Rows[e.RowIndex];
                mail = row.Cells["mail"].Value.ToString();
                update = true;
                mailtxt.Text= row.Cells["email"].Value.ToString();
                nametxt.Text = row.Cells["name"].Value.ToString();
                usertxt.Text = row.Cells["username"].Value.ToString();
                pwdtxt.Enabled = false;
                contacttxt.Text = row.Cells["contact"].Value.ToString();
                string admin= row.Cells["admin"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                if (admin == "1")
                {
                    ayes.Checked = true;
                    ano.Checked = false;
                }
                else
                {
                    ayes.Checked = false;
                    ano.Checked = true;
                }
                if (gender == "Male")
                {
                    genderbox.SelectedIndex=0;
                }
                else
                {
                    genderbox.SelectedIndex=1;
                }
                addbtn.Text = "Update";
                addnewbtn.Visible = true;
            }
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            update = false;
            nametxt.Text = "";
            mailtxt.Text = "";
            usertxt.Text = "";
            contacttxt.Text = "";
            pwdtxt.Text="";
            ayes.Checked = false;
            ano.Checked = false;
            addbtn.Text = "Add Agent";
            addnewbtn.Visible = false;
            pwdtxt.Enabled = true;

        }

        private void dpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
