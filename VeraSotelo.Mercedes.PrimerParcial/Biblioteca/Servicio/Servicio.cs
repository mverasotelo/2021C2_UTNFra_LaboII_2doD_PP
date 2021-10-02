using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Servicio
    {
        //atributos
        protected int identificador;
        protected DateTime horaInicio;
        protected int duracionEnMinutos;

        #region Constructores
        protected Servicio()
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad lectura-escritura
        /// </summary>
        abstract public int DuracionServicio { get; set; }

        /// <summary>
        /// Solo lectura = Devuelve el costo de la llamada
        /// </summary>
        public float Costo
        {
            get
            {
                return CalcularCosto();
            }
        }

        public DateTime HoraInicio
        {
            get
            {
                return horaInicio;
            }
            set
            {
                horaInicio = value;
            }
        }

        #endregion

        #region Metodos 

        /// <summary>
        /// Calcula el costo de un servicio
        /// </summary>
        /// <returns></returns>
        abstract protected float CalcularCosto();

        public float AgregarIVA()
        {
            return Costo * 1.21F;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Servicio s1, Servicio s2)
        {
            if (s1 is not null && s2 is not null)
            {
                return s1.identificador == s2.identificador;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator !=(Servicio s1, Servicio s2)
        {
            return !(s1 == s2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Servicio servicio = obj as Servicio;
            return servicio != null && this == servicio;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return identificador.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Servicio";
        }

        #endregion
    }

}
