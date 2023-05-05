namespace TP3_Generacion_de_Variable_Aleatoria
{
    partial class PantallaVariableAleatoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbDistribucion = new System.Windows.Forms.GroupBox();
            this.btnNormalConvolucion = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnNormalBoxMuller = new System.Windows.Forms.Button();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.btnPruebaChiCuadrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantNums = new System.Windows.Forms.MaskedTextBox();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.txtParamDos = new System.Windows.Forms.TextBox();
            this.txtParamUno = new System.Windows.Forms.TextBox();
            this.lblParamDos = new System.Windows.Forms.Label();
            this.lblParamUno = new System.Windows.Forms.Label();
            this.dgvListaNumeros = new System.Windows.Forms.DataGridView();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varAleat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbGeneracion = new System.Windows.Forms.GroupBox();
            this.pgbGeneracion = new System.Windows.Forms.ProgressBar();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbHistogramaYPrueba = new System.Windows.Forms.GroupBox();
            this.gbConclucion = new System.Windows.Forms.GroupBox();
            this.lblDesvEst = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblComparacion = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblEstTab = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEstCalc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPruebaChi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPruebaKS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilidadObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilidadEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCantidadIntervalos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnPruebaKS = new System.Windows.Forms.Button();
            this.dgvHistograma = new System.Windows.Forms.DataGridView();
            this.limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDeClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graficoHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarHistograma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDistribucion.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNumeros)).BeginInit();
            this.gbGeneracion.SuspendLayout();
            this.gbHistogramaYPrueba.SuspendLayout();
            this.gbConclucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebaKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDistribucion
            // 
            this.gbDistribucion.Controls.Add(this.btnNormalConvolucion);
            this.gbDistribucion.Controls.Add(this.btnPoisson);
            this.gbDistribucion.Controls.Add(this.btnExponencial);
            this.gbDistribucion.Controls.Add(this.btnNormalBoxMuller);
            this.gbDistribucion.Controls.Add(this.btnUniforme);
            this.gbDistribucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDistribucion.Location = new System.Drawing.Point(29, 27);
            this.gbDistribucion.Name = "gbDistribucion";
            this.gbDistribucion.Size = new System.Drawing.Size(221, 416);
            this.gbDistribucion.TabIndex = 2;
            this.gbDistribucion.TabStop = false;
            this.gbDistribucion.Text = "Seleccione la Distribucion";
            // 
            // btnNormalConvolucion
            // 
            this.btnNormalConvolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormalConvolucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalConvolucion.Location = new System.Drawing.Point(50, 196);
            this.btnNormalConvolucion.Name = "btnNormalConvolucion";
            this.btnNormalConvolucion.Size = new System.Drawing.Size(116, 65);
            this.btnNormalConvolucion.TabIndex = 3;
            this.btnNormalConvolucion.Text = "Distribucion Normal (Convolucion)";
            this.btnNormalConvolucion.UseVisualStyleBackColor = true;
            this.btnNormalConvolucion.Click += new System.EventHandler(this.btnNormalCnvolucion_Click);
            // 
            // btnPoisson
            // 
            this.btnPoisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoisson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.Location = new System.Drawing.Point(50, 349);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(116, 57);
            this.btnPoisson.TabIndex = 5;
            this.btnPoisson.Text = "Distribucion Poisson";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExponencial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.Location = new System.Drawing.Point(50, 277);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(116, 57);
            this.btnExponencial.TabIndex = 4;
            this.btnExponencial.Text = "Distribucion Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // btnNormalBoxMuller
            // 
            this.btnNormalBoxMuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormalBoxMuller.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalBoxMuller.Location = new System.Drawing.Point(50, 108);
            this.btnNormalBoxMuller.Name = "btnNormalBoxMuller";
            this.btnNormalBoxMuller.Size = new System.Drawing.Size(116, 73);
            this.btnNormalBoxMuller.TabIndex = 2;
            this.btnNormalBoxMuller.Text = "Distribucion Normal (Box-Müller)";
            this.btnNormalBoxMuller.UseVisualStyleBackColor = true;
            this.btnNormalBoxMuller.Click += new System.EventHandler(this.btnNormalBoxMuller_Click);
            // 
            // btnUniforme
            // 
            this.btnUniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUniforme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.Location = new System.Drawing.Point(50, 36);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(116, 57);
            this.btnUniforme.TabIndex = 1;
            this.btnUniforme.Text = "Distribucion Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // btnPruebaChiCuadrado
            // 
            this.btnPruebaChiCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPruebaChiCuadrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaChiCuadrado.Location = new System.Drawing.Point(9, 557);
            this.btnPruebaChiCuadrado.Name = "btnPruebaChiCuadrado";
            this.btnPruebaChiCuadrado.Size = new System.Drawing.Size(202, 40);
            this.btnPruebaChiCuadrado.TabIndex = 13;
            this.btnPruebaChiCuadrado.Text = "Prueba de Chi-Cuadrado";
            this.btnPruebaChiCuadrado.UseVisualStyleBackColor = true;
            this.btnPruebaChiCuadrado.Click += new System.EventHandler(this.btnPruebaChiCuadrado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Generar:";
            // 
            // txtCantNums
            // 
            this.txtCantNums.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantNums.Location = new System.Drawing.Point(161, 29);
            this.txtCantNums.Mask = "99999999";
            this.txtCantNums.Name = "txtCantNums";
            this.txtCantNums.PromptChar = ' ';
            this.txtCantNums.Size = new System.Drawing.Size(54, 26);
            this.txtCantNums.TabIndex = 6;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.txtParamDos);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.txtCantNums);
            this.gbParametros.Controls.Add(this.txtParamUno);
            this.gbParametros.Controls.Add(this.lblParamDos);
            this.gbParametros.Controls.Add(this.lblParamUno);
            this.gbParametros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(29, 461);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(221, 135);
            this.gbParametros.TabIndex = 3;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Ingrese los Parametros";
            // 
            // txtParamDos
            // 
            this.txtParamDos.Location = new System.Drawing.Point(161, 96);
            this.txtParamDos.Name = "txtParamDos";
            this.txtParamDos.Size = new System.Drawing.Size(54, 26);
            this.txtParamDos.TabIndex = 8;
            // 
            // txtParamUno
            // 
            this.txtParamUno.Location = new System.Drawing.Point(161, 61);
            this.txtParamUno.Name = "txtParamUno";
            this.txtParamUno.Size = new System.Drawing.Size(54, 26);
            this.txtParamUno.TabIndex = 7;
            // 
            // lblParamDos
            // 
            this.lblParamDos.AutoSize = true;
            this.lblParamDos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamDos.Location = new System.Drawing.Point(6, 99);
            this.lblParamDos.Name = "lblParamDos";
            this.lblParamDos.Size = new System.Drawing.Size(99, 18);
            this.lblParamDos.TabIndex = 0;
            this.lblParamDos.Text = "lblParamDos";
            // 
            // lblParamUno
            // 
            this.lblParamUno.AutoSize = true;
            this.lblParamUno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamUno.Location = new System.Drawing.Point(6, 64);
            this.lblParamUno.Name = "lblParamUno";
            this.lblParamUno.Size = new System.Drawing.Size(98, 18);
            this.lblParamUno.TabIndex = 0;
            this.lblParamUno.Text = "lblParamUno";
            // 
            // dgvListaNumeros
            // 
            this.dgvListaNumeros.AllowUserToAddRows = false;
            this.dgvListaNumeros.AllowUserToDeleteRows = false;
            this.dgvListaNumeros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaNumeros.ColumnHeadersHeight = 30;
            this.dgvListaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pos,
            this.varAleat});
            this.dgvListaNumeros.Location = new System.Drawing.Point(270, 19);
            this.dgvListaNumeros.MultiSelect = false;
            this.dgvListaNumeros.Name = "dgvListaNumeros";
            this.dgvListaNumeros.ReadOnly = true;
            this.dgvListaNumeros.RowHeadersWidth = 10;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaNumeros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaNumeros.Size = new System.Drawing.Size(221, 754);
            this.dgvListaNumeros.TabIndex = 0;
            this.dgvListaNumeros.TabStop = false;
            // 
            // pos
            // 
            this.pos.HeaderText = "Posicion";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            // 
            // varAleat
            // 
            this.varAleat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.varAleat.HeaderText = "Variable";
            this.varAleat.Name = "varAleat";
            this.varAleat.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 803);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(79, 614);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(116, 47);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gbGeneracion
            // 
            this.gbGeneracion.Controls.Add(this.pgbGeneracion);
            this.gbGeneracion.Controls.Add(this.btnLimpiar);
            this.gbGeneracion.Controls.Add(this.gbDistribucion);
            this.gbGeneracion.Controls.Add(this.btnGenerar);
            this.gbGeneracion.Controls.Add(this.dgvListaNumeros);
            this.gbGeneracion.Controls.Add(this.gbParametros);
            this.gbGeneracion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneracion.Location = new System.Drawing.Point(12, 6);
            this.gbGeneracion.Name = "gbGeneracion";
            this.gbGeneracion.Size = new System.Drawing.Size(507, 791);
            this.gbGeneracion.TabIndex = 0;
            this.gbGeneracion.TabStop = false;
            this.gbGeneracion.Text = "Generacion de Variable Aleatoria";
            // 
            // pgbGeneracion
            // 
            this.pgbGeneracion.Location = new System.Drawing.Point(0, 649);
            this.pgbGeneracion.Name = "pgbGeneracion";
            this.pgbGeneracion.Size = new System.Drawing.Size(501, 23);
            this.pgbGeneracion.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(79, 678);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbHistogramaYPrueba
            // 
            this.gbHistogramaYPrueba.Controls.Add(this.gbConclucion);
            this.gbHistogramaYPrueba.Controls.Add(this.dgvPruebaChi);
            this.gbHistogramaYPrueba.Controls.Add(this.dgvPruebaKS);
            this.gbHistogramaYPrueba.Controls.Add(this.cbCantidadIntervalos);
            this.gbHistogramaYPrueba.Controls.Add(this.btnLimpiar2);
            this.gbHistogramaYPrueba.Controls.Add(this.btnPruebaKS);
            this.gbHistogramaYPrueba.Controls.Add(this.dgvHistograma);
            this.gbHistogramaYPrueba.Controls.Add(this.graficoHistograma);
            this.gbHistogramaYPrueba.Controls.Add(this.btnGenerarHistograma);
            this.gbHistogramaYPrueba.Controls.Add(this.label2);
            this.gbHistogramaYPrueba.Controls.Add(this.btnPruebaChiCuadrado);
            this.gbHistogramaYPrueba.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistogramaYPrueba.Location = new System.Drawing.Point(525, 6);
            this.gbHistogramaYPrueba.Name = "gbHistogramaYPrueba";
            this.gbHistogramaYPrueba.Size = new System.Drawing.Size(1156, 853);
            this.gbHistogramaYPrueba.TabIndex = 1;
            this.gbHistogramaYPrueba.TabStop = false;
            this.gbHistogramaYPrueba.Text = "Histograma Y Prueba";
            // 
            // gbConclucion
            // 
            this.gbConclucion.Controls.Add(this.lblDesvEst);
            this.gbConclucion.Controls.Add(this.lblMedia);
            this.gbConclucion.Controls.Add(this.label10);
            this.gbConclucion.Controls.Add(this.label8);
            this.gbConclucion.Controls.Add(this.lblComparacion);
            this.gbConclucion.Controls.Add(this.lblConclusion);
            this.gbConclucion.Controls.Add(this.lblEstTab);
            this.gbConclucion.Controls.Add(this.label9);
            this.gbConclucion.Controls.Add(this.lblEstCalc);
            this.gbConclucion.Controls.Add(this.label7);
            this.gbConclucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConclucion.Location = new System.Drawing.Point(892, 546);
            this.gbConclucion.Name = "gbConclucion";
            this.gbConclucion.Size = new System.Drawing.Size(255, 289);
            this.gbConclucion.TabIndex = 17;
            this.gbConclucion.TabStop = false;
            this.gbConclucion.Text = "Conclusion";
            // 
            // lblDesvEst
            // 
            this.lblDesvEst.AutoSize = true;
            this.lblDesvEst.Location = new System.Drawing.Point(63, 61);
            this.lblDesvEst.Name = "lblDesvEst";
            this.lblDesvEst.Size = new System.Drawing.Size(82, 18);
            this.lblDesvEst.TabIndex = 9;
            this.lblDesvEst.Text = "lblDesvEst";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(63, 32);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(67, 18);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "lblMedia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "σ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "x̄:";
            // 
            // lblComparacion
            // 
            this.lblComparacion.AutoSize = true;
            this.lblComparacion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparacion.Location = new System.Drawing.Point(43, 162);
            this.lblComparacion.Name = "lblComparacion";
            this.lblComparacion.Size = new System.Drawing.Size(153, 24);
            this.lblComparacion.TabIndex = 5;
            this.lblComparacion.Text = "lblComparacion";
            this.lblComparacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(5, 206);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(129, 66);
            this.lblConclusion.TabIndex = 4;
            this.lblConclusion.Text = "No Se\r\nRechaza";
            this.lblConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstTab
            // 
            this.lblEstTab.AutoSize = true;
            this.lblEstTab.Location = new System.Drawing.Point(173, 122);
            this.lblEstTab.Name = "lblEstTab";
            this.lblEstTab.Size = new System.Drawing.Size(71, 18);
            this.lblEstTab.TabIndex = 3;
            this.lblEstTab.Text = "lblEstTab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Estadistico Tabulado:";
            // 
            // lblEstCalc
            // 
            this.lblEstCalc.AutoSize = true;
            this.lblEstCalc.Location = new System.Drawing.Point(168, 89);
            this.lblEstCalc.Name = "lblEstCalc";
            this.lblEstCalc.Size = new System.Drawing.Size(78, 18);
            this.lblEstCalc.TabIndex = 1;
            this.lblEstCalc.Text = "lblEstCalc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estadisto Calculado:";
            // 
            // dgvPruebaChi
            // 
            this.dgvPruebaChi.AllowUserToAddRows = false;
            this.dgvPruebaChi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPruebaChi.ColumnHeadersHeight = 30;
            this.dgvPruebaChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvPruebaChi.Location = new System.Drawing.Point(9, 614);
            this.dgvPruebaChi.MultiSelect = false;
            this.dgvPruebaChi.Name = "dgvPruebaChi";
            this.dgvPruebaChi.RowHeadersWidth = 10;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPruebaChi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPruebaChi.Size = new System.Drawing.Size(801, 229);
            this.dgvPruebaChi.TabIndex = 16;
            this.dgvPruebaChi.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Limite Inferior";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Limite Superior";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 52;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Fe";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 52;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Estadistico del Intervalo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 197;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Estadictico Acumulado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 192;
            // 
            // dgvPruebaKS
            // 
            this.dgvPruebaKS.AllowUserToAddRows = false;
            this.dgvPruebaKS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPruebaKS.ColumnHeadersHeight = 30;
            this.dgvPruebaKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.ProbabilidadObservada,
            this.ProbabilidadEsperada,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvPruebaKS.Location = new System.Drawing.Point(9, 614);
            this.dgvPruebaKS.MultiSelect = false;
            this.dgvPruebaKS.Name = "dgvPruebaKS";
            this.dgvPruebaKS.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPruebaKS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPruebaKS.Size = new System.Drawing.Size(877, 229);
            this.dgvPruebaKS.TabIndex = 0;
            this.dgvPruebaKS.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Limite Inferior";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 127;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Limite Superior";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Fo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 52;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "Fe";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 52;
            // 
            // ProbabilidadObservada
            // 
            this.ProbabilidadObservada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProbabilidadObservada.HeaderText = "P(Fo)";
            this.ProbabilidadObservada.Name = "ProbabilidadObservada";
            this.ProbabilidadObservada.Width = 73;
            // 
            // ProbabilidadEsperada
            // 
            this.ProbabilidadEsperada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProbabilidadEsperada.HeaderText = "P(Fe)";
            this.ProbabilidadEsperada.Name = "ProbabilidadEsperada";
            this.ProbabilidadEsperada.Width = 73;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.HeaderText = "|P(Fo)-P(Fe)|";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 124;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.HeaderText = "Maximo Estadistico";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 170;
            // 
            // cbCantidadIntervalos
            // 
            this.cbCantidadIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCantidadIntervalos.FormattingEnabled = true;
            this.cbCantidadIntervalos.Location = new System.Drawing.Point(244, 24);
            this.cbCantidadIntervalos.Name = "cbCantidadIntervalos";
            this.cbCantidadIntervalos.Size = new System.Drawing.Size(130, 26);
            this.cbCantidadIntervalos.TabIndex = 11;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.Location = new System.Drawing.Point(759, 556);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(116, 40);
            this.btnLimpiar2.TabIndex = 15;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnPruebaKS
            // 
            this.btnPruebaKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPruebaKS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaKS.Location = new System.Drawing.Point(236, 557);
            this.btnPruebaKS.Name = "btnPruebaKS";
            this.btnPruebaKS.Size = new System.Drawing.Size(247, 40);
            this.btnPruebaKS.TabIndex = 14;
            this.btnPruebaKS.Text = "Prueba de Kolmogorov-Smirnov";
            this.btnPruebaKS.UseVisualStyleBackColor = true;
            this.btnPruebaKS.Click += new System.EventHandler(this.btnPruebaKS_Click);
            // 
            // dgvHistograma
            // 
            this.dgvHistograma.AllowUserToAddRows = false;
            this.dgvHistograma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistograma.ColumnHeadersHeight = 30;
            this.dgvHistograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.limiteInferior,
            this.limiteSuperior,
            this.marcaDeClase,
            this.frecObs,
            this.frecEsp});
            this.dgvHistograma.Location = new System.Drawing.Point(9, 310);
            this.dgvHistograma.MultiSelect = false;
            this.dgvHistograma.Name = "dgvHistograma";
            this.dgvHistograma.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistograma.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistograma.Size = new System.Drawing.Size(1132, 230);
            this.dgvHistograma.TabIndex = 0;
            this.dgvHistograma.TabStop = false;
            // 
            // limiteInferior
            // 
            this.limiteInferior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.limiteInferior.HeaderText = "Limite Inferior";
            this.limiteInferior.Name = "limiteInferior";
            this.limiteInferior.Width = 127;
            // 
            // limiteSuperior
            // 
            this.limiteSuperior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.limiteSuperior.HeaderText = "Limite Superior";
            this.limiteSuperior.Name = "limiteSuperior";
            this.limiteSuperior.Width = 140;
            // 
            // marcaDeClase
            // 
            this.marcaDeClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marcaDeClase.HeaderText = "Marca De Clase";
            this.marcaDeClase.Name = "marcaDeClase";
            this.marcaDeClase.Width = 147;
            // 
            // frecObs
            // 
            this.frecObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.frecObs.HeaderText = "Frecuencia Observada";
            this.frecObs.Name = "frecObs";
            this.frecObs.Width = 192;
            // 
            // frecEsp
            // 
            this.frecEsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.frecEsp.HeaderText = "Frecuencia Esperada";
            this.frecEsp.Name = "frecEsp";
            this.frecEsp.Width = 184;
            // 
            // graficoHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistograma.Legends.Add(legend1);
            this.graficoHistograma.Location = new System.Drawing.Point(9, 60);
            this.graficoHistograma.Name = "graficoHistograma";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "FO";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "FE";
            this.graficoHistograma.Series.Add(series1);
            this.graficoHistograma.Series.Add(series2);
            this.graficoHistograma.Size = new System.Drawing.Size(1132, 241);
            this.graficoHistograma.TabIndex = 0;
            this.graficoHistograma.TabStop = false;
            this.graficoHistograma.Text = "chart1";
            // 
            // btnGenerarHistograma
            // 
            this.btnGenerarHistograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarHistograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarHistograma.Location = new System.Drawing.Point(445, 16);
            this.btnGenerarHistograma.Name = "btnGenerarHistograma";
            this.btnGenerarHistograma.Size = new System.Drawing.Size(177, 41);
            this.btnGenerarHistograma.TabIndex = 12;
            this.btnGenerarHistograma.Text = "Generar Histograma";
            this.btnGenerarHistograma.UseVisualStyleBackColor = true;
            this.btnGenerarHistograma.Click += new System.EventHandler(this.btnGenerarHistograma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccionar Cantidad Intervalos:";
            // 
            // PantallaVariableAleatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 861);
            this.Controls.Add(this.gbHistogramaYPrueba);
            this.Controls.Add(this.gbGeneracion);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PantallaVariableAleatoria";
            this.Text = "Generacion de Variable Aleatoria";
            this.Load += new System.EventHandler(this.PantallaVariableAleatoria_Load);
            this.gbDistribucion.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNumeros)).EndInit();
            this.gbGeneracion.ResumeLayout(false);
            this.gbHistogramaYPrueba.ResumeLayout(false);
            this.gbHistogramaYPrueba.PerformLayout();
            this.gbConclucion.ResumeLayout(false);
            this.gbConclucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebaKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDistribucion;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnNormalBoxMuller;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Button btnPruebaChiCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCantNums;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.TextBox txtParamDos;
        private System.Windows.Forms.TextBox txtParamUno;
        private System.Windows.Forms.Label lblParamDos;
        private System.Windows.Forms.Label lblParamUno;
        private System.Windows.Forms.DataGridView dgvListaNumeros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gbGeneracion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbHistogramaYPrueba;
        private System.Windows.Forms.Button btnNormalConvolucion;
        private System.Windows.Forms.Button btnGenerarHistograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistograma;
        private System.Windows.Forms.DataGridView dgvHistograma;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnPruebaKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDeClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecEsp;
        private System.Windows.Forms.ComboBox cbCantidadIntervalos;
        private System.Windows.Forms.GroupBox gbConclucion;
        private System.Windows.Forms.Label lblDesvEst;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblComparacion;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblEstTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPruebaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dgvPruebaKS;
        private System.Windows.Forms.ProgressBar pgbGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilidadObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilidadEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn varAleat;
    }
}

