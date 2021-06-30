using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Librerias.ClaseArreglo
{
   public class ClaseArregloDesordenadoDatos
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
        Datos[] arreglo;

        public int Top { get => top;}
        public Datos[] Arreglo { get => arreglo;}

        //public Datos[] Arreglo { get => arreglo; set => arreglo = value; }
        #endregion
        #region Constructor
        /// <summary>
        /// Método constructor  de la ClaseArregloDesordenado
        /// </summary>
        /// <param name="m"> Indica el tamaño del arreglo </param>
        public ClaseArregloDesordenadoDatos(int m)
        {
            this.arreglo = new Datos[m];
            this.top = 0;
            this.max = m;
        }
        #endregion
        //public void PrecargarCompleta()
        //{
        //    this.arreglo = new int[] { 7, 3, 9, 4, 6, 5 };
        //    this.max = this.arreglo.Length;
        //    this.top = this.arreglo.Length;
        //    Console.WriteLine("Operación satisfactoria");
        //}
    

        /// <summary>
        /// Critico Esta Lleno para validad la posibilidad de Insertar
        /// </summary>
        /// <returns>True si el arreglo esta lleno o False si el arreglo no lo esta</returns>
        public bool EstaLleno()
        {
            if (this.top == this.max)
                return true;
            return false;
        }
        /// <summary>
        /// Critico Esta Vacio para validad la posibilidad de Eliminar.
        /// </summary>
        /// <returns>True si esta vacio o False si no lo esta</returns>
        public bool EstaVacio()
        {
            if (this.top == 0)
                return true;
            return false;
        }
        /// <summary>
        /// Metodo que permite insertar un nuevo valor dentro del arreglo
        /// </summary>
        /// <param name="dato">Valor a agregar en el arreglo</param>
        /// <returns>True si el valor se inserto en el arreglo o False si no se pudo insertar</returns>
        public bool Insertar(Datos dato)
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i] == dato)
                    {
                        return false;
                    }
                }
                this.arreglo[this.top] = dato;
                this.top++;
                return true;
            }//fin del critico
            return false;
        }
        /// <summary>
        /// Metodo que busca un valor dentro del arreglo y lo elimina.
        /// </summary>
        /// <param name="dato">Valor a buscar dentro del arreglo para eliminarlo</param>
        /// <returns>True si el valor se elimino o False en caso contrario</returns>
        public bool Eliminar(Datos dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i].Nombre == dato.Nombre)
                    {
                        for (int y = i; y < this.top - 1; y++)
                        {
                            this.arreglo[y] = this.arreglo[y + 1];
                        }
                        this.top--;
                        return true;
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
        public Datos[] Mostrar()
        {
            Datos[] salida=new Datos[this.top];
          
                for (int i = 0; i < this.top; i++)
                {
                    salida[i] = this.arreglo[i];
                }
            
          
            return salida;
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
        public Datos[] ObtenerMayor()
        {

            Datos[] mayor = new Datos[1]{ new Datos()};
            //mayor[0] = new Datos();
            mayor[0].Porcentaje = double.MinValue;

            for (int i = 0; i < this.top; i++)
            {
                if (this.arreglo[i].Porcentaje > mayor[0].Porcentaje)
                {
                    mayor[0] = this.arreglo[i];
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
        public int BuscarValorEnArreglo(Datos dato)
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
        public void Swap(int origen,int destino)
        {
            Datos temp = arreglo[origen];
            arreglo[origen] = arreglo[destino];
            arreglo[destino] = temp;

        }
  
    }
}
