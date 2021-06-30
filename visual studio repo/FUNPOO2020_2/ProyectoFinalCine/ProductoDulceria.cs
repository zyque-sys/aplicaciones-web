using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    class ProductoDulceria:Producto
    {
    string articulo;
    string tema;
    string sabor;

        public string Articulo { get => articulo; set => articulo = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Sabor { get => sabor; set => sabor = value; }
    }
}
