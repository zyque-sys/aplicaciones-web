using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos02
{
    class ClaseMetodos
    {
        //campos
        int valorA, valorB;
        //this.valorA es para referirnos a los campos de la clase


        //propiedades
        public int ValorA { get => valorA; set => valorA = value; }
        public int ValorB { get => valorB; set => valorB = value; }
        //metodos

        /// <summary>
        /// Este metodo regresa la suma de los campos de la clase 
        /// Primero inicializa los campos de la clase
        /// </summary>
        /// <returns></returns>
        public int Suma() {
            return valorA + valorB;
        }

        /// <summary>
        /// Regresa la suma de los campos de la clase
        /// Acepta dos parametros int enviados como argumentos
        /// </summary>
        /// <param name="a">Primer entero</param>
        /// <param name="b">Segundo entero</param>
        /// <returns>Entero resultante de la suma</returns>
        public int Suma(int a,int b) {  //recibe dos parametros
            return a + b;
        } 


    }
}
