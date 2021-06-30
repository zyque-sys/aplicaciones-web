#region Librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace estructuraDeControlIterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for
            //for (int z = 0; z < 5; z++)
            //{

            //}
            #region variable de control
            ////creacion de la variable fuera del ciclo
            //int i;
            //for ( i = 0; i < 5; i++)
            //{

            //}
            ////creacion de variable dentro del ciclo
            ////"standar c11" del lenguaje C 2011
            //for (int x = 0; x < 5; x++)
            //{

            //}
            #endregion
            #region Paso(step)
            ///* ++ suma un valor, si y=10,y++ es lo mismo que y=y+1, lo mismo con -- pero en resta*/
            //for (int a = 0; a < 0; a--) //decremento de 1 en 1
            //{

            //}
            //for (int b = 0; b < 0; b++)//aumento de 1 en 1
            //{

            //}
            //for (int c= 0; c < 0; c=c+7) //aumento de 7 en 7
            //{

            //}
            #endregion
            #region Condicion de Repeticion
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("hola"); //escribe holas infinitos
            //}
            //Console.ReadLine();
            //for (int i = 0; i<10; i=i+2)
            //{
            //    Console.WriteLine(i); //imprime los numeros pares menores a 10
            //}
            //Console.ReadLine();



            #endregion
            #endregion
            #region while
            //int i=0;
            //while (i<10)
            //{
            //    Console.WriteLine("while");
            //    i++;
            //}
            #endregion
            #region Do-while
            //es el unico que se ejecuta por lo menos una vez
            //do
            //{
            //    Console.WriteLine("do-while");
            //    i++;
            //} while (i < 10);
            //#endregion
            #endregion
            #region anidado
            //for (int i = 0; i < length; i++)                 //anidado for
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //        for (int i = 0; i < length; i++)
            //        {

            //        }
            //    }
            //}
            //while (true)                 //anidado de while
            //{
            //    while (true)
            //    {
            //        while (true)
            //        {

            //        }
            //    }
            //}
            //do                                 //anidado do-while
            //{
            //    do
            //    {
            //        do
            //        {

            //        } while (true);
            //    } while (true);
            //} while (true);

            #endregion
            #region Break
            //rompe contexto
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==5)
            //    
            //        break;
            //   Console.WriteLine(i);
            //}
            #endregion
            #region Continua
            for (int i = 0; i <10; i++) //salta a la siguiente iteracion
            {
                if (i==5)
                
                    continue;
                Console.WriteLine(i);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
