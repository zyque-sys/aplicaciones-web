using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definicion de identificacion de objeto
            object objeto;
            objeto = new object(); // instancia

            Animal animal;
            animal = new Animal();
            animal.Comunicarse();


            AnimalDerivadoMismoEnsamblado ani;
            ani = new AnimalDerivadoMismoEnsamblado();
        }
    }
}
