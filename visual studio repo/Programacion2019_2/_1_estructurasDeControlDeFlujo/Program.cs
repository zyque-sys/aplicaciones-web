using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructurasDeControlDeFlujo
{
    class Program
    {
        static void Main(string[] args)
        {
            // snippet #re+TAB+TAB
            #region if
            #region simple


            //int a =1, b=2;
            //if (a>b)
            //{

            //    Console.WriteLine("Codigo verdadero de if");
            //}
            //else
            //{
            //    Console.WriteLine("codigo falso de if");
            //}

            //Console.WriteLine("Codigo fuera de if");
            //Console.ReadLine();


            #endregion
            #region Doble
            //string dato;
            //int numero;
            //Console.WriteLine("Teclea un numero: ");
            //dato = Console.ReadLine();
            //int.TryParse(dato,out numero);
            //if (numero>0 && numero<=10)
            //{
            //    Console.WriteLine("El numero esta en el rango de 0-10");
            //}
            //else
            //{
            //    Console.WriteLine("valor fuera del rango");
            //}
            //Console.ReadLine();
            #endregion
            #region anidado
            //string dato;
            //int numero;
            //Console.WriteLine("Teclea un numero: ");
            //dato = Console.ReadLine();
            //int.TryParse(dato, out numero);
            //if (numero >= 0 && numero <= 10)
            //{
            //    Console.WriteLine("El numero esta en el rango de 0-10");
            //    if (numero == 0) //te dice que numero es
            //    {
            //        Console.WriteLine("Es 0");
            //    }
            //    if (numero == 1)
            //    {
            //        Console.WriteLine("Es 1");
            //    }
            //}
            //else
            //{
            //    if (numero>=11 && numero<=20)

            //    {
            //        Console.WriteLine("El numero esta entre 11 y 20");
            //    }
            //    else
            //    {
            //        Console.WriteLine("numero fuera de rango");
            //    }
            //}
            //Console.ReadLine();

            #endregion
            #endregion
            #region switch
            string dato;
            int numero;
            Console.WriteLine("Teclea un numero: ");
            dato = Console.ReadLine();
            //int.TryParse(dato, out numero);

            /*switch (numero) */ //ejecucion de opciones por caso, el default es cuando no aplico ningun caso
            {
                //case 1:
                //    //ToDo
                //    Console.WriteLine("es un 1");
                //    break;
                //case 2:
                //    Console.WriteLine("es un 2");
                //    break;
                //case 3:
                //    Console.WriteLine("es un 3");
                //    break;

                //default:
                //    Console.WriteLine("no asi no mijo");
                //break;
                //}
                //    switch (numero) {
                //    case 1:
                //    case 2:
                //    case 3:
                //    case 4:
                //    case 5:

                //      Console.WriteLine("en rango de 1-5");
                //        break;


                //    default:
                //        Console.WriteLine("no asi no mijo");
                //        break;
                //}
                //Console.ReadLine();
                switch (dato)
                {
                    case "hola":
                        Console.WriteLine("holis");
                        break;
                    case "mundo":
                        Console.WriteLine("si");
                        break;
                    default:
                        Console.WriteLine("ahorita no joven");
                        break;
                }

                #endregion
            }
        }
    }
}
