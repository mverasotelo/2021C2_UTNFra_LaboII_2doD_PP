
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
            this.rctEstadisticas = new System.Windows.Forms.RichTextBox();
            this.pnlBarraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraInfo
            // 
            this.pnlBarraInfo.Location = new System.Drawing.Point(0, 699);
            this.pnlBarraInfo.Size = new System.Drawing.Size(1318, 44);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(1151, 6);
            this.lblFecha.Size = new System.Drawing.Size(124, 28);
            this.lblFecha.Text = "02-10-2021";
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
            // rctEstadisticas
            // 
            this.rctEstadisticas.Location = new System.Drawing.Point(32, 77);
            this.rctEstadisticas.Name = "rctEstadisticas";
            this.rctEstadisticas.Size = new System.Drawing.Size(1087, 457);
            this.rctEstadisticas.TabIndex = 1;
            this.rctEstadisticas.Text = "";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.rctEstadisticas);
            this.Controls.Add(this.lblGananciasTotales);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormEstadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.Controls.SetChildIndex(this.lblGananciasTotales, 0);
            this.Controls.SetChildIndex(this.pnlBarraInfo, 0);
            this.Controls.SetChildIndex(this.rctEstadisticas, 0);
            this.pnlBarraInfo.ResumeLayout(false);
            this.pnlBarraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGananciasTotales;
        private System.Windows.Forms.RichTextBox rctEstadisticas;
    }
}