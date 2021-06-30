using System;

class parametrosConsola
{
    static void Main(string[] args )
    {         //crear una variable de tipo arreglo, la variable es args
        Console.WriteLine("Imprime desde consola");

        Console.WriteLine("Argumento: " + args[0]);
        Console.WriteLine("Argumento: " + args[1]);

        int A, B, suma;
        int.TryParse(args[0], out A);
        int.TryParse(args[1], out B);
        suma = A + B;

        Console.WriteLine("La suma es:" + suma);


    }
}
