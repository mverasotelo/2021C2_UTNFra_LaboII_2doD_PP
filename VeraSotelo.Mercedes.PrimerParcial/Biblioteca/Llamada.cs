using System;


namespace Biblioteca
{
    public class Llamada
    {
        #region Enumerados
        public enum ETipo
        {
            Local = 100, LargaDistancia = 250, Internacional = 500
        }
        #endregion

        #region Atributos

        private int identificador;
        private short codigoPais;
        private short prefijoLocalidad;
        private short numero;
        private ETipo tipo;
        private int duracionEnMinutos;

        #endregion

        #region Constructores
        public Llamada(short codigoPais, short prefijoLocalidad, short numero)
        {
            this.codigoPais = codigoPais;
            this.prefijoLocalidad = prefijoLocalidad;
            this.numero = numero;
            this.tipo = TipoLlamada;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Solo lectura = retorna el tipo de llamada
        /// </summary>
        public ETipo TipoLlamada
        {
            get
            {
                return IdentificarTipoLlamada();
            }
        }

        /// <summary>
        /// Lectura/Escritura = Para establecer la duracion de una llamada una vez finalizada 
        /// </summary>
        public int DuracionLlamada
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
        /// Solo lectura = Devuelve el costo de la llamada
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return CalcularCostoLlamada();
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Analiza el número de la llamada a fin de determinar si es local, larga distancia o internacional
        /// </summary>
        /// <returns>Tipo de llamada</returns>
        private ETipo IdentificarTipoLlamada()
        {
            if(codigoPais != 54)
            {
                return ETipo.Internacional;
            }
            else
            {
                if(prefijoLocalidad == 11)
                {
                    return ETipo.Local;
                }
                else
                {
                    return ETipo.LargaDistancia;
                }
            }
        }

        /// <summary>
        /// Calcula el costo de una llamada segun su duracion y el valor del minuto
        /// </summary>
        /// <returns></returns>
        private float CalcularCostoLlamada()
        {
            return (DuracionLlamada * (int) tipo)/100;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Llamada ll1, Llamada ll2)
        {
            if (ll1 is not null && ll2 is not null)
            {
                return ll1.identificador == ll2.identificador;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="ll1"></param>
        /// <param name="ll2"></param>
        /// <returns></returns>
        public static bool operator !=(Llamada ll1, Llamada ll2)
        {
            return !(ll1 == ll2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Llamada llamada = obj as Llamada;
            return llamada != null && this == llamada;
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
            return $"{codigoPais} - {prefijoLocalidad} - {numero}";
        }

        #endregion
    }
}
