
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormInfoServicio
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
            this.btnOk = new System.Windows.Forms.Button();
            this.rctInfoServicio = new System.Windows.Forms.RichTextBox();
            this.lblInfoServicio = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(556, 480);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 48);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rctInfoServicio
            // 
            this.rctInfoServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rctInfoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rctInfoServicio.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctInfoServicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rctInfoServicio.Location = new System.Drawing.Point(27, 83);
            this.rctInfoServicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rctInfoServicio.Name = "rctInfoServicio";
            this.rctInfoServicio.ReadOnly = true;
            this.rctInfoServicio.Size = new System.Drawing.Size(699, 232);
            this.rctInfoServicio.TabIndex = 1;
            this.rctInfoServicio.Text = "";
            // 
            // lblInfoServicio
            // 
            this.lblInfoServicio.AutoSize = true;
            this.lblInfoServicio.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoServicio.Location = new System.Drawing.Point(34, 46);
            this.lblInfoServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoServicio.Name = "lblInfoServicio";
            this.lblInfoServicio.Size = new System.Drawing.Size(300, 33);
            this.lblInfoServicio.TabIndex = 5;
            this.lblInfoServicio.Text = "Información del servicio:";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFactura.Location = new System.Drawing.Point(27, 344);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(175, 27);
            this.lblFactura.TabIndex = 6;
            this.lblFactura.Text = "Costo del servicio";
            // 
            // FormInfoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(747, 553);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.lblInfoServicio);
            this.Controls.Add(this.rctInfoServicio);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "FormInfoServicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Servicio";
            this.Load += new System.EventHandler(this.FormInfoServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox rctInfoServicio;
        private System.Windows.Forms.Label lblInfoServicio;
        private System.Windows.Forms.Label lblFactura;
    }
}