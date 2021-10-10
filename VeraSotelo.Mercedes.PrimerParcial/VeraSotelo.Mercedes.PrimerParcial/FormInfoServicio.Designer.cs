
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
            this.lblSaldoBruto = new System.Windows.Forms.Label();
            this.lblSaldoIVA = new System.Windows.Forms.Label();
            this.lblTiempoUso = new System.Windows.Forms.Label();
            this.lblInfoServicio = new System.Windows.Forms.Label();
            this.lblCopias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(568, 464);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 48);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rctInfoServicio
            // 
            this.rctInfoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rctInfoServicio.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctInfoServicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rctInfoServicio.Location = new System.Drawing.Point(27, 83);
            this.rctInfoServicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rctInfoServicio.Name = "rctInfoServicio";
            this.rctInfoServicio.Size = new System.Drawing.Size(699, 232);
            this.rctInfoServicio.TabIndex = 1;
            this.rctInfoServicio.Text = "";
            // 
            // lblSaldoBruto
            // 
            this.lblSaldoBruto.AutoSize = true;
            this.lblSaldoBruto.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoBruto.Location = new System.Drawing.Point(34, 414);
            this.lblSaldoBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoBruto.Name = "lblSaldoBruto";
            this.lblSaldoBruto.Size = new System.Drawing.Size(132, 27);
            this.lblSaldoBruto.TabIndex = 2;
            this.lblSaldoBruto.Text = "Saldo bruto: ";
            // 
            // lblSaldoIVA
            // 
            this.lblSaldoIVA.AutoSize = true;
            this.lblSaldoIVA.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoIVA.Location = new System.Drawing.Point(34, 455);
            this.lblSaldoIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoIVA.Name = "lblSaldoIVA";
            this.lblSaldoIVA.Size = new System.Drawing.Size(232, 27);
            this.lblSaldoIVA.TabIndex = 3;
            this.lblSaldoIVA.Text = "Saldo a pagar con IVA:";
            // 
            // lblTiempoUso
            // 
            this.lblTiempoUso.AutoSize = true;
            this.lblTiempoUso.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiempoUso.Location = new System.Drawing.Point(34, 376);
            this.lblTiempoUso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoUso.Name = "lblTiempoUso";
            this.lblTiempoUso.Size = new System.Drawing.Size(151, 27);
            this.lblTiempoUso.TabIndex = 4;
            this.lblTiempoUso.Text = "Tiempo de uso";
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
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopias.Location = new System.Drawing.Point(34, 338);
            this.lblCopias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(77, 27);
            this.lblCopias.TabIndex = 6;
            this.lblCopias.Text = "Copias";
            this.lblCopias.Visible = false;
            // 
            // FormInfoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(759, 537);
            this.Controls.Add(this.lblCopias);
            this.Controls.Add(this.lblInfoServicio);
            this.Controls.Add(this.lblTiempoUso);
            this.Controls.Add(this.lblSaldoIVA);
            this.Controls.Add(this.lblSaldoBruto);
            this.Controls.Add(this.rctInfoServicio);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormInfoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Servicio";
            this.Load += new System.EventHandler(this.FormInfoServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox rctInfoServicio;
        private System.Windows.Forms.Label lblSaldoBruto;
        private System.Windows.Forms.Label lblSaldoIVA;
        private System.Windows.Forms.Label lblTiempoUso;
        private System.Windows.Forms.Label lblInfoServicio;
        private System.Windows.Forms.Label lblCopias;
    }
}