using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Examen
{
    public class Datos
    {
        #region Campos
        private string materia;
        private decimal corte1;
        private decimal corte2;
        private decimal corte3;



        #endregion

        #region Propiedades
        public decimal Corte1 { get => corte1; set => corte1 = value; }
        public decimal Corte2 { get => corte2; set => corte2 = value; }
        public decimal Corte3 { get => corte3; set => corte3 = value; }
        public string Materia { get => materia; set => materia = value; }

        #endregion

    }
}
