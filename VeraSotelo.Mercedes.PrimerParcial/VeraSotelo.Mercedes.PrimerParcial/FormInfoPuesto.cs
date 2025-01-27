﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Biblioteca;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormInfoPuesto : Form
    {
        private Puesto puesto;

        /// <summary>
        /// Constructor privado de FormInfo
        /// </summary>
        public FormInfoPuesto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga del constructor del FormInfo
        /// </summary>
        public FormInfoPuesto(Puesto puesto)
            : this()
        {
            this.puesto = puesto;
        }

        /// <summary>
        /// Evento Load. Se muestra la informacion del puesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInfo_Load(object sender, EventArgs e)
        {
            this.Text = $"Información Puesto {puesto.Id}";
            this.rctInfo.Text = puesto.ToString();
            if (puesto.Estado == Puesto.EEstado.Ocupado)
            {
                btnLiberar.Visible = true;
                if(puesto is Computadora && ((Computadora)puesto).EstaDisponible(Enumerados.EPerifericos.Impresora))
                {
                    btnImprimir.Visible = true;
                }
            }
        }

        /// <summary>
        /// Libera el puesto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLiberar_Click(object sender, EventArgs e)
        {
            if (puesto.Estado == Puesto.EEstado.Ocupado)
            {
                Cibercafe.LiberarPuesto(puesto);
                FormInfoServicio formInfoServicio = new FormInfoServicio(puesto.ListaServicios.Last());
                formInfoServicio.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre formilario modal para ingresar el número de copias solicitadas por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImpresiones frm = new FormImpresiones(puesto);
            frm.ShowDialog();
        }
    }
}
