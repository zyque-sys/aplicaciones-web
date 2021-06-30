using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseArregloDesordenado miArreglo = new ClaseArregloDesordenado(10);
            string menu = "A:Precargar arreglo \n" +
            "B:Insertar Dato en el arreglo\n" +
            "C:Eliminar Dato en el arreglo\n" +
            "D:Vaciar arreglo\n" +
            "E:Obtener posicion de un dato dentro del arreglo\n" +
            "F:Mostrar el dato mas grande del arreglo\n" +
            "Z: [!]Salir \n" +
            "Opcion: \n" ;
            string opcion="";
            string finMenu ="Z" ;
            int dato;
            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine(miArreglo.Mostrar());
                    
                    Console.WriteLine(menu);
                    opcion=Console.ReadLine().ToUpper();
                    if ((opcion != "A" && opcion != "B" && opcion != "C" && opcion != "D" && opcion != "E" && opcion != "F" && opcion != "Z"))
                    {
                        Console.WriteLine("Ingrese solo las opciones contenidas en el menu...");
                    }
                } while ((opcion != "A" && opcion != "B" && opcion != "C" && opcion != "D" && opcion != "E" && opcion != "F" && opcion != "Z"));
                switch (opcion)
                {
                    case "A":
                        miArreglo.PrecargarCompleta();
                        Console.WriteLine();
                        break;
                    case "B":
                        Console.WriteLine("Dato a insertar dentro del arreglo: ");
                        int.TryParse(Console.ReadLine(), out dato);
                        if (miArreglo.Insertar(dato))
                        {
                            Console.WriteLine("El valor " + dato + " fue insertado en el arreglo" + miArreglo.Mostrar());

                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " no fue insertado en el arreglo" + miArreglo.Mostrar());
                        }
                        break;
                    case "C":
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
                    case "D":
                        miArreglo.Vaciar();
                        Console.WriteLine("El arreglo se vacio" + miArreglo.Mostrar()); break;
                    case "E":
                        Console.WriteLine("Dato a encontrar dentro del arreglo: ");
                        int.TryParse(Console.ReadLine(), out dato);
                        int posicion = miArreglo.BuscarValorEnArreglo(dato);
                        if (posicion != -1)
                        {
                            Console.WriteLine("El valor " + dato + " se encuentra en la posicion" + posicion + miArreglo.Mostrar());

                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " NO se encontro en el arreglo\n" + miArreglo.Mostrar());
                        }
                        break;
                    case "F":
                        int mayor = miArreglo.ObtenerMayor();
                        if (mayor != int.MinValue)
                            Console.WriteLine("El valor mas grande del arreglo es: " + mayor + "" + miArreglo.ObtenerMayor());
                        else
                            Console.WriteLine("El arreglo esta vacio" + miArreglo.ObtenerMayor()); break;
                    


                }
                if (opcion != finMenu)
                    Console.ReadLine();
            } while (opcion != finMenu);
        }
    }
}
