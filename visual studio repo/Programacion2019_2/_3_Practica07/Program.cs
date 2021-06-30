using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Ingrese la " + (i + 1) + "medida en numeros enteros de su triangulo,seguidos de un enter cada uno;para determinar que tipo de triangulo es");
                int.TryParse(Console.ReadLine(), out ladoA);
                int.TryParse(Console.ReadLine(), out ladoB);
                int.TryParse(Console.ReadLine(), out ladoC);

                //manera mas facil seria int.TryParse(Console.ReadLine(),out ladoA); , te ahorras el string y la linea extra



                //if (ladoA == ladoB || ladoA == ladoC || ladoC == ladoB)
                //{
                //    //isoceles
                //    Console.WriteLine("Su triangulo es isoceles");
                //}
                //if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB!=ladoC))
                //{
                //    //escaleno
                //    Console.WriteLine("Su triangulo es escaleno");
                //}
                //if ((ladoA==ladoB) && (ladoC==ladoA) && (ladoB==ladoC))
                //{
                //    //equilatero
                //    Console.WriteLine("Su triangulo es equilatero");
                //}

                if (ladoA==ladoB && ladoA==ladoC)
                {
                    Console.WriteLine("equilatero");
                }
                else if (ladoA == ladoB || ladoA == ladoC)
                {
                    Console.WriteLine("isoceles");
                }
                else
                {
                    Console.WriteLine("escaleno");
                }
                Console.ReadLine();
            }
        }
    }
}
