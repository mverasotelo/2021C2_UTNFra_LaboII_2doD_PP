﻿using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Puesto
    {
        #region Enumeradores
        public enum ETipo { Cabina, Computadora };
        public enum EEstado { Disponible, Ocupado };
        #endregion

        //atributos
        protected string identificador;
        protected EEstado estado;
        protected ETipo tipo;
        
        #region Constructores
        protected Puesto(string identificador)
        {
            this.identificador = identificador;
            this.estado = EEstado.Disponible;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Solo lectura.
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
        /// Propiedad solo lectura del estado
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
        #endregion

        #region Metodos 

        /// <summary>
        /// Calcula los minutos de uso del puesto
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected abstract int CalcularMinutosDeUso();

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
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
        /// <returns></returns>
        public static bool operator !=(Puesto p1, Puesto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals()
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Puesto puesto = obj as Puesto;
            return puesto != null && this == puesto;
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