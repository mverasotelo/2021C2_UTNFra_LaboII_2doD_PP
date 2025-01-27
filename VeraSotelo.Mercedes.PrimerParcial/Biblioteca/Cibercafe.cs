﻿using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

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
        /// Propiedad solo lectura de lista de clientes a la espera de ser atendidos
        /// </summary>
        public static Queue<Cliente> ClientesEnEspera
        {
            get
            {
                return clientesEnEspera;
            }
        }


        #region Métodos públicos

        /// <summary>
        /// Agrega un cliente a la lista, si ya no se encuentra en la misma 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si se agrega, / False sino se pudo agregar o ya estaba en la lista</returns>
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
        /// Agrega un puesto al cibercafe. 
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>True si se pudo cargar / False si ya existia el servicio con ese identificador</returns>
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
        /// Lista los puestos compatibles con el servicio solicitado por el cliente
        /// </summary>
        /// <returns>Lista con los puestos compatibles</returns>
        public static List<Puesto> ListarPuestosCompatibles()
        {
            List<Puesto> puestos = new List<Puesto>();
            Servicio servicio = clientesEnEspera.Peek().Servicio;

            foreach (Puesto puesto in ListaPuestos)
            {
                if (servicio.EsCompatible(puesto))
                {
                    puestos.Add(puesto);
                }
            }
            return puestos;
        }

        /// <summary>
        /// Agrega el servicio del próximo cliente a un determinado puesto pasado por parametro y elimina al cliente de la cola
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>True si sale todo bien, False sino hay un puesto compatible</returns>
        public static bool AsignarPuesto(Puesto puesto, Servicio servicio)
        {
            if(servicio.EsCompatible(puesto))
            {
                puesto.Estado = Puesto.EEstado.Ocupado;
                servicio.HoraInicio = DateTime.Now;
                puesto.ListaServicios.Add(servicio);
                clientesEnEspera.Dequeue();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finaliza un servicio, establece su duracion en minutos y libera el puesto
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>True si sale todo bien, false si el puesto estaba disponible o no tenia cargado ningun servicio</returns>
        public static bool LiberarPuesto(Puesto puesto)
        {
            if (puesto.Estado == Puesto.EEstado.Ocupado)
            {
                if (puesto.ListaServicios.Count > 0)
                {
                    Servicio servicioActivo = puesto.ListaServicios.Last();
                    if (servicioActivo is Llamada || (servicioActivo is Sesion && ((Sesion)servicioActivo).TipoSesion == Sesion.ETipoSesion.Libre))
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
        /// Envia al cliente al final de la fila, sino encuentra puesto disponible.
        /// </summary>
        /// <returns>True si sale todo bien</returns>
        public static void EnviarClienteAlFinalDeLaFila()
        {
            Cliente cliente = clientesEnEspera.Peek();
            if (ListarPuestosCompatibles().Count == 0)
            {
                clientesEnEspera.Enqueue(cliente);
                clientesEnEspera.Dequeue();
            }
        }


        //METODOS DE ESTADISTICAS HISTORICAS

        /// <summary>
        /// Muestra puestos ordenados de forma descendente por minutos de uso, según el tipo pasado por parámetro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>String con la lista de puestos ordenado por minutos de uso en forma descendente</returns>
        public static string MostrarPuestosPorMinutosDeUso(Puesto.ETipo tipo)
        {
            List<Puesto> puestos = ListarPuestosPorTipo(tipo);
            puestos.Sort(Puesto.CompararPuestosPorUso);

            StringBuilder sb = new StringBuilder();
            foreach (Puesto p in puestos)
            {
                sb.AppendLine(p.ToString());
                sb.AppendLine("_________________________\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Calcula las ganancias totales y clasificadas por servicio (teléfono/computadora).
        /// </summary>
        /// <returns>String con la informacion de ganancias</returns>
        public static string CalcularGananciasTotales()
        {
            StringBuilder sb = new StringBuilder();
            float gananciasTelefono = 0;
            float gananciasPC = 0;

            foreach (Servicio s in ListarServicios())
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

            sb.AppendLine("*****GANANCIAS*****\n");
            sb.AppendLine($"Ganancias por cabinas: ${gananciasTelefono:N2}");
            sb.AppendLine($"Ganancias por computadoras: ${gananciasPC:N2}\n");
            sb.AppendLine($"GANANCIAS TOTALES: ${(gananciasTelefono+gananciasPC):N2}");

            return sb.ToString();
        }

        /// <summary>
        /// Calcula tiempo y recaudacion por tipo de llamada 
        /// </summary>
        /// <returns>String con la informacion por tipo de llamada</returns>
        public static string TiempoYRecaudacionLlamadas()
        {
            StringBuilder sb = new StringBuilder();
            float gananciasInternacionales = 0;
            float gananciasLargaDistancia = 0;
            float gananciasLocal = 0;
            float minutosInternacionales = 0;
            float minutosLargaDistancia = 0;
            float minutosLocal = 0;

            foreach (Servicio s in ListarServicios())
            {
                if(s is Llamada)
                {
                    if (((Llamada)s).TipoLlamada == Llamada.ETipoLlamada.Internacional)
                    {
                        gananciasInternacionales += s.Costo;
                        minutosInternacionales += s.DuracionServicio;
                    }
                    if (((Llamada)s).TipoLlamada == Llamada.ETipoLlamada.LargaDistancia)
                    {
                        gananciasLargaDistancia += s.Costo;
                        minutosLargaDistancia += s.DuracionServicio;
                    }
                    else
                    {
                        gananciasLocal += s.Costo;
                        minutosLocal += s.DuracionServicio;
                    }
                }
            }

            sb.AppendLine("***HORAS TOTALES Y RECAUDACION POR TIPO DE LLAMADA***\n");
            sb.AppendLine("LLAMADAS INTERNACIONALES:");
            sb.AppendLine($"Horas de llamadas internacionales: {(minutosInternacionales/60):N2}");
            sb.AppendLine($"Ganancias por llamadas internacionales: ${gananciasInternacionales:N2}\n");

            sb.AppendLine("LLAMADAS LARGA DISTANCIA:");
            sb.AppendLine($"Horas de llamadas larga distancia: {(minutosLargaDistancia/60):N2}");
            sb.AppendLine($"Ganancias por llamadas larga distancia: ${gananciasLargaDistancia:N2}\n");

            sb.AppendLine("LLAMADAS LOCALES:");
            sb.AppendLine($"Horas de llamadas locales: { (minutosLocal/60):N2}");
            sb.AppendLine($"Ganancias por llamadas locales: ${(gananciasLocal):N2}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra el software mas pedido por los clientes
        /// </summary>
        /// <returns></returns>
        public static string MostrarSoftwareMasPedido()
        {
            Dictionary<string, int> software = new Dictionary<string, int>();
            string softwareMasPedido = String.Empty;
            int contador = 0;

            foreach (Servicio s in ListarServicios())
            {
                if (s is Sesion)
                {
                    foreach (Enumerados.ESoftware j in ((Sesion)s).SoftwareRequerido)
                    {
                        if (!software.ContainsKey(j.ToString()))
                        {
                            software.Add(j.ToString(), 1);
                        }
                        else
                        {
                            software[j.ToString()] += 1;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> s in software)
            {
                if (s.Value > contador)
                {
                    softwareMasPedido = s.Key;
                    contador = s.Value;
                }
            }

            if (!String.IsNullOrEmpty(softwareMasPedido))
            {
                return $"El software más pedido es: {softwareMasPedido}";
            }
            else
            {
                return $"No se han pedido software";
            }
        }

        /// <summary>
        /// Muestra el juego mas pedido por los clientes
        /// </summary>
        /// <returns></returns>
        public static string MostrarJuegoMasPedido()
        {
            Dictionary<string, int> juegos = new Dictionary<string, int>();
            string juegoMasPedido = String.Empty;
            int contador = 0;

            foreach (Servicio s in ListarServicios())
            {
                if(s is Sesion)
                {
                    foreach (Enumerados.EJuegos j in ((Sesion)s).JuegosRequeridos)
                    {
                        if (!juegos.ContainsKey(j.ToString()))
                        {
                            juegos.Add(j.ToString(), 1);
                        }
                        else
                        {
                            juegos[j.ToString()] += 1;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> j in juegos)
            {
                if (j.Value > contador)
                {
                    juegoMasPedido = j.Key;
                    contador = j.Value;
                }
            }

            if (!String.IsNullOrEmpty(juegoMasPedido))
            {
                return $"El juego más pedido es: {juegoMasPedido}";
            }
            else
            {
                return $"No se han pedido juegos";
            }
        }

        /// <summary>
        /// Muestra el periferico mas pedido por los clientes
        /// </summary>
        /// <returns></returns>
        public static string MostrarPerifericoMasPedido()
        {
            Dictionary<string, int> perifericos = new Dictionary<string, int>();
            string perifericoMasPedido = String.Empty;
            int contador = 0;

            foreach (Servicio s in ListarServicios())
            {
                if (s is Sesion)
                {
                    foreach (Enumerados.EPerifericos p in ((Sesion)s).JuegosRequeridos)
                    {
                        if (!perifericos.ContainsKey(p.ToString()))
                        {
                            perifericos.Add(p.ToString(), 1);
                        }
                        else
                        {
                            perifericos[p.ToString()] += 1;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> p in perifericos)
            {
                if (p.Value > contador)
                {
                    perifericoMasPedido = p.Key;
                    contador = p.Value;
                }
            }

            if (!String.IsNullOrEmpty(perifericoMasPedido))
            {
                return $"El periférico más pedido es: {perifericoMasPedido}";
            }
            else
            {
                return $"No se han pedido periféricos";
            }
        }

        #endregion

        #region Métodos privados

        /// <summary>
        /// Lista los puestos por tipo
        /// </summary>
        /// <returns>Devuelve una lista de los puestos disponibles</returns>
        private static List<Puesto> ListarPuestosPorTipo(Puesto.ETipo tipo)
        {
            List<Puesto> puestos = new List<Puesto>();

            foreach (Puesto p in ListaPuestos)
            {
                if (p is Cabina && tipo == Puesto.ETipo.Cabina)
                {
                    puestos.Add(p);
                }
                else if (p is Computadora && tipo == Puesto.ETipo.Computadora)
                {
                    puestos.Add(p);
                }
            }
            return puestos;
        }

        /// <summary>
        /// Lista las sesiones del cibercafé
        /// </summary>
        /// <returns>Lista de sesiones</returns>
        private static List<Servicio> ListarServicios()
        {
            List<Servicio> servicios = new List<Servicio>();

            foreach (Puesto p in ListaPuestos)
            {
                foreach (Servicio s in p.ListaServicios)
                {
                    servicios.Add(s);
                }
            }
            return servicios;
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


        #endregion

    }
}
