#region librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace practica2NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int primero, segundo, tercero;
            string dato;

            Console.WriteLine("Ingrese primer numero:");
            dato = Console.ReadLine();
            int.TryParse(dato, out primero);
            do {
                Console.WriteLine("Ingrese segundo numero:");
                dato = Console.ReadLine();
                int.TryParse(dato, out segundo);
                if (primero==segundo)
                {
                    Console.WriteLine("Valor duplicado,ingrese de nuevo");
                }
            } while (primero==segundo);



            do
            {
                Console.WriteLine("Ingrese tercero numero:");
                dato = Console.ReadLine();
                int.TryParse(dato, out tercero);
                if (primero == tercero || segundo==tercero)
                {
                    Console.WriteLine("Valor duplicado,ingrese de nuevo");
                }
            } while (primero == tercero || segundo == tercero);

            if (primero>segundo){

                if (primero > tercero) 
                    Console.WriteLine("El mayor numero es: " + primero);

                
                else
                {
                    Console.WriteLine("El mayor numero es: " + tercero);
                }
            }
            else
            {
                //segundo>=primero
                if (segundo>tercero)
                    Console.WriteLine("El mayor numero es: " + segundo);
                
                else
                {
                    Console.WriteLine("El mayor numero es: " + tercero);
                }
            }
            Console.ReadLine();

        }
    }
}
