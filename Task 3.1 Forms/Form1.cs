using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double dlina(double x1, double y1, double x2, double y2)
        {
            double D;
            D = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return D;
        }
        public static bool treug(double a, double b, double c)
        {
            bool f = false;
            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                f = true;
            }
            return f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] x = new double[4];
                double[] y = new double[4];
                for (int i = 0; i < 4; i++)
                {

                    x[0] = Convert.ToDouble(textBox1.Text);
                    y[0] = Convert.ToDouble(textBox2.Text);
                    x[1] = Convert.ToDouble(textBox3.Text);
                    y[1] = Convert.ToDouble(textBox4.Text);
                    x[2] = Convert.ToDouble(textBox5.Text);
                    y[2] = Convert.ToDouble(textBox6.Text);
                    x[3] = Convert.ToDouble(textBox7.Text);
                    y[3] = Convert.ToDouble(textBox8.Text);
                }
                int h = 0;
                int k = 0;
                for (int i = 0; i < 2; i++)
                {
                    double a = dlina(x[k], y[k], x[k + 1], y[k + 1]);
                    double b = dlina(x[k + 1], y[k + 1], x[k + 2], y[k + 2]);
                    double c = dlina(x[k + 2], y[k + 2], x[k], y[k]);
                    if (treug(a, b, c))
                    {
                        h++;
                    }
                    a = dlina(x[k], y[k], x[k + 1], y[k + 1]);
                    b = dlina(x[k + 1], y[k + 1], x[k + 3], y[k + 3]);
                    c = dlina(x[k + 3], y[k + 3], x[k], y[k]);
                    if (treug(a, b, c))
                    {
                        h++;
                    }
                }
                textBox9.Text = h.ToString();
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
