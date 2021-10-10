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
    public partial class FormImpresiones : Form
    {

        Puesto puesto;

        public FormImpresiones(Puesto puesto)
        {
            InitializeComponent();
            this.puesto = puesto;
        }

        private void FormImpresiones_Load(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Sesion sesion = (Sesion)puesto.ListaServicios.Last();
            sesion.NumeroCopias = (int)numImpresiones.Value;
            this.Close();
        }
    }
}
