using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseColas arreglo = new ClaseColas(5);
            Console.WriteLine(arreglo.Mostrar());

            int[] temporal = new int[5];
            for (int i = 0; i < temporal.Length; i++)
            {
                temporal[i] = 5;
                arreglo.Encolar(temporal[i]);
            }
        }
        public string Mostrar(int[] arreglo)
        //(ClaseColas Cola,int elementos)
        {
            string salida = "";
            salida += "Cola\n -->[";
            for (int i = 0; i < arreglo.Length; i++)
            {
                salida += " " + arreglo[i] + " " + "|";
                if (arreglo[i] == arreglo.Length - 1)
                {
                    salida += "]";
                }
            }
            return salida;
            //alt
            StringBuilder datos = new StringBuilder();
            StringBuilder posicion = new StringBuilder();
            datos.Append("datos {");
            posicion.Append("posicion {");
            ClaseColas colaep = new ClaseColas(elementos);
            int dato = 0;
            int contadorIndice = 1;
            if (dato!=int.MinValue)
            {

                if (dato.ToString().Length >= contadorIndice.ToString().Length)
                {
                    int numeroCaracteres = dato.ToString().Length - contadorIndice.ToString().Length;
                    posicion.Append(new string(' ', numeroCaracteres));
                
                }
                else
                {
                    int numeroCaracteres = contadorIndice.ToString().Length - dato.ToString().Length;
                    posicion.Append(new string(' ', numeroCaracteres));
         
                }
                datos.Append(dato + ", ");
                posicion.Append(contadorIndice+" ");

                contadorIndice++;
                colaep.Encolar(dato);
                //datos.Append("}\n");
                do
                {
                    dato = colaep.DesEncolar();
                    if (dato != int.MinValue)
                    {

                    }
                } while (true);
            }
        }

    }
}
