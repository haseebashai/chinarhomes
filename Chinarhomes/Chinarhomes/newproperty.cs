using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Net;

namespace Chinarhomes
{
    public partial class newproperty : Form
    {
        List<string> pics = new List<string>();
        string cmd;
        DBConnect obj = new DBConnect();


        private dialogcontainer dg = null;
        public newproperty(Form dgcopy)
        {
            dg = dgcopy as dialogcontainer;
            InitializeComponent();
        }
        int propertyid;
        private void updbtn_Click(object sender, EventArgs e)
        {

                  cmd = "INSERT INTO `chinarhomes`.`properties` (`location`, `tags`, `type`, `noofstories`, `noofrooms`, `area`,`areaofbuilt`, "+
                "`price`, `priority`, `description`, `distancefrommain`, `age`, `furnished`, `verified`, `email`, `saletype`)"+
                " VALUES ('"+locationtxt.Text+"', '"+locationtxt.Text+ ""+tagstxt.Text+"', '"+ptypebox.Text+"', '" + floorstxt.Text + "', '" +roomstxt.Text + "', '"+areatxt.Text+"', '"+areaptxt.Text+"','"+pricetxt.Text+"',"+
                " '"+prioritytxt.Text+"', '"+desctxt.Text+"', '"+distancetxt.Text+"', '"+agetxt.Text+"', '"+furnishedtxt.Text+"', '"+verified+"','" + userinfo.email+ "', '"+saletypebox.Text+"')";
            obj.nonQuery(cmd);
            obj.closeConnection();
            propertyid = obj.Count("SELECT LAST_INSERT_ID()");
            MessageBox.Show(propertyid.ToString());
            obj.closeConnection();

            int dp = 0;
           foreach(string adr in pics)
            {
                UploadFileToFtp("ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/", adr);
                if (dp == 0)
                {
                    MessageBox.Show(adr);
                    string dpname = adr.Substring(adr.LastIndexOf('\\'));
                    cmd = "update properties set picture='"+dpname+"' where propertyid='"+propertyid+"'";
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                    MessageBox.Show(dpname);
                }
                else
                {
                    string picsname = adr.Substring(adr.LastIndexOf('\\'));
                    cmd = "insert into pictures (`propertyid`,`picture`)values('"+propertyid+"','"+adr+"')";
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                    MessageBox.Show(picsname);
                }
               
            }
        }
       
        private void clearpicbtn_Click(object sender, EventArgs e)
        {
            pics.Clear();
            flowpnl.Controls.Clear();
            flowpnl.Visible = false;
            updbtn.Visible = false;
            cancelbtn.Visible = false;
            clearpicbtn.Visible = false;
        }

        private void updpicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG|" + "All files (*.*)|*.*";

         
            fd.Multiselect = true;
            fd.Title = "Image Browser";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {

                foreach (String file in fd.FileNames)
                {

                    try
                    {
                        pics.Add(file);
                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = 182;
                        pb.Width = 242;
                        pb.Image = loadedImage;
                        flowpnl.AutoScroll = true;
                        flowpnl.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {

                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace);
                        pics.Remove(pics.Last());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                         + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                        pics.Remove(pics.Last());
                    }
                    if (pics.Count > 0)
                    {
                        flowpnl.Visible = true;
                        updbtn.Visible = true;
                        cancelbtn.Visible = true;
                        clearpicbtn.Visible = true;
                    }
                }
            }
        }
        public void UploadFileToFtp(string url, string filePath)
        {
            try
            {
                var fileName = Path.GetFileName(filePath);
                var request = (FtpWebRequest)WebRequest.Create(url + fileName);

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("Chinarhomes", "Chinar@123");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;

                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(requestStream);
                        requestStream.Close();
                    }
                }


                //      var response = (FtpWebResponse)request.GetResponse();
                //    MessageBox.Show("Image uploaded successfully.\nSuccess Response code: " + response.StatusDescription);

                //  response.Close();


            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Error!");
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

        private void newproperty_Load(object sender, EventArgs e)
        {
            ptypebox.DisplayMember = "Text";
            var items = new[]
            {
                new {Text="Apartment"},
                new {Text="House"},
                 new {Text="Land"},
                new {Text="Shop"},
                 new {Text="Others"}             
            };
            ptypebox.DataSource = items;

            saletypebox.DisplayMember = "Text";
            var items2 = new[]
            {
                new {Text="Sale"},
                new {Text="Rent"}
                 
            };
            saletypebox.DataSource = items2;
        }
    }
}
