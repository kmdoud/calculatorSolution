using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            var userInput = input1.Text;
            var userresult1 = int.Parse(userInput);
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            var userInput = input1.Text;
            var userresult = int.Parse(userInput);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            total.Text = (int.Parse(input1.Text) + int.Parse(input2.Text)).ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            total.Text = (int.Parse(input1.Text) - int.Parse(input2.Text)).ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            total.Text = (int.Parse(input1.Text) * int.Parse(input2.Text)).ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            total.Text = (int.Parse(input1.Text) / int.Parse(input2.Text)).ToString();
        }
    }
}
