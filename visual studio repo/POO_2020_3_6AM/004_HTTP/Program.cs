using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _004_HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create("http://www.upbc.edu.mx");
            // Turn off connection keep-alives.  
            HttpWReq.KeepAlive = false;

            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();

            // Get the HTTP protocol version number returned by the server.  
            String ver = HttpWResp.ProtocolVersion.ToString();
            Console.WriteLine(ver);
            HttpWResp.Close();
            Console.ReadLine();

        }
    }
}
