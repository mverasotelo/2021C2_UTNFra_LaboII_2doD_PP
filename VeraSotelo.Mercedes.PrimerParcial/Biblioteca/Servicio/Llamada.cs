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

        private string codigoPais;
        private string prefijoLocalidad;
        private string numero;

        /// <summary>
        /// Constructor publico de llamada
        /// </summary>
        public Llamada()
        {
            tipoServicio = ETipoServicio.Llamada;
        }

        /// <summary>
        /// Sobrecarga del constructor de llamada que recibe codigo pais, prefijo localidad y numero.
        /// </summary>
        /// <param name="codigoPais"></param>
        /// <param name="prefijoLocalidad"></param>
        /// <param name="numero"></param>
        public Llamada(string codigoPais, string prefijoLocalidad, string numero)
            : this()
        {
            this.codigoPais = codigoPais;
            this.prefijoLocalidad = prefijoLocalidad;
            this.numero = numero;
        }

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
        /// Propiedad lectura escritura
        /// </summary>
        public string CodigoPais
        {
            get
            {
                return codigoPais;
            }
            set
            {
                codigoPais = value;
            }
        }

        /// <summary>
        /// Propiedad lectura escritura
        /// </summary>
        public string PrefijoLocalidad
        {
            get
            {
                return prefijoLocalidad;
            }
            set
            {
                prefijoLocalidad = value;
            }
        }

        /// <summary>
        /// Propiedad lectura escritura
        /// </summary>
        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
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


        #region Métodos y sobrecargas

        /// <summary>
        /// Analiza el número de la llamada a fin de determinar si es local, larga distancia o internacional.
        /// Se reconoce a una llamada como de larga distancia cuando el código de país es distinto de '54'.
        /// Se reconoce a una llamada como de larga distancia cuando el prefijo contiene un número distinto de '11' o '011' luego del código de país (54 - #### - #### - ####).
        /// Se reconoce a una llamada como local cuando el prefijo contiene un '11' o '011' luego del código de país (54 - 11 - #### - ####).
        /// </summary>
        /// <returns>Devuelve tipo de llamada</returns>
        private ETipoLlamada IdentificarTipoLlamada()
        {
            if(codigoPais != "54")
            {
                return ETipoLlamada.Internacional;
            }
            else
            {
                if(prefijoLocalidad == "11" || prefijoLocalidad == "011")
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
        /// Sobreescribe el metodo y calcula el costo de una llamada segun su duracion y el valor del minuto.
        /// Local: $1.00 por minuto.
        /// Larga distancia: $2.50 por minuto.
        /// Internacional: $5.00 por minuto. 
        /// </summary>
        /// <returns>Devuelve costo de la llamada</returns>
        protected override float CalcularCosto()
        {
            return (DuracionServicio * (int) TipoLlamada)/100;
        }

        /// <summary>
        /// Sobrescribe el metodo EsCompatible para adecuarlo a una Llamada 
        /// (ademas de estar libre, debe ser una cabina)
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>Si recibe una cabina libre devuelve true, sino devuelve false</returns>
        public override bool EsCompatible(Puesto puesto)
        {
            Cabina cabina = puesto as Cabina;

            if (cabina is not null && base.EsCompatible(cabina))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador ==. Compara que el Hash code de ambas llamadas sean iguales.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public static bool operator ==(Llamada ll1, Llamada ll2)
        {
            if (ll1 is not null && ll2 is not null)
            {
                return ll1.GetHashCode() == ll2.GetHashCode();
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador != que reutiliza la sobrecarga del operador ==, comparando llamadas segun el hash code.
        /// </summary>
        /// <param name="ll1"></param>
        /// <param name="ll2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public static bool operator !=(Llamada ll1, Llamada ll2)
        {
            return !(ll1 == ll2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals(). Utiliza la sobrecarga del == de Llamada.
        /// </summary>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public override bool Equals(Object obj)
        {
            Llamada llamada = obj as Llamada;
            return llamada != null && this == llamada;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode(), reutilizando el método de la base. 
        /// Suma los hash code de la hora inicio, tipo del servicio, duración y numero de destino.
        /// </summary>
        /// <returns>Devuelve el hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() + NroDestino.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString(), brindando informacion sobre la llamada.
        /// </summary>
        /// <returns>String con informacion de la llamada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Llamada {TipoLlamada}\n");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Nro Destino: +{codigoPais} ({prefijoLocalidad}) {numero}");
            return sb.ToString();
        }

        #endregion
    }
}
