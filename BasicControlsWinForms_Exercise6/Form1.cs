using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControlsWinForms_Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            textBox1.Text = checkedButton.Text;
        }
    }
}
