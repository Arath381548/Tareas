using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIBLES
            int operacion, resp;
            double num1, num2, respuesta;

            //CICLO DE REGRESO
            do
            {
                Console.Clear();
                //LISTA DE OPERACIONES
                Console.WriteLine("LISTA DE OPERACIONES");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1.- SUMA");
                Console.WriteLine("2.- RESTA");
                Console.WriteLine("3.- MULTIPLICACION");
                Console.WriteLine("4.- DIVICION");
                Console.WriteLine("------------------------------");

                //SELECCION DE OPERACIONES
                Console.WriteLine("Que operacio deseas");
                operacion = Convert.ToInt32(Console.ReadLine());

                //FUNCIONES DE LAS OPERACIONES
                //REALIZA OPERACION
                switch (operacion)
                {
                    //CASO 1, SUMA LA CANTIDAD 1 CON LA CANTIDAD 2
                    case 1:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("SUMA");
                        Console.WriteLine("------------------------------");
                        Console.Write("Insertar numero 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insertar numero 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        respuesta = num1 + num2;
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Su resultado es: " + respuesta);
                        Console.WriteLine("------------------------------");
                        break;

                        //CASO 2, RESTA LA CANTIDA 1 A LA 2
                    case 2:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(" resta");
                        Console.WriteLine("------------------------------");
                        Console.Write("Insertar numero 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insertar numero 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        respuesta = num1 - num2;
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Su resultado es: " + respuesta);
                        Console.WriteLine("------------------------------");
                        break;

                        //CASO 3, MULTIPLICA LA CANTIDAD 1 CON LA 2
                    case 3:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("MULTIPLICACION");
                        Console.WriteLine("------------------------------");
                        Console.Write("Insertar numero 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insertar numero 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        respuesta = num1 * num2;
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Su resultado es: " + respuesta);
                        Console.WriteLine("------------------------------");
                        break;

                        //CASO 4, DIVIDE LA CANTIDAD 1 ENTRE LA CANTIDAD 2
                    case 4:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("DIVICION");
                        Console.WriteLine("------------------------------");
                        Console.Write("Insertar numero 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Insertar numero 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        //EN CASO QUE EL SEGUNDO NUMERO SEA DIFERENTE A 0 OBTENDRA UNA RESPUESTA

                        if (num2 != 0)
                        {
                            respuesta = num1 / num2;
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Su resultado es: " + respuesta);
                            Console.WriteLine("------------------------------");
                            break;
                        }

                        //EN CASO DE SER CERO SALTARA UN ERROR
                        else
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Divicion por cero no permitida");
                            Console.WriteLine("------------------------------");
                            break;
                        }

                        //EN CASO DE NO SELECIONAR ALGUNA OPERACION OFRECIDA SE TOMARA COMO OPERACION NO SELECCIONADA
                    default:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("OPERACION NO SELECCIONADA");
                        Console.WriteLine("------------------------------");
                        break;
                }
                //FUNCION DE SALIDA
                Console.WriteLine("PRECIONA ´0´ PARA SALIR,");
                Console.WriteLine("OTRO NUMERO PARA CONTINUAR");
                Console.WriteLine("------------------------------");
                resp = Convert.ToInt32(Console.ReadLine());
            } while (resp != 0);
        }
    }
}
