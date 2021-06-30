using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ArregloBidimensionalWinForm
{
    class ClaseMatriz
    {
        private double[,] matriz;

        public ClaseMatriz()
        {
            matriz = new double[12, 3];
        }
        public double this[int r,int c]
        {
            get
            {
                return this.matriz[r, c];

            }
            set
            {

                this.matriz[r, c] = value;
            }

        }

        public void ObtenerMesVentaMayorDulces(ref string Mes, ref double VentaMayor)
        {
            // Inicializa la VentaMayor con el primer valor de la columna 0     
            VentaMayor = this.matriz[0, 0];
            int NumeroRenglon = 0; // Inicializa el NumeroRenglon 
            for (int renglon = 1; renglon < 12; renglon++)
                if (this.matriz[renglon, 0] > VentaMayor) // Comparación para buscar si es mayor               
                {
                    VentaMayor = this.matriz[renglon, 0]; // Encuentra un valor mayor que el previamente almacenado                     
                    NumeroRenglon = renglon; // Almacena el renglón donde localizó la nueva venta mayor  
                }
            // Determina el mes correspondiente al NumeroRenglon de la VentaMayor            
            switch (NumeroRenglon)
            {
                case 0: Mes = "Enero"; break;
                case 1: Mes = "Febrero"; break;
                case 2: Mes = "Marzo"; break;
                case 3: Mes = "Abril"; break;
                case 4: Mes = "Mayo"; break;
                case 5: Mes = "Junio"; break;
                case 6: Mes = "Julio"; break;
                case 7: Mes = "Agosto"; break;
                case 8: Mes = "Septiembre"; break;
                case 9: Mes = "Octubre"; break;
                case 10: Mes = "Noviembre"; break;
                case 11: Mes = "Diciembre"; break; 

            }
        }

        public double CalcularPromedioBebidas()
        {

            return 1.0;
        }

        public void ObtenerMesMenorBebidas(string mes,double ventaMayor)
        {
        }
        public void ObtenerDptoMenorVentaAgosto(string mes,double ventaMayor)
        {

        }
    }
}
