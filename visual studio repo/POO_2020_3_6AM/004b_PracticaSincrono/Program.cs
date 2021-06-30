using System;


namespace _004b_PracticaSincrono
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProgramaServidor server = new ProgramaServidor("192.168.0.2", 4404);
                server.Start();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion {0}",e);
                
            }
            Console.ReadLine();
        }
    }
}
