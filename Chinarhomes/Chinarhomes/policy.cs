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

namespace Chinarhomes
{

    public partial class policy : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        MySqlDataAdapter adap;
        BindingSource bsource;
        DataTable dt;
        MySqlCommandBuilder cmdbl;
        bool terms = true, faq = false, about = false;
        string id,cmd;

        public policy()
        {
            InitializeComponent();
        }

        public void readterms()
        {
            try
            {
               
                dr = obj.Query("select * from terms");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["termsid"].Visible = false;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Something happened, please try again.\n\n" + ex.Message.ToString(), "Error!");
            }
        }

        public void readfaq()
        {
            try
            {
                dr=obj.Query("select * from faq");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["faqid"].Visible = false;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Something happened, please try again.\n\n" + ex.Message.ToString(), "Error!");
            }
        }

        public void readabout()
        {
            try
            {
                dr = obj.Query("select * from about");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["aboutid"].Visible = false;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Something happened, please try again.\n\n" + ex.Message.ToString(), "Error!");
            }
        }



       
        private void loadingshow()
        {
            loadinglbl.Visible = true;
            loadingpic.Visible = true;
        }

        private void termsbtn_Click(object sender, EventArgs e)
        {
            terms = true;
            faq = false;
            about = false;

            readterms();



        }
     
       
        private void faqbtn_Click(object sender, EventArgs e)
        {
            terms = false;
            faq = true;
            about = false;

            readfaq();
           

        }

        private void policy_Load(object sender, EventArgs e)
        {
            readterms();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(desctxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && desctxt.Text != "")
            {

                MessageBox.Show("Abnormal Special Character found, Please remove it and proceed.");

            }
            else
            {
                try
                {
                    if (terms)
                    {
                        cmd = ("UPDATE terms SET `heading`= '" + headtxt.Text + "', `description`= '" + desctxt.Text + "' WHERE `termsid`= '" + id + "'");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully Updated.");
                        readterms();
                    }else if (faq)
                    {
                        cmd = ("UPDATE faq SET `question`= '" + headtxt.Text + "', `answer`= '" + desctxt.Text + "' WHERE `faqid`= '" + id + "'");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully Updated.");
                        readfaq();
                    }else if (about)
                    {
                        cmd = ("UPDATE about SET `heading`= '" + headtxt.Text + "', `description`= '" + desctxt.Text + "' WHERE `aboutid`= '" + id + "'");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully Updated.");
                        readabout();
                    }
                
                }

                catch (Exception ex)
                {
                    obj.closeConnection();
                    MessageBox.Show(ex.Message);
                }
             
            }
        }

        private void headtxt_Enter(object sender, EventArgs e)
        {
            if (headtxt.Text == "heading")
                headtxt.Text = "";
        }

        private void headtxt_Leave(object sender, EventArgs e)
        {
            if (headtxt.Text == "")
            {
                headtxt.Text = "heading";
            }
        }

        private void desctxt_Enter(object sender, EventArgs e)
        {
            if (desctxt.Text == "description")
                desctxt.Text = "";
        }

        private void desctxt_Leave(object sender, EventArgs e)
        {
            if (desctxt.Text == "")
            {
                desctxt.Text = "description";
            }
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            epnl.Location = new Point(300, 288);
            epnl.Visible = true;
            addbtn.Visible = true;
            updbtn.Visible = false;
             
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(desctxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && desctxt.Text != "")
            {

                MessageBox.Show("Abnormal Special Character found, Please remove it and proceed.");

            }
            else
            {
                try
                {
                    if (terms)
                    {
                        cmd = ("insert into terms (`heading`,`description`)values('" + headtxt.Text + "','" + desctxt.Text + "')");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully added.","Success");
                        readterms();
                    }
                    else if (faq)
                    {
                        cmd = ("insert into faq (`question`,`answer`)values('" + headtxt.Text + "','" + desctxt.Text + "')");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully added.", "Success");
                        readfaq();
                    }
                    else if (about)
                    {
                        cmd = ("insert into about (`heading`,`description`)values('" + headtxt.Text + "', '" + desctxt.Text + "')");
                        obj.nonQuery(cmd);
                        obj.closeConnection();
                        MessageBox.Show("Successfully added.", "Success");
                        readabout();
                    }

                }

                catch (Exception ex)
                {
                    obj.closeConnection();
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void policydataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (terms)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.policydataview.Rows[e.RowIndex];
                    id = row.Cells["termsid"].Value.ToString();
                    headtxt.Text = row.Cells["heading"].Value.ToString();
                    desctxt.Text = row.Cells["description"].Value.ToString();
                }
            }else if (faq)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.policydataview.Rows[e.RowIndex];
                    id = row.Cells["faqid"].Value.ToString();
                    headtxt.Text = row.Cells["question"].Value.ToString();
                    desctxt.Text = row.Cells["answer"].Value.ToString();
                }
            }else if (about)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.policydataview.Rows[e.RowIndex];
                    id = row.Cells["aboutid"].Value.ToString();
                    headtxt.Text = row.Cells["heading"].Value.ToString();
                    desctxt.Text = row.Cells["description"].Value.ToString();
                }
            }
            epnl.Visible = true;
         }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            terms = false;
            faq = false;
            about = true;

            readabout();

        }

     
      
        private void addabtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new MySqlCommandBuilder(adap);
                adap.Update(dt);
                MessageBox.Show("About entry added.");
                readabout();
                policydataview.DataSource = bsource;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something happened, please try again.\n\n" + ex.Message.ToString(), "Error!");
            }
        }


    }
}
