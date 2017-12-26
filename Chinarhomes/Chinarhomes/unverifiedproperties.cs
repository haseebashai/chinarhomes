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
using System.Net.Mail;
using System.Threading.Tasks;


namespace Chinarhomes
{
    public partial class unverifiedproperties : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        BindingSource bsource;
        string address = "http://chinarhomes.com/chinarhomes/uploads/";
        List<string> pathurl = new List<string>();
        int i = 0;
        int total;
        string dp, emailto;
        string cmd;
        string ftpadd = "ftp://chinarhomes.com/httpdocs/chinarhomes/uploads/";
        string newadd = "ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/";
        DataTable dt;
        private dialogcontainer dg = null;


        public unverifiedproperties(Form dgcopy)
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
            try
            {
                if (Application.OpenForms.OfType<unverifiedproperties>().Count() == 1)
                {
                    propdataview.DataSource = bsource;

                    propdataview.Columns["description"].Visible = false;
                    propdataview.Columns["noofstories"].Visible = false;
                    propdataview.Columns["noofrooms"].Visible = false;
                    propdataview.Columns["areaofbuilt"].Visible = false;
                    propdataview.Columns["distancefrommain"].Visible = false;

                    propdataview.Columns["furnished"].Visible = false;
                    propdataview.Columns["tags"].Visible = false;
                    propdataview.Columns["picture"].Visible = false;
                    propdataview.Columns["saletype"].Visible = false;
                    propdataview.Columns["priority"].Visible = false;
                    propdataview.Columns["email"].Visible = false;
                    loading.Visible = false;
                    formlbl.Visible = false;
                    proppnl.Visible = true;
                }
            } catch { }
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
                    + "price as Price, verified as Verified,noofstories, noofrooms, areaofbuilt, distancefrommain, "
                    + "furnished,tags,picture,saletype,priority,name,email from properties where verified='0'");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;

                dr = obj.Query("select distinct type from properties ");
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("type", typeof(String));
                dt1.Load(dr);
                obj.closeConnection();
                ptypebox.DisplayMember = "type";
                ptypebox.DataSource = dt1;


                dr = obj.Query("select distinct saletype from properties ");
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("saletype", typeof(String));
                dt2.Load(dr);
                obj.closeConnection();
                saletypebox.DisplayMember = "saletype";
                saletypebox.DataSource = dt2;


                dr = obj.Query("select distinct furnished from properties ");
                DataTable dt3 = new DataTable();
                dt3.Columns.Add("furnished", typeof(String));
                dt3.Load(dr);
                obj.closeConnection();
                furnishedtxt.DisplayMember = "furnished";
                furnishedtxt.DataSource = dt3;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void propdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dldbtn.Visible = false;
            nopicslbl.Visible = false;
            loadpicbtn.Visible = false;
            cancelbtn.Visible = false;
            updbtn.Visible = false;
            editpropbtn.Visible = true;
            dpnl.Enabled = false;
            dpnl.Visible = true;
            dppnl.Visible = false;
            bpnl.Visible = true;
            apnl.Visible = false;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.propdataview.Rows[e.RowIndex];
                pidlbl.Text = row.Cells["id"].Value.ToString();
                locationtxt.Text = row.Cells["location"].Value.ToString();
                ptypebox.Text = row.Cells["type"].Value.ToString();
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
                saletypebox.Text = row.Cells["saletype"].Value.ToString();
                pnametxt.Text = row.Cells["name"].Value.ToString();
                emailto = row.Cells["email"].Value.ToString();

            }
        }

        private void Email_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            string to = (string)e.Result;
            if (to == "emailnotfoundfail")
            {
                apnl.Visible = false;
            }
            else
            {
                emaillbl.Text = to;
                apnl.Visible = true;
            }
        }
        string name;
        private void Email_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {


                dr = obj.Query("select mail,name from customer where email='" + emailto + "'");
                dr.Read();
                string to = dr[0].ToString();
                name = dr[1].ToString();
                obj.closeConnection();
                e.Result = to;

            } catch {
                e.Result = "emailnotfoundfail";
            }
        }

        private void editpropbtn_Click(object sender, EventArgs e)
        {
            emaillbl.Text = "";
            BackgroundWorker email = new BackgroundWorker();
            email.DoWork += Email_DoWork;
            email.RunWorkerCompleted += Email_RunWorkerCompleted;
            email.WorkerSupportsCancellation = true;
            email.RunWorkerAsync();


            loadpicbtn.Visible = true;
            loadpicbtn.Enabled = true;
            editpropbtn.Visible = false;
            cancelbtn.Visible = true;
            updbtn.Visible = true;
            dpnl.Enabled = true;
            apnl.Visible = true;
        }

        private void loadpicbtn_Click(object sender, EventArgs e)
        {
            if (emaillbl.Text == "")
            {
                MessageBox.Show("Please wait a minute.", "Wait");
            }
            else
            {
                iflowpnl.Controls.Clear();
                nopicslbl.Text = "Loading Pictures...";
                nopicslbl.Visible = true;
                nopicslbl.BringToFront();
                loadpicbtn.Enabled = false;
                BackgroundWorker bg = new BackgroundWorker();
                bg.RunWorkerCompleted += Bg_RunWorkerCompleted1;
                bg.DoWork += Bg_DoWork1;
                bg.WorkerSupportsCancellation = true;
                bg.RunWorkerAsync();
            }


        }

        string downloadpath;
        BackgroundWorker picdld = new BackgroundWorker();
        
        private void dldbtn_Click(object sender, EventArgs e)
        {

            try
            {
               
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {

                        downloadpath = folderDialog.SelectedPath;
                        
                        dldlbl.Text = "Downloading " + piclist.Count.ToString() + " pictures";
                        dldlbl.Visible = true;
                        dpnl.Enabled = false;
                        bpnl.Enabled = false;
                        propdataview.Enabled = false;

                        picdld.DoWork += Picdld_DoWork;
                        picdld.RunWorkerCompleted += Picdld_RunWorkerCompleted;
                        picdld.WorkerReportsProgress = true;
                        picdld.ProgressChanged += Picdld_ProgressChanged;
                        picdld.RunWorkerAsync();
                        dldbtn.Enabled = false;

                    }
                    else
                    {
                        dldbtn.Enabled = true;
                    }

                }
            }
            catch { }

        }

        private void Picdld_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void Picdld_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = e.Result as string;
            if (result == "success")
            {
               
                MessageBox.Show("Pictures downloaded at\r\n" + downloadpath,"Success!");
                dldbtn.Visible = false;

            }else if (result == "fail")
            {
                MessageBox.Show("Some files could not be downloaded, please retry.","Error!");
                
            }
           
            dldbtn.Enabled = true;
           
            dldlbl.Visible = false;
            progresspc.Visible = false;
            dpnl.Enabled = true;
            bpnl.Enabled = true;
            propdataview.Enabled = true;
        }

        private void Picdld_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                foreach (string pic in piclist)
                {

                    string url = "ftp://chinarhomes.com/httpdocs/chinarhomes/uploads/" + pic;
                    string ext = Path.GetExtension(url);
                    if (ext != "")
                    {



                        NetworkCredential credentials = new NetworkCredential("Chinarhomes", "Chinar@123");

                        // Query size of the file to be downloaded
                        FtpWebRequest sizeRequest = (FtpWebRequest)WebRequest.Create(url);
                        sizeRequest.Credentials = credentials;
                        sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                        long size = sizeRequest.GetResponse().ContentLength / 1000;



                        // Download the file
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                        request.Credentials = credentials;
                        request.Timeout = 10000;
                        request.Method = WebRequestMethods.Ftp.DownloadFile;
                        string filename = url.Substring(url.LastIndexOf("/") + 1);



                        using (Stream ftpStream = request.GetResponse().GetResponseStream())
                        using (Stream fileStream = File.Create(downloadpath + "\\" + filename))
                        {
                            byte[] buffer = new byte[10240];
                            int read;
                            int total = 0;
                            while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fileStream.Write(buffer, 0, read);
                                total += read;

                                progresspc.Invoke(
                                    (MethodInvoker)delegate { progresspc.Visible = true; progresspc.Text = "(" + total / 1000 + "/" + size + ") KB downloaded"; });
                            }
                        }

                    }

                }

            
                e.Result = "success";
                piclist.Clear();
                
                }catch { e.Result = "fail"; }
        }


        private void Download(string path)
        {

            try
            {
              
                

            }
            catch (Exception ex)
            {
               
               
            }
        }



        private void Bg_DoWork1(object sender, DoWorkEventArgs e)
        {
            try
            {
                dr = obj.Query("select picture from properties where propertyid='" + pidlbl.Text + "'");
                while(dr.Read())
                {
                   
                    pathurl.Add(dr[0].ToString());

                  
                   
                }
                obj.closeConnection();

                dr = obj.Query("select picture from pictures where propertyid='" + pidlbl.Text + "'");
                while (dr.Read())
                {
                    pathurl.Add(dr[0].ToString());
                  
                }

                obj.closeConnection();
                total = i;
              
                if (pathurl.Contains(""))
                {
                    e.Result = "404";
                   
                }
                else 
                {
                    e.Result = "success";
                }
              
            }
            catch (Exception ex)
            {
                e.Result = "fail";
              //  MessageBox.Show(ex.Message);
            }
        }

        List<string> piclist = new List<string>();
        private void Bg_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            piclist.Clear();
            string result = (string)e.Result;
           
            if (result == "404")
            {
                nopicslbl.Visible = true;
                nopicslbl.BringToFront();
                nopicslbl.Text = "No Pictures found.";
                dppnl.Visible = false;
              
                loadpicbtn.Enabled = true;
            }
            else if (result == "success")
            {
                Cursor = Cursors.WaitCursor;

                //    PopulateListView();
                foreach (String pic in pathurl)
                {
                    piclist.Add(pic);
                    PictureBox pb = new PictureBox();
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 102;
                    pb.Width = 132;
                    pb.ImageLocation = address + pic;
                    iflowpnl.Controls.Add(pb);
                    iflowpnl.AutoScroll = true;

                }
                dppnl.Visible = true;
                loadpicbtn.Visible = false;
                loadpicbtn.Enabled = true;
                dldbtn.Visible = true;
                nopicslbl.Text = "No Pictures found.";
                nopicslbl.Visible = false;
                Cursor = Cursors.Arrow;
               
            }
            else if (result == "fail")
            {
                dppnl.Visible = false;
                loadpicbtn.Enabled = true;
            }
           
            i = 0;
            total = 0;
            pathurl.Clear();
            
        }

        //private void PopulateListView()
        //{
        //    try
        //    {
               

        //        piclist.Clear();
        //        ImageList images = new ImageList();
        //        piclist.View = View.LargeIcon;


        //        images.ImageSize = new Size(112, 112);
        //        images.ColorDepth = ColorDepth.Depth32Bit;
        //        piclist.LargeImageList = images;


        //        foreach (string str in pathurl)
        //        {
        //            images.Images.Add(LoadImage(address + str));

        //        }

        //        for (i = 0; i < total;)
        //        {
                   
        //            piclist.Items.Add(pathurl[i], i);
        //            i++;
              
                    

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        picfailed = true;
              
        //    }

        //}

        bool picfailed = false;
        //private Image LoadImage(string url)
        //{
        //    try
        //    {
        //        WebRequest request = WebRequest.Create(url);

        //        WebResponse response = request.GetResponse();
        //        Stream responseStream = response.GetResponseStream();

        //        Bitmap bmp = new Bitmap(responseStream);

        //        responseStream.Dispose();

        //        return bmp;
        //    }
        //    catch (WebException ex)
        //    {
        //        picfailed = true;
              
        //        return null;
        //    }
        //}

        List<string> pics = new List<string>();
        private void updbtn_Click(object sender, EventArgs e)
        {
            if (emaillbl.Text == "")
            {
                MessageBox.Show("Please wait a minute.", "Wait");
            }
            else
            {
                if (locationtxt.Text == "")
                {
                    MessageBox.Show("Please enter location first.", "Error!");
                }
                else
                {
                    progressBar1.Visible = true;
                    dppnl.Visible = false;
                    nopicslbl.Visible = false;

                    BackgroundWorker bg = new BackgroundWorker();
                    bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
                    bg.DoWork += Bg_DoWork;
                    bg.WorkerSupportsCancellation = true;

                    StringBuilder loc = new StringBuilder(locationtxt.Text);
                    loc.Replace(@"\", @"\\").Replace("'", "\\'");
                    StringBuilder tags = new StringBuilder(tagstxt.Text);
                    tags.Replace(@"\", @"\\").Replace("'", "\\'");
                    StringBuilder type = new StringBuilder(ptypebox.Text);
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
                    StringBuilder saletype = new StringBuilder(saletypebox.Text);
                    saletype.Replace(@"\", @"\\").Replace("'", "\\'");
                    StringBuilder pname = new StringBuilder(pnametxt.Text);
                    pname.Replace(@"\", @"\\").Replace("'", "\\'");

                    string ver;
                    if (verified)
                        ver = "1";
                    else
                        ver = "0";



                    if (vyes.Checked == false && vno.Checked == false)
                    {
                        MessageBox.Show("Please check verify first.");
                        progressBar1.Visible = false;
                        //      dppnl.Visible = true;

                    }
                    else
                    {

                        bpnl.Enabled = false;
                        loadpicbtn.Enabled = false;
                        object[] arg = { loc, tags, type, floors, rooms, area, areap, price, priority, desc, distance, age, furnished, saletype, pname, ver };
                        bg.RunWorkerAsync(arg);

                    }
                }
            }
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                object[] arg = e.Argument as object[];
                StringBuilder loc = (StringBuilder)arg[0];
                StringBuilder tags = (StringBuilder)arg[1];
                StringBuilder type = (StringBuilder)arg[2];
                StringBuilder floors = (StringBuilder)arg[3];
                StringBuilder rooms = (StringBuilder)arg[4];
                StringBuilder area = (StringBuilder)arg[5];
                StringBuilder areap = (StringBuilder)arg[6];
                StringBuilder price = (StringBuilder)arg[7];
                StringBuilder priority = (StringBuilder)arg[8];
                StringBuilder desc = (StringBuilder)arg[9];
                StringBuilder distance = (StringBuilder)arg[10];
                StringBuilder age = (StringBuilder)arg[11];
                StringBuilder furnished = (StringBuilder)arg[12];
                StringBuilder saletype = (StringBuilder)arg[13];
                StringBuilder pname = (StringBuilder)arg[14];
                string ver = (string)arg[15];

               
                if (ver == "1")
                {
                    DialogResult dgr = MessageBox.Show(loc + "\n\nProperty verified?", "Confirm!", MessageBoxButtons.YesNo);
                    if (dgr == DialogResult.Yes)
                    {

                        cmd = "UPDATE `chinarhomes`.`properties` SET `location`='" + loc + "', `tags`='" + tags + "', `type`='" + type + "', `noofstories`='" + floors + "', `noofrooms`='" + rooms + "',"
                    + " `area`='" + area + "', `areaofbuilt`='" + areap + "', `price`='" + price + "', `priority`='" + priority + "', `description`='" + desc + "',"
                    + " `distancefrommain`='" + distance + "', `age`='" + age + "', `furnished`='" + furnished + "', `verified`='" + ver + "', `saletype`='" + saletype + "',`name`='" + pname + "',`verifiedby`='" + userinfo.email + "' WHERE propertyid='" + pidlbl.Text + "'";
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        dr = obj.Query("select picture from properties where propertyid='" + pidlbl.Text + "'");
                        dr.Read();
                        pics.Add(dr[0].ToString());
                        obj.closeConnection();
                        dr = obj.Query("select picture from pictures where propertyid='" + pidlbl.Text + "'");
                        while (dr.Read())
                        {
                            pics.Add(dr[0].ToString());
                        }
                        obj.closeConnection();

                        if (pics.Contains(""))
                        {

                            SmtpClient Smtpobj = new SmtpClient();
                            Smtpobj.Host = "smtp.zoho.com";
                            Smtpobj.Port = 587;
                            Smtpobj.UseDefaultCredentials = false;
                            Smtpobj.EnableSsl = true;
                            Smtpobj.Credentials = new NetworkCredential("support@chinarhomes.com", "Chinar@123chinar");
                            Smtpobj.DeliveryMethod = SmtpDeliveryMethod.Network;


                            MailMessage mail = new MailMessage("support@chinarhomes.com", emaillbl.Text);
                            mail.From = new MailAddress("support@chinarhomes.com", "ChinarHomes: Property Listed!");
                            mail.IsBodyHtml = true;
                            mail.Subject = "Your listed property is now live.";
                            mail.Body = "Dear <b>" + name + "</b>,<p><p>Congratulations, your listed property at <b>" + loc + "</b> is now live on ChinarHomes.<p>We will notify you once a customer responds to your listing.<p><p><p>Thanks and warm regards,<p>ChinarHomes.";

                            Smtpobj.Send(mail);

                            e.Result = "without";
                           

                        }
                        else if (!pics.Contains(""))
                        {

                            FtpWebRequest ftpRequest = null;
                            FtpWebResponse ftpResponse = null;
                            foreach (string pic in pics)
                            {
                                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://chinarhomes.com/httpdocs/chinarhomes/uploads/" + pic);
                                ftpRequest.Credentials = new NetworkCredential("Chinarhomes", "Chinar@123");
                                ftpRequest.UseBinary = true;
                                ftpRequest.UsePassive = true;
                                ftpRequest.KeepAlive = true;
                                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                                ftpRequest.RenameTo = "../pictures/" + pic;
                                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                                ftpResponse.Close();

                            }
                            SmtpClient Smtpobj = new SmtpClient();
                            Smtpobj.Host = "smtp.zoho.com";
                            Smtpobj.Port = 587;
                            Smtpobj.UseDefaultCredentials = false;
                            Smtpobj.EnableSsl = true;
                            Smtpobj.Credentials = new NetworkCredential("support@chinarhomes.com", "Chinar@123chinar");
                            Smtpobj.DeliveryMethod = SmtpDeliveryMethod.Network;


                            MailMessage mail = new MailMessage("support@chinarhomes.com", emaillbl.Text);
                            mail.From = new MailAddress("support@chinarhomes.com", "ChinarHomes: Property Listed!");
                            mail.IsBodyHtml = true;
                            mail.Subject = "Your listed property is now live.";
                            mail.Body = "Dear <b>" + name + "</b>,<p><p>Congratulations, your listed property at <b>" + loc + "</b> is now live on ChinarHomes.<p>We will notify you once a customer responds to your listing.<p><p><p>Thanks and warm regards,<p>ChinarHomes.";

                            Smtpobj.Send(mail);

                            e.Result = "success";
                          
                        }
                    }
                    else
                    {
                        e.Result = "fail";
                    }
                }
                else if (ver == "0")
                {
                   
                    cmd = "UPDATE `chinarhomes`.`properties` SET `location`='" + loc + "', `tags`='" + tags + "', `type`='" + type + "', `noofstories`='" + floors + "', `noofrooms`='" + rooms + "',"
                        + " `area`='" + area + "', `areaofbuilt`='" + areap + "', `price`='" + price + "', `priority`='" + priority + "', `description`='" + desc + "',"
                        + " `distancefrommain`='" + distance + "', `age`='" + age + "', `furnished`='" + furnished + "', `verified`='" + ver + "', `saletype`='" + saletype + "',`name`='" + pname + "' WHERE propertyid='" + pidlbl.Text + "'";
                    obj.nonQuery(cmd);
                    obj.closeConnection();
                    e.Result = "success";
                   
                }


            }
            catch(Exception ex)
            {
                
                e.Result = "fail";
                MessageBox.Show(ex.Message);
            }
            }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = (string)e.Result;
          
            if (result == "success")
            {
                progressBar1.Visible = false;
                MessageBox.Show("Property Updated succesfully.", "Success");
                dpnl.Enabled = false;
                dpnl.Visible = false;
                dppnl.Visible = false;
                apnl.Visible = false;
                editpropbtn.Visible = true;
                loadpicbtn.Visible = false;
                cancelbtn.Visible = false;
                updbtn.Visible = false;
                progressBar1.Visible = false;
                bpnl.Enabled = true;
                loadpicbtn.Enabled = true;
                bpnl.Visible = false;
                loadpicbtn.Visible = false;
                Cursor = Cursors.WaitCursor;
                readproperties();
                
                propdataview.DataSource = bsource;
                Cursor = Cursors.Arrow;
            }else if (result == "without")
            {
                progressBar1.Visible = false;

                MessageBox.Show("Property Verified without pictures!\nPlease goto verified properties and upload pictures.", "Warning!");
               
                dpnl.Enabled = false;
                dpnl.Visible = false; apnl.Visible = false;
                dppnl.Visible = false;
                editpropbtn.Visible = true;
                loadpicbtn.Visible = false;
                cancelbtn.Visible = false;
                updbtn.Visible = false;
                progressBar1.Visible = false;
                bpnl.Enabled = true;
                loadpicbtn.Enabled = true;
                bpnl.Visible = false;
                loadpicbtn.Visible = false;
                Cursor = Cursors.WaitCursor;
                readproperties();

                propdataview.DataSource = bsource;
                Cursor = Cursors.Arrow;

            } else if (result == "fail")
            {
                progressBar1.Visible = false;
                bpnl.Visible = true;
                bpnl.Enabled = true;
                loadpicbtn.Visible = true;
                loadpicbtn.Enabled = true;
                Cursor = Cursors.Arrow;
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

                MessageBox.Show("Please enter correct amount.", "Error!");
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

        private void locsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("location LIKE '%{0}%'", locsearch.Text);
                propdataview.DataSource = dv;
            }catch { }
        }

        private void namesearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("name LIKE '%{0}%'", namesearch.Text);
                propdataview.DataSource = dv;
            }catch { }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            dldbtn.Visible=false;
            nopicslbl.Visible = false;
            loadpicbtn.Visible = false;
            cancelbtn.Visible = false;
            updbtn.Visible = false;
            editpropbtn.Visible = true;
            dpnl.Enabled = false;
            dpnl.Visible = true;
            dppnl.Visible = false;
            bpnl.Visible = true;
        }
    }
    }

