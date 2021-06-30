using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Pilas
{
    class Pila
    {
        private int max;
        private int top;
        private int[] arreglo;

      
        public Pila(int t)
        {
            this.max = t;
            this.top = 0;
            this.arreglo = new int[t];
        }

        private bool EstaVacia()
        {
            return this.top == 0;
        }
        private bool EstaLleno()
        {
            return this.top == this.max;
        }
        public bool Push(int dato,bool verbose)
        {
            //toDo
            if (!EstaLleno())
            {
                this.arreglo[this.max - 1] = dato;
                for (int i = this.max-1; i >= this.top; i--)
                {
                    if (i!=this.max-1)
                        this.arreglo[i+1] = 0;
                    this.arreglo[i] = dato;
                    if (verbose)
                        Console.WriteLine(MostrarVerbose());
                        //imprimir estado de la pila
                }
                this.arreglo[this.top] = dato;
                this.top++;
                return true;
            }
            else
                return false;
            
        }
        public bool Pop(bool verbose)
        {
            //toDo
            if (!EstaVacia())
            {
                this.top--;
                for (int i = this.top; i < this.max-1; i++)
                {
                    this.arreglo[i + 1] = this.arreglo[i];
                    if (verbose)
                        Console.WriteLine(MostrarVerbose());
                    //imprimir estado de la pila
                }
                return true;
            }
            else
                return false;
        }
        public string Mostrar1()
        {
            //toDo

                string salida = "";
                int maxcar = 0;
                int cmax = max.ToString().Length;
                String[] car = new string[max];

                #region Contador caracteres
                for (int j = max - 1; j > -1; j--)
                {

                    string pos = arreglo[j].ToString();
                    if (pos.Length > maxcar)
                    {
                        maxcar = pos.Length;
                    }
                }
                #endregion

                #region Caracterizador
                for (int k = max - 1; k > -1; k--)
                {
                    string pos = arreglo[k].ToString();
                    int carr = pos.Length;
                    for (int l = carr; l <= maxcar; l++)
                    {
                        car[k] += " ";
                    }
                }
                #endregion

                for (int i = max - 1; i > -1; i--)
                {

                    string sp = "";
                    string pos = i.ToString();
                    int pos1 = pos.Length;
                    while (pos1 != cmax)
                    {
                        sp += " ";
                        pos1++;
                    }



                    if (i < top)
                    {
                        salida += i + ".- " + sp + "|" + car[i] + arreglo[i] + "|";
                    }
                    else
                    {
                        car[i] += " ";
                        salida += i + ".- " + sp + "|" + car[i] + "|";
                    }

                    if (i == top)
                    {
                        salida += " T";
                    }

                    //if (i != top && arreglo[i] != 0)
                    //{
                    //    salida += " c";
                    //}

                    salida += "\n";

                }

                return salida;
       
        }
        public string Mostrar()
        {
            //if (EstaVacia())
            //{
            //    return "Pila Vacia...";
            //}
            string salida =this.top==this.max?"\tMAX=T\n":"\tMAX\n";
            int maxCaracteres = MaxLength();
            for (int i = this.max-1; i >= 0; i--)
            {
                salida += i + " | ";//colocando indice del renglon
                int avance=i<this.top?this.arreglo[i].ToString().Length:0;
   
                for (int j = avance; j < maxCaracteres; j++)
                    salida += " ";
                //esto vvv
                if (i<this.top)
                    salida += this.arreglo[i] + " |"; //inserta valor

                else
                    salida += " | ";
                //es lo mismo que esto vvv
                //salida+=i<this.top?this.arreglo[i]+" | ": salida+=" | ";

                if (i == this.top)
                    salida += " T\n";//colocando Top
                else
                    salida += "\n";

            }
            return salida;
        }
        public string MostrarVerbose()
        {
         
            string salida = this.top == this.max ? "\tMAX=T\n" : "\tMAX\n";
            int maxCaracteres = MaxLength();
            for (int i = this.max - 1; i >= 0; i--)
            {
                salida += i + " | ";//colocando indice del renglon
                int avance = i < this.top ? this.arreglo[i].ToString().Length : 0;

                for (int j = avance; j < maxCaracteres; j++)
                    salida += " ";
                salida += this.arreglo[i] + " |"; //inserta valor

                //es lo mismo que esto vvv
                //salida+=i<this.top?this.arreglo[i]+" | ": salida+=" | ";

                if (i == this.top)
                    salida += " T\n";//colocando Top
                else
                    salida += "\n";

            }
            return salida;
        }
        private int MaxLength()
        {
            int maxCaracteres = int.MinValue;
            for (int j = 0; j < this.top; j++)
                if (maxCaracteres < this.arreglo[j].ToString().Length)
                    maxCaracteres = this.arreglo[j].ToString().Length;

            return maxCaracteres;
        }
  
        public void Vaciar()
        {
            this.top = 0;
        }

    }
}
