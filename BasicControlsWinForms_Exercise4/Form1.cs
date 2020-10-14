using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Text = "Calculate";
                double op1 = double.Parse(textBox1.Text);
                double op2 = double.Parse(textBox2.Text);
                if (textBox4.Text == "+")
                {
                    textBox3.Text = (op1 + op2).ToString();
                }
                else
                {
                    textBox3.Text = (op1 - op2).ToString();
                }
            }
            catch (Exception)
            {
                button3.Text = "Fill all the fields!";
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
