using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ComponentesGraficos.Practicas.Controles
{
    class ClaseArregloDesordenado
    {
        private int top; // Variable para contar la cantidad de celdas ocupadas
        private readonly int Max; // Tamaño del arreglo
        private ClaseDatos[] Arreglo; // Declaracion del arreglo de objetos
        public int Top
        {
            get
            {
                return (top);
            }
        }
        public ClaseArregloDesordenado(int m) //Constructor
        {
            Max = m;
            top = 0;
            Arreglo = new ClaseDatos[Max]; // Creacióndel arreglo de tamaño Max
        }
        public bool EstaLleno() // Método para detectar si el arreglo está lleno
        {
            if (top == Max)
                return (true);
            else
                return (false);
        }
        public bool EstaVacio() // Método para detectar si el arreglo está vacío
        {
            if (top == 0)
                return (true);
            else
                return (false);
        }
        public bool Insertar(ClaseDatos Dato) // Método para insertar un dato en el arreglo
        {
            if (!EstaLleno()) // Si no está lleno ...
            {
                for (int i = 0; i < top; i++)
                {
                    if (Arreglo[i].Uniforme ==
                   Dato.Uniforme)
                        return (false); // No se inserta el dato(duplicado)
                }
                Arreglo[top] = Dato; // Se inserta el dato en el arreglo
                top++; // Se incrementa la cantidad de datos del arreglo
                return (true); // Inserción exitosa !!!
            }
            else
                return (false); // No se inserta el dato(arreglo lleno)
        }
        public bool Eliminar(UInt16 Uniforme) //Método para eliminar un dato del arreglo
        {
            int i = 0, x = 0;
            if (!EstaVacio()) // Si no está vacío ...
            {
                for (i = 0; i < top; i++)
                {
                    if (Arreglo[i].Uniforme == Uniforme) // Comparación
                    {
                        for (x = i; x < top - 1; x++) // Desplazamiento de los valores de las celdas sucesoras
                            Arreglo[i] = Arreglo[i + 1];
                        top--; // Se disminuye la cantidad de datos del arreglo
                        return (true);
                    }
                }
                return (false); // No se elimina el dato(no existe el jugador)
            }
            else
                return (false); // No se elimina el dato(arreglo vacío)
        }
        public ClaseDatos Consultar(int celda)
        {
            if (celda >= 0 && celda < Top)
                return (Arreglo[celda]); // Devuelve el objeto almacenado en la celda del Arreglo
            else
                return (null);
        }
        public bool Ordenar() // Ordena los datos de los jugadores del arreglo
        { // mediante el sorteador de la selección directa

            if (!EstaVacio()) // Si no está vacío ...
            {
                int p = 0, x = 0;
                ClaseDatos Temporal = new ClaseDatos();
                for (p = 0; p < top - 1; p++)
                    for (x = p + 1; x < top; x++)
                        if (Arreglo[x].Porcentaje <
                       Arreglo[p].Porcentaje)
                        {
                            Temporal = Arreglo[p];
                            Arreglo[p] = Arreglo[x];
                            Arreglo[x] = Temporal;
                        }
                return (true);
            }
            else
                return (false);
        }
        public ClaseDatos Mayor() // Devuelve el objeto con el mejor porcentaje
        {                        // de bateo
            ClaseDatos Mayor = Arreglo[0];
            for (int i = 1; i < top; i++)
                if (Arreglo[i].Porcentaje >
               Mayor.Porcentaje)
                    Mayor = Arreglo[i];
            return (Mayor);
        }
    }
}
