using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace _3AM_180416_LEYVA_MOJARDIN_EXCAP4
{
    class Program
    {
        static void Main(string[] args)
        {
            string PATH = "c:\\temp\\usuarios.txt";
            string CALIF = "c:\\temp\\calificaciones.txt";
            string miNombre = "NAYLA";
            char[] arregloCadena = miNombre.ToArray();
            int columna = 0;
            int renglon = 0;
            int retraso = 30;
            //-----PASO 0
            do
            {
                int columnaP = columna;
                for (int i = 0; i < arregloCadena.Length; i++)
                {

                    if (columnaP < 112)
                    {
                        impresion(columnaP, renglon, arregloCadena[i]);
                        columnaP += 8;
                    }
                }
                Thread.Sleep(retraso);
                columna++;
            } while (columna < 105 /* - arregloCadena.Length*8 */);


            string usuario = "";
            

            #region Existencia del Archivo PATH

            if (File.Exists(PATH))
            {
                Console.WriteLine("Usuario:");
                usuario = Console.ReadLine();

                Console.WriteLine("Contraseña:");
                string contrasena = LeerContrasena(true);


                bool credenciales = CredencialUsuarioValido(PATH, usuario, contrasena);

              
                while (!credenciales)
                {
                    Console.WriteLine("Verifique sus credenciales");
                    Console.Write("Usuario: ");
                    usuario = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    contrasena = LeerContrasena(true);
                    Console.WriteLine();
                    credenciales = CredencialUsuarioValido(PATH, usuario, contrasena);
                    
                }
                if (credenciales)
                {
                    //existe el usuario con todo correcto
                    Menu(PATH, CALIF);
                }
            }
            else
            {
                Menu(PATH, CALIF);
            }
            #endregion

        }
        static void Menu(string PATH, string CALIF) {

            int opcion = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|1.Registrar usuario                      |");
                Console.WriteLine("|2.Registrar calificaciones               |\n" +
                                  "|3.Mostrar usuarios                       |\n" +
                                  "|4.Mostrar calificaciones                 |\n" +
                                  "|                                         |\n" +
                                  "|5.Salir del programa[!]                  |\n" +
                                  "-------------------------------------------");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: CreacionDeUsuario(PATH); break;
                    case 2:
                        int opcioon = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("USUARIOS: ");
                            LeerUsuarios(PATH);
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("|1.Registrar calificaciones               |");
                            Console.WriteLine("|2.Cancelar  y regresar                   |\n" +
                                                                "-------------------------------------------");

                            int.TryParse(Console.ReadLine(), out opcioon);

                            switch (opcioon)
                            {
                                case 1: RegistrarCalificaciones(PATH, CALIF); break;
                            }
                        } while (opcion != 2); ; break;
                    case 3: LeerUsuarios(PATH); break;
                    case 4: LeerCalificaciones(CALIF); break;
                }


            } while (opcion != 5);



            Console.ReadLine();


        }
        static void impresion(int columna, int renglon, char letra)
        {

            int posicionLetra = IndiceLetra(letra);


            #region letrasSimbolos
            string[] Letras = new string[]
                {
                       "   ■■   ",//posicion 0
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■■■■■  ",//posicion 8
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",

                "  ■■■■  ",//posicion 16
                " ■    ■ ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■■■■■  ",//posicion 24
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■  ",

                " ■■■■■  ",//posicion 32
                " ■      ",
                " ■      ",
                " ■      ",
                " ■■■■■  ",
                " ■      ",
                " ■      ",
                " ■■■■■■ ",

                " ■■■■■■ ",//posicion 40
                " ■      ",
                " ■      ",
                " ■■■■   ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",

                "  ■■■■■ ",//posicion 48
                " ■      ",
                " ■      ",
                " ■      ",
                " ■  ■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■■ ",

                " ■    ■ ",//posicion 56
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■■■■■■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■■■■■■ ",//posicion 64
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                " ■■■■■■ ",

                "  ■■■■■ ",//posicion 72
                "    ■   ",
                "    ■   ",
                "    ■   ",
                "    ■   ",
                " ■  ■   ",
                " ■  ■   ",
                "  ■■    ",

                " ■    ■ ",//posicion 80
                " ■   ■  ",
                " ■  ■   ",
                " ■■■    ",
                " ■ ■    ",
                " ■  ■   ",
                " ■   ■  ",
                " ■    ■ ",

                " ■      ",//88
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■      ",
                " ■■■■■■ ",

                " ■    ■ ",//96
                " ■■  ■■ ",
                " ■ ■■ ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",

                " ■    ■ ",//104
                " ■    ■ ",
                " ■■   ■ ",
                " ■ ■  ■ ",
                " ■  ■ ■ ",
                " ■   ■■ ",
                " ■    ■ ",
                " ■    ■ ",

                "   ■■   ",//112
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■  ■  ",
                "   ■■   ",

                " ■■■■   ",//120
                " ■   ■  ",
                " ■    ■ ",
                " ■   ■  ",
                " ■■■■   ",
                " ■      ",
                " ■      ",
                " ■      ",

                "   ■■   ",//128
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■  ■■  ",
                "  ■  ■■ ",
                "   ■  ■ ",

                " ■■■■   ",//136
                " ■   ■  ",
                " ■    ■ ",
                " ■■■■■  ",
                " ■ ■    ",
                " ■  ■   ",
                " ■   ■  ",
                " ■    ■ ",

                "  ■■■■  ",//144
                " ■    ■ ",
                " ■      ",
                "  ■■■   ",
                "     ■  ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■■■■■■ ",//152
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",

                " ■    ■ ",//160
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                "  ■■■■  ",

                " ■    ■ ",//168
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■   ■  ",
                "  ■ ■   ",
                "   ■    ",

                " ■    ■ ",//176
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■    ■ ",
                " ■ ■■ ■ ",
                " ■■  ■■ ",
                " ■    ■ ",

                " ■    ■ ",//184
                "  ■  ■  ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "  ■  ■  ",
                " ■    ■ ",
                " ■    ■ ",

                " ■    ■ ",//192
                "  ■  ■  ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",
                "   ■■   ",

                " ■■■■■■ ",//200
                "      ■ ",
                "     ■  ",
                "    ■   ",
                "   ■    ",
                "  ■     ",
                " ■      ",
                " ■■■■■■ ",

                "        ",//208
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",


                };
            #endregion

            for (int i = posicionLetra; i < posicionLetra + 8; i++)
            {

                Console.SetCursorPosition(columna, renglon);
                Console.WriteLine(Letras[i]);
                renglon++;
            }

        }
        static int IndiceLetra(char letra)
        {

            switch (letra)
            {
                case 'A': return 0;
                case 'B': return 8;
                case 'C': return 16;
                case 'D': return 24;
                case 'E': return 32;
                case 'F': return 40;
                case 'G': return 48;
                case 'H': return 56;
                case 'I': return 64;
                case 'J': return 72;
                case 'K': return 80;
                case 'L': return 88;
                case 'M': return 96;
                case 'N': return 104;
                case 'O': return 112;
                case 'P': return 120;
                case 'Q': return 128;
                case 'R': return 136;
                case 'S': return 144;
                case 'T': return 152;
                case 'U': return 160;
                case 'V': return 168;
                case 'W': return 176;
                case 'X': return 184;
                case 'Y': return 192;
                case 'Z': return 200;
                case ' ': return 208;


                default:
                    return letra;
            }

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
        static void CreacionDeUsuario(string PATH) //AAAAAAAAAAAAAAAAAAAAAA
        {
            string usuario, contrasena, nombre, correo;
            string contrasenaB = "";
            string SEPARADOR = ",";
            bool validez;

            do
            {
                Console.WriteLine("Ingrese Usuario: ");
                usuario = Console.ReadLine();

            if ((UsuarioExiste(PATH, usuario)) == true)
            {
                Console.WriteLine("USUARIO PREEXISTENTE");
            }
            } while (UsuarioExiste(PATH, usuario)==true);
            do {

                Console.WriteLine("Ingrese Contrasena");
                contrasena = Console.ReadLine();
                Console.WriteLine("Verifique su contrasena");
                contrasenaB = Console.ReadLine();
                validez = contrasena.Equals(contrasenaB);
                if (!(contrasena.Length >= 6 && validez == true))
                {
                    Console.WriteLine("Contrasena debe ser mayor a 6 digitos , o deben coincidir");
                }
            } while (!(contrasena.Length >= 6 && validez == true));


            Console.WriteLine("Ingrese nombre real del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Correo");
            correo = Console.ReadLine();

            if (File.Exists(PATH))
            {
                GrabarUsuarioNuevo(usuario, contrasena, nombre, correo, PATH, SEPARADOR);
            }
            else
            {
                GrabarUsuarios(usuario, contrasena, nombre, correo, PATH, SEPARADOR);
            }

        }
        static void GrabarUsuarioNuevo(string usuario, string contrasena,
            string nombre, string correo,
            String PATH, String SEPARADOR)
        {

            bool variable = UsuarioExiste(PATH, usuario); // busca el usuario y regresa un booleano respecto a su existencia
            if (!variable)
            {
                Console.WriteLine("Guardando nuevo usuario en archivo");
                Console.ReadLine();
                GrabarUsuarios(usuario, contrasena, nombre, correo, PATH, SEPARADOR);
            }
            else
            {
                Console.WriteLine("Usuario preexistente.....");
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
        static public void GrabarUsuarios(string usuario, string contrasena,
        string nombre, string correo,
        String PATH, String SEPARADOR)
        {

            try
            {

                using (StreamWriter fs = File.AppendText(PATH))
                {
                    fs.Write(usuario);
                    fs.Write(SEPARADOR);
                    fs.Write(SecurePasswordHasher.Hash(contrasena)); //encrypta el password
                    fs.Write(SEPARADOR);
                    fs.Write(nombre);
                    fs.Write(SEPARADOR);
                    fs.Write(correo);
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
                        int campos = ContadorDeCampos(s);
                        int contador = 0;
                        char[] arregloCadena = s.ToArray();
                        string[] Campos = new string[campos];
                        for (int i = 0; i < arregloCadena.Length; i++)
                        {
                            if (arregloCadena[i]!=',')
                            {
                                Campos[contador] += arregloCadena[i];
                            }
                            else
                            {
                                contador++;
                            }
                        }
                        Console.WriteLine(">Usuario: "+Campos[0]+"\nNombre: "+Campos[2]);
                    }
                    //Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("--NO EXISTEN USUARIOS REGISTRADOS--");
                Console.ReadLine();
            }
            //Console.ReadLine();
        }
        static void RegistrarCalificaciones(string PATH, string CALIF)
        {
            string SEPARADOR = ",";
            string usuario="";
            string contrasena1 = "";
           
            bool validez;        //VALIDANDO
            do
            {

                Console.WriteLine("Usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Contraseña:");
                string contrasena = LeerContrasena(true);
                contrasena = contrasena1;
                validez = CredencialUsuarioValido(PATH, usuario, contrasena);
                if (!validez)
                {
                    Console.WriteLine("Confirme sus credenciales");
                }
            } while (!validez);


            bool credenciales = CredencialUsuarioValido(PATH, usuario, contrasena1);

            if (credenciales)
            {
                
              

                Console.Clear();
                Console.WriteLine("Mate:");
                string c1 = Console.ReadLine();
                Console.WriteLine("Fisica:");
                string c2 = Console.ReadLine();
                Console.WriteLine("Quimica:");
                string c3 = Console.ReadLine();
                Console.WriteLine("Logica:");
                string c4 = Console.ReadLine();


                try
                {

                    using (StreamWriter fs = File.AppendText(CALIF))
                    {
                        fs.Write(usuario);
                        fs.Write(SEPARADOR);
                        fs.Write("MATE");
                        fs.Write(c1);
                        fs.Write(SEPARADOR);
                        fs.Write("FISICA");
                        fs.Write(c2);
                        fs.Write(SEPARADOR);
                        fs.Write("QUIMICA:");
                        fs.Write(c3);
                        fs.Write(SEPARADOR);
                        fs.Write("LOGICA");
                        fs.Write(c4);
                        fs.Write(SEPARADOR);
                  
                        fs.WriteLine();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en ejecucion\n" + ex.ToString());
                }


            }
            else
            {
                Console.WriteLine("USUARIO O CONTRASENA NO CORRECTOS");
                Console.ReadLine();
                //no existe el usuario o no coinciden credenciales
            }

        }
        static public void LeerCalificaciones(string CALIF)
        {
            int cal1, cal2, cal3, cal4;
            string S = "";
            try
            {
                using (StreamReader sr = File.OpenText(CALIF))
                {
                    
                    while ((S = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(S);
                        char[] ArregloCadena = S.ToArray();
                        string[] Campos = new string[campos];
                        int contadorPalabra = 0;
                        for (int i = 0; i < ArregloCadena.Length; i++)
                        {
                            if (ArregloCadena[i] != ',')
                            {
                                Campos[contadorPalabra] += ArregloCadena[i];
                            }
                            else
                            {
                                contadorPalabra++;
                            }
                        }
                        int.TryParse(Campos[1],out cal1);
                        int.TryParse(Campos[2], out cal2);
                        int.TryParse(Campos[3], out cal3);
                        int.TryParse(Campos[4], out cal4);

                        int promedio = (cal1 + cal2 + cal3 + cal4) / 4;
                        Console.WriteLine(">Usuario: {0}, Mate: {1}, Fisica: {2}, Quimica: {3}, Logica: {4}, >>Promedio de : {5}", Campos[0],
                            Campos[1], Campos[2], Campos[3], Campos[4],promedio);
                     
                    }
                   
                }
            }
            catch (Exception)
            {
                Console.WriteLine("--NO EXISTEN USUARIOS REGISTRADOS--");
                Console.ReadLine();
            }

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
                if (cki.Key != ConsoleKey.Enter)
                {
                    password += cki.KeyChar;
                }
            } while (cki.Key != ConsoleKey.Enter);
            return password;

        }

    }

    }

