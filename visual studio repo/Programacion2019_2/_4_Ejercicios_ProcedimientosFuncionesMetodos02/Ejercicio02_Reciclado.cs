using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos02
{
    class Ejercicio02_Reciclado
    {
        static void Main(string [] args){
            int valor;
            GetNumber numero = new GetNumber(); // instancia de la clase

            do
            {
                valor = numero.GetInt("Ingrese un numero entero: ", "Error, solo puedes ingresar numeros enteeros");
                if (!(valor > 0 && valor <= 10))
                {
                    Console.WriteLine("Error");
                }
            } while (!(valor>0 && valor<=10));
            Console.ReadLine();
        }
    }
}
