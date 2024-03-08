using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematicas
{
    class Program
    {
        //guardara datos
        static void Main(string[] args)
        {
            int exit, figura, calculo, triangulo;
            double largo, ancho, radio, perimetro, area;


            do
            {
                Console.Clear();//limpia la memoria


                //escribe en la consola
                Console.WriteLine("CALCULAR");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1.AREA");
                Console.WriteLine("2.PERIMETRO");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Que deseas hacer");

                //Lee el numero ingresado para tomar una decision
                calculo = Convert.ToInt32(Console.ReadLine());

                switch (calculo)
                {
                    //en caso de seleccionar 1 mostrara las siguientes opciones con la posibilidad de seleccionar una
                    case 1:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("AREA-FIGURAS");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("1.-CUADRADO");
                        Console.WriteLine("2.-RECTANGULO");
                        Console.WriteLine("3.-CIRCULO");
                        Console.WriteLine("4.-TRIANGULO");
                        Console.WriteLine("------------------------------");

                        //Lee el dato ingresado para filtrar la informacion
                        figura = Convert.ToInt32(Console.ReadLine());
                        switch (figura)
                        {
                            case 1://en caso de seleccionar 1
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("CUADRADO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar lado: ");
                                largo = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo tomara como dato almacenado en "largo"
                                area = largo * largo;//multiplicara lado por lado y lo guardara en area
                                Console.Write("El area es " + area + " u²");//muestra el area
                                Console.WriteLine("");
                                break;
                            case 2://en caso de seleccionar 2
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("RECTANGULO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar largo: ");
                                largo = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo almacenara como largo
                                Console.Write("Insertar ancho: ");
                                ancho = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo almacenara como ancho
                                if (largo != ancho)//en caso que el largo sea diferente al ancho los multiplicara y mostrara un resultado
                                {
                                    area = largo * ancho;
                                    Console.Write("El area es " + area + " u²");
                                    Console.WriteLine("");
                                }
                                else//en caso de ser iguales te papeara
                                {
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("SI PA PENDEJO NO SE ESTUDIA");
                                    Console.WriteLine("------------------------------");
                                }
                                break;
                            case 3://en caso de seleccionar 3
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("CIRCULO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar radio: ");
                                radio = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado
                                largo = radio * radio;//Multiplicara radio por radio (equivalencia de radio al cuadrado) y lo almacenara como largo
                                area = 3.1416 * largo;//Multiplica el largo por pi para sacar el area
                                Console.Write("El area es " + area + " u²");
                                Console.WriteLine("");
                                break;
                            case 4://en caso de seleccionar 4
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("TRIANGULO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar altura: ");
                                largo = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo almacenara como altura
                                Console.Write("Insertar base: ");
                                ancho = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo almacenara como ancho
                                radio = largo * ancho;//Multiplicara el largo por el ancho y lo guardara
                                area = radio / 2;//Divide el resultado anterior entre 2 para sacar el area
                                Console.Write("El area es " + area + " u²");
                                Console.WriteLine("");
                                break;
                        }
                        break;
                    case 2://En caso de seleccionar 2 
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("PERIMETRO-FIGURAS");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("1.-CUADRADO");
                        Console.WriteLine("2.-RECTANGULO");
                        Console.WriteLine("3.-CIRCULO");
                        Console.WriteLine("4.-TRIANGULO");
                        Console.WriteLine("------------------------------");

                        //Leera el dato para filtrarlo
                        figura = Convert.ToInt32(Console.ReadLine());
                        switch (figura)
                        {
                            case 1://En caso de seleccionar 1
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("CUADRADO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar lado: ");
                                largo = Convert.ToDouble(Console.ReadLine());//Leera el dato y lo guardara como largo
                                perimetro = largo * 4;//Multiplica el lagro por 4
                                Console.Write("El perimetro es " + perimetro + " u");
                                Console.WriteLine("");
                                break;
                            case 2://En caso de seleccionar 2
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("RECTANGULO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar largo: ");
                                largo = Convert.ToDouble(Console.ReadLine());//Leera el dato y lo guardara como largo
                                Console.Write("Insertar ancho: ");
                                ancho = Convert.ToDouble(Console.ReadLine());//Leera el dato y lo guardara como ancho
                                if (largo != ancho)//si el largo es diferente al ancho
                                {//multiplicara el area y el ancho por 2 y los sumara para mostrar el perimetro
                                    area = largo * 2;
                                    radio = ancho * 2;
                                    perimetro = area + radio;
                                    Console.Write("El perimetro es " + perimetro + " u");
                                    Console.WriteLine("");
                                }
                                else//en caso de ser iguales el ancho y largo te papeara
                                {
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("SI PA PENDEJO NO SE ESTUDIA");
                                    Console.WriteLine("------------------------------");
                                }
                                break;
                            case 3://en caso de seleccionar 3
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("CIRCULO");
                                Console.WriteLine("------------------------------");
                                Console.Write("Insertar radio: ");
                                radio = Convert.ToDouble(Console.ReadLine());//Leera el dato ingresado y lo guardara como radio
                                largo = radio * 2;//Multiplicara el radio por 2 para sacar el diametro
                                perimetro = 3.1416 * largo;//Multiplicara el diametro por pi para sacar el perimetro
                                Console.Write("El perimetro es " + perimetro + " u");
                                Console.WriteLine("");
                                break;
                            case 4://En caso de seleccionar 4
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("PERIMETRO-TRIANGULO");
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("1.-EQUILATERO");
                                Console.WriteLine("2.-ISOSCELES");
                                Console.WriteLine("3.-ESCALENO");
                                Console.WriteLine("------------------------------");
                                triangulo = Convert.ToInt32(Console.ReadLine());//Leera el dato para filtrarlo
                                switch (triangulo)
                                {
                                    case 1://en caso de ser 1
                                        Console.WriteLine("------------------------------");
                                        Console.WriteLine("PERIMETRO-TRIANGULO-EQUILATERO");
                                        Console.WriteLine("------------------------------");
                                        Console.Write("Insertar lado: ");
                                        largo = Convert.ToDouble(Console.ReadLine());//Preguntara por 1 lado y lo multiplicara por 3
                                        perimetro = largo * 3;
                                        Console.Write("El perimetro es " + perimetro + " u");//escribe el resultado
                                        Console.WriteLine("");
                                        break;
                                    case 2://en caso de ser 2
                                        Console.WriteLine("------------------------------");
                                        Console.WriteLine("PERIMETRO-TRIANGULO-ISOSCELES");
                                        Console.WriteLine("------------------------------");
                                        Console.Write("Insertar largo: ");
                                        largo = Convert.ToDouble(Console.ReadLine());//Leera el largo del triangulo
                                        Console.Write("Insertar ancho: ");
                                        ancho = Convert.ToDouble(Console.ReadLine());//Leera el ancho del triangulo
                                        if (largo != ancho)
                                        {
                                            area = largo * 2;
                                            radio = ancho * 2;
                                            perimetro = area + radio;
                                            Console.Write("El perimetro es " + perimetro + " u");
                                            Console.WriteLine("");
                                        }
                                        else//te papeara
                                        {
                                            Console.WriteLine("------------------------------");
                                            Console.WriteLine("SI PA PENDEJO NO SE ESTUDIA");
                                            Console.WriteLine("------------------------------");
                                        }
                                        break;


                                }
                                break;

                        }
                        break;
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("PRECIONA ´0´ PARA SALIR,");
                Console.WriteLine("OTRO NUMERO PARA CONTINUAR");
                Console.WriteLine("------------------------------");
                exit = Convert.ToInt32(Console.ReadLine());//si escribe 0 saldra del sistema
            } while (exit != 0);//si preciona otro numero que no sea 0 seguira con el programa
        }
    }
}

