using Biblioteca;
using System;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormEstadisticas : Form
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
                    rctEstadisticas.Text = Cibercafe.TiempoYRecaudacionLlamadas();
                    break;
                case 4:
                    rctEstadisticas.Text = Cibercafe.MostrarSoftwareMasPedido();
                    break;
                case 5:
                    rctEstadisticas.Text = Cibercafe.MostrarJuegoMasPedido();
                    break;
                case 6:
                    rctEstadisticas.Text = Cibercafe.MostrarPerifericoMasPedido();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
