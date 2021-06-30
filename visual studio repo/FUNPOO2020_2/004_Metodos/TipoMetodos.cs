using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Metodos
{
    class TipoMetodos
    {
        private int campo;

        public int Campo
        {
            get { return this.campo; }
            set { this.campo = value; }
        }
        //metodo constructor se ejecuta al instanciar un objeto
        public TipoMetodos()
        {
            Console.WriteLine("Construccion de objeto");
        }
        public TipoMetodos(int a)
        {
            this.campo = a;
            Console.WriteLine("Construccion de objeto con inicializacion de campo");
        }


        /// <summary>
        /// Metodo que recibe un parametro tipo objeto
        /// </summary>
        /// <param name="parametro1"></param>
        public void MetodoConParametroTipoObjeto(Parametro parametro1)
        {
            parametro1.Campo = parametro1.Campo + 1;
            Console.WriteLine("El valor del objeto parametro 1 dentro del metodo es: {0}", parametro1);
        }

        public Parametro MetodoConParametroTipoObjetoConRetornoDeObjeto(Parametro parametro1)
        {
            Parametro par2 = new Parametro(); //memoria nueva independiente a otros espacios
            par2.Campo = parametro1.Campo;
            par2.Campo = par2.Campo + 1;
            Console.WriteLine("El valor del objeto parametro 1 dentro del metodo es: {0}", parametro1);
            return par2;
        }

        /// <summary>
        /// Metodo que recibe un parametro tipo primitivo
        /// </summary>
        public void MetodoConParametroTipoPrimitivo(int a)
        {
            a = a + 1;
            Console.WriteLine("El valor de la variable adentro del metodo es; {0}", a);
        }

        //metodo destructor
        ~TipoMetodos()
        {
            Console.WriteLine("Objeto destruido");
        }
        class EjemploTipoMetodos
        {
            static void Main()
            {
                TipoMetodos tipoMetodos = new TipoMetodos(); //aqui se ejecuta el metodo constructor
                int a = 5;
                Console.WriteLine("El valor de la variable antes del metodo es {0}", a);
                tipoMetodos.MetodoConParametroTipoPrimitivo(a);
                Console.WriteLine("El valor de la variable a es: {0}", a);

                Console.WriteLine();

                Parametro par1 = new Parametro();
                par1.Campo = 1;
                Console.WriteLine("El valor del Objeto par 1 antes del metodo es {0}", par1.Campo);
                tipoMetodos.MetodoConParametroTipoObjeto(par1);
                Console.WriteLine("El valor del Objeto par1 es: {0}", par1.Campo);

                //Parametro par2 = par1; //alias

                Parametro par2 = new Parametro(); //memoria nueva independiente a otros espacios
                par2.Campo = par1.Campo;// es copia de valor por el campo es de tipo primitivo

                //ICloner...por el momento esta fuera del tema...

                Console.WriteLine();
                Console.WriteLine("El valor del Objeto par1 antes del metodo es {0}", par1.Campo);
                tipoMetodos.MetodoConParametroTipoObjeto(par2);
                Console.WriteLine("El valor del Objeto par1 es: {0}", par1.Campo);

                Console.WriteLine();
                Console.WriteLine("El valor del Objeto par1 antes del metodo es {0}", par1.Campo);
                par2 = tipoMetodos.MetodoConParametroTipoObjetoConRetornoDeObjeto(par1);
                Console.WriteLine("El valor del objeto par1 es: {0}", par1.Campo);

                Console.WriteLine("Valor recibido en nuevo objeto par2 {0}", par2.Campo);

                Console.ReadLine();
            }
        }
    }
}
