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
    public partial class properties : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        BindingSource bsource;
      

        public properties()
        {
            InitializeComponent();
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();

        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            propdataview.DataSource = bsource;
            propdataview.Columns["ID"].Visible = false;
            propdataview.Columns["description"].Visible = false;
            propdataview.Columns["noofstories"].Visible = false;
            propdataview.Columns["noofrooms"].Visible = false;
            propdataview.Columns["areaofbuilt"].Visible = false;
            propdataview.Columns["distancefrommain"].Visible = false;
            propdataview.Columns["timestampp"].Visible = false;
            propdataview.Columns["furnished"].Visible = false;
            propdataview.Columns["tags"].Visible = false;

        }
     
        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
           
                try
                {
                    dr = obj.Query("select propertyid as ID, location as Location, type as Type, area as Area, description as Description, "
                        +"price as Price, verified as Verified,noofstories, noofrooms, areaofbuilt, distancefrommain, timestampp, furnished,tags,picture from properties");
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    bsource = new BindingSource();
                    bsource.DataSource = dt;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private void loadpics()
        {
            dr = obj.Query("select properties.picture, pictures.picture from pictures inner join properties on properties.propertyid=pictures.propertyid where properties.propertyid='"+pidlbl.Text+"';");
            dr.Read();
            
        }
      
        private void propdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelbtn.Visible = false;
            updbtn.Visible = false;
            editpropbtn.Visible = true;
            dpnl.Enabled = false;
            dpnl.Visible = true;
            bpnl.Visible = true;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.propdataview.Rows[e.RowIndex];
                pidlbl.Text = row.Cells["id"].Value.ToString();
                locationtxt.Text= row.Cells["location"].Value.ToString();
                typetxt.Text= row.Cells["type"].Value.ToString();
                pricetxt.Text= row.Cells["price"].Value.ToString();
                string verify = row.Cells["verified"].Value.ToString();
               
                if (verify =="True")
                {
                    vyes.Checked = true;
                }
                else
                {
                    vno.Checked = true;
                } 

                floorstxt.Text= row.Cells["noofstories"].Value.ToString();
                roomstxt.Text= row.Cells["noofrooms"].Value.ToString();
                areatxt.Text = row.Cells["area"].Value.ToString();
                areaptxt.Text= row.Cells["areaofbuilt"].Value.ToString();
                timestamptxt.Text= row.Cells["timestampp"].Value.ToString();
                desctxt.Text= row.Cells["description"].Value.ToString();
                distancetxt.Text= row.Cells["distancefrommain"].Value.ToString();
                furnishedtxt.Text= row.Cells["furnished"].Value.ToString();
                tagstxt.Text= row.Cells["tags"].Value.ToString();

            }
        }

        private void editpropbtn_Click(object sender, EventArgs e)
        {
            editpropbtn.Visible = false;
            cancelbtn.Visible = true;
            updbtn.Visible = true;
            dpnl.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
        {
            ImageList images = new ImageList();
            images.Images.Add(
                LoadImage("https://lalchowk.in/lalchowk/pictures/14001-1.jpg"));
            images.Images.Add(
                LoadImage("https://lalchowk.in/lalchowk/pictures/14000-1.jpg"));

            listView1.View = View.LargeIcon;

           
            images.ImageSize = new Size(96, 96);
            images.ColorDepth = ColorDepth.Depth32Bit;
            listView1.LargeImageList = images;
            listView1.Items.Add("An item", 0);
            listView1.Items.Add("Another item item", 1);
        }
        private Image LoadImage(string url)
        {
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
        }
    }
 }

