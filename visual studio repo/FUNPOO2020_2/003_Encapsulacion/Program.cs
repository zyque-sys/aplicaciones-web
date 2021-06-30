using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Genero = "Femenino"; //set de la propiedad

            //set     =    Get
            string genero = animal.Genero; //get de la propiedad
                                           // = value (para un set)

            animal.Raza = "moNtes";
            #region Obj Arreglos
            //campo
        private int[] arreglo;
        private int dato;

        //constructor
        public void ObjetoArreglo(int tamaño)
        {
            this.arreglo = new int[tamaño];
        }
        //propiedad instanciada
        static public int Dato
        {
            get { return 1 }
        }
        #endregion
    }
    }
    }
}
