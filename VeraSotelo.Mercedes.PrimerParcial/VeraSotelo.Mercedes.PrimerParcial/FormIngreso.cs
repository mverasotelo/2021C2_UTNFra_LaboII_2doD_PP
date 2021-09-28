using System;
using Biblioteca;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngreso : Base
    {
        protected Cliente cliente;

        /// <summary>
        /// Constructor del FormIngreso
        /// </summary>
        public FormIngreso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga del constructor del FormIngreso
        /// </summary>
        /// <param name="cliente"></param>
        public FormIngreso(Cliente cliente)
            :this()
        {
            this.cliente = cliente;
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            this.lblDatosCliente.Text = $"{cliente.ToString()}";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
