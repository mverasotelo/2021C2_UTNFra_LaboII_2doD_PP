
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBarraInfo = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.pnlBarraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraInfo
            // 
            this.pnlBarraInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarraInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlBarraInfo.Controls.Add(this.lblFecha);
            this.pnlBarraInfo.Controls.Add(this.lblOperador);
            this.pnlBarraInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlBarraInfo.Location = new System.Drawing.Point(0, 609);
            this.pnlBarraInfo.Name = "pnlBarraInfo";
            this.pnlBarraInfo.Size = new System.Drawing.Size(1213, 44);
            this.pnlBarraInfo.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.Location = new System.Drawing.Point(1170, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 28);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOperador.Location = new System.Drawing.Point(11, 6);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(217, 28);
            this.lblOperador.TabIndex = 0;
            this.lblOperador.Text = "Mercedes Vera Sotelo";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlBarraInfo);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cibercafé \"El Vicio\"";
            this.Load += new System.EventHandler(this.Base_Load);
            this.pnlBarraInfo.ResumeLayout(false);
            this.pnlBarraInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBarraInfo;
        protected System.Windows.Forms.Label lblFecha;
        protected System.Windows.Forms.Label lblOperador;
    }
}
