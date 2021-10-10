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

        private void FormInfoServicio_Load(object sender, EventArgs e)
        {
            rctInfoServicio.Text = $"{servicio}";
            if(servicio is Sesion && ((Sesion)servicio).NumeroCopias>0)
            {
                lblCopias.Visible = true;
                lblCopias.Text = $"{((Sesion)servicio).NumeroCopias} copias (${((Sesion)servicio).CalcularCostoCopias():N2})";
            }
            lblTiempoUso.Text = $"{servicio.DuracionServicio} minutos de uso";
            lblSaldoBruto.Text += $" ${(servicio.Costo):N2}";
            lblSaldoIVA.Text += $" ${(servicio.AgregarIVA()):N2}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
