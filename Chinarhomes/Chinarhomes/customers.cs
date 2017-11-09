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
    public partial class customers : Form
    {

        DBConnect obj = new DBConnect();
        String email;
        BindingSource bsource;
      
        MySqlDataReader dr;
       
        DataTable dt1;

        public customers()
        {
            InitializeComponent();
        }

        private void readcustomers()
        {
            try
            {
                dr = obj.Query("select * from customer");
                dt1 = new DataTable();
                dt1.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt1;
                customerdataview.DataSource = bsource;
                customerdataview.Columns["mail"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
      /*      dialogcontainer dg = new dialogcontainer();
            promomail pm = new promomail(emaillbl.Text, dg);
            pm.TopLevel = false;
            dg.Size = new Size(700, 715);
            pm.epnl.Location = new Point(-300, 1);
            pm.elistlbl.Text = "";

            dg.dialogpnl.Controls.Add(pm);
            pm.loadingdg();
            dg.Text = "Send Email";

            dg.Show();

            pm.Show(); */
        }


        private void readcount()
        {
            try
            {
                dr = obj.Query("select count(*) from customer");
                dr.Read();
                countlbl.Text = dr[0].ToString();
                obj.closeConnection();
            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void customers_Load(object sender, EventArgs e)
        {
            readcustomers();
            readcount();
        }



        private void readdetails()
        {
            try
            {
                dr = obj.Query("select * from interested where email='"+email+"'");
                dt1 = new DataTable();
                dt1.Load(dr);
                obj.closeConnection();
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt1;
                interesteddataview.DataSource = bsource;

                dr = obj.Query("select * from wishlist where email='"+email+"'");
                dt1 = new DataTable();
                dt1.Load(dr);
                obj.closeConnection();
                BindingSource bsource2 = new BindingSource();
                bsource2.DataSource = dt1;
                wishlistdataview.DataSource = bsource2;

                


            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message, "Error!");
            }
           
        }

        private void customerdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerdataview.Rows[e.RowIndex];
                email = row.Cells["email"].Value.ToString();
                emaillbl.Text = row.Cells["mail"].Value.ToString();
                namelbl.Text = row.Cells["name"].Value.ToString();
                contactlbl.Text = row.Cells["contact"].Value.ToString();

                dpnl.Visible = true;
                Cursor = Cursors.WaitCursor;
                readdetails();
                ppnl.Visible = true;
                Cursor = Cursors.Arrow;

            }
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt1);
            dv.RowFilter = string.Format("mail LIKE '%{0}%'", emailtxt.Text);
            customerdataview.DataSource = dv;
        }




        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt1);
            dv.RowFilter = string.Format("name LIKE '%{0}%'", usertxt.Text);
            customerdataview.DataSource = dv;
        }

    }
}
