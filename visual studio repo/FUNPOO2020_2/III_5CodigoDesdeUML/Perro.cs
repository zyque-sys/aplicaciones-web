using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III_5CodigoDesdeUML
{
    public class Perro : Animal
    {
        private int cPerro1;
        private string cPerro2;

        public event System.EventHandler Ladrar;

        public int Cperro1
        {
            get { return this.cPerro1; }
            set { this.cPerro1 = value; }
        }

        public string Cperro2
        {
            get { return this.cPerro2; }
            set { this.cPerro2 = value; }
        }

        public void Mperro1()
        {
        }

        public void Mperro2()
        {
        }
    }
}
