using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ListasDinamicas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static string Mostrar(ClaseListaSimpleOrdenada<ClaseDatosNodoListaSimple> lista)
        {
            string salida = "";
            StringBuilder presalida = new StringBuilder();
            foreach (ClaseDatosNodoListaSimple ObjetoConDatoIn in lista)
            {
                presalida.Append(ObjetoConDatoIn.Dato + "-->");
            }
            return presalida.ToString() + "NULL";
        }
    }
}
