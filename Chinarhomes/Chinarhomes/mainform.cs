using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chinarhomes
{
    public partial class mainform : Form
    {
        MySqlDataReader dr;
        DBConnect obj = new DBConnect();
        bool error = false;

        private container cn = null;
        public mainform(Form cncopy)
        {
            cn = cncopy as container;
            InitializeComponent();
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();


        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (error)
            {
                cntpnl.Visible = false;
                
            }
           else if (!e.Cancelled)
            {
                object[] arg = (object[])e.Result;
                string lpa = (string)arg[0];
                string verified = (string)arg[1];
                string addedby = (string)arg[2];
                int count = (int)arg[3];

                lpalbl.Text = lpa;
                vlbl.Text = verified;
                abylbl.Text = addedby;
                if (count > 0)
                {
                    vcountlbl.Text = count + " Properties need verification.";
                }
                else if (count == 0)
                {
                    vcountlbl.Text = "All Properties are verified.";
                    warningpic.Visible = false;
                    vcountlbl.Location = new Point(4, 42);
                }
                homepnl.Visible = true;
                loading.Dispose();
            }
            else
            {
                MessageBox.Show("loading cancelled.","error");
            }
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dr = obj.Query("select location,email, verified from properties order by propertyid desc limit 1");
                dr.Read();
                string lpa = dr[0].ToString();
                string email = dr[1].ToString();
                string ver = dr[2].ToString();

                string verified = "";
                if (ver == "False")
                {
                    verified = "NO";
                }
                else if (ver == "True")
                {
                    verified = "YES";
                }

               
                obj.closeConnection();
                dr = obj.Query("select mail from customer where email='" + email + "'");
                dr.Read();
                string addedby = dr[0].ToString();
                obj.closeConnection();

                dr = obj.Query("select count(propertyid) from properties where verified='False'");
                dr.Read();
                int count = int.Parse(dr[0].ToString());
                
                obj.closeConnection();


                object[] args = {lpa,verified,addedby,count };
                e.Result = args;

            }catch(Exception ex)
            {
                obj.closeConnection();
                e.Cancel = true;
                error = true;
            }
        }


        private void propbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = true;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            properties prop = new properties();
            prop.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(prop);
            prop.Show();

            
        }

        private void policybtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = true;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            Cursor = Cursors.WaitCursor;
            policy pol = new policy();
            pol.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(pol);
            pol.Show();
            Cursor = Cursors.Arrow;
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = true;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            customers cust = new customers();
            cust.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(cust);
            cust.Show();
        }

        private void msgbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = true;
            arrow7.Visible = false;
            messages msg = new messages();
            msg.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(msg);
            msg.Show();
        }

        private void agentbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = true;
            arrow6.Visible = false;
            arrow7.Visible = false;
            agents ag = new agents();
            ag.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(ag);
            ag.Show();
        }

        private void intbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = true;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            interests inte = new interests();
            inte.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(inte);
            inte.Show();


        }

        private void propbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 62);
            arrow.Visible = true;

        }

        private void propbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void policybtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 312);
            arrow.Visible = true;
        }

        private void policybtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void customerbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 162);
            arrow.Visible = true;
        }

        private void customerbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void msgbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 113);
            arrow.Visible = true;
        }

        private void msgbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void agentbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 262);
            arrow.Visible = true;
        }

        private void agentbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }
        private void intbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 212);
            arrow.Visible = true;
           
        }

        private void intbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void verpic_Click(object sender, EventArgs e)
        {
            dialogcontainer dg = new dialogcontainer();

            verifiedproperties ver = new verifiedproperties(dg);
            ver.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(ver);
            dg.Size = new Size(1206, 734);
            dg.lbl.Text = "Verified Properties";
            dg.Show();
            ver.Show();
        }

        private void unverpic_Click(object sender, EventArgs e)
        {
            dialogcontainer dg = new dialogcontainer();

            unverifiedproperties ver = new unverifiedproperties(dg);
            ver.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(ver);
            dg.Size = new Size(1206, 734);
            dg.lbl.Text = "Unverified Properties";
            dg.Show();
            ver.Show();
        }

        private void polpic_Click(object sender, EventArgs e)
        {
            policy pol = new policy();
            pol.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(pol);
            pol.Show();
        }

        private void agpic_Click(object sender, EventArgs e)
        {
            agents ag = new agents();
            ag.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(ag);
            ag.Show();
        }

        private void msgpic_Click(object sender, EventArgs e)
        {
            messages msg = new messages();
            msg.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(msg);
            msg.Show();
        }

        private void custpic_Click(object sender, EventArgs e)
        {
            customers cust = new customers();
            cust.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(cust);
            cust.Show();
        }
        public void changelabel(String username)
        {
           userbtn.Text = username;
         

        }

        private void signoutlbl_Click(object sender, EventArgs e)
        {
            userinfo.loggedin = false;
            userinfo.admin = false;
            userinfo.email = "";
            userinfo.username = "";
            this.Close();
            MessageBox.Show("Logged out successfully.\n\nPlease Login to continue.","Success!");
            loginform lg = new loginform(cn);
            lg.TopLevel = false;
            cn.mainpnl.Controls.Clear();
            cn.mainpnl.Controls.Add(lg);
            lg.Show();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            

            dialogcontainer dg = new dialogcontainer();
            settings st = new settings();
            st.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(st);
            dg.Size = new Size(620, 479);
            dg.lbl.Text = "User Settings";
            dg.Show();
            st.Show();
        }

        private void addppic_Click(object sender, EventArgs e)
        {
            newproperty np = new newproperty(this);
            np.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(np);
            np.formlbl.Visible = true;
            np.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(cn);
            cn.mainpnl.Controls.Clear();
            mf.TopLevel = false;
            cn.mainpnl.Controls.Add(mf);
            mf.changelabel(userinfo.username);
            mf.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            mainform mf = new mainform(cn);
            cn.mainpnl.Controls.Clear();
            mf.TopLevel = false;
            cn.mainpnl.Controls.Add(mf);
            mf.changelabel(userinfo.username);
            mf.Show();
        }

        private void mailbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 362);
            arrow.Visible = true;
        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;


            dialogcontainer dg = new dialogcontainer();

            mail ml = new mail("");
            ml.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(ml);
            dg.Size = new Size(638, 550);
            dg.lbl.Text = "Send Mail";

            dg.Show();
            ml.Show();
        }

        private void mailbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            if (!userinfo.admin)
            {
               
               customerbtn.Visible = false;
               intbtn.Visible = false;
               agentbtn.Visible = false;
                policybtn.Visible = false;
                mailbtn.Visible = false;
                agpic.Visible = false;
                custpic.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                msgpic.Location = new Point(240, 330);
                label5.Location = new Point(295, 475);
            }
        }
    }
}
