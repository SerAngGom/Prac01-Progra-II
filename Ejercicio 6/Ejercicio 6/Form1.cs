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
        bool encendido;
        
        public Form1()
        {
            InitializeComponent();
            DesacTecla();
            encendido = false;
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
            if (encendido== false) 
            {
                ActTecla();
                encendido = true;
            }
            else
            {
                DesacTecla();
                textBox1.Text = "";
                operacion = "";
                encendido = false;
            }
            
        }
        public void ActTecla()
        {
            tecla1.Enabled = true;
            tecla2.Enabled = true;
            tecla3.Enabled = true;
            tecla4.Enabled = true;
            tecla5.Enabled = true;
            tecla6.Enabled = true;
            tecla7.Enabled = true;
            tecla8.Enabled = true;
            tecla9.Enabled = true;
            tecla0.Enabled = true;
            teclapunto.Enabled = true;
            teclacambio.Enabled = true;
            teclamas.Enabled = true;
            teclamenos.Enabled = true;
            teclamult.Enabled = true;
            tecladiv.Enabled = true;
            teclaigual.Enabled = true;
            teclaCE.Enabled = true;
        }
        public void DesacTecla()
        {
            tecla1.Enabled = false;
            tecla2.Enabled = false;
            tecla3.Enabled = false;
            tecla4.Enabled = false;
            tecla5.Enabled = false;
            tecla6.Enabled = false;
            tecla7.Enabled = false;
            tecla8.Enabled = false;
            tecla9.Enabled = false;
            tecla0.Enabled = false;
            teclapunto.Enabled = false;
            teclacambio.Enabled = false;
            teclamas.Enabled = false;
            teclamenos.Enabled = false;
            teclamult.Enabled = false;
            tecladiv.Enabled = false;
            teclaigual.Enabled = false;
            teclaCE.Enabled = false;
        }
    }
}