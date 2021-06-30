using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002b_Libreria.Formas
{
    public abstract class Formas
    {

        private Point p1;
        private Point p2;
        private Pen pluma;



        protected Formas()
        {
            this.p1 = new Point(-1, -1);//Punto invalido
            this.p2 = new Point(-1, -1);//Punto invalido
            this.pluma = new Pen(Color.Black);//Pluma negra 1x
        }
        protected Formas(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.pluma = new Pen(Color.Black);//Pluma negra 1x
        }

        public Formas(Point p1, Point p2, Pen pluma) : this(p1, p2)
        {
            this.pluma = pluma;
        }


        private void Verificador(Point p1, Point p2)
        {
            if (p1.X > p2.X)
            {
                int temp = p1.X;
                p1.X = p2.X;
                p2.X = temp;
            }
            if (p1.Y > p2.Y)
            {
                int temp = p1.Y;
                p1.Y = p2.Y;
                p2.Y = temp;
            }


        }
        public abstract void Dibujar(Graphics g);
        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Pen Pluma { get => pluma; set => pluma = value; }

    }
}
