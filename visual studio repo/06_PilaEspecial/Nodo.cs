using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PilaEspecial
{
    class Nodo
    {
        private string placas;
        private string propietario;
        private DateTime horaEntrada;

        public string Placas { get => placas; set => placas = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
    }
}
