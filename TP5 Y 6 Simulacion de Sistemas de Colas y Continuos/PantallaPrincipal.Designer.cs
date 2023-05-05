namespace TP5_Simulacion_de_Sistemas_de_Colas
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
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbSemilla = new System.Windows.Forms.CheckBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gbColas = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbEventos = new System.Windows.Forms.GroupBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbExponencialOficina = new System.Windows.Forms.CheckBox();
            this.txtMediaExponencialOficina = new System.Windows.Forms.TextBox();
            this.cbExponencialRevision = new System.Windows.Forms.CheckBox();
            this.txtLambdaExponencialRevision = new System.Windows.Forms.TextBox();
            this.cbExponencialCaseta = new System.Windows.Forms.CheckBox();
            this.txtMediaExponencialCaseta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPoissonLlegadas = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLambdaPoissonLlegadas = new System.Windows.Forms.TextBox();
            this.gbObjetos = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbOficina = new System.Windows.Forms.CheckBox();
            this.txtCantidadOficina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCaseta = new System.Windows.Forms.CheckBox();
            this.txtCantidadCaseta = new System.Windows.Forms.TextBox();
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
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbParametros.SuspendLayout();
            this.gbColas.SuspendLayout();
            this.gbEventos.SuspendLayout();
            this.gbObjetos.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnGuardar);
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
            this.gbParametros.Location = new System.Drawing.Point(4, 13);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(1319, 264);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(9, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 44);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar para comparar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbSemilla
            // 
            this.cbSemilla.AutoSize = true;
            this.cbSemilla.Location = new System.Drawing.Point(9, 140);
            this.cbSemilla.Name = "cbSemilla";
            this.cbSemilla.Size = new System.Drawing.Size(159, 20);
            this.cbSemilla.TabIndex = 17;
            this.cbSemilla.Text = "Utilizar misma semilla";
            this.cbSemilla.UseVisualStyleBackColor = true;
            this.cbSemilla.CheckedChanged += new System.EventHandler(this.cbSemilla_CheckedChanged);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSimular.Location = new System.Drawing.Point(200, 202);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(106, 46);
            this.btnSimular.TabIndex = 16;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gbColas
            // 
            this.gbColas.Controls.Add(this.label23);
            this.gbColas.Controls.Add(this.label19);
            this.gbColas.Controls.Add(this.label18);
            this.gbColas.Controls.Add(this.label17);
            this.gbColas.Location = new System.Drawing.Point(1085, 22);
            this.gbColas.Name = "gbColas";
            this.gbColas.Size = new System.Drawing.Size(228, 236);
            this.gbColas.TabIndex = 15;
            this.gbColas.TabStop = false;
            this.gbColas.Text = "Colas";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 16);
            this.label23.TabIndex = 37;
            this.label23.Text = "Cola de Bloqueo - FIFO - Max 15";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "Cola de Oficina - FIFO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Cola de Revision - FIFO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Cola de Caseta - FIFO - Max 15";
            // 
            // gbEventos
            // 
            this.gbEventos.Controls.Add(this.cbH);
            this.gbEventos.Controls.Add(this.txtH);
            this.gbEventos.Controls.Add(this.label24);
            this.gbEventos.Controls.Add(this.label22);
            this.gbEventos.Controls.Add(this.label21);
            this.gbEventos.Controls.Add(this.cbExponencialOficina);
            this.gbEventos.Controls.Add(this.txtMediaExponencialOficina);
            this.gbEventos.Controls.Add(this.cbExponencialRevision);
            this.gbEventos.Controls.Add(this.txtLambdaExponencialRevision);
            this.gbEventos.Controls.Add(this.cbExponencialCaseta);
            this.gbEventos.Controls.Add(this.txtMediaExponencialCaseta);
            this.gbEventos.Controls.Add(this.label16);
            this.gbEventos.Controls.Add(this.label15);
            this.gbEventos.Controls.Add(this.label14);
            this.gbEventos.Controls.Add(this.cbPoissonLlegadas);
            this.gbEventos.Controls.Add(this.label13);
            this.gbEventos.Controls.Add(this.txtLambdaPoissonLlegadas);
            this.gbEventos.Location = new System.Drawing.Point(668, 21);
            this.gbEventos.Name = "gbEventos";
            this.gbEventos.Size = new System.Drawing.Size(411, 239);
            this.gbEventos.TabIndex = 15;
            this.gbEventos.TabStop = false;
            this.gbEventos.Text = "Eventos";
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(196, 211);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(15, 14);
            this.cbH.TabIndex = 38;
            this.cbH.UseVisualStyleBackColor = true;
            this.cbH.CheckedChanged += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(147, 206);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(43, 23);
            this.txtH.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "h (paso de Ec. Dif.):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 177);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(271, 16);
            this.label22.TabIndex = 35;
            this.label22.Text = "Fin Bloqueo - Segun Ecuacion Diferencial";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(302, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Llegada Bloqueo - Segun Ecuacion Diferencial";
            // 
            // cbExponencialOficina
            // 
            this.cbExponencialOficina.AutoSize = true;
            this.cbExponencialOficina.Location = new System.Drawing.Point(364, 121);
            this.cbExponencialOficina.Name = "cbExponencialOficina";
            this.cbExponencialOficina.Size = new System.Drawing.Size(15, 14);
            this.cbExponencialOficina.TabIndex = 33;
            this.cbExponencialOficina.UseVisualStyleBackColor = true;
            this.cbExponencialOficina.CheckedChanged += new System.EventHandler(this.cbExponencialOficina_CheckedChanged);
            // 
            // txtMediaExponencialOficina
            // 
            this.txtMediaExponencialOficina.Location = new System.Drawing.Point(315, 116);
            this.txtMediaExponencialOficina.Name = "txtMediaExponencialOficina";
            this.txtMediaExponencialOficina.Size = new System.Drawing.Size(43, 23);
            this.txtMediaExponencialOficina.TabIndex = 32;
            // 
            // cbExponencialRevision
            // 
            this.cbExponencialRevision.AutoSize = true;
            this.cbExponencialRevision.Location = new System.Drawing.Point(373, 88);
            this.cbExponencialRevision.Name = "cbExponencialRevision";
            this.cbExponencialRevision.Size = new System.Drawing.Size(15, 14);
            this.cbExponencialRevision.TabIndex = 31;
            this.cbExponencialRevision.UseVisualStyleBackColor = true;
            this.cbExponencialRevision.CheckedChanged += new System.EventHandler(this.cbExponencialRevision_CheckedChanged);
            // 
            // txtLambdaExponencialRevision
            // 
            this.txtLambdaExponencialRevision.Location = new System.Drawing.Point(324, 83);
            this.txtLambdaExponencialRevision.Name = "txtLambdaExponencialRevision";
            this.txtLambdaExponencialRevision.Size = new System.Drawing.Size(43, 23);
            this.txtLambdaExponencialRevision.TabIndex = 30;
            // 
            // cbExponencialCaseta
            // 
            this.cbExponencialCaseta.AutoSize = true;
            this.cbExponencialCaseta.Location = new System.Drawing.Point(364, 56);
            this.cbExponencialCaseta.Name = "cbExponencialCaseta";
            this.cbExponencialCaseta.Size = new System.Drawing.Size(15, 14);
            this.cbExponencialCaseta.TabIndex = 29;
            this.cbExponencialCaseta.UseVisualStyleBackColor = true;
            this.cbExponencialCaseta.CheckedChanged += new System.EventHandler(this.cbExponencialCaseta_CheckedChanged);
            // 
            // txtMediaExponencialCaseta
            // 
            this.txtMediaExponencialCaseta.Location = new System.Drawing.Point(315, 51);
            this.txtMediaExponencialCaseta.Name = "txtMediaExponencialCaseta";
            this.txtMediaExponencialCaseta.Size = new System.Drawing.Size(43, 23);
            this.txtMediaExponencialCaseta.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(302, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Fin Oficina i - Distribucion Exponencial (media)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(312, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Fin Revision i - Distribucion Exponencial (media)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Fin Caseta i - Distribucion Exponencial (media)";
            // 
            // cbPoissonLlegadas
            // 
            this.cbPoissonLlegadas.AutoSize = true;
            this.cbPoissonLlegadas.Location = new System.Drawing.Point(385, 26);
            this.cbPoissonLlegadas.Name = "cbPoissonLlegadas";
            this.cbPoissonLlegadas.Size = new System.Drawing.Size(15, 14);
            this.cbPoissonLlegadas.TabIndex = 24;
            this.cbPoissonLlegadas.UseVisualStyleBackColor = true;
            this.cbPoissonLlegadas.CheckedChanged += new System.EventHandler(this.cbPoissonLlegadas_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(326, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Llegada Cliente - Distribucion Exponencial (media)";
            // 
            // txtLambdaPoissonLlegadas
            // 
            this.txtLambdaPoissonLlegadas.Location = new System.Drawing.Point(336, 21);
            this.txtLambdaPoissonLlegadas.Name = "txtLambdaPoissonLlegadas";
            this.txtLambdaPoissonLlegadas.Size = new System.Drawing.Size(43, 23);
            this.txtLambdaPoissonLlegadas.TabIndex = 23;
            // 
            // gbObjetos
            // 
            this.gbObjetos.Controls.Add(this.label20);
            this.gbObjetos.Controls.Add(this.cbOficina);
            this.gbObjetos.Controls.Add(this.txtCantidadOficina);
            this.gbObjetos.Controls.Add(this.label12);
            this.gbObjetos.Controls.Add(this.label11);
            this.gbObjetos.Controls.Add(this.cbCaseta);
            this.gbObjetos.Controls.Add(this.txtCantidadCaseta);
            this.gbObjetos.Controls.Add(this.label10);
            this.gbObjetos.Controls.Add(this.label9);
            this.gbObjetos.Location = new System.Drawing.Point(312, 19);
            this.gbObjetos.Name = "gbObjetos";
            this.gbObjetos.Size = new System.Drawing.Size(350, 239);
            this.gbObjetos.TabIndex = 14;
            this.gbObjetos.TabStop = false;
            this.gbObjetos.Text = "Objetos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 197);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(200, 32);
            this.label20.TabIndex = 23;
            this.label20.Text = "Bloqueo - P(1) [FueraSistema,\r\nBloqLlegadas, BloqOficina]";
            // 
            // cbOficina
            // 
            this.cbOficina.AutoSize = true;
            this.cbOficina.Location = new System.Drawing.Point(261, 160);
            this.cbOficina.Name = "cbOficina";
            this.cbOficina.Size = new System.Drawing.Size(15, 14);
            this.cbOficina.TabIndex = 22;
            this.cbOficina.UseVisualStyleBackColor = true;
            this.cbOficina.CheckedChanged += new System.EventHandler(this.cbOficina_CheckedChanged);
            // 
            // txtCantidadOficina
            // 
            this.txtCantidadOficina.Location = new System.Drawing.Point(212, 155);
            this.txtCantidadOficina.Name = "txtCantidadOficina";
            this.txtCantidadOficina.Size = new System.Drawing.Size(43, 23);
            this.txtCantidadOficina.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 32);
            this.label12.TabIndex = 20;
            this.label12.Text = "Empleado Oficina - P(1-n) \r\n[Libre, Ocupado, SBloqueada]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Circuito Revision - P(2) - [Libre, Ocupado]";
            // 
            // cbCaseta
            // 
            this.cbCaseta.AutoSize = true;
            this.cbCaseta.Location = new System.Drawing.Point(238, 90);
            this.cbCaseta.Name = "cbCaseta";
            this.cbCaseta.Size = new System.Drawing.Size(15, 14);
            this.cbCaseta.TabIndex = 18;
            this.cbCaseta.UseVisualStyleBackColor = true;
            this.cbCaseta.CheckedChanged += new System.EventHandler(this.cbCaseta_CheckedChanged);
            // 
            // txtCantidadCaseta
            // 
            this.txtCantidadCaseta.Location = new System.Drawing.Point(189, 85);
            this.txtCantidadCaseta.Name = "txtCantidadCaseta";
            this.txtCantidadCaseta.Size = new System.Drawing.Size(43, 23);
            this.txtCantidadCaseta.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 64);
            this.label10.TabIndex = 1;
            this.label10.Text = "Clientes - T(0-n) - Tiempo llegada sistema,\r\nTiempo llegada oficina - [ECCaseta, " +
    "ACaseta-i,\r\nECRevision, ARevision-i, ECOficina, AOficina-i,\r\nECBloqueo, ServInte" +
    "rrumpido]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Empleado Caseta - P(1-n) \r\n[Libre, Ocupado]";
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
            this.label5.Size = new System.Drawing.Size(153, 16);
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
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo a Simular:";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.progressBar1);
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.Location = new System.Drawing.Point(4, 283);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1319, 393);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(9, 21);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 10;
            this.dgvResultados.Size = new System.Drawing.Size(1304, 364);
            this.dgvResultados.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1319, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 678);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbParametros);
            this.Name = "PantallaPrincipal";
            this.Text = "TP5 - Simulacion ITV";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbColas.ResumeLayout(false);
            this.gbColas.PerformLayout();
            this.gbEventos.ResumeLayout(false);
            this.gbEventos.PerformLayout();
            this.gbObjetos.ResumeLayout(false);
            this.gbObjetos.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox gbColas;
        private System.Windows.Forms.GroupBox gbEventos;
        private System.Windows.Forms.GroupBox gbObjetos;
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
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.CheckBox cbPoissonLlegadas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLambdaPoissonLlegadas;
        private System.Windows.Forms.CheckBox cbOficina;
        private System.Windows.Forms.TextBox txtCantidadOficina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbCaseta;
        private System.Windows.Forms.TextBox txtCantidadCaseta;
        private System.Windows.Forms.CheckBox cbSemilla;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbExponencialOficina;
        private System.Windows.Forms.TextBox txtMediaExponencialOficina;
        private System.Windows.Forms.CheckBox cbExponencialRevision;
        private System.Windows.Forms.TextBox txtLambdaExponencialRevision;
        private System.Windows.Forms.CheckBox cbExponencialCaseta;
        private System.Windows.Forms.TextBox txtMediaExponencialCaseta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

