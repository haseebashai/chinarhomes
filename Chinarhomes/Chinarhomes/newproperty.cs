using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace Chinarhomes
{
    public partial class newproperty : Form
    {
        List<string> pics = new List<string>();


        private dialogcontainer dg = null;
        public newproperty(Form dgcopy)
        {
            dg = dgcopy as dialogcontainer;
            InitializeComponent();
        }
     
        private void updbtn_Click(object sender, EventArgs e)
        {

            string cmd = "INSERT INTO `chinarhomes`.`properties` (`location`, `tags`, `type`, `noofstories`, `noofrooms`, `area`,"+
                "`areaofbuilt`, `price`, `priority`, `description`, `timestampp`, `distancefrommain`, `age`, `furnished`, `verified`,"+
                "`email`, `saletype`) VALUES ('a', 'a', 'a', 'a', 'a', 'a', 'aqa',"+
                "'a', 'a', 'a', '', 'a', 'a', 'a', 'a', '258efdc003a5c43825f73ff845ca1348', 'a')";
            


           foreach(string adr in pics)
            {
                MessageBox.Show(adr);
            }
        }

        private void clearpicbtn_Click(object sender, EventArgs e)
        {
            pics.Clear();
            flowpnl.Controls.Clear();
            flowpnl.Visible = false;
            updbtn.Visible = false;
            cancelbtn.Visible = false;
            clearpicbtn.Visible = false;
        }

        private void updpicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG|" + "All files (*.*)|*.*";

         
            fd.Multiselect = true;
            fd.Title = "Image Browser";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                
                foreach (String file in fd.FileNames)
                {
                   
                    try
                    {
                        pics.Add(file);
                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = 182;
                        pb.Width = 242;
                        pb.Image = loadedImage;
                        flowpnl.AutoScroll = true;
                        flowpnl.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                       
                            MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace);
                             pics.Remove(pics.Last());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                         + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                        pics.Remove(pics.Last());
                    }
                    if (pics.Count > 0)
                    {
                        flowpnl.Visible = true;
                        updbtn.Visible = true;
                        cancelbtn.Visible = true;
                        clearpicbtn.Visible = true;
                    }
        }

            }

        }

     
    }
}
