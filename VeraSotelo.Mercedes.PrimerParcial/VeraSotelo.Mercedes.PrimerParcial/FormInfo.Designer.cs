
namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormInfo
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
            this.btnOK = new System.Windows.Forms.Button();
            this.rctInfo = new System.Windows.Forms.RichTextBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(472, 533);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(198, 49);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rctInfo
            // 
            this.rctInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rctInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rctInfo.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rctInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rctInfo.Location = new System.Drawing.Point(12, 12);
            this.rctInfo.Name = "rctInfo";
            this.rctInfo.ReadOnly = true;
            this.rctInfo.Size = new System.Drawing.Size(658, 504);
            this.rctInfo.TabIndex = 2;
            this.rctInfo.Text = "";
            // 
            // btnLiberar
            // 
            this.btnLiberar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLiberar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLiberar.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLiberar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLiberar.Location = new System.Drawing.Point(12, 533);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(208, 49);
            this.btnLiberar.TabIndex = 3;
            this.btnLiberar.Text = "LIBERAR";
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Visible = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.rctInfo);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.RichTextBox rctInfo;
        protected System.Windows.Forms.Button btnLiberar;
    }
}