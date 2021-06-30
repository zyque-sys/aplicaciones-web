using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica06
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int cantidad;
            int Billete100, Billete50, Billete30, Billete10, Billete5;
            int residuo100, residuo50, residuo30, residuo10, residuo5;
            bool valDbilletes;

            do
            {
                Console.Write("Ingrese  la cantidad que va a convertir: ");
                //cantidad= int.Parse(Console.ReadLine());
                dato = Console.ReadLine();
                if ((!(int.TryParse(dato, out cantidad))))
                {
                    Console.WriteLine("Error...Ingrese solo numeros, no letras o caracteres");

                }



            } while (!(cantidad > 0));





            //para mutliplos divisibles entre 100
            Billete100 = cantidad / 100;
            residuo100 = cantidad % 100;

            //para multiplos divisibles de 50
            Billete50 = residuo100 / 50;
            residuo50 = residuo100 % 50;

            //30

            Billete30 = residuo50 / 30;
            residuo30 = residuo50 % 30;

            //10

            Billete10 = residuo50 / 10;
            residuo10 = residuo30 % 10;


            //5

            Billete5 = residuo10 / 5;
            residuo5 = residuo10 % 5;




            Console.WriteLine("Usted tiene {0} de 100, {1} de 50, {2} de 30, {3} de 10, {4} de 5.", Billete100, Billete50, Billete30, Billete10, Billete5);
            Console.WriteLine("{0} de resto", residuo5);
            Console.ReadLine();
        }
    }
}
