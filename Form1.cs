using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,4";
            textBox2.Text = "0,74";
            textBox3.Text = "19,43";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);

            textBox4.Text +=
            "Лаб.Раб №2 ";

            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
            "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
            "Z = " + z.ToString();
            double a = Math.Tan(x - y) *
           Math.Tan(x + y);
            a = Math.Exp(a);
            double b = Math.Exp(y + z);
            double c = Math.Sqrt(Math.Cos(x * x) +
            Math.Sin(z * z));
            double u = a - b * c;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine +
            "Результат U = " + u.ToString();
        }
    }
}
