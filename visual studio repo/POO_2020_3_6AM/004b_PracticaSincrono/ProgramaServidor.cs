using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace _004b_PracticaSincrono
{
    class ProgramaServidor
    {
         IPHostEntry host;
         IPAddress ipAddress;
         IPEndPoint endPoint;

        Socket sServer;
         Socket sClient;

         public ProgramaServidor(String ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddress = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, port);

            sServer = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sServer.Bind(endPoint);
            sServer.Listen(10);
        }
         public void Start()
        {
            byte[] buffer = new byte[1024];
            string mensaje;
            sClient = sServer.Accept();
            sClient.Receive(buffer);
            mensaje = Encoding.ASCII.GetString(buffer);
            Console.WriteLine("Respuesta del servidor: " + mensaje);
        }


    }
}

