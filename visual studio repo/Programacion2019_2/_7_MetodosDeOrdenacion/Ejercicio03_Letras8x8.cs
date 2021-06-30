using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _7_MetodosDeOrdenacion
{
    class Ejercicio03_Letras8x8
    {
        static void Main(string[] args)
        {
            #region Variables indispensables
            int columna = 0; int renglon;
            char letra;
            string dato;
            int contador=0;
            #endregion
            //========ETAPA 1
            //Console.WriteLine("Columna,Renglon de la palabra :");
            //dato = Console.ReadLine();
            //int.TryParse(dato, out columna);
            //dato = Console.ReadLine();
            //int.TryParse(dato, out renglon);

            //Console.WriteLine("Letra a escribir: ");
            //dato = Console.ReadLine();
            //char.TryParse(dato, out letra);

            Console.WriteLine("Escriba su frase EN MAYUSCULAS : ");
            string cadena = Console.ReadLine().ToUpper();
            char[] arregloCadena = cadena.ToArray();
            Console.Clear();
            if (cadena == "")
            {
                Console.WriteLine("no ingreso nada");
                Console.ReadLine();
            }

            ////=======etapa 2

            //impresion(0, 0, 'F');

            //===========etapa 3

            //ImpresionFrases(0, 0, arregloCadena);
            //Console.ReadLine();

            //=======etapa 4
            do
            {
                for (int j = 0; j < 25 ; j++)
                {

                    Thread.Sleep(10);
             
                    ImpresionFrases(j, 0, arregloCadena);

                }

                for (int j = 25; j >= 0; j--)
                {

                    Thread.Sleep(10);
                    //if (arregloCadena.Length > 6)
                    //{
                    //    ImpresionFrases(0, 0, arregloCadena);
                    //}

                    ImpresionFrases(j, 0, arregloCadena);
                            
                        
                    

                }

            } while (true);
            //if (nLetras >= 6)
            //{
            //    Thread.Sleep(30);
            //    if (j%5!=0)
            //    {
            //        contador += 8;
            //        columna = j;
            //        ImpresionFrases(columna, contador, arregloCadena);
            //    }
            //}
            Console.ReadLine();

            


        }

        static char[] Ingresos()
        {
            char[] S = { };
            do
            {

                Console.WriteLine("Simbolo a utilizar para la letra: ");
                string simbolos = Console.ReadLine();
                S = simbolos.ToArray();
                if (S.Length > 1)
                {
                    Console.WriteLine("!!ERROR!!Solo un simbolo");
                }
            } while (S.Length != 1);

            return S;
        }

        static void impresion(int columna, int renglon, char letra)
        {
        
                int posicionLetra = IndiceLetra(letra);
                //char[] S = Ingresos();
                //char N = ' ';

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
            #region letrasVariables
            // {

            // { N N S[0] N N S[0] N N } ",
            // { N S[0] N N N N S[0] N } ",
            // { N S[0] N N N N S[0] N } ",
            // { N S[0] S[0] S[0] S[0] S[0] S[0] N }",
            // { N S[0] N N N N S[0] N } ",
            // { N S[0] N N N N S[0] N } ",
            // { N S[0] N N N N S[0] N }",            //A", 0

            // { N S[0] S[0] S[0] S[0] S[0] N N }",   //B",8
            // { N S[0] N N N N S[0] N } ",
            //  { N S[0] N N N N S[0] N }",
            //  { N S[0] N N N N S[0] N }",
            //  { N S[0] S[0] S[0] S[0] S[0] S[0] N }",
            // { N S[0] N N N N S[0] N } ",
            // { N S[0] N N N N S[0] N } ",
            //  { N S[0] S[0] S[0] S[0] S[0] N N } ",

            //  { N S[0] S[0] S[0] S[0] S[0] N N }", //C",16
            // { N S[0] N N N N S[0] N } ",
            //  { N S[0] N N N N N N }",
            // { N", S[0]", N", N", N", N", N", N", }",
            // { N", S[0]", N", N", N", N", N", N", }",
            //{ N", S[0]", N", N", N", N", N", N}",
            // { N", S[0]", N", N", N", N", S[0]", N", }",
            // { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N", }",

            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N", }",  //D}",16
            //  {N", S[0]", N", N", N", N", S[0]", N", }",
            // {N", S[0]", N", N", N", N", S[0]", N", }",
            // {N", S[0]", N", N", N", N", S[0]", N", }",
            // {N", S[0]", N", N", N", N", S[0]", N", }",
            // {N", S[0]", N", N", N", N", S[0]", N", }",
            // { N", S[0]", N", N", N", N", S[0]", N", }",
            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",

            //  {N", N", S[0]", S[0]", S[0]", S[0]", S[0]", N}", //E}",24
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", N", S[0]", S[0]", S[0]", S[0]", S[0]", N}",

            // {N", N", S[0]", S[0]", S[0]", S[0]", S[0]", N}", //F}",32
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",

            //   { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N", }",//G}",40
            //  {N", S[0]", N", N", N", N", S[0]", N", }",
            //  {N", S[0]", N", N", N", N", N", N", }",
            //  {N", S[0]", N", N", N", N", N", N", }",
            //  {N", S[0]", N", N", S[0]", S[0]", S[0]", N}",
            //  {N", S[0]", N", N", N", N", S[0]", N}",
            //  {N", S[0]", N", N", N", N", S[0]", N}",
            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",

            //  { N", S[0]", N", N", N", N", S[0]", N", }",  //H}",48
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",

            //  { N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}", //I}",56
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",
            //   {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}",

            //   {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}", //J}",64
            //   {N", N", N", N", N", S[0]", N", N}",
            //   {N", N", N", N", N", S[0]", N", N}",
            //   {N", N", N", N", N", S[0]", N", N}",
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", N", S[0]", S[0]", S[0]", S[0]", N", N}",

            //   {N", S[0]", N", N", N", N", S[0]", N }",//K}",72
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", S[0]", N", N", S[0]", N", N", N}",
            //   {N", S[0]", S[0]", N", N", N", N", N}",
            //   {N", S[0]", N", S[0]", N", N", N", N}",
            //   {N", S[0]", N", N", S[0]", N", N", N}",
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",

            //   {N", S[0]", N", N", N", N", N", N}", //L}",80
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", S[0]", N", N", N", N", N", N}",
            //   {N", N", S[0]", S[0]", S[0]", }",S[0]", S[0]", N",
            //   }",
            //   { S[0]", S[0]", N", N", N", N", S[0]", S[0]}", //M}",88
            //  { S[0]", N", S[0]", N", S[0]", N", N", S[0]}",
            //   { S[0]", N", N", S[0]", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",

            //   { S[0]", S[0]", N", N", N", N", N", S[0]}", //N", 96
            //   { S[0]", N", S[0]", N", N", N", N", S[0]}",
            //   { S[0]", N", N", S[0]", N", N", N", S[0]}",
            //   { S[0]", N", N", N", S[0]", N", N", S[0]}",
            //   { S[0]", N", N", N", N", S[0]", N", S[0]}",
            //   { S[0]", N", N", N", N", N", S[0]", S[0]}",
            //   { S[0]", N", N", N", N", N", S[0]", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",
            //   { S[0]", N", N", N", N", N", N", S[0]}",

            //   { N", N", S[0]", S[0]", S[0]", S[0]", N", N}", //0}",104
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            // { N", N", S[0]", S[0]", S[0]", S[0]", N", N}",

            // { N", N", S[0]", S[0]", S[0]", S[0]", N", N}", //P}",112
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",
            //   { N", S[0]", N", N", N", N", N", N}",
            //   { N", S[0]", N", N", N", N", N", N}",
            //   { N", S[0]", N", N", N", N", N", N}",

            // { N", N", S[0]", S[0]", S[0]", S[0]", N", N}", //Q}",120
            //     { N", S[0]", N", N", N", N", S[0]", N}",
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //  { N", S[0]", N", S[0]", N", N", S[0]", N}",
            //   { N", S[0]", N", N", S[0]", N", S[0]", N}",
            //   { N", S[0]", N", N", N", S[0]", S[0]", N}",
            //   { N", N", S[0]", S[0]", S[0]", S[0]", N", S[0]}",

            // { N", N", S[0]", S[0]", S[0]", S[0]", N", N}", //R}",128
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",
            //  { N", S[0]", N", N", S[0]", N", N", N}",
            //  { N", S[0]", N", N", N", S[0]", N", N}",
            //  { N", S[0]", N", N", N", N", S[0]", N}",

            //  { N", N", S[0]", S[0]", S[0]", S[0]", N", N}",   //S}",136
            //  { N", S[0]", N", N", N", N", N", N}",
            //  { N", S[0]", N", N", N", N", N", N}",
            //  { N", S[0]", N", N", N", N", N", N}",
            //  { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",
            //  { N", N", N", N", N", N", S[0]", N}",
            //  { N", N", N", N", N", N", S[0]", N}",
            //  { N", S[0]", S[0]", S[0]", S[0]", S[0]", N", N}",

            //   { N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", N}", //T}",144
            //   { N", N", N", S[0]", N", N", N", N}",
            //   { N", N", N", S[0]", N", N", N", N}",
            //  { N", N", N", S[0]", N", N", N", N}",
            //   { N", N", N", S[0]", N", N", N", N}",
            //   { N", N", N", S[0]", N", N", N", N}",
            //   { N", N", N", S[0]", N", N", N", N}",
            //   { N", N", N", S[0]", N", N", N", N}",

            //   { N", S[0]", N", N", N", N", S[0]", N}",  //U}",152
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            // { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", S[0]", N", N", N", N", S[0]", N}",
            //   { N", N", S[0]", S[0]", S[0]", S[0]", N", N}",

            //  { N", S[0]", N", N", N", N", S[0]", N}",   //V}",160
            //  { N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", N", S[0]", N}",
            //   {N", S[0]", N", N", N", S[0]", N", N}",
            //   {N", N", S[0]", N", S[0]", N", N", N}",
            //   {N", N", N", S[0]", N", N", N", N}",

            //   {N", S[0]", N", N", N", N", N", S[0]}", //W}",168
            //   {N", S[0]", N", N", N", N", N", S[0]}",
            //   {N", S[0]", N", N", N", N", N", S[0]}",
            //   {N", S[0]", N", N", N", N", N", S[0]}",
            //   {N", S[0]", N", N", S[0]", N", N", S[0]}",
            //   {N", S[0]", N", N", S[0]", N", N", S[0]}",
            //    {N", S[0]", N", S[0]", N", S[0]", N", S[0]}",
            //  {N", S[0]", S[0]", N", N", N", S[0]", S[0]}",
            //  {N", S[0]", N", N", N", N", N", S[0]}",

            //  {N", S[0]", N", N", N", N", N", S[0]}", //X}",176
            //  {N", N", S[0]", N", N", N", N", S[0]}",
            //  {N", N", N", S[0]", N", N", S[0]", N}",
            //  {N", N", N", N", S[0]", S[0]", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",
            //  {N", N", N", S[0]", N", S[0]", N", N}",
            //  {N", N", S[0]", N", N", N", S[0]", N}",
            //  {N", S[0]", N", N", N", N", N", S[0]}",

            //  {S[0]", N", N", N", N", N", N", S[0]}",   //Y}",184
            //  {N",S[0]", N", N", N", N", S[0]", N}",
            //  {N", N", S[0]", N", N", S[0]", N", N}",
            //  {N", N", N", N", S[0]",N", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",

            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]}",  //Z}",192
            //  {N", N", N", N", N", N", S[0]", N}",
            //  {N", N", N", N", N", S[0]", N", N}",
            //  {N", N", N", N", S[0]", N", N", N}",
            //  {N", N", N", S[0]", N", N", N", N}",
            //  {N", N", S[0]", N", N", N", N", N}",
            //  {N", S[0]", N", N", N", N", N", N}",
            //  {N", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]", S[0]}

            // };
            #endregion
            
            for (int i = posicionLetra; i < posicionLetra + 8; i++)
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
                impresion((columna + 8) * i, renglon, arregloCadena[i]);
                columna = columna + 9;
            }
        }



    }

}

