using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extraescolar
{
    class Burbuja
    {
        static void Main(string[] args)
        {
            //int[] arreglo = { 23, 11, 100, 1, 555, 222, 50, 9 };

            //int temporal = 0;

            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    for (int j = 0; j < arreglo.Length - 1; j++)
            //    {
            //        if (arreglo[j] > arreglo[j + 1])
            //        {
            //            temporal = arreglo[j + 1];
            //            arreglo[j + 1] = arreglo[j];
            //            arreglo[j] = temporal;
            //        }
            //    }
            //}

            //for (int i = 0; i < arreglo.Length; i++)
            //    Console.Write(arreglo[i] + " ");


            //pruebas locas
            string cadena;

            int valorASCII;

            Console.Write("Ingrese una letra: ");
            cadena=Console.ReadLine();

            char[] arreglo=cadena.ToCharArray();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("El caracter "+arreglo[i]+" ");
            }

            Console.WriteLine





            Console.ReadKey();
        }
    }
}
