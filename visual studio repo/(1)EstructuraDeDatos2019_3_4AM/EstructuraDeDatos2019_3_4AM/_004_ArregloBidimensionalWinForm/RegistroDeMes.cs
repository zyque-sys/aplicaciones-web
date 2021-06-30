using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ArregloBidimensionalWinForm
{
    class RegistroDeMes
    {
        private double dulces;
        private double conservas;
        private double bebidas;

        public double Dulces { get => dulces; set => dulces = value; }
        public double Conservas { get => conservas; set => conservas = value; }
        public double Bebidas { get => bebidas; set => bebidas = value; }

        public RegistroDeMes(double dulces, double conservas, double bebidas)
        {
            this.dulces = dulces;
            this.conservas = conservas;
            this.bebidas = bebidas;
        }
    }
}
