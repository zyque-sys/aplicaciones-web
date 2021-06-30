using System;

class salidaEstandar
{
    static void Main()
    {
        int valorA;
        int valorB;

        //	Console.Write("hola");
        //	Console.Write(" ");
        //	Console.Write("mundo");

        /*	Console.WriteLine("hola");
            Console.WriteLine("mundo"); 	*/
        valorA = 10;
        valorB = 20;
        /*	Console.WriteLine("El valor de A es:");
            Console.WriteLine(valorA);
            Console.WriteLine("El valor de B es:"+valorB);
        */
        /*	Console.Write("El valor de A es:");
            Console.WriteLine(valorA);
            Console.Write("El valor de B es:"+valorB);
        */
        Console.WriteLine("El valor de A es:" + valorA);
        Console.WriteLine("El valor de B es:" + valorB);
        /*	int valorC;
            valorC=valorB+valorA;
            Console.WriteLine("La suma es:"+valorC);
            */
        Console.WriteLine("La suma es:" + (valorA + valorB));
        Console.WriteLine("Variable A: {0},Variable B:{1}, la suma de las vaariables es: {2}", valorA, valorB, valorA + valorB);
        Console.WriteLine("El valor de A es:" + valorA + "\nEl valor de B es:" + valorB + "\nSu suma es:" + (valorA + valorB));
    }





}