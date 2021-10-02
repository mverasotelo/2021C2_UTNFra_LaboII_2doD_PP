using Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngreso : Form
    {

        /// <summary>
        /// Constructor de FormIngreso
        /// </summary>
        public FormIngreso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar el formulario, muestra info del cliente, del servicio requerido 
        /// y los puestos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Ingreso_Load(object sender, EventArgs e)
        {
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