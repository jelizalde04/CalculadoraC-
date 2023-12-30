using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        double num1, num2;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }


        private void button14_Click(object sender, EventArgs e)
        {

            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
             tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbDisplay.Text);
            operacion = "Dividir";
            tbDisplay.Text = "";
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case "Sumar":                    tbDisplay.Text = calculadora.Operar(num1, num2, calculadora.Sumar).ToString();
                    break;
                case "Restar":
                    tbDisplay.Text = calculadora.Operar(num1, num2, calculadora.Restar).ToString();
                    break;
                case "Multiplicar":
                    tbDisplay.Text = calculadora.Operar(num1, num2, calculadora.Multiplicar).ToString();
                    break;
                case "Dividir":
                    tbDisplay.Text = calculadora.Operar(num1, num2, calculadora.Dividir).ToString();
                    break;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbDisplay.Text);
            operacion = "Sumar";
            tbDisplay.Text = "";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbDisplay.Text);
            operacion = "Restar";
            tbDisplay.Text = "";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbDisplay.Text);
            operacion = "Multiplicar";
            tbDisplay.Text = "";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }
    }

    public class Calculadora
    {
        public delegate double Operacion(double a, double b);

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public double Operar(double a, double b, Operacion operacion)
        {
            return operacion(a, b);
        }
    }
}
