using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void DrawEvery100()
        {
            while (true)
            {
                timeLbl.Text = DateTime.Now.Millisecond.ToString();
                timeLbl.ForeColor = DateTime.Now.Millisecond % 2 == 0 ? Color.Green : Color.Red;
                await Task.Run(() => { Thread.Sleep(100); });
            }

        }

        private void ElapsedEventHandler(object sender, ElapsedEventArgs e)
        {
            Action action = () => {
                timeLbl.Text = DateTime.Now.Millisecond.ToString();
                timeLbl.ForeColor = DateTime.Now.Millisecond % 2 == 0 ? Color.Green : Color.Red;
            };
            timeLbl.BeginInvoke(action);
        }
        private void displayTimeBtn_Click(object sender, EventArgs e)
        {
            // Option 1
            
            if (timer == null)
            {
                timer = new System.Timers.Timer(100);
                timer.Elapsed += ElapsedEventHandler;
                timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Timer already on!");
            }
            
            DrawEvery100();
        }
    }
}
