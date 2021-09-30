
namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.btnAsignarPuesto = new System.Windows.Forms.Button();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.rctInfoSesion = new System.Windows.Forms.RichTextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblPuestosDisponibles = new System.Windows.Forms.Label();
            this.cmbPuestosDisponibles = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBarraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraInfo
            // 
            this.pnlBarraInfo.Location = new System.Drawing.Point(0, 899);
            this.pnlBarraInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraInfo.Size = new System.Drawing.Size(0, 55);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(-229, 8);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Size = new System.Drawing.Size(124, 28);
            this.lblFecha.Text = "28-09-2021";
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(15, 8);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btnAsignarPuesto
            // 
            this.btnAsignarPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarPuesto.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAsignarPuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarPuesto.Location = new System.Drawing.Point(316, 607);
            this.btnAsignarPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarPuesto.Name = "btnAsignarPuesto";
            this.btnAsignarPuesto.Size = new System.Drawing.Size(216, 49);
            this.btnAsignarPuesto.TabIndex = 3;
            this.btnAsignarPuesto.Text = "ASIGNAR PUESTO";
            this.btnAsignarPuesto.UseVisualStyleBackColor = false;
            this.btnAsignarPuesto.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.ForeColor = System.Drawing.Color.White;
            this.lblDatosCliente.Location = new System.Drawing.Point(187, 31);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(205, 120);
            this.lblDatosCliente.TabIndex = 4;
            this.lblDatosCliente.Text = "Nombre y apellido\r\nDNI XXXXXXXX\r\n(XX años)\r\n\r\n";
            this.lblDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rctInfoSesion
            // 
            this.rctInfoSesion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rctInfoSesion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rctInfoSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctInfoSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rctInfoSesion.Location = new System.Drawing.Point(27, 204);
            this.rctInfoSesion.Margin = new System.Windows.Forms.Padding(0);
            this.rctInfoSesion.Name = "rctInfoSesion";
            this.rctInfoSesion.ReadOnly = true;
            this.rctInfoSesion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rctInfoSesion.Size = new System.Drawing.Size(505, 273);
            this.rctInfoSesion.TabIndex = 1;
            this.rctInfoSesion.Text = "";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServicio.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblServicio.Location = new System.Drawing.Point(27, 163);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(316, 25);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "DATOS DEL SERVICIO SOLICITADO";
            // 
            // lblPuestosDisponibles
            // 
            this.lblPuestosDisponibles.AutoSize = true;
            this.lblPuestosDisponibles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuestosDisponibles.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPuestosDisponibles.Location = new System.Drawing.Point(27, 501);
            this.lblPuestosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuestosDisponibles.Name = "lblPuestosDisponibles";
            this.lblPuestosDisponibles.Size = new System.Drawing.Size(220, 25);
            this.lblPuestosDisponibles.TabIndex = 7;
            this.lblPuestosDisponibles.Text = "PUESTOS DISPONIBLES";
            // 
            // cmbPuestosDisponibles
            // 
            this.cmbPuestosDisponibles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestosDisponibles.FormattingEnabled = true;
            this.cmbPuestosDisponibles.Location = new System.Drawing.Point(27, 545);
            this.cmbPuestosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestosDisponibles.Name = "cmbPuestosDisponibles";
            this.cmbPuestosDisponibles.Size = new System.Drawing.Size(505, 33);
            this.cmbPuestosDisponibles.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(31, 607);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(216, 49);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 691);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbPuestosDisponibles);
            this.Controls.Add(this.lblPuestosDisponibles);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.rctInfoSesion);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.btnAsignarPuesto);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(578, 738);
            this.Name = "FormIngreso";
            this.Text = "Asignar Puesto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.Controls.SetChildIndex(this.pnlBarraInfo, 0);
            this.Controls.SetChildIndex(this.btnAsignarPuesto, 0);
            this.Controls.SetChildIndex(this.lblDatosCliente, 0);
            this.Controls.SetChildIndex(this.rctInfoSesion, 0);
            this.Controls.SetChildIndex(this.lblServicio, 0);
            this.Controls.SetChildIndex(this.lblPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.cmbPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnlBarraInfo.ResumeLayout(false);
            this.pnlBarraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblDatosCliente;
        internal System.Windows.Forms.Button btnAsignarPuesto;
        internal System.Windows.Forms.Label lblServicio;
        internal System.Windows.Forms.Label lblPuestosDisponibles;
        private System.Windows.Forms.RichTextBox rctInfoSesion;
        private System.Windows.Forms.ComboBox cmbPuestosDisponibles;
        internal System.Windows.Forms.Button btnCancelar;
    }
}