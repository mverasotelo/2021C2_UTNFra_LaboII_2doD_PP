using Biblioteca;
using System;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngreso : Form
    {

        protected Cliente cliente;

        /// <summary>
        /// Constructor de FormIngreso
        /// </summary>
        protected FormIngreso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIngreso_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Muestra las puestos disponibles que cumplen con los requerimientos del cliente
        /// </summary>
        protected void MostrarPuestosCompatibles()
        {

            if (Cibercafe.ListarPuestosCompatibles().Count > 0)
            {
                foreach (Puesto p in Cibercafe.ListarPuestosCompatibles())
                {
                    cmbPuestosDisponibles.Items.Add(p.Id);
                }
            }
            else
            {
                cmbPuestosDisponibles.Items.Add("No hay puestos disponibles");
                btnIngresar.Text = "ENVIAR AL FINAL";
            }
            cmbPuestosDisponibles.SelectedIndex = 0;
        }

        /// <summary>
        /// Cierra el formulario, cancelando la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}