using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil carro = new Automovil();
            CamionCarga trailer = new CamionCarga();
            Motocicleta moto = new Motocicleta();

            Console.WriteLine("==Forma de avanzar de cada vehiculo==");

            carro.Avanzar();
            trailer.Avanzar();
            moto.Avanzar();
            Console.WriteLine("==Formas de derrapar de carro y motocicleta==");
            //carro.Derrapar();
            moto.Derrapar();

            Console.ReadLine();
        }
    }
}
