using System;
using System.IO;


namespace _7_Ejercicio01
{
    class UsuariosV3
    {
        static void Main(string[] args)
        {
            string path = "c:\\temp\\usuarios\\usuario.txt";
            const string SEPARADOR = ",";
            try
            {

                using (StreamWriter fs = File.AppendText(path))
                {
                    fs.Write("USUARIO");
                    fs.Write(SEPARADOR);
                    fs.Write("CONTRASENA");
                    fs.Write(SEPARADOR);
                    fs.Write("NOMBRE");
                    fs.Write(SEPARADOR);
                    fs.Write("CORREO");
                    fs.Write(SEPARADOR);
                    fs.Write("DIRECCION");
                    fs.Write(SEPARADOR);
                    fs.Write("CP");
                    fs.WriteLine();
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
