using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace ExamenCap4Recuperacion
{
    class Program
    {
        static void Main()
        {
            cadenaTextoDesvanece("Daniel");

            string path = "c:\\temp\\usuario.txt";
            string usuario = "";
            string contrasena;

            if (File.Exists(path))
            {
                //verificar usuario
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                contrasena = LeerContrasena(true, "^");

                bool credenciales = CredencialesDeUsuarioValidas(path, usuario, contrasena);

                if (credenciales)
                {
                    //existe usuario y coinciden las credenciales
                    Menu(path, usuario);
                }
                else
                {
                    //No coincide las credenciales
                    Console.ReadLine();
                }
            }
            else
            {
                Menu(path, usuario);
            }
        }

        static void Menu(string PATH, string usuario)
        {
            const string PATHCAL = "c:\\temp\\calificaciones.txt";
            string menu = "1. Imprimir usuario\n" +
                "2. Registrar usuario\n" +
                "3. Registrar calificaciones\n" +
                "4. Mostrar calificaciones\n" +
                "5. Ordenar registros de usuario por nombre de usuario\n" +
                "6. Ordenar registros de calificaciones por nombre de usuario\n" +
                "7. Borrar registros de usuarios\n" +
                "8. Borrar registros de calificaciones \n" +
                "9. Salir";

            int opcionInt, salida = 9;
            do
            {
                Console.Clear();
                if (usuario != "")
                {
                    Console.WriteLine("Bienvenido: " + usuario);
                }
                Console.WriteLine(menu);
                do
                {
                    Console.Write("\nOpcion: ");
                    int.TryParse(Console.ReadLine(), out opcionInt);
                } while (!(opcionInt > 0 && opcionInt < salida + 1));

                switch (opcionInt)
                {
                    case 1:
                        Console.WriteLine("\n");
                        LeerRegistros(PATH);
                        Console.ReadLine();
                        break;
                    case 2:
                        RegistrarUsuario(PATH);
                        Console.ReadLine();
                        break;
                    case 3:
                        RegistrarCalificaciones(PATH, PATHCAL);
                        break;
                    case 4:
                        ImprimirCalificaciones(PATH, PATHCAL);
                        break;
                    case 5:
                        OrdenarUsuarios(0, PATH);
                        break;
                    case 6:
                        OrdenarRegistros(0, PATHCAL);
                        break;
                    case 7:
                        BorrarRegistros(PATH);
                        break;
                    case 8:
                        BorrarRegistros(PATHCAL);
                        break;
                }

            } while (opcionInt != salida);
        }
        static int ContadorRegistros(string PATH)
        {
            int contador = 0;
            string s = "";
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        contador++;
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("No hay registro de calificaciones");
            }
            return contador;
        }


        static void ImprimirCalificaciones(string PATH, string PATHCAL)
        {
            string s;

            double promedio;

            string[,] matrizCalificaciones = new string[ContadorRegistros(PATHCAL), 5];
            string[,] matrizUsuarios = new string[ContadorRegistros(PATH), 4];

            try
            {
                using (StreamReader sr = File.OpenText(PATHCAL))
                {
                    int indiceRenglonCalificacion = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        promedio = 0;

                        int calificacion;
                        String[] Campos = ObtenerCampos(s);

                        matrizCalificaciones[indiceRenglonCalificacion, 0] = Campos[0];
                        matrizCalificaciones[indiceRenglonCalificacion, 1] = Campos[1];
                        matrizCalificaciones[indiceRenglonCalificacion, 2] = Campos[2];
                        matrizCalificaciones[indiceRenglonCalificacion, 3] = Campos[3];
                        matrizCalificaciones[indiceRenglonCalificacion, 4] = Campos[4];
                        indiceRenglonCalificacion++;

                        Console.WriteLine("\nCalificacion de " + Campos[0]);
                        Console.Write("Matematicas ");
                        Console.WriteLine(Campos[1]);
                        int.TryParse(Campos[1], out calificacion);
                        promedio += calificacion;

                        Console.Write("Espanol ");
                        Console.WriteLine(Campos[2]);
                        int.TryParse(Campos[2], out calificacion);
                        promedio += calificacion;

                        Console.Write("Historia ");
                        Console.WriteLine(Campos[3]);
                        int.TryParse(Campos[3], out calificacion);
                        promedio += calificacion;

                        Console.Write("Fisica ");
                        Console.WriteLine(Campos[4]);
                        int.TryParse(Campos[4], out calificacion);
                        promedio += calificacion;
                        promedio = promedio / 4;

                        Console.WriteLine("El promedio es: " + promedio);



                        // mostrar los usuarios registrados que no tienen calificacion
                    }

                }

                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonUsuarios = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        String[] Campos = ObtenerCampos(s);

                        matrizUsuarios[indiceRenglonUsuarios, 0] = Campos[0];
                        matrizUsuarios[indiceRenglonUsuarios, 1] = Campos[1];
                        matrizUsuarios[indiceRenglonUsuarios, 2] = Campos[2];
                        matrizUsuarios[indiceRenglonUsuarios, 3] = Campos[3];
                        indiceRenglonUsuarios++;
                    }

                }
                bool esta;
                Console.WriteLine("\nUsuarios sin calificacion");
                for (int i = 0; i < matrizUsuarios.GetLength(0); i++)
                {//usuarios
                    esta = false;
                    for (int j = 0; j < matrizCalificaciones.GetLength(0); j++)
                    {//calificaciones
                        if (matrizUsuarios[i, 0] == matrizCalificaciones[j, 0])
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (!esta)
                    {
                        Console.WriteLine("Usuario: " + matrizUsuarios[i, 0] + " Nombre: " + matrizUsuarios[i, 2]);
                    }
                }
            }
            catch (Exception)
            {

            }

            Console.ReadLine();
        }

        static void RegistrarCalificaciones(string PATH, string PATHCAL)
        {
            if (!LeerRegistros(PATH))
            {
                Console.WriteLine("No hay registros");
                return;
            }
            MenuCal(PATH, PATHCAL);
        }

        static void MenuCal(string PATH, string PATHCAL)
        {
            string menu = "1. Registrar calificaciones\n" +
                "2. Cancelar y regresar al menu princial";
            int opcion;
            bool existeUsuario = false;
            do
            {
                Console.WriteLine(menu);
                do
                {
                    Console.Write("Opcion: ");
                    int.TryParse(Console.ReadLine(), out opcion);

                } while (!(opcion > 0 && opcion < 3));

                if (opcion == 1)
                {
                    do
                    {


                        Console.WriteLine("Ingrese el nombre del usuario para registrar calificaciones");
                        Console.Write("Nombre de usuario: ");
                        string usuario = Console.ReadLine();
                        existeUsuario = UsuarioExist(PATH, usuario);

                        if (existeUsuario)
                        {
                            string[] Campos = SolicitarCalificaciones(usuario, PATHCAL);
                            GrabarRegistro(Campos, ",", PATHCAL);
                        }
                        else
                        {
                            Console.WriteLine("Usuario invalido, ingrese de nuevo.");
                        }
                    } while (!existeUsuario);
                }

            } while (opcion != 2);
        }

        static string[] SolicitarCalificaciones(string usuario, string PATHCAL)
        {
            string[] Campos = new string[5];
            Campos[0] = usuario;

            Console.WriteLine("Calificaciones");

            Console.Write("Matematicas: ");
            Campos[1] = Console.ReadLine();
            Console.Write("Espanol: ");
            Campos[2] = Console.ReadLine();
            Console.Write("Historia: ");
            Campos[3] = Console.ReadLine();
            Console.Write("Fisica: ");
            Campos[4] = Console.ReadLine();
            return Campos;
        }

        static void RegistrarUsuario(string path)
        {
            const string SEPARADOR = ",";
            string[] Campos = new string[4];
            Console.Write("Usuario: ");
            Campos[0] = Console.ReadLine();
            Console.Write("Contrasena: ");
            Campos[1] = SecurePasswordHasher.Hash(LeerContrasena(true, "^"));
            Console.WriteLine();
            Console.Write("Nombre del usuario: ");
            Campos[2] = Console.ReadLine();
            Console.Write("Correo: ");
            Campos[3] = Console.ReadLine();

            if (File.Exists(path))
            {
                GrabarUsuarioValido(Campos, SEPARADOR, path);
            }
            else
            {
                GrabarRegistro(Campos, SEPARADOR, path);
            }
        }

        static string PedirContrasenna()
        {
            string pwd, pwdR;
            do
            {
                Console.Write("Contraseña: ");
                pwd = LeerContrasena(true, "^");
                Console.WriteLine();
                Console.Write("Repetir contraseña: ");
                pwdR = LeerContrasena(true, "^");
                Console.WriteLine();
                if (pwd != pwdR || pwd.Length < 6)
                {
                    Console.WriteLine("");
                    if (pwd != pwdR)
                        Console.Write("Las contraseñas coinciden ");
                    Console.WriteLine();
                    if (pwd.Length < 6)
                        Console.Write("Longitud de la contraseña debe ser por lo menos 6 caracteres");
                    Console.WriteLine();
                }
            } while (pwd != pwdR || pwd.Length < 6);
            return pwd;
        }

        static void GrabarUsuarioValido(string[] Campos, string SEPARADOR, string path)
        {

            if (!UsuarioExist(path, Campos[0]))
            {
                Console.WriteLine("Usuario guardado");
                GrabarRegistro(Campos, SEPARADOR, path);
            }
            else
            {
                Console.WriteLine("Usuario preExistente");
            }
        }

        private static bool UsuarioExist(string path, string nuevoUsuario)
        {
            #region Verificacion de usuario
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(linea);
                        char[] ArregloCadena = linea.ToArray();
                        //  Console.WriteLine(linea + " \nTiene {0} campos", campos);
                        #region separacion de campos
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
                        #endregion

                        #region verificacion
                        for (int i = 0; i < contadorPalabra + 1; i++)
                        {
                            //    Console.WriteLine(Campos[i]);
                        }

                        if (Campos[0] == nuevoUsuario)
                        {
                            return true;
                            //Console.WriteLine("existe");
                            //break;
                        }
                        else
                        {
                            //Console.WriteLine("No existe");
                        }

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
            return false;
        }

        private static bool CredencialesDeUsuarioValidas(string path, string usuario, string contrasena)
        {
            #region Verificacion de usuario
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        String[] Campos = ObtenerCampos(linea);

                        if (Campos[0] == usuario)
                        {
                            //encontro usuario
                            if (SecurePasswordHasher.Verify(contrasena, Campos[1]))
                            {
                                return true;
                            }
                            Console.WriteLine("Contraseña invalida");
                            return false;
                        }

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nError en la verificacion");
            }
            #endregion
            Console.WriteLine("\nUsuario No registrado");
            return false;
        }

        public static void GrabarRegistro(string[] Campos, string SEPARADOR, string PATH)
        {
            try
            {
                //escritura de archivo
                using (StreamWriter sw = File.AppendText(PATH))
                {
                    for (int i = 0; i < Campos.Length; i++)
                    {
                        sw.Write(Campos[i]);
                        if (i != Campos.Length - 1)
                            sw.Write(SEPARADOR);
                    }
                    sw.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static bool LeerRegistros(string path)
        {
            bool hayRegistros = false;

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        hayRegistros = true;
                        string[] Campos = ObtenerCampos(linea);
                        Console.WriteLine("Usuario: {0} \t\tNombre completo: {1}", Campos[0], Campos[2]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No hay usuarios registrados");
                Console.ReadLine();
            }
            return hayRegistros;
        }

        static int ContadorDeCampos(string texto)
        {
            char[] AC = texto.ToArray();
            int contador = 0;
            for (int i = 1; i < AC.Length; i++)
            {
                if (AC[i] == ',' && AC[i - 1] != ',')
                {
                    contador++;
                }
            }
            if (AC[AC.Length - 1] != ',')
            {
                contador++;
            }
            return contador;
        }

        static string[] ObtenerCampos(string linea)
        {
            int campos = ContadorDeCampos(linea);
            char[] ArregloCadena = linea.ToArray();
            //  Console.WriteLine(linea + " \nTiene {0} campos", campos);
            #region separacion de campos
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
            #endregion

            for (int i = 0; i < contadorPalabra + 1; i++)
            {
                //    Console.WriteLine(Campos[i]);
            }
            return Campos;
        }

        static void cadenaTextoDesvanece(string texto)
        {
            int columna = 0;

            char[] arrayBanner = texto.ToUpper().ToCharArray();

            Console.Clear();

            do
            {
                int columnaProceso = columna;
                for (int i = 0; i < arrayBanner.Length; i++)
                {
                    if (columnaProceso < Console.WindowWidth - 12)
                    {
                        impresion(columnaProceso, 0, arrayBanner[i]);
                        columnaProceso += 8;
                    }
                }
                Thread.Sleep(10);
                columna++;
            } while (columna < 117);//efecto de borrado de letras
            //} while (columna < (Console.WindowWidth - 3) - arrayBanner.Length * 8);

            #region rebote
            //Console.Clear();
            //do
            //{
            //    int columnaProceso = columna;
            //    for (int i = 0; i < arrayBanner.Length; i++)
            //    {
            //        if (columnaProceso < (Console.WindowWidth - 8))
            //        {
            //            impresion(columnaProceso, 0, arrayBanner[i]);
            //            columnaProceso += 8;
            //        }
            //    }
            //    Thread.Sleep(10);
            //    columna--;
            //} while (columna != 0);
            //Thread.Sleep(50);
            #endregion

            Console.Clear();

        }

        static void impresion(int columna, int renglon, char letra)
        {
            string[] letras = new string[]
{
                        "   ¦¦   ",//posicion 0
                        "  ¦  ¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",

                        " ¦¦¦¦¦  ",//posicion 8
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦  ",

                        "  ¦¦¦¦  ",//posicion 16
                        " ¦    ¦ ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦    ¦ ",
                        "  ¦¦¦¦  ",

                        " ¦¦¦¦¦  ",//posicion 24
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦  ",

                        " ¦¦¦¦¦  ",//posicion 32
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦¦¦¦¦  ",
                        " ¦      ",
                        " ¦      ",
                        " ¦¦¦¦¦¦ ",

                        " ¦¦¦¦¦¦ ",//posicion 40
                        " ¦      ",
                        " ¦      ",
                        " ¦¦¦¦   ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",

                        "  ¦¦¦¦¦ ",//posicion 48
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦  ¦¦¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        "  ¦¦¦¦¦ ",

                        " ¦    ¦ ",//posicion 56
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",

                        " ¦¦¦¦¦¦ ",//posicion 64
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        " ¦¦¦¦¦¦ ",

                        "  ¦¦¦¦¦ ",//posicion 72
                        "    ¦   ",
                        "    ¦   ",
                        "    ¦   ",
                        "    ¦   ",
                        " ¦  ¦   ",
                        " ¦  ¦   ",
                        "  ¦¦    ",

                        " ¦    ¦ ",//posicion 80
                        " ¦   ¦  ",
                        " ¦  ¦   ",
                        " ¦¦¦    ",
                        " ¦ ¦    ",
                        " ¦  ¦   ",
                        " ¦   ¦  ",
                        " ¦    ¦ ",

                        " ¦      ",//88
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",
                        " ¦¦¦¦¦¦ ",

                        " ¦    ¦ ",//96
                        " ¦¦  ¦¦ ",
                        " ¦ ¦¦ ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",

                        " ¦    ¦ ",//104
                        " ¦    ¦ ",
                        " ¦¦   ¦ ",
                        " ¦ ¦  ¦ ",
                        " ¦  ¦ ¦ ",
                        " ¦   ¦¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",

                        "   ¦¦   ",//112
                        "  ¦  ¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        "  ¦  ¦  ",
                        "   ¦¦   ",

                        " ¦¦¦¦   ",//120
                        " ¦   ¦  ",
                        " ¦    ¦ ",
                        " ¦   ¦  ",
                        " ¦¦¦¦   ",
                        " ¦      ",
                        " ¦      ",
                        " ¦      ",

                        "   ¦¦   ",//128
                        "  ¦  ¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦  ¦¦  ",
                        "  ¦  ¦¦ ",
                        "   ¦  ¦ ",

                        " ¦¦¦¦   ",//136
                        " ¦   ¦  ",
                        " ¦    ¦ ",
                        " ¦¦¦¦¦  ",
                        " ¦ ¦    ",
                        " ¦  ¦   ",
                        " ¦   ¦  ",
                        " ¦    ¦ ",

                        "  ¦¦¦¦  ",//144
                        " ¦    ¦ ",
                        " ¦      ",
                        "  ¦¦¦   ",
                        "     ¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        "  ¦¦¦¦  ",

                        " ¦¦¦¦¦¦ ",//152
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",

                        " ¦    ¦ ",//160
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        "  ¦¦¦¦  ",

                        " ¦    ¦ ",//168
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦   ¦  ",
                        "  ¦ ¦   ",
                        "   ¦    ",

                        " ¦    ¦ ",//176
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",
                        " ¦ ¦¦ ¦ ",
                        " ¦¦  ¦¦ ",
                        " ¦    ¦ ",

                        " ¦    ¦ ",//184
                        "  ¦  ¦  ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "  ¦  ¦  ",
                        " ¦    ¦ ",
                        " ¦    ¦ ",

                        " ¦    ¦ ",//192
                        "  ¦  ¦  ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",
                        "   ¦¦   ",

                        " ¦¦¦¦¦¦ ",//200
                        "      ¦ ",
                        "     ¦  ",
                        "    ¦   ",
                        "   ¦    ",
                        "  ¦     ",
                        " ¦      ",
                        " ¦¦¦¦¦¦ ",

                        "        ",//208
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
};

            int posicionDeLetra = indiceLetra(letra);
            Console.SetCursorPosition(columna, renglon);

            for (int i = posicionDeLetra; i < posicionDeLetra + 8; i++)
            {
                Console.SetCursorPosition(columna, renglon);
                Console.WriteLine(letras[i]);
                renglon++;
            }

        }

        static int indiceLetra(char letra)
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
                default: return 208;
            }

        }

        static string LeerContrasena(bool eco, string simbolo)
        {
            int renglon = Console.CursorTop;
            int columna = Console.CursorLeft;
            ConsoleKeyInfo cki;
            string password = "";

            do
            {
                Console.SetCursorPosition(columna, renglon);
                cki = Console.ReadKey(true);
                if (eco)
                {//con eco
                    if (cki.Key != ConsoleKey.Backspace)
                    {
                        if (cki.Key != ConsoleKey.Enter)
                        {
                            Console.Write(simbolo);
                            columna++;
                            password += cki.KeyChar;
                        }
                    }
                    else
                    {
                        if (password.Length != 0)
                        {
                            columna--;
                            Console.SetCursorPosition(columna, renglon);
                            Console.Write(" ");
                            password = password.Remove(password.Length - 1, 1);
                        }
                    }
                    //Console.SetCursorPosition(10, 10);
                    //Console.WriteLine(password + "            ");
                }
                else
                {//sin eco
                    if (cki.Key != ConsoleKey.Backspace)
                    {
                        if (cki.Key != ConsoleKey.Enter)
                        {
                            password += cki.KeyChar;
                        }
                    }
                    else
                    {
                        if (password.Length != 0)
                        {
                            password = password.Remove(password.Length - 1, 1);
                        }
                    }
                    //Console.SetCursorPosition(10, 10);
                    //Console.WriteLine(password + "            ");
                }

            } while (cki.Key != ConsoleKey.Enter);

            return password;
        }


        static void OrdenarCalif(int indiceCampo, string PATH)
        {
            string s;
            string SEPARADOR = ",";
            //double promedio;
            
            string[,] matrizCalificaciones = new string[ContadorRegistros(PATH), 5];

            try
            {

                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonCalificacion = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        //promedio = 0;

                        //int calificacion;
                        String[] Campos = ObtenerCampos(s);

                        matrizCalificaciones[indiceRenglonCalificacion, 0] = Campos[0];
                        matrizCalificaciones[indiceRenglonCalificacion, 1] = Campos[1];
                        matrizCalificaciones[indiceRenglonCalificacion, 2] = Campos[2];
                        matrizCalificaciones[indiceRenglonCalificacion, 3] = Campos[3];
                        matrizCalificaciones[indiceRenglonCalificacion, 4] = Campos[4];
                        indiceRenglonCalificacion++;


                        // mostrar los usuarios registrados que no tienen calificacion
                    }

                    string[,] temp = new string[1, 5];
                    for (int a = 1; a < ContadorRegistros(PATH); a++)
                        for (int b = ContadorRegistros(PATH) - 1; b>= a; b--)
                        {
                            if (matrizCalificaciones[b - 1, indiceCampo].CompareTo(matrizCalificaciones[b, indiceCampo]) > 0)
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    temp[1, i] = matrizCalificaciones[b - 1, i];
                                }

                                for (int i = 0; i < 5; i++)
                                {
                                    matrizCalificaciones[b - 1, i] = matrizCalificaciones[b, i];
                                }

                                for (int i = 0; i < 5; i++)
                                {
                                    matrizCalificaciones[b, i] = temp[1, i];
                                }
                            }

                        }
                }
                BorrarRegistros(PATH);
                using (StreamWriter sw = File.AppendText(PATH))
                {
                    for (int i = 0; i < matrizCalificaciones.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrizCalificaciones.GetLength(1); j++)
                        {
                            sw.Write(matrizCalificaciones[i,j]);
                            sw.Write(SEPARADOR);
                        }                        
                        sw.WriteLine(); 
                    }
                    
                }
            }

            catch (Exception)
            {

            }

            Console.ReadLine();
        }

        static void OrdenarUsuarios(int indiceCampo, string PATH)
        {
            int contadorRegis =  ContadorRegistros(PATH);
            string s;
            string SEPARADOR = ",";
            //double promedio;

            string[,] matrizUsuarios = new string[ContadorRegistros(PATH), 4];

            try
            {

                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonUsuarios = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        //promedio = 0;

                        //int calificacion;
                        String[] Campos = ObtenerCampos(s);

                        matrizUsuarios[indiceRenglonUsuarios, 0] = Campos[0];
                        matrizUsuarios[indiceRenglonUsuarios, 1] = Campos[1];
                        matrizUsuarios[indiceRenglonUsuarios, 2] = Campos[2];
                        matrizUsuarios[indiceRenglonUsuarios, 3] = Campos[3];
                        indiceRenglonUsuarios++;


                        // mostrar los usuarios registrados que no tienen calificacion
                    }
                    int c = contadorRegis - 1;
                    string[,] temp = new string[1, 4];
                    for (int a = 1; a < contadorRegis; a++)
                    {
                        for (int b = c ; b >= a; b--)
                        {
                            if ((matrizUsuarios[(b - 1), indiceCampo].CompareTo(matrizUsuarios[b, indiceCampo])) > 0)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    temp[1, i] = matrizUsuarios[b - 1, i];
                                }

                                for (int i = 0; i < 4; i++)
                                {
                                    matrizUsuarios[b - 1, i] = matrizUsuarios[b, i];
                                }

                                for (int i = 0; i < 4; i++)
                                {
                                    matrizUsuarios[b, i] = temp[1, i];
                                }
                            }

                        }
                    }
                }
                BorrarRegistros(PATH);
                using (StreamWriter sw = File.AppendText(PATH))
                {
                    for (int i = 0; i < matrizUsuarios.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrizUsuarios.GetLength(1); j++)
                        {
                            sw.Write(matrizUsuarios[i, j]);
                            sw.Write(SEPARADOR);
                        }
                        sw.WriteLine();
                    }
                    
                }
            }

            catch (Exception)
            {

            }

            Console.ReadLine();
        }

    

        static void BorrarRegistros(string PATH)
        {
            if (File.Exists(PATH))
            {
                try
                {
                    File.Delete(PATH);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
    }
}
