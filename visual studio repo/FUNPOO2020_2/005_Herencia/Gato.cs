using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
     //la clase Animal es clase padre
     //La clase Gato es clase derivada
        class Gatos : Animal
        {
            #region Campos
            private string raza;
            private int edad;
            private bool estaDomesticado; 
            private string pelaje; 
            private bool tieneDiscapacidad; 
            private string colorOjos;

            public string Raza { get => raza; set => raza = value; }
            public int Edad { get => edad; set => edad = value; }
            public bool EstaDomesticado { get => estaDomesticado; set => estaDomesticado = value; }
            public string Pelaje { get => pelaje; set => pelaje = value; }
            public bool TieneDiscapacidad { get => tieneDiscapacidad; set => tieneDiscapacidad = value; }
            public string ColorOjos { get => colorOjos; set => colorOjos = value; }

            #endregion

            #region Metodos
            public void Maullar()
            {
                //toDo
            }

            public void Cazar()
            {
                //toDo
            }

            public void Asicalarse()
            {
                //toDo
            }

            public void afilarGarras()
            {
                //toDo
            }

            public override int Oler()
            {
                Console.WriteLine("Utiliza la nariz");
                return 1;
            }
            #endregion

        }
    
}
