
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormIngresoLlamada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private new void InitializeComponent()
        {
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumeroDestino = new System.Windows.Forms.Label();
            this.lblPuestosDisponibles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(55, 449);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(392, 449);
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbPuestosDisponibles
            // 
            this.cmbPuestosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPuestosDisponibles.Location = new System.Drawing.Point(55, 367);
            this.cmbPuestosDisponibles.Size = new System.Drawing.Size(552, 31);
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(55, 250);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.PlaceholderText = "Código País";
            this.txtCodigoPais.Size = new System.Drawing.Size(127, 29);
            this.txtCodigoPais.TabIndex = 5;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefijo.Location = new System.Drawing.Point(204, 250);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.PlaceholderText = "Prefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(136, 29);
            this.txtPrefijo.TabIndex = 6;
            this.txtPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(368, 250);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PlaceholderText = "Número";
            this.txtNumero.Size = new System.Drawing.Size(239, 29);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumeroDestino
            // 
            this.lblNumeroDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDestino.AutoSize = true;
            this.lblNumeroDestino.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDestino.Location = new System.Drawing.Point(55, 210);
            this.lblNumeroDestino.Name = "lblNumeroDestino";
            this.lblNumeroDestino.Size = new System.Drawing.Size(164, 29);
            this.lblNumeroDestino.TabIndex = 8;
            this.lblNumeroDestino.Text = "Número Destino";
            // 
            // lblPuestosDisponibles
            // 
            this.lblPuestosDisponibles.AutoSize = true;
            this.lblPuestosDisponibles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuestosDisponibles.Location = new System.Drawing.Point(55, 326);
            this.lblPuestosDisponibles.Name = "lblPuestosDisponibles";
            this.lblPuestosDisponibles.Size = new System.Drawing.Size(203, 29);
            this.lblPuestosDisponibles.TabIndex = 9;
            this.lblPuestosDisponibles.Text = "Cabinas Disponibles";
            // 
            // FormIngresoLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 525);
            this.Controls.Add(this.lblPuestosDisponibles);
            this.Controls.Add(this.lblNumeroDestino);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPrefijo);
            this.Controls.Add(this.txtCodigoPais);
            this.MinimumSize = new System.Drawing.Size(403, 400);
            this.Name = "FormIngresoLlamada";
            this.ShowIcon = false;
            this.Text = "Ingresar llamada";
            this.Load += new System.EventHandler(this.IngresoLlamada_Load);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtPrefijo, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.lblNumeroDestino, 0);
            this.Controls.SetChildIndex(this.lblPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.lblDatosCliente, 0);
            this.Controls.SetChildIndex(this.cmbPuestosDisponibles, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumeroDestino;
        private System.Windows.Forms.Label lblPuestosDisponibles;
    }
}