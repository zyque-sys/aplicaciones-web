using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_IntroPoo
{
    class ClaseArregloDesordenado
    {
        #region Campos
        int max;
        int top;
        int[] arreglo;
        #endregion


        #region Constructor
        /// <summary>
        /// Metodo constructor de la clase
        /// </summary>
        /// <param name="m">Indica el tamaño del arreglo</param>
        public ClaseArregloDesordenado(int m)
        {
            this.arreglo = new int[m];
            this.top = 0;
            this.max = m;

        }
        #endregion
        public void PrecargarCompleta()
        {
            this.arreglo = new int[] { 7, 3, 9, 4, 6, 5 };
            this.max = this.arreglo.Length;//6
            this.top= this.arreglo.Length; 

        }
        
        /// <summary>
        /// Metodo  que determina si el arreglo esta lleno,valida al metodo Eliminar e Insertar
        /// </summary>
        /// <returns>True si esta lleno, False si no lo esta</returns>
        public bool EstaLleno()
        {
            if (this.top == this.max)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metodo que determina si el arreglo esta vacio , para validar al metodo Eliminar e Insertar
        /// </summary>
        /// <returns>True si esta vacio y False si no lo esta</returns>
        public bool EstaVacio()
        {
            if(this.top==0)
                return true;

            return false;
        }
        /// <summary>
        /// Metodo que vacia el arreglo
        /// </summary>
        public void Vaciar()
        {
            this.top = 0;

        }
        /// <summary>
        /// Metodo que inserta un valor en el arreglo
        /// </summary>
        /// <param name="dato">Valor a arreglar en el arreglo</param>
        /// <returns></returns>
        public bool Insertar(int dato)
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i]==dato)
                        return false;
                }
                this.arreglo[this.top] = dato;
                this.top++;
                return true;
            }//fin del critico
            return false;
          
        }
        /// <summary>
        /// Metodo que elimina un elemento del arreglo,validado por el metodo EstaVacio
        /// </summary>
        /// <param name="dato">dato a eliminar</param>
        /// <returns>True si pudo eliminar el dato</returns>
        public bool Eliminar(int dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i]==dato)
                    {
                        for (int j = i; j < this.top-1; j++)
                        {
                            this.arreglo[j] = this.arreglo[j + 1];
                            this.top--;
                            return true;
                        }
                    }
                }
                return false;
            }//fin del critico
            return false;
        }
        /// <summary>
        /// Metodo que regresa una cadena de caracteres que representa el contenido del arreglo
        /// </summary>
        /// <returns>Cadena con el contenido del arreglo</returns>
        public string Mostrar()
        {
            string salida = "{";
            for (int i = 0; i < this.top; i++)
            {
                salida += this.arreglo[i];
                if (i<this.top-1)
                {
                    salida += ",";
                }
            }
            salida += "}";
            return salida;
        }
        /// <summary>
        /// Metodo que regresa el indice de un valor dentro del arreglo
        /// </summary>
        /// <param name="dato">valor entero a buscar en el arreglo</param>
        /// <returns>numero entero mayor o igual a 0 para indicar la posicion(inidice) del valor buscado;-1 en caso de queel valor no exista en el arreglo</returns>
        public int BuscarValorArreglo(int dato)
        {
            for (int i = 0; i < this.top; i++)
            {
                if (this.arreglo[i] == dato)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Metodo que ordena el contenido del arreglo
        /// </summary>
        /// <returns>True si el arreglo se ordeno y False si no se ordeno</returns>
        public bool Ordenar()
        {
            return true;
        }
        /// <summary>
        /// Metodo que regresa el valor mas grande almacenado en el arreglo
        /// </summary>
        /// <returns>Valor mayor dentro del arreglo</returns>
        public int ObtenerMayor()
        {
            int mayor = int.MinValue;
            for (int i = 0; i < this.top; i++)
            {
                if (this.arreglo[i]>mayor)
                {
                    mayor = this.arreglo[i];
                }
            }
            return mayor;
        }
    }

}
