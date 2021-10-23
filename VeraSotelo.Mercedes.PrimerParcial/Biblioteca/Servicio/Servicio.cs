using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Servicio
    {

        #region Enumerados
        public enum ETipoServicio { Sesion, Llamada, Todos };
        #endregion

        protected DateTime horaInicio;
        protected int duracionEnMinutos;
        protected ETipoServicio tipoServicio;

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

        #region Métodos y sobrecargas

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

        /// <summary>
        /// Sobrecarga del operador ==. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
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

        /// <summary>
        /// Sobrescribe el metodo Equals(). Utiliza la sobrecarga del == de Servicio.
        /// </summary>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public override bool Equals(Object obj)
        {
            Servicio servicio = obj as Servicio;
            return servicio != null && this == servicio;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode(). 
        /// Suma los hash code de la hora inicio, tipo del servicio y duración.
        /// </summary>
        /// <returns>Devuelve nuevo hash code</returns>
        public override int GetHashCode()
        {
            return HoraInicio.GetHashCode() + tipoServicio.GetHashCode() + DuracionServicio.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString(), mostrando informacion del servicio (hora inicio y duracion)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hora Inicio: {HoraInicio}");
            sb.AppendLine($"Duración del Servicio: {DuracionServicio} minutos");
            return sb.ToString();
        }
        #endregion
    }
}
