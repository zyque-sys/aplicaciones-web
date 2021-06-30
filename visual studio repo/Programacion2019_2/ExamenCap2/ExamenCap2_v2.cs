using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCap2
{
    class ExamenCap2_v2
    {
        static void Main(string[] args)
        {
            #region Variables
            String dato = " ";
            int datoEntero=0;
            float respuesta = 0.0f;
            string[] preguntas = {
                "Pregunta 01?\n",
                "Pregunta 02?\n",
                "Pregunta 03?\n",
                "Pregunta 04?\n",
                "Pregunta 05?\n",
                "Pregunta 06?\n",
                "Pregunta 07?\n",
                "Pregunta 08?\n",
                "Pregunta 09?\n",
                "Pregunta 10?\n"
            };
            string[] respuestas = {
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz",
                "\n1) ttt\t2) yyy \t3) zzz"
            };
            #endregion

            #region Preguntas
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(preguntas[i] + respuestas[i]);
                do
                {
                    dato = Console.ReadLine();
                    int.TryParse(dato, out datoEntero);

                    if (datoEntero > 0 && datoEntero < 4)
                    {
                        Console.WriteLine("Fuera de rango ");
                    }
                } while (datoEntero > 0 && datoEntero < 4);
            }
            #endregion

            #region Valor de respuesta
            if (datoEntero == 1) { respuesta += 3.33f; }
            if (datoEntero == 2) { respuesta += 6.66f; }
            if (datoEntero == 3) { respuesta += 9.99f; }
            #endregion

            #region Resultado
            if (respuesta >= 90) { Console.WriteLine("Nivel Máximo"); }
            else if (respuesta >= 75 && respuesta < 90) { Console.WriteLine("Nivel bueno"); }
            else if (respuesta >= 50 && respuesta < 75) { Console.WriteLine("Nivel regular"); }
            else { Console.WriteLine("Fuera de nivel"); }
            #endregion

            Console.ReadLine();
        }
    }
}