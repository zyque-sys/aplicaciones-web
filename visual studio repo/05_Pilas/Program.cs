using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila(5);
            //Console.WriteLine(pila.Mostrar());
            Console.WriteLine("Push de 5");
            pila.Push(5,false);
            Console.WriteLine(pila.Mostrar());
            //Console.WriteLine("Push de 6");
            //pila.Push(333, false);
            //Console.WriteLine(pila.Mostrar());
            //Console.WriteLine("Push de 2");
            //pila.Push(2, false);
            //Console.WriteLine(pila.Mostrar());
            //Console.WriteLine("Push de 4");
            //pila.Push(4, false);
            //Console.WriteLine(pila.Mostrar());
            //Console.WriteLine("Push de 12");
            //pila.Push(12, false);
            //Console.WriteLine(pila.Mostrar());
            Console.WriteLine("Pop");
            pila.Pop(true);
            Console.WriteLine(pila.Mostrar());
            Console.ReadLine();
        }
    }
}
