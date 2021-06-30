using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    abstract class Producto
    {
        #region Campos
        string nombre;
        int id_producto;
        int cantidad;
        float precio;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        #endregion

        #region Metodos
        public bool ReabastecerProducto()
        {
            //toDo
            int num;
            Console.WriteLine("Cuantas unidades desea añadir: ");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                cantidad = cantidad +num ;
                return true;
            }
            else
                return false;
            
        }
        #endregion
    }
}
