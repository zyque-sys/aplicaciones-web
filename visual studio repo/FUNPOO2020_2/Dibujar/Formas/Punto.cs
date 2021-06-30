using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar.Formas
{
    class Punto
    {
        private int x;
        private int y;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            return "{"+this.x+", "+this.y+"}";//{0,0}
        }
    }
}
