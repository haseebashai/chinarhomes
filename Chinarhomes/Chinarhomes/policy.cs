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
        bool terms = true, faq = false, about = false, contact = false;
        string id,cmd;

        public policy()
        {
            InitializeComponent();
            
           
        }


        public void readterms()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dr = obj.Query("select * from terms");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["termsid"].Visible = false;
                Cursor = Cursors.Arrow;
            }

            catch (Exception ex)
            {
                Cursor = Cursors.Arrow;
            }
        }

        public void readfaq()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dr=obj.Query("select * from faq");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["faqid"].Visible = false;
                Cursor = Cursors.Arrow;
            }

            catch (Exception ex)
            {
                Cursor = Cursors.Arrow;
               
            }
        }

        public void readabout()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dr = obj.Query("select * from about where aboutid>1");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["aboutid"].Visible = false;
                Cursor = Cursors.Arrow;
            }

            catch (Exception ex)
            {
                Cursor = Cursors.Arrow;
            }
        }

        public void readcontacts()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dr = obj.Query("select * from contacts");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                policydataview.DataSource = bsource;
                policydataview.Columns["id"].Visible = false;
                Cursor = Cursors.Arrow;
            }

            catch (Exception ex)
            {
                Cursor = Cursors.Arrow;
            }
        }


        private void loadingshow()
        {
            loadinglbl.Visible = true;
            loadingpic.Visible = true;
        }

        private void termsbtn_Click(object sender, EventArgs e)
        {
            epnl.Visible = false;
            terms = true;
            faq = false;
            about = false;
            contact = false;

            readterms();



        }
     
       
        private void faqbtn_Click(object sender, EventArgs e)
        {
            epnl.Visible = false;
            terms = false;
            faq = true;
            about = false;
            contact = false;

            readfaq();
           

        }


        private void headtxt_Enter(object sender, EventArgs e)
        {
            if (headtxt.Text == "heading"||headtxt.Text=="Name")
                headtxt.Text = "";
        }

        private void headtxt_Leave(object sender, EventArgs e)
        {
            if (!contact)
            {
                if (headtxt.Text == "")
                {
                    headtxt.Text = "heading";
                }
            }
        }

        private void desctxt_Enter(object sender, EventArgs e)
        {
            if (desctxt.Text == "description"||desctxt.Text=="Number")
                desctxt.Text = "";
        }

        private void desctxt_Leave(object sender, EventArgs e)
        {
            if (!contact)
            {
                if (desctxt.Text == "")
                {
                    desctxt.Text = "description";
                }
            }
        }

        bool newentry=false;
        private void addnewbtn_Click(object sender, EventArgs e)
        {
            newentry = true;
            epnl.Visible = true;
            if (contact)
            {
                headtxt.Text = "Name";
                desctxt.Text = "Number";
                desctxt.MaxLength = 10;
            }else
            {
                headtxt.Text = "heading";
                desctxt.Text = "description";
                desctxt.MaxLength = 32767;
            }
            addbtn.Text = "Add new entry";
             
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(desctxt.Text, @"^([a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/{}""|]+)$") && desctxt.Text != "")
            {

                MessageBox.Show("Please remove special characters like:\n\n© ™ ® ` etc.", "Error!");

            }
            else
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    if (terms)
                    {
                        if (newentry)
                        {
                            cmd = "insert into terms (`heading`,`description`)values('" + headtxt.Text + "','" + desctxt.Text + "')";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully added.", "Success");
                            readterms();
                        }
                        else
                        {
                            cmd = "UPDATE terms set heading='" + headtxt.Text + "',description='" + desctxt.Text + "' where termsid='"+id+"'";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully updated.", "Success");
                            readterms();
                        }
                    }
                    else if (faq)
                    {
                        if (newentry)
                        {
                            cmd = "insert into faq (`question`,`answer`)values('" + headtxt.Text + "','" + desctxt.Text + "')";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully added.", "Success");
                            readfaq();
                        }else
                        {
                            cmd = "UPDATE faq set question='" + headtxt.Text + "',answer='" + desctxt.Text + "' where faqid='"+id+"'";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully updated.", "Success");
                            readfaq();
                        }
                    }
                    else if (about)
                    {
                        if (newentry)
                        {
                            cmd = "insert into about (`heading`,`description`)values('" + headtxt.Text + "', '" + desctxt.Text + "') ";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully added.", "Success");
                            readabout();
                        }else
                        {
                            cmd = "UPDATE about set heading='" + headtxt.Text + "',description='" + desctxt.Text + "' where aboutid='"+id+"'";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully updated.", "Success");
                            readabout();
                        }
                    }else if (contact)
                    {
                        if (newentry)
                        {
                            cmd = "insert into contacts (`name`,`contact`)values('" + headtxt.Text + "', '" + desctxt.Text + "')";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully updated.", "Success");
                            readcontacts();
                        }else
                        {
                            cmd = "UPDATE contacts set name='" + headtxt.Text + "',contact='" + desctxt.Text + "' where id='"+id+"'";
                            obj.nonQuery(cmd);
                            obj.closeConnection();
                            MessageBox.Show("Successfully updated.", "Success");
                            readcontacts();
                        }
                    }
                    Cursor = Cursors.Arrow;
                }

                catch (Exception ex)
                {
                    Cursor = Cursors.Arrow;
                    obj.closeConnection();
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void desctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (contact)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                desctxt.MaxLength = 10;
            }else
            {
                desctxt.MaxLength = 32767;
            }
        }


        private void conbtn_Click(object sender, EventArgs e)
        {
            epnl.Visible = false;
            terms = false;
            faq = false;
            about = false;
            contact = true;

            readcontacts();
        }

        private void policy_Load(object sender, EventArgs e)
        {
            
            readterms();
            Cursor = Cursors.Arrow;
            polpnl.Visible = true;
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
            }else if (contact)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.policydataview.Rows[e.RowIndex];
                    id = row.Cells["id"].Value.ToString();
                    headtxt.Text = row.Cells["name"].Value.ToString();
                    desctxt.Text = row.Cells["contact"].Value.ToString();
                }
            }
            epnl.Visible = true;
            addbtn.Text = "Update";
            newentry = false;
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            epnl.Visible = false;
            terms = false;
            faq = false;
            about = true;
            contact = false;

            readabout();

        }

    }
}
