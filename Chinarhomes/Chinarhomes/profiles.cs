using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;

namespace Chinarhomes
{

    public partial class profiles : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt,dt1;
        BindingSource bsource,bsource1;
        bool profile = false, job = false;

        public profiles()
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
            try
            {
                jobdataview.DataSource = bsource1;
                jobdataview.Columns["jobtype"].Visible = false;
                jobdataview.Columns["jobdescription"].Visible = false;
                loading.Visible = false;
                formlbl.Text = "Job Requests";
                formlbl.BringToFront();
                apnl.Visible = true;
                job = true;
                profile = false;
            }
            catch { }
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            readjobs();
        }

        private void readprofile()
        {
            try
            {
                dr = obj.Query("select * from profile");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
            }
            catch { }
        }

        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            contacttxt.MaxLength = 10;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
        bool update = false;
        string id;
        private void jobdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (profile)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.jobdataview.Rows[e.RowIndex];
                        update = true;
                        id = row.Cells["id"].Value.ToString();
                        emailtxt.Text = row.Cells["email"].Value.ToString();
                        nametxt.Text = row.Cells["name"].Value.ToString();
                        desigtxt.Text = row.Cells["designation"].Value.ToString();
                        skilltxt.Text = row.Cells["skills"].Value.ToString();
                        contacttxt.Text = row.Cells["contact"].Value.ToString();
                        exptxt.Text = row.Cells["experience"].Value.ToString();
                        schooltxt.Text = row.Cells["school"].Value.ToString();
                        string picture = row.Cells["picture"].Value.ToString();

                        dp.BackgroundImage = null;
                        BackgroundWorker pic = new BackgroundWorker();
                        uplbl.Text = "Loading...";
                        uplbl.Visible = true;

                        pic.DoWork += (o, a) =>
                        {
                            System.Threading.Thread.Sleep(2000);
                            a.Result = "http://chinarhomes.com/chinarhomes/pictures/profiles/" + picture;

                        };
                        pic.RunWorkerCompleted += (o, b) =>
                        {

                            dp.SizeMode = PictureBoxSizeMode.Zoom;
                            dp.ImageLocation = b.Result as string;

                            uplbl.Text = "Upload new picture";
                        };
                        pic.RunWorkerAsync();
                        addbtn.Text = "Update";
                        addnewbtn.Visible = true;
                        rmvpbtn.Visible = true;


                    }
                }
                else if (job)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.jobdataview.Rows[e.RowIndex];
                        id = row.Cells["id"].Value.ToString();
                        umailtxt.Text = row.Cells["email"].Value.ToString();
                        usernametxt.Text = row.Cells["name"].Value.ToString();
                        jtypetxt.Text = row.Cells["jobtype"].Value.ToString();
                        desctxt.Text = row.Cells["jobdescription"].Value.ToString();
                        contxt.Text = row.Cells["contact"].Value.ToString();
                        posttxt.Text = row.Cells["posted"].Value.ToString();

                        jdpnl.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            update = false;
            nametxt.Text = "";
            emailtxt.Text = "";
            desigtxt.Text = "";
            contacttxt.Text = "";
            skilltxt.Text = "";
            exptxt.Text = "";
            schooltxt.Text = "";    
            addbtn.Text = "Add Profile";
            addnewbtn.Visible = false;
            uplbl.Visible = false;
            rmvpbtn.Visible = false;
            dp.BackgroundImage = null;
            dp.Image = null;
            dp.Image = Properties.Resources.user_20;
        }
        private void contacttxt_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(contacttxt.Text, @"^([0-9]+)$") && contacttxt.Text != "")
            {

                MessageBox.Show("Please enter correct number.", "Error!");
                contacttxt.Focus();

            }
        }

        private void canbtn_Click(object sender, EventArgs e)
        {
            update = false;
            nametxt.Text = "";
            emailtxt.Text = "";
            desigtxt.Text = "";
            contacttxt.Text = "";
            skilltxt.Text = "";
            exptxt.Text = "";
            schooltxt.Text = "";
            addbtn.Text = "Add Profile";
            addnewbtn.Visible = false;
            uplbl.Visible = false;
            errlbl.Visible = false;
            rmvpbtn.Visible = false;
            dp.BackgroundImage = null;
            dp.Image = null;
            dp.Image = Properties.Resources.user_20;
        }

        string fileaddress, filename, fullpath, directory,uploadpath;

        private void uplbl_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog picdialog = new OpenFileDialog();
                if (picdialog.ShowDialog() == DialogResult.OK)
                {
                    dp.Image = null;
                    fileaddress = picdialog.FileName;
                    filename = picdialog.SafeFileName;
                    Image myimage = new Bitmap(fileaddress);
                    Bitmap clone = new Bitmap(myimage.Width, myimage.Height);
                    // get the object representing clone's currently empty drawing surface
                    Graphics g = Graphics.FromImage(clone);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                    // copy the original image onto this surface
                    g.DrawImage(myimage, 0, 0, myimage.Width, myimage.Height);
                    // free graphics and original image
                    g.Dispose();
                    myimage.Dispose();
                    dp.BackgroundImage = clone;
                    dp.BackgroundImageLayout = ImageLayout.Stretch;
                    fullpath = Path.GetFullPath(fileaddress).TrimEnd(Path.DirectorySeparatorChar);
                    directory = Path.GetDirectoryName(fullpath) + "\\";
                    uploadpath = Path.GetFileName(fullpath);
                    pic = true;



                }
            }
            catch { }
        }

        private void profbtn_Click(object sender, EventArgs e)
        {
            jobdataview.DataSource = null;
            Cursor = Cursors.WaitCursor;
            readprofile();
            jobdataview.DataSource = bsource;

            dpnl.Visible = true;
            jdpnl.Visible = false;
            canbtn_Click(null, null);
            Cursor = Cursors.Arrow;
          
            profile = true;
            job = false;
        }

        private void ucanbtn_Click(object sender, EventArgs e)
        {
            jdpnl.Visible = false;
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string cmd = "update jobs set processed=1 where id ='"+id+"'";
                obj.nonQuery(cmd);
                MessageBox.Show("Job status updated as Processed.", "Success!");
                jdpnl.Visible = false;
                readjobs();
                jobdataview.DataSource = bsource1;
            }
            catch
            {
                obj.closeConnection();
                MessageBox.Show("Update failed. Please retry.", "Error!");
            }
            Cursor = Cursors.Arrow;
        }

        private void rmvjbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgr = MessageBox.Show("Do you want to remove this job by " + usernametxt.Text + " ?", "Confirm!", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    string cmd = "delete from jobs where id ='" + id + "'";
                    obj.nonQuery(cmd);
                    MessageBox.Show("Job removed.", "Success!");
                    readjobs();
                    jobdataview.DataSource = bsource1;
                    jdpnl.Visible = false;
                    Cursor = Cursors.Arrow;
                }
            }catch
            {
                obj.closeConnection();
                MessageBox.Show("Job deletion failed, Please retry.", "Error!");
            }
            Cursor = Cursors.Arrow;
        }

        private void rmvpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgr = MessageBox.Show("Do you want to remove the profile of " + nametxt.Text + " ?", "Confirm!", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    string cmd = "delete from profile where id ='" + id + "'";
                    obj.nonQuery(cmd);
                    MessageBox.Show("Profile removed.", "Success!");
                    readprofile();
                    jobdataview.DataSource = bsource;
                    canbtn_Click(null, null);
                    Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                obj.closeConnection();
                MessageBox.Show("Profile deletion failed, Please retry.", "Error!");
            }
            Cursor = Cursors.Arrow;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            errlbl.Visible = false;
            StringBuilder name = new StringBuilder(nametxt.Text);
            name.Replace(@"'", "\\'").Replace(@"\", "\\");
            StringBuilder school = new StringBuilder(schooltxt.Text);
            school.Replace(@"'", "\\'").Replace(@"\", "\\");
            StringBuilder desig = new StringBuilder(desigtxt.Text);
            desig.Replace(@"'", "\\'").Replace(@"\", "\\");
            StringBuilder skills = new StringBuilder(skilltxt.Text);
            skills.Replace(@"'", "\\'").Replace(@"\", "\\");
            StringBuilder email = new StringBuilder(emailtxt.Text);
            email.Replace(@"'", "\\'").Replace(@"\", "\\");
            StringBuilder exp = new StringBuilder(exptxt.Text);
            exp.Replace(@"'", "\\'").Replace(@"\", "\\");


            try
            {
               
                 if (emailtxt.Text == "" || nametxt.Text == "" || desigtxt.Text == "" || contacttxt.Text == "" || skilltxt.Text == "" || exptxt.Text == "" || schooltxt.Text == "")
                {
                    MessageBox.Show("Please enter all details.", "Error!");
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    if (update == false)
                    {
                        if (pic == false)
                        {
                            errlbl.Visible = true;
                        }
                        else if(pic)
                        {
                            UploadFileToFtp("ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/profiles/", fileaddress);
                            string cmd = "insert into profile (`name`,`school`,`designation`,`picture`,`skills`,`email`,`contact`,`experience`) values" +
                            " ('" + name + "','" + school + "','" + desig + "','" + filename + "','" + skills + "','" + email + "','" + contacttxt.Text + "','" + exp + "')";
                            obj.nonQuery(cmd);
                            MessageBox.Show("Profile added succesfully.", "Success!");
                            canbtn_Click(null, null);
                            readprofile();
                            jobdataview.DataSource = bsource;

                        }
                    }
                    else if(update==true)
                    {
                        if (pic)
                        {
                            

                            UploadFileToFtp("ftp://chinarhomes.com/httpdocs/chinarhomes/pictures/profiles/", fileaddress);
                            string cmd = "update profile set `picture`='"+filename+"',`email`='" + email + "',`school`='" + school + "', `name`='" + name + "', `contact`='" + contacttxt.Text + "', `designation`='" + desig + "', `skills`='" + skills + "',`experience`='" + exp + "' where id='" + id + "'";
                            obj.nonQuery(cmd);
                            MessageBox.Show("Profile updated succesfully.", "Success!");
                            canbtn_Click(null, null);
                            readprofile();
                            jobdataview.DataSource = bsource;
                        }
                        else if (pic == false)
                        {
                           
                            string cmd = "update profile set `email`='" + email + "',`school`='" + school + "', `name`='" + name + "', `contact`='" + contacttxt.Text + "', `designation`='" + desig + "', `skills`='" + skills + "',`experience`='" + exp + "' where id='" + id + "'";
                            obj.nonQuery(cmd);
                            MessageBox.Show("Profile updated succesfully.", "Success!");
                            canbtn_Click(null, null);
                            readprofile();
                            jobdataview.DataSource = bsource;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show("Profile adding failed. Please retry."+ex.ToString(), "Error!");
               
            }
            Cursor = Cursors.Arrow;
        }

        bool pic = false;
        private void dp_Click(object sender, EventArgs e)
        {
            try { 
            OpenFileDialog picdialog = new OpenFileDialog();
                if (picdialog.ShowDialog() == DialogResult.OK)
                {
                    dp.Image = null;
                    fileaddress = picdialog.FileName;
                    filename = picdialog.SafeFileName;
                    Image myimage = new Bitmap(fileaddress);
                    Bitmap clone = new Bitmap(myimage.Width, myimage.Height);
                    // get the object representing clone's currently empty drawing surface
                    Graphics g = Graphics.FromImage(clone);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                    // copy the original image onto this surface
                    g.DrawImage(myimage, 0, 0, myimage.Width, myimage.Height);
                    // free graphics and original image
                    g.Dispose();
                    myimage.Dispose();
                    dp.BackgroundImage = clone;
                    dp.BackgroundImageLayout = ImageLayout.Stretch;
                    fullpath = Path.GetFullPath(fileaddress).TrimEnd(Path.DirectorySeparatorChar);
                    directory = Path.GetDirectoryName(fullpath) + "\\";
                    uploadpath = Path.GetFileName(fullpath);
                    pic = true;


                }
            }
            catch { }
        }

        bool picfailed = false;
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

                //using (var fileStream = File.OpenRead(filePath))
                //{
                //    using (var requestStream = request.GetRequestStream())
                //    {
                //        fileStream.CopyTo(requestStream);
                //        requestStream.Close();
                //    }
                //}

                Stream ftpStream = request.GetRequestStream();
                FileStream file = File.OpenRead(filePath);
               

                byte[] buffer = new byte[10240];
                int bytesRead = 0;



                while ((bytesRead = file.Read(buffer, 0, buffer.Length)) > 0)
                {

                    ftpStream.Write(buffer, 0, bytesRead);
                }

                file.Close();
                ftpStream.Close();
              


            }
            catch (Exception ex)
            {
                picfailed = true;
                
            }
        }

        private void jobbtn_Click(object sender, EventArgs e)
        {
            jobdataview.DataSource = null;
            Cursor = Cursors.WaitCursor;
            readjobs();
            jobdataview.DataSource = bsource1;
            dpnl.Visible = false;
          //  jdpnl.Visible = true;
            Cursor = Cursors.Arrow;
            job = true;
            profile = false;
        }

        private void readjobs()
        {
            try
            {
                dr = obj.Query("select * from jobs");
                dt1 = new DataTable();
                dt1.Load(dr);
                obj.closeConnection();
                bsource1 = new BindingSource();
                bsource1.DataSource = dt1;
                
            }catch
            {
                obj.closeConnection();
            }
        }
    }
}
