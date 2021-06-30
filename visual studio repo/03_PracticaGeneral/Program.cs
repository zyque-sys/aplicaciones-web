using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PracticaGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseArregloV3 arregloAlumnos = new ClaseArregloV3(10);
            
            
            int alumnosConCalificacion=0;
            int alumnosRegistrados=0;
            int opcion;
            int inicioMenu = 1;
            int finMenu = 5;
            string menu = "===MENU===\n1: Registrar estudiante\n2: Registrar calificaciones\n3: Mostrar listas de estudiantes\n4: Mostrar promedio de calificaciones por materia\n5: [!]Salir[!]\nOpción:";
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Numero de alumnos registrados: "+alumnosRegistrados);
                    Console.Write(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opción invalida");
                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\t");
                        Datos dato = new Datos();
                        dato.Matricula = capturaEntero("Dame matricula: ");
                        dato.Nombre = capturaString("Dame nombre: ");
                        dato.ApellidoMaterno = capturaString("Ingrese su apellido materno: ");
                        dato.ApellidoPaterno = capturaString("Ingrese su apellido paterno: ");

                        if (arregloAlumnos.Insertar(dato))
                        {
                            Console.WriteLine("Alumno agregado :)");
                            alumnosRegistrados++;
                            
                        }
                        else
                            Console.WriteLine("Error de insercion :/");
                        break;
                    case 2:
                        if (!arregloAlumnos.EstaVacio())
                        {
                            Console.WriteLine("Numero de alumnos con calificacion: "+alumnosConCalificacion);
                            Mostrar(arregloAlumnos);
                            Console.ReadLine();
                            Console.WriteLine("\t");
                                string alumno = capturaString("Estudiante al que se le ingresara calificacion(/q): ");
                                if (alumno == "/q")
                                break;

                                Datos tempo = new Datos();
                                tempo.Nombre = alumno;
                                int pos = arregloAlumnos.Buscar(tempo);
                                if (pos != -1)
                                {
                                    arregloAlumnos[pos].CalifMate = capturaDecimal("Ingrese su calificacion en MATEMATICAS: ");
                                    arregloAlumnos[pos].CalifFisica = capturaDecimal("Ingrese su calificacion en FISICA: ");
                                    arregloAlumnos[pos].CalifProgra = capturaDecimal("Ingrese su calificacion en PROGRAMACION: ");
                                    alumnosConCalificacion++;
                                }
                                else
                                    Console.WriteLine("No se encontro el alumno :(");
                        }
                        else
                            Console.WriteLine("No hay alumnos registrados aun :( , procure registrar por lo menos uno");

                        break;
                    case 3:
                        Mostrar(arregloAlumnos);
                        break;
                    case 4:
                        if (!arregloAlumnos.EstaVacio())
                        {
                            decimal calificacionesMate = 0;
                            decimal calificacionesFisica = 0;
                            decimal calificacionesProgra = 0;
                            for (int i = 0; i < arregloAlumnos.Top; i++)
                            {
                                calificacionesMate += arregloAlumnos[i].CalifMate;
                                calificacionesFisica += arregloAlumnos[i].CalifFisica;
                                calificacionesProgra += arregloAlumnos[i].CalifProgra;
                            }
                            Console.WriteLine("Promedios\nMatematicas: " + calificacionesMate/alumnosRegistrados + "\nFisica: " + calificacionesFisica/ alumnosRegistrados + "\nProgramacion: " + calificacionesProgra / alumnosRegistrados);
                        }
                        else
                            Console.WriteLine("No se pueden mostrar calificaciones porque no hay alumnos registrados :(");
                        break;
                }
                Console.ReadLine();
            } while (opcion != finMenu);

        }//finMain
  
        static ClaseArregloV3 CopiarArreglo(ClaseArregloV3 original)
        {
            ClaseArregloV3 arregloTemp = new ClaseArregloV3(original.Max);
            for (int i = 0; i < original.Top; i++)
                arregloTemp.Insertar(original.Arreglo[i]);

            return arregloTemp;
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

        public static void Mostrar(ClaseArregloV3 arregloAlumnos)
        {
            if (!arregloAlumnos.EstaVacio())
            {
                for (int i = 0; i < arregloAlumnos.Top; i++)
                    Console.WriteLine(i + 1 + "-. [" + arregloAlumnos[i].Matricula + "] " + arregloAlumnos[i].Nombre + " " + arregloAlumnos[i].ApellidoPaterno + " " + arregloAlumnos[i].ApellidoMaterno + "\n");
            }
            else
            {
                Console.WriteLine("El arreglo esta vacio :(");
            }
        }
    }
}
