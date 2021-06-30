using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arreglos_Practica_ClaseArregloV1
{
    class ClaseArregloV1
    {
        #region Campos
        private int[] arreglo;
        private int max;
        private int top;
        #endregion

        #region Metodos
        public int Buscar(int dato) {
            for (int i = 0; i < this.top; i++)
            {
                if (this.arreglo[i] == dato)
                {
                    return i;
                }
            }
            return -1;
        }

        public ClaseArregloV1(int m) {
            this.arreglo = new int[m];
            this.top = 0;
            this.max = m;

        }

        public bool Eliminar(int dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i] == dato)
                    {
                        for (int j = i; j < this.top - 1; j++)
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
        public bool Insertar(int dato)
        {
            if (!EstaLleno())
            {
                for (int i = 0; i < this.top; i++)
                {
                    if (this.arreglo[i] == dato)
                        return false;
                }
                this.arreglo[this.top] = dato;
                this.top++;
                return true;
            }//fin del critico

            return false;
        }
        public void Swap(int pos1,int pos2)
        {
            int temp = this.arreglo[pos1];
            this.arreglo[pos1] = this.arreglo[pos2];
            this.arreglo[pos2] = temp;

        }
        public string Mostrar()
        {
            string salida = "";

            string contenido = "Contenido:{";
            string posicion = "Posicion: [";
            string indice = "Indice:   [";
            //llenado de datos
            if (!EstaVacio())
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    contenido += arreglo[i];
                    posicion += new string(' ', arreglo[i].ToString().Length - i.ToString().Length) + i;
                    //indice
                    if (i == top)
                    {
                        indice += new string(' ', arreglo[i].ToString().Length - 1) + "T";
                    }
                    else
                    {
                        if (i < this.top)
                        {
                            indice += new string(' ', arreglo[i].ToString().Length - 1) + "C";
                        }
                        else
                        {
                            indice += new string(' ', arreglo[i].ToString().Length);
                        }
                    }
                    //comas
                    if (i != arreglo.Length - 1)
                    {
                        contenido += ", ";
                        posicion += ", ";
                        indice += " ";
                    }
                }//endFor
                contenido += "  }";
                posicion += ", " + this.max + "]";
                if (top == max)
                {
                    indice += "  T]";
                }
                else
                {
                    indice += "  ]";
                }
                salida = contenido + "\n" + posicion + "\n" + indice + "\n";
                salida += "C:Indica las celdas con contenido;T indica la posicion de TOP";
                return salida;
            }
            else
            {
                salida = "Arreglo Vacío";

            }
            return salida;
                //if (!EstaVacio())
            //{
            //    for (int i = 0; i < this.top; i++)
            //    {
            //        salida += this.arreglo[i];
            //        if (i != this.top - 1)
            //            salida += ",";
            //    }
            //    salida += "}";
            //}
            //else
            //{
            //    salida = "{ }";
            //}
            //return salida;
      
        }
        public bool Ordenar()
        {
            return false;
        }

        public void Vaciar()
        {
            this.top = 0;
        }
        public bool EstaLleno()
        {
            if (this.top == this.max)
            {
                return true;
            }
            return false;
        }
        public bool EstaVacio()
        {
            if (this.top == 0)
                return true;

            return false;
        }
        #endregion

    }
}
