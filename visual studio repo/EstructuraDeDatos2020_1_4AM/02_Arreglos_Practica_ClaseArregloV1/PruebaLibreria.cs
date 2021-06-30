using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias.ModelosDeDatos;
using Librerias.SortAlgorithms;

namespace _02_Arreglos_Practica_ClaseArregloV1
{
    class PruebaLibreria
    {
        static void Main()
        {
            BubbleSort bubbles=new BubbleSort();
            ClaseArregloV2 arreglo = new ClaseArregloV2(5);

            arreglo.Insertar(6);
            arreglo.Insertar(3);
            arreglo.Insertar(5);
            arreglo.Insertar(2);
            arreglo.Insertar(4);

            Console.WriteLine(arreglo.Mostrar());
            Console.WriteLine("Ordenando...");
            Console.WriteLine("Ascendente");
            bubbles.RunSortAscendant(arreglo);
            Console.WriteLine(arreglo.Mostrar());

            Console.WriteLine("Descendente");
            bubbles.RunSortDescendant(arreglo);
            Console.WriteLine(arreglo.Mostrar());

            Console.ReadLine();


        }
    }
}
