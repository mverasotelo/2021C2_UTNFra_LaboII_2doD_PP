﻿namespace VeraSotelo.Mercedes.PrimerParcial
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
            this.rdbPc = new System.Windows.Forms.RadioButton();
            this.rdbCabina = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblComputadoras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbPuestos = new System.Windows.Forms.GroupBox();
            this.lblCab5 = new System.Windows.Forms.Label();
            this.lblCab4 = new System.Windows.Forms.Label();
            this.lblCabinas = new System.Windows.Forms.Label();
            this.lblCab3 = new System.Windows.Forms.Label();
            this.lblCab2 = new System.Windows.Forms.Label();
            this.lblCab1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarraInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbPuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(1046, 6);
            this.lblFecha.Size = new System.Drawing.Size(124, 28);
            this.lblFecha.Text = "28-09-2021";
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientes.Location = new System.Drawing.Point(939, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(231, 30);
            this.lblClientes.TabIndex = 21;
            this.lblClientes.Text = "CLIENTES EN ESPERA";
            // 
            // lstCliente
            // 
            this.lstCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCliente.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.ItemHeight = 30;
            this.lstCliente.Location = new System.Drawing.Point(742, 48);
            this.lstCliente.Margin = new System.Windows.Forms.Padding(0);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(431, 544);
            this.lstCliente.TabIndex = 0;
            this.lstCliente.DoubleClick += new System.EventHandler(this.lstCliente_DoubleClick);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstadisticas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.Location = new System.Drawing.Point(548, 536);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(5);
            this.btnEstadisticas.Size = new System.Drawing.Size(172, 56);
            this.btnEstadisticas.TabIndex = 38;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsignar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAsignar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.Location = new System.Drawing.Point(548, 48);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAsignar.Size = new System.Drawing.Size(172, 54);
            this.btnAsignar.TabIndex = 39;
            this.btnAsignar.Text = "ASIGNAR PUESTO";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // rdbPc
            // 
            this.rdbPc.AutoSize = true;
            this.rdbPc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPc.Location = new System.Drawing.Point(15, 29);
            this.rdbPc.Name = "rdbPc";
            this.rdbPc.Size = new System.Drawing.Size(137, 27);
            this.rdbPc.TabIndex = 40;
            this.rdbPc.TabStop = true;
            this.rdbPc.Text = "Computadora";
            this.rdbPc.UseVisualStyleBackColor = true;
            // 
            // rdbCabina
            // 
            this.rdbCabina.AutoSize = true;
            this.rdbCabina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCabina.Location = new System.Drawing.Point(15, 62);
            this.rdbCabina.Name = "rdbCabina";
            this.rdbCabina.Size = new System.Drawing.Size(84, 27);
            this.rdbCabina.TabIndex = 41;
            this.rdbCabina.TabStop = true;
            this.rdbCabina.Text = "Cabina";
            this.rdbCabina.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCabina);
            this.groupBox1.Controls.Add(this.rdbPc);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(548, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 105);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(548, 447);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 44;
            this.button1.Text = "AGREGAR CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblComputadoras
            // 
            this.lblComputadoras.AutoSize = true;
            this.lblComputadoras.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputadoras.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComputadoras.Location = new System.Drawing.Point(14, -17);
            this.lblComputadoras.Name = "lblComputadoras";
            this.lblComputadoras.Size = new System.Drawing.Size(130, 89);
            this.lblComputadoras.TabIndex = 6;
            this.lblComputadoras.Text = "💻";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label5.Size = new System.Drawing.Size(141, 86);
            this.label5.TabIndex = 42;
            this.label5.Text = "C02";
            this.label5.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 377);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label4.Size = new System.Drawing.Size(141, 86);
            this.label4.TabIndex = 42;
            this.label4.Text = "C04";
            this.label4.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSalmon;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(167, 179);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label10.Size = new System.Drawing.Size(141, 86);
            this.label10.TabIndex = 42;
            this.label10.Text = "C07";
            this.label10.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 277);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label3.Size = new System.Drawing.Size(141, 86);
            this.label3.TabIndex = 42;
            this.label3.Text = "C03";
            this.label3.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSalmon;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(167, 377);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label9.Size = new System.Drawing.Size(141, 86);
            this.label9.TabIndex = 42;
            this.label9.Text = "C09";
            this.label9.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 476);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label2.Size = new System.Drawing.Size(141, 86);
            this.label2.TabIndex = 42;
            this.label2.Text = "C05";
            this.label2.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(167, 277);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label8.Size = new System.Drawing.Size(141, 86);
            this.label8.TabIndex = 42;
            this.label8.Text = "C08";
            this.label8.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSalmon;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(167, 476);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label7.Size = new System.Drawing.Size(141, 86);
            this.label7.TabIndex = 42;
            this.label7.Text = "C10";
            this.label7.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(167, 79);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label6.Size = new System.Drawing.Size(141, 86);
            this.label6.TabIndex = 42;
            this.label6.Text = "C06";
            this.label6.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // gpbPuestos
            // 
            this.gpbPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbPuestos.AutoSize = true;
            this.gpbPuestos.Controls.Add(this.lblCab5);
            this.gpbPuestos.Controls.Add(this.label7);
            this.gpbPuestos.Controls.Add(this.label9);
            this.gpbPuestos.Controls.Add(this.lblCab4);
            this.gpbPuestos.Controls.Add(this.label8);
            this.gpbPuestos.Controls.Add(this.lblCabinas);
            this.gpbPuestos.Controls.Add(this.lblCab3);
            this.gpbPuestos.Controls.Add(this.label10);
            this.gpbPuestos.Controls.Add(this.lblCab2);
            this.gpbPuestos.Controls.Add(this.label6);
            this.gpbPuestos.Controls.Add(this.label2);
            this.gpbPuestos.Controls.Add(this.lblCab1);
            this.gpbPuestos.Controls.Add(this.label4);
            this.gpbPuestos.Controls.Add(this.label3);
            this.gpbPuestos.Controls.Add(this.label5);
            this.gpbPuestos.Controls.Add(this.label1);
            this.gpbPuestos.Controls.Add(this.lblComputadoras);
            this.gpbPuestos.Location = new System.Drawing.Point(12, 13);
            this.gpbPuestos.Name = "gpbPuestos";
            this.gpbPuestos.Size = new System.Drawing.Size(516, 588);
            this.gpbPuestos.TabIndex = 36;
            this.gpbPuestos.TabStop = false;
            this.gpbPuestos.Text = "groupBox2";
            // 
            // lblCab5
            // 
            this.lblCab5.AutoSize = true;
            this.lblCab5.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCab5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCab5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCab5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCab5.Location = new System.Drawing.Point(352, 476);
            this.lblCab5.Margin = new System.Windows.Forms.Padding(3);
            this.lblCab5.Name = "lblCab5";
            this.lblCab5.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblCab5.Size = new System.Drawing.Size(140, 86);
            this.lblCab5.TabIndex = 42;
            this.lblCab5.Text = "T05";
            this.lblCab5.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblCab4
            // 
            this.lblCab4.AutoSize = true;
            this.lblCab4.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCab4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCab4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCab4.Location = new System.Drawing.Point(352, 377);
            this.lblCab4.Name = "lblCab4";
            this.lblCab4.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblCab4.Size = new System.Drawing.Size(140, 86);
            this.lblCab4.TabIndex = 42;
            this.lblCab4.Text = "T04";
            this.lblCab4.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblCabinas
            // 
            this.lblCabinas.AutoSize = true;
            this.lblCabinas.Font = new System.Drawing.Font("DejaVu Sans Mono", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCabinas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCabinas.Location = new System.Drawing.Point(389, -10);
            this.lblCabinas.Name = "lblCabinas";
            this.lblCabinas.Size = new System.Drawing.Size(103, 74);
            this.lblCabinas.TabIndex = 5;
            this.lblCabinas.Text = "📞";
            // 
            // lblCab3
            // 
            this.lblCab3.AutoSize = true;
            this.lblCab3.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCab3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCab3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCab3.Location = new System.Drawing.Point(352, 276);
            this.lblCab3.Name = "lblCab3";
            this.lblCab3.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblCab3.Size = new System.Drawing.Size(140, 86);
            this.lblCab3.TabIndex = 42;
            this.lblCab3.Text = "T03";
            this.lblCab3.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblCab2
            // 
            this.lblCab2.AutoSize = true;
            this.lblCab2.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCab2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCab2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCab2.Location = new System.Drawing.Point(352, 179);
            this.lblCab2.Name = "lblCab2";
            this.lblCab2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblCab2.Size = new System.Drawing.Size(140, 86);
            this.lblCab2.TabIndex = 42;
            this.lblCab2.Text = "T02";
            this.lblCab2.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblCab1
            // 
            this.lblCab1.AutoSize = true;
            this.lblCab1.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCab1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCab1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCab1.Location = new System.Drawing.Point(352, 79);
            this.lblCab1.Name = "lblCab1";
            this.lblCab1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.lblCab1.Size = new System.Drawing.Size(140, 86);
            this.lblCab1.TabIndex = 42;
            this.lblCab1.Text = "T01";
            this.lblCab1.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.label1.Size = new System.Drawing.Size(141, 86);
            this.label1.TabIndex = 42;
            this.label1.Text = "C01";
            this.label1.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // FormCibercafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.gpbPuestos);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCibercafe";
            this.Activated += new System.EventHandler(this.FormCibercafe_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCibercafe_FormClosing);
            this.Load += new System.EventHandler(this.FormCibercafe_Load);
            this.Controls.SetChildIndex(this.pnlBarraInfo, 0);
            this.Controls.SetChildIndex(this.lblClientes, 0);
            this.Controls.SetChildIndex(this.lstCliente, 0);
            this.Controls.SetChildIndex(this.gpbPuestos, 0);
            this.Controls.SetChildIndex(this.btnEstadisticas, 0);
            this.Controls.SetChildIndex(this.btnAsignar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.pnlBarraInfo.ResumeLayout(false);
            this.pnlBarraInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPuestos.ResumeLayout(false);
            this.gpbPuestos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.RadioButton rdbCabina;
        private System.Windows.Forms.RadioButton rdbPc;
        private System.Windows.Forms.GroupBox gpbServicio;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblComputadoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbPuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCab5;
        private System.Windows.Forms.Label lblCab4;
        private System.Windows.Forms.Label lblCabinas;
        private System.Windows.Forms.Label lblCab3;
        private System.Windows.Forms.Label lblCab2;
        private System.Windows.Forms.Label lblCab1;
    }
}