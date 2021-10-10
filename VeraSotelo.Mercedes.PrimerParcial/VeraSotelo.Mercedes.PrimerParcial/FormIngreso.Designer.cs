
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormIngreso
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
        protected void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.cmbPuestosDisponibles = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(60, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 44);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(397, 591);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(215, 44);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "ASIGNAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(227, 54);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(204, 96);
            this.lblDatosCliente.TabIndex = 2;
            this.lblDatosCliente.Text = "Nombre y Apellido\r\nDNI XXXXXXXX\r\n(XX años)\r\n";
            this.lblDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPuestosDisponibles
            // 
            this.cmbPuestosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPuestosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestosDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbPuestosDisponibles.FormattingEnabled = true;
            this.cmbPuestosDisponibles.Location = new System.Drawing.Point(60, 509);
            this.cmbPuestosDisponibles.Name = "cmbPuestosDisponibles";
            this.cmbPuestosDisponibles.Size = new System.Drawing.Size(552, 31);
            this.cmbPuestosDisponibles.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHelp.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHelp.Location = new System.Drawing.Point(625, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(44, 44);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "❓";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(672, 679);
            this.Controls.Add(this.cmbPuestosDisponibles);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "FormIngreso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar puesto";
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnIngresar;
        protected System.Windows.Forms.Label lblDatosCliente;
        protected System.Windows.Forms.ComboBox cmbPuestosDisponibles;
        protected System.Windows.Forms.Button btnHelp;
    }
}