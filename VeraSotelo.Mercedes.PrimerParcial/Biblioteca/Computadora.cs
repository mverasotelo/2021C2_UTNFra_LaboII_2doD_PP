using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Computadora : Servicio
    {
        #region Enumerados
        public enum ESoftware
        {
            Office, Messenger, ICQ, Ares, Winamp
        }

        public enum EPerifericos
        {
            Camara, Auriculares, Microfono, Joystick
        }

        public enum EJuegos
        {
            CounterStrike, DiabloII, MuOnline, LineageII, WarcraftIII, AgeOfEmpiresII, TheSims
        }
        #endregion

        #region Atributos

        private List<ESoftware> softwareInstalado;
        private List<EPerifericos> perifericosDisponibles;
        private List<EJuegos> juegosDisponibles;

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor de Computadora
        /// </summary>
        private Computadora()
            :base()
        {
            softwareInstalado = new List<ESoftware>();
            perifericosDisponibles = new List<EPerifericos>();
            juegosDisponibles = new List<EJuegos>();
        }

        /// <summary>
        /// Sobrecarga del constructor de Computadora
        /// </summary>
        /// <param name="identificador"></param>
        public Computadora(string identificador) 
            :this()
        {
            this.identificador = identificador;
            this.tipo = ETipo.Computadora;
        }
        #endregion

        public int MinutosDeUso
        {
            get
            {
                return CalcularMinutosDeUso();
            }
        }


        #region Metodos

        /// <summary>
        /// Sobrescribe el metodo abstracto CalcularMinutosDeUso()
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected override int CalcularMinutosDeUso()
        {
            int usoTotal = 0;

            //foreach (Sesion sesion in listaDeSesiones)
            //{
            //    usoTotal += sesion.DuracionSesion;
            //}

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

            sb.AppendLine($" CABINA {identificador.ToUpper()}");
            sb.AppendLine($" Software Instalado:");
            foreach(ESoftware software in softwareInstalado)
            {
                sb.AppendLine($"- {software}");
            }
            sb.Append($" Software Instalado:");
            foreach (ESoftware software in softwareInstalado)
            {
                sb.Append($"{software} ");
            }
            sb.Append($" Perifericos Disponibles:");
            foreach (EPerifericos periferico in perifericosDisponibles)
            {
                sb.Append($"{periferico} ");
            }
            sb.Append($" Juegos Disponibles:");
            foreach (EJuegos juego in juegosDisponibles)
            {
                sb.Append($"{juego} ");
            }
            sb.AppendLine($" Minutos de uso:{MinutosDeUso}");
            sb.AppendLine("====================================");

            return sb.ToString();
        }

        #endregion
    }
}
