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
    public partial class FormCibercafe : System.Windows.Forms.Form
    {
        public FormCibercafe()
        {
            InitializeComponent();

        }

        private void FormCibercafe_Load(object sender, EventArgs e)
        {
            Cibercafe elVicio = new Cibercafe();

            //Agrega clientes
            Cliente c1 = new Cliente(34398757, "Mercedes", "Vera", 32);
            Cliente c2 = new Cliente(12345678, "Juan", "Perez", 50);
            Cliente c3 = new Cliente(23456789, "Raul", "Garcia", 41);
            Cliente c4 = new Cliente(34567890, "Alicia", "Sotelo", 35);
            Cliente c5 = new Cliente(41123456, "Julian", "Meroni", 18);

            elVicio += c1;
            elVicio += c2;
            elVicio += c3;
            elVicio += c4;
            elVicio += c5;

            foreach (Cliente c in elVicio.ClientesEnEspera)
            {
                lstCliente.Items.Add(c.ToString());
            }

            //Agrega computadoras
            Computadora pc1 = new Computadora("C01");
            Computadora pc2 = new Computadora("C02");
            Computadora pc3 = new Computadora("C03");
            Computadora pc4 = new Computadora("C04");
            Computadora pc5 = new Computadora("C05");
            Computadora pc6 = new Computadora("C06");
            Computadora pc7 = new Computadora("C07");
            Computadora pc8 = new Computadora("C08");
            Computadora pc9 = new Computadora("C09");
            Computadora pc10 = new Computadora("C10");
            elVicio += pc1;
            elVicio += pc2;
            elVicio += pc3;
            elVicio += pc4;
            elVicio += pc5;
            elVicio += pc6;
            elVicio += pc7;
            elVicio += pc8;
            elVicio += pc9;
            elVicio += pc10;

            //Agregar cabinas
            Cabina t1 = new Cabina("T01", Cabina.ETipoTelefono.ConTeclado, "Panasonic");
            Cabina t2 = new Cabina("T02", Cabina.ETipoTelefono.ConTeclado, "Panasonic");
            Cabina t3 = new Cabina("T03", Cabina.ETipoTelefono.ConTeclado, "Philips");
            Cabina t4 = new Cabina("T04", Cabina.ETipoTelefono.ConTeclado, "Panasonic");
            Cabina t5 = new Cabina("T05", Cabina.ETipoTelefono.ConTeclado, "Panasonic");
            elVicio += t1;
            elVicio += t2;
            elVicio += t3;
            elVicio += t4;
            elVicio += t5;

            List<Control> cabinas = new List<Control>();

            foreach (Control c in gpbCabinas.Controls)
            {
                if (c is Label)
                {
                    cabinas.Add(c);
                }
            }
        }

        /// <summary>
        /// Pide confirmacion para salir cuando se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCibercafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Escuchador de eventos del evento click del boton Estadisticas. Muestra de forma no modal un Form con estadisticas historicas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas f = new FormEstadisticas();
            f.Show();
        }

        ///
        private void lstCliente_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((ListBox)sender).SelectedItem.ToString());

        }
    }
}
