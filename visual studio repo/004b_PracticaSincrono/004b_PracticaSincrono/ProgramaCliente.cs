using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace _004b_PracticaSincrono
{
    class ProgramaCliente
    {
        IPAddress ipAddress;
        IPHostEntry host;
        IPEndPoint endPoint;
        Socket envio;

        public ProgramaCliente(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddress = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, port);
            envio = new Socket(ipAddress.AddressFamily, SocketType.Stream,
                ProtocolType.Tcp);
        }
        public void Enviar(string mensaje)
        {
            byte[] bytemensaje = Encoding.ASCII.GetBytes(mensaje);
            envio.Send(bytemensaje);
            Console.WriteLine("Mensaje Enviado");

        }
        public void Start()
        {
            envio.Connect(endPoint);
        }
       
    }
    }


