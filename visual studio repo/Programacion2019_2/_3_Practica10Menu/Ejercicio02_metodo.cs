using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos
{
    class Ejercicio02_metodo
    {
        static void Main(string[] args)
        {
            ClaseSuma objetoSuma;
            objetoSuma = new ClaseSuma();
            int valor =objetoSuma.suma(11, 2);
            objetoSuma.valorA = 5;
            objetoSuma.valorB = 8;
            Console.WriteLine("La suma es: "+valor);
            Console.WriteLine("la suma desde metodo sin parametros:"+objetoSuma.suma());
            Console.ReadLine();

        }
    }
}
