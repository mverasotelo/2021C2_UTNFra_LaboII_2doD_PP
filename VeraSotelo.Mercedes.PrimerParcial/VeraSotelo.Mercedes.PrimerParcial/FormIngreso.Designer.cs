
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCliente.Location = new System.Drawing.Point(31, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(91, 25);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(401, 483);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(147, 42);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatosCliente.Location = new System.Drawing.Point(31, 93);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(0, 25);
            this.lblDatosCliente.TabIndex = 4;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblCliente);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormIngreso";
            this.Text = "Asignar Puesto";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.lblDatosCliente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCliente;
        internal System.Windows.Forms.Label lblDatosCliente;
        internal System.Windows.Forms.Button btnIngresar;
    }
}