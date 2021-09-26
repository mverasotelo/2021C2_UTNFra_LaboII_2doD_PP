using System;

namespace Biblioteca
{
    public abstract class Servicio
    {
        #region Enumeradores
        public enum ETipo { Cabina, Computadora };
        public enum EEstado { Libre, Ocupado };
        #endregion

        //atributos
        protected string identificador;
        protected EEstado estado;
        protected ETipo tipo;
        
        #region Constructores
        protected Servicio()
        {
            this.estado = EEstado.Libre;
        }
        #endregion

        #region Propiedades
        public ETipo TipoServicio
        {
            get
            {
                return tipo;
            }
        }
        #endregion

        #region Metodos 

        /// <summary>
        /// Calcula los minutos de uso del servicio
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected abstract int CalcularMinutosDeUso();

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
            return $"{identificador}";
        }

        #endregion
    }
}
