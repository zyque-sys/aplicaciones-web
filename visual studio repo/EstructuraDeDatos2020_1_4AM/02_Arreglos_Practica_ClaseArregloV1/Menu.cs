using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arreglos_Practica_ClaseArregloV1
{
    class Menu
    {
        static void Main(string[] args)
        {
            ClaseArregloV1 ArregloV1 = new ClaseArregloV1(4);
            int opcion;
            int inicioMenu = 1;
            int finMenu = 9;

            int dato;
            string menu = "===MENU===\n1:Buscar Arreglo \n2: Eliminar en el arreglo \n3:Esta Lleno \n4:Esta Vacio \n5:Insertar valores \n6:Mostrar \n7:Ordenar \n8:Vaciar \n[!]9:Salir[!] \nOpción:";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu)
                    {
                        Console.WriteLine("Opción invalida"); Console.ReadLine();
                    }
                    } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        int temp;
                        Console.WriteLine("==>Ingrese el numero a buscar en el arreglo");
                        int.TryParse(Console.ReadLine(), out dato);
                        Console.WriteLine("Buscando dato...");
                        if (ArregloV1.Buscar(dato) != -1)
                        {
                            temp=ArregloV1.Buscar(dato);
                            Console.WriteLine("Se encontro el dato " + dato + " en la posicion " + temp);
                        }

                        else
                            Console.WriteLine("No se encontro el dato");
                        
                        break;
                    case 2:
                        Console.WriteLine("==>Ingrese el numero a eliminar en el arreglo");
                        int.TryParse(Console.ReadLine(), out dato);
                        Console.WriteLine("Eliminando dato...");
                        ArregloV1.Eliminar(dato);
                        Console.WriteLine(ArregloV1.Mostrar()); ;
                        
                        break;
                    case 3:
                        Console.WriteLine("==>Evaluando si el arreglo esta lleno");
                        if (ArregloV1.EstaLleno())
                            Console.WriteLine("El arreglo esta lleno");
                        else
                            Console.WriteLine("El arreglo NO esta lleno");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("==>Evaluando si el arreglo esta vacio");
                        if (ArregloV1.EstaVacio())
                            Console.WriteLine("El arreglo esta vacio");
                        else
                            Console.WriteLine("El arreglo NO esta vacio");
                        
                        break;
                    case 5:
                        Console.WriteLine("==>Ingrese el valor a insertar en el arreglo");
                        int.TryParse(Console.ReadLine(), out dato);
                        Console.WriteLine("Insertando dato...");
                        ArregloV1.Insertar(dato);
                        Console.WriteLine(ArregloV1.Mostrar());
                        
                        //toDo
                        break;
                    case 6:
                        Console.WriteLine("==>Este es el arreglo actualmente:");
                        Console.WriteLine(ArregloV1.Mostrar());
                        break;
                    case 7:
                        Console.WriteLine("==>El arreglo actualmente:");
                        Console.WriteLine(ArregloV1.Mostrar());
                        Console.WriteLine("==>El arreglo despues de ordenarlo:");
                        ArregloV1.Ordenar();
                        Console.WriteLine(ArregloV1.Mostrar());

                        break;
                    case 8:
                        Console.WriteLine("==>Vaciando el arreglo:");
                        Console.WriteLine(ArregloV1.Mostrar());
                        Console.WriteLine("==>Arreglo vacio");
                        ArregloV1.Vaciar();
                        Console.WriteLine(ArregloV1.Mostrar());


                        break;
                }
                Console.ReadLine();
            } while (opcion != finMenu);

        }

    }
}
