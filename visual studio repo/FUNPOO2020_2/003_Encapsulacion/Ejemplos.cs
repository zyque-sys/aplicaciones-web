using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulacion
{
    class Ejemplo
    {
        private double Real;
        private double Imaginary;

        //static void WriteMessage(string message) => Console.WriteLine(message);


        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        //public Complex Add(Complex b) =>
        //    new Complex(this.Real + b.Real, this.Imaginary + b.Imaginary);


        public Complex Add(Complex b)
        {
            return
                new Complex(this.Real + b.Real, this.Imaginary + b.Imaginary);
        }
    }
}
