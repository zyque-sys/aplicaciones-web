using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arreglos_Practica_ClaseArregloV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Test");
            ClaseArregloV1 ArregloV1 = new ClaseArregloV1(4);
            Console.SetWindowSize(50, 50);
            Console.WriteLine("Estado del arreglo a inicio del programa");
            Console.WriteLine(ArregloV1.Mostrar());

            #region Insertando datos en el arreglo

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insertando datos");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Insertando el valor 10: ");
            if (ArregloV1.Insertar(10))//insertando valor 10
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo

            Console.Write("Insertando el valor 5: ");
            if (ArregloV1.Insertar(5))//insertando valor 10
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo

            Console.Write("Insertando el valor 8: ");
            if (ArregloV1.Insertar(8))//insertando valor 10
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo

            Console.Write("Insertando el valor 2: ");
            if (ArregloV1.Insertar(2))//insertando valor 2
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo

            Console.Write("Insertando el valor 2: ");
            if (!ArregloV1.Insertar(2))//insertando valor 2 repetido
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo

            Console.Write("Insertando el valor 12: ");
            if (!ArregloV1.Insertar(12))//insertando valor 12
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(ArregloV1.Mostrar());//mostrando el contenido del arreglo
            #endregion
            //Console.WriteLine();
            #region Buscar datos en el arreglo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Buscando datos");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Estado del arreglo despues de insertar datos");
            Console.WriteLine(ArregloV1.Mostrar());

            Console.Write("Buscando un 2: ");
            if (ArregloV1.Buscar(2) != -1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write("Buscando un 10: ");
            if (ArregloV1.Buscar(10) != -1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write("Buscando un 5: ");
            if (ArregloV1.Buscar(5) != -1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.Write("Buscando un 12: ");
            if (ArregloV1.Buscar(12) == -1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            #endregion
            Console.WriteLine();
            #region Elminando datos del arreglo
            Console.WriteLine("Estado del arreglo despues de insertar datos");
            Console.WriteLine(ArregloV1.Mostrar());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eliminando datos");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Eliminando el valor 5: ");
            if (ArregloV1.Eliminar(5))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.Write("Eliminando el valor 15: ");
            if (ArregloV1.Eliminar(15))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            #endregion
            Console.WriteLine();
            #region Vaciar Arreglo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vaciando Arreglo");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Estado del arreglo antes de vaciar");
            Console.WriteLine(ArregloV1.Mostrar());

            ArregloV1.Vaciar();
            Console.Write(ArregloV1.Mostrar() + ": ");
            if (ArregloV1.Mostrar() == "Arreglo Vacío")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Ejecucion correcta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejecución incorrecta");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            #endregion

            Console.ReadLine();
        }
    }
}
