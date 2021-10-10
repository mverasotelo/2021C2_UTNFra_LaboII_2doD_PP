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

        #region Atributos

        private ETipoTelefono tipoTelefono;
        private string marca;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Cabina
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
        #endregion

        #region Métodos

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo teléfono: {tipoTelefono}");
            sb.AppendLine($"Marca: {marca}");

            return sb.ToString();
        }

        #endregion
    }
}
