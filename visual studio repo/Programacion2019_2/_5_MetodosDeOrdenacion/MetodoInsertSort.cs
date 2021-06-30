using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MetodosDeOrdenacion
{
    class MetodoInsertSort
    {
        static void Main(string[] args)
        {
            // Metodo insertSort 
            // Acomodando comparando predecesores
            int[] arregloInsercion = { 8, 3, 5 };


            //for (int i = 1; i < arregloInsercion.Length; i++)
            //{
            //    int valor = arregloInsercion[i];
            //    int z = i - 1;

            //    while (z >= 0 && arregloInsercion[z] > valor)
            //    {
            //        arregloInsercion[z + 1] = arregloInsercion[z];
            //        z--;
            //    }

            //    arregloInsercion[z + 1] = valor;

            //    for (int j = 0; j < arregloInsercion.Length; j++)
            //    {
            //        Console.WriteLine(arregloInsercion[j]);
            //        //Console.WriteLine(valor);
            //    }
            Console.WriteLine("El arreglo original es: 8, 3, 5");
            Console.WriteLine("Ordenado con InsertSort:");

            int acomodados;
            int j;
            for (int i = 0; i < arregloInsercion.Length; i++)
            {
                acomodados = arregloInsercion[i];
                j = i - 1;
                while (j >= 0 && arregloInsercion[j] > acomodados)
                {
                    arregloInsercion[j + 1] = arregloInsercion[j];
                    j--;
                }
                arregloInsercion[j + 1] = acomodados;
            }
            for (int f = 0; f < arregloInsercion.Length; f++)
            {
                Console.Write(arregloInsercion[f] + "  ");
            }
            Console.ReadLine();

            
        }

    }
}
