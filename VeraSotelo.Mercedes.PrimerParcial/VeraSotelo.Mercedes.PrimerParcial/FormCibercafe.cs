using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormCibercafe : Base
    {
        public FormCibercafe()
        {
            InitializeComponent();

        }

        private void FormCibercafe_Load(object sender, EventArgs e)
        {

            //Agregar puestos al Cibercafé
            List<Puesto> listaPuestos = new List<Puesto>()
            {
                //cabinas
                new Cabina("T01", Cabina.ETipoTelefono.ConTeclado, "Siemens"),
                new Cabina("T02", Cabina.ETipoTelefono.ADisco, "Panasonic"),
                new Cabina("T03", Cabina.ETipoTelefono.ConTeclado, "Philips"),
                new Cabina("T04", Cabina.ETipoTelefono.ADisco, "Panasonic"),
                new Cabina("T05", Cabina.ETipoTelefono.ConTeclado, "Panasonic"),
                
                //computadoras
                new Computadora("C01",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Microfono},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.AgeOfEmpiresII, Enumerados.EJuegos.MuOnline},
                new Dictionary<string,string>{ {"RAM","4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video", "486 DLC" }}),
                
                new Computadora("C02",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Messenger },
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video", "Geforce 4" }}),

                new Computadora("C03",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Ares },
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video", "9600GT" } }),

                new Computadora("C04",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","2GB"}, {"Procesador","Intel Pentium"}, {"Placa de video", "486 DLC" } }),

                new Computadora("C05",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","1GB"}, {"Procesador", "Intel 4004" }, {"Placa de video", "9600GT" } }),

                new Computadora("C06",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Microfono},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.AgeOfEmpiresII, Enumerados.EJuegos.MuOnline},
                new Dictionary<string,string>{ {"RAM","4GB"}, {"Procesador","Intel Pentium 4"}, {"Placa de video", "486 DLC" }}),

                new Computadora("C07",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Messenger,Enumerados.ESoftware.Winamp},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Auriculares},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","2GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video", "Geforce 4" } }),

                new Computadora("C08",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","4GB"}, {"Procesador","Intel Pentium 2"}, {"Placa de video", "9600GT" } }),

                new Computadora("C09",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Messenger},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.MuOnline},
                new Dictionary<string,string>{ {"RAM","2GB"}, {"Procesador","Intel Pentium"}, {"Placa de video", "486 DLC" } }),

                new Computadora("C10",
                new List<Enumerados.ESoftware>(){ Enumerados.ESoftware.Office, Enumerados.ESoftware.Office},
                new List<Enumerados.EPerifericos>(){ Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick},
                new List<Enumerados.EJuegos>(){ Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.CounterStrike},
                new Dictionary<string,string>{ {"RAM","1GB"}, {"Procesador", "Intel 4004" }, {"Placa de video", "9600GT" } }),
            };

            foreach(Puesto p in listaPuestos)
            {
                Cibercafe.AgregarPuesto(p);
            }

            Cibercafe.ListaPuestos[1].Estado = Puesto.EEstado.Ocupado;
            Cibercafe.ListaPuestos[5].Estado = Puesto.EEstado.Ocupado;
            Cibercafe.ListaPuestos[7].Estado = Puesto.EEstado.Ocupado;
            Cibercafe.ListaPuestos[4].Estado = Puesto.EEstado.Ocupado;
            ActualizarEstadoPuestos();


            //Agrega clientes
            Cliente c1 = new Cliente(34398757, "Mercedes", "Vera", 32);
            Cliente c2 = new Cliente(12345678, "Juan", "Perez", 50);
            Cliente c3 = new Cliente(23456789, "Raul", "Garcia", 41);
            Cliente c4 = new Cliente(34567890, "Alicia", "Sotelo", 35);
            Cliente c5 = new Cliente(41123456, "Julian", "Meroni", 18);

            //Agrega servicios a los clientes
            c1 += new Sesion(Sesion.ETipoSesion.Libre,
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono },
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike });
            c2 += new Llamada(34, 567, 1234567);
            c3 += new Llamada(54, 351, 56565415);
            c4 += new Sesion(Sesion.ETipoSesion.Libre,
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Microfono, Enumerados.EPerifericos.Microfono },
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.MuOnline });
            c5 += new Sesion(Sesion.ETipoSesion.Libre,
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Joystick, Enumerados.EPerifericos.Microfono },
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.LineageII, Enumerados.EJuegos.CounterStrike });


            Cibercafe.IngresarCliente(c1);
            Cibercafe.IngresarCliente(c2);
            Cibercafe.IngresarCliente(c3);
            Cibercafe.IngresarCliente(c4);
            Cibercafe.IngresarCliente(c5);


            ActualizarListadoClientes();

        }

        private void ActualizarListadoClientes()
        {
            lstCliente.Items.Clear();
            foreach (Cliente c in Cibercafe.ClientesEnEspera)
            {
                lstCliente.Items.Add(c.ToString());
            }
        }

        private void ActualizarEstadoPuestos()
        {
            for (int i = 0; i < gpbPuestos.Controls.Count; i++)
            {
                if (gpbPuestos.Controls[i] is Label)
                {
                    foreach (Puesto p in Cibercafe.ListaPuestos)
                    {
                        if (gpbPuestos.Controls[i].Text == p.Id)
                        {
                            if(p.Estado == Puesto.EEstado.Disponible)
                            {
                                gpbPuestos.Controls[i].BackColor = Color.DarkSeaGreen;
                            }
                            else
                            {
                                gpbPuestos.Controls[i].BackColor = Color.DarkSalmon;
                            }
                        }
                    }
                }
            }
        }

        #region Eventos
        /// <summary>
        /// Pide confirmacion para salir cuando se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCibercafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Escuchador de eventos del evento click del boton Estadisticas. Muestra de forma no modal un Form con estadisticas historicas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas f = new FormEstadisticas();
            f.Show();
        }

       /// <summary>
       /// Muestra información del usuario
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void lstCliente_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((ListBox)sender).SelectedItem.ToString());
        }

        /// <summary>
        /// Muestra la informacion del puesto al hacer click en el
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPuesto_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Cibercafe.ListaPuestos.Count; i++)
            {
                if (((Label)sender).Text == Cibercafe.ListaPuestos[i].Id)
                {
                    Puesto p = Cibercafe.ListaPuestos[i];
                    FormInformacion frmInfo = new FormInformacion();
                    frmInfo.Text = $"Información Puesto {p.Id}";
                    frmInfo.rctInfo.Text = p.ToString();
                    frmInfo.Show();
                }
            }
        }

        /// <summary>
        /// Abre una FormIngreso para asignar un puesto al cliente de acuerdo a sus requerimientos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {

            if (Cibercafe.ClientesEnEspera.Count > 0)
            {
                Cliente cliente = Cibercafe.ClientesEnEspera.Peek();
                FormIngreso frmIngreso = new FormIngreso(cliente);
                frmIngreso.Show();
            }
        }
        #endregion
        /// <summary>
        /// Actualiza el estado de los puestos y la lista de clientes una vez que el form vuelve a tomar foco 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCibercafe_Activated(object sender, EventArgs e)
        {
            ActualizarEstadoPuestos(); 
            ActualizarListadoClientes();
        }
    }
}
