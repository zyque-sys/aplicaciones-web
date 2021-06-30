using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            //PROCEDIMIENTOS:::calculo de suma varias veces
            procedimientoSuma(1, 2);
            procedimientoSuma(1, 2);
            procedimientoSuma(1, 2);
            procedimientoSuma(1,2);

            //FUNCIONES:::impresion de variable vaias veces(consume menos memoria)
            int valor = funcionSuma(1, 2);
            Console.WriteLine("La suma es"+valor);
            Console.WriteLine("La suma es" + valor);
            Console.WriteLine("La suma es" + valor);
            Console.WriteLine("La suma es" + valor);

            Console.ReadLine();
            #region procedimiento o funciones
            void procedimientoSuma(int a, int b)
            {
                Console.WriteLine("La suma es : "+(a+b));
            }

            int funcionSuma(int a,int b)//aqui no puede haber declaracion de variables dentro si estan delaradas en otra parte
            {
                return a + b;
            }//fin del main

            #endregion
        }
    }//fin del main
}
