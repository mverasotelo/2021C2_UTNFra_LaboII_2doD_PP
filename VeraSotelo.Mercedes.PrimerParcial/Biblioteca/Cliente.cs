using System;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private short edad;
        private Servicio servicio;

        /// <summary>
        /// Constructor de la clase Cliente, recibe dni, nombre, apellido, edad y servicio solicitado.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="servicio"></param>
        public Cliente(int dni, string nombre, string apellido, short edad, Servicio servicio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.servicio = servicio;
        }

        /// <summary>
        /// Propiedad solo lectura de servicio
        /// </summary>
        public Servicio Servicio
        {
            get
            {
                return servicio;
            }
        }

        #region Metodos y sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Compara 2 clientes segun su numero de DNI
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Devuelve true si los DNI son iguales, false si son distintos</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.dni == c2.dni;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Compara 2 clientes segun su numero de DNI reutilizando la sobrecarga del operador ==.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Devuelve falsse si los DNI son iguales, true si son distintos</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals().Compara 2 clientes segun su numero de DNI reutilizando la sobrecarga del operador ==.
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && this == cliente;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns>Devuelve true si los DNI son iguales, false si son distintos</returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString(), mostrando informacion del cliente.
        /// </summary>
        /// <returns>Devuelve string con informacion del cliente.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" {nombre} {apellido}");
            sb.AppendLine($" DNI: {dni}");
            sb.AppendLine($" ({edad} años)");
            return sb.ToString();
        }
        #endregion
    }
}