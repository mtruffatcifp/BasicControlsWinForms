using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String op1, op2, op3 = op2 = op1 = "";
            if (checkBox1.Checked == true)
            {
                op1 = "mouse ";
            }
            if (checkBox2.Checked == true)
            {
                op2 = "cat ";
            }
            if (checkBox3.Checked == true)
            {
                op3 = "dog";
            }

            textBox1.Text = "Choosen: " + op1 + op2 + op3;
        }
    }
}
