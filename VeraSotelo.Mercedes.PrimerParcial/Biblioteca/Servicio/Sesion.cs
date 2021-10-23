using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public sealed class Sesion : Servicio
    {
        #region Enumerados
        public enum ETipoSesion
        {
            Libre, Fija
        }
        #endregion

        private const float COSTO_BLOQUE_30MIN = 0.5F;
        private const float COSTO_IMPRESION = 0.05F;
        private ETipoSesion tipoSesion;
        private List<Enumerados.ESoftware> softwareRequerido;
        private List<Enumerados.EPerifericos> perifericosRequeridos;
        private List<Enumerados.EJuegos> juegosRequeridos;
        private int numeroCopias;

        /// <summary>
        /// Constructor privado de sesion para crear listas e inicializar tipoServicio en Sesion.
        /// </summary>
        private Sesion()
        {
            tipoServicio = ETipoServicio.Sesion;
            softwareRequerido = new List<Enumerados.ESoftware>();
            perifericosRequeridos = new List<Enumerados.EPerifericos>();
            juegosRequeridos = new List<Enumerados.EJuegos>();
        }

        /// <summary>
        /// Constructor de la clase Sesion, que recibe requerimientos de software, perifericos y juegos.
        /// </summary>
        /// <param name="softwareRequerido"></param>
        /// <param name="perifericosRequeridos"></param>
        /// <param name="juegosRequeridos"></param>
        public Sesion(List<Enumerados.ESoftware> softwareRequerido,
            List<Enumerados.EPerifericos> perifericosRequeridos,
            List<Enumerados.EJuegos> juegosRequeridos)
            : this()
        {
            this.softwareRequerido = softwareRequerido;
            this.perifericosRequeridos = perifericosRequeridos;
            this.juegosRequeridos = juegosRequeridos;
        }

        /// <summary>
        /// Propiedad lectura-escritura tipo sesion
        /// </summary>
        public ETipoSesion TipoSesion
        {
            get
            {
                return tipoSesion;
            }
            set
            {
                this.tipoSesion = value;
            }
        }

        /// <summary>
        /// Propiedad lectura-escritura numeroCopias
        /// </summary>
        public int NumeroCopias
        {
            get
            {
                return numeroCopias;
            }
            set
            {
                this.numeroCopias = value;
            }
        }

        /// <summary>
        /// Propiedad de solo letura SoftwareRequerido
        /// </summary>
        public List<Enumerados.ESoftware> SoftwareRequerido
        {
            get
            {
                return softwareRequerido;
            }
        }

        /// <summary>
        /// Propiedad de solo letura PerifericosRequeridos
        /// </summary>
        public List<Enumerados.EPerifericos> PerifericosRequeridos
        {
            get
            {
                return perifericosRequeridos;
            }
        }

        /// <summary>
        /// Propiedad de solo letura JuegosRequeridos
        /// </summary>
        public List<Enumerados.EJuegos> JuegosRequeridos
        {
            get
            {
                return juegosRequeridos;
            }
        }

        /// <summary>
        /// Propiedad lectura-escritura DuracionServicio
        /// </summary>
        public override int DuracionServicio
        {
            get
            {
                return duracionEnMinutos;
            }
            set
            {
                duracionEnMinutos = value;
            }
        }

        /// <summary>
        /// Sobreescribe la propiedad Costo para sumarle el costo en concepto de copias.
        /// </summary>
        public override float Costo
        {
            get
            {
                return base.Costo + CalcularCostoCopias();
            }
        }


        #region Metodos y sobrecargas

        /// <summary>
        /// Sobreescribe el metodo y calcula el costo de una sesion segun su duracion mas el costo en concepto de copias
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return ((float)Math.Ceiling(DuracionServicio / 30F) * COSTO_BLOQUE_30MIN);
        }

        /// <summary>
        /// Calcula el costo en concepto de copias
        /// </summary>
        /// <returns></returns>
        public float CalcularCostoCopias()
        {
            return numeroCopias * COSTO_IMPRESION;
        }

        /// <summary>
        /// Sobrescribe el metodo EsCompatible para adecuarlo a una Sesion 
        /// (ademas de estar libre, la PC debe cumplir los requerimientos de software, juegos y perifericos)
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns></returns>
        public override bool EsCompatible(Puesto puesto)
        {
            Computadora pc = puesto as Computadora;

            if (pc is not null && base.EsCompatible(pc))
            {
                foreach (Enumerados.ESoftware software in SoftwareRequerido)
                {
                    if (!pc.EstaDisponible(software))
                    {
                        return false;
                    }
                }
                foreach (Enumerados.EJuegos juego in JuegosRequeridos)
                {
                    if (!pc.EstaDisponible(juego))
                    {
                        return false;
                    }
                }
                foreach (Enumerados.EPerifericos periferico in PerifericosRequeridos)
                {
                    if (!pc.EstaDisponible(periferico))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Muestra los requerimientos de la PC, tanto de software, como de juegos y perifericos.
        /// </summary>
        /// <returns>String con info de requerimientos de clientes</returns>
        public string MostrarRequerimientosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Software requerido:");
            foreach (Enumerados.ESoftware software in softwareRequerido)
            {
                sb.AppendLine($"- {software} ");
            }
            sb.AppendLine($"\n Perifericos requeridos:");
            foreach (Enumerados.EPerifericos periferico in perifericosRequeridos)
            {
                sb.AppendLine($"- {periferico} ");
            }
            sb.AppendLine($"\n Juegos requeridos:");
            foreach (Enumerados.EJuegos juego in juegosRequeridos)
            {
                sb.AppendLine($"- {juego} ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra el costo por una sesion, detallando lo gastado en concepto de internet, asi como de copias y el costo final con IVA.
        /// </summary>
        /// <returns>String con info del costo</returns>
        public override string CobrarPorServicio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Servicio internet x {DuracionServicio} min: ${(Costo - CalcularCostoCopias()):N2}");
            if (NumeroCopias > 0)
            {
                sb.AppendLine($"Servicio impresión x {NumeroCopias}: ${CalcularCostoCopias():N2}");
            }
            sb.AppendLine("");
            sb.AppendLine(base.CobrarPorServicio());
            return sb.ToString();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString(), llamando a la sobrescritura de la base, y agregando numero de copias (de existir) y requerimientos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sesión {tipoSesion}\n");
            sb.AppendLine($"{base.ToString()}");
            if (numeroCopias > 0)
            {
                sb.AppendLine($"Numero de copias: {numeroCopias}\n");
            }
            sb.AppendLine(MostrarRequerimientosCliente());
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador ==. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public static bool operator ==(Sesion s1, Sesion s2)
        {
            if (s1 is not null && s2 is not null)
            {
                return s1.GetHashCode() == s2.GetHashCode();
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Devuelve true si los hash code son distintos, false si son iguales</returns>
        public static bool operator !=(Sesion s1, Sesion s2)
        {
            return !(s1 == s2);
        }

        /// <summary>
        /// Sobrescribe el metodo Equals(). Utiliza la sobrecarga del operador == de Sesion.
        /// </summary>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public override bool Equals(Object obj)
        {
            Servicio sesion = obj as Sesion;
            return sesion != null && this == sesion;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode(), reutilizando el método de la base. 
        /// Suma los hash code de la hora inicio, tipo del servicio, duración y tipo de sesion.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() + tipoSesion.GetHashCode();
        }

        #endregion
    }
}