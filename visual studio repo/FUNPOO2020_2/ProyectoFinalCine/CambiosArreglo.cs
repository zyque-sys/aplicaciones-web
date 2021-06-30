using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class CambiosArreglo
    {
        #region Campos
        Pelicula[] pelicula;
        Boleto[] boleto;
        ProductoPlatillo[] platillo;
        ProductoDulceria[] dulce;
        private int max;
        private int top;
        #endregion
        #region Propiedades
        public int Top { get => top; set => top = value; }
        public int Max { get => this.max; set => this.max = value; }
        internal Pelicula[] Pelicula { get => Pelicula; set => Pelicula = value; }
        internal Boleto[] Boleto { get => Boleto; set => Boleto = value; }
        internal ProductoPlatillo[] Platillo { get => Platillo; set => Platillo = value; }
        internal ProductoDulceria[] Dulce { get => Dulce; set => Dulce = value; }
        #endregion
        #region Metodos:Pelicula
     
        public bool EliminarPelicula(Pelicula peli)
        {
            if (!(EstaVacio()))
            {
                for (int i = 0; i < this.top; i++)//iterador para desplazarce por las posiones del arreglo
                {
                    if (this.pelicula[i].NumPelicula == peli.NumPelicula)// compara si el dato es del mismo valor al dato que buscamos a eliminar
                    {// fijamos el valor de i
                        for (int y = i; y < this.top - 1; y++)//preevee un intercambio de valores
                            this.pelicula[y] = this.pelicula[y + 1];
                        this.top--;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public bool EstaLleno()
        {
            if (this.top == this.max)
                return true;
            return false;
        }

        /// <summary>
        /// Metodo que permite controlar el critico EstaVacio para evitar
        /// realizar la operacion de eliminar o buscar cuando no existen elementos
        /// </summary>
        /// <returns></returns>
        public bool EstaVacio()
        {
            if (this.top == 0)
                return true;
            return false;
        }
        /// <summary>
        /// Metodo para agregar un valor en el arreglo
        /// </summary>
        /// <param name="dato">valor a agregar en el arreglo</param>
        /// <returns>True en caso de que la operacion se realice con exito; False en caso contrario.</returns>
        public bool Insertar(Pelicula peli) // Método para insertar un dato en el arreglo desordenado        
        {
            if (!EstaLleno()) // Si no está lleno ...        
            {
                for (int i = 0; i <= top - 1; i++)
                    if (pelicula[i] == peli)  // Comparación para detectar si el dato ya existe                     
                        return (false);  // No se insertó el dato (duplicado)       
                pelicula[top] = peli;  // Se inserta el dato en el arreglo      
                top++;  // Se incrementa la cantidad de datos del arreglo          
                return (true);  // Dato insertado con exito         
            }
            else
                return (false); // No se insertó el dato (arreglo lleno)      
        }
        public bool ModificarPelicula(int id)
        {
            //toDo
            return true;
        }
        #endregion
        #region Metodos:Boleto
        public bool ModificarBoleto(int id)
        {
            //toDo
            return true;
        }
        public bool EliminarBoleto(Boleto bole)
        {
            if (!(BoletoVacio()))
            {
                for (int i = 0; i < this.top; i++)//iterador para desplazarce por las posiones del arreglo
                {
                    if (this.boleto[i].Id_boleto == bole.Id_boleto)// compara si el dato es del mismo valor al dato que buscamos a eliminar
                    {// fijamos el valor de i
                        for (int y = i; y < this.top - 1; y++)//preevee un intercambio de valores
                            this.boleto[y] = this.boleto[y + 1];
                        this.top--;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public bool BoletoLleno()
        {
            if (this.top == this.max)
                return true;
            return false;
        }

        /// <summary>
        /// Metodo que permite controlar el critico EstaVacio para evitar
        /// realizar la operacion de eliminar o buscar cuando no existen elementos
        /// </summary>
        /// <returns></returns>
        public bool BoletoVacio()
        {
            if (this.top == 0)
                return true;
            return false;
        }

        #endregion
        #region Metodos:Platillo
        public bool EliminarPlatillo(ProductoPlatillo plat)
        {
            if (!(PlatilloVacio()))
            {
                for (int i = 0; i < this.top; i++)//iterador para desplazarce por las posiones del arreglo
                {
                    if (this.platillo[i].Id_producto == plat.Id_producto)// compara si el dato es del mismo valor al dato que buscamos a eliminar
                    {// fijamos el valor de i
                        for (int y = i; y < this.top - 1; y++)//preevee un intercambio de valores
                            this.platillo[y] = this.platillo[y + 1];
                        this.top--;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public bool PlatilloLleno()
        {
            if (this.top == this.max)
                return true;
            return false;
        }

        /// <summary>
        /// Metodo que permite controlar el critico EstaVacio para evitar
        /// realizar la operacion de eliminar o buscar cuando no existen elementos
        /// </summary>
        /// <returns></returns>
        public bool PlatilloVacio()
        {
            if (this.top == 0)
                return true;
            return false;
        }
        #endregion

        

    }
}
