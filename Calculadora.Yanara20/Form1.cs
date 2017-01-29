using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Yanara20
{
    public partial class Form1 : Form
    {
        double Numero1;
        double Numero2;
        double Result;
        String Operandos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Operandos = "+";
            Numero1 = double.Parse(txtSalida.Text);
            txtSalida.Clear();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Operandos = "-";
            Numero1 = double.Parse(txtSalida.Text);
            txtSalida.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Operandos = "*";
            Numero1 = double.Parse(txtSalida.Text);
            txtSalida.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Operandos = "/";
            Numero1 = double.Parse(txtSalida.Text);
            txtSalida.Clear();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "7";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtSalida.Text = txtSalida.Text + ".";
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = double.Parse(txtSalida.Text);

            switch (Operandos)
            {
                case "+": Result = Numero1 + Numero2;
                    txtSalida.Text = Result.ToString();
                    break;
                case "-": Result = Result = Numero1 - Numero2;
                    txtSalida.Text = Result.ToString();
                    break;
                case "*": Result = Numero1 * Numero2;
                    txtSalida.Text = Result.ToString();
                    break;
                case "/": Result = Numero1 / Numero2;
                    txtSalida.Text = Result.ToString();
                    break;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Operandos = "Sqrt";
            Numero1 = double.Parse(txtSalida.Text);
            Result = Numero1;
            txtSalida.Text = Math.Sqrt(Numero1).ToString();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            Operandos= "Seno";
            Numero1 = Double.Parse(txtSalida.Text) * Math.PI / 180.0;
            Result = Numero1;
            txtSalida.Text = Math.Sin(Numero1).ToString();
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            Operandos = "Coseno";
            Numero1 = Double.Parse(txtSalida.Text) * Math.PI / 180.0;
            Result = Numero1;
            txtSalida.Text = Math.Cos(Numero1).ToString();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            Operandos = "Tangente";
            Numero1 = Double.Parse(txtSalida.Text) * Math.PI / 180.0;
            Result = Numero1;
            txtSalida.Text = Math.Sin(Numero1).ToString();
        }
    }
}
