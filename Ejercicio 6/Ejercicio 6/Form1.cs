using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        String operacion;
        bool TieneSigno;
        char signo;
        bool igual;
        DesacTecla();
        public Form1()
        {
            InitializeComponent();
        }
        private void tecla1_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "1";

        }

        private void tecla2_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void tecla3_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void tecla4_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void tecla5_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void tecla6_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void tecla7_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void tecla8_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void tecla9_Click(object sender, EventArgs e)
        {
            if (operacion != "" && textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            if (igual)
            {
                igual = false;
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void tecla0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void teclapunto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void teclacambio_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToDouble(textBox1.Text) > 0)
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
                else if (Convert.ToDouble(textBox1.Text) < 0)
                {
                    double n = Convert.ToDouble(textBox1.Text);
                    n *= -1;
                    textBox1.Text = Convert.ToString(n);
                }
            }
            else
            {
                textBox1.Text += "-";
            }

        }

        private void teclamas_Click(object sender, EventArgs e)
        {
            operacion += textBox1.Text;
            if (ContieneSigno(operacion))
            {
                double resultado = opera(operacion);
                textBox1.Text = Convert.ToString(resultado);
                operacion = Convert.ToString(resultado);
            }
            else textBox1.Text = "";
            operacion += "+";

        }

        private void teclamenos_Click(object sender, EventArgs e)
        {
            operacion += textBox1.Text;
            if (ContieneSigno(operacion))
            {
                double resultado = opera(operacion);
                textBox1.Text = Convert.ToString(resultado);
                operacion = Convert.ToString(resultado);
            }
            else textBox1.Text = "";
            operacion += "-";
        }

        private void teclamult_Click(object sender, EventArgs e)
        {
            operacion += textBox1.Text;
            if (ContieneSigno(operacion))
            {
                double resultado = opera(operacion);
                textBox1.Text = Convert.ToString(resultado);
                operacion = Convert.ToString(resultado);
            }
            else textBox1.Text = "";
            operacion += "*";
        }

        private void tecladiv_Click(object sender, EventArgs e)
        {
            operacion += textBox1.Text;
            if (ContieneSigno(operacion))
            {
                double resultado = opera(operacion);
                if (Convert.ToString(resultado) == "∞")
                {
                    textBox1.Text = "ERROR";
                }
                else
                {
                    textBox1.Text = Convert.ToString(resultado);
                    operacion = Convert.ToString(resultado);
                }
            }
            else textBox1.Text = "";
            operacion += "/";

        }

        private void teclaigual_Click(object sender, EventArgs e)
        {
            operacion += textBox1.Text;
            double resultado = opera(operacion);
            if (Convert.ToString(resultado) == "∞")
            {
                textBox1.Text = "ERROR";
            }
            else
            {
                textBox1.Text = Convert.ToString(resultado);
                operacion = "";
            }
            
            

        }

        private void teclaCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operacion = "";
        }
        public double opera(string operacion)
        {
            double num1 = 0;
            double num2 = 0;
            string aux = "";
            double resultado = 0;
            aux += operacion[0];
            int cont = 0;
            foreach (char i in operacion)
            {
                if (cont == 0) cont++;
                else if (i == '+' || i == '-' || i == '*' || i == '/')
                {
                    num1 = Convert.ToDouble(aux, CultureInfo.InvariantCulture);
                    signo = i;
                    aux = "";
                }
                else
                {
                    aux += i;
                }
            }
            num2 = Convert.ToDouble(aux, CultureInfo.InvariantCulture);

            if (signo == '+') resultado = num1 + num2;
            else if (signo == '-') resultado = num1 - num2;
            else if (signo == '*') resultado = num1 * num2;
            else if (signo == '/') resultado = num1 / num2;
            igual = true;
            return resultado;
        }
        public bool ContieneSigno(string operacion)
        {
            TieneSigno = false;
            char[] signos;
            signos = new char[4];
            signos[0] = '+';
            signos[1] = '-';
            signos[2] = '*';
            signos[3] = '/';
            foreach (char j in signos)
            {
                foreach (char i in operacion)
                {
                    if (i == j) return true;

                }
            }
            return TieneSigno;
        }

        private void teclaC_Click(object sender, EventArgs e)
        {
            ActTecla();
        }
        public void ActTecla()
        {
            tecla1_Click.Enabled = true;
            tecla2_Click.Enabled = true;
            tecla3_Click.Enabled = true;
            tecla4_Click.Enabled = true;
            tecla5_Click.Enabled = true;
            tecla6_Click.Enabled = true;
            tecla7_Click.Enabled = true;
            tecla8_Click.Enabled = true;
            tecla9_Click.Enabled = true;
            tecla0_Click.Enabled = true;
            teclapunto_Click.Enabled = true;
            teclacambio_Click.Enabled = true;
            teclamas_Click.Enabled = true;
            teclamenos_Click.Enabled = true;
            teclamult_Click.Enabled = true;
            tecladiv_Click.Enabled = true;
            teclaigual_Click.Enabled = true;
            teclaCE_Click.Enabled = true;
        }
        public void DesacTecla()
        {
            tecla1_Click.Enabled = false;
            tecla2_Click.Enabled = false;
            tecla3_Click.Enabled = false;
            tecla4_Click.Enabled = false;
            tecla5_Click.Enabled = false;
            tecla6_Click.Enabled = false;
            tecla7_Click.Enabled = false;
            tecla8_Click.Enabled = false;
            tecla9_Click.Enabled = false;
            tecla0_Click.Enabled = false;
            teclapunto_Click.Enabled = false;
            teclacambio_Click.Enabled = false;
            teclamas_Click.Enabled = false;
            teclamenos_Click.Enabled = false;
            teclamult_Click.Enabled = false;
            tecladiv_Click.Enabled = false;
            teclaigual_Click.Enabled = false;
            teclaCE_Click.Enabled = false;
        }
    }
}