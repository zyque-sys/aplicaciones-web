using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ArregloBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Acreada=false;
            bool Bcreada=false;

            int[,] destinoA=new int[5,5];
            int[,] destinoB = new int[5, 5];

            ClaseMatriz A = new ClaseMatriz(4, 4);
            ClaseMatriz B = new ClaseMatriz(4, 4);
            string menu = "1.Precargar matriz \n " +
                "2.Crear matriz A\n" +
                "3.Crear matriz B\n" +
                "4.Llenar matriz A\n" +
                "5.Llenar matriz B\n" +
                "6.Realizar suma de A y B\n" +
                "7.Realizar multiplicacion de A y B\n" +
                "8.Limpiar matriz A\n" +
                "9.Limpiar matriz B\n" +
                "10.Mostrar contenido de las matrices A y B\n" +
                "11.Salir\n";
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        A = new ClaseMatriz(4, 6);
                        B = new ClaseMatriz(4, 6);
                        PrecargarMatriz(A, B); 
                        Acreada = true;
                        Bcreada = true;
                        break;
                    case 2:
                        Console.WriteLine("--Creacion de la matriz A--\n");
                        A = CrearMatriz("A");
                        Acreada = true; break;
                    case 3:
                        Console.WriteLine("--Creacion de la matriz A--\n");
                        B = CrearMatriz("B");
                        Bcreada = true; break;
                    case 4:
                        Console.WriteLine("Llenado de la matriz A:");
                        Console.WriteLine(A.Mostrar());
                        if (Acreada)
                        {
                            LlenarMatriz(A, destinoA);
                            Console.WriteLine(A.Mostrar());
                        }
                        else
                        {
                            Console.WriteLine("Matriz A no esta creada\nPrimero cree la matriz :C");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Llenado de la matriz B:");
                        Console.WriteLine(B.Mostrar());
                        if (Bcreada)
                        {
                            LlenarMatriz(B, destinoB);
                            Console.WriteLine(B.Mostrar());
                        }
                        else
                        {
                            Console.WriteLine("Matriz B no esta creada\nPrimero cree la matriz :C");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Suma de las matrices A y B");
                        ClaseMatriz resultado = new ClaseMatriz(0,0);
                        if (Acreada && Bcreada)
                        {
                            resultado = A + B;
                            A.Mostrar();
                            Console.WriteLine(" + ");
                            B.Mostrar();
                            Console.WriteLine("El resultado de la operacion suma (A+B) es:\n" + resultado.Mostrar());
                        }
                        
                        break;
                    case 7:
                        Console.WriteLine("Multiplicacion de las matrices A y B");
                        ClaseMatriz resultado1 = new ClaseMatriz(0, 0);
                        if (Acreada && Bcreada)
                        {
                            resultado1 = A * B;
                            A.Mostrar();
                            Console.WriteLine(" x ");
                            B.Mostrar();
                            Console.WriteLine("El resultado de la operacion suma (A+B) es:\n" + resultado1.Mostrar());
                        }
                        break;
                    case 8:
                        Console.WriteLine("Limpiado de la matriz A");
                        LimpiarMatriz(A);
                        Console.WriteLine("matriz limpia!!!");
                        break;
                    case 9:
                        Console.WriteLine("Limpiado de la matriz B");
                        LimpiarMatriz(B);
                        Console.WriteLine("matriz limpia!!!"); break;
                    case 10:
                        Console.WriteLine("---Matrices---");
                        Console.WriteLine("Matriz A\n:"+A.Mostrar());
                        Console.WriteLine("Matriz B\n:" + B.Mostrar()); break;

                    
                }
                Console.ReadLine();
            } while (opcion!=11);
        
        }
        //caso 1
     
        public static void PrecargarMatriz(ClaseMatriz A,ClaseMatriz B)
        {
            int [,]destinoA = new int[,] { { 111, 111, 111, 111, 1, 11 }, { 1, 11, 111, 1111, 1, 1 }, { 11, 111, 4, 1, 15, 14 }, { 0, 0, 0, 0,15,1} };
            int[,] destinoB = new int[,] { { 111, 111, 111, 111, 1, 11 }, { 1, 11, 111, 1111, 1, 1 }, { 11, 111, 4, 1, 15, 14 }, { 0, 0, 0, 0, 15, 1 } };
            
            A = LlenarMatriz(A, destinoA);
            B = LlenarMatriz(B,destinoB);
            
        }
        //caso 2,3
        ///
        public static ClaseMatriz CrearMatriz(string letra)
        {
            int r, c;
            ClaseMatriz objetoInutil=new ClaseMatriz(0,0);
            do
            {
                Console.WriteLine("Numero de RENGLONES:");
            } while (!int.TryParse(Console.ReadLine(), out r));
            do
            {
                Console.WriteLine("Numero de COLUMNAS:");
            } while (!int.TryParse(Console.ReadLine(), out c));
            if (letra=="A")
            {
                ClaseMatriz A = new ClaseMatriz(r, c);
                Console.WriteLine("Se creo la matriz " + letra+":\n"+A.Mostrar());
                return A;
            }
            else if (letra=="B")
            {
                ClaseMatriz B = new ClaseMatriz(r, c);
                Console.WriteLine("Se creo la matriz " + letra + ":\n" + B.Mostrar());
                return B;
            }
            return objetoInutil;
            
        }
        //caso 4,5
        public static ClaseMatriz LlenarMatriz(ClaseMatriz matriz,int[,] destino)
        {
            for (int r = 0; r < matriz.Maxrenglones; r++)
            {
                for (int c = 0; c < matriz.Maxcolumnas; c++)
                    matriz[r, c] = destino[r, c];
            }
            return matriz;

        }
        //caso 6
    
        //caso 8,9
        public static ClaseMatriz LimpiarMatriz(ClaseMatriz matriz)
        {
            for (int r = 0; r < matriz.Maxrenglones; r++)
            {
                for (int c = 0; c < matriz.Maxcolumnas; c++)
                {
                    matriz[r, c] = 0;
                }
            }
            return matriz;

        }
        //caso 10
    

    }
}
