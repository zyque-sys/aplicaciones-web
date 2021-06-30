using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III_5CodigoDesdeUML
{
    public class Pato : Animal
    {
        private int cPato1;
        private string cPato2;

        public event System.EventHandler Graznar;

        public int Cpato1
        {
            get => default;
            set
            {
            }
        }

        public string Cpato2
        {
            get => default;
            set
            {
            }
        }
    }
}
