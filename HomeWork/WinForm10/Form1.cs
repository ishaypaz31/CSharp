using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool GetAB(out int a,out int b) 
        {
            if (int.TryParse(firstTxt.Text, out a)== false)
            {
                MessageBox.Show($"{firstTxt.Text}  is not an Integer number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                b = 0;
                return false;
            }
            if (int.TryParse(secondTxt.Text, out b) == false)
            {
                MessageBox.Show($"{secondTxt.Text}  is not an Integer number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                a = 0;
                return false;
            }
            return true;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultsLst.Items.Clear();
            System.Diagnostics.Debug.WriteLine("User cleared the list");
        }
        private void plusBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} + {b} = {a + b}");
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} * {b} = {a * b}");
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} - {b} = {a - b}");
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                if (b == 0)
                {
                    BackColor = Color.Red;
                }
                else
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                }
                resultsLst.Items.Add($"{a} / {b} = {a / (double)b}");
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumberA = r.Next(101);
            firstTxt.Text = $"{randomNumberA}";
            firstTxt.Text = "" + randomNumberA;
            firstTxt.Text = randomNumberA.ToString();
            firstTxt.Text = Convert.ToString(randomNumberA);

            int randomNumberB = r.Next(101);
            secondTxt.Text = $"{randomNumberB}";
            secondTxt.Text = "" + randomNumberB;
            secondTxt.Text = randomNumberB.ToString();
            secondTxt.Text = Convert.ToString(randomNumberB);
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} ^ {b} = {(Math.Pow(a, 1.0 / b))}");
            }
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} ^ {b} = {(Math.Pow(a,b))}"); 
            }
        }
    }
}
