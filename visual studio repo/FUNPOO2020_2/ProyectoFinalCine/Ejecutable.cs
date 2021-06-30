using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class Ejecutable
    {
        static void Main(string[] args)
        {
            #region Campos
            int opcion;
            int inicioMenu = 1;
            int finMenu = 6;
            string menu = "1: Seleccion de pelicula \n2: Comprar boletos \n3: Comprar en dulceria \n4: Comprar en Cafe \n5: Validar Boleto\nOpción:";

            CatalogoOHistorial catCartelera = new CatalogoOHistorial();
            Pelicula[] peliculas = new Pelicula[10];
            Pelicula funcion=new Pelicula();
            ProductoDulceria[] productosDulceria;
            ProductoPlatillo[] productosCafe;
            Boleto[] historialBoletos=new Boleto[50];
            Boleto boletoCliente = new Boleto();
            #endregion

            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(menu);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opción invalida");
                } while (opcion < inicioMenu || opcion > finMenu);

                switch (opcion)
                {
                    case 1:
                        //toDo
                        int boton;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("|-------------------------------------------|");
                        Console.WriteLine("|-------------------------------------------|");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        catCartelera.MostrarCatalogo(peliculas);
                        
                        funcion=SeleccionDeCartelera(peliculas,funcion);
                        Console.WriteLine("⌐-----------------------------------¬\n" +
                                          "|                                   |\n"+
                                          "|¿Desea continuar a comprar boletos?|\n"+
                                          "|                                   |\n" +
                                          "|  [1.Si]  [Cualquier otra cosa.No] |\n" +
                                          "|                                   |\n" +
                                          "┕-----------------------------------┘\nOpción:");
                        int.TryParse(Console.ReadLine(),out boton);
                        if (boton==1)
                            CompraBoletos(funcion);

                        break;
                    case 2:
                        
                        
                        boletoCliente=CompraBoletos(funcion);
                        break;
                    case 3:
                        //toDo
                        //CompraProductos(productosDulceria,productosCafe);
                        break;
                    case 4:
                        int id;
                        bool realizo;
                        do
                        {
                            Console.WriteLine("Ingrese el numero de identificación del boleto:");
                            realizo= int.TryParse(Console.ReadLine(),out id);
                            if (realizo==false)
                                Console.WriteLine("Ingrese solo numeros");
                        } while (realizo == false);
                        Boleto temp = new Boleto();
                        boletoCliente.Id_boleto=temp.Id_boleto;
                        if (ValidacionBoletos(temp,historialBoletos))
                        {
                            Console.WriteLine("Disfrute la funcion! :D");
                        }
                        
                        break;
                }
                Console.ReadLine();
            } while (opcion != finMenu);


        }
        static Pelicula SeleccionDeCartelera(Pelicula [] pelis,Pelicula pelicula) {
            //toDo

            int opcion;
            int inicioMenu = 1;
            int finMenu = 3;
            string titulo = " _________________________________\n" +
                          "|======Selección de cartelera=====|\n" +
                          "|_________________________________|\n";
            string menu=  "|-1-:Modificaciones de admin      |\n" +
                          "|2:Seleccion de pelicula          |\n" +
                          "|                                 |\n" +
                          "|[x]3.Salir                       |\n" +
                          " _________________________________\nOpción:";
            do
            {
                do
                {
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(titulo);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(menu);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < inicioMenu || opcion > finMenu) Console.WriteLine("Opción invalida");
                } while (opcion < inicioMenu || opcion > finMenu);
                CatalogoOHistorial cartelera = new CatalogoOHistorial();
                Pelicula funcion = new Pelicula();
                switch (opcion)
                {
                    case 1:
                        MenuAdmin(pelis,pelicula,cartelera);
                        break;
                    case 2:
                        //toDo
                        
                        int numPel=0;
                        int indicePelicula=0;
                        Console.WriteLine("Ingrese el numero de la pelicula a escoger:");
                        int.TryParse(Console.ReadLine(), out numPel);
                        if (int.TryParse(Console.ReadLine(), out numPel))
                        {
                            for (int i = 0; i < pelis.Length; i++)
                            {
                                if (pelis[i].NumPelicula == numPel) { indicePelicula = i; break; }
                                else indicePelicula = -1;
                            }
                            if (indicePelicula >= 0)
                            {
                                pelis[indicePelicula].NumPelicula=funcion.NumPelicula;
                                pelis[indicePelicula].NombrePelicula = funcion.NombrePelicula;
                                pelis[indicePelicula].Sala = funcion.Sala;
                                pelis[indicePelicula].Horario = funcion.Horario;
                            }
                            else
                                Console.WriteLine("El numero de pelicula no se encontro");

                        }else
                            Console.WriteLine("Dato invalido, ingrese solo numeros");
                        break;
                    default:
                        //toDo
                        break;
                }
                if (funcion.NumPelicula>0)
                {
                    Console.WriteLine("Se lleno la funcion con exito ! :)");
                }else
                    Console.WriteLine("No se pudo llenar la funcion");
                return funcion;

            } while (opcion != finMenu);

        }
        #region MenuAdmin(sobrecargas)
        static void MenuAdmin(Pelicula[] peli,Pelicula funcion,CatalogoOHistorial cartelera)
        {

            int opcion;
            int inicioMenu = 1;
            int finMenu = 4;
            string menu = " _________________________________\n" +
                          "|======Menu de administrador======|\n" +
                          "|1:Añadir pelicula                |\n" +
                          "|2:Modificar pelicula             |\n" +
                          "|3:Eliminar pelicula              |\n" +
                          "|                                 |\n" +
                          "|                                 |\n" +
                          "|[x]4.Salir                       |\n" +
                          " _________________________________\nOpción:";
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
                        //1:Añadir pelicula 
                        cartelera.ActualizarCatalogo(peli);

                        break;
                    case 2:
                        //2:Modificar pelicula
                        int numPel = 0;
                        Console.WriteLine("Ingrese el numero de la pelicula a la cual quiere modificar");
                        numPel = int.Parse(Console.ReadLine());
                        int indicePelicula = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            if (peli[i].NumPelicula == numPel) { indicePelicula = i; break; }
                            else indicePelicula = -1;
                        }
                       
                        if (indicePelicula>=0)
                        {
                            peli[indicePelicula].NombrePelicula = funcion.NombrePelicula;
                            peli[indicePelicula].Horario = funcion.Horario;
                            peli[indicePelicula].Sala = funcion.Sala;
                            bool sePudo= cartelera.ActualizarCatalogo(funcion);
                            if (sePudo)
                            {
                                Console.WriteLine("Pelicula actualizada!");
                            }
                            else
                            {
                                Console.WriteLine("No se pudo actualizar la pelicula, revise sus valores :(");
                            }
                            
                        }



                        break;
                    case 3:
                        //3:Eliminar pelicula
                        int numPel1 = 0;
                        Console.WriteLine("Ingrese el numero de la pelicula a la cual quiere eliminar");
                        numPel1 = int.Parse(Console.ReadLine());
                        int indicePelicula1 = 0;

                        for (int i = 0; i < 10; i++)
                        {
                            if (peli[i].NumPelicula == numPel1) { indicePelicula1 = i; break; }
                            else indicePelicula1 = -1;
                        }
                        if (indicePelicula1 > 0)
                        {
                            peli[indicePelicula1].NombrePelicula = "";
                            peli[indicePelicula1].NumPelicula = 0;
                            peli[indicePelicula1].Sala = 0;
                            peli[indicePelicula1].Horario = "";
                            peli[indicePelicula1].AsientosDisponibles = 0;
                            Console.WriteLine("Pelicula eliminada con exito");
                        }
                        else
                        {
                            Console.WriteLine("El numero de pelicula seleccionado no se encontro");
                        }

                        break;
                    default:
                        break;
                }
            } while (opcion != finMenu);


        }
        static void MenuAdmin(ProductoDulceria[] dulceria) { }
        static void MenuAdmin(ProductoPlatillo[] cafe) { }
        #endregion

        static Boleto CompraBoletos(Pelicula funcion) {
            //toDo
            Boleto boleto = new Boleto();
            int cantidadBoletos=0;
            int cantidadBoletosNino=0;
            float total=0.00f;
            bool realizo;
            if (funcion.AsientosDisponibles<25)
            {
                do
                {
                    Console.WriteLine("¿Cuántos boletos de adulto desea comprar");
                    realizo = int.TryParse(Console.ReadLine(), out cantidadBoletos);
                    if (realizo == true)
                    {
                        total = cantidadBoletos * 75.5f;
                        Console.WriteLine("¿Desea comprar boletos de niño?");
                        if (Console.ReadLine().ToUpper() == "SI")
                        {
                            Console.WriteLine("¿Cuántos boletos de niño desea comprar");
                            int.TryParse(Console.ReadLine(), out cantidadBoletosNino);
                            total = total + (cantidadBoletosNino * 55.5f);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese solo numeros porfavor");
                    }
                } while (realizo == false);
                string descuento;
                float descuentOU = 0.00f;
                if (cantidadBoletos>0 || cantidadBoletosNino>0)
                {
                    Console.WriteLine("Su total es de $ " + total + " mxn, ¿Desea agregar algún descuento?\n[Escriba solo si para continuar]");
                    if (Console.ReadLine().ToUpper() == "SI")
                    {
                        
                        //VET5,SENIOR10,STUDENT10
                        Console.WriteLine("Escriba el codigo de descuento a seleccionar");
                        descuento = Console.ReadLine().ToUpper();
                        if (descuento == "SENIOR10" || descuento == "STUDENT10")
                        {
                            float desc = total * 0.10f;
                            total = total - desc;
                            boleto.Descuento = 0.10f;
                        }
                        else if (descuento == "VET5")
                        {
                            float desc = total * 0.05f;
                            total = total - desc;
                            boleto.Descuento = 0.05f;
                        }
                        else
                        {
                            Console.WriteLine("No tenemos registrado ese código de descuento");
                        }
                    }
                    Console.WriteLine("Su nuevo total es de $ "+total+"\n¿Desea confirmar su compra?\n[1]Si  [Cualquier otra cosa]No");
                    int opcion = 0;
                    if (opcion==1)
                    {
                        total = boleto.Total;
                        descuentOU=boleto.Descuento;
                        boleto.Id_boleto = 123456;
                        Console.WriteLine("Gracias por su compra!Su número de boleto es "+boleto.Id_boleto+
                                          "\nPelicula a ver:"+boleto.Funcion.NombrePelicula+
                                          "\nDescuentos:"+descuentOU+"\nTotal[ $"+total+" mxn]\n--Disfrute la función!!--");
                        return boleto;
                    }
                }
   
            }
            else
            {
                Console.WriteLine("No hay asientos suficientes, seleccione otra pelicula");
            }
            return boleto;
        }
        #region CompraProductos(sobrecargas)
        static void CompraProductos(ProductoDulceria[] productosDulceria, CatalogoOHistorial inventarioDulceria)
        {
            inventarioDulceria.MostrarCatalogo(productosDulceria);

        }
        static void CompraProductos(ProductoPlatillo[] productosPlatillo, CatalogoOHistorial inventarioPlatillo)
        {
            inventarioPlatillo.MostrarCatalogo(productosPlatillo);
        }
        #endregion

        static bool ValidacionBoletos(Boleto funcion,Boleto [] boletos) {
            int indice;
            bool sePudo = false;
            for (int i = 0; i < boletos.Length; i++)
            {
                if (boletos[i].Id_boleto == funcion.Id_boleto)
                {
                    sePudo = true;
                }
                else
                    sePudo = false;
            }
            return sePudo;
        
        }


    }
}
