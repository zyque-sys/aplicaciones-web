using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias.SortAlgorithms;
using Librerias.ModelosDeDatos;

namespace _02_Arreglos_Practica_ClaseArregloV1
{
    class Menu2
    {
        static void Main(string[] args)
        {
            //    ClaseArregloV2 arregloV1 = new ClaseArregloV2(5);
            //    ClaseArregloV2 arregloTemp = new ClaseArregloV2(5);
            //    int opcion;
            //    int inicioMenu = 1;
            //    int finMenu = 9;
            //    int dato;

            //    string menu = "===MENU===\n1:Precargar Arreglo \n2: Eliminar en el arreglo \n3:Esta Lleno \n4:Buscar en el arreglo \n5:Insertar valores \n6:Mostrar \n7:Ordenar \n8:Vaciar \n[!]9:Salir[!] \nOpción:";
            //    do
            //    {
            //        opcion = Menu(menu, inicioMenu, finMenu,true);
            //        switch (opcion)
            //        {
            //            case 1:
            //                arregloV1.Vaciar();

            //                arregloV1.Insertar(4);
            //                arregloV1.Insertar(8);
            //                arregloV1.Insertar(1);
            //                arregloV1.Insertar(3);
            //                arregloV1.Insertar(2);
            //                break;
            //            case 2:
            //                Console.WriteLine("==>Ingrese el numero a eliminar en el arreglo");
            //                int.TryParse(Console.ReadLine(), out dato);
            //                Console.WriteLine("Eliminando dato...");
            //                arregloV1.Eliminar(dato);
            //                Console.WriteLine(arregloV1.Mostrar()); ;

            //                break;
            //            case 3:
            //                Console.WriteLine("==>Evaluando si el arreglo esta lleno");
            //                if (arregloV1.EstaLleno())
            //                    Console.WriteLine("El arreglo esta lleno");
            //                else
            //                    Console.WriteLine("El arreglo NO esta lleno");
            //                Console.ReadLine();
            //                break;
            //            case 4:
            //                int temp;
            //                Console.WriteLine("==>Ingrese el numero a buscar en el arreglo");
            //                int.TryParse(Console.ReadLine(), out dato);
            //                Console.WriteLine("Buscando dato...");
            //                if (arregloV1.Buscar(dato) != -1)
            //                {
            //                    temp = arregloV1.Buscar(dato);
            //                    Console.WriteLine("Se encontro el dato " + dato + " en la posicion " + temp);
            //                }

            //                else
            //                    Console.WriteLine("No se encontro el dato");

            //                break;
            //            case 5:
            //                Console.WriteLine("==>Ingrese el valor a insertar en el arreglo");
            //                int.TryParse(Console.ReadLine(), out dato);
            //                Console.WriteLine("Insertando dato...");
            //                arregloV1.Insertar(dato);
            //                Console.WriteLine(arregloV1.Mostrar());

            //                //toDo
            //                break;
            //            case 6:
            //                Console.WriteLine("==>Este es el arreglo actualmente:");
            //                Console.WriteLine(arregloV1.Mostrar());
            //                break;
            //            case 7:

            //                Console.WriteLine("==>El arreglo actualmente:");
            //                Console.WriteLine(arregloV1.Mostrar());
            //                int opcion2;
            //                int inicioMenu2 = 1;
            //                int finMenu2 = 5;
            //                string menu2 = "1: BubbleSort\n2: HeapSort\n3: InsertSort\n4:QuickSort\n5:PancakeSort\n6:SelectSort\nOpción:";
            //                do
            //                {
            //                    opcion2 = Menu(menu2, inicioMenu2, finMenu2, false);
            //                    switch (opcion2)
            //                    {
            //                        case 1:
            //                            //toDo
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            BubbleSort bubbles = new BubbleSort();
            //                            Console.WriteLine("Ordenando...");

            //                            bubbles.RunSortAscendant(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();

            //                            break;
            //                        case 2:
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            HeapSort hippy = new HeapSort();
            //                            Console.WriteLine("Ordenando...");

            //                            hippy.RunSort(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();
            //                            //toDo
            //                            break;
            //                        case 3:
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            InsertSort inserts = new InsertSort();
            //                            Console.WriteLine("Ordenando...");

            //                            inserts.RunSort(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();
            //                            //toDo
            //                            break;
            //                        case 4:
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            QuickSort quickie = new QuickSort();
            //                            Console.WriteLine("Ordenando...");

            //                            quickie.RunSort(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();
            //                            //toDo
            //                            break;
            //                        case 5:
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            PancakeSort pancake = new PancakeSort();
            //                            Console.WriteLine("Ordenando...");

            //                            pancake.RunSort(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();
            //                            //toDo
            //                            break;
            //                        case 6:
            //                            arregloTemp = CopiarArreglo(arregloV1);
            //                            SelectSort selects = new SelectSort();
            //                            Console.WriteLine("Ordenando...");

            //                            selects.RunSort(arregloTemp);
            //                            Console.WriteLine(arregloTemp.Mostrar());
            //                            Console.ReadLine();
            //                            //toDo
            //                            break;
            //                        default:
            //                            //toDo
            //                            break;
            //                    }
            //                } while (opcion2 != finMenu);



            //                break;
            //            case 8:
            //                Console.WriteLine("==>Vaciando el arreglo:");
            //                Console.WriteLine(arregloV1.Mostrar());
            //                Console.WriteLine("==>Arreglo vacio");
            //                arregloV1.Vaciar();
            //                Console.WriteLine(arregloV1.Mostrar());


            //                break;
            //        }
            //        Console.ReadLine();
            //    } while (opcion != finMenu);

            //}
            ///// <summary>
            ///// Metodo que imprime un menu y regresa la seleccion del usuario
            ///// </summary>
            ///// <param name="menu">string desplegable con el menu</param>
            ///// <param name="inicioMenu">parametro inicial</param>
            ///// <param name="finMenu"></param>
            ///// <param name="clear">variable que determina si se limpia o no la pantalla</param>
            ///// <returns></returns>
            //static int Menu(string menu,int inicioMenu,int finMenu,bool clear)
            //{
            //    int opcion;
            //    do
            //    {
            //        if (clear)
            //            Console.Clear();
            //        Console.Write(menu);
            //        int.TryParse(Console.ReadLine(), out opcion);
            //        if (opcion < inicioMenu || opcion > finMenu)
            //            Console.WriteLine("Opción invalida"); Console.ReadLine();

            //    } while (opcion < inicioMenu || opcion > finMenu);
            //    return opcion;
            //}
            ///// <summary>
            ///// Metodo que regresa una copia del arreglo recibido
            ///// </summary>
            ///// <param name="original"></param>
            ///// <returns></returns>
            //static ClaseArregloV2 CopiarArreglo(ClaseArregloV2 original) {
            //    ClaseArregloV2 arregloTemp = new ClaseArregloV2(original.Max);
            //    for (int i = 0; i < original.Top; i++)
            //        arregloTemp.Insertar(original.Arreglo[i]);

            //    return arregloTemp;
            //}
        } //temp
    }
}
