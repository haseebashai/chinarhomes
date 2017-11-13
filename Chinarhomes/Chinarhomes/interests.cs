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
    public partial class interests : Form
    {
        DBConnect obj = new DBConnect();
        MySqlDataReader dr;
        string name,contact,encemail,url="http://chinarhomes.com/chinarhomes/pictures/";

        public interests()
        {
            InitializeComponent();
        }
        private void readinterests()
        {
            dr = obj.Query("select mail from customer");
           
            DataTable dt = new DataTable();
            dt.Columns.Add("mail", typeof(String));
            dt.Load(dr);
            
           
            obj.closeConnection();
            custlist.DisplayMember = "mail";
            custlist.DataSource = dt;
            custlist.SelectedItem = 0;


        }

        private void custlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> properties = new List<string>();

            dr = obj.Query("select name,contact,email from customer");
            dr.Read();
            name = dr[0].ToString();
            contact = dr[1].ToString();
            encemail = dr[2].ToString();
            obj.closeConnection();
            
            namelbl.Text = name;
            conlbl.Text = contact;
            emaillbl.Text = custlist.Text;

            dr = obj.Query("select propertyid from interested where email ='" + encemail + "'");
            while (dr.Read())
            {
                properties.Add(dr[0].ToString());

            }
          
            obj.closeConnection();
           

            foreach (String property in properties)
            {
                
                dr = obj.Query("select location,picture,area,price from properties where propertyid='" + property + "' ");
                dr.Read();


                CustomControl c = new CustomControl(
                new PictureBox {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = url + dr[1].ToString(),
                    Height = 150,
                    Width = 220, },
                new TextBox {
                    Text = dr[0].ToString() + "\r\n" + "Area: " + dr[2].ToString() + "\r\n" + "Price: " + dr[3].ToString(), Size = new Size(220, 70),
                    Multiline = true, ReadOnly = true});

                    iflowpnl.AutoScroll = true;
                    iflowpnl.Controls.Add(c);
                    obj.closeConnection();
      
            }
            dpnl.Visible = true;
        }

        private void interests_Load(object sender, EventArgs e)
        {
            readinterests();
           
            
        }
    }
    public class CustomControl : Control
    {
        private PictureBox pb;
        private TextBox label;
        public CustomControl(PictureBox pic, TextBox lbl)
        {
            pb = pic;
            label = lbl;
            Height = pb.Height + lbl.Height;
            Width = Math.Max(pb.Width, lbl.Width);
            Controls.Add(pb);
            pb.Location = new Point(0, 0);
            Controls.Add(lbl);
            lbl.Location = new Point(0, pb.Height);
            
           
        }
    }
}
