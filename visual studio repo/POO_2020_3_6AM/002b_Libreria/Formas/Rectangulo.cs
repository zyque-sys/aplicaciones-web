using System;
using System.Drawing;


namespace _002b_Libreria.Formas
{
    class Rectangulo : Formas
    {
        public override void Dibujar(Graphics g)
        {

            g.DrawRectangle(Pluma,
                Math.Min(P1.X,P2.X),
                Math.Min(P1.Y,P2.Y),
                Math.Abs(P2.X-P1.X),
                Math.Abs(P2.Y-P1.Y));
        }

    
    }
}
