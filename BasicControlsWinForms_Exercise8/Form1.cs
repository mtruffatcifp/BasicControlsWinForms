using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Insert(0, "Rian Hurst");
            listBox1.Items.Insert(1, "Kimberly Corbett");
            listBox1.Items.Insert(2, "Maaria Ridley");
            listBox1.Items.Insert(3, "Antonina Rennie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Insert(0, "Zach Steadman");
            listBox1.Items.Insert(1, "Tiffany Benton");
            listBox1.Items.Insert(2, "Jadine Mason");
            listBox1.Items.Insert(3, "Aaliya Burton");
            listBox1.Items.Insert(4, "Ariya Holcomb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
