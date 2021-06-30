using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.ModelosDeDatos
{
    public class ClaseArregloV2
    {
        #region Campos
        private int[] arreglo;
        private int max;
        private int top;
        #region Propiedades
        public int[] Arreglo { get => this.arreglo; set => this.arreglo = value; }
        public int Max { get => this.max; set => this.max = value; }
        public int Top { get => this.top; set => this.top = value; }
        #endregion
        #endregion

        #region Metodos
        public int Buscar(int dato)
        {
            for (int i = 0; i < this.Top; i++)
            {
                if (this.Arreglo[i] == dato)
                {
                    return i;
                }
            }
            return -1;
        }

        public ClaseArregloV2(int m)
        {
            this.Arreglo = new int[m];
            this.Top = 0;
            this.Max = m;

        }

        public void Swap(int pos1, int pos2)
        {
            int temp = this.arreglo[pos1];
            this.arreglo[pos1] = this.arreglo[pos2];
            this.arreglo[pos2] = temp;

        }

        public bool Eliminar(int dato)
        {
            if (!EstaVacio())
            {
                for (int i = 0; i < this.Top; i++)
                {
                    if (this.Arreglo[i] == dato)
                    {
                        for (int j = i; j < this.Top - 1; j++)
                        {
                            this.Arreglo[j] = this.Arreglo[j + 1];
                            this.Top--;
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
                for (int i = 0; i < this.Top; i++)
                {
                    if (this.Arreglo[i] == dato)
                        return false;
                }
                this.Arreglo[this.Top] = dato;
                this.Top++;
                return true;
            }//fin del critico

            return false;
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
                for (int i = 0; i < Arreglo.Length; i++)
                {
                    contenido += Arreglo[i];
                    posicion += new string(' ', Arreglo[i].ToString().Length - i.ToString().Length) + i;
                    //indice
                    if (i == Top)
                    {
                        indice += new string(' ', Arreglo[i].ToString().Length - 1) + "T";
                    }
                    else
                    {
                        if (i < this.Top)
                        {
                            indice += new string(' ', Arreglo[i].ToString().Length - 1) + "C";
                        }
                        else
                        {
                            indice += new string(' ', Arreglo[i].ToString().Length);
                        }
                    }
                    //comas
                    if (i != Arreglo.Length - 1)
                    {
                        contenido += ", ";
                        posicion += ", ";
                        indice += " ";
                    }
                }//endFor
                contenido += "  }";
                posicion += ", " + this.Max + "]";
                if (Top == Max)
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
            this.Top = 0;
        }
        public bool EstaLleno()
        {
            if (this.Top == this.Max)
            {
                return true;
            }
            return false;
        }
        public bool EstaVacio()
        {
            if (this.Top == 0)
                return true;

            return false;
        }
        #endregion
    }
}
