using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero,decenas,unidades;
            string dato;

            do
            {
                Console.WriteLine("Ingrese el numero de 3 digitos:");
                dato = Console.ReadLine();
                int.TryParse(dato, out numero);
            } while (!(numero > -1000 && numero < -99 || numero > 99 && numero < 1000));


            int r = numero % 100;
                decenas = Math.Abs(r / 10);
                unidades = Math.Abs(r % 10);
            numero = numero / 100;
            Console.WriteLine("Su numero invertido es: ");
            Console.Write(unidades);
            Console.Write(decenas);
            Console.WriteLine(numero);

            
            

            Console.ReadLine();


        }
    }
}
