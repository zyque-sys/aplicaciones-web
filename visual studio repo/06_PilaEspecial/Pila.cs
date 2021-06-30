using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PilaEspecial
{
    class Pila
    {
        private int max;
        private int top;
        private Nodo[] arreglo;

        public int Top { get => top; set => top = value; }

        public Pila(int t)
        {
            this.max = t;
            this.Top = 0;
            this.arreglo = new Nodo[t];
        }

        private bool EstaVacia()
        {
            return this.Top == 0;
        }
        private bool EstaLleno()
        {
            return this.Top == this.max;
        }
        public bool Push(Nodo dato)
        {
            //toDo
            if (!EstaLleno())
            {
                this.arreglo[this.Top] = dato;
                this.Top++;
                return true;
            }
            else
                return false;
            
        }
        public Nodo Pop()
        {
            //toDo
            if (!EstaVacia())
            {
                this.Top--;
                return this.arreglo[this.Top];
            }
            else
                return null;
        }
    
        public void Vaciar()
        {
            this.Top = 0;
        }

    }
}
