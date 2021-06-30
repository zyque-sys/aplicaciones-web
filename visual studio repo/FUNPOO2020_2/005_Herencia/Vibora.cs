using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    class Vibora : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Engullir");
        }

        public override int Oler()
        {
            Console.WriteLine("Utiliza la lengua");
            return 1;
        }
    }
}
