﻿using Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormCibercafe : Form
    {
        /// <summary>
        /// Constructor de FormCibercafe
        /// </summary>
        public FormCibercafe()
        {
            InitializeComponent();

        }

        #region Eventos

        /// <summary>
        /// Evento load. Agrega puestos y clientes al cibercafe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCibercafe_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //Agregar puestos al cibercafé
            List<Puesto> listaPuestos = new()
            {
                //cabinas
                new Cabina("T01", Cabina.ETipoTelefono.ConTeclado, "Siemens"),
                new Cabina("T02", Cabina.ETipoTelefono.ADisco, "Panasonic"),
                new Cabina("T03", Cabina.ETipoTelefono.ConTeclado, "Philips"),
                new Cabina("T04", Cabina.ETipoTelefono.ADisco, "Panasonic"),
                new Cabina("T05", Cabina.ETipoTelefono.ConTeclado, "Panasonic"),


                //computadoras
                new Computadora("C01",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Impresora },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.AgeOfEmpiresII, Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.TheSims},
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { {Enumerados.EEspecificacionesHardware.RAM, "4GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 4" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "486 DLC" } }),

                new Computadora("C02",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono, Enumerados.EPerifericos.Impresora },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "2GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 2" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "Geforce 4" } }),

                new Computadora("C03",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "4GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 2" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "9600GT" } }),

                new Computadora("C04",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick, Enumerados.EPerifericos.Impresora },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.CounterStrike, Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.TheSims },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "2GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "486 DLC" } }),

                new Computadora("C05",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.AgeOfEmpiresII, Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "1GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel 4004" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "9600GT" } }),

                new Computadora("C06",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Microfono, Enumerados.EPerifericos.Impresora },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.AgeOfEmpiresII, Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.TheSims},
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "4GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 4" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "486 DLC" } }),

                new Computadora("C07",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Messenger, Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "2GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 2" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "Geforce 4" } }),

                new Computadora("C08",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono, Enumerados.EPerifericos.Joystick, Enumerados.EPerifericos.Camara },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "4GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium 2" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "9600GT" } }),

                new Computadora("C09",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Messenger, Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.MuOnline },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "2GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel Pentium" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "486 DLC" } }),

                new Computadora("C10",
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Office, Enumerados.ESoftware.Office, Enumerados.ESoftware.Ares, Enumerados.ESoftware.Office, },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick, Enumerados.EPerifericos.Impresora, Enumerados.EPerifericos.Microfono },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.CounterStrike },
                new Dictionary<Enumerados.EEspecificacionesHardware, string> { { Enumerados.EEspecificacionesHardware.RAM, "1GB" }, { Enumerados.EEspecificacionesHardware.Procesador, "Intel 4004" }, { Enumerados.EEspecificacionesHardware.PlacaVideo, "9600GT" } }),
            };

            foreach (Puesto p in listaPuestos)
            {
                Cibercafe.AgregarPuesto(p);
            }

            //Agregar servicios anteriores para simulacion estadisticas

            List<Servicio> listaSesiones = new()
            {
                new Sesion(
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Messenger, Enumerados.ESoftware.ICQ },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Impresora, Enumerados.EPerifericos.Auriculares },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.DiabloII }),

                new Sesion(
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.Office },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Camara },
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.LineageII, Enumerados.EJuegos.WarcraftIII }),

                new Sesion(
                new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.Winamp },
                new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara, Enumerados.EPerifericos.Joystick},
                new List<Enumerados.EJuegos>() { Enumerados.EJuegos.MuOnline, Enumerados.EJuegos.CounterStrike }),

                new Llamada("54","11","3232323"),
                new Llamada("65","565","56565656"),
                new Llamada("54","351","454545")
                };

            Random random = new Random();

            foreach (Servicio s in listaSesiones)
            {
                int duracion = random.Next(1, 60);
                if (s is Sesion)
                {
                    int pc = random.Next(0, 9);
                    s.DuracionServicio = duracion;
                    Cibercafe.ListaPuestos[pc].ListaServicios.Add(s);
                }
                else
                {
                    int cabina = random.Next(10, 14);
                    s.DuracionServicio = duracion;
                    Cibercafe.ListaPuestos[cabina].ListaServicios.Add(s);
                }
            }

            //Agregar clientes en espera al cibercafé
            List<Cliente> listaClientes = new()
            {
            new Cliente(34398757, "Mercedes", "Vera", 32, new Sesion(
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Auriculares, Enumerados.EPerifericos.Microfono},
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.CounterStrike })),

            new Cliente(41123456, "Julian", "Gonzalez", 18, new Sesion(
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Winamp, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Camara },
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.CounterStrike })),

            new Cliente(23456789, "Raul", "Garcia", 41, new Llamada("54", "11", "35556565")),

            new Cliente(34567890, "Alicia", "Sotelo", 35, new Sesion(
            new List<Enumerados.ESoftware>() { Enumerados.ESoftware.Ares, Enumerados.ESoftware.ICQ },
            new List<Enumerados.EPerifericos>() { Enumerados.EPerifericos.Microfono, Enumerados.EPerifericos.Impresora},
            new List<Enumerados.EJuegos>() { Enumerados.EJuegos.TheSims, Enumerados.EJuegos.MuOnline })),

            new Cliente(12345678, "Juan", "Perez", 50, new Llamada())
            };

            foreach (Cliente c in listaClientes)
            {
                Cibercafe.IngresarCliente(c);
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
        /// Muestra la informacion del puesto al hacer click en él
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
                    FormInfoPuesto frmInfo = new FormInfoPuesto(p);
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
            FormIngreso frmIngreso;
            if (Cibercafe.ClientesEnEspera.Count > 0)
            {
                Cliente c = Cibercafe.ClientesEnEspera.Peek();
                if (c.Servicio is Llamada)
                {
                    frmIngreso = new FormIngresoLlamada();
                }
                else
                {
                    frmIngreso = new FormIngresoPC();
                }

                frmIngreso.Show();
            }
        }

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
        /// Cierra el programa, pidiendo confirmación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Muestra un MessageBox explicando la funcionalidad del formulario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Muestra la lista de clientes en espera\n- Muestra los puestos del cibercafé, indicando su disponibilidad\n- Se puede acceder a las estadísticas históricas del local", "Ayuda");
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Actualiza el listado de clientes 
        /// </summary>
        internal void ActualizarListadoClientes()
        {
            lstCliente.Items.Clear();
            foreach (Cliente c in Cibercafe.ClientesEnEspera)
            {
                lstCliente.Items.Add(c.ToString());
            }
        }

        /// <summary>
        /// Actualiza listado puestos asignandole el color rojo si esta ocupado y verde si esta disponible
        /// </summary>
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
                            if (p.Estado == Puesto.EEstado.Disponible)
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

        #endregion
    }
}
