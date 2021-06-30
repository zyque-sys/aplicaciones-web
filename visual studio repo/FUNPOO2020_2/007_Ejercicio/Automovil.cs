using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ejercicio
{
    internal class Automovil:Vehiculo
    {
        private string tipoAuto;
        private bool esElectricoOGasolina;
        private string color;
        //private Vehiculo vehiculo;

        public string TipoAuto { get => tipoAuto; set => tipoAuto = value; }
        public bool EsElectricoOGasolina { get => esElectricoOGasolina; set => esElectricoOGasolina = value; }
        public string Color { get => color; set => color = value; }

        public void ReclinarAsientos() {
            //toDo
        }
            public void Reversa() {
            //toDo
        }
            public void EncenderRadio()
        { //toDo
        }

        //override public void Derrapar()
        //{//toDo virtual Vehiculo
        //    Console.WriteLine("Derrapado de automovil");
        //}
        public override void Avanzar()
        {
            //toDo-Abstract Vehiculo
            Console.WriteLine("Avanzar de automovil");
        }
    }
}
