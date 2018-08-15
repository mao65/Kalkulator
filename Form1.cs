using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string operator1 = string.Empty;
        string operator2 = string.Empty;
        string wyniki;
        char operatory;
        

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void jeden_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "1";
           
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text +="2";
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "3";
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "4";
        }

        private void piec_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "5";
        }

        private void szesc_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "6";
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "7";
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "8";
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
            wynik.Text = string.Empty;
            wynik.Text = wynik.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            
            wynik.Text = wynik.Text += "0";
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            operator1 = wynik.Text;
            operatory = '+';
            wynik.Text = string.Empty;
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            operator1 = wynik.Text;
            operatory = '-';
            wynik.Text = string.Empty;
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            operator1 = wynik.Text;
            operatory = '*';
            wynik.Text = string.Empty;
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            operator1 = wynik.Text;
            operatory = '/';
            wynik.Text = string.Empty;
        }

        private void kasuj_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
        }

        private void wyn1_Click(object sender, EventArgs e)
        {
            operator2 = wynik.Text;
            double opr1;
            double opr2;
            double.TryParse(operator1, out opr1);
            double.TryParse(operator2, out opr2);

            switch(operatory)
            {
                case '+':
                    wyniki = (opr1 + opr2).ToString();
                    break;
                case '-':
                    wyniki = (opr1 - opr2).ToString();
                    break;
                case '*':
                    wyniki = (opr1 * opr2).ToString();
                    break;
                case '/':
                    if(opr2!=0)
                    {
                        wyniki = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nie można podzielić przez 0");
                    }
                    break;
                
            }
            wynik.Text = wyniki.ToString();
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            wynik.Text = wynik.Text + ".";
        }
    }
}
