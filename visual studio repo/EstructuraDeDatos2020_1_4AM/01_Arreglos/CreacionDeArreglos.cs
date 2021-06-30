using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Arreglos
{
    class CreacionDeArreglos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creacion de arreglos");
            //-FORMA 1-
            int[] Arreglo;  //declaracion 
            Arreglo = new int[5];//instancia

            //-FORMA 2-
            int[] Arreglo2 = new int[5];//declaracion de identificador e instanciacion

            //-FORMA 3-
            int elementos = 10;
            int[] Arreglo3 = new int[elementos];

            //-FORMA 4-
            int[] Arreglo4 = new int[5] {4,3,5,1,0 };

            //-FORMA 5-
            int[] Arreglo5 = new int[] { 4, 3, 5, 1, 0 };




        }
    }
}
