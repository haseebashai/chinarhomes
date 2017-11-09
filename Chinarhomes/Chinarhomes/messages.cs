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
    public partial class messages : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        DataTable dt;
       
        BindingSource bsource;

        public messages()
        {
            InitializeComponent();
        }

        private void readmsgs()
        {
            try
            {
                dr = obj.Query("SELECT customer.mail,messages.*  FROM chinarhomes.messages inner join customer on customer.email=messages.email");
                dt = new DataTable();
                dt.Load(dr);
                obj.closeConnection();
                bsource = new BindingSource();
                bsource.DataSource = dt;
                messagesdataview.DataSource = bsource;
                messagesdataview.Columns["email"].Visible = false;
                messagesdataview.Columns["messageid"].Visible = false;
            }
            catch (Exception ex)
            {
                obj.closeConnection();
                MessageBox.Show(ex.Message, "Error!");
            }
        }


        private void messagesdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.messagesdataview.Rows[e.RowIndex];
                midlbl.Text = row.Cells["messageid"].Value.ToString();
                emaillbl.Text = row.Cells["mail"].Value.ToString();
                sublbl.Text = row.Cells["subject"].Value.ToString();
                msgtxt.Text = row.Cells["message"].Value.ToString();
                mpnl.Visible = true;



            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {

       /*     mail ml = new mail(emaillbl.Text, sublbl.Text, msgtxt.Text, midlbl.Text);
            ml.ShowDialog();
            readmsgs();
            messagesdataview.DataSource = bsource; */
        }

        private void messages_Load(object sender, EventArgs e)
        {
            readmsgs();
        }
    }
}
