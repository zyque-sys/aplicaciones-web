using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            //==Formas de crear arreglos==
            #region 1ra forma:Instancia
            //Crear un arreglo
            int[] A;    //por convencion,los arreglos van con mayuscula

            A = new int[5]; // declaracion del arreglo con su numero de posiciones
            #endregion
            #region 2da forma:Asignacion
            int[] C=new int[5];

            //asignacion
            C[0]=1;
            C[1]=2;
            C[2]=4;
            C[3]=7;
            C[4]=3;
            #endregion
            #region 3ra forma:Instancia con asignacion
            //o
            int[] B = new int[] { 1, 2, 8 }; //instancia con asignacion
            #endregion
            #region Get & Set
            C[3]= 6; //set
            int z = C[3]; //get
            #endregion
            #region Impresion pedorra de arreglos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("EL valor del arreglo C[{0}]={1}",i,C[i]);
            }
            #endregion
            Console.WriteLine();
            #region Impresion chila de arreglos
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine("EL valor del arreglo C[{0}]={1}", i, C[i]);
            }
            #endregion
            #region String como arreglos

            string palabra = "hola mundo";
            char[] cadena;
            cadena = palabra.ToArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                //Console.WriteLine("EL valor del arreglo cadena[{0}]={1}", i, cadena[i]);
                //Console.WriteLine(cadena[i]);
                //Console.Write(cadena[i]);
            }


            #endregion
            Console.ReadLine();

        }
    }
}
