using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    //una clase abstracta no puede ser instanciada
    abstract class Animal
    {
        

        #region Campos
        private string tipoPiel; 
        private string colorPelaje; 
        private string especie;
        private string tipoAlimentacion;
        private string genero;
        private bool tipoReproduccion;
        bool carnivoro;

        public string TipoPiel { get => tipoPiel; set => tipoPiel = value; }
        public string ColorPelaje { get => colorPelaje; set => colorPelaje = value; }
        public string Especie { get => especie; set => especie = value; }
        public string TipoAlimentacion { get => tipoAlimentacion; set => tipoAlimentacion = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        #endregion

        #region Metodos

        public virtual void Comer()
        {
            Console.WriteLine("Masticar");
        }

        protected void Respirar()
        {
            //toDo
        }
        //metodos abstractos solo se declaran en las clases derivadas
        public abstract int Oler();
        #endregion

    }
}
