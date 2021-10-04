using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteca;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngresoPC : FormIngreso
    {

        private Sesion sesion;

        /// <summary>
        /// Constructor de FormIngresoPC
        /// </summary>
        public FormIngresoPC()
        {
            InitializeComponent();
            cliente = Cibercafe.ClientesEnEspera.Peek();
            sesion = (Sesion)cliente.Servicio;
        }

        /// <summary>
        /// Evento Load. Carga datos del cliente, requerimientos de la sesion y muestra computadoras disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIngresoPC_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text = cliente.ToString();
            rctRequerimientos.Text = sesion.MostrarRequerimientosCliente();
            rbtLibre.Checked = true;
            MostrarComputadorasCompatibles();
        }

        /// <summary>
        /// Muestra un campo para ingresar el tiempo cuando la sesion es fija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtFija_CheckedChanged(object sender, EventArgs e)
        {
            numTiempo.Visible = true;
            lblTiempo.Visible = true;
        }

        /// <summary>
        /// Oculta el campo para ingresar el tiempo cuando la sesion es libre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtLibre_CheckedChanged(object sender, EventArgs e)
        {
            numTiempo.Visible = false;
            lblTiempo.Visible = false;
        }

        /// <summary>
        /// Muestra las computadoras disponibles que cumplen con los requerimientos del cliente
        /// </summary>
        private void MostrarComputadorasCompatibles()
        {
            List<string> computadorasDisponibles = new List<string>();

            foreach (Puesto p in Cibercafe.ListaPuestosDisponibles)
            {
                if (p is Computadora)
                {
                    if (p.Estado == Puesto.EEstado.Disponible)
                    {
                        if (Cibercafe.ChequearRequisitosPC((Sesion)(cliente.Servicio), (Computadora)p))
                        {
                            computadorasDisponibles.Add(p.Id);
                        }
                    }
                }
            }

            if (computadorasDisponibles.Count > 0)
            {
                cmbPuestosDisponibles.DataSource = computadorasDisponibles;

            }
            else
            {
                cmbPuestosDisponibles.Items.Add("No hay computadoras con los requerimientos disponibles");
                cmbPuestosDisponibles.SelectedIndex = 0;
                btnIngresar.Enabled = false;
                btnIngresar.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// Setea el tipo de sesion, asigna la sesion a la PC seleccionada y la duración (si corresponde), 
        /// la marca como ocupada y quita al cliente de la cola
        /// </summary>
        /// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rbtFija.Checked == true && numTiempo.Value % 30 != 0)
            {
                MessageBox.Show("La duración de usa sesión fija debe fijarse en bloques de media hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtLibre.Checked == true)
                {
                    sesion.TipoSesion = Sesion.ETipoSesion.Libre;
                }
                else
                {
                    sesion.DuracionServicio = (int)numTiempo.Value;
                    sesion.TipoSesion = Sesion.ETipoSesion.Fija;
                }

                foreach (Puesto puesto in Cibercafe.ListaPuestosDisponibles)
                {
                    if (puesto.Id == (string)cmbPuestosDisponibles.SelectedItem)
                    {
                        if (Cibercafe.AgregarServicio(puesto, sesion))
                        {
                            this.Close();
                            Cibercafe.ClientesEnEspera.Dequeue();
                        }
                    }
                }
            }
        }
    }
}
