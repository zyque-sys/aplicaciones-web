using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PracticaGeneral
{
    public class ClaseArregloV3
    {
        #region Campos
        private Datos[] arreglo;
        private int max;
        private int top;

        public int Top { get => top; set => top = value; }
        public int Max { get => this.max; set => this.max = value; }
        public Datos[] Arreglo { get => arreglo; set => arreglo = value; }


        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="m"></param>
        public ClaseArregloV3(int m)
        {
            this.arreglo = new Datos[m];
            this.max = m;
            this.top = 0;
        }

        /// <summary>
        /// Este Metodo intergambia los datos dentro de un arreglo indicados por los indices
        /// </summary>
        /// <param name="index1">Indice del valor 1 a intercambiar</param>
        /// <param name="index2">Indice del valor 2 a intercambiar</param>
        public void Swap(int index1, int index2)
        {
            Datos temporal = this.Arreglo[index1];

            Arreglo[index1] = Arreglo[index2];

            Arreglo[index2] = temporal;
        }
        /// <summary>
        /// Metodo para encontrar la posicion de un dato en el arreglo
        /// </summary>
        /// <param name="dato">Valor a buscar en el arreglo</param>
        /// <returns></returns>
        public int Buscar(Datos dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i].Nombre == dato.Nombre)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Metodo que busca un valor dentro del arreglo y lo elimina
        /// </summary>
        /// <param name="dato">Valor a buscar para eliminarlo del arreglo</param>
        /// <returns>True en caso de que el valor se encuentre y se elimine del arreglo
        /// False en caso de que no se encuentre el valor en el arreglo o que no se pueda ejecutar el
        /// procedimiento</returns>
        public bool Eliminar(Datos dato)
        {
            if (!(EstaVacio()))
            {
                for (int i = 0; i < this.top; i++)//iterador para desplazarce por las posiones del arreglo
                {
                    if (this.arreglo[i].Matricula == dato.Matricula)// compara si el dato es del mismo valor al dato que buscamos a eliminar
                    {// fijamos el valor de i
                        for (int y = i; y < this.top - 1; y++)//preevee un intercambio de valores
                            this.arreglo[y] = this.arreglo[y + 1];
                        this.top--;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Metodo que permite controlar el critico EstaLleno para evitar realizar un overflow en el arreglo
        /// </summary>
        /// <returns></returns>
        public bool EstaLleno()
        {
            if (this.top == this.max)
                return true;
            return false;
        }

        /// <summary>
        /// Metodo que permite controlar el critico EstaVacio para evitar
        /// realizar la operacion de eliminar o buscar cuando no existen elementos
        /// </summary>
        /// <returns></returns>
        public bool EstaVacio()
        {
            if (this.top == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Metodo para agregar un valor en el arreglo
        /// </summary>
        /// <param name="dato">valor a agregar en el arreglo</param>
        /// <returns>True en caso de que la operacion se realice con exito; False en caso contrario.</returns>
        public bool Insertar(Datos dato) // Método para insertar un dato en el arreglo desordenado        
        {
            if (!EstaLleno()) // Si no está lleno ...        
            {
                for (int i = 0; i <= top - 1; i++)
                    if (arreglo[i] == dato)  // Comparación para detectar si el dato ya existe                     
                        return (false);  // No se insertó el dato (duplicado)       
                arreglo[top] = dato;  // Se inserta el dato en el arreglo      
                top++;  // Se incrementa la cantidad de datos del arreglo          
                return (true);  // Dato insertado con exito         
            }
            else
                return (false); // No se insertó el dato (arreglo lleno)      
        }

       public Datos this[int i]
        {
            get { return this.arreglo[i]; }
            set { this.arreglo[i]=value; }
        }


        public bool Ordernar()
        {
            //ToDo en clase [Metodos de Ordenacion]{SubMenu}
            return false;
        }

        /// <summary>
        /// Este metodo vacia el arreglo
        /// </summary>
        public void Vaciar()
        {
            this.top = 0;
        }
        /// <summary>
        /// Precarga el arreglo con datos ya preliminados 
        /// </summary>
        //////public void PrecargaLleno()
        //////{
        //////    this.arreglo = new Datos[] { 7, 3, 4, 6, 5 };
        //////    this.top = 5;
        //////    this.max = 5;
        //////}
        #endregion

    }
}
