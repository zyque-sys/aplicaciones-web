using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MetodosDeOrdenacion
{
    class MetodoBurbuja
    {
        static void Main(string[] args)
        {
            int[] arregloBurbuja = { 4, 3, 2, 1 };

            //for (int i = 0; i <= arregloBurbuja.Length; i++)
            //{
            //    if (arregloBurbuja[i + 1] < arregloBurbuja[i])
            //    {
            //        arregloBurbuja[i + 1] = arregloBurbuja[i];
            //    }
            //    Console.WriteLine(arregloBurbuja[i]);
            //}

            Console.WriteLine("El arreglo original es: 4, 3, 2, 1");
            Console.WriteLine("Ordenado con Burbuja:");


            int t;
            for (int a = 1; a < arregloBurbuja.Length; a++)
                for (int b = arregloBurbuja.Length - 1; b >= a; b--)
                {
                    if (arregloBurbuja[b - 1] > arregloBurbuja[b])
                    {
                        t = arregloBurbuja[b - 1];
                        arregloBurbuja[b - 1] = arregloBurbuja[b];
                        arregloBurbuja[b] = t;
                    }
                }
            for (int f = 0; f < arregloBurbuja.Length; f++)
            {
                Console.Write(arregloBurbuja[f] + "  ");
            }
            Console.ReadLine();
            
        }
    }
}
