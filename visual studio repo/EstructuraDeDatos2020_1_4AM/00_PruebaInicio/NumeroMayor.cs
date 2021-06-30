using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PruebaInicio
{
    class NumeroMayor
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Ingrese numero a:");
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Ingrese numero b:");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Ingrese numero c:");
            int.TryParse(Console.ReadLine(), out c);

            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine("a es mayor");
                }
                else
                {
                    Console.WriteLine("c es mayor");
                }
            }
            else
            {
                if (b>c)
                {
                    Console.WriteLine("b es mayor");
                }
                else
                {
                    Console.WriteLine("c es mayor");
                }
            }
            //alternativa
            if (a>b&&a>c)
            {
                //a es mayor
            }
            else if (b>a&&b>c)
            {
                //b es mayor
            }
            else
            {
                //c es mayor    1
            }
        }
    }
}
