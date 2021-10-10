namespace VeraSotelo.Mercedes.PrimerParcial
{
    partial class FormCibercafe
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblComputadoras = new System.Windows.Forms.Label();
            this.lblC02 = new System.Windows.Forms.Label();
            this.lblC04 = new System.Windows.Forms.Label();
            this.lblC07 = new System.Windows.Forms.Label();
            this.lblC03 = new System.Windows.Forms.Label();
            this.lblC09 = new System.Windows.Forms.Label();
            this.lblC05 = new System.Windows.Forms.Label();
            this.lblC08 = new System.Windows.Forms.Label();
            this.lblC10 = new System.Windows.Forms.Label();
            this.lblC06 = new System.Windows.Forms.Label();
            this.gpbPuestos = new System.Windows.Forms.GroupBox();
            this.lblT05 = new System.Windows.Forms.Label();
            this.lblT04 = new System.Windows.Forms.Label();
            this.lblCabinas = new System.Windows.Forms.Label();
            this.lblT03 = new System.Windows.Forms.Label();
            this.lblT02 = new System.Windows.Forms.Label();
            this.lblT01 = new System.Windows.Forms.Label();
            this.lblC01 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.gpbPuestos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Tw Cen MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientes.Location = new System.Drawing.Point(996, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(236, 25);
            this.lblClientes.TabIndex = 21;
            this.lblClientes.Text = "👤 CLIENTES EN ESPERA";
            // 
            // lstCliente
            // 
            this.lstCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCliente.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.ItemHeight = 35;
            this.lstCliente.Location = new System.Drawing.Point(741, 48);
            this.lstCliente.Margin = new System.Windows.Forms.Padding(0);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(499, 564);
            this.lstCliente.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstadisticas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEstadisticas.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.Location = new System.Drawing.Point(549, 504);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEstadisticas.Size = new System.Drawing.Size(171, 56);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "📈 ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAsignar.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.Location = new System.Drawing.Point(549, 48);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAsignar.Size = new System.Drawing.Size(171, 54);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "ASIGNAR PUESTO";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblComputadoras
            // 
            this.lblComputadoras.AutoSize = true;
            this.lblComputadoras.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputadoras.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComputadoras.Location = new System.Drawing.Point(14, -16);
            this.lblComputadoras.Name = "lblComputadoras";
            this.lblComputadoras.Size = new System.Drawing.Size(130, 89);
            this.lblComputadoras.TabIndex = 6;
            this.lblComputadoras.Text = "💻";
            // 
            // lblC02
            // 
            this.lblC02.AutoSize = true;
            this.lblC02.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC02.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC02.Location = new System.Drawing.Point(14, 188);
            this.lblC02.Margin = new System.Windows.Forms.Padding(0);
            this.lblC02.Name = "lblC02";
            this.lblC02.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC02.Size = new System.Drawing.Size(141, 83);
            this.lblC02.TabIndex = 42;
            this.lblC02.Text = "C02";
            this.lblC02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC02.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC04
            // 
            this.lblC04.AutoSize = true;
            this.lblC04.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC04.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC04.Location = new System.Drawing.Point(14, 378);
            this.lblC04.Margin = new System.Windows.Forms.Padding(0);
            this.lblC04.Name = "lblC04";
            this.lblC04.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC04.Size = new System.Drawing.Size(141, 83);
            this.lblC04.TabIndex = 42;
            this.lblC04.Text = "C04";
            this.lblC04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC04.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC07
            // 
            this.lblC07.AutoSize = true;
            this.lblC07.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC07.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC07.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC07.Location = new System.Drawing.Point(167, 188);
            this.lblC07.Margin = new System.Windows.Forms.Padding(0);
            this.lblC07.Name = "lblC07";
            this.lblC07.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC07.Size = new System.Drawing.Size(141, 83);
            this.lblC07.TabIndex = 42;
            this.lblC07.Text = "C07";
            this.lblC07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC07.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC03
            // 
            this.lblC03.AutoSize = true;
            this.lblC03.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC03.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC03.Location = new System.Drawing.Point(14, 283);
            this.lblC03.Margin = new System.Windows.Forms.Padding(0);
            this.lblC03.Name = "lblC03";
            this.lblC03.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC03.Size = new System.Drawing.Size(141, 83);
            this.lblC03.TabIndex = 42;
            this.lblC03.Text = "C03";
            this.lblC03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC03.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC09
            // 
            this.lblC09.AutoSize = true;
            this.lblC09.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC09.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC09.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC09.Location = new System.Drawing.Point(167, 378);
            this.lblC09.Margin = new System.Windows.Forms.Padding(0);
            this.lblC09.Name = "lblC09";
            this.lblC09.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC09.Size = new System.Drawing.Size(141, 83);
            this.lblC09.TabIndex = 42;
            this.lblC09.Text = "C09";
            this.lblC09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC09.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC05
            // 
            this.lblC05.AutoSize = true;
            this.lblC05.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC05.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC05.Location = new System.Drawing.Point(14, 473);
            this.lblC05.Margin = new System.Windows.Forms.Padding(0);
            this.lblC05.Name = "lblC05";
            this.lblC05.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC05.Size = new System.Drawing.Size(141, 83);
            this.lblC05.TabIndex = 42;
            this.lblC05.Text = "C05";
            this.lblC05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC05.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC08
            // 
            this.lblC08.AutoSize = true;
            this.lblC08.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC08.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC08.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC08.Location = new System.Drawing.Point(167, 283);
            this.lblC08.Margin = new System.Windows.Forms.Padding(0);
            this.lblC08.Name = "lblC08";
            this.lblC08.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC08.Size = new System.Drawing.Size(141, 83);
            this.lblC08.TabIndex = 42;
            this.lblC08.Text = "C08";
            this.lblC08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC08.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC10
            // 
            this.lblC10.AutoSize = true;
            this.lblC10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC10.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC10.Location = new System.Drawing.Point(167, 473);
            this.lblC10.Margin = new System.Windows.Forms.Padding(0);
            this.lblC10.Name = "lblC10";
            this.lblC10.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC10.Size = new System.Drawing.Size(141, 83);
            this.lblC10.TabIndex = 42;
            this.lblC10.Text = "C10";
            this.lblC10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC10.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC06
            // 
            this.lblC06.AutoSize = true;
            this.lblC06.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC06.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC06.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC06.Location = new System.Drawing.Point(167, 93);
            this.lblC06.Margin = new System.Windows.Forms.Padding(0);
            this.lblC06.Name = "lblC06";
            this.lblC06.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC06.Size = new System.Drawing.Size(141, 83);
            this.lblC06.TabIndex = 42;
            this.lblC06.Text = "C06";
            this.lblC06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC06.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // gpbPuestos
            // 
            this.gpbPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbPuestos.AutoSize = true;
            this.gpbPuestos.Controls.Add(this.lblT05);
            this.gpbPuestos.Controls.Add(this.lblC10);
            this.gpbPuestos.Controls.Add(this.lblC09);
            this.gpbPuestos.Controls.Add(this.lblT04);
            this.gpbPuestos.Controls.Add(this.lblC08);
            this.gpbPuestos.Controls.Add(this.lblCabinas);
            this.gpbPuestos.Controls.Add(this.lblT03);
            this.gpbPuestos.Controls.Add(this.lblC07);
            this.gpbPuestos.Controls.Add(this.lblT02);
            this.gpbPuestos.Controls.Add(this.lblC06);
            this.gpbPuestos.Controls.Add(this.lblC05);
            this.gpbPuestos.Controls.Add(this.lblT01);
            this.gpbPuestos.Controls.Add(this.lblC04);
            this.gpbPuestos.Controls.Add(this.lblC03);
            this.gpbPuestos.Controls.Add(this.lblC02);
            this.gpbPuestos.Controls.Add(this.lblC01);
            this.gpbPuestos.Controls.Add(this.lblComputadoras);
            this.gpbPuestos.Location = new System.Drawing.Point(11, 13);
            this.gpbPuestos.Margin = new System.Windows.Forms.Padding(0);
            this.gpbPuestos.Name = "gpbPuestos";
            this.gpbPuestos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPuestos.Size = new System.Drawing.Size(517, 627);
            this.gpbPuestos.TabIndex = 36;
            this.gpbPuestos.TabStop = false;
            this.gpbPuestos.Text = "groupBox2";
            // 
            // lblT05
            // 
            this.lblT05.AutoSize = true;
            this.lblT05.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblT05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblT05.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblT05.Location = new System.Drawing.Point(352, 473);
            this.lblT05.Margin = new System.Windows.Forms.Padding(0);
            this.lblT05.Name = "lblT05";
            this.lblT05.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblT05.Size = new System.Drawing.Size(137, 83);
            this.lblT05.TabIndex = 42;
            this.lblT05.Text = "T05";
            this.lblT05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT05.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblT04
            // 
            this.lblT04.AutoSize = true;
            this.lblT04.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblT04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblT04.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblT04.Location = new System.Drawing.Point(352, 378);
            this.lblT04.Margin = new System.Windows.Forms.Padding(0);
            this.lblT04.Name = "lblT04";
            this.lblT04.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblT04.Size = new System.Drawing.Size(137, 83);
            this.lblT04.TabIndex = 42;
            this.lblT04.Text = "T04";
            this.lblT04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT04.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblCabinas
            // 
            this.lblCabinas.AutoSize = true;
            this.lblCabinas.Font = new System.Drawing.Font("DejaVu Sans Mono", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCabinas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCabinas.Location = new System.Drawing.Point(389, -9);
            this.lblCabinas.Name = "lblCabinas";
            this.lblCabinas.Size = new System.Drawing.Size(103, 74);
            this.lblCabinas.TabIndex = 5;
            this.lblCabinas.Text = "📞";
            // 
            // lblT03
            // 
            this.lblT03.AutoSize = true;
            this.lblT03.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblT03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblT03.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblT03.Location = new System.Drawing.Point(352, 283);
            this.lblT03.Margin = new System.Windows.Forms.Padding(0);
            this.lblT03.Name = "lblT03";
            this.lblT03.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblT03.Size = new System.Drawing.Size(137, 83);
            this.lblT03.TabIndex = 42;
            this.lblT03.Text = "T03";
            this.lblT03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT03.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblT02
            // 
            this.lblT02.AutoSize = true;
            this.lblT02.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblT02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblT02.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblT02.Location = new System.Drawing.Point(352, 188);
            this.lblT02.Margin = new System.Windows.Forms.Padding(0);
            this.lblT02.Name = "lblT02";
            this.lblT02.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblT02.Size = new System.Drawing.Size(137, 83);
            this.lblT02.TabIndex = 42;
            this.lblT02.Text = "T02";
            this.lblT02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT02.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblT01
            // 
            this.lblT01.AutoSize = true;
            this.lblT01.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblT01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblT01.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblT01.Location = new System.Drawing.Point(352, 93);
            this.lblT01.Margin = new System.Windows.Forms.Padding(0);
            this.lblT01.Name = "lblT01";
            this.lblT01.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblT01.Size = new System.Drawing.Size(137, 83);
            this.lblT01.TabIndex = 42;
            this.lblT01.Text = "T01";
            this.lblT01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT01.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblC01
            // 
            this.lblC01.AutoSize = true;
            this.lblC01.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblC01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblC01.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC01.Location = new System.Drawing.Point(14, 93);
            this.lblC01.Margin = new System.Windows.Forms.Padding(0);
            this.lblC01.Name = "lblC01";
            this.lblC01.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblC01.Size = new System.Drawing.Size(141, 83);
            this.lblC01.TabIndex = 42;
            this.lblC01.Text = "C01";
            this.lblC01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC01.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(549, 568);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalir.Size = new System.Drawing.Size(171, 56);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblOperador);
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 44);
            this.panel1.TabIndex = 37;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(1094, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(146, 27);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "XX-XX-XXXX";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperador.Location = new System.Drawing.Point(11, 8);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(216, 27);
            this.lblOperador.TabIndex = 0;
            this.lblOperador.Text = "Mercedes Vera Sotelo";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCibercafe
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.gpbPuestos);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.lblClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "FormCibercafe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cibercafé \"El Vicio\"";
            this.Activated += new System.EventHandler(this.FormCibercafe_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCibercafe_FormClosing);
            this.Load += new System.EventHandler(this.FormCibercafe_Load);
            this.gpbPuestos.ResumeLayout(false);
            this.gpbPuestos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblComputadoras;
        private System.Windows.Forms.Label lblC02;
        private System.Windows.Forms.Label lblC04;
        private System.Windows.Forms.Label lblC07;
        private System.Windows.Forms.Label lblC03;
        private System.Windows.Forms.Label lblC09;
        private System.Windows.Forms.Label lblC05;
        private System.Windows.Forms.Label lblC08;
        private System.Windows.Forms.Label lblC10;
        private System.Windows.Forms.Label lblC06;
        private System.Windows.Forms.GroupBox gpbPuestos;
        private System.Windows.Forms.Label lblC01;
        private System.Windows.Forms.Label lblT05;
        private System.Windows.Forms.Label lblT04;
        private System.Windows.Forms.Label lblCabinas;
        private System.Windows.Forms.Label lblT03;
        private System.Windows.Forms.Label lblT02;
        private System.Windows.Forms.Label lblT01;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOperador;
    }
}
