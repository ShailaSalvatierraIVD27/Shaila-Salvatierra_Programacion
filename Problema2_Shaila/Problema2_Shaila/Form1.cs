using Microsoft.VisualBasic.Devices;
using System;

namespace Problema2_Shaila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
            textBox3.Text = "1";
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            comboBox1.Text= "Seleccione Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int factura, unidades;
            decimal precio, subtotal, descuento, total;

           
            if (!int.TryParse(textBox1.Text, out factura) ||
                comboBox1.SelectedIndex == -1 ||
                !int.TryParse(textBox3.Text, out unidades) ||
                unidades <= 0 ||
                !decimal.TryParse(textBox2.Text, out precio))
            {
                MessageBox.Show("Ingrese todos los datos correctamente");
                return;
            }

            subtotal = precio * unidades;

            if (radioButton1.Checked)
            {
                descuento = subtotal * 0.05m;
            }
            else if (radioButton2.Checked)
            {
                descuento = 0;
            }
            else
            {
                MessageBox.Show("Seleccione si desea aplicar descuento");
                return;
            }

            total = subtotal - descuento;

            

            MessageBox.Show("Factura No. " + factura +
                            "\nProducto: " + comboBox1.Text +
                            "\nSubtotal: Q. " + subtotal.ToString("0.00") +
                            "\nDescuento: Q. " + descuento.ToString("0.00") +
                            "\nTotal a pagar: Q. " + total.ToString("0.00"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Teclado Q.125.00")
            {
                textBox2.Text = "125";
            }
            else if (comboBox1.Text == "Mouse Q.75.00")
            {
                textBox2.Text = "75";
            }
            else if (comboBox1.Text == "Audifonos Q.150.00")
            {
                textBox2.Text = "150";
            }
            else if (comboBox1.Text == "USB Q.60.00")
            {
                textBox2.Text = "60";
            }
            else if (comboBox1.Text == "Memoria RAM Q.350.00")
            {
                textBox2.Text = "350";
            }
        }
    }
}
