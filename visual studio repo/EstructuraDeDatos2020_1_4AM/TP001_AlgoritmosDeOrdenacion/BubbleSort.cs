using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias.ModelosDeDatos;

namespace Librerias.SortAlgorithms
{
    public class BubbleSort
    {
        public void RunSortAscendant(ClaseArregloV2 arreglo) {
            for (int i = 0; i < arreglo.Top-1; i++)
            {
                for (int j = 0; j < arreglo.Top-i-1; j++)
                {
                    if (arreglo.Arreglo[j]<arreglo.Arreglo[j+1])
                    {
                        arreglo.Swap(j,j+1);  
                   

                    }
                }
            }

        }

        public void RunSortDescendant(ClaseArregloV2 arreglo)
        {
            for (int i = 0; i < arreglo.Top - 1; i++)
            {
                for (int j = 0; j < arreglo.Top - i - 1; j++)
                {
                    if (arreglo.Arreglo[j] > arreglo.Arreglo[j + 1])
                    {
                        arreglo.Swap(j, j + 1);


                    }
                }
            }

        }
    }
}
