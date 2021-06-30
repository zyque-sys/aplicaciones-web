using System;
using System.IO;

namespace _7_Ejercicio01
{
    class UsuariosV4_Metodos
    {
        static void Main()
        {
            string PATH = "c:\\temp\\usuarios\\usuario.txt";
            const string SEPARADOR = "";
            string usuario, contrasena, nombre, correo, direccion, cp;
            usuario = "lomito";
            contrasena = "contra12";
            nombre = "lomito suave";
            correo = "lomit0@gmail.com";
            direccion = "av.casa 1546 ";
            cp = "21000";
            GrabarUsuarios(usuario, contrasena,nombre, correo, direccion,cp, PATH, SEPARADOR);
            //LeerUsuarios(PATH);
            Console.ReadLine();
            
        }

        static public void GrabarUsuarios(string usuario, string contrasena,
            string nombre, string correo, string direccion, string cp,
            String PATH, String SEPARADOR)
        {

            try
            {

                using (StreamWriter fs = File.AppendText(PATH))
                {
                    fs.Write(usuario);
                    fs.Write(SEPARADOR);
                    fs.Write(contrasena);
                    fs.Write(SEPARADOR);
                    fs.Write(nombre);
                    fs.Write(SEPARADOR);
                    fs.Write(correo);
                    fs.Write(SEPARADOR);
                    fs.Write(direccion);
                    fs.Write(SEPARADOR);
                    fs.Write(cp);
                    fs.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ejecucion\n"+ex.ToString());
            }
        

        }
        static public void LeerUsuarios(string PATH)
        {
            using (StreamReader sr = File.OpenText(PATH))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }




        }
    }
}
