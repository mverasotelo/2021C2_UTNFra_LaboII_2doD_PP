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
            MostrarPuestosCompatibles();
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
        /// Setea el tipo de sesion, asigna la sesion a la PC seleccionada y la duración (si corresponde), 
        /// la marca como ocupada y quita al cliente de la cola
        /// </summary>
        /// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "ASIGNAR")
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

                    foreach (Puesto puesto in Cibercafe.ListarPuestosCompatibles(cliente))
                    {
                        if (puesto.Id == (string)cmbPuestosDisponibles.SelectedItem)
                        {
                            if (Cibercafe.AsignarPuesto(puesto))
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                Cibercafe.EnviarClienteAlFinalDeLaFila();
                this.Close();
            }
        }
    }
}
