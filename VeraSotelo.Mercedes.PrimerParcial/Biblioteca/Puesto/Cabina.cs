using System;
using System.Text;
using System.Collections.Generic;

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
        private List<Llamada> listaDeLlamadas;

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
            this.listaDeLlamadas = new List<Llamada>();
            this.tipo = ETipo.Cabina;
            this.identificador = identificador;
            this.tipoTelefono = tipo;
            this.marca = marca;
        }
        #endregion

        #region Propiedades
        public int MinutosDeUso
        {
            get
            {
                return CalcularMinutosDeUso();
            }
        }

        public ETipoTelefono TipoTelefono
        {
            get
            {
                return tipoTelefono;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobrescribe el metodo abstracto CalcularMinutosDeUso()
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected override int CalcularMinutosDeUso()
        {
            int usoTotal = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                usoTotal += llamada.DuracionServicio;
            }

            return usoTotal;
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" CABINA {identificador.ToUpper()}\n");
            sb.AppendLine($" Tipo teléfono: {tipoTelefono}");
            sb.AppendLine($" Marca: {marca}");
            sb.AppendLine($" Minutos de uso: {MinutosDeUso}");

            return sb.ToString();
        }

        #endregion
    }
}
