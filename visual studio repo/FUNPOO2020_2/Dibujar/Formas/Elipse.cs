using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar.Formas
{
    class Elipse:Forma
    {
        #region Campos
        //private Punto pI;
        //private Punto pF;
        private Rectangulo rectangulo;
        #endregion

        #region Propiedades
        //internal Punto PI { get => pI; set => pI = value; }
        //internal Punto PF { get => pF; set => pF = value; }
        internal Rectangulo Rectangulo { get => rectangulo; set => rectangulo = value; }
        #endregion
        #region Constructores
        public Elipse():base()
        {
            //this.pI = new Punto(0, 0);
            //this.pF = new Punto(0, 0);
            this.rectangulo = new Rectangulo();//especializacion
        }
        public Elipse(Punto pI, int ancho, int largo):base()
        {
            this.PI = pI;
           this.PF = new Punto(pI.X + ancho, pI.Y + largo);
            this.rectangulo = new Rectangulo(pI, ancho,largo);
        }
        public Elipse(Punto pI, Punto pF):base(pI,pF)
        {
            //.pI = pI;
            //this.pF = pF;
            this.rectangulo = new Rectangulo(pI,pF);
        }
        public Elipse(Rectangulo rectangulo):base()
        {
            this.PI=rectangulo.PI;
            this.PF = rectangulo.PF;
            this.rectangulo = new Rectangulo();
        }
        #endregion
        public override void Dibujar()
        {
            //toDo
            Console.WriteLine("Dibujando elipse en: "+this);
        }
        public override string ToString()
        {
            return "["+base.PI+", "+base.PF+"], {"+this.rectangulo+"}";
        }

    }
   

}
