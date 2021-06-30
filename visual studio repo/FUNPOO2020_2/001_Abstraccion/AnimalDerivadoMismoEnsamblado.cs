using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraccion
{
    class AnimalDerivadoMismoEnsamblado:Animal
    {
        void testprivate()
        {
            this.color = "";
        }
        void testPrivateProtected()
        {
            this.clasificacion = "";
        }
    }
}
