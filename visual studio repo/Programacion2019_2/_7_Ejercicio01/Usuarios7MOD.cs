using System;
using System.IO;

namespace _7_Ejercicio01
{
    class Usuarios7MOD
    {
        static void Main()
        {
            string PATH = "c:\\temp\\usuarios\\usuario.txt";
            string usuario = "";
            string contrasena = "";



            if (File.Exists(PATH))
            {
                Console.WriteLine("Usuario:");
                usuario = Console.ReadLine();

                Console.WriteLine("Contraseña:");
                contrasena = LeerContrasena(true);

                bool credenciales = CredencialUsuarioValido(PATH, usuario, contrasena);

                if (credenciales)
                {
                    //existe el usuario con todo correcto
                    Menu(PATH);
                }
                else
                {
                    //no existe el usuario o no coinciden credenciales
                }
            }
            else
            {
                Menu(PATH);
            }

            //usuario = "lomito";
            //contrasena = "contra12";
            //nombre = "lomito suave";
            //correo = "lomit0@gmail.com";
            //direccion = "av.casa 1546 ";
            //cp = "21000";
            Console.ReadLine();

        }
        #region Menu
        static void Menu(string PATH)
        {
            const string SEPARADOR = ",";
            string menu = "-------------------------------------------\n" +
                              "| 1.Leer Archivo                          |\n" +
                              "|2.Crear Usuario                          |\n" +
                              "|3.Salir                                  |\n" +
                              "|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|\n" +
                              "|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|\n" +
                              "|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx |\n" +
                              "|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx     |\n" +
                              "-------------------------------------------";
            int opcionInt;
            int SALIDA = 3;
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                do
                {
                    Console.WriteLine("OPCION");
                    int.TryParse(Console.ReadLine(), out opcionInt);
                } while (!(opcionInt > 0 && opcionInt < 4));
                switch (opcionInt)
                {
                    case 1:
                        LeerUsuarios(PATH);
                        break;
                    case 2:
                        CreacionDeUsuario(PATH);
                        break;
                }
            } while (opcionInt != SALIDA);
        }
        #endregion
        static void CreacionDeUsuario(string PATH)
        {
            string usuario, contrasena, nombre, correo, direccion, cp;
            string SEPARADOR = ",";
            Console.WriteLine("Ingrese nombre del usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese Contrasena");
            contrasena = Console.ReadLine();
            Console.WriteLine("Ingrese nombre real del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Correo");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese Direccion");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese CP");
            cp = Console.ReadLine();
            if (File.Exists(PATH))
            {
                GrabarUsuarioNuevo(usuario, contrasena, nombre, correo, direccion, cp, PATH, SEPARADOR);
            }
            else
            {
                GrabarUsuarios(usuario, contrasena, nombre, correo, direccion, cp, PATH, SEPARADOR);
            }

        }
        static void GrabarUsuarioNuevo(string usuario, string contrasena,
            string nombre, string correo, string direccion, string cp,
            String PATH, String SEPARADOR)
        {

            bool variable = UsuarioExiste(PATH, usuario); // busca el usuario y regresa un booleano respecto a su existencia
            if (!variable)
            {
                Console.WriteLine("Guardando nuevo usuario en archivo");
                Console.ReadLine();
                GrabarUsuarios(usuario, contrasena, nombre, correo, direccion, cp, PATH, SEPARADOR);
            }


        }
        static bool UsuarioExiste(string PATH, string nuevoUsuario)
        {
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(s);
                        char[] Cadena;
                        int contadorPalabra = 0;
                        Cadena = s.ToCharArray();
                        String[] Campos = new string[campos];
                        for (int i = 0; i < Cadena.Length; i++)
                        {
                            if (Cadena[i] != ',')
                            {
                                Campos[contadorPalabra] += Campos[i];
                            }
                            else
                            {
                                contadorPalabra++;
                            }
                        }
                        if (Campos[0] == nuevoUsuario)
                        {
                            return true;
                        }


                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error de ejecucion\n");
            }
            return false;
        }


        static bool CredencialUsuarioValido(string PATH, string usuario, string contrasena)
        {
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(s);
                        char[] Cadena;
                        int contadorPalabra = 0;
                        Cadena = s.ToCharArray();
                        string[] Campos = new string[campos];
                        for (int i = 0; i < Cadena.Length; i++)
                        {
                            if (Cadena[i] != ',')
                            {
                                Campos[contadorPalabra] += Cadena[i];
                            }
                            else
                            {
                                contadorPalabra++;
                            }
                        }
                        if (Campos[0] == usuario)
                        {
                            if (SecurePasswordHasher.Verify(contrasena, Campos[1]))
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Contrasena invalida");
                                return false;
                            }
                        }


                    }


                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error en ejecucion\n");
            }
            Console.WriteLine("Usuario no existe");
            return false;
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
                    //fs.Write(contrasena);
                    fs.Write(SecurePasswordHasher.Hash(contrasena)); //encrypta el password
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
                Console.WriteLine("Error en ejecucion\n" + ex.ToString());
            }


        }
        static public void LeerUsuarios(string PATH)
        {
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("--NO EXISTEN USUARIOS REGISTRADOS--");
                Console.ReadLine();
            }
            Console.ReadLine();
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
        static string LeerContrasena(bool eco)
        {
            ConsoleKeyInfo cki;
            String password = "";
            do
            {
                cki = Console.ReadKey(true);
                if (eco)
                {
                    Console.Write("^");
                }
                if (cki.Key!=ConsoleKey.Enter)
                {
                    password += cki.KeyChar;
                }
            } while (cki.Key!=ConsoleKey.Enter);
            return password;

        }
    }
}
