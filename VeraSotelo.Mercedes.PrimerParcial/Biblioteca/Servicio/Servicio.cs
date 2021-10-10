using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Servicio
    {

        #region Enumerados
        public enum ETipoServicio { Sesion, Llamada, Todos };
        #endregion

        #region Atributos

        protected DateTime horaInicio;
        protected int duracionEnMinutos;
        protected ETipoServicio tipoServicio;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad lectura-escritura
        /// </summary>
        abstract public int DuracionServicio { get; set; }

        /// <summary>
        /// Solo lectura = Devuelve el costo del servicio
        /// </summary>
        public virtual float Costo
        {
            get
            {
                return CalcularCosto();
            }
        }

        /// <summary>
        /// Solo lectura = Devuelve el tipo del servicio
        /// </summary>
        public ETipoServicio TipoServicio
        {
            get
            {
                return tipoServicio;
            }
        }

        /// <summary>
        /// Propiedad lectura-escritura de horaInicio
        /// </summary>
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

        #region Métodos 

        /// <summary>
        /// Evalua si un puesto pasado por parametro es compatible.
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>True si el puesto esta libre, false si esta ocupado.</returns>
        public virtual bool EsCompatible(Puesto puesto)
        {
            if (puesto.Estado == Puesto.EEstado.Disponible)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Calcula el costo de un servicio
        /// </summary>
        /// <returns></returns>
        abstract protected float CalcularCosto();

        /// <summary>
        /// Le agrega un 21% en concepto de IVA al costo del servicio.
        /// </summary>
        /// <returns></returns>
        public float AgregarIVA()
        {
            return Costo * 1.21F;
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
            return HoraInicio.GetHashCode() + GetType().GetHashCode() + DuracionServicio.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hora Inicio: {HoraInicio}");
            sb.AppendLine($"Duración del Servicio: {DuracionServicio} minutos");
            return sb.ToString();
        }

        /// <summary>
        /// Muestra el costo por servicio.
        /// </summary>
        /// <returns></returns>
        public virtual string CobrarPorServicio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Saldo bruto: ${Costo:N2}");
            sb.AppendLine("_____________________________________");
            sb.AppendLine($"SALDO A PAGAR CON IVA: ${AgregarIVA():N2}");
            return sb.ToString();
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
                return s1.GetHashCode() == s2.GetHashCode();
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

        #endregion
    }
}
