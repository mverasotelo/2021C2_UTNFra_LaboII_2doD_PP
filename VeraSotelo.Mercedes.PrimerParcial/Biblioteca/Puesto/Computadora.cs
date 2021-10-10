using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public sealed class Computadora : Puesto
    {
        #region Atributos

        private List<Enumerados.ESoftware> softwareInstalado;
        private List<Enumerados.EPerifericos> perifericosDisponibles;
        private List<Enumerados.EJuegos> juegosDisponibles;
        private Dictionary<string, string> especificacionesHardware;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor privado de Computadora
        /// </summary>
        private Computadora(string identificador)
            : base(identificador)
        {
            softwareInstalado = new List<Enumerados.ESoftware>();
            perifericosDisponibles = new List<Enumerados.EPerifericos>();
            juegosDisponibles = new List<Enumerados.EJuegos>();
            especificacionesHardware = new Dictionary<string, string>();
        }

        /// <summary>
        /// Constructor publico de Computadora
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="softwareInstalado"></param>
        /// <param name="perifericosDisponibles"></param>
        /// <param name="juegosDisponibles"></param>
        /// <param name="especificacionesHardware"></param>
        public Computadora(string identificador, List<Enumerados.ESoftware> softwareInstalado,
        List<Enumerados.EPerifericos> perifericosDisponibles, List<Enumerados.EJuegos> juegosDisponibles,
        Dictionary<string, string> especificacionesHardware)
            : this(identificador)
        {
            this.identificador = identificador;
            this.tipo = ETipo.Computadora;
            this.softwareInstalado = softwareInstalado;
            this.perifericosDisponibles = perifericosDisponibles;
            this.juegosDisponibles = juegosDisponibles;
            this.especificacionesHardware = especificacionesHardware;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Enumerados.ESoftware> SoftwareInstalado
        {
            get
            {
                return softwareInstalado;
            }
        }

        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Enumerados.EPerifericos> PerifericosDisponibles
        {
            get
            {
                return perifericosDisponibles;
            }
        }

        /// <summary>
        /// Solo lectura
        /// </summary>
        public List<Enumerados.EJuegos> JuegosDisponibles
        {
            get
            {
                return juegosDisponibles;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Chequea que un software este instalado en una PC
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool EstaDisponible(Enumerados.ESoftware s)
        {
            if (SoftwareInstalado.Count > 0)
            {
                foreach (Enumerados.ESoftware software in SoftwareInstalado)
                {
                    if (software == s)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Chequea que un software este instalado en una PC
        /// </summary>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool EstaDisponible(Enumerados.EJuegos j)
        {
            if (JuegosDisponibles.Count > 0)
            {
                foreach (Enumerados.EJuegos juego in JuegosDisponibles)
                {
                    if (juego == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Chequea que un periferico este disponible en una PC
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool EstaDisponible(Enumerados.EPerifericos p)
        {
            if (PerifericosDisponibles.Count > 0)
            {
                foreach (Enumerados.EPerifericos periferico in PerifericosDisponibles)
                {
                    if (periferico == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns>Información de la computadora</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($"Especificaciones de Hardware:");
            foreach (KeyValuePair<string, string> e in especificacionesHardware)
            {
                sb.AppendLine($"- {e.Key}: {e.Value}");
            }

            sb.AppendLine($"\nSoftware Instalado:");
            foreach (Enumerados.ESoftware software in softwareInstalado)
            {
                sb.AppendLine($"- {software} ");
            }
            sb.AppendLine($"\n Perifericos Disponibles:");
            foreach (Enumerados.EPerifericos periferico in perifericosDisponibles)
            {
                sb.AppendLine($"- {periferico} ");
            }
            sb.AppendLine($"\n Juegos Disponibles:");
            foreach (Enumerados.EJuegos juego in juegosDisponibles)
            {
                sb.AppendLine($"- {juego} ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescribe Equals() usando el método de la clase base Puesto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si los identificadores son iguales, false si no</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Sobreescribe GetHashCode() usando el de la clase base Puesto
        /// </summary>
        /// <returns>HashCode generado a partir del identificador</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
