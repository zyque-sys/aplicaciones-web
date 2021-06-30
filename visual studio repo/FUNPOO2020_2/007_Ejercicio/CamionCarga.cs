using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ejercicio
{
    internal class CamionCarga:Vehiculo
    {
        private int cajasCarga;
        private int numLlantas;
        private string tipoMotor;

        public int CajasCarga { get => cajasCarga; set => cajasCarga = value; }
        public int NumLlantas { get => numLlantas; set => numLlantas = value; }
        public string TipoMotor { get => tipoMotor; set => tipoMotor = value; }

        public void LiberarCajas()
        { //toDo
        }
            public void GirarCamion()
        {//toDo
        }
            public void EncenderPreventivas()
        {//toDo
        }

        public override void Avanzar()
        {
            //toDo-Abstract Vehiculo
            Console.WriteLine("Avanzar de camion");
        }



    }
}
