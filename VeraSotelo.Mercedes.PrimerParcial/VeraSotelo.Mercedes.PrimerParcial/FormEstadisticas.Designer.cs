
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
            this.rctEstadisticas = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbEstadisticas = new System.Windows.Forms.ComboBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rctEstadisticas
            // 
            this.rctEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rctEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rctEstadisticas.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rctEstadisticas.Location = new System.Drawing.Point(12, 116);
            this.rctEstadisticas.Name = "rctEstadisticas";
            this.rctEstadisticas.ReadOnly = true;
            this.rctEstadisticas.Size = new System.Drawing.Size(1105, 449);
            this.rctEstadisticas.TabIndex = 1;
            this.rctEstadisticas.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(947, 587);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbEstadisticas
            // 
            this.cmbEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadisticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadisticas.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEstadisticas.FormattingEnabled = true;
            this.cmbEstadisticas.Items.AddRange(new object[] {
            "Lista de computadoras ordenadas por minutos de uso de forma descendente",
            "Lista de cabinas ordenadas por minutos de uso de forma descendente",
            "Ganancias totales y clasificadas por servicio (teléfono/computadora)",
            "Horas totales y la recaudación por tipo de llamada",
            "El software más pedido por los clientes",
            "El periférico más pedido por los clientes",
            "El juego más pedido por los clientes"});
            this.cmbEstadisticas.Location = new System.Drawing.Point(12, 63);
            this.cmbEstadisticas.Name = "cmbEstadisticas";
            this.cmbEstadisticas.Size = new System.Drawing.Size(852, 35);
            this.cmbEstadisticas.TabIndex = 4;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVisualizar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVisualizar.Location = new System.Drawing.Point(879, 63);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(238, 36);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = " VISUALIZAR";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadisticas.Location = new System.Drawing.Point(12, 31);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(484, 28);
            this.lblEstadisticas.TabIndex = 6;
            this.lblEstadisticas.Text = "Seleccione la información que desea consultar:";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1129, 653);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.cmbEstadisticas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rctEstadisticas);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rctEstadisticas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbEstadisticas;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label lblEstadisticas;
    }
}