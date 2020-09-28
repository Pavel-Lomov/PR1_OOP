using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void button4_Click(object sender, EventArgs e)
        {
            int[] mas1 = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                mas1[i] = r.Next(-20, 20);
                //textBox1.Text += ("\r\n"+mas1[i] );
                textBox1.Text += (mas1[i] + Environment.NewLine);
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = textBox1.Lines.Length;
            int[] mas = new int[count];
            for (int i = 0; i < count - 1; i++)
            {
                mas[i] = Convert.ToInt32(textBox1.Lines[i]);
        
            }
            int min = 0;
            int max = 0;
            for (int i = 1; i < count; i++)
            {
                if ((min < mas[i]  && mas[i]<0) || (min==0 && mas[i] < 0))
                {
                    min = mas[i];
                }
            }
            if (min == 0)
            {
                textBox3.Text = ("Элемент не найден");
            }
            else
            {
                textBox3.Text = min.ToString();
            }

            for (int i = 1; i < count; i++)
            {
                if ((max > mas[i] && mas[i] > 0) || (max == 0 && mas[i] > 0))
                {
                    max = mas[i];
                }
            }
            if (max == 0)
            {
                textBox2.Text = ("Элемент не найден");
            }
            else
            {
                textBox2.Text = max.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button4.Enabled = true;
        }
    }
}  
