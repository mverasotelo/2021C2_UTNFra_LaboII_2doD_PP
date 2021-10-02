
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormIngresoPC
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
        protected new void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Text = "Nombre y Apellido\r\nDNI XXXXXXXX\r\n(XX años)\r\n";
            // 
            // cmbPuestosDisponibles
            // 
            this.cmbPuestosDisponibles.Size = new System.Drawing.Size(552, 31);
            // 
            // FormIngresoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 679);
            this.Name = "FormIngresoPC";
            this.Text = "FormIngresoPC";
            this.Load += new System.EventHandler(this.FormIngresoPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}