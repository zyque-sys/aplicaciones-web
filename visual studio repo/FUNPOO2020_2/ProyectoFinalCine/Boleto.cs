using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class Boleto
    {
        #region Campos
        Pelicula funcion;
        int id_boleto;
        float descuento;
        float total;
        #endregion

        #region Propiedades
        public int Id_boleto { get => id_boleto; set => id_boleto = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float Total { get => total; set => total = value; }
        internal Pelicula Funcion { get => funcion; set => funcion = value; }
        #endregion


    }
}
