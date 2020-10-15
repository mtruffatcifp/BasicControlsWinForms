using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 10; i+=2)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 1; i <= 10; i += 2)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem); ;
        }
    }
}
