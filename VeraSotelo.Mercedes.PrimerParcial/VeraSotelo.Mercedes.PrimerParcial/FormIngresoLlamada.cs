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
using FluentValidation;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngresoLlamada : FormIngreso
    {
        private Llamada llamada;

        /// <summary>
        /// Constructor del FormIngresoLlamada.
        /// </summary>
        public FormIngresoLlamada()
        {
            InitializeComponent();
            cliente = Cibercafe.ClientesEnEspera.Peek();
            llamada = (Llamada)cliente.Servicio;
        }

        /// <summary>
        /// Evento load. Muestra puestos disponibles y los datos del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IngresoLlamada_Load(object sender, EventArgs e)
        {
            MostrarPuestosCompatibles();
            lblDatosCliente.Text = cliente.ToString();
        }

        /// <summary>
        /// Asigna la llamada a la cabina seleccionada, la marca como ocupado y quita al cliente de la cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            llamada.CodigoPais = txtCodigoPais.Text;
            llamada.PrefijoLocalidad = txtPrefijo.Text;
            llamada.Numero = txtNumero.Text;

            ValidadorLlamada validator = new ValidadorLlamada();
            if (!(validator.Validate(llamada)).IsValid)
            {
                StringBuilder errores = new StringBuilder();

                foreach(var error in (validator.Validate(llamada)).Errors)
                {
                    errores.AppendLine($"- {error.ErrorMessage}");
                }

                MessageBox.Show(errores.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Puesto puesto in Cibercafe.ListarPuestosCompatibles())
                {
                    if (puesto.Id == (string)cmbPuestosDisponibles.SelectedItem)
                    {
                        if (Cibercafe.AsignarPuesto(puesto, Cibercafe.ClientesEnEspera.Peek().Servicio))
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
