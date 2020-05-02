using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms11Exercise2
{
    public partial class Form1 : Form
    {
        const int MAX = 10;
        int[] numbers = new int[MAX];
        int location;

        public Form1()
        {
            InitializeComponent();
        }
        private void nextNumberBtn_Click(object sender, EventArgs e)
        {
            if (location >= MAX)
            {
                numberLbl.ForeColor = Color.Red;
            }
            else
            {
                numberLbl.Text = numbers[location].ToString();
                location++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < MAX; i++)
            {
                numbers[i] = r.Next(100) + 1;
            }
            location = 0;
        }


    }
}
