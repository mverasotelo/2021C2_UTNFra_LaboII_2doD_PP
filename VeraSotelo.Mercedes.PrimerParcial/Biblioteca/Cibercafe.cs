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
        /// Propiedad solo lectura de lista de puestos
        /// </summary>
        public static List<Puesto> ListaPuestos
        {
            get
            {
                return puestos;
            }
        }

        /// <summary>
        /// Propiedad solo lectura de puestos disponibles
        /// </summary>
        public static List<Puesto> ListaPuestosDisponibles
        {
            get
            {
                return ChequearPuestosDisponibles();
            }
        }

        /// <summary>
        /// Propiedad solo lectura de lista de clientes en espera
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
        /// Chequea que los requisitos solicitado en una sesion esten disponibles en una PC pasada por parametro
        /// </summary>
        /// <param name="sesion"></param>
        /// <param name="computadora"></param>
        /// <returns>True si todo se cumple, False si algo no se cumple</returns>
        public static bool ChequearRequisitosPC(Sesion sesion, Computadora computadora)
        {
            foreach (Enumerados.ESoftware software in sesion.SoftwareRequerido)
            {
                if (computadora != software)
                {
                    return false;
                }
            }
            foreach (Enumerados.EJuegos juego in sesion.JuegosRequeridos)
            {
                if (computadora != juego)
                {
                    return false;
                }
            }
            foreach (Enumerados.EPerifericos periferico in sesion.PerifericosRequeridos)
            {
                if (computadora != periferico)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Chequea los puestos disponibles
        /// </summary>
        /// <returns>Devuelve una lista de los puestos disponibles</returns>
        private static List<Puesto> ChequearPuestosDisponibles()
        {
            List<Puesto> puestosDisponibles = new List<Puesto>();
            foreach(Puesto p in ListaPuestos)
            {
                if(p.Estado == Puesto.EEstado.Disponible)
                {
                    puestosDisponibles.Add(p);
                }
            }
            return puestosDisponibles;
        }

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
