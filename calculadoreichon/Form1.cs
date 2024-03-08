using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoreichon
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado2;

        private int operacion;


        public Form1()
        {
            InitializeComponent();
        }
        //boton del numero 0
        private void btn0_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "0";
        }
        //boton del numero 1
        private void btn1_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "1";
        }
        //boton del numero 2
        private void btn2_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "2";
        }
        //boton del numero 3
        private void btn3_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "3";
        }
        //boton del numero 4
        private void btn4_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "4";
        }
        //boton del numero 5
        private void btn5_Click(object sender, EventArgs e)
        {
 
            resultado.Text = resultado.Text + "5";
        }
        //boton del numero 6
        private void btn6_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "6";
        }
        //boton del numero 7
        private void btn7_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "7";
        }
        //boton del numero 8
        private void btn8_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "8";
        }
        //boton del numero 9
        private void btn9_Click(object sender, EventArgs e)
        {

            resultado.Text = resultado.Text + "9";
        }
        //boton de C para limpiar
        private void btnBorrar_Click(object sender, EventArgs e)
        {

            resultado.Text = "";
        }
        //boton del igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
 //swich de operaciones dependiendo la operacion puesta a realizar
            valor2 = Convert.ToDouble(resultado.Text);

            switch (operacion)
            {
                case 1:
                    resultado2 = valor1 + valor2;
                    break;

                case 2:
                    resultado2 = valor1 - valor2;
                    break;

                case 3:
                    resultado2 = valor1 * valor2;
                    break;

                case 4:
                    resultado2 = valor1 / valor2;
                    break;
            }

            resultado.Text = resultado2.ToString();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Text = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Text = "";

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //boton multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Text = "";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton division
            operacion = 4;
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Text = "";

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //boton punto
            resultado.Text = resultado.Text + ".";
        }
    }
}
