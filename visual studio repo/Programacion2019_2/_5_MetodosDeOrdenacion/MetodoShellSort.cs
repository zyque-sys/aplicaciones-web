using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MetodosDeOrdenacion
{
    class MetodoShellSort
    {
        static void Main(string[] args)
        {
            int[] arregloShell = { 8, 5, 6, 3, 1, 9 };

            Console.WriteLine("El arreglo original es:  8, 5, 6, 3, 1, 9");
            Console.WriteLine("Ordenado con shell:");

            int salto = 0;
            int condicionShell = 0;
            int acomodo = 0;
            int x = 0;
            salto = arregloShell.Length / 2;

            while (salto > 0)
            {
                condicionShell = 1;
                while (condicionShell != 0)
                {
                    condicionShell = 0;
                    x = 1;
                    while (x <= (arregloShell.Length - salto))
                    {
                        if (arregloShell[x - 1] > arregloShell[(x - 1) + salto])
                        {
                            acomodo = arregloShell[(x - 1) + salto];
                            arregloShell[(x - 1) + salto] = arregloShell[x - 1];
                            arregloShell[(x - 1)] = acomodo;
                            condicionShell = 1;
                        }
                        x++;
                    }
                }
                salto = salto / 2;
            }
            for (int f = 0; f < arregloShell.Length; f++)
            {
                Console.WriteLine(arregloShell[f] + "  ");
            }

            Console.ReadLine();
        }
    }
}
