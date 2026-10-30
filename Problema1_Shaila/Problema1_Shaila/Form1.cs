namespace Problema1_Shaila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal sueldo, bonificacion, descuento, pagoTotal;
            decimal porcentajeBonificacion, porcentajeDescuento;


            if (textBox1.Text == "" ||
                !decimal.TryParse(textBox2.Text, out sueldo) ||
                sueldo <= 0)
            {
                MessageBox.Show("Ingrese un nombre y un sueldo válido");
                return;
            }


            if (radioButton4.Checked)
            {
                if (radioButton1.Checked)
                {
                    porcentajeBonificacion = 0.08m;
                    porcentajeDescuento = 0.06m;
                }
                else if (radioButton2.Checked)
                {
                    porcentajeBonificacion = 0.10m;
                    porcentajeDescuento = 0.04m;
                }
                else
                {
                    MessageBox.Show("Seleccione el estado civil");
                    return;
                }
            }
            else if (radioButton3.Checked)
            {
                if (radioButton1.Checked)
                {
                    porcentajeBonificacion = 0.10m;
                    porcentajeDescuento = 0.04m;
                }
                else if (radioButton2.Checked)
                {
                    porcentajeBonificacion = 0.12m;
                    porcentajeDescuento = 0.03m;
                }
                else
                {
                    MessageBox.Show("Seleccione el estado civil");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seleccione el sexo");
                return;
            }


            bonificacion = sueldo * porcentajeBonificacion;

            descuento = (sueldo + bonificacion)
                        * porcentajeDescuento;

            pagoTotal = sueldo + bonificacion - descuento;


            textBox3.Text = bonificacion.ToString("0.00");
            textBox4.Text = descuento.ToString("0.00");
            textBox5.Text = pagoTotal.ToString("0.00");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
