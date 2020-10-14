using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(textBox1.Text);
            double op2 = double.Parse(textBox2.Text);
            if (textBox4.Text == "+")
            {
                textBox3.Text = (op1 + op2).ToString();
            } else
            {
                textBox3.Text = (op1 - op2).ToString();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == " +")
            {
                textBox4.Text = "+";
            }
            else if (listBox1.SelectedItem == " -")
            {
                textBox4.Text = "-";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
