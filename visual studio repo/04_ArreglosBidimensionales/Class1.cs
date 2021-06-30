using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArreglosBidimensionales
{
    class Class1
    {
        public void Main()
        {
            ClaseMatriz matriz = new ClaseMatriz(5, 5);

            matriz[2, 2] = 6;

        }
        static string GenerarStringMatriz(ClaseMatriz A)
        {
            int[] maxEspacios = new int[A.Maxcolumnas];
            for (int c = 0; c <A.Maxcolumnas ; c++)
            {
                maxEspacios[c] = int.MinValue;
                for (int r = 0; r < A.Maxrenglones; r++)
                    if (maxEspacios[c]<A[r,c].ToString().Length)
                        maxEspacios[c] = A[r, c].ToString().Length;
            }
            string salida = "";
            for (int r = 0; r < A.Maxrenglones; r++)
            {
                salida += "|";
                for (int c = 0; c < A.Maxcolumnas; c++)
                {
                    int espacios = maxEspacios[c] - A[r, c].ToString().Length;
                    for (int i = 0; i < espacios; i++)
                        salida += " ";
                    salida += A[r, c];
                    if (c < A.Maxcolumnas - 1)
                        salida += ", ";
                }
                salida += "|\n";
            }
            return salida;
        }
    }
}
