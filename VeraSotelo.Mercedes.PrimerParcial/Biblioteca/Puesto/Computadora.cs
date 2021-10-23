using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public sealed class Computadora : Puesto
    {

        private List<Enumerados.ESoftware> softwareInstalado;
        private List<Enumerados.EPerifericos> perifericosDisponibles;
        private List<Enumerados.EJuegos> juegosDisponibles;
        private Dictionary<string, string> especificacionesHardware;

        /// <summary>
        /// Constructor privado de Computadora que crea las listas de software, juegos y perifericos y el diccionario de especificaciones de hardware.
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
        /// Constructor publico de Computadora, recibe identificados, listas de software, juegos y perifericos y el diccionario de especificaciones de hardware.
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

        /// <summary>
        /// Propiedad solo lectura de software instalado
        /// </summary>
        public List<Enumerados.ESoftware> SoftwareInstalado
        {
            get
            {
                return softwareInstalado;
            }
        }

        /// <summary>
        /// Propiedad solo lectura de perofericos disponibles
        /// </summary>
        public List<Enumerados.EPerifericos> PerifericosDisponibles
        {
            get
            {
                return perifericosDisponibles;
            }
        }

        /// <summary>
        /// Propiedad solo lectura de juegos instalados
        /// </summary>
        public List<Enumerados.EJuegos> JuegosDisponibles
        {
            get
            {
                return juegosDisponibles;
            }
        }


        #region Métodos y sobrecargas

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
        /// Sobrescribe el metodo ToString(), reutilizando la versiond de la clase y agregando informacion sobre la computadora
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
        /// Sobrecarga del operador ==. Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Devuelve true si los hash code son iguales, false si son distintos</returns>
        public static bool operator ==(Computadora c1, Computadora c2)
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
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Devuelve true si los hash code son distintos, false si son iguales</returns>
        public static bool operator !=(Computadora c1, Computadora c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobreescribe Equals(), reutilizando la sobrecarga del operador == de Computadora. 
        /// Compara que el Hash code de ambas sesiones sean iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si los identificadores son iguales, false si no</returns>
        public override bool Equals(object obj)
        {
            Computadora computadora = obj as Computadora;
            return computadora != null && this == computadora;
        }

        /// <summary>
        /// Sobreescribe GetHashCode() usando el de la clase base Puesto y comparando tambien segun las especificaciones del hardware.
        /// </summary>
        /// <returns>nuevo hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() + especificacionesHardware.GetHashCode();
        }
        
        #endregion
    }
}
