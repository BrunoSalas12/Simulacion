namespace TP7_Individual
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.cbSemilla = new System.Windows.Forms.CheckBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gbColas = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbEventos = new System.Windows.Forms.GroupBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbLlegadaCOVID = new System.Windows.Forms.CheckBox();
            this.txtMediaLlegadaCOVID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLlegadaGripe = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMediaLlegadaGripe = new System.Windows.Forms.TextBox();
            this.gbObjetos = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEnfermero = new System.Windows.Forms.CheckBox();
            this.txtCantidadEnfermero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinutosMostrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHorasMostrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasMostrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinutosSimular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasSimular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasSimular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.gbColas.SuspendLayout();
            this.gbEventos.SuspendLayout();
            this.gbObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.progressBar1);
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.Location = new System.Drawing.Point(8, 251);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1319, 420);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1319, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(9, 21);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 10;
            this.dgvResultados.Size = new System.Drawing.Size(1304, 393);
            this.dgvResultados.TabIndex = 0;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.cbSemilla);
            this.gbParametros.Controls.Add(this.btnSimular);
            this.gbParametros.Controls.Add(this.gbColas);
            this.gbParametros.Controls.Add(this.gbEventos);
            this.gbParametros.Controls.Add(this.gbObjetos);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.txtMinutosMostrar);
            this.gbParametros.Controls.Add(this.label7);
            this.gbParametros.Controls.Add(this.txtHorasMostrar);
            this.gbParametros.Controls.Add(this.label8);
            this.gbParametros.Controls.Add(this.txtDiasMostrar);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.txtMinutosSimular);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.txtHorasSimular);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.txtDiasSimular);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Font = new System.Drawing.Font("Arial", 10F);
            this.gbParametros.Location = new System.Drawing.Point(8, 8);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(1319, 237);
            this.gbParametros.TabIndex = 2;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // cbSemilla
            // 
            this.cbSemilla.AutoSize = true;
            this.cbSemilla.Location = new System.Drawing.Point(9, 140);
            this.cbSemilla.Name = "cbSemilla";
            this.cbSemilla.Size = new System.Drawing.Size(158, 20);
            this.cbSemilla.TabIndex = 17;
            this.cbSemilla.Text = "Utilizar misma semilla";
            this.cbSemilla.UseVisualStyleBackColor = true;
            this.cbSemilla.CheckedChanged += new System.EventHandler(this.cbSemilla_CheckedChanged);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSimular.Location = new System.Drawing.Point(200, 172);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(106, 46);
            this.btnSimular.TabIndex = 16;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gbColas
            // 
            this.gbColas.Controls.Add(this.label18);
            this.gbColas.Controls.Add(this.label17);
            this.gbColas.Location = new System.Drawing.Point(1085, 22);
            this.gbColas.Name = "gbColas";
            this.gbColas.Size = new System.Drawing.Size(228, 208);
            this.gbColas.TabIndex = 15;
            this.gbColas.TabStop = false;
            this.gbColas.Text = "Colas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Cola Clientes COVID - FIFO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Cola Clientes Gripe - FIFO";
            // 
            // gbEventos
            // 
            this.gbEventos.Controls.Add(this.cbH);
            this.gbEventos.Controls.Add(this.txtH);
            this.gbEventos.Controls.Add(this.label24);
            this.gbEventos.Controls.Add(this.label21);
            this.gbEventos.Controls.Add(this.cbLlegadaCOVID);
            this.gbEventos.Controls.Add(this.txtMediaLlegadaCOVID);
            this.gbEventos.Controls.Add(this.label16);
            this.gbEventos.Controls.Add(this.label15);
            this.gbEventos.Controls.Add(this.label14);
            this.gbEventos.Controls.Add(this.cbLlegadaGripe);
            this.gbEventos.Controls.Add(this.label13);
            this.gbEventos.Controls.Add(this.txtMediaLlegadaGripe);
            this.gbEventos.Location = new System.Drawing.Point(668, 21);
            this.gbEventos.Name = "gbEventos";
            this.gbEventos.Size = new System.Drawing.Size(411, 209);
            this.gbEventos.TabIndex = 15;
            this.gbEventos.TabStop = false;
            this.gbEventos.Text = "Eventos";
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(207, 179);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(15, 14);
            this.cbH.TabIndex = 38;
            this.cbH.UseVisualStyleBackColor = true;
            this.cbH.CheckedChanged += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(158, 174);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(43, 23);
            this.txtH.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 177);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "h (paso de Ec. Dif.):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(328, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Vencimiento Vacunas - Segun Ecuacion Diferencial";
            // 
            // cbLlegadaCOVID
            // 
            this.cbLlegadaCOVID.AutoSize = true;
            this.cbLlegadaCOVID.Location = new System.Drawing.Point(362, 56);
            this.cbLlegadaCOVID.Name = "cbLlegadaCOVID";
            this.cbLlegadaCOVID.Size = new System.Drawing.Size(15, 14);
            this.cbLlegadaCOVID.TabIndex = 29;
            this.cbLlegadaCOVID.UseVisualStyleBackColor = true;
            this.cbLlegadaCOVID.CheckedChanged += new System.EventHandler(this.cbLlegadaCOVID_CheckedChanged);
            // 
            // txtMediaLlegadaCOVID
            // 
            this.txtMediaLlegadaCOVID.Location = new System.Drawing.Point(313, 51);
            this.txtMediaLlegadaCOVID.Name = "txtMediaLlegadaCOVID";
            this.txtMediaLlegadaCOVID.Size = new System.Drawing.Size(43, 23);
            this.txtMediaLlegadaCOVID.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Fin Vacunacion - ((22*N)/60)\'";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 32);
            this.label15.TabIndex = 26;
            this.label15.Text = "Los clientes llegan en gurpos de 1 a 4\r\npersonas con distribucion uniforme";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Llegada Clientes COVID - Exponencial (media)";
            // 
            // cbLlegadaGripe
            // 
            this.cbLlegadaGripe.AutoSize = true;
            this.cbLlegadaGripe.Location = new System.Drawing.Point(354, 26);
            this.cbLlegadaGripe.Name = "cbLlegadaGripe";
            this.cbLlegadaGripe.Size = new System.Drawing.Size(15, 14);
            this.cbLlegadaGripe.TabIndex = 24;
            this.cbLlegadaGripe.UseVisualStyleBackColor = true;
            this.cbLlegadaGripe.CheckedChanged += new System.EventHandler(this.cbLlegadaGripe_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Llegada Clientes Gripe - Exponencial (media)";
            // 
            // txtMediaLlegadaGripe
            // 
            this.txtMediaLlegadaGripe.Location = new System.Drawing.Point(305, 21);
            this.txtMediaLlegadaGripe.Name = "txtMediaLlegadaGripe";
            this.txtMediaLlegadaGripe.Size = new System.Drawing.Size(43, 23);
            this.txtMediaLlegadaGripe.TabIndex = 23;
            // 
            // gbObjetos
            // 
            this.gbObjetos.Controls.Add(this.label20);
            this.gbObjetos.Controls.Add(this.label11);
            this.gbObjetos.Controls.Add(this.cbEnfermero);
            this.gbObjetos.Controls.Add(this.txtCantidadEnfermero);
            this.gbObjetos.Controls.Add(this.label10);
            this.gbObjetos.Controls.Add(this.label9);
            this.gbObjetos.Location = new System.Drawing.Point(312, 19);
            this.gbObjetos.Name = "gbObjetos";
            this.gbObjetos.Size = new System.Drawing.Size(350, 211);
            this.gbObjetos.TabIndex = 14;
            this.gbObjetos.TabStop = false;
            this.gbObjetos.Text = "Objetos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(311, 32);
            this.label20.TabIndex = 23;
            this.label20.Text = "Cliente COVID - T(0-n) - [SiendoVacunado (SV),\r\nEsperandoVacunacion (EV)]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cliente Gripe - T(0-n) - [SiendoVacunados (SV),\r\nEsperandoVacunacion (EV)]";
            // 
            // cbEnfermero
            // 
            this.cbEnfermero.AutoSize = true;
            this.cbEnfermero.Location = new System.Drawing.Point(323, 22);
            this.cbEnfermero.Name = "cbEnfermero";
            this.cbEnfermero.Size = new System.Drawing.Size(15, 14);
            this.cbEnfermero.TabIndex = 18;
            this.cbEnfermero.UseVisualStyleBackColor = true;
            this.cbEnfermero.CheckedChanged += new System.EventHandler(this.cbEnfermero_CheckedChanged);
            // 
            // txtCantidadEnfermero
            // 
            this.txtCantidadEnfermero.Location = new System.Drawing.Point(274, 17);
            this.txtCantidadEnfermero.Name = "txtCantidadEnfermero";
            this.txtCantidadEnfermero.Size = new System.Drawing.Size(43, 23);
            this.txtCantidadEnfermero.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 48);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enfermero - P(1-n) - Ultima Vacunacion -\r\n[Libre, VacunandoGripe (VG),\r\nVacunando" +
    "COVID (VC)]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Caja Vacunas Gripe - T(0-n) - Dosis Restantes\r\n[Abierta]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(268, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "mins.";
            // 
            // txtMinutosMostrar
            // 
            this.txtMinutosMostrar.Location = new System.Drawing.Point(263, 84);
            this.txtMinutosMostrar.Name = "txtMinutosMostrar";
            this.txtMinutosMostrar.Size = new System.Drawing.Size(43, 23);
            this.txtMinutosMostrar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(218, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "horas";
            // 
            // txtHorasMostrar
            // 
            this.txtHorasMostrar.Location = new System.Drawing.Point(214, 84);
            this.txtHorasMostrar.Name = "txtHorasMostrar";
            this.txtHorasMostrar.Size = new System.Drawing.Size(43, 23);
            this.txtHorasMostrar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(170, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "dias";
            // 
            // txtDiasMostrar
            // 
            this.txtDiasMostrar.Location = new System.Drawing.Point(165, 84);
            this.txtDiasMostrar.Name = "txtDiasMostrar";
            this.txtDiasMostrar.Size = new System.Drawing.Size(43, 23);
            this.txtDiasMostrar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mostrar desde Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(236, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "mins.";
            // 
            // txtMinutosSimular
            // 
            this.txtMinutosSimular.Location = new System.Drawing.Point(231, 36);
            this.txtMinutosSimular.Name = "txtMinutosSimular";
            this.txtMinutosSimular.Size = new System.Drawing.Size(43, 23);
            this.txtMinutosSimular.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(186, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "horas";
            // 
            // txtHorasSimular
            // 
            this.txtHorasSimular.Location = new System.Drawing.Point(182, 36);
            this.txtHorasSimular.Name = "txtHorasSimular";
            this.txtHorasSimular.Size = new System.Drawing.Size(43, 23);
            this.txtHorasSimular.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(138, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "dias";
            // 
            // txtDiasSimular
            // 
            this.txtDiasSimular.Location = new System.Drawing.Point(133, 36);
            this.txtDiasSimular.Name = "txtDiasSimular";
            this.txtDiasSimular.Size = new System.Drawing.Size(43, 23);
            this.txtDiasSimular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo a Simular:";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 678);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbParametros);
            this.Name = "PantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbColas.ResumeLayout(false);
            this.gbColas.PerformLayout();
            this.gbEventos.ResumeLayout(false);
            this.gbEventos.PerformLayout();
            this.gbObjetos.ResumeLayout(false);
            this.gbObjetos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.CheckBox cbSemilla;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox gbColas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbEventos;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbLlegadaCOVID;
        private System.Windows.Forms.TextBox txtMediaLlegadaCOVID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbLlegadaGripe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMediaLlegadaGripe;
        private System.Windows.Forms.GroupBox gbObjetos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbEnfermero;
        private System.Windows.Forms.TextBox txtCantidadEnfermero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinutosMostrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHorasMostrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinutosSimular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasSimular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiasSimular;
        private System.Windows.Forms.Label label1;
    }
}

