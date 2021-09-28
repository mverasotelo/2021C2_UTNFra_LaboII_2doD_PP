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
        /// Constructor de Computadora
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

    public Computadora(string identificador, List<Enumerados.ESoftware> softwareInstalado, List<Enumerados.EPerifericos> perifericosDisponibles, List<Enumerados.EJuegos> juegosDisponibles, Dictionary<string, string> especificacionesHardware) 
            :this(identificador)
        {
            this.identificador = identificador;
            this.tipo = ETipo.Computadora;
            this.softwareInstalado = softwareInstalado;
            this.perifericosDisponibles = perifericosDisponibles;
            this.juegosDisponibles = juegosDisponibles;
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

        /// <summary>
        /// Lectura/Escritura = Para establecer la duracion de una llamada una vez finalizada 
        /// </summary>

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

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" COMPUTADORA {identificador.ToUpper()}\n");
            sb.AppendLine($" Software Instalado:");
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
    }
}
