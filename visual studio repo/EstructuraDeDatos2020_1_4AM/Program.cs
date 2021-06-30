using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arreglo_DatosEspeciales
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseArregloV3 arreglov3 = new ClaseArregloV3(5);

            for (int i = 0; i < arreglov3.Max; i++)
            {
                Console.WriteLine("Ingrese los datos de la posicion {0}: ",i);
                arreglov3.Insertar(CapturaDeInfo());
                Console.WriteLine();
            }
            
            Console.WriteLine(arreglov3.Mostrar());
            Console.ReadLine();
        }//finMain
        public static Datos CapturaDeInfo() {
            Datos a = new Datos();
            a.Matricula =capturaEntero("Dame matricula: ");
            a.Calificacion = capturaEntero("Dame calificacion: ");
            a.Grupo = capturaString("Dame grupo: ");
            a.Nombre = capturaString("Dame nombre: "); 
            
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
