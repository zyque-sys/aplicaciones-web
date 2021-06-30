using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCap2
{
    class ExamenCap2_v1
    {
        static void Main(string[] args)
        {
            #region variables
            string dato = " ";
            int datoEntero;
            float respuesta=0;
            #endregion

            #region pregunta 1
            Console.WriteLine("Pregunta 01?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 2
            Console.WriteLine("Pregunta 02?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 3
            Console.WriteLine("Pregunta 03?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 4
            Console.WriteLine("Pregunta 04?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 5
            Console.WriteLine("Pregunta 05?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 6 
            Console.WriteLine("Pregunta 06?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 7
            Console.WriteLine("Pregunta 07?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 8
            Console.WriteLine("Pregunta 08" +
                "?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 9
            Console.WriteLine("Pregunta 09?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion
            #region pregunta 10
            Console.WriteLine("Pregunta 10?\n1) ttt\t2) yyy \t3) zzz");
            do
            {
                dato = Console.ReadLine();
                int.TryParse(dato, out datoEntero);

                if (datoEntero > 0 && datoEntero < 4)
                {
                    Console.WriteLine("Fuera de rango ");
                }
            } while (datoEntero > 0 && datoEntero < 4);
            #endregion

            #region version de String
            //do
            //{
            //    dato = Console.ReadLine();
            //    int.TryParse(dato, out datoEntero);

            //    if (dato != "ttt" && dato != "yyy" && dato != "zzz")
            //    {
            //        Console.WriteLine("Fuera de rango ");
            //    }

            //} while (dato != "ttt" && dato != "yyy" && dato != "zzz");

            //switch (dato)
            //{
            //    case "ttt": respuesta += 3.33f; break;
            //    case "yyy": respuesta += 6.66f; break;
            //    case "zzz": respuesta += 9.99f; break;
            //}
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
