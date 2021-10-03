using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public sealed class Sesion : Servicio
    {
        #region Enumerados
        public enum ETipoSesion
        {
            Libre, Fija        
        }
        #endregion

        #region Atributos

        private const float COSTO = 0.5F;
        private ETipoSesion tipoSesion;
        private List<Enumerados.ESoftware> softwareRequerido;
        private List<Enumerados.EPerifericos> perifericosRequeridos;
        private List<Enumerados.EJuegos> juegosRequeridos;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor privado de sesion para crear listas e inicializar tipoServicio en Sesion.
        /// </summary>
        private Sesion()
        {
            softwareRequerido = new List<Enumerados.ESoftware>();
            perifericosRequeridos = new List<Enumerados.EPerifericos>();
            juegosRequeridos = new List<Enumerados.EJuegos>();
        }

        /// <summary>
        /// Constructor de la clase Sesion
        /// </summary>
        /// <param name="tipoSesion"></param>
        /// <param name="softwareRequerido"></param>
        /// <param name="perifericosRequeridos"></param>
        /// <param name="juegosRequeridos"></param>
        public Sesion(List<Enumerados.ESoftware> softwareRequerido,
            List<Enumerados.EPerifericos> perifericosRequeridos, 
            List<Enumerados.EJuegos> juegosRequeridos)
            :this()
        {
            this.softwareRequerido = softwareRequerido;
            this.perifericosRequeridos = perifericosRequeridos;
            this.juegosRequeridos = juegosRequeridos;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad lectura-escritura tipo sesion
        /// </summary>
        public ETipoSesion TipoSesion
        {
            get
            {
                return tipoSesion;
            }
            set
            {
                this.tipoSesion = value;
            }
        }

        /// <summary>
        /// Propiedad de solo letura SoftwareRequerido
        /// </summary>
        public List<Enumerados.ESoftware> SoftwareRequerido
        {
            get
            {
                return softwareRequerido;
            }
        }

        /// <summary>
        /// Propiedad de solo letura PerifericosRequeridos
        /// </summary>
        public List<Enumerados.EPerifericos> PerifericosRequeridos
        {
            get
            {
                return perifericosRequeridos;
            }
        }

        /// <summary>
        /// Propiedad de solo letura JuegosRequeridos
        /// </summary>
        public List<Enumerados.EJuegos> JuegosRequeridos
        {
            get
            {
                return juegosRequeridos;
            }
        }

        /// <summary>
        /// Propiedad lectura-escritura DuracionServicio
        /// </summary>
        public override int DuracionServicio
        {
            get
            {
                return duracionEnMinutos;
            }
            set
            {
                duracionEnMinutos = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una sesion segun su duracion y el costo
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {   
            return (float) Math.Ceiling(DuracionServicio / 30F) * COSTO;
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sesión {tipoSesion}\n");
            if(tipoSesion != ETipoSesion.Libre)
            {
                sb.AppendLine($"Minutos solicitados: 0");
            }
            sb.AppendLine(MostrarRequerimientosCliente());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los requerimientos de la PC
        /// </summary>
        /// <returns></returns>
        public string MostrarRequerimientosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Software requerido:");
            foreach (Enumerados.ESoftware software in softwareRequerido)
            {
                sb.AppendLine($"- {software} ");
            }
            sb.AppendLine($"\n Perifericos requeridos:");
            foreach (Enumerados.EPerifericos periferico in perifericosRequeridos)
            {
                sb.AppendLine($"- {periferico} ");
            }
            sb.AppendLine($"\n Juegos requeridos:");
            foreach (Enumerados.EJuegos juego in juegosRequeridos)
            {
                sb.AppendLine($"- {juego} ");
            }
            return sb.ToString();
        }

        #endregion
    }
}