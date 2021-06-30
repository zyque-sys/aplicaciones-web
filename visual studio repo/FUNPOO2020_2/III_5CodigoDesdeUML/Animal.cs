using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III_5CodigoDesdeUML
{
    class Animal
    {
        //miembros de la clase
        //caracteristicas

        #region Campos
            //tipos de seguridad
        public string tipoPiel; 

        protected string color;

        private string raza;

        public string tipoAlimentacion;
        protected internal string genero;
        private protected string clasificacion;

        bool carnivoro; 
        #endregion

        #region Metodos
        //*funciones
        //o prodecimientos en progra estructurada
        //metodo // de POO

        //alimentarse
        public void Alimentarse()
        {
            tipoPiel = "sdjkfas";

            //...
            this.color = "dsd";
            this.genero = "dfs";
            this.clasificacion = "";
        }

        //respirar
        protected void Respirar()
        {
        }

        int Oler()
        {
            return 1;
        }

        Animal Reproducirse(Animal a, Animal b)
        {
            return new Animal();
        }

        //Comunicarse
        internal void Comunicarse()
        {
            //Como...
            //Void Hablar() {}
            //void Escuchar() { }
        }

        #endregion
    }
}
