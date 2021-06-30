using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dibujar.Formas;

namespace Dibujar
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto pI = new Punto(5,10);
            Punto pF = new Punto(11,80);
            Linea linea1 = new Linea(pI,pF);
            Linea linea2 = new Linea(new Punto(5, 10), new Punto(11, 80));

            linea1.Dibujar();
            linea2.Dibujar();

            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.Dibujar();
            Rectangulo rectangulo2 = new Rectangulo(pI,pF);
            rectangulo2.Dibujar();
            Rectangulo rectangulo3 = new Rectangulo(new Punto(55, 81), new Punto(100, 80));
            rectangulo3.Dibujar();
            Rectangulo rectangulo4 = new Rectangulo(pI, 10,56);
            rectangulo4.Dibujar();
            Rectangulo rectangulo5 = new Rectangulo(new Punto(55,101), 10, 56);
            rectangulo5.Dibujar();

            Elipse elipse1 = new Elipse();
            elipse1.Dibujar();
            Elipse elipse2 = new Elipse(pI,pF);
            elipse2.Dibujar();

            Elipse elipse3 = new Elipse(pI,20,40);
            elipse3.Dibujar();

            Elipse elipse4 = new Elipse(rectangulo4);
            elipse4.Dibujar();

            Elipse elipse5 = new Elipse(new Rectangulo(pI,78,34));
            elipse5.Dibujar();
            Console.WriteLine("Polimorfismo");
            Forma forma = new Linea();
            forma.Dibujar();
            forma = new Rectangulo();
            forma.Dibujar();
            forma = new Elipse();
            forma.Dibujar();
            Console.WriteLine("Ejemplo de virtual");
            forma.Borrar();
            Console.ReadLine();
        }
    }
}
