using System;
using System.IO;
using System.Text;

namespace _7_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region OPCION 1
            string path = "c:\\temp\\myTest.txt";
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("si existe");
                    File.Delete(path);
                }
                else
                {
                    Console.WriteLine("No existe");
                }
                #region ESCRITURA DE ARCHIVO
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Hola pipol");

                    //array byte,offset,count
                    fs.Write(info, 0, info.Length);
                }

                #endregion
                #region LECTURA DE ARCHIVO
                using (StreamReader sr=File.OpenText(path))
                {
                    string linea = "";
                    while ((linea=sr.ReadLine())!=null)
                    {
                        Console.WriteLine(linea);//impresion de lineas leidas
                    }
                }
                #endregion
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            #endregion
            #region OPCION 2
            //string path = "c:\\temp\\myTest.txt";

            try
            {
                //verifica la existencia del archivo
                if (File.Exists(path))
                {//si existe lo elimina
                    Console.WriteLine("si existe");
                    File.Delete(path);
                }

                //escritura de archivo
                //using (FileStream fs = File.Create(path))
                //{
                //    byte[] info = new UTF8Encoding(true).GetBytes("hola mundo");

                //        //byte[], offset, count 
                //    fs.Write(info, 0, info.Length);//esta linea guarda
                //}



                //escritura de archivo
                using (StreamWriter sw = File.CreateText(path))
                {
                    //byte[] info = new UTF8Encoding(true).GetBytes("hola mundo");

                    //byte[], offset, count 
                    sw.WriteLine("hola mundo");
                    sw.WriteLine("como estas?");
                    sw.WriteLine("hola mundo");
                    sw.WriteLine("como estas?");
                    sw.WriteLine("hola mundo");
                    sw.WriteLine("como estas?");
                    sw.WriteLine("hola mundo");
                    sw.WriteLine("como estas?");
                    sw.WriteLine("hola mundo");
                    sw.WriteLine("como estas?");
                }


                //lectura de archivo
                using (StreamReader sr = File.OpenText(path))
                {
                    string linea = "";

                    //barrido del archivo
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();

            #endregion
        }
    }
}
