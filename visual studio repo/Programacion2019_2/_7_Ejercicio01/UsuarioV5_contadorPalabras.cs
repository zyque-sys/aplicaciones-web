using System;
using System.IO;


namespace _7_Ejercicio01
{
    class UsuarioV5_contadorPalabras
    {
        static void Main()
        {
            string path = "c:\\temp\\Usuarios\\Usuarios.txt";
            //Las constantes por convención se les llama con mayúsculas
            const string SEPARADOR = ",";
            string usuario, contrasena, nombre, correo, direccion, codigoPostal;
            usuario = "YairRT";
            contrasena = "Yair123";
            nombre = "Yair";
            correo = "YairRuiz79@gmail.com";
            direccion = "Linazas";
            codigoPostal = "21395";

            SaveUser(path, SEPARADOR, usuario, contrasena, nombre, correo, direccion, codigoPostal);
            GetUsers(path);
            Console.ReadLine();
        }
        #region SaveUser
        static public void SaveUser(string path, string SEPARADOR, string usuario, string contrasena, string nombre, string correo, string direccion, string cp)
        {
            try
            {
                //Cambiamos de File.Create a File.AppendText
                //File.Create me sobreescribia el documento y el AppendText me agrega al documento
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.Write(usuario);
                    sw.Write(SEPARADOR);
                    sw.Write(contrasena);
                    sw.Write(SEPARADOR);
                    sw.Write(nombre);
                    sw.Write(SEPARADOR);
                    sw.Write(correo);
                    sw.Write(SEPARADOR);
                    sw.Write(direccion);
                    sw.Write(SEPARADOR);
                    sw.Write(cp);
                    sw.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        static public void GetUsers(string path)
        {

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(linea);
                        int contadorPalabra = 0;
                        char[] arregloCadena = linea.ToCharArray();

                        //Impresión de la linea leída
                        Console.WriteLine(linea);

                        Console.WriteLine("Tiene {0} campos", campos);

                        String[] Campos = new string[campos];

                        for (int i = 0; i < arregloCadena.Length; i++)
                        {
                            if (arregloCadena[i] != ',')
                            {
                                Campos[contadorPalabra] += arregloCadena[i];
                            }
                            else
                            {
                                contadorPalabra++;
                            }
                        }
                        //for (int i = 0; i < contadorPalabra + 1; i++)
                        //{
                        //    Console.WriteLine(Campos[i]);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public int ContadorDeCampos(string texto)
        {
            int cantidad = 0;
            char[] arregloPalabra = texto.ToCharArray();
            for (int i = 1; i < arregloPalabra.Length; i++)
            {
                if (arregloPalabra[i] == ',' && arregloPalabra[i - 1] != ',')
                {
                    cantidad++;
                }
            }
            if (arregloPalabra[arregloPalabra.Length - 1] != ',')
            {
                cantidad++;
            }
            return cantidad;

        
        }
    }
}
    

