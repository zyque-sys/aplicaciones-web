using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            Gatos gato = new Gatos();
            Vibora vibora = new Vibora();

            Console.Write("El gato: "); gato.Comer();
            Console.Write("La vibora: "); vibora.Comer();

            Console.Write("El gato: "); gato.Oler();
            Console.Write("La vibora: "); vibora.Oler();

            Console.ReadLine();
        }
    }
}
