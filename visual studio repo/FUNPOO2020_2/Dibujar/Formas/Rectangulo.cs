using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar.Formas
{
    class Rectangulo:Forma
    {
        #region Campos
        //private Punto pI;
        //private Punto pF;
        private int ancho;//especializacion
        private int largo;//especializacion
        #endregion

        //public Rectangulo(Punto pI, Punto pF, int ancho)
        //{
        //    //this.pI = pI;
        //    //this.pF = pF;
        //    this.ancho = pF.X-pI.X;
        //    this.largo = pF.Y - pI.Y;
        //}

        public Rectangulo(Punto pI, int ancho, int largo):base()
        {
           
            this.ancho = ancho;
            this.largo = largo;
            base.PI = pI;
            base.PF = new Punto(pI.X+ ancho,pI.Y + largo);
           
        }
        public Rectangulo(Punto pI,Punto pF):base(pI,pF)
        {
            this.ancho = pF.X - pI.X;
            this.largo = pF.Y - pI.Y;
        }
        public Rectangulo():base()
        {
            //this.pI = new Punto(0, 0);
            //this.pF = new Punto(0, 0);
            this.ancho = 0;
            this.largo= 0;
        }

        public int Ancho { get => ancho; set => ancho = value; }
        public int Largo { get => largo; set => largo = value; }
        //public Punto PI { get => pI; set => pI = value; }
        //public Punto PF { get => pF; set => pF = value; }

        public override void Dibujar()
        {
            //toDo
            Console.WriteLine("Dibujando rectangulo "+this);
        }
        public override string ToString()
        {
            //{0, 0},{0, 0}:Largo=0, Ancho=0;
            return base.PI+", "+base.PF+": Ancho="+this.ancho+", Largo="+this.largo;
        }
    }
}
