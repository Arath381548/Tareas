using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//nombre del proyecto
namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //metodo que se ejecuta cuando clickeas en ejecutar
        private void Ejecutar_Click(object sender, EventArgs e)
        {
           double res = 0;//almacenamiento del resultado

            //convierte los valores en un double
           if (double.TryParse(num1.Text, out double d1) &&
           double.TryParse(num2.Text, out double d2))
            {
                //obtiene el tipo de operacion a realizar
                char op = operador.Text[0];

                switch (op)//seleccion de opeeracien en relacion de la operacion ingresada
                {
                    case '+':
                        res = d1 + d2;//suma
                        break;

                    case '-':
                        res = d1 - d2;//resta
                        break;

                    case '*':
                        res = d1 * d2;//multiplicacion
                        break;

                    case '/':
                        if (d1 != 0)//divicion
                        {
                            res = d1 / d2;
                        }
                        else
                        {//error en caso que se divida entre cero
                            Console.WriteLine("error: division por cero no permitida");
                            Console.ReadLine();
                            return;
                        }
                        break;
                    default://caso en el que no se ingrese un operador valido
                        Console.WriteLine("error operador no valido");
                        Console.ReadLine();
                        return;

                }
                resultado.Text = res.ToString();//escribe el resultado
                Console.ReadLine();
            }
            else
            {
                MessageBox.Show("Ingrese números válidos en los TextBox.");
            }//caso en el que no se ingresen numeros saltara un aviso

        }
        //se abrio por error :v
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
