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
            lblDatosCliente.Text = $"{cliente.ToString()}";
            rctInfoSesion.Text = cliente.Servicio.ToString();
            MostrarPuestosDisponibles();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Muestra puestos disponibles en un combobox, filtrando por puesto disponible
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
            cmbPuestosDisponibles.DataSource = puestosDisponibles;
        }
    }
}
