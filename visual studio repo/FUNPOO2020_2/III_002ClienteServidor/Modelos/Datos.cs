using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III_002ClienteServidor.Modelos
{
    class Datos
    {
        int a;
        int b;
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public int Suma()
        {
            return this.a + this.b;
        }
    }
}
