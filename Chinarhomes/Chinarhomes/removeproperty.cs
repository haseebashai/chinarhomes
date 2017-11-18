using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using System.Security;

namespace Chinarhomes
{
    public partial class removeproperty : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt;
        List<string> pathurl = new List<string>();
        int i = 0;
        int total;
        PictureBox pb;

        private dialogcontainer dg = null;
        public removeproperty(Form dgcopy)
        {
            dg = dgcopy as dialogcontainer;
            InitializeComponent();
            loading.Visible = true;
            formlbl.Visible = true;
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.WorkerSupportsCancellation = true;
            pageload.RunWorkerAsync();
        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formlbl.Visible = false;
            loading.Visible = false;
            proplist.DisplayMember = "location";
            proplist.DataSource = dt;          
            proppnl.Visible = true;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readproperties();
            
        }

        private void readproperties()
        {
            dr = obj.Query("select location from properties");

            dt = new DataTable();
            dt.Columns.Add("location", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            

        }
        BackgroundWorker bg;
        string pid, loc, name, price, encemail,trueemail,ver;

        private void rmpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgr = MessageBox.Show("Are you sure you want to remove this property?\n" + loc, "Confirm!", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    string cmd = "delete from pictures where propertyid='"+pid+"'";
                    obj.nonQuery(cmd);
                    string cmd1 = "delete from properties where propertyid='" + pid + "'";
                    obj.nonQuery(cmd1);
                    MessageBox.Show("Property deleted successfully.", "Success!");
                    Cursor = Cursors.WaitCursor;
                    readproperties();
                    proplist.DisplayMember = "location";
                    proplist.DataSource = dt;
                    Cursor = Cursors.Arrow;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void proplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            dpnl.Visible = false;
            proplist.Enabled = false;
            loadinglbl.Visible = true;
            proploading.Visible = true;
            iflowpnl.Controls.Clear();
            pathurl.Clear();
            i = 0;
            string propname = proplist.Text;
            bg = new BackgroundWorker();
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += bg_RunWorkerCompleted;
            bg.WorkerSupportsCancellation = true;
            bg.RunWorkerAsync(propname);

           
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Application.OpenForms.OfType<removeproperty>().Count() == 1)
            {
                loadinglbl.Visible = false;
                proploading.Visible = false;
                proplist.Enabled = true;
                if (success)
                {

                    namelbl.Text = name;
                    loclbl.Text = loc;
                    addedbylbl.Text = trueemail;
                    pricelbl.Text = "₹ " + price;
                    verlbl.Text = ver;
                    pidlbl.Text = pid;
                    dpnl.Visible = true;
                    List<string> imageurl = (List<string>)e.Result;



                    try
                    {
                        foreach (String pic in imageurl)
                        {
                            pb = new PictureBox();
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 132;
                            pb.Width = 182;
                            pb.ImageLocation = pic;
                            iflowpnl.Controls.Add(pb);
                            iflowpnl.AutoScroll = true;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot display the image: "
                         + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);

                    }
                }
                else if (success == false)
                {

                }
            }
        }

        bool success = false;
        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
           
                string propname = e.Argument as string;
                try
                {
                    dr = obj.Query("select propertyid,location,name,price,email,picture,verified from properties where location='" + propname + "'");
                    dr.Read();
                    pid = dr[0].ToString();
                    loc = dr[1].ToString();
                    name = dr[2].ToString();
                    price = dr[3].ToString();
                    encemail = dr[4].ToString();
                    ver = dr[6].ToString();
                    if (dr[5].ToString() != null)
                        pathurl.Add(dr[5].ToString());
                    i++;


                    obj.closeConnection();

                    dr = obj.Query("select picture from pictures where propertyid='" + pid + "' limit 2");
                    while (dr.Read())
                    {
                        if (dr[0].ToString() != null)
                            pathurl.Add(dr[0].ToString());
                        i++;
                    }

                    obj.closeConnection();
                    total = i;

                    dr = obj.Query("select mail from customer where email='" + encemail + "'");
                    dr.Read();
                    trueemail = dr[0].ToString();
                    obj.closeConnection();

                    List<string> imageurl = new List<string>();
                    foreach (String pic in pathurl)
                    {

                        imageurl.Add("http://chinarhomes.com/chinarhomes/pictures/" + pic);


                    }
                success = true;
                    e.Result = imageurl;

                }
                catch (Exception ex)
                {
                success = false;
                
                }
            }
        }
}
