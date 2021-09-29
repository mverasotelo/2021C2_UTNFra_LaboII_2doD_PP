using System;
using System.Collections.Generic;
using Biblioteca;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Sesion : Servicio
    {

        #region Enumerados
        public enum ETipoSesion
        {
            Libre
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
        public Sesion(ETipoSesion tipoSesion, 
            List<Enumerados.ESoftware> softwareRequerido,
            List<Enumerados.EPerifericos> perifericosRequeridos, 
            List<Enumerados.EJuegos> juegosRequeridos)
            :this()
        {
            this.tipoSesion = tipoSesion;
            this.softwareRequerido = softwareRequerido;
            this.perifericosRequeridos = perifericosRequeridos;
            this.juegosRequeridos = juegosRequeridos;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Lectura-escrritura DuracionServicio
        /// </summary>
        public override int DuracionServicio
        {
            get
            {
                return duracionEnMinutos;
            }
            set
            {
                this.duracionEnMinutos = value;
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

        #endregion

        #region Metodos

        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una sesion segun su duracion y el costo
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            if (DuracionServicio % 30 > 0) //caso para PC de uso libre
            {
                double duracion = DuracionServicio / 30;
                return (float) Math.Ceiling(duracion) * COSTO;
            }
            return (DuracionServicio/30) * COSTO;
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
