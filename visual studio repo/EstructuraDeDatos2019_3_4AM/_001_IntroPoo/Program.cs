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
            string menu = "1:Precargar arreglo con {7,3,9,4,6,5}\n2:Insertar dato en el arreglo\n3:Eliminar datos en el arreglo\n4:Vaciar arreglo\n5:Mostrar el contenido del arreglo\n6:Obtener posicion de un dato dentro del arreglo\n7:Mostrar el dato mas grande del arreglo\n8:Ordenar el arreglo\n9:[!]SALIR[!]\nOpcion:";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion<inicioMenu || opcion>finMenu)
                    {
                        Console.WriteLine("opcion invalida!!!!!!!");
                    }

                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        //toma la variable int[] arreglo de la clase ClaseArregloDesordenado y lo precarga
                        miArreglo.PrecargarCompleta();
                        Console.WriteLine("Se precargo el arreglo con: "+miArreglo.Mostrar());
                        break;
                     case 2:
                        //insertar un dato en el arreglo
                        Console.WriteLine("Dato a insertar en el arreglo :");
                        int.TryParse(Console.ReadLine(), out dato);
                        if (miArreglo.Insertar(dato))
                        {
                            Console.WriteLine("El valor "+dato+" fue insertado en el arreglo \n"+miArreglo.Mostrar());
                        }
                        else
                        {
                            Console.WriteLine("El valor "+dato+" no se pudo insertar...\n"+miArreglo.Mostrar());
                        } 
                        break;
                    case 3:
                        //Eliminar un dato en el arreglo
                        Console.WriteLine("Dato a eliminar en el arreglo :");
                        int.TryParse(Console.ReadLine(), out dato);
                        if (miArreglo.Eliminar(dato))
                        {
                            Console.WriteLine("El valor " + dato + " fue eliminado en el arreglo \n" + miArreglo.Mostrar());
                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " no se pudo eliminar...\n" + miArreglo.Mostrar());
                        }
                        break;
                    case 4:
                        //Vacia el arreglo
                        miArreglo.Vaciar();
                        Console.WriteLine("Se vacio el arreglo :" + miArreglo.Mostrar());
                        break;
                    case 5:
                        //muestra el arreglo actual
                        Console.WriteLine("Arreglo: "+ miArreglo.Mostrar());
                        break;
                    case 6:
                        //Busca un dato y proporciona su posicion 
                        Console.WriteLine("Dato a buscar en el arreglo :");
                        int.TryParse(Console.ReadLine(), out dato);
                        int posicion = miArreglo.BuscarValorArreglo(dato);
                        if (posicion!=-1)
                        {
                            Console.WriteLine("El valor " + dato + " se encuentra en la posicion "+posicion+"\nArreglo completo:" + miArreglo.Mostrar());
                        }
                        else
                        {
                            Console.WriteLine("El valor " + dato + " no existe en el arreglo...\n" + miArreglo.Mostrar());
                        }
                        break;
                    case 7:
                        int mayor = miArreglo.ObtenerMayor();
                        if (mayor!=int.MinValue)
                            Console.WriteLine("El valor mas grande del arreglo es:" + mayor + "\nArreglo: " + miArreglo.Mostrar());
                        else
                            Console.WriteLine("El arreglo esta vacio \nArreglo: " + miArreglo.Mostrar());
                        break;
                    case 8:
                        //EL tuduuuu
                        break;

                }
                if (opcion != finMenu)
                {
                    Console.ReadLine();
                }
              
            }
            while (opcion != finMenu);

        }

    }
}
