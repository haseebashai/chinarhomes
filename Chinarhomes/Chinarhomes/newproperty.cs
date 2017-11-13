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
using System.Net;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

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
            DialogResult dgr = MessageBox.Show("Please ensure all the details are filled and correct before proceeding.", "Confirm!", MessageBoxButtons.OKCancel);
            if (dgr == DialogResult.OK)
            {
                if (vyes.Checked == false && vno.Checked == false)
                {
                    MessageBox.Show("Please check verification type.", "Error!");
                    vyes.Focus();
                }
                else
                {
                    int ver = 0;

                    if (verified)
                        ver = 1;
                    else
                        ver = 0;
                    try
                    {
                        StringBuilder loc = new StringBuilder(locationtxt.Text);
                        loc.Replace(@"\", @"\\").Replace("'", "\\'");
                        StringBuilder pname = new StringBuilder(pnametxt.Text);
                        pname.Replace(@"\", @"\\").Replace("'", "\\'");
                        StringBuilder desc = new StringBuilder(desctxt.Text);
                        desc.Replace(@"\", @"\\").Replace("'", "\\'");



                        cmd = "INSERT INTO `chinarhomes`.`properties` (`location`, `tags`, `type`, `noofstories`, `noofrooms`, `area`,`areaofbuilt`, " +
                      "`price`, `priority`, `description`, `distancefrommain`, `age`, `furnished`, `verified`, `email`, `saletype`,`verifiedby`,`name`)" +
                      " VALUES ('" + loc + "', '"+pname+" " + loc + " " + tagstxt.Text + "', '" + ptypebox.Text + "', '" + floorstxt.Text + "', '" + roomstxt.Text + "', '" + areatxt.Text + "', '" + areaptxt.Text + "','" + pricetxt.Text + "'," +
                      " '" + prioritytxt.Text + "', '" + desc + "', '" + distancetxt.Text + "', '" + agetxt.Text + "', '" + furnishedtxt.Text + "', '" + ver + "','258efdc003a5c43825f73ff845ca1348', '" + saletypebox.Text + "','" + userinfo.email + "','" + pname + "')";
                        obj.nonQuery(cmd);
                        propertyid = obj.Count("SELECT LAST_INSERT_ID()");

                        obj.closeConnection();

                        int dp = 0;
                        foreach (string adr in pics)
                        {
                            UploadFileToFtp("ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/", adr);
                            if (dp == 0)
                            {
                                MessageBox.Show(adr);
                                string dpname = adr.Substring(adr.LastIndexOf("\\"));
                                cmd = "update properties set picture='" + dpname + "' where propertyid='" + propertyid + "'";
                                obj.nonQuery(cmd);
                                obj.closeConnection();
                                MessageBox.Show(dpname);
                                dp++;
                            }
                            else if (dp > 0)
                            {
                                string picsname = adr.Substring(adr.LastIndexOf("\\"));
                                cmd = "insert into pictures (`propertyid`,`picture`)values('" + propertyid + "','" + picsname + "')";
                                obj.nonQuery(cmd);
                                obj.closeConnection();
                                MessageBox.Show(picsname);
                            }

                        }
                        MessageBox.Show("added.");

                    }
                    catch (MySqlException ex)
                    {
                        obj.closeConnection();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
       
        private void clearpicbtn_Click(object sender, EventArgs e)
        {
            pics.Clear();
            flowpnl.Controls.Clear();
            flowpnl.Visible = false;
            updbtn.Visible = false;
           
            clearpicbtn.Visible = false;
            updpicbtn.Location = new Point(491, 90);
            updpicbtn.Text = "Select Pictures";
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
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
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
                        updpicbtn.Location = new Point(43, 128);
                        flowpnl.Visible = true;
                        updbtn.Visible = true;
                       
                        clearpicbtn.Visible = true;
                        updpicbtn.Text = "Add more Pictures";
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
                new {Text="Apartments"},
                new {Text="Houses"},
                 new {Text="Lands & Plots"},
                new {Text="Commercial Space"},
                 new {Text="Other"}             
            };
            ptypebox.DataSource = items;

            saletypebox.DisplayMember = "Text";
            var items2 = new[]
            {
                new {Text="Sale"},
                new {Text="Rent"}
                 
            };
            saletypebox.DataSource = items2;

            furnishedtxt.DisplayMember = "Text";
            var items3 = new[]
            {
                new {Text="Yes"},
                new {Text="No"}

            };
            furnishedtxt.DataSource = items3;
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void floorstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roomstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void areatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void areaptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void agetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void distancetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void prioritytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pricetxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(pricetxt.Text, @"^([0-9]+)$") && pricetxt.Text != "")
            {

                MessageBox.Show("Please enter correct amount.","Error!");
                pricetxt.Focus();

            }
        }

        private void locationtxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(locationtxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && locationtxt.Text != "")
            {

                MessageBox.Show("Please remove special characters like:\n\n© ™ ® ` etc.", "Error!");
                locationtxt.Focus();

            }
        }

        private void pnametxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(pnametxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && pnametxt.Text != "")
            {

                MessageBox.Show("Please remove special characters like:\n\n© ™ ® ` etc.", "Error!");
                pnametxt.Focus();

            }
        }

        private void floorstxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(floorstxt.Text, @"^([0-9]+)$") && floorstxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                floorstxt.Focus();

            }
        }

        private void roomstxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(roomstxt.Text, @"^([0-9]+)$") && roomstxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                roomstxt.Focus();

            }
        }

        private void areatxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(areatxt.Text, @"^([0-9]+)$") && areatxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                areatxt.Focus();

            }
        }

        private void areaptxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(areaptxt.Text, @"^([0-9]+)$") && areaptxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                areaptxt.Focus();

            }
        }

        private void agetxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(agetxt.Text, @"^([0-9]+)$") && agetxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                agetxt.Focus();

            }
        }

        private void distancetxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(distancetxt.Text, @"^([0-9]+)$") && distancetxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                distancetxt.Focus();

            }
        }

        private void prioritytxt_Leave(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(prioritytxt.Text, @"^([0-9]+)$") && prioritytxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                prioritytxt.Focus();

            }
        }

        private void desctxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(desctxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && desctxt.Text != "")
            {

                MessageBox.Show("Please remove special characters like:\n\n© ™ ® ` etc.", "Error!");
                desctxt.Focus();

            }
        }
    }
}
