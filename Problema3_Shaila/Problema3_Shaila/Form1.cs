namespace Problema3_Shaila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empleado, categoria;
            int anios;
            decimal sueldoBase, sueldoTotal;


            empleado = textBox1.Text;
            categoria = comboBox1.Text;


            if (empleado == "" ||
                !int.TryParse(textBox2.Text, out anios) ||
                anios < 0 ||
                categoria == "")
            {
                MessageBox.Show("Ingrese todos los datos correctamente");
                return;
            }

            if (categoria == "A")
            {
                sueldoBase = 3000;
            }
            else
            {
                sueldoBase = 2500;
            }

            sueldoTotal = sueldoBase + (anios * 30);

            textBox4.Text = empleado;
            textBox3.Text = anios.ToString();
            textBox6.Text = categoria;
            textBox5.Text = sueldoTotal.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
