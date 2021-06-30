using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MetodosEjercicios
{
    class ClaseMetodos
    {
        //listo
        #region Metodo 1
        //1.Crear un metodo que indique si una cadena contiene exclusivamente numeros

        public void Metodo1()
        {
            Console.WriteLine("Ingrese su cadena a evaluar:");
            string dato = Console.ReadLine();
            char[] Captura;
            bool salida = false;
            char[] Numerico = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            Captura = dato.ToArray();

            for (int i = 0; i < Captura.Length; i++)
            {
                salida = false;
                for (int j = 0; j < Numerico.Length; j++)
                {
                    if (Captura[i] == Numerico[j])
                    {
                        salida = true; break;
                    }
                }
                if (!salida)
                {
                    Console.WriteLine("Su cadena NO es de numeros");
                }
                if (salida)
                {
                    Console.WriteLine("Su cadena es de numeros");
                }
            }
            
            Console.ReadLine();

        }
        #endregion
        //listo
            #region Metodo 2
            //2.Crear un metodo que regrese el numero entero contenido en una cadena de caracteres
            public void Metodo2()
        {
            //char[] cadena;
            //int[] numeros = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //string lectura;

            //Console.WriteLine("Ingrese la cadena a evaluar");
            //lectura = Console.ReadLine();
            //cadena = lectura.ToArray();
            //for (int i = 0; i < cadena.Length; i++)
            //{
            //    if (cadena[i] == 0 || cadena[i] == 1 || cadena[i] == 2 || cadena[i] == 3 || cadena[i] == 4 || cadena[i] == 5 || cadena[i] == 6 || cadena[i] == 7 || cadena[i] == 8 || cadena[i] == 9)
            //    {
            //        numeros[i] = cadena[i];
            //    }
            //}
            //Console.WriteLine("Los numeros enteros en la cadena son:");
            //for (int f = 0; f < numeros.Length; f++)
            //{
            //    Console.Write(numeros[f] + "  ");
            //}
            //Console.ReadLine();
            Console.WriteLine("Ingrese la cadena a procesar: ");
            string dato = Console.ReadLine();
            char[] Captura;
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            Captura = dato.ToArray();

            for (int i = 0; i < Captura.Length; i++)
            {
            
                for (int j = 0; j < numeros.Length; j++)
                {
                     if (Captura[i] == numeros[j])
                    {
                        Console.Write(Captura[i]);
                    }
                   
                }
            
            }

            Console.ReadLine();

        }
        #endregion
        //listo
        #region Metodo 3
        //3.Crear un metodo que imprima en pantalla la tabla de multiplicar seleccionada por el usuario
        public void Metodo3()
            {
                int multiplicado;
                int resultado;
                do
                {
                    Console.WriteLine("Ingrese el numero cuya tabla de multiplicar desea saber: ");
                    if (!(int.TryParse(Console.ReadLine(), out multiplicado)))
                    {
                        Console.WriteLine("!!ERROR!!: Solo un numero entero");
                    }
                } while (!(multiplicado>=0));
                for (int i = 0; i < 11; i++)
                {
                resultado = multiplicado * i;
                Console.WriteLine(multiplicado + "x" + i + "=" + resultado);
                }
            Console.ReadLine();
            }
        #endregion
        //listo 
        #region Metodo 4
        //4.Realizar un metodo que indique si un numero es par o no usando true o false
        public void Metodo4()
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero para determinar si este es par o no: ");
                if (!(int.TryParse(Console.ReadLine(), out numero)))
                {
                    Console.WriteLine("!!ERROR!!: Solo un numero entero");
                }
            } while (!(numero >= 0));
            numero = numero % 2;
            if (numero==0)
            {
                Console.WriteLine("El numero que ingreso es par");
            }
            else
            {
                Console.WriteLine("El numero que ingreso NO es par");
            }
            Console.ReadLine();
        }

        #endregion
        //listo
        #region Metodo 5
        //5.Realizar un metodo que imprima los primeros N numeros impares
        public void Metodo5()
        {
            int iteraciones;
            int impresion;
            do
            {
                Console.WriteLine("Ingrese el numero de numeros impares a imprimir: ");
                if (!(int.TryParse(Console.ReadLine(), out iteraciones)))
                {
                    Console.WriteLine("!!ERROR!!: Solo un numero entero");
                }
            } while (!(iteraciones >= 0));
            Console.WriteLine("Los numeros son: ");
            Console.WriteLine(0);
            for (int i = 0; i < (iteraciones*2)-1; i++)
            {
                impresion = i % 2;
                if (impresion != 0)
                {
                    impresion = i + 2;
                    Console.WriteLine(impresion);
                }
            }
            Console.ReadLine();
        }
        #endregion
        //listo
        #region Metodo 6
        //6.Realizar un metodo que imprima los primeros N numeros de la serie de fibonacci
        public void Metodo6()
        {
            int iteraciones;
            int a, b,suma;
            int contador=0;
            do
            {
                Console.WriteLine("Ingrese el numero de sucesiones de Fibonacci a imprimir: ");
                if (!(int.TryParse(Console.ReadLine(), out iteraciones)))
                {
                    Console.WriteLine("!!ERROR!!: Solo un numero entero");
                }
            } while (!(iteraciones >= 0));
            Console.WriteLine("Los numeros son: ");
            a = 0;
            b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            do
            {
                suma = a + b;
                a = b;
                b = suma;
                Console.WriteLine(suma);
                contador++;
            } while (contador<iteraciones-2);

            Console.ReadLine();
        }
        #endregion
        //masomenos
        #region Metodo 7
        //7.Realizar un metodo que indique si el resultado de una division es exacto o no
        public void Metodo7()
        {
            bool validez;
            int divisor;
            int dividendo;
            int resultado,sobrante;
                do
                {
                    Console.WriteLine("Ingrese el divisor: ");
                    validez = int.TryParse(Console.ReadLine(), out divisor);
                    if (!validez)
                    {
                        Console.WriteLine("!!ERROR!!: Solo un numero entero");
                    }
                } while (!validez);

            do
            {
                Console.WriteLine("Ingrese el dividendo: ");
                validez = int.TryParse(Console.ReadLine(), out dividendo);
                if (!validez)
                {
                    Console.WriteLine("!!ERROR!!: Solo un numero entero");
                }
            } while (!validez);
            resultado = dividendo % divisor;
            if (resultado!=0)
            {
                resultado = dividendo / divisor;
                sobrante = dividendo % divisor;
                Console.WriteLine("La division que los numeros "+divisor+" y "+dividendo+" NO es exacta, su resultado es "+resultado+" y sobran "+sobrante);
            }
            if (resultado == 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("La division es exacta," + dividendo + " entre " + divisor + " da: " + resultado);
            }

            Console.ReadLine();
        }
        #endregion
        #region Marco
        public void Recuadro (string[] marco)
        {
            string esquinaSI = marco[0];
            string lineaHorizontal = marco[1];
            string esquinaSD = marco[2];
            string lineaVertical = marco[3];
            string esquinaID = marco[4];
            string esquinaII = marco[5];

        }
        #endregion
    }
}

