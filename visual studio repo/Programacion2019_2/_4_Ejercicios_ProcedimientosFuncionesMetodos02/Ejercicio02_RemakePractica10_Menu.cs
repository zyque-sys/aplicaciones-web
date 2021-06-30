using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ejercicios_ProcedimientosFuncionesMetodos02
{
    class Ejercicio02_RemakePractica10_Menu
    {
        static void Main()
        {
            int valor;
            string menu = "======Practicas del 1er corte==========" + "\n1.Numero Mayor" + "\n2.Inversion de numero dos cifras" + "\n 3.Inversion de numero tres cifras " + "\n4.Mayor de N numeros" + "\n5.Desglose de billetes" + "\n6.Tipos de triangulos" + "\n7.Dia de la semana" + "\n8.Calificacion" + "\n9. >Salir<";
            //int limiteee = int.MaxValue;
            Remake_Practica10_Menu practicas = new Remake_Practica10_Menu();
            GetNumber numero = new GetNumber();
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                valor=numero.GetInt("Ingrese un numero","Solo un numero entero");
                switch (valor)
                {
                    case 1:
                        #region Mayor de 3 numeros

                        practicas.Practica02();

                        break;
                    #endregion  
                    case 2:
                        #region Inversion de numero de dos cifras
                        practicas.Practica03();
                        break;
                    #endregion
                    case 3:
                        #region Inversion de numero de tres cifras
                        practicas.Practica04();
                        break;
                    #endregion
                    case 4:
                        #region Mayor de N numeros
                        practicas.Practica05();
                        break;
                    #endregion
                    case 5:
                        #region Desglose de billetes
                        practicas.Practica06();
                        break;
                    #endregion
                    case 6:
                        #region Lados de un triangulo
                        practicas.Practica07();
                        break;
                    #endregion
                    case 7:
                        #region Dias de la semana
                        practicas.Practica08();
                        break;
                    #endregion
                    case 8:
                        #region Calificaciones
                        practicas.Practica09();
                        break;
                        #endregion

                }
                Console.ReadLine();
            } while (valor != 9);
          

        }
    }
}//369
