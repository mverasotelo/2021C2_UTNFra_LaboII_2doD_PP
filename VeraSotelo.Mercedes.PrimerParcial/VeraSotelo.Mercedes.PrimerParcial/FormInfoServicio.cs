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
    public partial class FormInfoServicio : Form
    {

        private Servicio servicio;

        public FormInfoServicio()
        {
            InitializeComponent();
        }

        public FormInfoServicio(Servicio servicio)
            :this()
        {
            this.servicio = servicio;
        }

        /// <summary>
        /// Muestra información del servicio y el monto a pagar por conceptos y total con IVA.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInfoServicio_Load(object sender, EventArgs e)
        {
            rctInfoServicio.Text = $"{servicio}";
            lblFactura.Text = $"{servicio.CobrarPorServicio()}";
        }

        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
