using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            do
            {
                Console.WriteLine("Escriba el dia de la semana y le dire que es");
                int.TryParse(Console.ReadLine(), out dia);
               
            } while (!(dia > 0 && dia < 8));
            if (dia == 0)
            {
                return;
            }


            if (!(dia > 0 && dia < 8))
            {
                Console.WriteLine("valor fuera de rango");
            }
            switch (dia)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("El dia es Miercoles");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("El dia es Sabado");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo");
                    Console.ReadLine();
                    break;
            
            }

        }
    }
}
