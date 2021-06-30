using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCap2
{
    class ExamenCap2_v3
    {
        static void Main(string[] args)
        {
            #region Variables
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
            float respuesta = 0.0f;
            float V1 = 3.33f;
            float V2 = 6.66f;
            float V3 = 9.99f;
            float[] V = { 3.33f, 6.66f, 9.99f };
            float[,] valoresPorPregunta=
            {
                {V[0],V[1],V[2]},
                {V[2],V[0],V[1]},
                {V[1],V[2],V[0]},
                {V[0],V[1],V[2]},
                {V[2],V[0],V[1]},
                {V[1],V[2],V[0]},
                {V[0],V[1],V[2]},
                {V[2],V[0],V[1]},
                {V[1],V[2],V[0]},
                {V[0],V[1],V[2]}
            };
            #endregion

            #region Preguntas y respuestas
            for (int i = 0; i < preguntas.Length; i++)
            {
                respuesta += valorPregunta(preguntas[i], respuestas[i], valoresPorPregunta[i, 0], valoresPorPregunta[i, 1], valoresPorPregunta[i, 2]);
            }
            #endregion

            #region Resultado
            if (respuesta >= 90) { Console.WriteLine("Nivel Máximo"); }
            else if (respuesta >= 75 && respuesta < 90) { Console.WriteLine("Nivel bueno"); }
            else if (respuesta >= 50 && respuesta < 75) { Console.WriteLine("Nivel regular"); }
            else { Console.WriteLine("Fuera de nivel"); }
            #endregion

            Console.ReadLine();
        }

        static float valorPregunta(string pregunta, string respuesta, float V1, float V2, float V3)
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
