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
            tipoServicio = ETipoServicio.Sesion;
            softwareRequerido = new List<Enumerados.ESoftware>();
            perifericosRequeridos = new List<Enumerados.EPerifericos>();
            juegosRequeridos = new List<Enumerados.EJuegos>();
        }

        /// <summary>
        /// Constructor de sesion libre 
        /// </summary>
        /// <param name="tipoSesion"></param>
        public Sesion(ETipoSesion tipoSesion)
            :this()
        {
            this.tipoSesion = tipoSesion;
        }

        /// <summary>
        /// Constructor de sesion por tiempo fijo
        /// </summary>
        /// <param name="tiempo"></param>
        public Sesion(int tiempo)
            :this()
        {
            this.duracionEnMinutos = tiempo;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Lectura-escrritura
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

        #endregion
    }
}
