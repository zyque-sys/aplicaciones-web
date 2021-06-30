using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos02
{
    class GetNumber
    {

        /// <summary>
        /// Regresa un entero
        /// </summary>
        /// <param name="msj">Mensaje de ingreso</param>
        /// <param name="errorMsj">Error de conversion</param>
        /// <returns></returns>
        public int GetInt(string msj,string errorMsj)
        {
            int valor;
            bool valido;
            do
            {
                Console.WriteLine(msj);
                valido = int.TryParse(Console.ReadLine(), out valor);
                if (!valido)
                {
                    Console.WriteLine(errorMsj);
                }
            } while (!valido);
            return valor;
        }


        /// <summary>
        /// Regresa un flotante
        /// </summary>
        /// <param name="msj">Mensaje de ingreso</param>
        /// <param name="errorMsj">Error de conversion</param>
        /// <returns></returns>
        public float GetFloat(string msj, string errorMsj)
        {
            float valor;
            bool valido;
            do
            {
                Console.WriteLine(msj);
                valido = float.TryParse(Console.ReadLine(), out valor);
                if (!valido)
                {
                    Console.WriteLine(errorMsj);
                }
            } while (!valido);
            return valor;
        }


        /// <summary>
        /// Regresa un double
        /// </summary>
        /// <param name="msj">Mensaje de ingreso</param>
        /// <param name="errorMsj">Error de conversion</param>
        /// <returns></returns>
        public double GetDouble(string msj, string errorMsj)
        {
            double valor;
            bool valido;
            do
            {
                Console.WriteLine(msj);
                valido = double.TryParse(Console.ReadLine(), out valor);
                if (!valido)
                {
                    Console.WriteLine(errorMsj);
                }
            } while (!valido);
            return valor;
        }




        /// <summary>
        /// Regresa un decimal
        /// </summary>
        /// <param name="msj">Mensaje de ingreso</param>
        /// <param name="errorMsj">Error de conversion</param>
        /// <returns></returns>
        public decimal GetDecimal(string msj, string errorMsj)
        {
            decimal valor;
            bool valido;
            do
            {
                Console.WriteLine(msj);
                valido = decimal.TryParse(Console.ReadLine(), out valor);
                if (!valido)
                {
                    Console.WriteLine(errorMsj);
                }
            } while (!valido);
            return valor;
        }




    }
}
