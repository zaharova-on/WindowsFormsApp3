using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Green;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkCyan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, " + textBox1.Text + "!");
        }
    }
}
