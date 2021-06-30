using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arreglos
{
    class Ejercicio03_InvertirOrdenDeLasPalabras
    {
        static void Main(string[] args)
        {
            #region Version con Split
            //string frase;
            //string[] mochadas;
            //int j;

            //Console.WriteLine("Ingrese su frase a invertir:");
            //frase = Console.ReadLine();

            //mochadas = frase.Split(' ');
            //j = mochadas.Length - 1;
            //for (int i = j; i >= 0; i--)
            //{
            //    Console.Write(mochadas[i] + " ");
            //}
            #endregion
            #region Metodo sin Split
            string lectura;
            char[] cadena;
            char[] palabraInvertida;

            Console.WriteLine("Ingrese su frase a invertir:");
            lectura = Console.ReadLine();
            cadena = lectura.ToArray();
            int NumeroDePalabras = ContadorDePalabras(cadena);

            string palabras = new string [NumeroDePalabras];
            int contadorPalabras = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i]!=' ')
                {
                    palabras[contadorPalabras] += cadena[i];
                }
                else
                {
                    contadorPalabras++;
                }
            }

            string salida = "";
            for (int i = 0; i < NumeroDePalabras; i++)
            {
                palabraInvertida[i] = new string(InvertirCadena(palabras[i].ToArray()));
                salida += palabraInvertida[i];
                if (i!=NumeroDePalabras-1)
                {
                    salida += " ";
                }
            }

            #endregion
            Console.ReadLine();
        }
        #region Metodos

        static char[] InvertirCadena(char[] arreglito)
        {
            
            for (int i = 0; i < arreglito.Length; i++)
            {
                Console.Write(arreglito[arreglito.Length - i - 1]);
            }

        }
        static int ContadorDePalabras(char [] Cadena)
        {
            int contador = 0;

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
            return contador;
        }
        #endregion
    }
}
