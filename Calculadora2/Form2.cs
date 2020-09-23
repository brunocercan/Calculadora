using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form2 : Form
    {
        string n;//numero digitado
        string n1 = "";//junção dos numeros digitados
        string n2 = "";//numeros do textbox3
        string mod = "";//modificador
        
        public Form2()
        {
            InitializeComponent();

            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }

        private void Mostra(string n)
        {
            string texto1 = textBox1.Text;//numero 1
            string modificador = textBox2.Text;//Modificador
            string texto3 = textBox3.Text;//numero 2
            n1 = n;

            

            if (modificador == "")
            {
                
                if (texto1 == "")
                {

                    texto1 = n1;
                    textBox1.Text = texto1;

                    button11.Enabled = true;
                    button12.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    button17.Enabled = true;

                }
                else
                {
                    

                    texto1 = texto1 + n1;
                    textBox1.Text = texto1;
                }
            }
            else
            {
                n2 = n2 + n;
                textBox3.Text = n2;
                n2 = textBox3.Text;
                button13.Enabled = true;
            }

        }

        private void MostraMod(string mod)
        {
            switch (mod)
            {
                case "/":
                    textBox2.Text = "Divisão";
                    break;
                case "*":
                    textBox2.Text = "Multiplicação";
                    break;
                case "-":
                    textBox2.Text = "Subtração";
                    break;
                case "+":
                    textBox2.Text = "Soma";
                    break;
                default:
                    textBox2.Text = "";
                    break;
            }
        }

        #region Calculos
        private void button13_Click(object sender, EventArgs e)
        {
            MostraResultado(Calculos(textBox1.Text, mod, textBox3.Text));
        }
        private void MostraResultado(string res)
        {
            textBox4.Text = res;
        }
        private string Calculos(string numero1, string modificador, string numero2)//textbox1, textbox2, textbox3
        {
            double num1, num2, resuld;
            num1 = Double.Parse(numero1);
            num2 = Double.Parse(numero2);
           
            switch (mod)
            {
                case "/":
                    //Divisão
                    resuld = (num1 / num2);
                    break;
                case "*":
                    resuld = (num1 * num2);
                    break;
                case "-":
                    resuld = (num1 - num2);
                    break;
                case "+":
                    resuld = (num1 + num2);
                    break;
                default:
                    resuld = 0;
                    break;
            }
            return Convert.ToString(resuld);
        }

        #endregion

        #region Numeros
        private void button10_Click(object sender, EventArgs e)
        {
            n = "0";
            Mostra(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = "1";
            Mostra(n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = "2";
            Mostra(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = "3";
            Mostra(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = "4";
            Mostra(n);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n = "5";
            Mostra(n);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n = "6";
            Mostra(n);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n = "7";
            Mostra(n);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n = "8";
            Mostra(n);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n = "9";
            Mostra(n);
        }

        #endregion

        #region Modificadores
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            n1 = "";
            n2 = "";
            n = "";
            mod = "";

            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            mod = "/";
            MostraMod(mod);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mod = "*";
            MostraMod(mod);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mod = "-";
            MostraMod(mod);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mod = "+";
            MostraMod(mod);
        }

        #endregion

        
    }
}
