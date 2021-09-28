
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormEstadisticas
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
        private void InitializeComponent()
        {
            this.lblGananciasTotales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGananciasTotales
            // 
            this.lblGananciasTotales.AutoSize = true;
            this.lblGananciasTotales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGananciasTotales.Location = new System.Drawing.Point(32, 31);
            this.lblGananciasTotales.Name = "lblGananciasTotales";
            this.lblGananciasTotales.Size = new System.Drawing.Size(185, 23);
            this.lblGananciasTotales.TabIndex = 0;
            this.lblGananciasTotales.Text = "GANANCIAS TOTALES";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1077, 563);
            this.Controls.Add(this.lblGananciasTotales);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGananciasTotales;
    }
}