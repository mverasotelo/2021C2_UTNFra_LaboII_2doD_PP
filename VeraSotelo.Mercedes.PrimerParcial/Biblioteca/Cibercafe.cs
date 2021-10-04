using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace Biblioteca
{
    public static class Cibercafe
    {
        #region Atributos estáticos

        private static List<Puesto> puestos;
        private static Queue<Cliente> clientesEnEspera;

        #endregion

        #region Constructor estático

        /// <summary>
        /// Constructor estatico de la clase Cibercafe
        /// </summary>
        static Cibercafe()
        {
            puestos = new List<Puesto>();
            clientesEnEspera = new Queue<Cliente>();
        }

        #endregion

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

        #region Métodos estáticos

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
                if (!computadora.EstaDisponible(software))
                {
                    return false;
                }
            }
            foreach (Enumerados.EJuegos juego in sesion.JuegosRequeridos)
            {
                if (!computadora.EstaDisponible(juego))
                {
                    return false;
                }
            }
            foreach (Enumerados.EPerifericos periferico in sesion.PerifericosRequeridos)
            {
                if (!computadora.EstaDisponible(periferico))
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
        /// Agrega un servicio a un determinado puesto
        /// </summary>
        /// <param name="puesto"></param>
        /// <param name="servicio"></param>
        /// <returns>true si sale todo bien</returns>
        public static bool AgregarServicio(Puesto puesto, Servicio servicio)
        {
            if(puesto.Estado == Puesto.EEstado.Disponible)
            {
                puesto.Estado = Puesto.EEstado.Ocupado;
                servicio.HoraInicio = DateTime.Now;
                puesto.ListaServicios.Add(servicio);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finaliza un servicio, establece su duracion en minutos y libera el puesto
        /// </summary>
        /// <param name="puesto"></param>
        /// <param name="servicio"></param>
        /// <returns>true si sale todo bien, false si algo sale mal o el puesto estaba disponible</returns>
        public static bool LiberarPuesto(Puesto puesto)
        {
            if(puesto.Estado == Puesto.EEstado.Ocupado)
            {
                if (puesto.ListaServicios.Count > 0)
                {
                    Servicio servicioActivo = puesto.ListaServicios.Last();
                    if(servicioActivo is Llamada || (servicioActivo is Sesion && ((Sesion)servicioActivo).TipoSesion == Sesion.ETipoSesion.Libre))
                    {
                        servicioActivo.DuracionServicio = CalcularDiferenciaEnMinutos(servicioActivo.HoraInicio);
                    }
                    puesto.Estado = Puesto.EEstado.Disponible;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Calcula la diferencia en minutos entre una hora dada y la hora actual
        /// Por fines prácticos de la evaluación un segundo de la vida real será equivalente a un minuto del ciber.
        /// </summary>
        /// <param name="horaInicio"></param>
        /// <returns>Diferencia en minutos</returns>
        private static int CalcularDiferenciaEnMinutos(DateTime horaInicio)
        {
            TimeSpan diferencia = DateTime.Now - horaInicio;
            return (int)diferencia.TotalSeconds;
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

        /// <summary>
        /// Muestra puestos ordenados de forma descendente por minutos de uso, según el tipo pasado por parámetro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>string con la lista de puestos ordenado por minutos de uso en forma descendente</returns>
        public static string MostrarPuestosPorMinutosDeUso(Puesto.ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            List<Puesto> puestos = new List<Puesto>();

            foreach (Puesto p in ListaPuestos)
            {
                if (tipo == Puesto.ETipo.Cabina && p is Cabina)
                {
                    puestos.Add(p);
                }
                else if (tipo == Puesto.ETipo.Computadora && p is Computadora)
                {
                    puestos.Add(p);
                }
            }
            puestos.Sort(CompararPuestosPorUso);

            foreach (Puesto p in puestos)
            {
                sb.AppendLine(p.ToString());
                sb.AppendLine("_________________________\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Compara dos puestos segun sus minutos de uso
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>1 si p1 es mayor o igual a p2, 0 si es menor, -1 si ha ocurrido algun error</returns>
        public static int CompararPuestosPorUso(Puesto p1, Puesto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.MinutosDeUso >= p2.MinutosDeUso)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return -1;
        }

        /// <summary>
        /// Calcula las ganancias totales y clasificadas por servicio (teléfono/computadora).
        /// </summary>
        /// <returns>Cadena con la informacion de ganancias</returns>
        public static string CalcularGananciasTotales()
        {
            StringBuilder sb = new StringBuilder();
            float gananciasTelefono = 0;
            float gananciasPC = 0;

            foreach (Puesto p in ListaPuestos)
            {
                if(p.ListaServicios.Count > 0)
                {
                    foreach(Servicio s in p.ListaServicios)
                    {
                        if(s is Sesion)
                        {
                            gananciasPC += s.Costo;
                        }
                        else
                        {
                            gananciasTelefono += s.Costo;
                        }
                    }
                }
            }

            sb.AppendLine("*****GANANCIAS*****\n");
            sb.AppendLine($"Ganancias por cabinas: ${gananciasTelefono:N2}");
            sb.AppendLine($"Ganancias por computadoras: ${gananciasPC:N2}\n");
            sb.AppendLine($"GANANCIAS TOTALES: ${(gananciasTelefono+gananciasPC):N2}");

            return sb.ToString();
        }

        #endregion
    }
}
