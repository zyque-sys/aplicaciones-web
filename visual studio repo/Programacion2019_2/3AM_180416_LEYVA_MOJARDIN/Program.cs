using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AM_180416_LEYVA_MOJARDIN
{
    class Program
    {
        static void Main(string[] args) {
            float respuesta = 0.0f;
            char inciso;
            bool valido;
           
            //PREGUNTAS

          do {
                Console.WriteLine("================EXAMEN DE REPOSTERIA====================\nIngresa el inciso correcto a,b, o c \n[!]Al terminar el cuestionario puedes presionar X para salir, de lo contrario se iniciara de nuevo[!]");
                Console.ReadLine();

                do
            {
                Console.Clear();
                Console.WriteLine("1.Cuantas estrellas tiene el restaurante principal de Gordon Ramsay \na)Ninguna \nb)2 estrellas \nc)4 estrellas");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
            if (inciso =='A' || inciso == 'a')
            {
                respuesta = respuesta + 3.33f;
            }
            if (inciso == 'B' || inciso == 'b')
            {
                respuesta = respuesta + 6.66f;
            }
            if (inciso == 'C' || inciso == 'c')
            {
                respuesta = respuesta + 9.99f;
            }

            do {
                Console.Clear();
                Console.WriteLine("2.Que grasa para cocinar lleva el pan frances \na)Manteca \nb)Mantequilla \nc)Aceite vegetal");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("3.Que son los smores \na)Sanwiches de galleta con nieve dentro \nb)Pastelitos \nc)Sandwiches de galleta con malvavisco y chocolate dentro");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("4.Para que sirve ponerle una pizca de sal a un postre \na)No tiene efecto \nb)Aminora su dulzura \nc)Resalta su dulzura");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("5.Cual es el truco mas usado para evitar que un pastel de zanahoria se reseque \na)El doble de aceite a la cantidad de harina \nb)Usar zanahoria enlatada \nc)Ponerle 250g de piña enlatada");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("6.Nombre alternativo del pastel relleno \na)Creme brulee \nb)Molten \nc)Pastel volcan");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("7.De que esta hecha la corteza de un creme brulee \na)Glaseado horneado \nb)Pan \nc)Azucar cristalizada");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("8.Como se cristaliza la corteza de un creme brulee \na)Horneandose \nb)Baño maria \nc)Con un soplete");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("9.Que significa que un chocolate este temper \na)Acabado matte \nb)Quebradizo\nc)Que este brilloso ");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }
                do {
                Console.Clear();
                Console.WriteLine("10.El merengue de turron se debe hornear \na)Es opcional \nb)No \nc)si");
                valido = char.TryParse(Console.ReadLine(), out inciso);
                if (!valido)
                {
                    Console.WriteLine("ERROR: Ingrese solo un inciso a,b o c");
                }
            } while (!valido);
                if (inciso == 'A' || inciso == 'a')
                {
                    respuesta = respuesta + 3.33f;
                }
                if (inciso == 'B' || inciso == 'b')
                {
                    respuesta = respuesta + 6.66f;
                }
                if (inciso == 'C' || inciso == 'c')
                {
                    respuesta = respuesta + 9.99f;
                }



                //RESPUESTAS


                if (respuesta>=50 && respuesta<75)
            {

                Console.WriteLine("Tu resultado, " + respuesta + " ,es insuficiente");
            }
            else if (respuesta>=75 &&respuesta<90)
            {

                Console.WriteLine("Tu resultado, " + respuesta + " ,es regular");
            }
            else if (respuesta>90 && respuesta<95)
            {

                Console.WriteLine("Tu resultado, " + respuesta + " ,es bueno");
            }
            if (respuesta>95)
            {

                Console.WriteLine("Tu resultado, " + respuesta + " ,es sobresaliente");

            }
                else { 
                
                    Console.WriteLine("Tu resultado esta fuera de nivel" 
                        );
                }

        }while(inciso!='x' || inciso!='X');
            Console.ReadLine();
        }
    }
}
