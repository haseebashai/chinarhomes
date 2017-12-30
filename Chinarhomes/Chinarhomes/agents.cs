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
    public partial class agents : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt;
        BindingSource bsource;

        public agents()
        {
            InitializeComponent();
            loading.Visible = true;
            formlbl.Visible = true;
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();


        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            try
            {
                //if (Application.OpenForms.OfType<agents>().Count() == 1)
                //{
                agentdataview.DataSource = bsource;
                agentdataview.Columns["mail"].Visible = false;
                agentdataview.Columns["password"].Visible = false;
                agentdataview.Columns["admin"].Visible = false;
                agentdataview.Columns["sid"].Visible = false;
                loading.Visible = false;
                formlbl.Text = "Agents";
                formlbl.BringToFront();
                apnl.Visible = true;
                // }
            }
            catch { }

        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {

            readagents();
            
        }

        private void readagents()
        {
            try
            {
                dr = obj.Query("select * from staff");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
            }
            catch { }
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

            StringBuilder email = new StringBuilder(mailtxt.Text);
            email.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder name = new StringBuilder(nametxt.Text);
            name.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder user = new StringBuilder(usertxt.Text);
            user.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder add = new StringBuilder(addtxt.Text);
            add.Replace(@"\", @"\\").Replace("'", "\\'");

            int admin;
            string encmail, encpassword;

            if (ayes.Checked)
                admin = 1;
            else
                admin = 0;
            try
            {
                if (update == false)
                {

                    encmail = md5hash(mailtxt.Text);
                    encpassword = md5hash(pwdtxt.Text);

                    if (ayes.Checked == false && ano.Checked == false)
                    {
                        MessageBox.Show("Please select if admin or not.", "Select Option");
                    }
                    else if (mailtxt.Text == "" || nametxt.Text == "" || usertxt.Text == "" || contacttxt.Text == "" || pwdtxt.Text == "" || addtxt.Text == "")
                    {
                        MessageBox.Show("Please enter all details.", "Error!");
                    }
                    else
                    {
                        Cursor = Cursors.WaitCursor;
                        if (errlbl.Visible == false)
                        {
                            string cmd = "INSERT INTO `staff` (`email`, `mail`, `name`, `contact`, `password`, `gender`, `admin`,`username`,`address`) VALUES ('" + email + "', '" + encmail + "', '" + name + "', '" + contacttxt.Text + "', '" + encpassword + "', '" + genderbox.Text + "', '" + admin + "','" + user + "','" + add + "')";
                            obj.nonQuery(cmd);
                            obj.closeConnection();

                            MessageBox.Show("Agent added Successfully.", "Success!");
                            readagents();
                            agentdataview.DataSource = bsource;
                            agentdataview.Columns["mail"].Visible = false;
                            agentdataview.Columns["password"].Visible = false;
                            agentdataview.Columns["admin"].Visible = false;
                            agentdataview.Columns["sid"].Visible = false;
                            Cursor = Cursors.Arrow;
                        }
                    }
                }
                else
                {
                    if (errlbl.Visible == false)
                    {
                        Cursor = Cursors.WaitCursor;
                        encmail = md5hash(mailtxt.Text);
                        string cmd = "update staff set `email`='" + email + "',`mail`='" + encmail + "', `name`='" + name + "', `contact`='" + contacttxt.Text + "', `gender`='" + genderbox.Text + "', `admin`='" + admin + "',`username`='" + user + "',`address`='" + add + "' where mail='" + mail + "'";
                        obj.nonQuery(cmd);
                        obj.closeConnection();

                        MessageBox.Show("Agent updated Successfully.", "Success!");
                        readagents();
                        agentdataview.DataSource = bsource;
                        agentdataview.Columns["mail"].Visible = false;
                        agentdataview.Columns["password"].Visible = false;
                        agentdataview.Columns["admin"].Visible = false;
                        agentdataview.Columns["sid"].Visible = false;
                        Cursor = Cursors.Arrow;
                    }
                }
            }catch(Exception ex)
            {
                Cursor = Cursors.Arrow;
                MessageBox.Show(ex.Message);
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.agentdataview.Rows[e.RowIndex];
                    mail = row.Cells["mail"].Value.ToString();
                    update = true;
                    mailtxt.Text = row.Cells["email"].Value.ToString();
                    nametxt.Text = row.Cells["name"].Value.ToString();
                    usertxt.Text = row.Cells["username"].Value.ToString();
                    addtxt.Text = row.Cells["address"].Value.ToString();
                    pwdtxt.Enabled = false;
                    contacttxt.Text = row.Cells["contact"].Value.ToString();
                    string admin = row.Cells["admin"].Value.ToString();
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
                        genderbox.SelectedIndex = 0;
                    }
                    else
                    {
                        genderbox.SelectedIndex = 1;
                    }
                    addbtn.Text = "Update";
                    addnewbtn.Visible = true;
                }
            }catch { }
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            update = false;
            nametxt.Text = "";
            mailtxt.Text = "";
            usertxt.Text = "";
            contacttxt.Text = "";
            pwdtxt.Text="";
            addtxt.Text = "";
            ayes.Checked = false;
            ano.Checked = false;
            addbtn.Text = "Add Agent";
            addnewbtn.Visible = false;
            pwdtxt.Enabled = true;
            errlbl.Visible = false;

        }

        private void contacttxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(contacttxt.Text, @"^([0-9]+)$") && contacttxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                contacttxt.Focus();

            }
        }

        private void canbtn_Click(object sender, EventArgs e)
        {

            update = false;
            nametxt.Text = "";
            mailtxt.Text = "";
            usertxt.Text = "";
            contacttxt.Text = "";
            pwdtxt.Text = "";
            addtxt.Text = "";
            ayes.Checked = false;
            ano.Checked = false;
            addbtn.Text = "Add Agent";
            addnewbtn.Visible = false;
            pwdtxt.Enabled = true;
            errlbl.Visible = false;
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            errlbl.Visible = false;
            BackgroundWorker username = new BackgroundWorker();
            username.DoWork += Username_DoWork;
            username.RunWorkerCompleted += Username_RunWorkerCompleted;
            username.RunWorkerAsync(usertxt.Text);
        }

        private void Username_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (success)
                {
                    errlbl.Visible = true;

                }
                else if (success == false)
                {
                    errlbl.Visible = false;
                }
            }catch { }
        }

        bool success = false;
        private void Username_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string usertxt = (string)e.Argument;
           
                int i = 0;
                i = obj.Count("Select Count(sid) from staff where username='" + usertxt+ "';");
              
                if (i == 1)
                {
                    success = true;
                }
                else
                    success = false;
               
               
            }catch { success = false; }
        }
    }
}
