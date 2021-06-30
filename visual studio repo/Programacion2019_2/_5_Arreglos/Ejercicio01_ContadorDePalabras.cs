using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arreglos
{
    class Ejercicio01_ContadorDePalabras
    {
        static void Main(string[] args)
        {
            //Hacer un programa que reciba una cadena de caracteres por parte del usuario y que indique como salida
            //el numero de palabras contenidas en la cadena.

            String oracion;
            int contador = 0;
            char[] Cadena;

            Console.Write("escriba una oracion: ");
            oracion = Console.ReadLine();

            Cadena = oracion.ToArray();

            if (oracion == "")
            {
                Console.WriteLine("no ingreso nada");
                Console.ReadLine();
                return;
            }
            else
            {
                for (int i = 1; i < Cadena.Length; i++)
                {
                    if (Cadena[i] == ' ' && Cadena[i - 1] != ' ')
                    {
                        contador++;
                    }
                }
                if (Cadena[Cadena.Length - 1] != ' ')
                {
                    contador++;
                }
            }

            Console.WriteLine("EL numero de palabras que escribio fue: " + contador);
            Console.WriteLine("Lo que ingreso fue: " + oracion);
            Console.ReadLine();

        }

    }
}