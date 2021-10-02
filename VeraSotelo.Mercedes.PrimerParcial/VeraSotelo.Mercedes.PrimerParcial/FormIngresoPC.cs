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
    public partial class FormIngresoPC : FormIngreso
    {


        public FormIngresoPC()
        {
            InitializeComponent();
            cliente = Cibercafe.ClientesEnEspera.Peek();
        }

        private void FormIngresoPC_Load(object sender, EventArgs e)
        {
            Sesion sesion = (Sesion)cliente.Servicio;
            lblDatosCliente.Text = $"{cliente}";
            rctRequerimientos.Text = sesion.MostrarRequerimientosCliente();
            MostrarComputadorasCompatibles();
        }

        private void MostrarComputadorasCompatibles()
        {
            List<string> computadorasDisponibles = new List<string>();

            foreach (Puesto p in Cibercafe.ListaPuestosDisponibles)
            {
                if (p is Computadora)
                {
                    if (p.Estado == Puesto.EEstado.Disponible)
                    {
                        if (Cibercafe.ChequearRequisitosPC((Sesion)(cliente.Servicio), (Computadora)p))
                        {
                            computadorasDisponibles.Add(p.Id);
                        }
                    }
                }
            }

            if (computadorasDisponibles.Count > 0)
            {
                cmbPuestosDisponibles.DataSource = computadorasDisponibles;

            }
            else
            {
                cmbPuestosDisponibles.Items.Add("No hay computadoras con los requerimientos disponibles");
                cmbPuestosDisponibles.SelectedIndex = 0;
                btnIngresar.Enabled = false;
                btnIngresar.BackColor = Color.Gray;
            }
        }
    }
}
