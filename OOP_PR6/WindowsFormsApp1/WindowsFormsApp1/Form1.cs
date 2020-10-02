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
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] mas = new double[dataGridView2.ColumnCount];
            int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            int i, j;
            for (i = 0; i < dataGridView1.RowCount; i++)
                for (j = 0; j < dataGridView1.ColumnCount; j++)
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                mas[i] = 0;
                for (j = 0; j < dataGridView1.ColumnCount; j++)
                    mas[i] += A[i, j];
                mas[i] /= dataGridView1.ColumnCount;
            }
            i = 0;
            while (i < dataGridView1.ColumnCount - 1)
                if (mas[i] > mas[i + 1])
                {
                    double temp = mas[i];
                    mas[i] = mas[i + 1];
                    mas[i + 1] = temp;
                    if (i > 0)
                        i--;
                    else
                        i++;
                }
                else
                    i++;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView2[i, 0].Value = mas[i].ToString();

        }
    }
}


