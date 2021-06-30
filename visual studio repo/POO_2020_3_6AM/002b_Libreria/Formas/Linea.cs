using System;
using System.Drawing;

namespace _002b_Libreria.Formas
{
    class Linea : Formas
    {
        public Linea() : base()
        {
        }

        public Linea(Point p1, Point p2, Pen pluma) : base(p1, p2, pluma)
        {
        }

        public override void Dibujar(Graphics g)
        {
            g.DrawLine(Pluma, P1, P2);
        }

    }
}
