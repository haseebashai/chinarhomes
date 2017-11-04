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
            properties prop = new properties();
            prop.TopLevel = false;
            cntpnl.Controls.Clear();
            cntpnl.Controls.Add(prop);
            prop.Show();
            
        }
    }
}
