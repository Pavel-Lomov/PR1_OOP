using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double X1 = Convert.ToDouble(textBox2.Text);
            double Y1 = Convert.ToDouble(textBox3.Text);
            double X2 = Convert.ToDouble(textBox4.Text);
            double b = Y1 - a * X1;
            double Y2 = a * X2 + b;
            textBox5.Text = Y2.ToString();
        }
    }
}
