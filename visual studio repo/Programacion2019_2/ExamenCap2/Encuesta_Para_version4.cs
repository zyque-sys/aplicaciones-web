using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCap2
{
    class Encuesta_Para_version4
    {
        public float valorPregunta(string pregunta, string respuesta, float V1, float V2, float V3)
        {
            #region Variables
            String dato = " ";
            int datoEntero = 0;
            #endregion

            #region Impresion de pregunta y respuesta
            Console.WriteLine(pregunta + respuesta);
            #endregion

            #region Captura de respuesta
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);

            if (datoEntero == 1) { return V1; }
            if (datoEntero == 2) { return V2; }
            if (datoEntero == 3) { return V3; }
            #endregion

            return 0.0f;
        }

    }
}
