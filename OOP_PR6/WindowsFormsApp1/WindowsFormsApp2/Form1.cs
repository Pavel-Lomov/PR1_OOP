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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          //  dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
           // dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            int n = Convert.ToInt32(numericUpDown1.Value);//побочная диагональ квадратной матрицы
            int[,] mas = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i+j==n-1)
                    {
                        mas[i, j] =0;
                    }
                    if (i+j<n-1)
                    {
                        mas[i, j] = -1;
                    }
                    if (i+j>n-1)
                    {
                        mas[i, j] =1 ;
                    }
                    dataGridView1[i, j].Value = mas[i, j].ToString();
                }
            }
        }
    }
}
