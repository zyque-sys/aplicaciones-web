using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar.Formas
{
    abstract class Forma
    {
        #region Campos
        private Punto pI;
        private Punto pF;
        #endregion
        #region Propiedades
        internal Punto PI { get => pI; set => pI = value; }
        internal Punto PF { get => pF; set => pF = value; }
        #endregion
        public Forma()
        {
            this.pI = new Punto(0,0);
            this.pF = new Punto(0, 0);
        }
        public Forma(Punto pI,Punto pF)
        {
            this.pI = pI;
            this.pF = pF;
        }

        public abstract void Dibujar();
        public virtual void Borrar()
        {
            Console.WriteLine("Borrando forma");
        }
     
    }
}
