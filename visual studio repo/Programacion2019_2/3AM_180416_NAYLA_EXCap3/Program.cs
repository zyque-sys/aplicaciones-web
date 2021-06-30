using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _3AM_180416_NAYLA_EXCap3
{
    class Program
    {
        static void Main(string[] args)
        {
            string miNombre = "NAYLA";
            char[] arregloCadena = miNombre.ToArray();
            int columna = 0;
            int renglon = 0;
            int retraso = 30;
            //-----PASO 0
            do
            {
                int columnaP = columna;
                for (int i = 0; i < arregloCadena.Length; i++)
                {
                  
                    if (columnaP < 112)
                    {
                        impresion(columnaP, renglon, arregloCadena[i]);
                        columnaP += 8;
                    }
                }
                Thread.Sleep(retraso);
                columna++;
            } while (columna < 105 /* - arregloCadena.Length*8 */);

            //for (int i = 0; i < 25; i++)
            //{

            //    Thread.Sleep(10);
            //    ImpresionFrases(i, 0, arregloCadena);

            //}

            //int regreso = 1;

            //for (int i = 0; i < arregloCadena.Length; i++)
            //{
            //    for (int j = arregloCadena.Length; j <= 0; j--)
            //    {


            //        impresion(Console.BufferWidth - regreso - i, 0, arregloCadena[j]);
            //        regreso += 8;

            //    }
            //}



            #region MENU
            string tituloS = "MENU";
            char[] titulo= tituloS.ToArray();
            int opcion=0;
            do
            {
                Console.Clear();
                ImpresionFrases(7, 2, titulo);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("| 1.Recibir texto                         |");
                Console.WriteLine("|2.Mostrar un banner utilizando el texto  |\n" +
                                  "|(cargado en la opcion 1)                 |\n" +
                                  "|3.Mostrar un banner con el texto ordenado|\n" +
                                  "|4.Mostrarlo con el texto ordenado, ascen-|\n" +
                                  "|-dente y descendente                     |\n" +
                                  "|5.Salir del programa                     |\n" +
                                  "-------------------------------------------");

             int.TryParse(Console.ReadLine(), out opcion);
                char[] texto;
                switch (opcion)
                {
                    case 1:opcion1(); break;
                    case 2: opcion2(texto= opcion1()); break;
                    case 3: opcion3(texto=opcion1()); break;
                    case 4: opcion4(texto=opcion1()); break;
                    case 5: return;
                   
                }


            } while (opcion != 5);



            Console.ReadLine();
        }
        #endregion
        #region --------METODOS DE LOS INCISOS
        static char[] opcion1()
        {
            char[] S;
            do
            {

                Console.WriteLine("Ingrese texto menor a 10 caracteres: ");
                string simbolos = Console.ReadLine().ToUpper();
                 S = simbolos.ToArray();
                if (S.Length > 10)
                {
                    Console.WriteLine("!!ERROR!!Solo 10 caracteres");
                }
            } while (S.Length>10);
            return S;
        }
        static void opcion2(char[] S)
        {
            int columna = 0;
            int renglon=0;
            int retraso = 30;

            if (S.Length==0)
            {
                S = opcion1();
            }
            do
            {
                int columnaP = columna;
                for (int i = 0; i < S.Length; i++)
                {

                    if (columnaP < 115)
                    {
                        impresion(columnaP, renglon, S[i]);
                        columnaP += 8;
                    }
                }
                Thread.Sleep(retraso);
                columna++;

              
            } while (columna < 115 - S.Length*8 );
            do
            {
                int columnaP = columna;
                for (int i = 0; i < S.Length; i++)
                {

                    if (columnaP >= 115)
                    {
                        impresion(columnaP, renglon, S[i]);
                        columnaP += 8;
                    }
                }
                Thread.Sleep(retraso);
                columna++;
            } while (columna<115-S.Length*8);


        }
        static char[] opcion3(char[]Captura)
        {
            if (Captura.Length == 0)
            {
                Captura = opcion1();
            }
            char acomodados;
            int j;
            for (int i = 0; i < Captura.Length; i++)
            {
                acomodados = Captura[i];
                j = i - 1;
                while (j >= 0 && Captura[j] > acomodados)
                {
                    Captura[j + 1] = Captura[j];
                    j--;
                }
                Captura[j + 1] = acomodados;

            }
            opcion2(Captura);
            Console.ReadLine();
            return Captura;
        }
        static char[] opcion4(char[] Captura)
        {
            //aqui toma el texto cargado de la opcion 1 (donde se recibe) y lo almacenada ya en oren alfabetico de la opcion 3
            if (Captura.Length == 0)
            {
                Captura= opcion1();
                
            }
            char acomodados;
            int j;
            for (int i = 0; i < Captura.Length; i++)
            {
                acomodados = Captura[i];
                j = i - 1;
                while (j >= 0 && Captura[j] > acomodados)
                {
                    Captura[j + 1] = Captura[j];
                    j--;
                }
                Captura[j + 1] = acomodados;

            }
            //AHLO a OLHA
            
            char[] Revertido = new char[Captura.Length];

            int x = 0;

            for (int i = Captura.Length - 1; i >= 0; i--)
            {
                Revertido[x] = Captura[i];
                x++;
            }
            opcion2(Revertido);
            Console.ReadLine();
            return Captura;

        }
        #endregion

        #region  METODOS PROPIOS DEL BANNER
        static void impresion(int columna, int renglon, char letra)
        {

            int posicionLetra = IndiceLetra(letra);


            #region letrasSimbolos
            string[] Letras = new string[]
                {
                       "   ■■   ",//posicion 0
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■■■■■  ",//posicion 8
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",

                "  ■■■■  ",//posicion 16
                " ■    ■ ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■■■■■  ",//posicion 24
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",

                " ■■■■■  ",//posicion 32
                " ■      ",
                " ■      ",
                " ■      ",
                " ■■■■■  ",
                " ■      ",
                " ■      ",
                " ■■■■■■ ",

                " ■■■■■■ ",//posicion 40
                " ■      ",
                " ■      ",
                " ■■■■   ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",

                "  ■■■■■ ",//posicion 48
                " ■      ",
                " ■      ",
                " ■      ",
                " ■  ■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■■ ",

                " ■    ■ ",//posicion 56
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■■■■■■ ",//posicion 64
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                " ■■■■■■ ",

                "  ■■■■■ ",//posicion 72
                "    ■   ",
                "    ■   ",
                "    ■   ",
                "    ■   ",
                " ■  ■   ",
                " ■  ■   ",
                "  ■■    ",

                " ■    ■ ",//posicion 80
                " ■   ■  ",
                " ■  ■   ",
                " ■■■    ",
                " ■ ■    ",
                " ■  ■   ",
                " ■   ■  ",
                " ■    ■ ",

                " ■      ",//88
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■■■■■■ ",

                " ■    ■ ",//96
                " ■■  ■■ ",
                " ■ ■■ ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■    ■ ",//104
                " ■    ■ ",
                " ■■   ■ ",
                " ■ ■  ■ ",
                " ■  ■ ■ ",
                " ■   ■■ ",
                " ■    ■ ",
                " ■    ■ ",

                "   ■■   ",//112
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■  ■  ",
                "   ■■   ",

                " ■■■■   ",//120
                " ■   ■  ",
                " ■    ■ ",
                " ■   ■  ",
                " ■■■■   ",
                " ■      ",
                " ■      ",
                " ■      ",

                "   ■■   ",//128
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■  ■■  ",
                "  ■  ■■ ",
                "   ■  ■ ",

                " ■■■■   ",//136
                " ■   ■  ",
                " ■    ■ ",
                " ■■■■■  ",
                " ■ ■    ",
                " ■  ■   ",
                " ■   ■  ",
                " ■    ■ ",

                "  ■■■■  ",//144
                " ■    ■ ",
                " ■      ",
                "  ■■■   ",
                "     ■  ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■■■■■■ ",//152
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",

                " ■    ■ ",//160
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■    ■ ",//168
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■   ■  ",
                "  ■ ■   ",
                "   ■    ",

                " ■    ■ ",//176
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■ ■■ ■ ",
                " ■■  ■■ ",
                " ■    ■ ",

                " ■    ■ ",//184
                "  ■  ■  ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",

                " ■    ■ ",//192
                "  ■  ■  ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",

                " ■■■■■■ ",//200
                "      ■ ",
                "     ■  ",
                "    ■   ",
                "   ■    ",
                "  ■     ",
                " ■      ",
                " ■■■■■■ ",

                "        ",//208
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",


                };
            #endregion
            
            for (int i =posicionLetra; i < posicionLetra + 8; i++)
            {

                Console.SetCursorPosition(columna, renglon);
                Console.WriteLine(Letras[i]);
                renglon++;
            }

        }
        static int IndiceLetra(char letra)
        {
            
            switch (letra)
            {
                case 'A': return 0;
                case 'B': return 8;
                case 'C': return 16;
                case 'D': return 24;
                case 'E': return 32;
                case 'F': return 40;
                case 'G': return 48;
                case 'H': return 56;
                case 'I': return 64;
                case 'J': return 72;
                case 'K': return 80;
                case 'L': return 88;
                case 'M': return 96;
                case 'N': return 104;
                case 'O': return 112;
                case 'P': return 120;
                case 'Q': return 128;
                case 'R': return 136;
                case 'S': return 144;
                case 'T': return 152;
                case 'U': return 160;
                case 'V': return 168;
                case 'W': return 176;
                case 'X': return 184;
                case 'Y': return 192;
                case 'Z': return 200;
                case ' ': return 208;


                default:
                    return letra;
            }

        }

        static void ImpresionFrases(int columna, int renglon, char[] arregloCadena)
        {

            for (int i = 0; i < arregloCadena.Length; i++)
            {
                impresion(columna * i, renglon, arregloCadena[i]);
                columna = columna + 1;
            }
        }
        #endregion


    }
}
