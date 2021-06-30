using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Arreglo_DatosEspeciales
{
    class Menu
    {
        static void Main(string[] args)
        {
            ClaseArregloV3 arreglo = new ClaseArregloV3(5);
            ClaseArregloV3 arregloTemp = new ClaseArregloV3(5);
            Datos dato;

            int opcion;
            int inicioMenu = 1;
            int finMenu = 8;
            //int dato;

            string menu = "===MENU===\n1:Precargar Arreglo \n2: Insertar valores \n3:Eliminar \n4:Vaciar \n5:Mostrar \n6:Buscar \n7:Ordenar \n8:[!]Salir[!] \nOpción:";
            do
            {
                opcion = ImprimeMenu(menu, inicioMenu, finMenu,true);
                switch (opcion)
                {
                    case 1:
                        arreglo.Vaciar();

                        for (int i = 0; i < 5; i++)
                        {
                            dato= new Datos();
                            dato.Nombre = "pupper" + i;
                            dato.Matricula = i;
                            dato.Grupo = i + "M";
                            dato.Calificacion = 5 + i;
                            arreglo.Insertar(dato);
                        }
                        break;
                    case 2:
                        dato = CapturaDeInfo();
                        if (arreglo.Insertar(dato))
                            Console.WriteLine("Dato insertado :)");
                        else
                            Console.WriteLine("Error de insercion :/");
                        break;
                    case 3:
                        dato = CapturaDeInfoParaEliminar();
                        if (arreglo.Eliminar(dato))
                            Console.WriteLine("Dato eliminado :)");
                        else
                            Console.WriteLine("Error de eliminacion :/");
                        break;
                    case 4:
                       
                        Console.WriteLine("==>Vaciando el arreglo:");
                        arreglo.Vaciar();
                        Console.WriteLine("==>Arreglo vacio");
                        break;
                    case 5:
                       
                        Console.WriteLine(arreglo.Mostrar());
                        //toDo
                        break;
                    case 6:
                        //int temp;
                        //Console.WriteLine("==>Ingrese el numero a buscar en el arreglo");
                        //int.TryParse(Console.ReadLine(), out dato);
                        //Console.WriteLine("Buscando dato...");
                        //if (arreglo.Buscar(dato) != -1)
                        //{
                        //    temp = arreglo.Buscar(dato);
                        //    Console.WriteLine("Se encontro el dato " + dato + " en la posicion " + temp);
                        //}
                        break;
                    case 7:
                        
                        Console.WriteLine("==>El arreglo actualmente:");
                        Console.WriteLine(arreglo.Mostrar());
                        int opcion2;
                        int inicioMenu2 = 1;
                        int finMenu2 = 7;
                        string menu2 = "\t1: BubbleSort\n\t2: HeapSort\n\t3: InsertSort\n\t4:QuickSort\n \t5:PancakeSort\n\t6:SelectSort\n\t7:[!]Salir[!]\n\tOpción:";
                        do
                        {
                            opcion2 = ImprimeMenu(menu2, inicioMenu2, finMenu2, false);
                            switch (opcion2)
                            {
                                case 1:
                                    //toDo
                                    arregloTemp = CopiarArreglo(arreglo);
                                    BubbleSort bubbles = new BubbleSort();
                                    Console.WriteLine("Ordenando...");

                                    bubbles.RunSortAscendant(arregloTemp);
                                    Console.WriteLine(arregloTemp.Mostrar());
                                    Console.ReadLine();

                                    break;
                                case 2:
                                    //arregloTemp = CopiarArreglo(arregloV1);
                                    //HeapSort hippy = new HeapSort();
                                    //Console.WriteLine("Ordenando...");

                                    //hippy.RunSort(arregloTemp);
                                    //Console.WriteLine(arregloTemp.Mostrar());
                                    //Console.ReadLine();
                                    //toDo
                                    break;
                                case 3:
                                    //arregloTemp = CopiarArreglo(arregloV1);
                                    //InsertSort inserts = new InsertSort();
                                    //Console.WriteLine("Ordenando...");

                                    //inserts.RunSort(arregloTemp);
                                    //Console.WriteLine(arregloTemp.Mostrar());
                                    //Console.ReadLine();
                                    //toDo
                                    break;
                                case 4:
                                    //arregloTemp = CopiarArreglo(arregloV1);
                                    //QuickSort quickie = new QuickSort();
                                    //Console.WriteLine("Ordenando...");

                                    //quickie.RunSort(arregloTemp);
                                    //Console.WriteLine(arregloTemp.Mostrar());
                                    //Console.ReadLine();
                                    //toDo
                                    break;
                                case 5:
                                    //arregloTemp = CopiarArreglo(arregloV1);
                                    //PancakeSort pancake = new PancakeSort();
                                    //Console.WriteLine("Ordenando...");

                                    //pancake.RunSort(arregloTemp);
                                    //Console.WriteLine(arregloTemp.Mostrar());
                                    //Console.ReadLine();
                                    //toDo
                                    break;
                                case 6:
                                    //arregloTemp = CopiarArreglo(arregloV1);
                                    //SelectSort selects = new SelectSort();
                                    //Console.WriteLine("Ordenando...");

                                    //selects.RunSort(arregloTemp);
                                    //Console.WriteLine(arregloTemp.Mostrar());
                                    //Console.ReadLine();
                                    //toDo
                                    break;
                                default:
                                    //toDo
                                    break;
                            }
                        } while (opcion2 != finMenu);



                        break;
                 
                }
                Console.ReadLine();
            } while (opcion != finMenu);

        }
        /// <summary>
        /// Metodo que imprime un menu y regresa la seleccion del usuario
        /// </summary>
        /// <param name="menu">string desplegable con el menu</param>
        /// <param name="inicioMenu">parametro inicial</param>
        /// <param name="finMenu"></param>
        /// <param name="clear">variable que determina si se limpia o no la pantalla</param>
        /// <returns></returns>
        static int ImprimeMenu(string menu,int inicioMenu,int finMenu,bool clear)
        {
            int opcion;
            do
            {
                if (clear)
                    Console.Clear();
                Console.Write(menu);
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < inicioMenu || opcion > finMenu)
                    Console.WriteLine("Opción invalida"); Console.ReadLine();

            } while (opcion < inicioMenu || opcion > finMenu);
            return opcion;
        }
        /// <summary>
        /// Metodo que regresa una copia del arreglo recibido
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        static ClaseArregloV3 CopiarArreglo(ClaseArregloV3 original) {
            ClaseArregloV3 arregloTemp = new ClaseArregloV3(original.Max);
            for (int i = 0; i < original.Top; i++)
                arregloTemp.Insertar(original.Arreglo[i]);

            return arregloTemp;
        }
        public static Datos CapturaDeInfo()
        {
            Datos a = new Datos();
            a.Matricula = capturaEntero("Dame matricula: ");
            a.Calificacion = capturaEntero("Dame calificacion: ");
            a.Grupo = capturaString("Dame grupo: ");
            a.Nombre = capturaString("Dame nombre: ");

            return a;
        }
        public static Datos CapturaDeInfoParaEliminar()
        {
            Datos a = new Datos();
            a.Matricula = capturaEntero("Dame matricula: ");
            return a;
        }
        public static int capturaEntero(string msg)
        {
            int dato;
            bool pass = false;
            do
            {
                Console.WriteLine(msg);
                pass = int.TryParse(Console.ReadLine(), out dato);
                if (!pass)
                {
                    Console.WriteLine("Error de entrada de datos");
                }
            } while (!pass);
            return dato;
        }

        public static string capturaString(string msg)
        {

            Console.Write(msg);
            string dato = Console.ReadLine();
            return dato;
        }

    }
}
