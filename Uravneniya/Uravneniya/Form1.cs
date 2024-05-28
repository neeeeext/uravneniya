using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uravneniya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox5.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double c = Convert.ToDouble(textBox7.Text);
            double x = Convert.ToDouble(textBox3.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double i = Convert.ToDouble(textBox6.Text);
            double result = 0;

            chart1.Series[0].Points.Clear();


            while (x <= y)
            {
               
                switch (comboBox1.Text)
                {
                    
                    case ("ax² + bx + c"):
                        result = a * Math.Pow(x, 2) + b * x + c;
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("sin(x)"):
                        result = Math.Sin(x);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("a * sin(x) + b"):
                        result = a * Math.Sin(x) + b;
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("cos(x)"):
                        result = Math.Cos(x);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("tg(x)"):
                        result = Math.Tan(x);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("2 * tg(x) + ba"):
                        result = 2 * Math.Tan(x) + b * a;
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("ax²"):
                        result = a * Math.Pow(x, 2);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("√x"):
                        result = Math.Sqrt(x);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("ctg(x)"):
                        result = 1 / Math.Tan(x);
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                    case ("ab + cos(x) - c"):
                        result = a * b + Math.Cos(x) - c;
                        this.chart1.Series[0].Points.AddXY(x, result);
                        x = x + i;
                        break;
                }
            }
        }
    }
}