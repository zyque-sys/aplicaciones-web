using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ListasDinamicasDobles.Teoria
{
    class ClaseListaDobleOrdenada<Tipo> where Tipo :
  IComparable<Tipo>, IEquatable<Tipo>
    {
        private ClaseNodo nodoinicial; // Apuntador al nodo inicial

        private ClaseNodo nodofinal; // Apuntador al nodo final
        private ClaseNodo NodoInicial
        {
            get { return (nodoinicial); }
            set { nodoinicial = value; }
        }
        private ClaseNodo NodoFinal
        {
            get { return (nodofinal); }
            set { nodofinal = value; }
        }
        class ClaseNodo
        {
            private Tipo objetocondatos;
            private ClaseNodo siguiente;
            private ClaseNodo anterior;
            public Tipo ObjetoConDatos
            {
                get { return (objetocondatos); }
                set { objetocondatos = value; }
            }
            public ClaseNodo Siguiente
            {
                get { return (siguiente); }
                set { siguiente = value; }
            }
            public ClaseNodo Anterior
            {
                get { return (anterior); }
                set { anterior = value; }
            }
        }
        //Constructor
        public ClaseListaDobleOrdenada()
        {
            // Inicializa la lista doble vacía
            NodoInicial = null;
            NodoFinal = null;
        }
        // Método privado para detectar si la lista doble está vacía
        public bool EstaVacia()
        {
            if (NodoInicial == null || NodoFinal ==
            null)
                return (true);
            else
                return (false);
        }
        // Método que recibe el Nodo que se desea insertar
        public void Insertar(Tipo Nodo)
        {
            // Declaración local de los nodos
            ClaseNodo NuevoNodo, NodoActual,
            NodoAnterior;
            if (EstaVacia()) // Si está vacía
            {
                NuevoNodo = new ClaseNodo(); //Creación del NuevoNodo
                NuevoNodo.ObjetoConDatos = Nodo; //Asignación del Nodo
                NuevoNodo.Anterior = null;
                NuevoNodo.Siguiente = null;
                NodoInicial = NuevoNodo; // El NuevoNodo es el NodoInicial
                NodoFinal = NuevoNodo; // El NuevoNodo también es el NodoFinal
                return; // Inserción exitosa
            }
            NodoActual = NodoInicial;
            NodoAnterior = NodoActual;
            while (NodoActual != null)
            {
                if
                (NodoActual.ObjetoConDatos.Equals(Nodo))
                    throw new Exception("Duplicado...");
                if (Nodo.CompareTo(NodoActual.ObjetoConDatos) < 0)
                    if
                    (Nodo.CompareTo(NodoInicial.ObjetoConDatos) < 0) //Inserción al principio
                    {
                        NuevoNodo = new ClaseNodo();
                        NuevoNodo.ObjetoConDatos =
                        Nodo;
                        NuevoNodo.Anterior = null;
                        NuevoNodo.Siguiente =
                        NodoInicial;
                        NodoInicial.Anterior =
                        NuevoNodo;
                        NodoInicial = NuevoNodo;
                        return;
                    }
                    else // Inserción intermedia
                    {
                        NuevoNodo = new ClaseNodo();
                        NuevoNodo.ObjetoConDatos =
                        Nodo;
                        NuevoNodo.Anterior =
                        NodoAnterior;
                        NuevoNodo.Siguiente =
                        NodoActual;
                        NodoAnterior.Siguiente =
                        NuevoNodo;
                        NodoActual.Anterior =
                        NuevoNodo;
                        return;
                    }
                NodoAnterior = NodoActual;
                NodoActual = NodoActual.Siguiente;
            }
            // Inserción al final
            NuevoNodo = new ClaseNodo();
            NuevoNodo.ObjetoConDatos = Nodo;
            NuevoNodo.Anterior = NodoFinal;
            NuevoNodo.Siguiente = null;
            NodoFinal.Siguiente = NuevoNodo;
            NodoFinal = NuevoNodo;

            return;
        }
        public Tipo Eliminar(Tipo Nodo)
        {
            // Declaración local de los nodos
            ClaseNodo NodoActual, NodoAnterior;
            if (EstaVacia()) // Si está vacía ..
                return (default(Tipo)); // Nodo inexistente(lista doble vacía)
                                        // Inicia el recorrido de la lista doble
            NodoActual = NodoInicial;
            NodoAnterior = NodoInicial;
            while (NodoActual != null)
            {
                if
                (NodoActual.ObjetoConDatos.Equals(Nodo)) // Si localiza el nodo...
                {
                    ClaseNodo NodoEliminado = new
                    ClaseNodo();
                    NodoEliminado = NodoActual;
                    if (NodoInicial == NodoFinal) //Eliminación del único nodo
                    {
                        NodoInicial = null;
                        NodoFinal = null;
                        NodoActual = null;
                        return (NodoEliminado.ObjetoConDatos);
                    }
                    if (NodoActual == NodoInicial) //Eliminación al inicio
                    {
                        NodoInicial =
                        NodoActual.Siguiente;
                        NodoInicial.Anterior = null;
                        NodoActual = null;
                        return
                        (NodoEliminado.ObjetoConDatos);
                    }

                    if (NodoActual == NodoFinal) //Eliminación al final
                    {
                        NodoFinal =
                        NodoActual.Anterior;
                        NodoFinal.Siguiente = null;
                        NodoActual = null;
                        return
                        (NodoEliminado.ObjetoConDatos);
                    }
                    // Eliminación intermedia
                    NodoAnterior.Siguiente =
                    NodoActual.Siguiente;
                    NodoActual.Siguiente.Anterior =
                    NodoActual.Anterior;
                    NodoActual = null;
                    return
                    (NodoEliminado.ObjetoConDatos);
                }
                if
                (Nodo.CompareTo(NodoActual.ObjetoConDatos) < 0) // Si el nodo buscado es menor,
                    return (default(Tipo));
                // entonces no se encuentra
                NodoAnterior = NodoActual; // Guarda el NodoAnterior
                NodoActual = NodoActual.Siguiente; // Cambio de NodoActual
            }
            // Termina el recorrido de la lista doble y no se localiza el nodo(eliminación fallida)
            return (default(Tipo));
        }
        // Método público que recibe un Nodo para buscarlo en la lista doble
        public Tipo Buscar(Tipo Nodo)
        {
            if (!EstaVacia())
            {
                ClaseNodo NodoActual = new ClaseNodo();
                // Empieza el recorrido en el NodoInicial
                NodoActual = NodoInicial;
                while (NodoActual != null)
                {
                    if
                    (NodoActual.ObjetoConDatos.Equals(Nodo))
                        return
                        (NodoActual.ObjetoConDatos); // Devuelve los datos del nodo
                    NodoActual = NodoActual.Siguiente;
                    // Cambia al siguiente nodo
                }
                // Termina el recorrido y no localiza el nodo
                return (default(Tipo));
            }
            else
                return (default(Tipo)); // No se encuentra el nodo(Lista doble vacía)
        }

        // Método para eliminar todos los nodos de la Lista Doble
        public void Vaciar()
        {
            if (!EstaVacia())
            {
                // Inicializa el NodoActual al principio de la lista doble y declara el NodoAnterior
                ClaseNodo NodoActual = NodoInicial,
NodoAnterior;
                // Recorre la lista doble en forma ascendente
                while (NodoActual != null) // Mientras no encuentra el final de la lista doble
                {
                    NodoAnterior = NodoActual; //Guarda el NodoAnterior
                    NodoActual = NodoActual.Siguiente;
                    // Cambia de NodoActual
                    NodoAnterior = null; // Elimina el NodoAnterior
                }
                NodoInicial = null; // Inicializa la lista doble vacía
                NodoFinal = null;
            }
        }
        // Iterador para recorrer los nodos en forma ascendente
        public IEnumerable<Tipo> DesdeNodoInicial
        {
            get
            {
                if (EstaVacia()) // Si está vacía
                    yield break;
                // Declaración del nodo local
                ClaseNodo NodoActual = new ClaseNodo();
                // Inicia el recorrido de la lista en el NodoInicial
                NodoActual = NodoInicial;
                while (NodoActual != null) // Mientras haya nodos ...
                {
                    yield return
                    (Tipo)NodoActual.ObjetoConDatos; // Devuelve el NodoActual
                    NodoActual = NodoActual.Siguiente;
                    // Cambia de NodoActual
                }
            }
        }
        // Iterador para recorrer los nodos en forma descendente
        public IEnumerable<Tipo> DesdeNodoFinal
        {
            get
            {
                if (EstaVacia()) // Si está vacía
                    yield break;
                // Declaración del nodo local
                ClaseNodo NodoActual = new ClaseNodo();
                // Inicia el recorrido de la lista en el NodoInicial
                NodoActual = NodoFinal;
                while (NodoActual != null) // Mientras haya nodos ...
                {
                    yield return
                    (Tipo)NodoActual.ObjetoConDatos; // Devuelve el NodoActual
                    NodoActual = NodoActual.Anterior;
                    // Cambia de NodoActual
                }
            }
        }
    }
}
