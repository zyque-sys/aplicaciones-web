using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ExamenC1
{
    class ClaseArregloDesordenado
    {

        #region Campos
        /// <summary>
        /// Cantidad de localidades del arreglo
        /// </summary>
        int max;
        /// <summary>
        /// Posicion siguiente al ultimo valor en el arreglo.
        /// </summary>
        int top;
        int[] arreglo;
        #endregion
        #region Constructor
        /// <summary>
        /// Método constructor  de la ClaseArregloDesordenado
        /// </summary>
        /// <param name="m"> Indica el tamaño del arreglo </param>
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
            this.max = this.arreglo.Length;
            this.top = this.arreglo.Length;
            Console.WriteLine("Operación satisfactoria");
        }

        /// <summary>
        /// Critico Esta Lleno para validad la posibilidad de Insertar
        /// </summary>
        /// <returns>True si el arreglo esta lleno o False si el arreglo no lo esta</returns>
        public bool EstaLleno()
        {
            if (this.top == 0)
                return true;
            return false;
        }
        /// <summary>
        /// Critico Esta Vacio para validad la posibilidad de Eliminar.
        /// </summary>
        /// <returns>True si esta vacio o False si no lo esta</returns>
        public bool EstaVacio()
        {
            if (this.top == this.max)
                return true;
            return false;
        }
        /// <summary>
        /// Metodo que permite insertar un nuevo valor dentro del arreglo
        /// </summary>
        /// <param name="dato">Valor a agregar en el arreglo</param>
        /// <returns>True si el valor se inserto en el arreglo o False si no se pudo insertar</returns>
        /// 
        public bool Insertar(int dato)
        {
            if (!EstaLleno())
            {
                for (int i = this.max; i <this.max; i--)
                {
                    if (this.arreglo[i] == dato)
                    {
                        return false;
                    }
                }
                this.arreglo[this.top] = dato;
                this.top--;
                return true;
            }//fin del critico
            return false;
        }
        /// <summary>
        /// Genera un numero aleatorio
        /// </summary>
        /// <returns>Regresa un numero entre 1 y 1,000,000</returns>
        private int RN()
        {
            Thread.Sleep(5);
            Random random = new Random();
            return random.Next(1, 1000000);
        }
        /// <summary>
        /// Metodo que busca un valor dentro del arreglo y lo elimina.
        /// </summary>
        /// <param name="dato">Valor a buscar dentro del arreglo para eliminarlo</param>
        /// <returns>True si el valor se elimino o False en caso contrario</returns>
        public bool Eliminar(int dato)
        {
            if (!EstaVacio())
            {
                for (int i = this.max; i > this.top; i--)
                {
                    if (this.arreglo[i] == dato)
                    {
                        for (int y = i; y < this.top - 1; y++)
                        {
                            this.arreglo[y] = this.arreglo[y + 1];
                        }
                        this.top--;
                        return true;
                    }
                }
            }//fin del critico
            return false;
        }
        /// <summary>
        /// Metodo que regresa una cadena de caracteres que representa el contenido del arreglo
        /// </summary>
        /// <returns>Cadena con el contenido del arreglo</returns>
        public string Mostrar()
        {

            string resultado = "Contenido: {";
            if (!EstaVacio())
            {
                for (int i = 0; i < this.top; i++)
                {
                    resultado += this.arreglo[i];
                    if (i < this.top - 1)
                    {
                        resultado += ",";
                    }
                }

                resultado += "}\nPosicion: {";
                int[] posicion = new int[this.max+1];
                for (int i = 1; i < this.max+1; i++)
                {
                    posicion[i] = i;
                    resultado += posicion[i];
                    if (i < this.top - 1)
                    {
                        resultado += ",";
                    }
                }
                resultado += "}";
                return resultado;
            }
            return "";
        }
        public string Mostrar2()
        { string cosa="\nIndice: [";

              char[] indice = new char[this.max];
            for (int i = this.max; i <= this.max; i--)
            {
                for (int j = 0; j < this.top; j++)
                {
                    if (this.arreglo[j] != 0)
                    {
                        indice[i] = 'T';
                        cosa += indice[i];
                    }
                }
            }
            cosa += "]";
            return cosa;
        }
        /// <summary>
        /// Metodo que ordena el contenido del arreglo
        /// </summary>
        /// <returns>True si el arreglo se ordeno o False en caso contrario</returns>
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
                if (this.arreglo[i] > mayor)
                {
                    mayor = this.arreglo[i];
                }
            }
            return mayor;
        }
        /// <summary>
        /// Método que vacía el arreglo
        /// </summary>
        public void Vaciar()
        {
            this.top = 0;
        }
        /// <summary>
        /// Método que busca un valor en el arreglo
        /// </summary>
        /// <param name="dato">Valor entero a buscar dentro del arreglo</param>
        /// <returns>Numero entero 0 o mayor para indicar el indice (posición) del valor buscado; -1 en el caso de que el valor no exista en el arreglo</returns>
        public int BuscarValorEnArreglo(int dato)
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
    }
}
