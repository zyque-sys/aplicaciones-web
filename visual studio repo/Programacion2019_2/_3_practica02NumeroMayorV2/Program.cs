using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_practica2NumeroMayorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int valorMaximo = int.MinValue;
            string dato;
            int iMax=0;
            int limite = int.MaxValue;

            bool limiteB = Convert.ToBoolean(limite);
            

            for (int i = 0;i<3;i++) 
            {
                Console.WriteLine("Ingrese el numero "+(i+1)+" : ");
                dato = Console.ReadLine();
                int.TryParse(dato, out numero);
                    if (valorMaximo<numero)
                    {
                    valorMaximo = numero;
                    iMax = i;
                    }
                
            }
            Console.WriteLine("El numero de iteracion con el valor mayor fue el: "+(iMax+1));
            Console.WriteLine("El valor mayor fue: "+valorMaximo);
            Console.ReadLine();
        }
    }
}
