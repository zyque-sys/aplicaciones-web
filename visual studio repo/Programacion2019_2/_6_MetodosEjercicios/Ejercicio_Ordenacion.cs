using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MetodosEjercicios
{
    class Ejercicio_Ordenacion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su cadena a evaluar:");
            string dato = Console.ReadLine();
            char[] Captura;
            char[] Procesada;
            
    

            Captura = dato.ToArray();
            //Ejercicio_Ordenacion ingreso = new Ejercicio_Ordenacion();
            MetodoOrdenarAlfabeticamente(Captura);
            MetodoRecorrerIzquierda(Captura);
         
        }

        static char[] MetodoOrdenarAlfabeticamente(char[] Captura)
        { 
            char acomodados;
            int j;
            for (int i = 0; i < Captura.Length; i++)
            {
                acomodados = Captura[i];
                j = i - 1;
                while (j >= 0 && Captura[j] > acomodados)
                {
                    Captura[j + 1] = Captura[j];
                    j--;
                }
                Captura[j + 1] = acomodados;
               
            }
            Console.WriteLine("Acomodado Alfabeticamente: ");
            Console.Write(Captura);
            Console.ReadLine();
            return Captura;
        }

 
        static char[] MetodoRecorrerIzquierda(char[] Procesada)
        {
            char[] procesamiento = new char[Procesada.Length];
            Console.WriteLine("Arreglo recorrido: ");
            for (int i = 0; i < Procesada.Length - 1; i++)
            {
                procesamiento[i] = Procesada[i + 1];
              
            }

            procesamiento[procesamiento.Length - 1] = Procesada[0];
            for (int i = 0; i < procesamiento.Length+1; i++)
            {
                Console.Write(procesamiento[i]);
            }
            Console.ReadLine();
            return procesamiento;
        }


    }
}
