using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar.Formas
{
    internal class Linea:Forma
    {
        public Linea(Punto pI, Punto pF):base(pI,pF)
        {
        }
        public Linea():base()
        {
        }
        
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando linea etre los puntos: "+this);
            //toDo
        }
        public override string ToString()
        {
            return base.PI+", "+base.PF;
        }
    }
}
