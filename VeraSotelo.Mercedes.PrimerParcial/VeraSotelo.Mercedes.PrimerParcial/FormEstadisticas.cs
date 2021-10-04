using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormEstadisticas : Base
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            switch (cmbEstadisticas.SelectedIndex)
            {
                case 0:
                    rctEstadisticas.Text = Cibercafe.MostrarPuestosPorMinutosDeUso(Puesto.ETipo.Computadora);
                    break;
                case 1:
                    rctEstadisticas.Text = Cibercafe.MostrarPuestosPorMinutosDeUso(Puesto.ETipo.Cabina);
                    break;
                case 2:
                    rctEstadisticas.Text = Cibercafe.CalcularGananciasTotales();
                    break;
                case 3:
                    rctEstadisticas.Text = ""; //falta
                    break;
                case 4:
                    rctEstadisticas.Text = ""; //falta
                    break;
                case 5:
                    rctEstadisticas.Text = ""; //falta
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
