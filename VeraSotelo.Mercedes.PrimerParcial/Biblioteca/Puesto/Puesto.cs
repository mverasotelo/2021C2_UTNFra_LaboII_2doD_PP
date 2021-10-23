using System;
using System.Text;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Puesto
    {
        #region Enumerados
        public enum ETipo { Cabina, Computadora, Todos };
        public enum EEstado { Disponible, Ocupado };
        #endregion

        protected string identificador;
        protected EEstado estado;
        protected ETipo tipo;
        protected List<Servicio> listaServicios;
        protected int minutosDeUso;
        protected Puesto(string identificador)
        {
            this.identificador = identificador;
            this.listaServicios = new List<Servicio>();
            this.estado = EEstado.Disponible;
        }

        /// <summary>
        /// Propiedad solo lectura del ID.
        /// </summary>
        public string Id
        {
            get
            {
                return identificador;
            }
        }

        /// <summary>
        /// Propiedad solo lectura del tipo de puesto
        /// </summary>
        public ETipo TipoPuesto
        {
            get
            {
                return tipo;
            }
        }

        /// <summary>
        /// Propiedad solo lectura de ListaServicios
        /// </summary>
        public List<Servicio> ListaServicios
        {
            get
            {
                return listaServicios;
            }
        }

        /// <summary>
        /// Propiedad lectura/escritura del estado
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                this.estado = value;
            }
        }

        /// <summary>
        /// Propiedad lectura/escritura de la duración.
        /// </summary>
        public int MinutosDeUso
        {
            get
            {
                return CalcularMinutosDeUso();
            }
            set
            {
                minutosDeUso = value;
            }
        }

        #region Metodos y sobrecargas

        /// <summary>
        /// Calcula los minutos de uso del puesto sumando la duración de los servicios 
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected int CalcularMinutosDeUso()
        {
            int usoTotal = 0;

            foreach (Servicio servicio in listaServicios)
            {
                usoTotal += servicio.DuracionServicio;
            }

            return usoTotal;
        }

        /// <summary>
        /// Compara dos puestos segun sus minutos de uso
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>1 si p1 es mayor a p2, 0 si son iguales, -1 si es menor</returns>
        internal static int CompararPuestosPorUso(Puesto p1, Puesto p2)
        {
            return p2.MinutosDeUso.CompareTo(p1.MinutosDeUso);
        }


        /// <summary>
        /// Sobrecarga del operador ==, comparando por identificador
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Devuelve true si los identificadores son iguales, false si son distintos</returns>
        public static bool operator ==(Puesto p1, Puesto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.identificador == p2.identificador;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Devuelve true si los identificadores son distintos, false si son iguales</returns>
        public static bool operator !=(Puesto p1, Puesto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals(), comparando por identificador, reutilizando la sobrecarga del operador == de Puesto.
        /// </summary>
        /// <returns>Devuelve true si los identificadores son iguales, false si son distintos</returns>
        public override bool Equals(Object obj)
        {
            Puesto puesto = obj as Puesto;
            return puesto != null && this == puesto;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode(), devolviendo el hash code del identificador.
        /// </summary>
        /// <returns>Nuevo hash code</returns>
        public override int GetHashCode()
        {
            return identificador.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString(), devolviendo informacion del puesto
        /// </summary>
        /// <returns>Devuelve in string con info del puesto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{tipo.ToString().ToUpper()} {identificador.ToUpper()}\n");
            sb.AppendLine($"Estado: {estado}");
            sb.AppendLine($"Minutos de uso: {MinutosDeUso}");

            return sb.ToString();
        }

        #endregion
    }
}
