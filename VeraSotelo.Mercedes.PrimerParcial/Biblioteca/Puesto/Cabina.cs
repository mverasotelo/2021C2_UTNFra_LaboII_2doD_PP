using System.Text;

namespace Biblioteca
{
    public sealed class Cabina : Puesto
    {
        #region Enumerados
        public enum ETipoTelefono
        {
            ADisco, ConTeclado
        }
        #endregion

        private ETipoTelefono tipoTelefono;
        private string marca;

        /// <summary>
        /// Constructor de la clase Cabina, recibe un identificador, un tipo y una marca
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        public Cabina(string identificador, ETipoTelefono tipo, string marca) 
            : base(identificador)
        {
            this.tipo = ETipo.Cabina;
            this.identificador = identificador;
            this.tipoTelefono = tipo;
            this.marca = marca;
        }

        #region Métodos y sobrecargas

        /// <summary>
        /// Sobrescribe el metodo ToString(), utilizando el de la base y agregando info sobre el telefono
        /// </summary>
        /// <returns>Devuelve string con info de la cabina</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo teléfono: {tipoTelefono}");
            sb.AppendLine($"Marca: {marca}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador ==. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public static bool operator ==(Cabina c1, Cabina c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.GetHashCode() == c2.GetHashCode();
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Devuelve true si los hash code son distintos, false si son iguales</returns>
        public static bool operator !=(Cabina c1, Cabina c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobreescribe Equals(), reutilizando la sobrecarga del operador == de Computadora. 
        /// Compara que el hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si los identificadores son iguales, false si no</returns>
        public override bool Equals(object obj)
        {
            Cabina cabina = obj as Cabina;
            return cabina != null && this == cabina;
        }

        /// <summary>
        /// Sobreescribe GetHashCode() usando el de la clase base Puesto y comparando tambien segun especificaciones del telefono.
        /// </summary>
        /// <returns>Nuevo hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() + marca.GetHashCode() + tipoTelefono.GetHashCode();
        }

        #endregion y sobrecargas
    }
}
