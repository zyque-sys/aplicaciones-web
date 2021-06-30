using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PilaEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo auto;
            int tamanhoEstacionamiento=3;
            Pila estacionamiento = new Pila(tamanhoEstacionamiento);

            int opcion;
            int inicioMenu = 1;
            int finMenu = 4;
            string menu = "1: Ingresar auto\n2: Retirar auto\n3: Mostrar Estacionamiento\n4: [!]Salir[!]\nOpción:";
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
                        if (estacionamiento.Top != tamanhoEstacionamiento)
                        {
                            auto = new Nodo();
                            auto.Placas = capturaString("Ingrese placa del auto:");
                            auto.Propietario = capturaString("Ingrese nomre del propietario:");
                            auto.HoraEntrada = DateTime.Now;
                            estacionamiento.Push(auto);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Estacionamiento lleno...No es posible ingresar mas autos :C");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        break;
                    case 2:
                        DateTime salidaAuto = DateTime.Now;
                        if (estacionamiento.Top!=0)
                        {
                            auto=estacionamiento.Pop();
                            Console.WriteLine("Placas:"+auto.Placas);
                            Console.WriteLine("Propietario:"+auto.Propietario);
                            Console.WriteLine("Hora de Ingreso:"+auto.HoraEntrada);
                            int minutos = MinutosTranscurridos(auto.HoraEntrada,salidaAuto);
                            Console.WriteLine("Cobrar: $"+(0.25*minutos));
                        }
                        break;
                    case 3:
                        //toDo
                        //Mostrar todos los carros en el estacionamiento(en el main, muestra solo las placas)
                        break;
                    default:
                        //toDo
                        break;
                }
            } while (opcion != finMenu);

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
        public static string Mostrar(Pila pila)
        {
            //toDo
            return "";
        }
        static int MinutosTranscurridos(DateTime inicio,DateTime fin)
        {
            //toDo
            return -1;
        }
        static int DiasTranscurridos(DateTime inicio, DateTime fin)
        {
            //toDo
            return -1;
        }
        static int AñosTranscurridos(DateTime inicio, DateTime fin)
        {
            //toDo
            return -1;
        }
        static int SegundosTranscurridos(DateTime inicio, DateTime fin)
        {
            //toDo
            return -1;
        }
        static float HorasTranscurridos(DateTime inicio, DateTime fin)
        {
            //toDo
            return -0.0f;
        }
    }
}
