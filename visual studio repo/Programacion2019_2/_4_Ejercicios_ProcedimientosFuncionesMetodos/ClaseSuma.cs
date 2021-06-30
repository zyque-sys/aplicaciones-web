using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos
{
    class ClaseSuma
    {
       public int valorA, valorB;
        //SOBRECARGA DE METODOS:mismo mmetodo con dos firmas
        
        //sin argumentos
        public int suma() {

            return valorA + valorB;
        }
        //con argumentos
        public int suma(int a,int b) {
            return a + b;
        }
    }
}
