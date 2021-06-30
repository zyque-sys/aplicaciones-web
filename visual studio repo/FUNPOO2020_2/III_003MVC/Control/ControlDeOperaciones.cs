using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using III_003MVC.Modelo;

namespace III_003MVC.Control
{
    class ControlDeOperaciones
    {
        Datos datos;

        internal Datos Datos { get => datos; set => datos = value; }

        public ControlDeOperaciones()
        {
            datos = new Datos();
        }

        public int Suma()
        {
            return datos.A + datos.B;
        }

        public void CargarA(int a)
        {
            datos.A = a;
        }

        public void CargarB(int b)
        {
            datos.B = b;
        }
    }
}
