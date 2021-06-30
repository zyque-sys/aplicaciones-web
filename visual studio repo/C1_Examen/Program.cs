using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseArregloV3 arregloMaterias = new ClaseArregloV3(3);
            int materiasRegistradas = 0;
            int opcion;
            int inicioMenu = 1;
            int finMenu = 6;
            string menu = "1: Capturar nombre de la materia\n2: Capturar/modificar de los cortes para materias registradas\n3: Modificar nombre de materia\n4: Eliminar materia\n5: Presentar promedio de calificacion para cada materia \n6: [!]Salir[!]\nOpción:";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opción invalida");
                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\t");
                        Datos dato = new Datos();
                        dato.Materia = capturaString("Ingrese el nombre de la materia: ");
                        if (arregloMaterias.Insertar(dato))
                        {
                            Console.WriteLine("Materia agregada :)");
                            materiasRegistradas++;
                        }

                        else
                            Console.WriteLine("Error de insercion :/");
                        Console.ReadLine();
                        break;
                    case 2:
                        if (!arregloMaterias.EstaVacio())
                        {
                            
                            Mostrar(arregloMaterias,false);
                            Console.ReadLine();
                            Console.WriteLine("\t");
                            string materia = capturaString("Materia al que se le ingresara calificacion(\\q): ");
                            if (materia == "\\q")
                                break;

                            Datos tempo = new Datos();
                            tempo.Materia =materia;
                            int pos = arregloMaterias.Buscar(tempo);
                            if (pos != -1)
                            {
                                int opcion2;
                                int inicioMenu2 = 1;
                                int finMenu2 = 7;
                                string menu2 = "1: Capturar calificacion del corte 1\n2: Capturar calificacion del corte 2 \n3: Capturar calificacion del corte 3 \n4: Modificar calificacion del corte 1 \n5: Modificar calificacion del corte 2\n6: Modificar calificacion del corte 3\n7:[!]Cancelar\nOpción:";
                                do
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.Write(menu2);
                                        int.TryParse(Console.ReadLine(), out opcion2);
                                        if (opcion2 < inicioMenu2 || opcion2 > finMenu2) Console.WriteLine("Opción invalida");
                                    } while (opcion2 < inicioMenu2 || opcion2 > finMenu2);

                                    switch (opcion2)
                                    {
                                        case 1:
                                            arregloMaterias[pos].Corte1 = capturaDecimal("Ingrese su calificacion del corte 1: ");
                                            break;
                                        case 2:
                                            arregloMaterias[pos].Corte2 = capturaDecimal("Ingrese su calificacion en corte 2: ");
                                            break;
                                        case 3:
                                            arregloMaterias[pos].Corte3 = capturaDecimal("Ingrese su calificacion en corte 3: ");
                                            break;
                                        case 4:
                                            //toDo
                                            arregloMaterias[pos].Corte1 = 0;
                                            arregloMaterias[pos].Corte1 = capturaDecimal("Ingrese su NUEVA calificacion del corte 1: ");

                                            break;
                                        case 5:
                                            //toDo
                                            arregloMaterias[pos].Corte2 = 0;
                                            arregloMaterias[pos].Corte2 = capturaDecimal("Ingrese su NUEVA calificacion del corte 2: ");
                                            break;
                                        case 6:
                                            //toDo
                                            arregloMaterias[pos].Corte3 = 0;
                                            arregloMaterias[pos].Corte3 = capturaDecimal("Ingrese su NUEVA calificacion del corte 3: ");
                                            break;
                                    }
                                } while (opcion2 != finMenu2);


                            }
                            else
                                Console.WriteLine("No se encontro la materia");
                        }
                        else
                            Console.WriteLine("No hay materias registradas aun :( , procure registrar por lo menos una");
                        Console.ReadLine();
                        break;
                    case 3:
                        //toDo
                        if (!arregloMaterias.EstaVacio())
                        {

                            Mostrar(arregloMaterias,false);
                            Console.ReadLine();
                            Console.WriteLine("\t");
                            string materiaABuscar = capturaString("Seleccionar nombre de la materia(\\q): ");
                            if (materiaABuscar == "\\q")
                                break;
                            Datos tempo = new Datos();
                            tempo.Materia = materiaABuscar;
                            int pos = arregloMaterias.Buscar(tempo);
                            if (pos != -1)
                            {
                                arregloMaterias[pos].Materia ="";
                                arregloMaterias[pos].Materia = capturaString("Ingrese el NUEVO nombre de la materia: ");
                            }
                            else
                                Console.WriteLine("No se encontro la materia :(");
                        }
                        else
                            Console.WriteLine("No hay materias registradas aun :( , procure registrar por lo menos una");
                        Console.ReadLine();
                        break;
                    case 4:
                        if (!arregloMaterias.EstaVacio())
                        {

                            Mostrar(arregloMaterias,false);
                            Console.ReadLine();
                            Console.WriteLine("\t");
                            string materiaAEliminar = capturaString("Ingrese la materia a eliminar: ");
                            Datos tempo = new Datos();
                            tempo.Materia = materiaAEliminar;
                            int pos = arregloMaterias.Buscar(tempo);
                            if (pos != -1)
                            {
                                bool pass=arregloMaterias.Eliminar(tempo);
                                if (pass)
                                    Console.WriteLine("Se elimino correctamente :D");
                                else
                                    Console.WriteLine("Error al eliminar :/");
                            }
                            else
                                Console.WriteLine("No se encontro la materia :(");
                        }
                        else
                            Console.WriteLine("No hay materias registradas aun :( , procure registrar por lo menos una");
                        Console.ReadLine();
                        break;
                    case 5:

                        //toDo
                        if (!arregloMaterias.EstaVacio())
                        {
                            decimal []promedio = new decimal[3];
                            for (int i = 0; i < arregloMaterias.Top; i++)
                                promedio[i] = (arregloMaterias[i].Corte1 + arregloMaterias[i].Corte2 + arregloMaterias[i].Corte3);
                            Console.WriteLine("===PROMEDIOS===");
                            for (int j = 0; j < arregloMaterias.Top; j++)
                            {
                                Console.WriteLine(arregloMaterias[j].Materia+":");
                                asignarColor(promedio[j]/3);
                            }
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("No se pueden mostrar calificaciones porque no hay alumnos registrados :(");
                        break;
                }
            } while (opcion != finMenu);

        }//finMain
        public static string capturaString(string msg)
        {

            Console.Write(msg);
            string dato = Console.ReadLine();
            return dato;
        }
        public static void Mostrar(ClaseArregloV3 arregloMaterias,bool calificaciones)
        {
            if (!arregloMaterias.EstaVacio())
            {
                for (int i = 0; i < arregloMaterias.Top; i++)
                {
                    decimal corte1 = arregloMaterias[i].Corte1;
                    decimal corte2 = arregloMaterias[i].Corte2;
                    decimal corte3 = arregloMaterias[i].Corte3;
                
                    if (calificaciones)
                    {
                        Console.WriteLine(i + 1 + "-. [" + arregloMaterias[i].Materia + "] \nCorte 1: ");
                        asignarColor(corte1);
                        Console.WriteLine("\nCorte 2: ");
                        asignarColor(corte2);
                        Console.WriteLine("\nCorte 3: ");
                        asignarColor(corte3);
                        Console.WriteLine("\n");
                    }
                    else
                        Console.WriteLine(i + 1 + "-. [" + arregloMaterias[i].Materia + "]");
                    
                }
                    
            }
            else
            {
                Console.WriteLine("El arreglo esta vacio :(");
            }
        }
        public static void asignarColor(decimal corte)
        {
            if (corte >= 8.5m && corte<= 9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(corte);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (corte >= 7 && corte <8.4m )
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(corte);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(corte>=0&&corte<6.9m)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(corte);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
                Console.WriteLine(corte);
        }
        public static decimal capturaDecimal(string msg)
        {
            decimal dato;
            bool pass = false;
            do
            {
                Console.WriteLine(msg);
                pass = decimal.TryParse(Console.ReadLine(), out dato);
                if (!pass)
                {
                    Console.WriteLine("Error de entrada de datos");
                }
            } while (!pass);
            return dato;
        }
    }
}
