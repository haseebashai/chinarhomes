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
        string tvp, tuvp;


        public properties()
        {
            InitializeComponent();
            BackgroundWorker pageload = new BackgroundWorker();
            pageload.DoWork += Pageload_DoWork;
            pageload.RunWorkerCompleted += Pageload_RunWorkerCompleted;
            pageload.RunWorkerAsync();
            loading.Visible = true;
        }

        private void Pageload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadinglbl.Text = "Highlights";
            loading.Visible = false;
            tvplbl.Text = "Total Verified Properties currently added: " + tvp;
            tuvplbl.Text = "Total Unverified Properties currently added: " + tuvp;
        }

        private void Pageload_DoWork(object sender, DoWorkEventArgs e)
        {
            dr = obj.Query("Select count(propertyid) from properties where verified='1'");
            dr.Read();
            tvp = dr[0].ToString();
            obj.closeConnection();

            dr = obj.Query("Select count(propertyid) from properties where verified='0'");
            dr.Read();
            tuvp = dr[0].ToString();
            obj.closeConnection();
        }

        private void verbtn_Click(object sender, EventArgs e)
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

        private void addpbtn_Click(object sender, EventArgs e)
        {
            dialogcontainer dg = new dialogcontainer();

            newproperty np = new newproperty(dg);
            np.TopLevel = false;
            dg.dialogpnl.Controls.Clear();
            dg.dialogpnl.Controls.Add(np);
            dg.Size = new Size(1206, 734);
            dg.lbl.Text = "Add New Property";
            np.dpnl.Location = new Point(4, 5);
            dg.Show();
            np.Show();
        }

        private void unverbtn_Click(object sender, EventArgs e)
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

  
        
    }
}
