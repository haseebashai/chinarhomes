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
    public partial class container : Form
    {
        public container()
        {
            InitializeComponent();
        }

        private void container_Load(object sender, EventArgs e)
        {

           loginform lg = new loginform(this,this);
            lg.TopLevel = false;
            mainpnl.Controls.Clear();
            mainpnl.Controls.Add(lg);
            lg.Show(); 
        }
    }
}
