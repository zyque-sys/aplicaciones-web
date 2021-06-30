using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArreglosBidimensionales
{
    class ClaseMatriz
    {
        #region Campos
        private int maxrenglones;
        private int maxcolumnas;
        private int renglones;
        private int columnas;
        private double[,] matriz;
        #endregion

        #region Propiedades
        public int Maxrenglones { get => maxrenglones; set => maxrenglones = value; }
        public int Maxcolumnas { get => maxcolumnas; set => maxcolumnas = value; }
        public int Renglones { get => renglones; set => renglones = value; }
        public int Columnas { get => columnas; set => columnas = value; }
        public double[,] Matriz { get => matriz; set => matriz = value; }

        public double this[int r, int c]//las propiedades en su firma no llevan parentesis
        {               //indexadores
            get
            {
                //toDo
                return this.Matriz[r, c];
            }
            set
            {

                this.Matriz[r, c] = value;
            }
        }
        #endregion

        #region Constructores
        public ClaseMatriz()
        {
            this.maxrenglones = 5;
            this.maxcolumnas = 5;
            this.renglones = 5;
            this.columnas = 5;
            this.matriz = new double[,] { { 1,2,3,4,5 },
                                          { 6,7,8,9,10 },
                                          { 11,12,13,14,15},
                                          { 16,17,18,19,20},
                                          { 21,22,23,24,25} };
        }

        public ClaseMatriz(int r, int c)
        {
            this.maxrenglones = r;//lo va a depositar de la clase
            this.maxcolumnas = c;
            this.renglones = 0;
            this.columnas = 0;
            this.Matriz = new double[r, c]; //Pedido de memoria
        }
        #endregion

        #region Métodos
        private bool EstaVacia()
        {


            return false;
        }

        public string Mostrar()
        {
            return "";
        }

        public static ClaseMatriz operator +(ClaseMatriz matrizA, ClaseMatriz matrizB)
        {
            //toDo
            
                ClaseMatriz temporal=new ClaseMatriz(matrizA.Maxrenglones,matrizA.Maxcolumnas);
                for (int i = 1; i <= matrizA.; i++)
                {
                    for (int j = 1; j <= fila; j++)
                    {
                        temporal.datos[i, j] = datos[i, j] + objeto.datos[i, j];
                        return temporal;
                    }
                }

            
            return new ClaseMatriz();
        }
    

        public static ClaseMatriz operator *(ClaseMatriz matrizA, ClaseMatriz matrizB)
        {
            //ciclos anidados 
            // i=0: A.maxrenglon
            //j=0; b.maxrenglon
            //se toman los datos de las matrices para ponerlos dentro de una matriz resultante
            ClaseMatriz matrizC = new ClaseMatriz(matrizA.maxrenglones, matrizB.Maxcolumnas);//instancia de memoria

            for (int i = 0; i < matrizA.Maxrenglones; i++)
            {
                for (int j = 0; j < matrizB.Maxcolumnas; j++)
                {
                    for (int r = 0; r < matrizA.maxcolumnas; r++) //empieza la sumatoria solo de donde empieza y donde termina
                    {
                        matrizC[i, j] += matrizA[i, r] * matrizB[r, j];
                    }
                }
            }
            return matrizC;
        }

        #endregion

    }
}
