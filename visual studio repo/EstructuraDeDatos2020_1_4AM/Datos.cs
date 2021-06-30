using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arreglo_DatosEspeciales
{
    public class Datos
    {
        private int calificacion;
        private int matricula;
        private string grupo;
        private string nombre;

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static bool operator ==(Datos a,Datos b)
        {
            //1st way
            //if (a.matricula == b.matricula)
            //{
            //    if (a.calificacion==b.calificacion)
            //    {
            //        if (a.grupo==b.grupo)
            //        {
            //            if (a.nombre==b.nombre)
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //}
            //return false;
            //2nd way
            if (b.Equals(null))
                return false;

            return a.matricula == b.matricula && a.calificacion == b.calificacion && a.grupo == b.grupo && a.nombre == b.nombre;
        }
        public static bool operator !=(Datos a, Datos b)
        {
            if (b.Equals(null))
                return false;
        
            return a.matricula != b.matricula && a.calificacion != b.calificacion && a.grupo != b.grupo && a.nombre != b.nombre;
        }
        public static bool operator <(Datos a,Datos b)
        {
            return a.Matricula < b.Matricula; 
        }
        public static bool operator >(Datos a, Datos b)
        {
            return a.Matricula > b.Matricula;
        }
    }
}
