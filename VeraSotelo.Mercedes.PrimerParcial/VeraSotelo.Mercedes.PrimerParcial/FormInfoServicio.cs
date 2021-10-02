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
            rctInfoServicio.Text = $"\n{servicio}";
            lblTiempoUso.Text = $"Tiempo de uso: {servicio.DuracionServicio} minutos";
            lblSaldoBruto.Text = $"Saldo bruto: ${servicio.Costo}";
            lblSaldoIVA.Text = $"Saldo con IVA: ${servicio.AgregarIVA()}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
