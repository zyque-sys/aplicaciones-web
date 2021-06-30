using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class Pelicula
    {
        #region Campos
        string nombrePelicula;
        int numPelicula;
        int sala;
        string horario;
        int asientosDisponibles;

        #endregion

        #region Propiedades
        public string NombrePelicula { get => nombrePelicula; set => nombrePelicula = value; }
        public int NumPelicula { get => numPelicula; set => numPelicula = value; }
        public int Sala { get => sala; set => sala = value; }
        public string Horario { get => horario; set => horario = value; }
        public int AsientosDisponibles { get => asientosDisponibles; set => asientosDisponibles = value; }
        #endregion
    }
}
