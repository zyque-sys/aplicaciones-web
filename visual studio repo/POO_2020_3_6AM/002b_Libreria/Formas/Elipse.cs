using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002b_Libreria.Formas
{
    class Elipse:Formas
    {
        public override void Dibujar(Graphics g)
        {
            g.DrawEllipse(Pluma,
                Math.Min(P1.X, P2.X),
                Math.Min(P1.Y, P2.Y),
                Math.Abs(P2.X - P1.X),
                Math.Abs(P2.Y - P1.Y));
        }

       
    }
}
