using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MetodosDeOrdenacion
{
    class MetodoQuickSort
    {
        static void Main(string[] args)
        {
            int[] arregloQuickSort = { 5, 6, 2, 4, 9, 1 };
            Console.WriteLine("El arreglo original es: 5,6,2,4,9,1");
            Console.WriteLine("Ordenado con QuickSort:");
            int h = 0;int n=0;
            n = 6;
            h = n;
            

            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", arregloQuickSort[i]);
                Quicksort(arregloQuickSort, 0, h - 1);
            }
        }
        //{ 5,6,2,4,9,1};
        static void Quicksort(int[] arregloQuickSort, int primero, int ultimo)
        {
            int i, j, central, h = 0;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = arregloQuickSort[central];
            i = primero;
            j = ultimo;
            do
            {
                while (arregloQuickSort[i] < pivote) i++;
                while (arregloQuickSort[j] > pivote) j--;
                if (i <= j)
                {
                    int tempo;
                    tempo = arregloQuickSort[i];
                    arregloQuickSort[i] = arregloQuickSort[j];
                    arregloQuickSort[j] = tempo;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                Quicksort(arregloQuickSort, primero, j);
            }
            if (i < ultimo)
            {
                Quicksort(arregloQuickSort, i, ultimo);
            }

            for (int l = 0; i < h; i++)
            {
                Console.Write(" {0} ", arregloQuickSort[i]);
            }
           
        }
        
    }
   
}
