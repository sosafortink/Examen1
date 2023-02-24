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
    public partial class Form2 : Form
    {
     double subtotalprincipal = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //agregar producti
        {
            string producto = textBox1.Text;
            double precio = Convert.ToDouble(textBox2.Text);
            double cantidad = Convert.ToDouble(textBox3.Text);
            double subtotal = precio * cantidad;

            listBox1.Items.Add("Producto: "+producto+" precio: "+precio+" cantidad: "+" === "+subtotal);
           
            subtotalprincipal += subtotal;

            if (listBox1.Items.Count >= 2)
            {
                button2.Enabled = true;
            }

        }

        private async void button2_Click(object sender, EventArgs e) //calcular total
        {
            
            double descuento =  await descuentoAsync(subtotalprincipal);
            double total = subtotalprincipal - descuento;

            MessageBox.Show("su total a pagar es: " + total + "\nEl descuento total en su compra es: " + descuento);
        }

        private async Task<double> descuentoAsync(double subtotal)
        {
            double descuento = await Task.Run(() => { return subtotal * 0.015; });
            return descuento;
        }
    }
}
