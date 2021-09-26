using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cibercafe
    {

        private List<Computadora> computadoras;
        private List<Cabina> cabinas;
        private Queue<Cliente> clientesEnEspera;

        /// <summary>
        /// Constructor de la clase Cibercafe
        /// </summary>
        public Cibercafe()
        {
            this.computadoras = new List<Computadora>();
            this.cabinas = new List<Cabina>();
            this.clientesEnEspera = new Queue<Cliente>();
        }

        /// <summary>
        /// Solo Lectura = devuelva lista de computadoras
        /// </summary>
        public List<Computadora> ListaComputadoras
        {
            get
            {
                return computadoras;
            }
        }

        /// <summary>
        /// Solo Lectura = devuelva lista de cabinas
        /// </summary>
        public List<Cabina> ListaCabinas
        {
            get
            {
                return cabinas;
            }
        }

                /// <summary>
        /// Solo Lectura = devuelva lista de cabinas
        /// </summary>
        public Queue<Cliente> ClientesEnEspera
        {
            get
            {
                return clientesEnEspera;
            }
        }

        #region Operadores

        /// <summary>
        /// Agrega un servicio al cibercafe. 
        /// </summary>
        /// <param name="cibercafe"></param>
        /// <param name="servicio"></param>
        /// <returns>True si se pudo cargar / false si ya existia el servicio con ese identificador</returns>
        public static Cibercafe operator +(Cibercafe cibercafe, Servicio servicio)
        {
            if(servicio.TipoServicio == Servicio.ETipo.Computadora)
            {
                if(cibercafe.computadoras.Count != 0)
                {
                    foreach (Computadora c in cibercafe.computadoras)
                    {
                        if (c == (Computadora)servicio)
                        {
                            return cibercafe;
                        }
                    }
                }
                cibercafe.computadoras.Add((Computadora)servicio);
            }
            else
            {
                if (cibercafe.cabinas.Count != 0)
                {
                    foreach (Cabina c in cibercafe.cabinas)
                    {
                        if (c == (Cabina)servicio)
                        {
                            return cibercafe;
                        }
                    }
                }
                cibercafe.cabinas.Add((Cabina)servicio);
            }
            return cibercafe;
        }

        public static Cibercafe operator +(Cibercafe cibercafe, Cliente cliente)
        {
            foreach (Cliente c in cibercafe.clientesEnEspera)
            {
                if (c == cliente)
                {
                    return cibercafe;
                }
            }
            cibercafe.clientesEnEspera.Enqueue(cliente);

            return cibercafe;
        }

        //public static Cibercafe operator -(Cibercafe cibercafe, Cliente cliente)
        //{
        //    foreach (Cliente c in cibercafe.clientesEnEspera)
        //    {
        //        if (c == cliente)
        //        {
        //            cibercafe.clientesEnEspera.Dequeue();
        //            return cibercafe;
        //        }
        //    }
        //    return cibercafe;
        //}

        #endregion
    }
}
