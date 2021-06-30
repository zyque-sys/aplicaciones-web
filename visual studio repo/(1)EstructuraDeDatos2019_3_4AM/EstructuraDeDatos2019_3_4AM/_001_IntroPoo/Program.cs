using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_IntroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseArregloDesordenado miArreglo = new ClaseArregloDesordenado(6);

            int dato;
            int opcion;
            int inicioMenu = 1;
            int finMenu = 9;
            string menu = "1: Precargar arreglo con {7,3,9,4,6,5}\n" +
                "2: Insertar dato en el arreglo\n" +
                "3: Eliminar dato del arreglo\n" +
                "4: Vaciar el arreglo\n" +
                "5: Mostrar el contenido del arreglo\n" +
                "6: Obtener posicion de un dato dentro del arreglo\n" +
                "7: Mostrar el dato mas grande del arreglo\n" +
                "8: Ordenar el arreglo\n" +
                "9: Salir\n" +
                "Opcion:";

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opcion invalida");
                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        miArreglo.PrecargarCompleta();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Dato a insertar dentro del arreglo: ");
                        int.TryParse(Console.ReadLine(), out dato);
                        if (miArreglo.Insertar(dato))
                        {
                            Console.WriteLine("El valor " + dato + " fue insertado en el arreglo"+miArreglo.Mostrar());

                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " no fue insertado en el arreglo"+miArreglo.Mostrar());
                        }

                        break;
                    case 3:
                        Console.WriteLine("Dato a eliminar dentro del arreglo: ");
                        int.TryParse(Console.ReadLine(), out dato);
                        if (miArreglo.Eliminar(dato))
                        {
                            Console.WriteLine("El valor " + dato + " fue eliminar en el arreglo" + miArreglo.Mostrar());

                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " no fue eliminar en el arreglo" + miArreglo.Mostrar());
                        }
                        break;
                    case 4:
                        miArreglo.Vaciar();
                        Console.WriteLine("El arreglo se vacio" + miArreglo.Mostrar());
                        break;
                    case 5:
                        Console.WriteLine(miArreglo.Mostrar());
                        break;
                    case 6:
                        Console.WriteLine("Dato a encontrar dentro del arreglo: ");
                        int.TryParse(Console.ReadLine(), out dato);
                        int posicion = miArreglo.BuscarValorEnArreglo(dato);
                        if (posicion!=-1)
                        {
                            Console.WriteLine("El valor " + dato + " se encuentra en la posicion" + posicion + miArreglo.Mostrar());

                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " NO se encontro en el arreglo\n"+ miArreglo.Mostrar());
                        }
                        break;
                    case 7:
                        int mayor = miArreglo.ObtenerMayor();
                        if (mayor != int.MinValue)
                            Console.WriteLine("El valor mas grande del arreglo es: "+ mayor +""+miArreglo.ObtenerMayor());
                        else
                            Console.WriteLine("El arreglo esta vacio" + miArreglo.ObtenerMayor());
                        break;
                    case 8:
                        break;
                }
                if (opcion != 9)
                Console.ReadLine();

            } while (opcion != 9);

        }

        
    }
}
