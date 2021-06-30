using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ComponentesGraficos.Practicas.Controles
{
    class ClaseDatos
    {
        private UInt16 uniforme;
        private string nombre;
        private double porcentaje;
        public UInt16 Uniforme
        {
            get
            {
                return (uniforme);
            }
            set
            {
                uniforme = value;
            }
        }
        public string Nombre
        {
            get
            {
                return (nombre);
            }
            set
            {
                nombre = value;
            }
        }
        public double Porcentaje
        {
            get
            {
                return (porcentaje);
            }
            set
            {
                porcentaje = value;
            }
        }
    }
}
