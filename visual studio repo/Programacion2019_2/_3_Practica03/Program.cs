using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica3
{
    class Program
    {
        static void Main(string[] args)
        {//invertir un numero de dos cifras
            #region V1
            int numero; //=12
            int decenas, unidades;
            //string dato;
            //do {
            //    Console.WriteLine("Ingrese el numero :");
            //    dato = Console.ReadLine();
            //    int.TryParse(dato, out numero);
            //} while (!(numero>-100 && numero<-9 || numero>9 && numero<100));
            ////el NOT=! convierte el falso en verdadero paraque la operacion se repita y pida el
            ////numero otra vez

            //decenas = Math.Abs(numero / 10);
            //unidades= Math.Abs(numero % 10);

            //Console.Write(unidades);
            //Console.Write(decenas);
            #endregion
            #region V2
            string dato;
            do
            {
                Console.Write("Dame valor: ");
                dato=Console.ReadLine();
            } while (!(dato.Length == 2));

            char[] cadena=dato.ToCharArray();
            Console.Write(cadena[1]); 
            Console.Write(cadena[0]);
            // o Console.WriteLine();
            Console.WriteLine("{0}{1}",cadena[1],cadena[0]);
            #endregion
            Console.ReadLine();


        }
    }
}
