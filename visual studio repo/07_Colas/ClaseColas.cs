using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Colas
{
    class ClaseColas
    {
        int max;
        int frente;
        int final;
        int[] arreglo;

        public ClaseColas(int t)
        {
            this.max = t;
            this.frente = 0;
            this.final = 0;
            this.arreglo = new int[t];
        }
        private bool EstaLlena()
        {
            return frente == max - 1 && final == max - 1;
        }
        private bool EstaVacia()
        {
            return frente==0&&final==0;
        }
        public bool Encolar(int dato)
        {
            if (!EstaLlena())
            {
                final = final + 1;
                arreglo[final] = dato;
                if (final == 0)
                    frente = final;

                return true;
            }
            else
                return false;
        }
        public bool DesEncolar()
        {
            if (!EstaVacia()) // Si no está vacía ...
            {
                // Compara si la cola se quedó vacía para optimizar el espacio
            if (frente == final)
                {
                    frente = -1; // Inicializa la cola
                    final = -1;
                }
                else
                    frente++; // Elimina el dato incrementando el Frente
                return (true); // Eliminación exitosa
            }
            else
                return (false); // No se eliminó el dato
        }
        public string Mostrar()
        {
            string resultado = "\n";
            int i;
            if (!EstaVacia()) // Si no está vacía ...
            {
                i = frente; // Inicializa la posicióndel recorrido
                do
                {
                    resultado = resultado + "\n[" + i +
                    "] -> " + this.arreglo[i].ToString();
                    i++; // Incrementa la posición
                         // Verifica la condición circular
                    if (i == max && frente > final)
                        i = 0; // Reinicia el recorrido al principio del arreglo(le da la vuelta)
                } while (i != final + 1); // Condiciónde salida del ciclo
            }
            else
                resultado = "\n\nCola circular vacía!!!";

            resultado = resultado + "\n\nFrente = " + frente.ToString();
            resultado = resultado + "\nFinal = " + final.ToString();
            resultado = resultado + "\nMax = " + max.ToString();
            return resultado; // Devuelve el resultado

        }
        public void Vaciar()
        {
            frente = 0;
            final = 0;
        }
    }
}
