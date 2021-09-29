using System;
using System.Text;
namespace Biblioteca
{
    public sealed class Llamada : Servicio
    {
        #region Enumerados
        public enum ETipoLlamada
        {
            Local = 100, LargaDistancia = 250, Internacional = 500
        }
        #endregion

        #region Atributos

        private int codigoPais;
        private int prefijoLocalidad;
        private int numero;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Llamada
        /// </summary>
        /// <param name="codigoPais"></param>
        /// <param name="prefijoLocalidad"></param>
        /// <param name="numero"></param>
        public Llamada(int codigoPais, int prefijoLocalidad, int numero)
        {
            this.codigoPais = codigoPais;
            this.prefijoLocalidad = prefijoLocalidad;
            this.numero = numero;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Solo lectura = Devuelve el numero de destino
        /// </summary>
        public string NroDestino
        {
            get
            {
                return $"+{codigoPais} ({prefijoLocalidad}) {numero}";
            }
        }

        /// <summary>
        /// Solo lectura = retorna el tipo de llamada
        /// </summary>
        public ETipoLlamada TipoLlamada
        {
            get
            {
                return IdentificarTipoLlamada();
            }
        }

        /// <summary>
        /// Solo lectura = Devuelve el costo de la llamada
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        /// <summary>
        /// Lectura/Escritura = Para establecer la duracion de una llamada una vez finalizada 
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

        #region Métodos

        /// <summary>
        /// Analiza el número de la llamada a fin de determinar si es local, larga distancia o internacional
        /// </summary>
        /// <returns>Tipo de llamada</returns>
        private ETipoLlamada IdentificarTipoLlamada()
        {
            if(codigoPais != 54)
            {
                return ETipoLlamada.Internacional;
            }
            else
            {
                if(prefijoLocalidad == 11)
                {
                    return ETipoLlamada.Local;
                }
                else
                {
                    return ETipoLlamada.LargaDistancia;
                }
            }
        }

        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una llamada segun su duracion y el valor del minuto
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return (DuracionServicio * (int) TipoLlamada)/100;
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
                return ll1.GetHashCode() == ll2.GetHashCode();
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
            string telefono = $"{codigoPais}{prefijoLocalidad}{numero}";
            return telefono.GetHashCode() + DuracionServicio.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Llamada {TipoLlamada}\n");
            sb.AppendLine($"Nro Destino: +{codigoPais} ({prefijoLocalidad}) {numero}\n");
            return sb.ToString();
        }

        #endregion
    }
}
