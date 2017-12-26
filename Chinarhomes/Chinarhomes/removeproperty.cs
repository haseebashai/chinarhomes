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
using System.Security.Cryptography;

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
            dr = obj.Query("select concat(propertyid,':     ',location) as location from properties");

            dt = new DataTable();
            dt.Columns.Add("location", typeof(String));
            dt.Load(dr);
            obj.closeConnection();
            

        }
        private void pwdtxt_TextChanged(object sender, EventArgs e)
        {
            if (pwdtxt.Text != "")
            {
                pwdent = true;
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

        BackgroundWorker bg;
        string pid, loc, name, price, encemail,trueemail,ver;
        bool pwdent = false;
        private void rmpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pwdent == false)
                {
                    pwdpnl.Visible = true;
                }
                else if(pwdent==true)
                {
                    DialogResult dgr = MessageBox.Show("Erasing this property will remove it from customer's wishlist/interested list and will remove it from everywhere.\n\nAre you sure you want to remove this property?\n" + loc, "Confirm!", MessageBoxButtons.YesNo);
                    if (dgr == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        
                            string pwd = md5hash(pwdtxt.Text);

                            dr = obj.Query("Select password from staff where username='" + userinfo.username + "';");
                            dr.Read();
                            if (dr[0].Equals(pwd))
                            {
                            obj.closeConnection();

                                string cmd = "delete from pictures where propertyid='" + pid + "'";
                                obj.nonQuery(cmd);
                                string cmd1 = "delete from interested where propertyid='" + pid + "'";
                                obj.nonQuery(cmd1);
                                string cmd2 = "delete from wishlist where propertyid='" + pid + "'";
                                obj.nonQuery(cmd2);
                                string cmd3 = "delete from properties where propertyid='" + pid + "'";
                                obj.nonQuery(cmd3);
                                MessageBox.Show("Property deleted successfully.", "Success!");
                                Cursor = Cursors.WaitCursor;
                                readproperties();
                                proplist.DisplayMember = "location";
                                proplist.DataSource = dt;
                                Cursor = Cursors.Arrow;
                            obj.closeConnection();
                            pwdpnl.Visible = false;
                            pwdtxt.Text = "";
                            pwdent = false;
                        }
                        else
                            {
                            Cursor = Cursors.Arrow;
                            MessageBox.Show("Incorrect Password.", "Error!");
                            obj.closeConnection();
                        }

                    }else
                    {
                        pwdpnl.Visible = false;
                        pwdtxt.Text = "";
                        pwdent = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Arrow;
               
                MessageBox.Show(ex.Message);
                pwdpnl.Visible = false;
                pwdtxt.Text = "";
                pwdent = false;
            }
        
        }

        private void proplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            pwdent = false;
            pwdtxt.Text = "";
            pwdpnl.Visible = false;
            dpnl.Visible = false;
            proplist.Enabled = false;
            loadinglbl.Visible = true;
            proploading.Visible = true;
            iflowpnl.Controls.Clear();
            pathurl.Clear();
            i = 0;
            string propid = proplist.Text.Split(':')[0];
            
            bg = new BackgroundWorker();
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += bg_RunWorkerCompleted;
            bg.WorkerSupportsCancellation = true;
            bg.RunWorkerAsync(propid);

           
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
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
            }catch { }
        }

        bool success = false;
        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
           
                string propid = e.Argument as string;
                try
                {
                    dr = obj.Query("select propertyid,location,name,price,email,picture,verified from properties where propertyid='" + propid + "'");
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
                    if (ver == "True")
                    {
                        imageurl.Add("http://chinarhomes.com/chinarhomes/pictures/" + pic);
                    }else if (ver == "False")
                    {
                        imageurl.Add("http://chinarhomes.com/chinarhomes/uploads/" + pic);
                    }

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
