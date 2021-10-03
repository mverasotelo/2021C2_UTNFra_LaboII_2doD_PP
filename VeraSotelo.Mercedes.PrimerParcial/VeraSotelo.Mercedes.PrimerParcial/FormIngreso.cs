using Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngreso : Form
    {

        protected Cliente cliente;

        /// <summary>
        /// Constructor de FormIngreso
        /// </summary>
        public FormIngreso()
        {
            InitializeComponent();
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