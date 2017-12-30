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
    public partial class uploads : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        string name, contact, url;
        DataTable dt;

        public uploads()
        {
            InitializeComponent();
            loading.Visible = true;
            formlbl.Visible = true;
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();
        }

        BackgroundWorker bg;
        List<string> properties = new List<string>();
        List<string> details = new List<string>();

        private void custlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            dpnl.Visible = false;
            custlist.Enabled = false;
            loadinglbl.Visible = true;
            proploading.Visible = true;
            iflowpnl.Controls.Clear();
            properties.Clear();



            bg = new BackgroundWorker();
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += bg_RunWorkerCompleted;
            bg.WorkerSupportsCancellation = true;
            bg.RunWorkerAsync(custlist.Text);
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                loadinglbl.Visible = false;
                proploading.Visible = false;
                custlist.Enabled = true;

                if (success)
                {
                    namelbl.Text = name;
                    conlbl.Text = contact;
                    emaillbl.Text = custlist.Text;
                    List<pupload> dobj = (List<pupload>)e.Result;


                    string ver="";
                    foreach (var details in dobj)
                    {
                       
                        if (details.Verified == "True")
                        {
                            url= "http://chinarhomes.com/chinarhomes/pictures/";
                            ver = "Verified";

                        }else if (details.Verified == "False")
                        {
                            url = "http://chinarhomes.com/chinarhomes/uploads/";
                            ver = "Unverified";
                        }
                        CustomControl2 c = new CustomControl2(
                      new PictureBox
                      {

                          SizeMode = PictureBoxSizeMode.StretchImage,
                          
                            ImageLocation = url + details.Picture,
                            
                          Height = 150,
                          Width = 220,
                      },
                      new TextBox
                      {
                          Text = details.Loc + "\r\n" + "Area: " + details.Area + " marlas\r\n" + "Price: " + details.Price + "\r\n" + "Propertyid: " + details.Pid + "\r\n" + "Status: " + ver,
                          Size = new Size(220, 75),
                          Multiline = true,
                          ReadOnly = true
                      });

                        iflowpnl.AutoScroll = true;
                        iflowpnl.Controls.Add(c);
                    }
                    dpnl.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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

        string loc, picture, area, price, verified;
        bool success = false;
        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string custid = e.Argument as string;

                dr = obj.Query("select email,contact,name from customer where mail='" + custid + "'");
                dr.Read();
                string email = dr[0].ToString();
                contact = dr[1].ToString();
                name = dr[2].ToString();
                obj.closeConnection();


                dr = obj.Query("select propertyid from properties where email ='" + email + "'");
                while (dr.Read())
                {
                    properties.Add(dr[0].ToString());

                }

                obj.closeConnection();


                List<pupload> dobj = new List<pupload>();
                foreach (String property in properties)
                {

                    dr = obj.Query("select location,picture,area,price,verified from properties where propertyid='" + property + "' ");
                    dr.Read();
                    loc = dr[0].ToString();
                    area = dr[2].ToString();
                    price = dr[3].ToString();
                    picture = dr[1].ToString();
                    verified = dr[4].ToString();
                    obj.closeConnection();


                    dobj.Add(new pupload(loc, area, price, picture, property, verified));
                    
                }


                success = true;
                e.Result = dobj;

            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message);

                success = false;
                e.Result = "fail";
            }
        }


        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formlbl.Visible = false;
            loading.Visible = false;
            titlelbl.Location = new Point(1, 1);
            titlelbl.Visible = true;
           
            custlist.DisplayMember = "email";
            custlist.DataSource = dt;
            
            ipnl.Visible = true;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readproperties();
        }

        private void readproperties()
        {
            try
            {
                dr = obj.Query("select distinct customer.mail as email from customer inner join properties on properties.email=customer.email where customer.email!='21c46b0ac82e494ad94106564b411686';");

                dt = new DataTable();
                dt.Columns.Add("email", typeof(String));
                dt.Load(dr);


                obj.closeConnection();
            }catch { obj.closeConnection(); }
        }
    }

    public class CustomControl2 : Control
    {
        private PictureBox pb;
        private TextBox label;
        public CustomControl2(PictureBox pic, TextBox lbl)
        {
            pb = pic;
            label = lbl;
            Height = pb.Height + lbl.Height;
            Width = Math.Max(pb.Width, lbl.Width);
            Controls.Add(pb);
            pb.Location = new Point(0, 0);
            Controls.Add(lbl);
            lbl.Location = new Point(0, pb.Height);


        }
    }


    public class pupload
    {
        private string loc;
        private string area;
        private string price;
        private string picture;
        private string pid;
        private string verified;

        public pupload(string loc, string area, string price, string picture, string pid, string verified)
        {
            this.loc = loc;
            this.area = area;
            this.price = price;
            this.picture = picture;
            this.pid = pid;
            this.verified = verified;
        }

        public string Loc
        {
            get { return loc; }
            set { loc = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public string Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Verified
        {
            get { return verified; }
            set { verified = value; }
        }

    }

}

