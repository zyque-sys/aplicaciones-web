using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ArregloBidimensional
{
    class ClaseMatriz
    {
        #region Campos
        private readonly int maxrenglones;
        private readonly int maxcolumnas;
        private int renglones;
        private int columnas;
        private double[,] matriz;
        int newField;



        #endregion
        #region Constructor
        public ClaseMatriz(int r, int c)
        {
            this.maxrenglones = r;
            this.maxcolumnas = c;
            this.renglones = 0;
            this.columnas = 0;

            matriz = new double[r, c];
   //         matriz = new double[,]
   //{
   //         {111,111,111,111 },
   //         {1,11,111,1111 },
   //         {11,111,4,1 },
   //         {0,0,0,0 }

   //};

        }
        #endregion

        #region Propiedades
        public int Maxrenglones { get => maxrenglones; }
        public int Maxcolumnas { get => maxcolumnas; }
        public int Renglones { get => renglones; set => renglones = value; }
        public int Columnas { get => columnas; set => columnas = value; }
        public double[,] Matriz { get => matriz; set => matriz = value; }
        #endregion

        #region Metodos
   
        public double this[int r, int c]
            {
            get
            {

                return (this.matriz[r, c]);
            }

            set
            {

                this.matriz[r, c] = 0;

            }
            
        }
        public bool EstaVacia()
        {
            if (this.renglones==0 &&this.columnas==0)
             {
                return true;
             }
    return false;
        }


        private int[] MaximoCaracteresPorColumna()
        {
            int[] maxCol = new int[this.maxcolumnas];

            for (int c = 0; c < this.maxcolumnas; c++)
            {
                maxCol[c] = int.MinValue;
                for (int r = 0; r < this.maxrenglones; r++)
                {
                    if (maxCol[c]<NCaracteres(this.matriz[r, c]))
                    {
                        maxCol[c] = NCaracteres(this.matriz[r, c]);
                    }
                }
            }


            return maxCol;
        }

        private int NCaracteres(double valor)
        {
            return valor.ToString().Length;

        }

        public string Mostrar()
        {
            string salida = "";
            int[] maxCol = MaximoCaracteresPorColumna();


            for (int r = 0; r < this.maxrenglones; r++)
            {
                salida += "|";
                for (int c = 0; c < this.maxcolumnas; c++)
                {
                    salida += " ";
                    for (int caracteres = NCaracteres(this.matriz[r,c]); caracteres <maxCol[c] ; caracteres++)
                    {
                        salida += " ";
                    }

                    salida += this.matriz[r, c];
                    if (c!=this.maxcolumnas-1)
                    {
                        salida += ",";
                    }
                }
                salida += "|\n";
            }
            return salida;
        }


        public static ClaseMatriz operator +(ClaseMatriz A, ClaseMatriz B)
        {
            ClaseMatriz MatrizC = new ClaseMatriz(A.Maxrenglones, B.Maxcolumnas);
            double suma;

            for (int i = 0; i < A.Maxrenglones; i++)
            {
                for (int k = 0; k < B.Maxcolumnas; k++)
                {
                    suma = 0.0;
                    for (int j = 0; j < A.Maxcolumnas; j++)
                    {
                        suma += A[i, j] + B[j, k];
                    }
                    MatrizC[i, k] = suma;
                }
            }
            return MatrizC;
        }


        public static ClaseMatriz operator *(ClaseMatriz A, ClaseMatriz B)
        {
            ClaseMatriz MatrizC = new ClaseMatriz(A.Maxrenglones, B.Maxcolumnas);
            double multiplicacion;

            for (int i = 0; i < A.Maxrenglones; i++)
            {
                for (int k = 0; k < B.Maxcolumnas ; k++)
                {
                    multiplicacion = 0.0;
                    for (int j = 0; j < A.Maxcolumnas ; j++)
                    {
                        multiplicacion += A[i, j] * B[j, k];
                    }
                    MatrizC[i, k] = multiplicacion;
                }
            }
            return MatrizC;
        }
        #endregion
    }

}
