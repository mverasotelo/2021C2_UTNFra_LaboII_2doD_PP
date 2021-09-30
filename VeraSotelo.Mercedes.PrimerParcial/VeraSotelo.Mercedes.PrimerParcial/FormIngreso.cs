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
    public partial class FormIngreso : Base
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
        /// Sobrecarga del constructor del FormIngreso
        /// </summary>
        /// <param name="cliente"></param>
        public FormIngreso(Cliente cliente)
            :this()
        {
            this.cliente = cliente;
        }

        /// <summary>
        /// Al cargar el formulario, muestra info del cliente, del servicio requerido 
        /// y los puestos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ingreso_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text = $"{cliente.ToString()}";
            rctInfoSesion.Text = cliente.Servicio.ToString();
            MostrarPuestosDisponibles();
        }


        /// <summary>
        /// Muestra puestos disponibles en un combobox, filtrando por puesto disponible 
        /// y segun los requerimientos del cliente. Si no hay puestos disponibles, deshabilita el boton 
        /// AsignarPuesto
        /// </summary>
        private void MostrarPuestosDisponibles()
        {
            List<string> puestosDisponibles = new List<string>();

            foreach (Puesto p in Cibercafe.ListaPuestosDisponibles)
            {
                if (cliente.Servicio is Llamada)
                {
                    if (p is Cabina)
                    {
                        puestosDisponibles.Add(p.Id);

                    }
                }
                else
                {
                    if(p is Computadora)
                    {
                        if (Cibercafe.ChequearRequisitosPC((Sesion)(cliente.Servicio), (Computadora)p))
                        {
                            puestosDisponibles.Add(p.Id);
                        }
                    }
                }
            }

            if (puestosDisponibles.Count > 0)
            {
                cmbPuestosDisponibles.DataSource = puestosDisponibles;
            }
            else
            {
                cmbPuestosDisponibles.Items.Add("No hay puestos disponibles");
                cmbPuestosDisponibles.SelectedIndex = 0;
                btnAsignarPuesto.Enabled = false;
                btnAsignarPuesto.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// Asigna un puesto al usuario, lo marca como ocupado y quita al cliente de la cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach(Puesto puesto in Cibercafe.ListaPuestosDisponibles)
            {
                if(puesto.Id == (string)cmbPuestosDisponibles.SelectedItem)
                {
                    if(Cibercafe.AgregarServicio(puesto, cliente.Servicio))
                    {
                        puesto.Estado = Puesto.EEstado.Ocupado;
                        Cibercafe.ClientesEnEspera.Dequeue();
                    }
                }
            }
            this.Close();
        }

        /// <summary>
        /// Cierra el formulario, cancelando la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
