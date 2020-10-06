using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
               A = Convert.ToDouble(textBox1.Text);
               B = Convert.ToDouble(textBox2.Text);
                c = A + B;
                textBox3.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
               A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                c = A - B;
                textBox3.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                A = Convert.ToDouble(textBox1.Text);
               B = Convert.ToDouble(textBox2.Text);
                c = A * B;
                textBox3.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                A = Convert.ToDouble(textBox1.Text);
               B = Convert.ToDouble(textBox2.Text);
                c = A / B;
                textBox3.Text = c.ToString();
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
