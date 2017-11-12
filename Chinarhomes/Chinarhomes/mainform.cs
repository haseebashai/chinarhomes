using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinarhomes
{
    public partial class mainform : Form
    {
        private container cn = null;
        public mainform(Form cncopy)
        {
            cn = cncopy as container;
            InitializeComponent();
        }

        private void propbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = true;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;


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
            policy pol = new policy();
            pol.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(pol);
            pol.Show();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = true;
            arrow4.Visible = false;
            arrow5.Visible = false;
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
            arrow4.Visible = true;
            arrow5.Visible = false;
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
            agents ag = new agents();
            ag.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(ag);
            ag.Show();
        }

        private void propbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 61);
            arrow.Visible = true;

        }

        private void propbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void policybtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 112);
            arrow.Visible = true;
        }

        private void policybtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void customerbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 161);
            arrow.Visible = true;
        }

        private void customerbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void msgbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 211);
            arrow.Visible = true;
        }

        private void msgbtn_MouseLeave(object sender, EventArgs e)
        {
            arrow.Visible = false;
        }

        private void agentbtn_MouseEnter(object sender, EventArgs e)
        {
            arrow.Location = new Point(145, 260);
            arrow.Visible = true;
        }

        private void agentbtn_MouseLeave(object sender, EventArgs e)
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
            this.Close();
            MessageBox.Show("Logged out successfully.\n\nPlease Login to continue.");
            loginform lg = new loginform(this, this);
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
            dg.Size = new Size(630, 479);
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
    }
}
