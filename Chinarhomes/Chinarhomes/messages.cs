using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace Chinarhomes
{
    public partial class messages : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt,dt1,dt2;
       
        BindingSource bsource, bsource2;

        public messages()
        {
            InitializeComponent();
            formlbl.Visible = true;
            loading.Visible = true;
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();



        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formlbl.Text = "Messages";
            formlbl.BringToFront();
            loading.Visible = false;
            messagesdataview.DataSource = bsource;
            messagesdataview.Columns["sender"].Visible = false;
            sentdataview.DataSource = bsource2;
            msgpnl.Visible = true;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readmsgs();
           

        }

        private void readstaff()
        {

            dr = obj.Query("select distinct username from staff where username !='"+userinfo.username+"'");

            dt1 = new DataTable();
            dt1.Columns.Add("username", typeof(String));
            dt1.Load(dr);
            obj.closeConnection();

        }


        private void readmsgs()
        {
            try
            {
                dr = obj.Query("SELECT username, message,sender from messages where recipient ='"+userinfo.username+"'");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;

                dr = obj.Query("SELECT message,recipient from messages where sender ='" + userinfo.email + "'");
                dt2 = new DataTable();
                dt2.Load(dr);
                obj.closeConnection();
                bsource2 = new BindingSource();
                bsource2.DataSource = dt2;


            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message, "Error!");
            }
        }


        private void messagesdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = messagesdataview.Rows[e.RowIndex];
               // midlbl.Text = row.Cells["messageid"].Value.ToString();
               fromlbl.Text= row.Cells["username"].Value.ToString();
                emaillbl.Text = row.Cells["sender"].Value.ToString();
               // sublbl.Text = row.Cells["subject"].Value.ToString();
                msgbodytxt.Text = row.Cells["message"].Value.ToString();
                viewpnl.Visible = true;



            }
        }

        BackgroundWorker sendmsg = new BackgroundWorker();
       


        private void rpbtn_Click(object sender, EventArgs e)
        {
            rpbtn.Enabled = false;
            sendmsg.DoWork += Sendmsg_DoWork;
            sendmsg.RunWorkerCompleted += Sendmsg_RunWorkerCompleted;
            sendmsg.RunWorkerAsync(fromlbl.Text);

        }

        private void Sendmsg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            
            stafflist.DisplayMember = "username";
            stafflist.DataSource = dt1;
            
            stafflist.Text = fromlbl.Text;
            newpnl.Visible = true;
            mpnl.Visible = true;
            rpbtn.Enabled = true;
            
        }

        private void Sendmsg_DoWork(object sender, DoWorkEventArgs e)
        {
            readstaff();
        }

        private void stafflist_SelectedIndexChanged(object sender, EventArgs e)
        {
            totxt.Text = stafflist.Text;
        }

        private void newmbtn_Click(object sender, EventArgs e)
        {
            sendmsg.DoWork += Sendmsg_DoWork;
            sendmsg.RunWorkerCompleted += Sendmsg_RunWorkerCompleted;
            sendmsg.RunWorkerAsync();
        }
        private void canbtn_Click(object sender, EventArgs e)
        {
            newpnl.Visible = false;
            msgtxt.Text = "";
        }

        private void rbtn_Click(object sender, EventArgs e)
        {

            if (msgtxt.Text != "")
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    StringBuilder msg = new StringBuilder(msgtxt.Text);
                    msg.Replace(@"\", @"\\").Replace("'", "\\'");

                    string cmd = "insert into messages (`sender`,`message`,`username`,`recipient`)values('" + userinfo.email + "','" + msg + "','" + userinfo.username + "','" + totxt.Text + "')";
                    obj.nonQuery(cmd);
                    MessageBox.Show("Message sent.", "Success!");
                    Pageload_DoWork(null,null);
                    Pageload_RunWorkerCompleted(null,null);
                    Cursor = Cursors.Arrow;
                }
                catch
                {
                    Cursor = Cursors.Arrow;
                }
            }else
            {
                MessageBox.Show("Please write a message first.", "Error!");
                msgtxt.Focus();
            }
        }

    }
}
