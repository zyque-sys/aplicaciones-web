using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "holi123";
            // Hash
            string hash = SecurePasswordHasher.Hash(contrasena);

            // Verify
            bool result = SecurePasswordHasher.Verify(contrasena, hash);
            Console.WriteLine(hash);
            Console.WriteLine("contra valido:"+result);
            Console.ReadLine();
        }
    }
}
