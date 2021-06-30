using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ejercicio
{
    internal class Motocicleta:Vehiculo
    {
        private string marca;
        private bool tieneCanasta;
        private string tipoPedal;

        public string Marca { get => this.marca; set => this.marca = value; }
        public bool TieneCanasta { get => this.tieneCanasta; set => this.tieneCanasta = value; }
        public string TipoPedal { get => this.tipoPedal; set => this.tipoPedal = value; }
        public void TireRim()
        {
            //toDo
        }
        public void Carrilear()
        { //toDo
        }
         public void Voltear()
        {
            //toDo
        }
        public void Derrapar() {
            //toDo Virtual Vehiculo
            Console.WriteLine("Derrapado de motocicleta");
        }
        public override void Avanzar()
        {
            //toDo-Abstract Vehiculo
            Console.WriteLine("Avanzar de motocicleta");
        }

    }
}
