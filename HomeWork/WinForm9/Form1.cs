using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button clicked!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            int num1;
            bool tryint = false;
            bool tryint1 = false;

            tryint = int.TryParse(lowerLimitTxtBx.Text, out num);
            if (!tryint)
            {
                label1.Text = "please enter a number";
            }
            else
            {
                label1.Text = "?";
            }

            tryint1 = int.TryParse(upperLimitTxtBx.Text, out num1);

            if (num > num1)
            {
                label1.Text = "The second number needs to be greater than the first number Try again";
            }
            else
            {
                label1.Text = "?";
            }
            if (tryint && tryint1 && num <= num1)
            {
                Random rnd = new Random();
                int month = rnd.Next(Convert.ToInt32(lowerLimitTxtBx.Text), Convert.ToInt32(upperLimitTxtBx.Text));
                label1.Text = "The new number random is : " + month.ToString();
                Debug.WriteLine($"The number found in the first txtBox is: {lowerLimitTxtBx.Text}");
                Debug.WriteLine($"The number found in the second  txtBox is: {upperLimitTxtBx.Text}");
                Debug.WriteLine($"The number drawn is: {month}");
            }
        }

        private void my_click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button clicked!");
        }

        private void zerofyBtn_Click(object sender, EventArgs e)
        {
            lowerLimitTxtBx.Text = 0.ToString();
            upperLimitTxtBx.Text = "0";

            label1.Text = "Zerofied!!";
        }


    }
}
