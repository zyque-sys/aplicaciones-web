using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias.ClaseArreglo;

namespace Librerias.SortAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// Ordena aspectos de un objeto con base al porcentaje, sin necesidad de pedir memoria adicional
        /// </summary>
        /// <param name="arreglo">componentes del objeto, objeto en si</param>
        public static void RunSort(ClaseArregloDesordenadoDatos arreglo)
        {
            for (int i = 0; i < arreglo.Top-1; i++)
            {
                for (int j = 0; j < arreglo.Top-i-1; j++)
                {
                    if (arreglo.Arreglo[j]>arreglo.Arreglo[j+1])
                    {
                        arreglo.Swap(j, j + 1);
                   //toDo
                    }
                }
            }
        }
    }
}
