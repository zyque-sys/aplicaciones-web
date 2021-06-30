using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MetodosEjercicios
{
    class ClaseEjecutables
    {
        static void Main(string[] args)
        {
            int valor;
            string menu =
"\n██████╗ ██████╗  █████╗  ██████╗████████╗██╗ ██████╗ █████╗ ███████╗     ██████╗ ██████╗ ███╗   ██╗    ███╗   ███╗███████╗████████╗ ██████╗ ██████╗  ██████╗ ███████╗"+
"\n██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██║██╔════╝██╔══██╗██╔════╝    ██╔════╝██╔═══██╗████╗  ██║    ████╗ ████║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗██╔═══██╗██╔════╝"+
"\n██████╔╝██████╔╝███████║██║        ██║   ██║██║     ███████║███████╗    ██║     ██║   ██║██╔██╗ ██║    ██╔████╔██║█████╗     ██║   ██║   ██║██║  ██║██║   ██║███████╗"+
"\n██╔═══╝ ██╔══██╗██╔══██║██║        ██║   ██║██║     ██╔══██║╚════██║    ██║     ██║   ██║██║╚██╗██║    ██║╚██╔╝██║██╔══╝     ██║   ██║   ██║██║  ██║██║   ██║╚════██║"+
"\n██║     ██║  ██║██║  ██║╚██████╗   ██║   ██║╚██████╗██║  ██║███████║    ╚██████╗╚██████╔╝██║ ╚████║    ██║ ╚═╝ ██║███████╗   ██║   ╚██████╔╝██████╔╝╚██████╔╝███████║"+
"\n╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝    ╚═╝     ╚═╝╚══════╝   ╚═╝    ╚═════╝ ╚═════╝  ╚═════╝ ╚══════╝"+
             "\n1.Crear un metodo que indique si una cadena contiene exclusivamente numeros"+
             "\n2.Crear un metodo que regrese el numero entero contenido en una cadena de caracteres"+
             "\n3.Crear un metodo que imprima en pantalla la tabla de multiplicar seleccionada por el usuario"+
             "\n4.Realizar un metodo que indique si un numero es par o no usando true o false"+
             "\n5.Realizar un metodo que imprima los primeros N numeros impares"+
             "\n6.Realizar un metodo que imprima los primeros N numeros de la serie de fibonacci"+
             "\n7.Realizar un metodo que indique si el resultado de una division es exacto o no"+
             "\n--> 8.Realice un programa que presente donde se ejecute cada uno de los metodos anteriormente descritos"+
             "\n9.Realice un metodo para pintar un recuadro utilizando los simbolos dentro de un arreglo que se enviara"+
             "\n como parametro "+
             "\n[!][INGRESE 0 PARA SALIR][!]";
            ClaseMetodos practicas = new ClaseMetodos();
            GetNumber ingreso = new GetNumber();
            ClaseMetodos marco = new ClaseMetodos();
            string dato;
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                valor = ingreso.GetInt("Ingrese un numero", "Solo un numero entero");
                switch (valor)
                {
                    case 1:
                        Console.Clear();
                        practicas.Metodo1();
                        break;
                    case 2:
                        Console.Clear();
                        practicas.Metodo2();
                        break;
                    case 3:
                        Console.Clear();
                        practicas.Metodo3();
                        break;
                    case 4:
                        Console.Clear();
                        practicas.Metodo4();
                        break;
                    case 5:
                        Console.Clear();
                        practicas.Metodo5();
                        break;
                    case 6:
                        Console.Clear();
                        practicas.Metodo6();
                        break;
                    case 7:
                        Console.Clear();
                        practicas.Metodo7();
                        break;
                    case 8:
                        Console.WriteLine("El caso ocho es solo este menu"); break;
                    case 9:
                        Console.WriteLine("La decoracion de este menu es realizada por el metodo 9"); break;

                }
            } while (valor != 0);
        }
    }

    }

