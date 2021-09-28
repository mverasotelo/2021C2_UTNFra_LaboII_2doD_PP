using System.Collections.Generic;

namespace Biblioteca
{
    public static class Cibercafe
    {
        private static List<Puesto> puestos;
        private static Queue<Cliente> clientesEnEspera;

        /// <summary>
        /// Constructor estatico de la clase Cibercafe
        /// </summary>
        static Cibercafe()
        {
            puestos = new List<Puesto>();
            clientesEnEspera = new Queue<Cliente>();
        }

        #region Propiedades

        /// <summary>
        /// Solo Lectura = devuelve lista de cabinas
        /// </summary>
        public static List<Puesto> ListaPuestos
        {
            get
            {
                return puestos;
            }
        }

        /// <summary>
        /// Solo Lectura = devuelva lista de cabinas
        /// </summary>
        public static Queue<Cliente> ClientesEnEspera
        {
            get
            {
                return clientesEnEspera;
            }
        }
        #endregion

        #region Metodos estaticos

        /// <summary>
        /// Agrega un puesto al cibercafe. 
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>True si se pudo cargar / false si ya existia el servicio con ese identificador</returns>
        public static bool AgregarPuesto(Puesto puesto)
        {
            foreach (Puesto p in ListaPuestos)
            {
                if (p == puesto)
                {
                    return false;
                }
            }
            puestos.Add(puesto);
            return true;
        }

        /// <summary>
        /// Agrega un cliente a la lista, si ya no se encuentra en la misma 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true si se agrega, false sino se pudo agregar o ya estaba en la lista</returns>
        public static bool IngresarCliente(Cliente cliente)
        {
            foreach (Cliente c in ClientesEnEspera)
            {
                if (c == cliente)
                {
                    return false;
                }
            }
            ClientesEnEspera.Enqueue(cliente);
            return true;
        }
        #endregion

    }
}
