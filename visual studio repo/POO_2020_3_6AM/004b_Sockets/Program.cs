using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _004b_Sockets
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sTCP = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream,
                            ProtocolType.Tcp);

            Socket sUDP = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Dgram,  
                ProtocolType.Udp);

            IPHostEntry ipHostInfo = Dns.Resolve("google.com");
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint ipe = new IPEndPoint(ipAddress, 11000);

            try
            {
                sTCP.Connect(ipe);
                byte[] msg = System.Text.Encoding.ASCII.GetBytes("This is a test");
                int bytesSent = sTCP.Send(msg);
                byte[] bytes = new byte[1024];
                int bytesRec = sTCP.Receive(bytes);
                Console.WriteLine("Echoed text = {0}",
                    System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRec));
                Console.ReadLine();
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("ArgumentNullException : {0}", ae.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            sTCP.Shutdown(SocketShutdown.Both);
            sTCP.Close();

            Console.ReadLine();
        }
    }
}
