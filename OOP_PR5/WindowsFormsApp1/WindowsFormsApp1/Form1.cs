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
        public static double A = 0;
        public static double B = 0;
        public static double c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //A = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           //B = Convert.ToDouble(textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Enabled = true;
           // button1.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                c = A + B;
                textBox3.Text = c.ToString();
            }
            if (radioButton2.Checked == true)
            {
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                c = A - B;
                textBox3.Text = c.ToString();
            }
            if (radioButton3.Checked == true)
            {
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                c = A * B;
                textBox3.Text = c.ToString();
            }
            if (radioButton4.Checked == true)
            {
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                c = A / B;
                textBox3.Text = c.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
