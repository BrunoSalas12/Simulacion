namespace TP4_Simulacion_de_Montecarlo_Puerto
{
    partial class TP4MontecarloPuerto
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
            this.components = new System.ComponentModel.Container();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnSimularDosMuelles = new System.Windows.Forms.Button();
            this.btnCargarCongUniforme = new System.Windows.Forms.Button();
            this.cbCargarCongUniforme = new System.Windows.Forms.CheckBox();
            this.cbParamsUniformeDescargas = new System.Windows.Forms.CheckBox();
            this.txtBUniformeDescargas = new System.Windows.Forms.TextBox();
            this.txtAUniformeDescargas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarCongPoisson = new System.Windows.Forms.Button();
            this.cbCargarCongPoisson = new System.Windows.Forms.CheckBox();
            this.cbParamPoissonLlegadas = new System.Windows.Forms.CheckBox();
            this.txtLambdaPoissonLlegadas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimularUnMuelle = new System.Windows.Forms.Button();
            this.cbCostoMuelleVacio = new System.Windows.Forms.CheckBox();
            this.txtCostoMuelleVacio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParamCostoNoche = new System.Windows.Forms.CheckBox();
            this.txtCostoPasarNoche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarCongDescargas = new System.Windows.Forms.Button();
            this.btnCargarCongLlegadas = new System.Windows.Forms.Button();
            this.btnCargarCongNormal = new System.Windows.Forms.Button();
            this.cbCargarCongDescargas = new System.Windows.Forms.CheckBox();
            this.cbCargarCongLlegadas = new System.Windows.Forms.CheckBox();
            this.cbCargarCongNormal = new System.Windows.Forms.CheckBox();
            this.cbParamsNormalGanancia = new System.Windows.Forms.CheckBox();
            this.txtDesviacionNormalGanancia = new System.Windows.Forms.TextBox();
            this.txtMediaNormalGanancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilaMostrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadSimular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.pgbSimulacion = new System.Windows.Forms.ProgressBar();
            this.dgvResultadosDosM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDDescargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDescargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcosPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcosConRetraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasOcupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GananciasDescargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostosPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostosPorVacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtilidadesTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtilidadesAcumuladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTbtnsCargarParams = new System.Windows.Forms.ToolTip(this.components);
            this.btnHorasLlegada = new System.Windows.Forms.Button();
            this.gbParametros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosDosM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnHorasLlegada);
            this.gbParametros.Controls.Add(this.btnSimularDosMuelles);
            this.gbParametros.Controls.Add(this.btnCargarCongUniforme);
            this.gbParametros.Controls.Add(this.cbCargarCongUniforme);
            this.gbParametros.Controls.Add(this.cbParamsUniformeDescargas);
            this.gbParametros.Controls.Add(this.txtBUniformeDescargas);
            this.gbParametros.Controls.Add(this.txtAUniformeDescargas);
            this.gbParametros.Controls.Add(this.label7);
            this.gbParametros.Controls.Add(this.btnCargarCongPoisson);
            this.gbParametros.Controls.Add(this.cbCargarCongPoisson);
            this.gbParametros.Controls.Add(this.cbParamPoissonLlegadas);
            this.gbParametros.Controls.Add(this.txtLambdaPoissonLlegadas);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.btnSimularUnMuelle);
            this.gbParametros.Controls.Add(this.cbCostoMuelleVacio);
            this.gbParametros.Controls.Add(this.txtCostoMuelleVacio);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.cbParamCostoNoche);
            this.gbParametros.Controls.Add(this.txtCostoPasarNoche);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.btnCargarCongDescargas);
            this.gbParametros.Controls.Add(this.btnCargarCongLlegadas);
            this.gbParametros.Controls.Add(this.btnCargarCongNormal);
            this.gbParametros.Controls.Add(this.cbCargarCongDescargas);
            this.gbParametros.Controls.Add(this.cbCargarCongLlegadas);
            this.gbParametros.Controls.Add(this.cbCargarCongNormal);
            this.gbParametros.Controls.Add(this.cbParamsNormalGanancia);
            this.gbParametros.Controls.Add(this.txtDesviacionNormalGanancia);
            this.gbParametros.Controls.Add(this.txtMediaNormalGanancia);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.txtFilaMostrar);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.txtCantidadSimular);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(1260, 201);
            this.gbParametros.TabIndex = 1;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // btnSimularDosMuelles
            // 
            this.btnSimularDosMuelles.Location = new System.Drawing.Point(810, 151);
            this.btnSimularDosMuelles.Name = "btnSimularDosMuelles";
            this.btnSimularDosMuelles.Size = new System.Drawing.Size(250, 44);
            this.btnSimularDosMuelles.TabIndex = 21;
            this.btnSimularDosMuelles.Text = "Simular N Dias con dos Muelles";
            this.btnSimularDosMuelles.UseVisualStyleBackColor = true;
            this.btnSimularDosMuelles.Click += new System.EventHandler(this.btnSimularDosMuelles_Click);
            // 
            // btnCargarCongUniforme
            // 
            this.btnCargarCongUniforme.Location = new System.Drawing.Point(738, 116);
            this.btnCargarCongUniforme.Name = "btnCargarCongUniforme";
            this.btnCargarCongUniforme.Size = new System.Drawing.Size(388, 26);
            this.btnCargarCongUniforme.TabIndex = 20;
            this.btnCargarCongUniforme.Text = "Cargar Parametros Generador para Uniforme";
            this.TTbtnsCargarParams.SetToolTip(this.btnCargarCongUniforme, "Se piden los parametros (X0, a, m, c) para\r\nel Generador Congruelcial Mixto que s" +
        "e\r\nutilizara para generar los Uniformes(A,B)\r\n");
            this.btnCargarCongUniforme.UseVisualStyleBackColor = true;
            this.btnCargarCongUniforme.Click += new System.EventHandler(this.btnCargarCongUniforme_Click);
            // 
            // cbCargarCongUniforme
            // 
            this.cbCargarCongUniforme.AutoSize = true;
            this.cbCargarCongUniforme.Enabled = false;
            this.cbCargarCongUniforme.Location = new System.Drawing.Point(1132, 123);
            this.cbCargarCongUniforme.Name = "cbCargarCongUniforme";
            this.cbCargarCongUniforme.Size = new System.Drawing.Size(15, 14);
            this.cbCargarCongUniforme.TabIndex = 0;
            this.cbCargarCongUniforme.TabStop = false;
            this.cbCargarCongUniforme.UseVisualStyleBackColor = true;
            // 
            // cbParamsUniformeDescargas
            // 
            this.cbParamsUniformeDescargas.AutoSize = true;
            this.cbParamsUniformeDescargas.Checked = true;
            this.cbParamsUniformeDescargas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParamsUniformeDescargas.Location = new System.Drawing.Point(1132, 90);
            this.cbParamsUniformeDescargas.Name = "cbParamsUniformeDescargas";
            this.cbParamsUniformeDescargas.Size = new System.Drawing.Size(15, 14);
            this.cbParamsUniformeDescargas.TabIndex = 19;
            this.cbParamsUniformeDescargas.UseVisualStyleBackColor = true;
            this.cbParamsUniformeDescargas.CheckedChanged += new System.EventHandler(this.cbParamsUniformeDescargas_CheckedChanged);
            // 
            // txtBUniformeDescargas
            // 
            this.txtBUniformeDescargas.Enabled = false;
            this.txtBUniformeDescargas.Location = new System.Drawing.Point(1066, 84);
            this.txtBUniformeDescargas.Name = "txtBUniformeDescargas";
            this.txtBUniformeDescargas.Size = new System.Drawing.Size(60, 26);
            this.txtBUniformeDescargas.TabIndex = 18;
            // 
            // txtAUniformeDescargas
            // 
            this.txtAUniformeDescargas.Enabled = false;
            this.txtAUniformeDescargas.Location = new System.Drawing.Point(1000, 84);
            this.txtAUniformeDescargas.Name = "txtAUniformeDescargas";
            this.txtAUniformeDescargas.Size = new System.Drawing.Size(60, 26);
            this.txtAUniformeDescargas.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descargas con Distribucion Uniforme";
            // 
            // btnCargarCongPoisson
            // 
            this.btnCargarCongPoisson.Location = new System.Drawing.Point(738, 55);
            this.btnCargarCongPoisson.Name = "btnCargarCongPoisson";
            this.btnCargarCongPoisson.Size = new System.Drawing.Size(388, 26);
            this.btnCargarCongPoisson.TabIndex = 16;
            this.btnCargarCongPoisson.Text = "Cargar Parametros Generador para Poisson";
            this.TTbtnsCargarParams.SetToolTip(this.btnCargarCongPoisson, "Se piden los parametros (X0, a, m, c) para\r\nel Generador Congruelcial Mixto que s" +
        "e\r\nutilizara para generar los Poisson(Lambda)");
            this.btnCargarCongPoisson.UseVisualStyleBackColor = true;
            this.btnCargarCongPoisson.Click += new System.EventHandler(this.btnCargarCongPoisson_Click);
            // 
            // cbCargarCongPoisson
            // 
            this.cbCargarCongPoisson.AutoSize = true;
            this.cbCargarCongPoisson.Enabled = false;
            this.cbCargarCongPoisson.Location = new System.Drawing.Point(1132, 62);
            this.cbCargarCongPoisson.Name = "cbCargarCongPoisson";
            this.cbCargarCongPoisson.Size = new System.Drawing.Size(15, 14);
            this.cbCargarCongPoisson.TabIndex = 0;
            this.cbCargarCongPoisson.TabStop = false;
            this.cbCargarCongPoisson.UseVisualStyleBackColor = true;
            // 
            // cbParamPoissonLlegadas
            // 
            this.cbParamPoissonLlegadas.AutoSize = true;
            this.cbParamPoissonLlegadas.Checked = true;
            this.cbParamPoissonLlegadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParamPoissonLlegadas.Location = new System.Drawing.Point(1132, 30);
            this.cbParamPoissonLlegadas.Name = "cbParamPoissonLlegadas";
            this.cbParamPoissonLlegadas.Size = new System.Drawing.Size(15, 14);
            this.cbParamPoissonLlegadas.TabIndex = 15;
            this.cbParamPoissonLlegadas.UseVisualStyleBackColor = true;
            this.cbParamPoissonLlegadas.CheckedChanged += new System.EventHandler(this.cbParamPoissonLlegadas_CheckedChanged);
            // 
            // txtLambdaPoissonLlegadas
            // 
            this.txtLambdaPoissonLlegadas.Enabled = false;
            this.txtLambdaPoissonLlegadas.Location = new System.Drawing.Point(1066, 23);
            this.txtLambdaPoissonLlegadas.Name = "txtLambdaPoissonLlegadas";
            this.txtLambdaPoissonLlegadas.Size = new System.Drawing.Size(60, 26);
            this.txtLambdaPoissonLlegadas.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Llegadas con Distribucion Poisson (por hora)";
            // 
            // btnSimularUnMuelle
            // 
            this.btnSimularUnMuelle.Location = new System.Drawing.Point(376, 151);
            this.btnSimularUnMuelle.Name = "btnSimularUnMuelle";
            this.btnSimularUnMuelle.Size = new System.Drawing.Size(250, 44);
            this.btnSimularUnMuelle.TabIndex = 13;
            this.btnSimularUnMuelle.Text = "Simular N Dias con un Muelle";
            this.btnSimularUnMuelle.UseVisualStyleBackColor = true;
            this.btnSimularUnMuelle.Click += new System.EventHandler(this.btnSimularUnMuelle_Click);
            // 
            // cbCostoMuelleVacio
            // 
            this.cbCostoMuelleVacio.AutoSize = true;
            this.cbCostoMuelleVacio.Checked = true;
            this.cbCostoMuelleVacio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCostoMuelleVacio.Location = new System.Drawing.Point(284, 143);
            this.cbCostoMuelleVacio.Name = "cbCostoMuelleVacio";
            this.cbCostoMuelleVacio.Size = new System.Drawing.Size(15, 14);
            this.cbCostoMuelleVacio.TabIndex = 6;
            this.cbCostoMuelleVacio.UseVisualStyleBackColor = true;
            this.cbCostoMuelleVacio.CheckedChanged += new System.EventHandler(this.cbCostoMuelleVacio_CheckedChanged);
            // 
            // txtCostoMuelleVacio
            // 
            this.txtCostoMuelleVacio.Enabled = false;
            this.txtCostoMuelleVacio.Location = new System.Drawing.Point(218, 137);
            this.txtCostoMuelleVacio.Name = "txtCostoMuelleVacio";
            this.txtCostoMuelleVacio.Size = new System.Drawing.Size(60, 26);
            this.txtCostoMuelleVacio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costos de muelle vacio:";
            // 
            // cbParamCostoNoche
            // 
            this.cbParamCostoNoche.AutoSize = true;
            this.cbParamCostoNoche.Checked = true;
            this.cbParamCostoNoche.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParamCostoNoche.Location = new System.Drawing.Point(284, 110);
            this.cbParamCostoNoche.Name = "cbParamCostoNoche";
            this.cbParamCostoNoche.Size = new System.Drawing.Size(15, 14);
            this.cbParamCostoNoche.TabIndex = 4;
            this.cbParamCostoNoche.UseVisualStyleBackColor = true;
            this.cbParamCostoNoche.CheckedChanged += new System.EventHandler(this.cbParamCostoNoche_CheckedChanged);
            // 
            // txtCostoPasarNoche
            // 
            this.txtCostoPasarNoche.Enabled = false;
            this.txtCostoPasarNoche.Location = new System.Drawing.Point(218, 104);
            this.txtCostoPasarNoche.Name = "txtCostoPasarNoche";
            this.txtCostoPasarNoche.Size = new System.Drawing.Size(60, 26);
            this.txtCostoPasarNoche.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costos de pasar la Noche:";
            // 
            // btnCargarCongDescargas
            // 
            this.btnCargarCongDescargas.Location = new System.Drawing.Point(316, 119);
            this.btnCargarCongDescargas.Name = "btnCargarCongDescargas";
            this.btnCargarCongDescargas.Size = new System.Drawing.Size(376, 26);
            this.btnCargarCongDescargas.TabIndex = 12;
            this.btnCargarCongDescargas.Text = "Cargar Parametros Generador para Descargas";
            this.TTbtnsCargarParams.SetToolTip(this.btnCargarCongDescargas, "Se piden los parametros (X0, a, m, c) para\r\nel Generador Congruelcial Mixto que s" +
        "e\r\nutilizara para simular las Descargas\r\n");
            this.btnCargarCongDescargas.UseVisualStyleBackColor = true;
            this.btnCargarCongDescargas.Click += new System.EventHandler(this.btnCargarCongDescargas_Click);
            // 
            // btnCargarCongLlegadas
            // 
            this.btnCargarCongLlegadas.Location = new System.Drawing.Point(316, 87);
            this.btnCargarCongLlegadas.Name = "btnCargarCongLlegadas";
            this.btnCargarCongLlegadas.Size = new System.Drawing.Size(376, 26);
            this.btnCargarCongLlegadas.TabIndex = 11;
            this.btnCargarCongLlegadas.Text = "Cargar Parametros Generador para Llegadas";
            this.TTbtnsCargarParams.SetToolTip(this.btnCargarCongLlegadas, "Se piden los parametros (X0, a, m, c) para\r\nel Generador Congruelcial Mixto que s" +
        "e\r\nutilizara para simular las Llegadas\r\n");
            this.btnCargarCongLlegadas.UseVisualStyleBackColor = true;
            this.btnCargarCongLlegadas.Click += new System.EventHandler(this.btnCargarCongLlegadas_Click);
            // 
            // btnCargarCongNormal
            // 
            this.btnCargarCongNormal.Location = new System.Drawing.Point(316, 55);
            this.btnCargarCongNormal.Name = "btnCargarCongNormal";
            this.btnCargarCongNormal.Size = new System.Drawing.Size(376, 26);
            this.btnCargarCongNormal.TabIndex = 10;
            this.btnCargarCongNormal.Text = "Cargar Parametros Generador para Normal";
            this.TTbtnsCargarParams.SetToolTip(this.btnCargarCongNormal, "Se piden los parametros (X0, a, m, c) para\r\nel Generador Congruelcial Mixto que s" +
        "e\r\nutilizara para generar los Normales(Media,Desv)");
            this.btnCargarCongNormal.UseVisualStyleBackColor = true;
            this.btnCargarCongNormal.Click += new System.EventHandler(this.btnCargarCongNormal_Click);
            // 
            // cbCargarCongDescargas
            // 
            this.cbCargarCongDescargas.AutoSize = true;
            this.cbCargarCongDescargas.Enabled = false;
            this.cbCargarCongDescargas.Location = new System.Drawing.Point(698, 126);
            this.cbCargarCongDescargas.Name = "cbCargarCongDescargas";
            this.cbCargarCongDescargas.Size = new System.Drawing.Size(15, 14);
            this.cbCargarCongDescargas.TabIndex = 0;
            this.cbCargarCongDescargas.TabStop = false;
            this.cbCargarCongDescargas.UseVisualStyleBackColor = true;
            // 
            // cbCargarCongLlegadas
            // 
            this.cbCargarCongLlegadas.AutoSize = true;
            this.cbCargarCongLlegadas.Enabled = false;
            this.cbCargarCongLlegadas.Location = new System.Drawing.Point(698, 94);
            this.cbCargarCongLlegadas.Name = "cbCargarCongLlegadas";
            this.cbCargarCongLlegadas.Size = new System.Drawing.Size(15, 14);
            this.cbCargarCongLlegadas.TabIndex = 0;
            this.cbCargarCongLlegadas.TabStop = false;
            this.cbCargarCongLlegadas.UseVisualStyleBackColor = true;
            // 
            // cbCargarCongNormal
            // 
            this.cbCargarCongNormal.AutoSize = true;
            this.cbCargarCongNormal.Enabled = false;
            this.cbCargarCongNormal.Location = new System.Drawing.Point(698, 62);
            this.cbCargarCongNormal.Name = "cbCargarCongNormal";
            this.cbCargarCongNormal.Size = new System.Drawing.Size(15, 14);
            this.cbCargarCongNormal.TabIndex = 0;
            this.cbCargarCongNormal.TabStop = false;
            this.cbCargarCongNormal.UseVisualStyleBackColor = true;
            // 
            // cbParamsNormalGanancia
            // 
            this.cbParamsNormalGanancia.AutoSize = true;
            this.cbParamsNormalGanancia.Checked = true;
            this.cbParamsNormalGanancia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParamsNormalGanancia.Location = new System.Drawing.Point(698, 30);
            this.cbParamsNormalGanancia.Name = "cbParamsNormalGanancia";
            this.cbParamsNormalGanancia.Size = new System.Drawing.Size(15, 14);
            this.cbParamsNormalGanancia.TabIndex = 9;
            this.cbParamsNormalGanancia.UseVisualStyleBackColor = true;
            this.cbParamsNormalGanancia.CheckedChanged += new System.EventHandler(this.cbParamsNormalGanancia_CheckedChanged);
            // 
            // txtDesviacionNormalGanancia
            // 
            this.txtDesviacionNormalGanancia.Enabled = false;
            this.txtDesviacionNormalGanancia.Location = new System.Drawing.Point(632, 23);
            this.txtDesviacionNormalGanancia.Name = "txtDesviacionNormalGanancia";
            this.txtDesviacionNormalGanancia.Size = new System.Drawing.Size(60, 26);
            this.txtDesviacionNormalGanancia.TabIndex = 8;
            // 
            // txtMediaNormalGanancia
            // 
            this.txtMediaNormalGanancia.Enabled = false;
            this.txtMediaNormalGanancia.Location = new System.Drawing.Point(566, 23);
            this.txtMediaNormalGanancia.Name = "txtMediaNormalGanancia";
            this.txtMediaNormalGanancia.Size = new System.Drawing.Size(60, 26);
            this.txtMediaNormalGanancia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ganancias con Distribucion Normal";
            // 
            // txtFilaMostrar
            // 
            this.txtFilaMostrar.Location = new System.Drawing.Point(230, 60);
            this.txtFilaMostrar.Name = "txtFilaMostrar";
            this.txtFilaMostrar.Size = new System.Drawing.Size(77, 26);
            this.txtFilaMostrar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mostrar a Partir de fila:";
            // 
            // txtCantidadSimular
            // 
            this.txtCantidadSimular.Location = new System.Drawing.Point(230, 23);
            this.txtCantidadSimular.Name = "txtCantidadSimular";
            this.txtCantidadSimular.Size = new System.Drawing.Size(77, 26);
            this.txtCantidadSimular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Dias a Simular:";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.pgbSimulacion);
            this.gbResultados.Controls.Add(this.dgvResultadosDosM);
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.Location = new System.Drawing.Point(12, 219);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1260, 430);
            this.gbResultados.TabIndex = 2;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // pgbSimulacion
            // 
            this.pgbSimulacion.Location = new System.Drawing.Point(0, 26);
            this.pgbSimulacion.Name = "pgbSimulacion";
            this.pgbSimulacion.Size = new System.Drawing.Size(1254, 23);
            this.pgbSimulacion.TabIndex = 24;
            // 
            // dgvResultadosDosM
            // 
            this.dgvResultadosDosM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosDosM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvResultadosDosM.Location = new System.Drawing.Point(7, 26);
            this.dgvResultadosDosM.Name = "dgvResultadosDosM";
            this.dgvResultadosDosM.Size = new System.Drawing.Size(1236, 398);
            this.dgvResultadosDosM.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Reloj (dias)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Llegadas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descargas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Barcos Pendientes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Barcos Descargados Con Retraso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Dias Muelle Ocupado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Porcentaje de Ocupacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Ganancias por Descargas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Costos por Barcos Pendientes";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Costos por Muelle Vacio";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Utilidades Totales";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Utilidades Acumuladas";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.RNDLlegadas,
            this.CantLlegadas,
            this.RNDDescargas,
            this.CantDescargas,
            this.BarcosPendientes,
            this.BarcosConRetraso,
            this.DiasOcupado,
            this.PorcentajeOcupacion,
            this.GananciasDescargas,
            this.CostosPendientes,
            this.CostosPorVacio,
            this.UtilidadesTotales,
            this.UtilidadesAcumuladas});
            this.dgvResultados.Location = new System.Drawing.Point(7, 26);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1247, 398);
            this.dgvResultados.TabIndex = 0;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Reloj (dias)";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            // 
            // RNDLlegadas
            // 
            this.RNDLlegadas.HeaderText = "RND Llegadas";
            this.RNDLlegadas.Name = "RNDLlegadas";
            this.RNDLlegadas.ReadOnly = true;
            // 
            // CantLlegadas
            // 
            this.CantLlegadas.HeaderText = "Llegadas";
            this.CantLlegadas.Name = "CantLlegadas";
            this.CantLlegadas.ReadOnly = true;
            // 
            // RNDDescargas
            // 
            this.RNDDescargas.HeaderText = "RND Descargas";
            this.RNDDescargas.Name = "RNDDescargas";
            this.RNDDescargas.ReadOnly = true;
            // 
            // CantDescargas
            // 
            this.CantDescargas.HeaderText = "Descargas";
            this.CantDescargas.Name = "CantDescargas";
            this.CantDescargas.ReadOnly = true;
            // 
            // BarcosPendientes
            // 
            this.BarcosPendientes.HeaderText = "Barcos Pendientes";
            this.BarcosPendientes.Name = "BarcosPendientes";
            this.BarcosPendientes.ReadOnly = true;
            // 
            // BarcosConRetraso
            // 
            this.BarcosConRetraso.HeaderText = "Barcos Descargados Con Retraso";
            this.BarcosConRetraso.Name = "BarcosConRetraso";
            this.BarcosConRetraso.ReadOnly = true;
            this.BarcosConRetraso.Width = 150;
            // 
            // DiasOcupado
            // 
            this.DiasOcupado.HeaderText = "Dias Muelle Ocupado";
            this.DiasOcupado.Name = "DiasOcupado";
            this.DiasOcupado.ReadOnly = true;
            this.DiasOcupado.Width = 150;
            // 
            // PorcentajeOcupacion
            // 
            this.PorcentajeOcupacion.HeaderText = "Porcentaje de Ocupacion";
            this.PorcentajeOcupacion.Name = "PorcentajeOcupacion";
            this.PorcentajeOcupacion.ReadOnly = true;
            this.PorcentajeOcupacion.Width = 150;
            // 
            // GananciasDescargas
            // 
            this.GananciasDescargas.HeaderText = "Ganancias por Descargas";
            this.GananciasDescargas.Name = "GananciasDescargas";
            this.GananciasDescargas.ReadOnly = true;
            this.GananciasDescargas.Width = 125;
            // 
            // CostosPendientes
            // 
            this.CostosPendientes.HeaderText = "Costos por Barcos Pendientes";
            this.CostosPendientes.Name = "CostosPendientes";
            this.CostosPendientes.ReadOnly = true;
            this.CostosPendientes.Width = 150;
            // 
            // CostosPorVacio
            // 
            this.CostosPorVacio.HeaderText = "Costos por Muelle Vacio";
            this.CostosPorVacio.Name = "CostosPorVacio";
            this.CostosPorVacio.ReadOnly = true;
            this.CostosPorVacio.Width = 125;
            // 
            // UtilidadesTotales
            // 
            this.UtilidadesTotales.HeaderText = "Utilidades Totales";
            this.UtilidadesTotales.Name = "UtilidadesTotales";
            this.UtilidadesTotales.ReadOnly = true;
            this.UtilidadesTotales.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UtilidadesAcumuladas
            // 
            this.UtilidadesAcumuladas.HeaderText = "Utilidades Acumuladas";
            this.UtilidadesAcumuladas.Name = "UtilidadesAcumuladas";
            this.UtilidadesAcumuladas.ReadOnly = true;
            this.UtilidadesAcumuladas.Width = 125;
            // 
            // TTbtnsCargarParams
            // 
            this.TTbtnsCargarParams.AutoPopDelay = 10000;
            this.TTbtnsCargarParams.InitialDelay = 500;
            this.TTbtnsCargarParams.ReshowDelay = 100;
            // 
            // btnHorasLlegada
            // 
            this.btnHorasLlegada.Location = new System.Drawing.Point(1153, 25);
            this.btnHorasLlegada.Name = "btnHorasLlegada";
            this.btnHorasLlegada.Size = new System.Drawing.Size(19, 23);
            this.btnHorasLlegada.TabIndex = 22;
            this.btnHorasLlegada.Text = "+";
            this.btnHorasLlegada.UseVisualStyleBackColor = true;
            this.btnHorasLlegada.Click += new System.EventHandler(this.btnHorasLlegada_Click);
            // 
            // TP4MontecarloPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbParametros);
            this.Name = "TP4MontecarloPuerto";
            this.Text = "TP4 Simulacion Montecarlo Puerto";
            this.Load += new System.EventHandler(this.TP4MontecarloPuerto_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosDosM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.TextBox txtMediaNormalGanancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilaMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadSimular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.TextBox txtDesviacionNormalGanancia;
        private System.Windows.Forms.CheckBox cbCargarCongLlegadas;
        private System.Windows.Forms.CheckBox cbCargarCongNormal;
        private System.Windows.Forms.CheckBox cbParamsNormalGanancia;
        private System.Windows.Forms.Button btnCargarCongUniforme;
        private System.Windows.Forms.CheckBox cbCargarCongUniforme;
        private System.Windows.Forms.CheckBox cbParamsUniformeDescargas;
        private System.Windows.Forms.TextBox txtBUniformeDescargas;
        private System.Windows.Forms.TextBox txtAUniformeDescargas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarCongPoisson;
        private System.Windows.Forms.CheckBox cbCargarCongPoisson;
        private System.Windows.Forms.CheckBox cbParamPoissonLlegadas;
        private System.Windows.Forms.TextBox txtLambdaPoissonLlegadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimularUnMuelle;
        private System.Windows.Forms.CheckBox cbCostoMuelleVacio;
        private System.Windows.Forms.TextBox txtCostoMuelleVacio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbParamCostoNoche;
        private System.Windows.Forms.TextBox txtCostoPasarNoche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarCongDescargas;
        private System.Windows.Forms.Button btnCargarCongLlegadas;
        private System.Windows.Forms.Button btnCargarCongNormal;
        private System.Windows.Forms.CheckBox cbCargarCongDescargas;
        private System.Windows.Forms.Button btnSimularDosMuelles;
        private System.Windows.Forms.ToolTip TTbtnsCargarParams;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDDescargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDescargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcosConRetraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasOcupado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GananciasDescargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostosPorVacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtilidadesTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtilidadesAcumuladas;
        private System.Windows.Forms.DataGridView dgvResultadosDosM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ProgressBar pgbSimulacion;
        private System.Windows.Forms.Button btnHorasLlegada;
    }
}

