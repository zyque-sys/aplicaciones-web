using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arreglo_DatosEspeciales
{
    public class BubbleSort
    {
        public void RunSortAscendant(ClaseArregloV3 arreglo) {
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

        public void RunSortDescendant(ClaseArregloV3 arreglo)
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
