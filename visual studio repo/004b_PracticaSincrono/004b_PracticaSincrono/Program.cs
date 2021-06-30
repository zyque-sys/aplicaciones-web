using System;


namespace _004b_PracticaSincrono
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProgramaCliente client = new ProgramaCliente("192.168.0.2", 4404);
                client.Start();
                client.Enviar("Mensaje del cliente");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                //SocketException
                Console.WriteLine("Excepcion : {0}",e);
                Console.ReadLine();
            }
            
        }
    }
}
