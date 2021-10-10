
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormImpresiones
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
            this.lblImpresiones = new System.Windows.Forms.Label();
            this.numImpresiones = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numImpresiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImpresiones
            // 
            this.lblImpresiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpresiones.AutoSize = true;
            this.lblImpresiones.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpresiones.Location = new System.Drawing.Point(63, 37);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(212, 23);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "Número de impresiones";
            // 
            // numImpresiones
            // 
            this.numImpresiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numImpresiones.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numImpresiones.Location = new System.Drawing.Point(63, 82);
            this.numImpresiones.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numImpresiones.Name = "numImpresiones";
            this.numImpresiones.Size = new System.Drawing.Size(212, 26);
            this.numImpresiones.TabIndex = 1;
            this.numImpresiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOk.Location = new System.Drawing.Point(200, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 39);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormImpresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(328, 216);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numImpresiones);
            this.Controls.Add(this.lblImpresiones);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(340, 260);
            this.Name = "FormImpresiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresiones";
            this.Load += new System.EventHandler(this.FormImpresiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numImpresiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImpresiones;
        private System.Windows.Forms.NumericUpDown numImpresiones;
        private System.Windows.Forms.Button btnOk;
    }
}