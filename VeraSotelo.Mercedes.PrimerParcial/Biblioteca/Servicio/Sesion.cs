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

        #region Atributos

        private const float COSTO_BLOQUE_30MIN = 0.5F;
        private const float COSTO_IMPRESION = 0.05F;
        private ETipoSesion tipoSesion;
        private List<Enumerados.ESoftware> softwareRequerido;
        private List<Enumerados.EPerifericos> perifericosRequeridos;
        private List<Enumerados.EJuegos> juegosRequeridos;
        private int numeroCopias;

        #endregion

        #region Constructores

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
        /// Constructor de la clase Sesion
        /// </summary>
        /// <param name="tipoSesion"></param>
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

        #endregion

        #region Propiedades

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

        #endregion

        #region Metodos

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

            if(pc is not null && base.EsCompatible(pc))
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
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sesión {tipoSesion}\n");
            sb.AppendLine($"{base.ToString()}");
            if(numeroCopias > 0)
            {
                sb.AppendLine($"Numero de copias: {numeroCopias}\n");
            }
            sb.AppendLine(MostrarRequerimientosCliente());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los requerimientos de la PC
        /// </summary>
        /// <returns></returns>
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
        /// Sobrescribe el metodo string y Muestra el costo por una sesion
        /// </summary>
        /// <returns></returns>
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
        #endregion
    }
}