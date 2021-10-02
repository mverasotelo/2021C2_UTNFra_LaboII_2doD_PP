
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormInformacion
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.rctInfo = new System.Windows.Forms.RichTextBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.pnlBarraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(1046, 6);
            this.lblFecha.Size = new System.Drawing.Size(124, 28);
            this.lblFecha.Text = "30-09-2021";
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(390, 503);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(180, 38);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "OK";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // rctInfo
            // 
            this.rctInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rctInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rctInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rctInfo.Location = new System.Drawing.Point(12, 12);
            this.rctInfo.Name = "rctInfo";
            this.rctInfo.Size = new System.Drawing.Size(558, 485);
            this.rctInfo.TabIndex = 5;
            this.rctInfo.Text = "";
            // 
            // btnLiberar
            // 
            this.btnLiberar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiberar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLiberar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLiberar.Location = new System.Drawing.Point(12, 503);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(180, 38);
            this.btnLiberar.TabIndex = 6;
            this.btnLiberar.Text = "LIBERAR";
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Visible = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.rctInfo);
            this.Controls.Add(this.btnInfo);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormInformacion";
            this.Text = "Información";
            this.Load += new System.EventHandler(this.FormInformacion_Load);
            this.Controls.SetChildIndex(this.pnlBarraInfo, 0);
            this.Controls.SetChildIndex(this.btnInfo, 0);
            this.Controls.SetChildIndex(this.rctInfo, 0);
            this.Controls.SetChildIndex(this.btnLiberar, 0);
            this.pnlBarraInfo.ResumeLayout(false);
            this.pnlBarraInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnInfo;
        internal System.Windows.Forms.RichTextBox rctInfo;
        protected System.Windows.Forms.Button btnLiberar;
    }
}