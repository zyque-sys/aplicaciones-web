using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PracticaGeneral
{
    public class Datos
    {
#region Campos
     
    private int matricula;
    private string nombre;
    private string apellidoPaterno;
    private string apellidoMaterno;
    private decimal califMate;
    private decimal califFisica;
    private decimal califProgra;
        #endregion

        #region Propiedades

       
        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public decimal CalifMate { get => califMate; set => califMate = value; }
        public decimal CalifFisica { get => califFisica; set => califFisica = value; }
        public decimal CalifProgra { get => califProgra; set => califProgra = value; }
        #endregion

    }
}
