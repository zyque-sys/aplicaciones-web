using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos02
{
    class Ejercicio01_metodos
    {

        static void Main(string[] args)
        {   //instancia de la clase
            ClaseMetodos metodos = new ClaseMetodos();
            
            //asignacion de valores en los campos de la clase
            metodos.ValorA = 10;
            metodos.ValorB = 15;

            //ejecucion del metodo suma
            int valor=metodos.Suma();
            Console.WriteLine("La suma de los campos del objeto es: "+valor);

            valor = metodos.Suma(1, 6);

            Console.WriteLine("La suma de los argumentos enteros es "+valor);

            Console.WriteLine("Clase Ejecutable");
            Console.ReadLine();
        }
    }
}
