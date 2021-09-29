using Biblioteca;
using System;
using System.Collections.Generic;
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
        /// Constructor la clase cliente
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Cliente(int dni, string nombre, string apellido, short edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        #region Propiedades

        /// <summary>
        /// 
        /// </summary>
        public Servicio Servicio
        {
            get
            {
                return servicio;
            }
        }

        #endregion

        #region Sobrecargas

        public static Cliente operator +(Cliente cliente, Servicio servicio)
        {
            if (servicio is Llamada)
            {
                cliente.servicio = (Llamada)servicio;
            }
            else
            {
                cliente.servicio = (Sesion)servicio;

            }
            return cliente;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.dni == c2.dni;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals()
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
        /// <returns></returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
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
