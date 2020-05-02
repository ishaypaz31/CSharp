using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms11Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redPnl_Click(object sender, EventArgs e)
        {
            helloWorldTxt.ForeColor = redPnl.BackColor;
        }

        private void greenPnl_Click(object sender, EventArgs e)
        {
            helloWorldTxt.ForeColor = greenPnl.BackColor;

        }

        private void bluePnl_Click(object sender, EventArgs e)
        {
            helloWorldTxt.ForeColor = bluePnl.BackColor;

        }

        private void yellowPnl_Click(object sender, EventArgs e)
        {
            helloWorldTxt.ForeColor = yellowPnl.BackColor;

        }
    }
}
