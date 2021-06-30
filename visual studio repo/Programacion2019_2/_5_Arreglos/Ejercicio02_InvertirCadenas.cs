using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arreglos
{
    class Ejercicio02_InvertirCadenas
    {
        static void Main(string[] args)
        {
            char[] arreglito;
            string lectura;

            Console.WriteLine("Ingrese su frase o palabra a invertir: ");
            lectura=Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Palabra invertida: ");

            arreglito = lectura.ToArray();
            for (int i = 0; i < arreglito.Length; i++)
            {
                Console.Write(arreglito[arreglito.Length-i-1]);
            }

            Console.ReadLine();


        }
    }
}
