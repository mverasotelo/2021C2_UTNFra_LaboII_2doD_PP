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
    public partial class FormInformacion : Base
    {
        private Puesto puesto;

        /// <summary>
        /// Constructor privado del FormInformacion
        /// </summary>
        private FormInformacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga del constructor del FormInformacion
        /// </summary>
        public FormInformacion(Puesto puesto)
            :this()
        {
            this.puesto = puesto;
        }


        private void FormInformacion_Load(object sender, EventArgs e)
        {
            this.Text = $"Información Puesto {puesto.Id}";
            this.rctInfo.Text = puesto.ToString();
            if (puesto.Estado == Puesto.EEstado.Ocupado)
            {
                btnLiberar.Visible = true;
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            if(puesto.Estado == Puesto.EEstado.Ocupado)
            {
                Cibercafe.LiberarPuesto(puesto);
                this.Close();
            }
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
