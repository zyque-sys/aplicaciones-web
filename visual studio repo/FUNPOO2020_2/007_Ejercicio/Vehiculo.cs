using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ejercicio
{
    abstract class Vehiculo
    {
        private string placas;
        private int caballosFuerza;
        private string modelo;

        public string Placas { get => this.placas; set => this.placas = value; }
        public int CaballosFuerza { get => this.caballosFuerza; set => this.caballosFuerza = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }

        public abstract void Avanzar();
        public void Frenar()
        {
            //toDo
        }
        //public virtual void Derrapar()
        //{
        //    //toDo
        //    Console.WriteLine("Derrapado general");
        //}
    }
}
