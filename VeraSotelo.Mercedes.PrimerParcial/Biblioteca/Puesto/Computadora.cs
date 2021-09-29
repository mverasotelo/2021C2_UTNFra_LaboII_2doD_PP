using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Computadora : Puesto
    {   

        #region Atributos

        private List<Enumerados.ESoftware> softwareInstalado;
        private List<Enumerados.EPerifericos> perifericosDisponibles;
        private List<Enumerados.EJuegos> juegosDisponibles;
        private Dictionary<string, string> especificacionesHardware;
        private List<Sesion> listaDeSesiones;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor privado de Computadora
        /// </summary>
        private Computadora(string identificador)
            :base(identificador)
        {
            softwareInstalado = new List<Enumerados.ESoftware>();
            perifericosDisponibles = new List<Enumerados.EPerifericos>();
            juegosDisponibles = new List<Enumerados.EJuegos>();
            especificacionesHardware = new Dictionary<string, string>();
            listaDeSesiones = new List<Sesion>();
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
            :this(identificador)
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
        public int MinutosDeUso
        {
            get
            {
                return CalcularMinutosDeUso();
            }
        }

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

        #region Metodos

        /// <summary>
        /// Sobrescribe el metodo abstracto CalcularMinutosDeUso()
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected override int CalcularMinutosDeUso()
        {
            int usoTotal = 0;

            if(listaDeSesiones.Count > 0)
            {
                foreach (Sesion sesion in listaDeSesiones)
                {
                    usoTotal += sesion.DuracionServicio;
                }
            }

            return usoTotal;
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" COMPUTADORA {identificador.ToUpper()}\n");

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
            sb.AppendLine($"\n Minutos de uso: {MinutosDeUso}");

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Chequea que un software este instalado en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Enumerados.ESoftware s)
        {
            if(c.SoftwareInstalado.Count > 0)
            {
                foreach(Enumerados.ESoftware software in c.SoftwareInstalado)
                {
                    if(software == s)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Chequea que un software NO este instalado en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Enumerados.ESoftware s)
        {
            return !(c == s);
        }

        /// <summary>
        /// Chequea que un software este instalado en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Enumerados.EJuegos j)
        {
            if (c.JuegosDisponibles.Count > 0)
            {
                foreach (Enumerados.EJuegos juego in c.JuegosDisponibles)
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
        /// Chequea que un software NO este instalado en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Enumerados.EJuegos j)
        {
            return !(c == j);
        }

        /// <summary>
        /// Chequea que un periferico este disponible en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Enumerados.EPerifericos p)
        {
            if (c.PerifericosDisponibles.Count > 0)
            {
                foreach (Enumerados.EPerifericos periferico in c.PerifericosDisponibles)
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
        /// Chequea que un periferico NO este disponible en una PC
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Enumerados.EPerifericos p)
        {
            return !(c == p);
        }

        #endregion
    }
}
