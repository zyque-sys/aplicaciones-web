using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.ClaseArreglo
{
    public class Datos
    {
        private int numUniforme;
        private string nombre;
        private double porcentaje;

        public int NumUniforme { get => numUniforme; set => numUniforme = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        /// <summary>
        /// Sobrecarga de un operados de dos objetos de tipo Datos 
        /// </summary>
        /// <param name="a">Primer objeto tipo Datos evaluado en porcentaje</param>
        /// <param name="b">Segundo objeto tipo Datos evaluado en porcentaje</param>
        /// <returns>Nuevo objeto de tipo datos con la suma de los dos objetos con la suma de un Porcentaje</returns>
        public static Datos operator +(Datos a ,Datos b)
        {
            Datos resultado = new Datos();
            resultado.Porcentaje = a.Porcentaje + b.Porcentaje;
            return resultado;
        }

        /// <summary>
        /// Compara el porcentaje del objeto a contra el porcentaje del objeto b
        /// </summary>
        /// <param name="a">Objeto de tipo Datos</param>
        /// <param name="b">Objeto de tipo Datos</param>
        /// <returns>True si el porcentaje a es mayor al porcentaje al objeto b, False en cualquier otro caso</returns>
        public static bool operator >(Datos a, Datos b)
        {
            if (a.Porcentaje>b.Porcentaje)
                return true;

            return false;
        }


        /// <summary>
        /// Compara el porcentaje del objeto a contra el porcentaje del objeto b
        /// </summary>
        /// <param name="a">Objeto de tipo Datos</param>
        /// <param name="b">Objeto de tipo Datos</param>
        /// <returns>True si el porcentaje a es menor al porcentaje al objeto b, False en cualquier otro caso</returns>
        public static bool operator <(Datos a, Datos b)
        {
            if (a.Porcentaje < b.Porcentaje)
                return true;

            return false;
        }
    }

}
