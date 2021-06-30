using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace _001_Practicas.Practica_1
{
 class MenuExcepciones
    {
        

        static void Main(string[] args)
        {

            int opcion;
            int inicioMenu = 1;
            int finMenu = 11;
            string menu = "==Menu de Excepciones==\n1: IndexOutOfRangeException"+
                                                  " \n2:NullReferenceException" +
                                                  "\n3: OverflowException"+
                                                  "\n4:InvalidOperationException" +
                                                  "\n5:ArgumentNullException"+
                                                  "\n6:NotImplementedException" +
                                                  "\n7:ArgumentException"+
                                                  "\n8:DirectoryNotFoundException" +
                                                  "\n9:UnauthorizedAccessException" +
                                                  "\n10:SEHException" +
                                                  "\n[!]11:Salir[!]"
                                                  + "\nOpción:";
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write(menu);
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opción invalida");
                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        
                        #region Caso 1
                        Console.WriteLine("Ejemplo de error IndexOutOfRangeException\nJerarquía del error:Object->Exception->SystemException->IndexOutOfRangeException");
                        
string caso1="\nint[] arregloX = new int[10];\nfor (int i = 0; i < arregloX.Length; ++i){\nfor (int i = 0; i < arregloX.Length; ++i){\narregloX[i] = i + 1;\n}\ntr{\nfor (int i = 0; i < arregloX.Length + 1; i++){\nConsole.WriteLine(''Posición {0} del arreglo'', arregloX[i]);\n}\n}\ncatch (IndexOutOfRangeException e){\nConsole.WriteLine(''Excepción:\n {0}'', e.Message);\n}";
                        MostrarCodigo(caso1);
                        int[] arregloX = new int[10];
                        for (int i = 0; i < arregloX.Length; ++i)
                        {
                            arregloX[i] = i + 1;
                        }
                        Console.WriteLine("El siguiente error es provocado por intentar acceder a una posición fuera del rango , en este caso se crea un arreglo arbitrario de 10 posiciones para provocarlo accediendo al onceavo índice");
                        try
                        {
                            for (int i = 0; i < arregloX.Length + 1; i++)
                            {
                                Console.WriteLine("Posición {0} del arreglo", arregloX[i]);
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine("Excepción:\n {0}", e.Message);
                        }
                        Console.ReadLine();
                        #endregion
                        break;
                    case 2:
                        
                        #region Caso 2
                        Console.WriteLine("Ejemplo de error NullReferenceException \nJerarquía del error:Object->Exception->SystemException->NullReferenceException");
                        string caso2="\nArrayList lista = null;\ntry{\nlista.Add(''Hola Mundo'');\nConsole.WriteLine(lista);} \ncatch (NullReferenceException e){\nConsole.WriteLine(''Error:{0}'',e.Message); \n}";
                        MostrarCodigo(caso2);
                        ArrayList lista = null;
                        try
                        {
                            lista.Add("Hola Mundo");
                            Console.WriteLine(lista);
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine("Error:{0}",e.Message);
                            
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 3:
                        
                        #region Caso 3
                        Console.WriteLine("Ejemplo de error OverflowException \nJerarquía del error:Object->Exception->SystemException->ArithmeticException->OverflowException");
                        string caso3="\ntry{\nint[] arreglo = new int[int.MaxValue+int.Parse(''1'')];\n}\ncatch (OverflowException e){\nConsole.WriteLine(''E'',e.Message);\n }";
                        MostrarCodigo(caso3);
                        try
                        {
                          int[] arreglo = new int[int.MaxValue+int.Parse("1")];
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Error:{0} ",e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion

                    case 4:
                        
                        #region Caso 4
                        Console.WriteLine("Ejemplo de error InvalidOperationException \nJerarquía de excepción:Object->Exception->SystemException->InvalidOperationException");
                      
                        string caso4="try{\nvar numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7 }; \nforeach (var numero in numeros){\nint agregados = (int)Math.Pow(numero, 3);\nnumeros.Add(agregados);\n }\n}\ncatch (InvalidOperationException e){\n Console.WriteLine('Error:{0}', e.Message);\n}";
                        MostrarCodigo(caso4);
                        try
                        {
                            var numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
                            foreach (var numero in numeros)
                            {
                                int agregados = (int)Math.Pow(numero, 3);
                                numeros.Add(agregados);
                            }
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine("Error:{0}", e.Message);
                        }
                        Console.ReadLine();
                        #endregion
                        break;
                    case 5:
                        
                        #region Caso 5
                        Console.WriteLine("Ejemplo de error ArgumentNullException \nJerarquía de excepción:Object->Exception->SystemException->ArgumentNullException");
                        string caso5="\ntry {\nstring variable = null;\nint entero = int.Parse(variable);\n}\ncatch (ArgumentNullException e){\nConsole.WriteLine('Error:{0}', e.Message);\n}";
                        MostrarCodigo(caso5);
                        try
                        {
                            string variable = null;
                            int entero = int.Parse(variable);
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine("Error:{0}",e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 6:
                        
                        #region Caso 6
                        Console.WriteLine("Ejemplo de error NotImplementedException\nJerarquía de excepción:Object->Exception->SystemException->NotImplementedException");
                        string caso6="\ntry{\nthrow new NotImplementedException();\n} \ncatch (NotImplementedException e){\nConsole.WriteLine(''Excepción:{0}'',e.Message);\n}";
                        MostrarCodigo(caso6);
                        try
                        {
                            throw new NotImplementedException();
                        }
                        catch (NotImplementedException e)
                        {
                            Console.WriteLine("Excepción:{0}",e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 7:

                        #region Caso 7
                        Console.WriteLine("Ejemplo de excepción ArgumentException \nJerarquía de excepción:Object->Exception->SystemException->ArgumentException");
                        string caso7=" \ntry{\nConsole.WriteLine(''Ingrese un saludo(No poner nada resultará en la excepción):'');\nvar entrada=Console.ReadLine();\nvar saludo = LeerSaludo(entrada);\nConsole.WriteLine(saludo);\n}\ncatch (ArgumentException e){\nConsole.WriteLine(''Excepción:{0}'',e.Message);\n}";
                        MostrarCodigo(caso7);
                        try
                        {
                            Console.WriteLine("Ingrese un saludo(No poner nada resultará en la excepción):");
                            var entrada = Console.ReadLine();
                            var saludo = LeerSaludo(entrada);
                            Console.WriteLine(saludo);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("Excepción:{0}", e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 8:
                        
                        #region Caso 8
                        Console.WriteLine("Ejemplo de excepción DirectoryNotFoundException \nJerarquía de excepción:Object->Exception->SystemException->IOException->DirectoryNotFoundException");
                        string caso8=" \ntry{\nstring direccion =''c:\\carpetaInexistente'';\nDirectory.SetCurrentDirectory(direccion);\n}\ncatch (DirectoryNotFoundException e){\nConsole.WriteLine(''Excepción: {0}'',e.Message);\n}";
                        MostrarCodigo(caso8);
                        try
                        {
                            string direccion ="c:\\carpetaInexistente";
                            Directory.SetCurrentDirectory(direccion);
                        }
                        catch (DirectoryNotFoundException e)
                        {
                            Console.WriteLine("Excepción: {0}",e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 9:
                        
                        #region Caso 9
                        Console.WriteLine("Ejemplo de excepción UnathorizedAccessException \nJerarquía de excepción:Object->Exception->SystemException->UnauthorizedAccessException");
                        string caso9 = "\ntry{\nstring path = @''c: \\Users\\leder'';\nFileStream sr = File.OpenWrite(path);\n}\ncatch (UnauthorizedAccessException e){\nConsole.WriteLine(''Excepción: { 0}'' '',e.Message);\n}";
                        MostrarCodigo(caso9);
                        try
                        {
                            string path = @"c:\Users\leder";
                            FileStream sr = File.OpenWrite(path);
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            Console.WriteLine("Excepción: {0}", e.Message);
                        }
                        Console.ReadLine();
                        break;
                    #endregion
                    case 10:

                        #region Caso 10
                        Console.WriteLine("Ejemplo de excepción SEHException \nJerarquía de excepción:Object->Exception->SystemException->->ExternalException->SEHException");
                        const string V = "c:\\";
                        string caso10 = "\ntry{\nIntPtr modo = Marshal.StringToHGlobalAnsi(V);]\nvar acceso = FileAccess.Read;\nFileStream fs=new FileStream(modo,acceso);\nbyte[] arreglo = new byte[10];\nfs.Read(arreglo,1,10);\n}\ncatch (SEHException e){\n Console.WriteLine(''Excepción: {0}'', e.Message);\n}";
                        MostrarCodigo(caso10);
                        try
                        {
                            IntPtr modo = Marshal.StringToHGlobalAnsi(V);
                            var acceso = FileAccess.Read;
                            FileStream fs = new FileStream(modo, acceso);
                            byte[] arreglo = new byte[10];
                            fs.Read(arreglo, 1, 10);
                        }
                        catch (SEHException e)
                        {
                            Console.WriteLine("Excepción: {0}", e.Message);
                        }
                        Console.ReadLine();
                        break;

                    #endregion

                    default:
                        //toDo
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != finMenu);
            Console.ReadLine();
        }
        public static string LeerSaludo(string entrada)
        {
            if (entrada=="")
            {
                throw new ArgumentException();
            }
            return "OK";
        }

        public static void MostrarCodigo(string texto)
        {
            Console.WriteLine(texto);
        }

   

    }

  
  
}
