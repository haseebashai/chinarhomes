using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chinarhomes
{
    public partial class customers : Form
    {

        DBConnect obj = new DBConnect();
        String email;
        BindingSource bsource;
      
        MySqlDataReader dr;
       
        DataTable dt1;

        public customers()
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
            loading.Visible = false;
            formlbl.Text="Customers";
            formlbl.BringToFront();
            customerdataview.DataSource = bsource;
            customerdataview.Columns["email"].Visible = false;
            customerdataview.Columns["password"].Visible = false;
            customerdataview.Columns["lastvisit"].Visible = false;
            customerdataview.Columns["subscribed"].Visible = false;
            customerdataview.Columns["verified"].Visible = false;
            countlbl.Text = "Total Registered Customers: " + count;
            cpnl.Visible = true;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readcustomers();
        }

        string count;
        private void readcustomers()
        {
            try
            {
                dr = obj.Query("select * from customer");
                dt1 = new DataTable();
                dt1.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt1;

                dr = obj.Query("select count(*) from customer");
                dr.Read();
                count = dr[0].ToString();
                obj.closeConnection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
            dialogcontainer dg = new dialogcontainer();

            mail ml = new mail(emaillbl.Text);
            ml.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(ml);
            dg.Size = new Size(638, 550);
            dg.lbl.Text = "Send Mail";

            dg.Show();
            ml.Show();
        }

        string intp,wp;
        List<string> ip = new List<string>();
        List<string> wip = new List<string>();
      
        private void readdetails()
        {
            try
            {
                dr = obj.Query("select distinct propertyid from interested where email='" + email + "'");
                while (dr.Read())
                {
                    intp += dr[0].ToString();
                    intp += "\r\n";
                }
                obj.closeConnection();
           
          
                dr = obj.Query("select distinct propertyid from wishlist where email='" + email+"'");
                while (dr.Read())
                {
                    wp += dr[0].ToString();
                    wp += "\r\n";
                }
                obj.closeConnection();
           

            if (intp!=null)
            {

                string[] p = intp.Split('\n');
                foreach (string pro in p)
                {
                    dr = obj.Query("select propertyid,location, price from properties where propertyid='" + pro + "'");
                    while (dr.Read())
                    {
                        ip.Add("ID: " + dr[0].ToString() + "\r\n" + "Location: " + dr[1].ToString() + "\r\n" + "Price: " + dr[2].ToString());

                    }
                    obj.closeConnection();
                }
                }
           


            if (wp!=null)
            {
                string[] p1 = wp.Split('\n');
                foreach (string pro in p1)
                {
                    dr = obj.Query("select propertyid,location, price from properties where propertyid='" + pro + "'");
                    while (dr.Read())
                    {
                        wip.Add("ID: " + dr[0].ToString() + "\r\n" + "Location: " + dr[1].ToString() + "\r\n" + "Price: " + dr[2].ToString());


                    }
                    obj.closeConnection();
                }
            }

                intp = "";
                wp = "";
            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message, "Error!");
            }

        }

       
        private void customerdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ppnl.Visible = false;
            dpnl.Visible = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerdataview.Rows[e.RowIndex];
                email = row.Cells["email"].Value.ToString();
                emaillbl.Text = row.Cells["mail"].Value.ToString();
                namelbl.Text = row.Cells["name"].Value.ToString();
                contactlbl.Text = row.Cells["contact"].Value.ToString();
               
                loadinglbl.Visible = false;
                proploading.Visible = false;
                loadbtn.Visible = true;
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            ip.Clear();
            wip.Clear();
            iflow.Controls.Clear();
            wflow.Controls.Clear();
            customerdataview.Enabled = false;
            loadbtn.Visible = false;
            loadinglbl.Visible = true;
            proploading.Visible = true;
            BackgroundWorker details = new BackgroundWorker();
            details.RunWorkerCompleted += Details_RunWorkerCompleted;
            details.DoWork += Details_DoWork;
            details.RunWorkerAsync();
        }

        private void Details_DoWork(object sender, DoWorkEventArgs e)
        {
            readdetails();
        }

        private void Details_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            loadinglbl.Visible = false;
            proploading.Visible = false;
          
                ilbl.Text = namelbl.Text + " is interested in:";
                wlbl.Text = "and has wishlisted these properties:";


                foreach (string d in ip)
                {
                   
                    TextBox t = new TextBox()
                    {
                        Text = d,
                        ReadOnly = true,
                        BackColor = Color.White,
                        Multiline = true,
                        Size = new Size(200, 40),
                        BorderStyle = BorderStyle.None,

                    };
                    iflow.Controls.Add(t);
                    iflow.AutoScroll = true;
                }


                foreach (string d in wip)
                {
                    
                    TextBox t = new TextBox()
                    {
                        Text = d,
                        ReadOnly = true,
                        BackColor = Color.White,
                        Multiline = true,
                        Size = new Size(200, 40),
                        BorderStyle = BorderStyle.None,

                    };
                    wflow.Controls.Add(t);
                    wflow.AutoScroll = true;
                }


            

            dpnl.Visible = true;
                ppnl.Visible = true;
                customerdataview.Enabled = true;
            
            
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt1);
            dv.RowFilter = string.Format("mail LIKE '%{0}%'", emailtxt.Text);
            customerdataview.DataSource = dv;
        }




        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt1);
            dv.RowFilter = string.Format("name LIKE '%{0}%'", usertxt.Text);
            customerdataview.DataSource = dv;
        }

    }
}
