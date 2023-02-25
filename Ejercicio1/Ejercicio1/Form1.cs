using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      //meses capital   interes
            InteresxMeses(12, 200000,Convert.ToDouble(0.015));
        }

        private void InteresxMeses(double meses, double capital,double inter)
        {

            for (int i = 0; i < meses; i++){
                listBox1.Items.Add("Interes del mes " + (i + 1) + ": " + Interes(capital, inter, i + 1));
                capital = capital + Interes(capital, inter, 0.0833333333333333);
            }
        }

        private double Interes(double C,double i, double t)
        {
            return C * i * t;
        }
    }
}
