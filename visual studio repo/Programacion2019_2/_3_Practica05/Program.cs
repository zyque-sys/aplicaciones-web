using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero;
            //int valorMaximo = int.MinValue;
            //string dato,dato1;
            //int iMax = 0;
            //int limite = int.MaxValue;

            //for (int i = 0; i >= 0 || i < limite; i++)
            //{
            //    Console.WriteLine("Ingrese el numero " + (i + 1) + " : ");

            //    dato = Console.ReadLine();
            //    int.TryParse(dato, out numero);

            //     if (valorMaximo < numero)
            //    {
            //        valorMaximo = numero;
            //        iMax = i;


            //    }
            //    Console.WriteLine("Si termino de ingresar valores, escriba solamente un si.De lo contrario solo presione ENTER");
            //    dato1 = Console.ReadLine();

            //    if ((dato1 == "si" || dato1 == "SI"))
            //    {
            //        Console.WriteLine("====El numero de iteracion con el valor mayor fue el #" + (iMax + 1)+" y su valor fue de " + valorMaximo+"====" +"\n Adios :D!");
            //        Console.ReadLine();
            //        break;
            //    }
            int numero;
            int valorMaximo = int.MinValue;
            string dato, dato1;
            int iMax = 0;
            int limite = int.MaxValue;

            for (int i = 0; i >= 0 && i < limite; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + " : ");

                dato = Console.ReadLine();
                int.TryParse(dato, out numero);

                if (valorMaximo < numero)
                {
                    valorMaximo = numero;
                    iMax = i;


                }
                Console.WriteLine("Si termino de ingresar valores, escriba solamente un si.De lo contrario solo presione ENTER");
                dato1 = Console.ReadLine();

                if ((dato1 == "si" || dato1 == "SI"))
                {
                    Console.WriteLine("====El numero de iteracion con el valor mayor fue el #" + (iMax + 1) + " y su valor fue de " + valorMaximo + "====" + "\n Adios :D!");
                    Console.ReadLine();
                    break;
                }

            }


    }
    }
}
