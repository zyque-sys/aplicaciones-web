using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*0-11 insuficiente
             12-13 regular 
             14,15 buena
             16,17,18 muy buena
             19,20 sobresaliente*/
            int numerongo;
            do
            {
                Console.WriteLine("Ingrese su calificacion para saber su ranking");
                int.TryParse(Console.ReadLine(), out numerongo);

            } while (!(numerongo>=0 || numerongo<=20));
            switch (numerongo)
            {
                case 1:
                case 2: 
                case 3: 
                case 4: 
                case 5: 
                case 6: 
                case 7: 
                case 8: 
                case 9: 
                case 10: 
                case 11:
                    Console.WriteLine("Insuficiente");
                    Console.ReadLine(); break;
                case 12:
                case 13: Console.WriteLine("Regular");
                    Console.ReadLine(); break;
                case 14:
                case 15: Console.WriteLine("Buena");
                    Console.ReadLine(); break;
                case 16:
                case 17:
                case 18: Console.WriteLine("Muy buena");
                    Console.ReadLine(); break;
                case 19:
                case 20: Console.WriteLine("Sobresaliente");
                    Console.ReadLine(); break;
                  


            }
        }
    }
}
