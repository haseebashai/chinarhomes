using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Chinarhomes
{
    public partial class verifiedproperties : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        BindingSource bsource;
        string address = "http://chinarhomes.com/chinarhomes/pictures/";
        List<string> pathurl = new List<string>();
        int i = 0;
        int total;
        string dp;
        string cmd;
        string ftpadd = "ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/";

        private dialogcontainer dg = null;


        public verifiedproperties(Form dgcopy)
        {
            dg = dgcopy as dialogcontainer;

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
            propdataview.Columns["picture"].Visible = false;
            propdataview.Columns["saletype"].Visible = false;
            propdataview.Columns["priority"].Visible = false;

        }
     
        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readproperties();
        }
        private void readproperties()
        {
            try
            {
                dr = obj.Query("select propertyid as ID, location as Location, type as Type, area as Area, description as Description, "
                    + "price as Price, verified as Verified,noofstories, noofrooms, areaofbuilt, distancefrommain, timestampp, "
                    + "furnished,tags,picture,saletype,priority from properties where verified='1'");
                DataTable dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void propdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadpicbtn.Visible = false;
            cancelbtn.Visible = false;
            updbtn.Visible = false;
            editpropbtn.Visible = true;
            dpnl.Enabled = false;
            dpnl.Visible = true;
            dppnl.Visible = false;
            bpnl.Visible = true;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.propdataview.Rows[e.RowIndex];
                pidlbl.Text = row.Cells["id"].Value.ToString();
                locationtxt.Text = row.Cells["location"].Value.ToString();
                typetxt.Text = row.Cells["type"].Value.ToString();
                pricetxt.Text = row.Cells["price"].Value.ToString();
                string verify = row.Cells["verified"].Value.ToString();

                if (verify == "True")
                {
                    vyes.Checked = true;
                }
                else
                {
                    vno.Checked = true;
                }

                floorstxt.Text = row.Cells["noofstories"].Value.ToString();
                roomstxt.Text = row.Cells["noofrooms"].Value.ToString();
                areatxt.Text = row.Cells["area"].Value.ToString();
                areaptxt.Text = row.Cells["areaofbuilt"].Value.ToString();
                prioritytxt.Text = row.Cells["priority"].Value.ToString();
                desctxt.Text = row.Cells["description"].Value.ToString();
                distancetxt.Text = row.Cells["distancefrommain"].Value.ToString();
                furnishedtxt.Text = row.Cells["furnished"].Value.ToString();
                tagstxt.Text = row.Cells["tags"].Value.ToString();
                saletypetxt.Text = row.Cells["saletype"].Value.ToString();
                
            }
        }

        private void editpropbtn_Click(object sender, EventArgs e)
        {
            loadpicbtn.Visible = true;
            editpropbtn.Visible = false;
            cancelbtn.Visible = true;
            updbtn.Visible = true;
            dpnl.Enabled = true;
        }

        private void loadpicbtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                dr = obj.Query("select picture from properties where propertyid='" + pidlbl.Text + "'");
                dr.Read();
                dp = dr[0].ToString();
                dpbox.ImageLocation = address + dp;

                obj.closeConnection();

                dr = obj.Query("select picture from pictures where propertyid='" + pidlbl.Text + "'");
                while (dr.Read())
                {
                    pathurl.Add(dr[0].ToString());
                    i++;
                }

                obj.closeConnection();
                total = i;
                if (i == 0)
                {
                    nopicslbl.Visible = true;
                    nopicslbl.BringToFront();
                }
                else
                    PopulateListView();
            
                dppnl.Visible = true;
            }catch(Exception ex)
            {
                dppnl.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateListView()
        {
            try
            {
               
                
                ImageList images = new ImageList();
                images.Images.Clear();
                piclist.View = View.LargeIcon;


                images.ImageSize = new Size(112, 112);
                images.ColorDepth = ColorDepth.Depth32Bit;
                piclist.LargeImageList = images;

                
                foreach (string str in pathurl)
                {

                    images.Images.Add(LoadImage(address + str));

                }

                for (i = 0; i < total;)
                {

                    piclist.Items.Add(pathurl[i], i);
                    i++;

                }
                
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private Image LoadImage(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                Bitmap bmp = new Bitmap(responseStream);

                responseStream.Dispose();

                return bmp;
            }catch(WebException ex)
            {
              
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {

            StringBuilder loc = new StringBuilder(locationtxt.Text);
            loc.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder tags = new StringBuilder(tagstxt.Text);
            tags.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder type = new StringBuilder(typetxt.Text);
            type.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder floors = new StringBuilder(floorstxt.Text);
            floors.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder rooms = new StringBuilder(roomstxt.Text);
            rooms.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder area = new StringBuilder(areatxt.Text);
            area.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder areap = new StringBuilder(areaptxt.Text);
            areap.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder price = new StringBuilder(pricetxt.Text);
            price.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder priority = new StringBuilder(prioritytxt.Text);
            priority.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder desc = new StringBuilder(desctxt.Text);
            desc.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder distance = new StringBuilder(distancetxt.Text);
            distance.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder age = new StringBuilder(agetxt.Text);
            age.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder furnished = new StringBuilder(furnishedtxt.Text);
            furnished.Replace(@"\", @"\\").Replace("'", "\\'");
            StringBuilder saletype = new StringBuilder(saletypetxt.Text);
            saletype.Replace(@"\", @"\\").Replace("'", "\\'");


            string ver;
            if (vyes.Checked == false && vno.Checked == false)
            {
                MessageBox.Show("Please check verify first.");
            } else {
                if (verified)
                    ver = "1";
                else
                    ver = "0";

                cmd = "UPDATE `chinarhomes`.`properties` SET `location`='" + loc + "', `tags`='" + tags + "', `type`='" + type + "', `noofstories`='" + floors + "', `noofrooms`='" + rooms + "',"
                    + " `area`='" + area + "', `areaofbuilt`='" + areap + "', `price`='" + price + "', `priority`='" + priority + "', `description`='" + desc + "',"
                    + " `distancefrommain`='" + distance + "', `age`='" + age + "', `furnished`='" + furnished + "', `verified`='" + ver + "', `saletype`='" + saletype + "' WHERE `propertyid`='" + pidlbl.Text + "'";
                obj.nonQuery(cmd);
                obj.closeConnection();
                MessageBox.Show("Property Updated succesfully.", "Success");
            }
            dpnl.Enabled = false;
            editpropbtn.Visible = true;
            loadpicbtn.Visible = false;
            cancelbtn.Visible = false;
            updbtn.Visible = false;
            readproperties();
            propdataview.DataSource = bsource;

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("Do you want to delete foloowing picture?\n" + piclist.SelectedItems[0].Text, "Confirm!", MessageBoxButtons.YesNo);

            if (dgr == DialogResult.Yes)
            {
                DeleteFileOnFtpServer(new Uri(ftpadd + dp));
            }
        }
       
        private void delpicsbtn_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("Do you want to delete following picture?\n" + piclist.SelectedItems[0].Text, "Confirm!", MessageBoxButtons.YesNo);
            
                if (dgr == DialogResult.Yes)
                {
                DeleteFileOnFtpServer(new Uri(ftpadd + piclist.SelectedItems[0].Text));
                try
                {
                    cmd = "delete from pictures where picture='" + piclist.SelectedItems[0].Text + "'&& propertyid='" + pidlbl.Text + "'";
                    MessageBox.Show(cmd);
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                }
                catch (MySqlException ex)
                {
                    obj.closeConnection();
                    MessageBox.Show(ex.Message);
                }
            }
            
           
        }
        public static bool DeleteFileOnFtpServer(Uri serverUri)
        {
            try
            {

                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return false;
                }
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
                request.Credentials = new NetworkCredential("Chinarhomes", "Chinar@123");
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Picture deleted successfully.","Removed!");
                response.Close();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something happened, please try again.\n\n" + ex.Message, "Error!");
                return false;
            }
        }

        bool verified;
        private void vyes_CheckedChanged(object sender, EventArgs e)
        {
            if (vyes.Checked)
                vno.Checked = false;
            verified = true;
        }

        private void vno_CheckedChanged(object sender, EventArgs e)
        {
            if (vno.Checked)
                vyes.Checked = false;
            verified = false;
        }

        private void desctxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(desctxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && desctxt.Text != "")
            {

                MessageBox.Show("Abnormal Special Character found, Please remove it and proceed.\nCheck for any special symbols like trademark, copyright etc. and remove it.");

            }
        }

        private void updpicbtn_Click(object sender, EventArgs e)
        {

        }
    }
 }

