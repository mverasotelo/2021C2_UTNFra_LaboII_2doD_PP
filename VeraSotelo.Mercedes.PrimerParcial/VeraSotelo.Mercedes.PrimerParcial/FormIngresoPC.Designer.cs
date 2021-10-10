
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
            this.rbtLibre = new System.Windows.Forms.RadioButton();
            this.rbtFija = new System.Windows.Forms.RadioButton();
            this.gpbTipoSesion = new System.Windows.Forms.GroupBox();
            this.numTiempo = new System.Windows.Forms.NumericUpDown();
            this.rctRequerimientos = new System.Windows.Forms.RichTextBox();
            this.lblRequerimientos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
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
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Location = new System.Drawing.Point(252, 26);
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
            // rbtLibre
            // 
            this.rbtLibre.AutoSize = true;
            this.rbtLibre.Location = new System.Drawing.Point(19, 33);
            this.rbtLibre.Name = "rbtLibre";
            this.rbtLibre.Size = new System.Drawing.Size(71, 27);
            this.rbtLibre.TabIndex = 6;
            this.rbtLibre.TabStop = true;
            this.rbtLibre.Text = "Libre";
            this.rbtLibre.UseVisualStyleBackColor = true;
            this.rbtLibre.CheckedChanged += new System.EventHandler(this.rbtLibre_CheckedChanged);
            // 
            // rbtFija
            // 
            this.rbtFija.AutoSize = true;
            this.rbtFija.Location = new System.Drawing.Point(19, 66);
            this.rbtFija.Name = "rbtFija";
            this.rbtFija.Size = new System.Drawing.Size(59, 27);
            this.rbtFija.TabIndex = 7;
            this.rbtFija.TabStop = true;
            this.rbtFija.Text = "Fija";
            this.rbtFija.UseVisualStyleBackColor = true;
            this.rbtFija.CheckedChanged += new System.EventHandler(this.rbtFija_CheckedChanged);
            // 
            // gpbTipoSesion
            // 
            this.gpbTipoSesion.Controls.Add(this.rbtFija);
            this.gpbTipoSesion.Controls.Add(this.rbtLibre);
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
            this.numTiempo.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTiempo.Location = new System.Drawing.Point(550, 307);
            this.numTiempo.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numTiempo.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTiempo.Name = "numTiempo";
            this.numTiempo.Size = new System.Drawing.Size(104, 29);
            this.numTiempo.TabIndex = 8;
            this.numTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTiempo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTiempo.Visible = false;
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
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(387, 309);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(157, 23);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "Tiempo en minutos:";
            this.lblTiempo.Visible = false;
            // 
            // FormIngresoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 679);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.numTiempo);
            this.Controls.Add(this.lblRequerimientos);
            this.Controls.Add(this.rctRequerimientos);
            this.Controls.Add(this.gpbTipoSesion);
            this.Controls.Add(this.lblPuestosDisponibles);
            this.MinimumSize = new System.Drawing.Size(360, 600);
            this.Name = "FormIngresoPC";
            this.ShowIcon = false;
            this.Text = "Ingresar sesión";
            this.Load += new System.EventHandler(this.FormIngresoPC_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.lblDatosCliente, 0);
            this.Controls.SetChildIndex(this.cmbPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.lblPuestosDisponibles, 0);
            this.Controls.SetChildIndex(this.gpbTipoSesion, 0);
            this.Controls.SetChildIndex(this.rctRequerimientos, 0);
            this.Controls.SetChildIndex(this.lblRequerimientos, 0);
            this.Controls.SetChildIndex(this.numTiempo, 0);
            this.Controls.SetChildIndex(this.lblTiempo, 0);
            this.gpbTipoSesion.ResumeLayout(false);
            this.gpbTipoSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblPuestosDisponibles;
        private System.Windows.Forms.RadioButton rbtLibre;
        private System.Windows.Forms.RadioButton rbtFija;
        private System.Windows.Forms.GroupBox gpbTipoSesion;
        private System.Windows.Forms.NumericUpDown numTiempo;
        private System.Windows.Forms.RichTextBox rctRequerimientos;
        private System.Windows.Forms.Label lblRequerimientos;
        private System.Windows.Forms.Label lblTiempo;
    }
}