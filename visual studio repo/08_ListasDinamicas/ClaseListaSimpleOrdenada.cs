using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ListasDinamicas
{
    class ClaseListaSimpleOrdenada<Tipo> where Tipo : IComparable<Tipo>, IEquatable<Tipo>
    {
        // Declaración del NodoInicial de la Lista
        private ClaseNodo NodoInicial;
        // Declaración de la clase de los nodos
        private class ClaseNodo
        {
            private Tipo objetocondatos; // Objeto con los datos del nodo
            private ClaseNodo siguiente; // Apuntador al siguiente nodo lógico

            // Propiedad pública de los datos del nodo
            public Tipo ObjetoConDatos
            {
                get { return (objetocondatos); }
                set { objetocondatos = value; }
            }
            // Propiedad pública del apuntador al siguiente nodo
            public ClaseNodo Siguiente
            {
                get { return (siguiente); }
                set { siguiente = value; }
            }
        }
        // Constructor de la ClaseListaSimple
        public ClaseListaSimpleOrdenada()
        {
            NodoInicial = null; // Inicializa la lista simple vacía
        }
        // Método para detectar si la Lista esta vacía
        public bool EstaVacia()
        {
            return NodoInicial == null;
        }
        // Método para insertar un Nodo
        public void Insertar(Tipo Nodo)
        {
            // Declaración local de los nodos
            ClaseNodo NuevoNodo, NodoActual,
            NodoAnterior;
            // Verificar si la lista esta vacía
            if (EstaVacia())
            {
                NuevoNodo = new ClaseNodo(); // Creación del nuevo nodo
                NuevoNodo.ObjetoConDatos = Nodo; //Asignación de los datos del Nodo
                NuevoNodo.Siguiente = null; // El NuevoNodo apunta a nulo
                NodoInicial = NuevoNodo; // Ahora el NuevoNodo es el NodoInicial
                return; // Inserción exitosa
            }
            // Recorrido de la Lista
            NodoActual = NodoInicial; // Inicializa el recorrido en el NodoInicial
            NodoAnterior = NodoInicial; // Guarda el NodoAnterior
            do
            {
                // Comparación para verificar duplicado
                if
                (NodoActual.ObjetoConDatos.CompareTo(Nodo) == 0)
                    throw new Exception("Duplicado ..."); // No se inserta el dato (duplicado)
                if
            (Nodo.CompareTo(NodoActual.ObjetoConDatos) < 0)
                {
                    // Alta al principio de la Lista
                    if
                    (Nodo.CompareTo(NodoInicial.ObjetoConDatos) < 0)
                    {
                        NuevoNodo = new ClaseNodo();
                        // Creación del nuevo nodo
                        NuevoNodo.ObjetoConDatos =
                        Nodo; // Asignación de los datos del Nodo
                        NuevoNodo.Siguiente =
                        NodoInicial; // El NuevoNodo apunta al NodoInicial
                        NodoInicial = NuevoNodo; // Ahora el NodoInicial es el NuevoNodo
                        return; // Inserción exitosa
                    }
                    else
                    {
                        // Alta de un Dato intermedio en la Lista
                        NuevoNodo = new ClaseNodo(); // Creación del nuevo nodo
                        NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos del Nodo
                        NuevoNodo.Siguiente = NodoAnterior.Siguiente; // El NuevoNodo apunta al NodoAnterior
                        NodoAnterior.Siguiente = NuevoNodo; // El NodoAnterior apunta al NuevoNodo
                        return; // Inserción exitosa
                    }
                }
                NodoAnterior = NodoActual; // Guarda el NodoAnterior
                NodoActual = NodoActual.Siguiente; //Se mueve al siguiente nodo del NodoActual
            } while (NodoActual != null); // Repetir mientras no se encuentre el final de la Lista
            // Alta de un Dato al final de la Lista
            NuevoNodo = new ClaseNodo(); // Creación del nuevo nodo
            NuevoNodo.ObjetoConDatos = Nodo; // Asignación de los datos del Nodo
            NuevoNodo.Siguiente = null; // El NuevoNodo no apunta a nada(es el último de la lista)
            NodoAnterior.Siguiente = NuevoNodo; // El NodoAnterior apunta al NuevoNodo
            return; // Inserción exitosa
        }
        //Método para eliminar un dato
        public Tipo Eliminar(Tipo Nodo)
        {
            // Declaración de los nodos
            ClaseNodo NodoActual, NodoAnterior, NodoEliminado;
            if (EstaVacia()) // Si está vacía ...
                throw new Exception("Vacía ...");
            // Inicializa el recorrido de la lista
            NodoActual = NodoInicial;
            NodoAnterior = NodoInicial; // Guarda el NodoAnterior
            do
            {
                if (Nodo.Equals(NodoActual.ObjetoConDatos)) // Verifica si es el Nodo que desea borrar
                {
                    /*NodoEliminado = new ClaseNodo();*/ // Crea un objeto
                    //NodoEliminado = NodoActual; // Guarda temporalmente los datos del nodo que se desea eliminar
                                                // Eliminación del primer nodo dela lista
                    if (Nodo.Equals(NodoInicial.ObjetoConDatos)) // ¿Es el primer nodo de la lista ?
                    {
                        NodoInicial = NodoActual.Siguiente; // El NodoInicial ahora es al que apunta el NodoActual
                        NodoActual.Siguiente = null; //Se elimina el Nodo Actual
                        return (NodoActual.ObjetoConDatos); // Eliminación exitosa(devuelve los datos del nodo eliminado)
                    }
                    else
                    {
                        // Eliminación de un nodo intermedio o el ultimo nodo de la lista
                        NodoAnterior.Siguiente = NodoActual.Siguiente; // El NodoAnterior apunta al siguiente nodo del actual
                        NodoActual.Siguiente = null;//Se elimina el Nodo Actual
                        return (NodoActual.ObjetoConDatos); // Eliminación exitosa(devuelve los datos del nodo eliminado)
                    }
                }
                NodoAnterior = NodoActual; // Guarda el NodoAnterior
                NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
            } while (NodoActual != null);
            throw new Exception("No se encuentra ...");
            // Error: no existe el nodo que se desea eliminar
        }
        // Método para eliminar todos los nodos de la Lista Enlazada Simple
        public void Vaciar()
        {
            if (!EstaVacia()) // Si no está vacía
            {
                // Inicializa el NodoActual al principio de la lista y declara el NodoAnterior
                ClaseNodo NodoActual = NodoInicial, NodoAnterior;
                // Recorre la lista
                while (NodoActual != null) // Mientras no encuentra el final de la lista
                {
                    NodoAnterior = NodoActual; // Guarda el NodoAnterior
                    NodoActual = NodoActual.Siguiente;
                    // Cambia de NodoActual
                    NodoAnterior.Siguiente = null; // Elimina el NodoAnterior
                }
                NodoInicial = null; // Inicializa la lista vacía
            }
            else
                throw new Exception("Vacía ..."); // Error: la lista está vacía
        }
        // Método para buscar un Nodo en la Lista Enlazada Simple
        public Tipo Buscar(Tipo Nodo)
        {
            if (!EstaVacia()) // Si no está vacía ...
            {
                ClaseNodo NodoActual = NodoInicial; // Inicializa el NodoActual al principio de la lista
                                                    // Recorrido de la lista
                while (NodoActual != null) // Mientras no encuentra el final de la lista
                {
                    if (Nodo.Equals(NodoActual.ObjetoConDatos)) // ¿Es el nodo deseado ?
                        return
                        (NodoActual.ObjetoConDatos); // Búsqueda exitosa (devuelve los datos del nodo buscado)
                    NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
                }
                return (default(Tipo)); // Terminó el recorrido y no se encuentra el dato
            }
            else
                return (default(Tipo)); // No se encuentra el dato(lista simple vacía)
        }
        // Iterador de la lista
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (EstaVacia()) // Si está vacía ...
                yield break;
            ClaseNodo NodoActual = new ClaseNodo();
            // Inicia el recorrido de la lista en el NodoInicial
            NodoActual = NodoInicial;
            while (NodoActual != null) // Mientras haya nodos ...
            {
                yield return
                (Tipo)NodoActual.ObjetoConDatos; // Devuelve los datos del NodoActual
                NodoActual = NodoActual.Siguiente; // Cambia de NodoActual
            }
        }
    }
}
