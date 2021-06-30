using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ExCap4_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            string miNombre = "JOTO";
            #region Banner
            char[] arregloCadena = miNombre.ToArray();
            int columna = 0;
            int renglon = 0;
            int retraso = 30;
            //DESVANECIENTE
            ////-----PASO 0
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
            //DE REBOTE
            //rebotarBanner(arregloCadena);
            #endregion

            string PATH = "c:\\temp\\usuario.txt";
            string usuario = "";
            string contrasena = "";

            string[,] Matriz = ObtenerMatriz(PATH);

            if (File.Exists(PATH))
            {
                Console.WriteLine("Usuario:");
                usuario = Console.ReadLine();
                //
                //contrasena = SecurePasswordHasher.Hash(PedirConstrasena());
                Console.WriteLine("Contrasena:");
                contrasena = LeerContrasena(true, "^");

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
                Console.WriteLine("nO HAY REGISTROS");
                Menu(PATH);
            }
            Console.ReadLine();

        }

        #region Menu
        static void Menu(string PATH)
        {
            string CALIF = "c:\\temp\\calificaciones.txt";
            const string SEPARADOR = ",";
            string menu =     "-------------------------------------------------------\n" +
                              "|1.Registrar usuario                                  |\n" +
                              "|2.Registrar calificaciones                           |\n" +
                              "|3.Mostrar usuarios                                   |\n" +
                              "|4.Mostrar calificaciones(y usuarios sin calificacion)|\n" +
                              "|5.Ordenar Usuarios por nombre de usuario             |\n" +
                              "|6.Ordenar Calificaciones por nombre de usuario       |\n" +
                              "|6.Borrar Usuarios                                    |\n"+
                              "|8.Borrar Calificaciones                              |\n"+
                              "|                                                     |\n"+
                              "|9.[!]SALIR DEL PROGRAMA[!]                           |\n" +
                              "-------------------------------------------------------";
            int opcionInt;
            int SALIDA = 9;
            do
            {
                Console.Clear();
                Console.WriteLine(menu);
                do
                {
                    Console.WriteLine("OPCION");
                    int.TryParse(Console.ReadLine(), out opcionInt);
                } while (!(opcionInt > 0 && opcionInt < SALIDA+1));
                switch (opcionInt)
                {
                    case 1:
                        CreacionDeUsuario(PATH);
                        break;
                    case 2:
                        RegistrarCalificaciones(PATH, CALIF);
                        break;
                    case 3:
                        LeerRegistros(PATH);
                        Console.ReadLine(); break;
                    case 4:
                        ImprimirCalificaciones(CALIF, PATH);
                        break;
                    case 5:
                        Console.WriteLine("Original");
                        string[,] matriz = ObtenerMatriz(PATH);
                        ImprimirMatriz(matriz,"\t|\t");
                        OrdenarUsuarios(0, PATH);
                        break;
                    case 6:
                        Console.WriteLine("Original");
                        string[,] matricita = ObtenerMatriz(PATH);
                        ImprimirMatriz(matricita, "\t|\t");
                        OrdenarRegistros(0, CALIF);
                        break;
                    case 7:
                        BorrarRegistros(PATH);
                        break;
                    case 8:
                        BorrarRegistros(CALIF);
                        break;
                }
            } while (opcionInt != SALIDA);
        }
        static void MenuCal(string PATH, string CALIF)
        {
            int opcioon = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("USUARIOS: ");
                LeerRegistros(PATH);
                bool existe = false;
                string menu = "-------------------------------------------\n" +
                "|1.Registrar calificaciones               |\n" +
                "|2.Cancelar  y regresar                   |\n" +
                "-------------------------------------------\n";
                Console.WriteLine(menu);
                do
                {
                    Console.WriteLine("Opcion: ");
                    int.TryParse(Console.ReadLine(), out opcioon);
                } while (!(opcioon > 0 && opcioon < 3));
                if (opcioon == 1)
                {
                    do
                    {
                        Console.WriteLine("--Ingrese el usuario para registrar calificaciones--");
                        Console.Write("Nombre de usuario");
                        string usuario = Console.ReadLine();
                        existe = UsuarioExiste(PATH, usuario);
                        if (existe)
                        {
                            string[] Campos = SolicitarCalificaciones(usuario, CALIF);
                            GrabarRegistro(Campos, ",", CALIF);
                        }
                        else
                        {
                            Console.WriteLine("Usuario invalido, ingrese de nuevo");
                        }
                        //RegistrarCalificaciones(PATH, CALIF);
                    } while (!existe);
                }
            } while (opcioon != 2);
        }
        #endregion
      
        #region Registros en Matriz
        static string[] SolicitarCalificaciones(string usuario, string CALIF)
        {
            string[] Campos = new string[5];
            Console.Clear();
            Campos[0] = usuario;
            Console.WriteLine("Mate:");
            Campos[1] = Console.ReadLine();
            Console.WriteLine("Fisica:");
            Campos[2] = Console.ReadLine();
            Console.WriteLine("Quimica:");
            Campos[3] = Console.ReadLine();
            Console.WriteLine("Logica:");
            Campos[4] = Console.ReadLine();
            return Campos;
        }

        static bool LeerRegistros(string PATH)
        {
            bool hayRegistros = false;
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        hayRegistros = true;
                        string[] Campos = obtenerCampos(s);
                        Console.WriteLine(">Usuario: {0} , Nombre Completo: {1}", Campos[0], Campos[2]);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("No hay usuaros registrados");
                Console.ReadLine();
            }
            return hayRegistros;
        }

        static void ImprimirCalificaciones(string CALIF, string PATH) //Ordenar Calificaciones
        {
            string s;

            double promedio;

            string[,] matrizCalificaciones = new string[ContadorDeRegistros(CALIF), 5];
            string[,] matrizUsuarios = new string[ContadorDeRegistros(PATH), 4];

            try
            {
                using (StreamReader sr = File.OpenText(CALIF))
                {
                    int indiceRenglonCalificacion = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        promedio = 0;

                        int calificacion;
                        String[] Campos = obtenerCampos(s);

                        matrizCalificaciones[indiceRenglonCalificacion, 0] = Campos[0];
                        matrizCalificaciones[indiceRenglonCalificacion, 1] = Campos[1];
                        matrizCalificaciones[indiceRenglonCalificacion, 2] = Campos[2];
                        matrizCalificaciones[indiceRenglonCalificacion, 3] = Campos[3];
                        matrizCalificaciones[indiceRenglonCalificacion, 4] = Campos[4];
                        indiceRenglonCalificacion++;

                        Console.WriteLine("\n------Calificaciones de: " + Campos[0]);
                        Console.Write("-Mate");
                        Console.WriteLine(Campos[1]);
                        int.TryParse(Campos[1], out calificacion);
                        promedio += calificacion;
                        Console.Write("-Quimica");
                        Console.WriteLine(Campos[2]);
                        int.TryParse(Campos[2], out calificacion);
                        promedio += calificacion;
                        Console.Write("-Fisica");
                        Console.WriteLine(Campos[3]);
                        int.TryParse(Campos[3], out calificacion);
                        promedio += calificacion;
                        Console.Write("-Logica ");
                        Console.WriteLine(Campos[4]);
                        int.TryParse(Campos[4], out calificacion);
                        promedio += calificacion;
                        promedio = promedio / 4;
                        Console.WriteLine(">El promedio es: " + promedio);

                    }//while

                }//using

                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonUsuarios = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        String[] Campos = obtenerCampos(s);

                        matrizUsuarios[indiceRenglonUsuarios, 0] = Campos[0];
                        matrizUsuarios[indiceRenglonUsuarios, 1] = Campos[1];
                        matrizUsuarios[indiceRenglonUsuarios, 2] = Campos[2];
                        matrizUsuarios[indiceRenglonUsuarios, 3] = Campos[3];
                        indiceRenglonUsuarios++;
                    }

                }//using
                bool esta;
                Console.WriteLine("\nUsuarios SIN calificacion: ");
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
                        Console.WriteLine(">Usuario: " + matrizUsuarios[i, 0] + " Nombre: " + matrizUsuarios[i, 2]);
                    }
                }
            }
            catch (Exception)
            {

            }

            Console.ReadLine();
        }
        static void OrdenarCalificaciones(int indiceCampo, string PATH)
        {
            string s;
            string SEPARADOR = ",";
            string[,] matrizCalificaciones = new string[ContadorDeRegistros(PATH), 5];

            try
            {

                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonCalificacion = 0;
                    while ((s = sr.ReadLine()) != null)
                    {

                        String[] Campos = obtenerCampos(s);

                        matrizCalificaciones[indiceRenglonCalificacion, 0] = Campos[0];
                        matrizCalificaciones[indiceRenglonCalificacion, 1] = Campos[1];
                        matrizCalificaciones[indiceRenglonCalificacion, 2] = Campos[2];
                        matrizCalificaciones[indiceRenglonCalificacion, 3] = Campos[3];
                        matrizCalificaciones[indiceRenglonCalificacion, 4] = Campos[4];
                        indiceRenglonCalificacion++;
                    }

                    string[,] temp = new string[1, 5];
                    for (int a = 1; a < ContadorDeRegistros(PATH); a++)
                        for (int b = ContadorDeRegistros(PATH) - 1; b >= a; b--)
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
                            sw.Write(matrizCalificaciones[i, j]);
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
            int contadorRegis = ContadorDeRegistros(PATH);
            string s;
            string SEPARADOR = ",";
            string[,] matrizUsuarios = new string[ContadorDeRegistros(PATH), 4];

            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    int indiceRenglonUsuarios = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        String[] Campos = obtenerCampos(s);

                        matrizUsuarios[indiceRenglonUsuarios, 0] = Campos[0];
                        matrizUsuarios[indiceRenglonUsuarios, 1] = Campos[1];
                        matrizUsuarios[indiceRenglonUsuarios, 2] = Campos[2];
                        matrizUsuarios[indiceRenglonUsuarios, 3] = Campos[3];
                        indiceRenglonUsuarios++;
                    }
                    int c = contadorRegis - 1;
                    string[,] temp = new string[1, 4];
                    for (int a = 1; a < contadorRegis; a++)
                    {
                        for (int b = c; b >= a; b--)
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
                Console.WriteLine("ERROR EN EL METODO: OrdenarUsuarios ");
            }
            Console.ReadLine();
        }//Ordenar usuarios

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
                    Console.WriteLine("NO SE BORRARON LOS REGISTROS,ERROR EN METODO:Borrar registros" +
                        "");
                    return;
                }
            }
        }

        static void OrdenarRegistros(int indiceCampo, string PATH)
        {
            if (PATH == "c:\\temp\\calificaciones.txt")
            {
                OrdenarCalificaciones(indiceCampo, PATH);
            }
            if (PATH == "c:\\temp\\usuario.txt")
            {
                OrdenarUsuarios(indiceCampo, PATH);
            }
        }

        static int ContadorDeRegistros(string PATH)
        {

            string s;
            int contador = 0;
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

                throw;
            }
            return contador;
        }

        static public void GrabarRegistro(string[] Campos, string SEPARADOR, string PATH)
        {

            try
            {

                using (StreamWriter fs = File.AppendText(PATH))
                {//crear o sobreescribir
                    for (int i = 0; i < Campos.Length; i++)
                    {
                        fs.Write(Campos[i]);
                        if (i != Campos.Length - 1)
                        {
                            fs.Write(SEPARADOR);
                        }
                    }
                    fs.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ejecucion\n" + ex.ToString());
            }
        }

        static void RegistrarCalificaciones(string PATH, string CALIF)
        {
            if (!LeerRegistros(PATH))
            {
                Console.WriteLine("No hay usuarios registrados");
                return;
            }
            MenuCal(PATH, CALIF);
        }
        #region Obtener,Imprimir y Ordenar
        static string[,] ObtenerMatriz(string PATH)
        {
            int[] dimension = ContadorDeRegistros2(PATH);
            int renglones = dimension[0];
            int columnas = dimension[1];
            string[,] MatrizDeArchivo = new string[renglones, columnas];
            string s = "";
            int contar = 0;
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    contar= 0;
                    while ((s=sr.ReadLine())!=null)
                    {
                        string[] Campos = obtenerCampos(s);
                        for (int i = 0; i < columnas; i++)
                        {
                            MatrizDeArchivo[contar,i]= Campos[i];
                        }
                        contar++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN METODO: ObtenerMatriz");
            }

            return MatrizDeArchivo;

        }
        static int[] ContadorDeRegistros2(string PATH) {

            int contador = 0;
            string s = "";
            int campos = 0;
            bool primeravez = true;
            int[] longitud = new int[2];
            try
            {
                using (StreamReader sr=File.OpenText(PATH))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (primeravez)
                        {
                            campos = ContadorDeCampos(s);
                            primeravez = false;
                        }
                        contador++;
                    }
                    longitud[0] = contador;
                    longitud[1] = campos;                }
            }
            catch (Exception)
            {
                Console.WriteLine("error en metodo ContadorDeRegistros2");
            }
            return longitud;
        }  //obtiene longitudes 
        static void ImprimirMatriz(string[,]matrizString,string SEPARADOR)
        {
            for (int i = 0; i < matrizString.GetLength(0); i++)
            {
                for (int j = 0; j < matrizString.GetLength(1); j++)
                {
                    Console.Write(matrizString[i,j]);
                    if (j!=matrizString.GetLength(1)-1)
                    {
                        Console.Write(SEPARADOR);
                    }
                    Console.WriteLine();
                }
            }

        }
       static string[,] BubbleMatrizCreciente(string[,]matriz,int columna)
        {
            for (int i = 0; i <matriz.GetLength(0); i++)
            {
                for (int j = 0; j <matriz.GetLength(0)-i-1; j++)
                {
                    if (matriz[j,columna].CompareTo(matriz[j+1,columna])>0)
                    {
                        matriz = SwapRegistrosMatriz(j, j + 1, matriz);
                    }
                }
            }
            return matriz;


        }
        static string[,] BubbleMatrizDecreciente(string[,] matriz, int columna)
        {
            for (int i = 0; i < matriz.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matriz.GetLength(0) - i - 1; j++)
                {
                    if (matriz[j, columna].CompareTo(matriz[j + 1, columna]) < 0)
                    {
                        matriz = SwapRegistrosMatriz(j, j + 1, matriz);
                    }
                }
            }
            return matriz;


        }
        static string[,] SwapRegistrosMatriz(int registroA, int registroB, string[,] matriz)
        {
            string[] registroTemp = new string[matriz.GetLength(1)];
            for (int z = 0; z < matriz.GetLength(1); z++)
                registroTemp[z] = matriz[registroA, z];

            for (int z = 0; z < matriz.GetLength(1); z++)
                matriz[registroA, z] = matriz[registroB, z];

            for (int z = 0; z < matriz.GetLength(1); z++)
                matriz[registroB, z] = registroTemp[z];

            return matriz;
        }
        #endregion
        #endregion

        #region Validaciones
        static bool CredencialUsuarioValido(string PATH, string usuario, string contrasena)
        {
            try
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "";
                    String[] Campos;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Campos = obtenerCampos(s);

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

        static void GrabarRegistroValido(string[] Campos, string SEPARADOR, string PATH)
        {
            // busca el usuario y regresa un booleano respecto a su existencia
            if (!UsuarioExiste(PATH, Campos[0]))
            {
                Console.WriteLine("Guardando nuevo usuario en archivo");

                GrabarRegistro(Campos, SEPARADOR, PATH);
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
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        int campos = ContadorDeCampos(linea);
                        char[] ArregloCadena = linea.ToArray();
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

                        }

                        if (Campos[0] == nuevoUsuario)
                        {
                            return true;

                        }
                        else
                        {

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }
        #endregion

        #region Lectura de usuarios/contrasenas
        static void CreacionDeUsuario(string PATH)
        {
            string[] Campos = new string[4];
            string SEPARADOR = ",";
            Console.WriteLine("Ingrese nombre del usuario");
            Campos[0] = Console.ReadLine();
            //pide contrasena
            Campos[1] = SecurePasswordHasher.Hash(PedirConstrasena());
            Console.WriteLine("Ingrese nombre real del usuario");
            Campos[2] = Console.ReadLine();
            Console.WriteLine("Ingrese Correo");
            Campos[3] = Console.ReadLine();
            if (File.Exists(PATH))
            {
                //GrabarUsuarioNuevo(usuario, contrasena, nombre, correo,PATH, SEPARADOR);
                GrabarRegistroValido(Campos, SEPARADOR, PATH);
            }
            else
            {
                //GrabarUsuarios(usuario, contrasena, nombre, correo, PATH, SEPARADOR);
                GrabarRegistro(Campos, SEPARADOR, PATH);
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
                        string[] Campos = obtenerCampos(s);
                        Console.WriteLine(">Usuario: {0},Nombre Completo: {2}", Campos[0], Campos[2]);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("--NO EXISTEN USUARIOS REGISTRADOS--");

            }
            Console.ReadLine();
        }
        static string PedirConstrasena()
        {
            string pwd, pwdR;
            do
            {
                Console.WriteLine("Ingrese Contrasena");
                pwd = LeerContrasena(true, "^");
                Console.WriteLine("Verifique contrasena:");
                pwdR = LeerContrasena(true, "^");
                if (pwd != pwdR || pwd.Length < 6)
                {
                    if (pwd != pwdR)
                    {
                        Console.WriteLine("Las contrasenas no coinciden");
                    }
                    if (pwd.Length < 6)
                    {
                        Console.WriteLine("Contrasena muy corta, ingrese al menos 6 caracteres");
                    }
                }
            } while (pwd != pwdR || pwd.Length < 6);
            return pwd;
        }
        static string LeerContrasena(bool eco, string simbolo)
        {
            ConsoleKeyInfo cki;
            String password = "";
            do
            {
                cki = Console.ReadKey(true);
                if (eco)
                {
                    Console.Write(simbolo);
                }
                if (cki.Key != ConsoleKey.Enter)
                {
                    password += cki.KeyChar;
                }
            } while (cki.Key != ConsoleKey.Enter);
            return password;

        }

        #endregion

        #region campos
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
        static string[] obtenerCampos(string s)
        {

            int campos = ContadorDeCampos(s);
            char[] ArregloCadena = s.ToArray();
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


            return Campos;


        }
        #endregion

        
        #region mETODOS DEL BANNER
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
        public static void rebotarBanner(char[] arregloOracion)
        {
            int columna = 0;
            int renglon = 0;
            bool valido = true;
            int columna2 = arregloOracion.Length * 8;
            do
            {
                Thread.Sleep(30);
                impresionFrase(columna, renglon, arregloOracion);
                columna++;
                columna2++;
                if (columna2 > 119)
                {
                    valido = false;
                }
            } while (valido);
            valido = true;
            do
            {
                Thread.Sleep(30);
                impresionFrase(columna, renglon, arregloOracion);
                columna--;
                if (columna == 0)
                {
                    valido = false;
                }
            } while (valido);
            columna = 0;
        }
        public static void impresionFrase(int columna, int renglon, char[] arregloOracion)
        {

            for (int i = 0; i < arregloOracion.Length; i++)
            {
                impresion(columna + 8 * i, renglon, arregloOracion[i]);

            }

        }
        #endregion


    }

}


