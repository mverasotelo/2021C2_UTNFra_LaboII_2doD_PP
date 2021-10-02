
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
            this.lblPuestosDisponibles = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gpbTipoSesion = new System.Windows.Forms.GroupBox();
            this.numTiempo = new System.Windows.Forms.NumericUpDown();
            this.rctRequerimientos = new System.Windows.Forms.RichTextBox();
            this.lblRequerimientos = new System.Windows.Forms.Label();
            this.gpbTipoSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(41, 575);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(422, 575);
            this.btnIngresar.Size = new System.Drawing.Size(232, 44);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Location = new System.Drawing.Point(229, 22);
            this.lblDatosCliente.Text = "Nombre y Apellido\r\nDNI XXXXXXXX\r\n(XX años)\r\n";
            // 
            // cmbPuestosDisponibles
            // 
            this.cmbPuestosDisponibles.Location = new System.Drawing.Point(41, 517);
            this.cmbPuestosDisponibles.Size = new System.Drawing.Size(613, 31);
            // 
            // lblPuestosDisponibles
            // 
            this.lblPuestosDisponibles.AutoSize = true;
            this.lblPuestosDisponibles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuestosDisponibles.Location = new System.Drawing.Point(41, 485);
            this.lblPuestosDisponibles.Name = "lblPuestosDisponibles";
            this.lblPuestosDisponibles.Size = new System.Drawing.Size(262, 29);
            this.lblPuestosDisponibles.TabIndex = 5;
            this.lblPuestosDisponibles.Text = "Computadoras disponibles";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 27);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Libre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 27);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Tiempo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gpbTipoSesion
            // 
            this.gpbTipoSesion.Controls.Add(this.numTiempo);
            this.gpbTipoSesion.Controls.Add(this.radioButton2);
            this.gpbTipoSesion.Controls.Add(this.radioButton1);
            this.gpbTipoSesion.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbTipoSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbTipoSesion.Location = new System.Drawing.Point(387, 164);
            this.gpbTipoSesion.Name = "gpbTipoSesion";
            this.gpbTipoSesion.Size = new System.Drawing.Size(267, 118);
            this.gpbTipoSesion.TabIndex = 8;
            this.gpbTipoSesion.TabStop = false;
            this.gpbTipoSesion.Text = "Tipo sesión";
            // 
            // numTiempo
            // 
            this.numTiempo.Location = new System.Drawing.Point(160, 64);
            this.numTiempo.Name = "numTiempo";
            this.numTiempo.Size = new System.Drawing.Size(95, 29);
            this.numTiempo.TabIndex = 8;
            // 
            // rctRequerimientos
            // 
            this.rctRequerimientos.Location = new System.Drawing.Point(41, 164);
            this.rctRequerimientos.Name = "rctRequerimientos";
            this.rctRequerimientos.Size = new System.Drawing.Size(327, 306);
            this.rctRequerimientos.TabIndex = 9;
            this.rctRequerimientos.Text = "";
            // 
            // lblRequerimientos
            // 
            this.lblRequerimientos.AutoSize = true;
            this.lblRequerimientos.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequerimientos.Location = new System.Drawing.Point(41, 132);
            this.lblRequerimientos.Name = "lblRequerimientos";
            this.lblRequerimientos.Size = new System.Drawing.Size(160, 29);
            this.lblRequerimientos.TabIndex = 10;
            this.lblRequerimientos.Text = "Requerimientos";
            // 
            // FormIngresoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 679);
            this.Controls.Add(this.lblRequerimientos);
            this.Controls.Add(this.rctRequerimientos);
            this.Controls.Add(this.gpbTipoSesion);
            this.Controls.Add(this.lblPuestosDisponibles);
            this.MinimumSize = new System.Drawing.Size(360, 600);
            this.Name = "FormIngresoPC";
            this.Text = "FormIngresoPC";
            this.Load += new System.EventHandler(this.FormIngresoPC_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.lblDatosCliente, 0);
            this.Controls.SetChildIndex(this.cmbPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.lblPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.gpbTipoSesion, 0);
            this.Controls.SetChildIndex(this.rctRequerimientos, 0);
            this.Controls.SetChildIndex(this.lblRequerimientos, 0);
            this.gpbTipoSesion.ResumeLayout(false);
            this.gpbTipoSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblPuestosDisponibles;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gpbTipoSesion;
        private System.Windows.Forms.NumericUpDown numTiempo;
        private System.Windows.Forms.RichTextBox rctRequerimientos;
        private System.Windows.Forms.Label lblRequerimientos;
    }
}