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
    public partial class interests : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        string name,contact,encemail,url="http://chinarhomes.com/chinarhomes/pictures/";
        DataTable dt;

        public interests()
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
            formlbl.Visible = false;
            loading.Visible = false;
            titlelbl.Location = new Point(1, 1);
            titlelbl.Visible = true;
            
            custlist.DisplayMember = "mail";
            custlist.DataSource = dt;
            ipnl.Visible = true;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readinterests();
        }

        private void readinterests()
        {
            dr = obj.Query("select distinct interested.email, customer.mail from customer inner join interested on interested.email=customer.email;");
           
            dt = new DataTable();
            dt.Columns.Add("mail", typeof(String));
            dt.Load(dr);
            
           
            obj.closeConnection();
           


        }

        List<string> properties = new List<string>();
        int i = 0;
        BackgroundWorker bg;
        List<string> details = new List<string>();

        private void custlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            dpnl.Visible = false;
            custlist.Enabled = false;
            loadinglbl.Visible = true;
            proploading.Visible = true;
            iflowpnl.Controls.Clear();
            properties.Clear();
            i = 0;
            string custname = custlist.Text;
            bg = new BackgroundWorker();
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += bg_RunWorkerCompleted;
            bg.WorkerSupportsCancellation = true;
            bg.RunWorkerAsync(custname);
       
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
                loadinglbl.Visible = false;
                proploading.Visible = false;
                custlist.Enabled = true;

                if (success)
                {
                    namelbl.Text = name;
                    conlbl.Text = contact;
                    emaillbl.Text = custlist.Text;
                    List<details> dobj= (List<details>)e.Result;
                  
                    foreach (var details in dobj)
                    {

                        CustomControl c = new CustomControl(
                      new PictureBox
                      {
                          SizeMode = PictureBoxSizeMode.StretchImage,
                          ImageLocation = url + details.Picture,
                          Height = 150,
                          Width = 220,
                      },
                      new TextBox
                      {
                          Text = details.Loc + "\r\n" + "Area: " + details.Area + "\r\n" + "Price: " + details.Price + "\r\n" + "Propertyid: " + details.Pid,
                          Size = new Size(220, 60),
                          Multiline = true,
                          ReadOnly = true
                      });

                        iflowpnl.AutoScroll = true;
                        iflowpnl.Controls.Add(c);
                    }
                    dpnl.Visible = true;
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

        string loc, picture, area, price;
        bool success = false;
        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string custname = e.Argument as string;

                dr = obj.Query("select name,contact,email from customer where mail='"+custname+"' ");
                dr.Read();
                name = dr[0].ToString();
                contact = dr[1].ToString();
                encemail = dr[2].ToString();
                obj.closeConnection();
              

                dr = obj.Query("select propertyid from interested where email ='" + encemail + "'");
                while (dr.Read())
                {
                    properties.Add(dr[0].ToString());

                }

                obj.closeConnection();

                List<details> dobj = new List<details>();
                foreach (String property in properties)
                {

                    dr = obj.Query("select location,picture,area,price from properties where propertyid='" + property + "' ");
                    dr.Read();
                    loc = dr[0].ToString();
                    area = dr[2].ToString();
                    price = dr[3].ToString();
                    picture = dr[1].ToString();
                    obj.closeConnection();
                   
                    dobj.Add(new details(loc, area, price,picture,property));
  
                }
                success = true;
                e.Result = dobj;
               
            }catch
            {
                success = false;
                e.Result = "fail";
            }
        }
    }

    public class CustomControl : Control
    {
        private PictureBox pb;
        private TextBox label;
        public CustomControl(PictureBox pic, TextBox lbl)
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

    public class details
    {
        private string loc;
        private string area;
        private string price;
        private string picture;
        private string pid;

        public details(string loc, string area, string price, string picture,string pid)
        {
            this.loc = loc;
            this.area = area;
            this.price = price;
            this.picture = picture;
            this.pid = pid;
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

    }

}
