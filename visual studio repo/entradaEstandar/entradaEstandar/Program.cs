using System;

class entradaEstandar
{
    static void Main()
    {
        string dato;
        /*		Console.WriteLine("Ingresa tu nombre");
                dato=Console.ReadLine();                 //Regresa valor
                Console.WriteLine("Tu nombre es: "+dato);
        */
        int A, B, suma;
        Console.WriteLine("Pon un numero");
        dato = Console.ReadLine();
        int.TryParse(dato, out A);                 //convierte dato a int y lo suplanta en A

        Console.WriteLine("Pon otro");
        dato = Console.ReadLine();
        int.TryParse(dato, out B);




    }
}