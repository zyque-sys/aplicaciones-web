using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica10_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int datoingo;
            string menu = "======Practicas del 1er corte==========" + "\n1.Numero Mayor" + "\n2.Inversion de numero dos cifras" + "\n 3.Inversion de numero tres cifras " + "\n4.Mayor de N numeros" + "\n5.Desglose de billetes" + "\n6.Tipos de triangulos" + "\n7.Dia de la semana" + "\n8.Calificacion" + "\n9. >Salir<";
            //int limiteee = int.MaxValue;

            do
            {
                    Console.Clear();
                    Console.WriteLine(menu);
                    int.TryParse(Console.ReadLine(), out datoingo); 
                    switch (datoingo)
                    {
                    case 1:
                     #region Mayor de 3 numeros
                        int primero, segundo, tercero;
                            string dato;

                            Console.WriteLine("Ingrese primer numero:");
                            dato = Console.ReadLine();
                            int.TryParse(dato, out primero);
                            do
                            {
                                Console.WriteLine("Ingrese segundo numero:");
                                dato = Console.ReadLine();
                                int.TryParse(dato, out segundo);
                                if (primero == segundo)
                                {
                                    Console.WriteLine("Valor duplicado,ingrese de nuevo");
                                }
                            } while (primero == segundo);



                            do
                            {
                                Console.WriteLine("Ingrese tercero numero:");
                                dato = Console.ReadLine();
                                int.TryParse(dato, out tercero);
                                if (primero == tercero || segundo == tercero)
                                {
                                    Console.WriteLine("Valor duplicado,ingrese de nuevo");
                                }
                            } while (primero == tercero || segundo == tercero);

                            if (primero > segundo)
                            {

                                if (primero > tercero)
                                    Console.WriteLine("El mayor numero es: " + primero);


                                else
                                {
                                    Console.WriteLine("El mayor numero es: " + tercero);
                                }
                            }
                            else
                            {
                                //segundo>=primero
                                if (segundo > tercero)
                                    Console.WriteLine("El mayor numero es: " + segundo);

                                else
                                {
                                    Console.WriteLine("El mayor numero es: " + tercero);
                                }
                            }
                            Console.ReadLine();

                            break;
                    #endregion  
                    case 2:
                     #region Inversion de numero de dos cifras
                        int numero; //=12
                            int decenas, unidades;
                            string datoCifra;
                            do
                            {
                                Console.WriteLine("Ingrese el numero :");
                                datoCifra = Console.ReadLine();
                                int.TryParse(datoCifra, out numero);
                            } while (!(numero > -100 && numero < -9 || numero > 9 && numero < 100));
                            //el NOT=! convierte el falso en verdadero paraque la operacion se repita y pida el
                            //numero otra vez

                            decenas = Math.Abs(numero / 10);
                            unidades = Math.Abs(numero % 10);

                            Console.Write(unidades);
                            Console.Write(decenas);
                            Console.ReadLine();
                            break;
                    #endregion
                    case 3:
                    #region Inversion de numero de tres cifras
                        int numero1, decenas1, unidades1;
                            string dato2;

                            do
                            {
                                Console.WriteLine("Ingrese el numero de 3 digitos:");
                                dato2 = Console.ReadLine();
                                int.TryParse(dato2, out numero1);
                            } while (!(numero1 > -1000 && numero1 < -99 || numero1 > 99 && numero1 < 1000));


                            int r = numero1 % 100;
                            decenas1 = Math.Abs(r / 10);
                            unidades1 = Math.Abs(r % 10);
                            numero1 = numero1 / 100;
                            Console.WriteLine("Su numero invertido es: ");
                            Console.Write(unidades1);
                            Console.Write(decenas1);
                            Console.WriteLine(numero1);




                            Console.ReadLine();

                            break;
                    #endregion
                    case 4:
                    #region Mayor de N numeros
                        int numero2 = 0;
                            int valorMaximo = int.MinValue;
                            string datoX, dato11 = "";
                            int iMax = 0;
                            int limite = int.MaxValue;

                            for (int z = 0; z >= 0 && z < limite; z++)
                            {


                                if ((dato11 == "si" || dato11 == "SI" || dato11 == "Si" || dato11 == "sI"))
                                {
                                    Console.WriteLine("====El numero de iteracion con el valor mayor fue el #" + (iMax + 1) + " y su valor fue de " + valorMaximo + "====" + "\n Adios :D!");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el numero " + (z + 1) + " : ");
                                    datoX = Console.ReadLine();
                                    int.TryParse(datoX, out numero2);

                                    if (valorMaximo < numero2)
                                    {
                                        valorMaximo = numero2;
                                        iMax = z;


                                    }

                                    Console.WriteLine("Si termino de ingresar valores, escriba solamente un si.De lo contrario escriba cualquier otra cosa");
                                    dato11 = Console.ReadLine();

                                }
                            }
                            break;
                    #endregion
                    case 5:
                    #region Desglose de billetes
                        int cantidad;
                            int Billete100, Billete50, Billete30, Billete10, Billete5;
                            int residuo100, residuo50, residuo30, residuo10, residuo5;
                            bool valDbilletes;

                            do
                            {
                                Console.Write("Ingrese  la cantidad que va a convertir: ");
                                //cantidad= int.Parse(Console.ReadLine());
                                dato = Console.ReadLine();
                                if ((!(int.TryParse(dato, out cantidad))))
                                {
                                    Console.WriteLine("Error...Ingrese solo numeros, no letras o caracteres");

                                }



                            } while (!(cantidad > 0));





                            //para mutliplos divisibles entre 100
                            Billete100 = cantidad / 100;
                            residuo100 = cantidad % 100;

                            //para multiplos divisibles de 50
                            Billete50 = residuo100 / 50;
                            residuo50 = residuo100 % 50;

                            //30

                            Billete30 = residuo50 / 30;
                            residuo30 = residuo50 % 30;

                            //10

                            Billete10 = residuo50 / 10;
                            residuo10 = residuo30 % 10;


                            //5

                            Billete5 = residuo10 / 5;
                            residuo5 = residuo10 % 5;




                            Console.WriteLine("Usted tiene {0} de 100, {1} de 50, {2} de 30, {3} de 10, {4} de 5.", Billete100, Billete50, Billete30, Billete10, Billete5);
                            Console.WriteLine("{0} de resto", residuo5);
                            Console.ReadLine();
                            break;
                    #endregion
                    case 6:
                    #region Lados de un triangulo
                        int ladoA, ladoB, ladoC;

                                Console.WriteLine("Ingrese la medida en numeros enteros de su triangulo,seguidos de un enter cada uno;para determinar que tipo de triangulo es");
                                int.TryParse(Console.ReadLine(), out ladoA);
                                int.TryParse(Console.ReadLine(), out ladoB);
                                int.TryParse(Console.ReadLine(), out ladoC);
                                if (ladoA == ladoB && ladoA == ladoC)
                                {
                                    Console.WriteLine("equilatero");
                                }
                                else if (ladoA == ladoB || ladoA == ladoC || ladoB==ladoC)
                                {
                                    Console.WriteLine("isoceles");
                                }
                                else
                                {
                                    Console.WriteLine("escaleno");
                                }
                                Console.ReadLine();
                            
                            break;
                    #endregion
                    case 7:
                    #region Dias de la semana
                        int dia;
                            do
                            {
                                Console.WriteLine("Escriba el dia de la semana y le dire que es");
                                int.TryParse(Console.ReadLine(), out dia);

                            } while (!(dia > 0 && dia < 8));
                            if (dia == 0)
                            {
                                return;
                            }


                            if (!(dia > 0 && dia < 8))
                            {
                                Console.WriteLine("valor fuera de rango");
                            }
                            switch (dia)
                            {
                                case 1:
                                    Console.WriteLine("El dia es Lunes");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("El dia es Martes");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("El dia es Miercoles");
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("El dia es Jueves");
                                    Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("El dia es Viernes");
                                    Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("El dia es Sabado");
                                    Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("El dia es Domingo");
                                    Console.ReadLine();
                                    break;

                            }
                            break;
                    #endregion
                    case 8:
                    #region Calificaciones
                        /*0-11 insuficiente
                   12-13 regular 
                   14,15 buena
                   16,17,18 muy buena
                   19,20 sobresaliente*/
                        int numerongo;
                            do
                            {
                                Console.WriteLine("Ingrese su calificacion para saber su ranking");
                                int.TryParse(Console.ReadLine(), out numerongo);

                            } while (!(numerongo >= 0 || numerongo <= 20));
                            switch (numerongo)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                case 10:
                                case 11:
                                    Console.WriteLine("Insuficiente");
                                    Console.ReadLine(); break;
                                case 12:
                                case 13:
                                    Console.WriteLine("Regular");
                                    Console.ReadLine(); break;
                                case 14:
                                case 15:
                                    Console.WriteLine("Buena");
                                    Console.ReadLine(); break;
                                case 16:
                                case 17:
                                case 18:
                                    Console.WriteLine("Muy buena");
                                    Console.ReadLine(); break;
                                case 19:
                                case 20:
                                    Console.WriteLine("Sobresaliente");
                                    Console.ReadLine(); break;



                            }
                            break;
                    #endregion
                   
                    }

            } while (datoingo !=9);
                    Console.ReadLine();

        }
    }
}
