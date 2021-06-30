using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class CatalogoOHistorial
    {


        #region Metodos
        /// <summary>
        /// Para todas las peliculas existentes
        /// </summary>
        /// <param name="pelis">Arreglo de objetos Pelicula</param>
        public void MostrarCatalogo(Pelicula[] pelis)
        {

            for (int i = 0; i < 10; i++)
            {
                pelis[i] = new Pelicula();
                if (pelis[i].NumPelicula != 0)
                {
                    Console.WriteLine("{0}.-Nombre de la Pelicula: {1}", pelis[i].NumPelicula, pelis[i].NombrePelicula);
                    Console.WriteLine("{0}.-Sala: {1}", pelis[i].NumPelicula, pelis[i].Sala);
                    Console.WriteLine("{0}.-Horario: {1}", pelis[i].NumPelicula, pelis[i].Horario);
                    Console.WriteLine("{0}.-Asientos disponibles: {1}", pelis[i].NumPelicula, pelis[i].AsientosDisponibles);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Cartelera vacia :(");
                    break;
                }
            }


        }
        /// <summary>
        /// Para mostrar info basica de 1 pelicula
        /// </summary>
        /// <param name="pelis">objeto pelicula</param>
        public void MostrarCatalogo(Pelicula pelis)
        {
            if (pelis.NumPelicula != 0)
            {
                Console.WriteLine("{0}.-Nombre de la Pelicula: {1}", pelis.NumPelicula, pelis.NombrePelicula);
                Console.WriteLine("{0}.-Sala: {1}", pelis.NumPelicula, pelis.Sala);
                Console.WriteLine("{0}.-Horario: {1}", pelis.NumPelicula, pelis.Horario);
                Console.WriteLine("\n");
            }
            else
                Console.WriteLine("Error :(");
        }
        /// <summary>
        /// para mostrar boletos existentes
        /// </summary>
        /// <param name="boletos">arreglo de objetos tipo Boleto</param>
        public void MostrarCatalogo(Boleto[] boletos)
        {
            //toDo
            for (int i = 0; i < boletos.Length; i++)
            {
                if (boletos[i].Id_boleto != 0)
                {
                    Console.WriteLine("Codigo del boleto: {1}", boletos[i].Id_boleto);
                    MostrarCatalogo(boletos[i].Funcion);
                    if (boletos[i].Descuento > 0.0f)
                    {
                        Console.WriteLine("Descuento: {1}", boletos[i].Descuento);
                    }
                    Console.WriteLine("_________\nTotal: {1}", boletos[i].Total);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("No hay boletos registrados");
                    break;
                }
            }

        }
        /// <summary>
        /// Muestra platillos disponibles
        /// </summary>
        /// <param name="producto">Arreglo de objetos tipo ProductoPlatillo</param>
        public void MostrarCatalogo(ProductoPlatillo[] producto)
        {
            //toDo
            for (int i = 0; i < producto.Length; i++)
            {
                if (producto[i].CantidadPlatillo != 0)
                {
                    Console.WriteLine(".-Platillo: {0}", producto[i].Platillo);
                    Console.WriteLine(".-Precio: $ {0}", producto[i].Precio);
                    switch (producto[i].Platillo.ToUpper())
                    {
                        case "CREPA":
                            Console.WriteLine(".-Ingredientes:\n\t -Masa\n\t -Mermelada\n\t -Queso crema");
                            break;
                        case "FRAPPE":
                            Console.WriteLine(".-Ingredientes:\n\t -Leche\n\t -Hielo\n\t -Cafe");
                            break;
                        case "CROISSANT":
                            Console.WriteLine(".-Ingredientes:\n\t -Cuerno\n\t -Jamon\n\t -Queso");
                            break;
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Menu no disponible D:");
                    break;
                }
            }

        }
        public void MostrarCatalogo(ProductoDulceria[] producto)
        {
            for (int i = 0; i < producto.Length; i++)
            {
                if (producto[i].Cantidad != 0)
                {
                    Console.WriteLine(".-Snack: {1}", producto[i].Articulo);
                    Console.WriteLine(".-Precio: $ {1}", producto[i].Precio);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Menu no disponible D:");
                    break;
                }
            }
          
        }
        //toDo vvv
        #region ActualizarCatalogo()
        public bool ActualizarCatalogo(Pelicula pelicula)
        { 
          //int numPel = 0;
          //Console.WriteLine("Ingrese el numero de la pelicula a la cual quiere modificar");
          //numPel = int.Parse(Console.ReadLine());
          //int indicePelicula = 0;

            //    if (pelicula.NumPelicula != numPel)
            //{
            //    indicePelicula = -1;
            //    sePudo = false;
            //}

            bool sePudo=false;

            if (pelicula.NumPelicula > 0)
            {
                Console.WriteLine("Seleccione el numero correspondiente:\n1.Cambiar nombre\n2.Cambiar Sala\n3.Cambiar Horario");
                int alt;
                int.TryParse(Console.ReadLine(), out alt);
                switch (alt)
                {
                    case 1:
                        Console.WriteLine("Nombre actual de la Pelicula: {0}", pelicula.NombrePelicula);
                        Console.WriteLine("Nombre nuevo: ");
                        pelicula.NombrePelicula = Console.ReadLine();
                        sePudo = true;
                        break;
                    case 2:
                        Console.WriteLine("Sala actual de la Pelicula: {0}", pelicula.Sala);
                        Console.WriteLine("Sala nueva: ");
                        pelicula.Sala = int.Parse(Console.ReadLine());
                        sePudo = true;
                        break;
                    case 3:
                        Console.WriteLine("Horario actual de la Pelicula: {0}", pelicula.Horario);
                        Console.WriteLine("Horario nueva: ");
                        pelicula.Horario = Console.ReadLine();
                        sePudo = true;
                        break;
                    default:
                        sePudo = false;
                        break;
                }

            }
            return sePudo;
        }
        public bool ActualizarCatalogo(Pelicula[] pelis)
        { //toDo
            int sala;
            bool realizo;
            string quiere = "";
            bool sePudo=false;

            for (int i = 0; (i < 10) && quiere != "NO"; i++)
            {
                pelis[i] = new Pelicula();
                do
                {
                    Console.WriteLine("¿Desea crear una nueva película(Maximo de 10 en cartelera)?\nResponda solo no para salir");
                    quiere = Console.ReadLine().ToUpper();
                    Console.WriteLine(quiere);
                    if ((pelis[i].NumPelicula >= 0 && pelis[i].NumPelicula < 10) && quiere != "NO")
                    {
                        pelis[i].NumPelicula = i + 1;
                        Console.WriteLine("Ingrese nombre de peliscula: ");
                        pelis[i].NombrePelicula = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Ingrese sala de peliscula: ");
                            realizo = int.TryParse(Console.ReadLine(), out sala);
                            if (realizo)
                            {
                                sala = pelis[i].Sala;
                                Console.WriteLine("Ingrese horario");
                                pelis[i].Horario = Console.ReadLine();
                                pelis[i].AsientosDisponibles = 25;
                                sePudo = true;
                            }
                            else
                                Console.WriteLine("Ingrese solo numeros ");
                        } while (!realizo);

                    }
                    else if (quiere == "NO")
                        sePudo = false;
                    else
                    {
                        Console.WriteLine("No se puede añadir pelicula, verifique que no este llena la cartelera");
                        sePudo = false;

                    }
                } while (quiere != "NO");
               
            }
            return sePudo;

        }
        public bool ActualizarCatalogo(Boleto boleto)
        { //toDo
            return true;
        }
        public bool ActualizarCatalogo(Boleto[] boletos)
        { //toDo
            return true;
        }
        public bool ActualizarCatalogo(ProductoPlatillo platillo)
        { //toDo
            return true;
        }
        public bool ActualizarCatalogo(ProductoPlatillo[] platillos)
        { //toDo
            return true;
        }
        public bool ActualizarCatalogo(ProductoDulceria articulo)
        { //toDo
            return true;
        }
        public bool ActualizarCatalogo(ProductoDulceria[] articulo)
        { //toDo
            return true;
        }
        #endregion
        //toDovvv
        #region EliminarDelCatalogo()
        public bool EliminarDelCatalogo(Pelicula pelicula)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(Pelicula[] pelis)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(Boleto boleto)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(Boleto[] boletos)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(ProductoPlatillo platillo)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(ProductoPlatillo[] platillos)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(ProductoDulceria articulo)
        { //toDo
            return true;
        }
        public bool EliminarDelCatalogo(ProductoDulceria[] articulo)
        { //toDo
            return true;
        }
        #endregion

        #endregion
    }
}
