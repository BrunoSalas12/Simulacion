namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra
{
    partial class PantallaInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIngresoMuestra = new System.Windows.Forms.RichTextBox();
            this.gbIngresoMuestra = new System.Windows.Forms.GroupBox();
            this.graficoHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarHistograma = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.txtCantIntervalos = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHipotesis = new System.Windows.Forms.GroupBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.gbConclucion = new System.Windows.Forms.GroupBox();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblComparacion = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblEstTab = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEstCalc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvIntervalos = new System.Windows.Forms.DataGridView();
            this.limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDeClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticoIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estaditicoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarMuestra = new System.Windows.Forms.Button();
            this.gbIngresoMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.gbHipotesis.SuspendLayout();
            this.gbConclucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngresoMuestra
            // 
            this.txtIngresoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresoMuestra.Location = new System.Drawing.Point(6, 59);
            this.txtIngresoMuestra.Name = "txtIngresoMuestra";
            this.txtIngresoMuestra.Size = new System.Drawing.Size(162, 598);
            this.txtIngresoMuestra.TabIndex = 1;
            this.txtIngresoMuestra.Text = "";
            this.txtIngresoMuestra.TextChanged += new System.EventHandler(this.txtIngresoMuestra_TextChanged);
            // 
            // gbIngresoMuestra
            // 
            this.gbIngresoMuestra.Controls.Add(this.txtIngresoMuestra);
            this.gbIngresoMuestra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresoMuestra.Location = new System.Drawing.Point(4, 2);
            this.gbIngresoMuestra.Name = "gbIngresoMuestra";
            this.gbIngresoMuestra.Size = new System.Drawing.Size(174, 663);
            this.gbIngresoMuestra.TabIndex = 0;
            this.gbIngresoMuestra.TabStop = false;
            this.gbIngresoMuestra.Text = "Ingrese los valores de muestra separados por renglon";
            // 
            // graficoHistograma
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoHistograma.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficoHistograma.Legends.Add(legend3);
            this.graficoHistograma.Location = new System.Drawing.Point(405, 12);
            this.graficoHistograma.Name = "graficoHistograma";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "FO";
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "FE";
            this.graficoHistograma.Series.Add(series5);
            this.graficoHistograma.Series.Add(series6);
            this.graficoHistograma.Size = new System.Drawing.Size(936, 243);
            this.graficoHistograma.TabIndex = 0;
            this.graficoHistograma.TabStop = false;
            this.graficoHistograma.Text = "chart1";
            // 
            // btnGenerarHistograma
            // 
            this.btnGenerarHistograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarHistograma.Location = new System.Drawing.Point(185, 175);
            this.btnGenerarHistograma.Name = "btnGenerarHistograma";
            this.btnGenerarHistograma.Size = new System.Drawing.Size(200, 80);
            this.btnGenerarHistograma.TabIndex = 5;
            this.btnGenerarHistograma.Text = "Generar Histograma de Frecuencias Observadas";
            this.btnGenerarHistograma.UseVisualStyleBackColor = true;
            this.btnGenerarHistograma.Click += new System.EventHandler(this.btnGenerarHistograma_Click);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.txtCantIntervalos);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.txtMaximo);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.txtMinimo);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(185, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(200, 157);
            this.gbParametros.TabIndex = 1;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Ingrese parametros";
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(128, 111);
            this.txtCantIntervalos.Mask = "99999999";
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.PromptChar = ' ';
            this.txtCantIntervalos.Size = new System.Drawing.Size(66, 26);
            this.txtCantIntervalos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cant. intervalos:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(128, 65);
            this.txtMaximo.Mask = "99999999";
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.PromptChar = ' ';
            this.txtMaximo.Size = new System.Drawing.Size(66, 26);
            this.txtMaximo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximo:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(128, 23);
            this.txtMinimo.Mask = "99999999";
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.PromptChar = ' ';
            this.txtMinimo.Size = new System.Drawing.Size(66, 26);
            this.txtMinimo.TabIndex = 2;
            this.txtMinimo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimo:";
            // 
            // gbHipotesis
            // 
            this.gbHipotesis.Controls.Add(this.btnPrueba);
            this.gbHipotesis.Controls.Add(this.btnPoisson);
            this.gbHipotesis.Controls.Add(this.btnExponencial);
            this.gbHipotesis.Controls.Add(this.btnNormal);
            this.gbHipotesis.Controls.Add(this.btnUniforme);
            this.gbHipotesis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHipotesis.Location = new System.Drawing.Point(185, 262);
            this.gbHipotesis.Name = "gbHipotesis";
            this.gbHipotesis.Size = new System.Drawing.Size(676, 92);
            this.gbHipotesis.TabIndex = 5;
            this.gbHipotesis.TabStop = false;
            this.gbHipotesis.Text = "Seleccion de Hipotesis";
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(541, 25);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(129, 57);
            this.btnPrueba.TabIndex = 10;
            this.btnPrueba.Text = "Realizar Prueba de Bondad";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnPoisson
            // 
            this.btnPoisson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.Location = new System.Drawing.Point(407, 25);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(107, 57);
            this.btnPoisson.TabIndex = 9;
            this.btnPoisson.Text = "Distribucion Poisson";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.Location = new System.Drawing.Point(274, 25);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(107, 57);
            this.btnExponencial.TabIndex = 8;
            this.btnExponencial.Text = "Distribucion Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(145, 25);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(107, 57);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.Text = "Distribucion Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnUniforme
            // 
            this.btnUniforme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.Location = new System.Drawing.Point(10, 25);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(107, 57);
            this.btnUniforme.TabIndex = 6;
            this.btnUniforme.Text = "Distribucion Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // gbConclucion
            // 
            this.gbConclucion.Controls.Add(this.lblVarianza);
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
            this.gbConclucion.Location = new System.Drawing.Point(1086, 261);
            this.gbConclucion.Name = "gbConclucion";
            this.gbConclucion.Size = new System.Drawing.Size(255, 289);
            this.gbConclucion.TabIndex = 0;
            this.gbConclucion.TabStop = false;
            this.gbConclucion.Text = "Conclusion";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Location = new System.Drawing.Point(63, 61);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(84, 18);
            this.lblVarianza.TabIndex = 9;
            this.lblVarianza.Text = "lblVarianza";
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
            this.label10.Location = new System.Drawing.Point(18, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "S^2:";
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
            // dgvIntervalos
            // 
            this.dgvIntervalos.AllowUserToAddRows = false;
            this.dgvIntervalos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIntervalos.ColumnHeadersHeight = 30;
            this.dgvIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.limiteInferior,
            this.limiteSuperior,
            this.marcaDeClase,
            this.frecObs,
            this.frecEsp,
            this.estadisticoIntervalo,
            this.estaditicoAcumulado});
            this.dgvIntervalos.Location = new System.Drawing.Point(195, 360);
            this.dgvIntervalos.MultiSelect = false;
            this.dgvIntervalos.Name = "dgvIntervalos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervalos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIntervalos.RowHeadersWidth = 10;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntervalos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIntervalos.Size = new System.Drawing.Size(885, 305);
            this.dgvIntervalos.TabIndex = 0;
            this.dgvIntervalos.TabStop = false;
            // 
            // limiteInferior
            // 
            this.limiteInferior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.limiteInferior.HeaderText = "Limite Inferior";
            this.limiteInferior.Name = "limiteInferior";
            this.limiteInferior.Width = 94;
            // 
            // limiteSuperior
            // 
            this.limiteSuperior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.limiteSuperior.HeaderText = "Limite Superior";
            this.limiteSuperior.Name = "limiteSuperior";
            this.limiteSuperior.Width = 101;
            // 
            // marcaDeClase
            // 
            this.marcaDeClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marcaDeClase.HeaderText = "Marca De Clase";
            this.marcaDeClase.Name = "marcaDeClase";
            this.marcaDeClase.Width = 108;
            // 
            // frecObs
            // 
            this.frecObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.frecObs.HeaderText = "Frecuencia Observada";
            this.frecObs.Name = "frecObs";
            this.frecObs.Width = 140;
            // 
            // frecEsp
            // 
            this.frecEsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.frecEsp.HeaderText = "Frecuencia Esperada";
            this.frecEsp.Name = "frecEsp";
            this.frecEsp.Width = 133;
            // 
            // estadisticoIntervalo
            // 
            this.estadisticoIntervalo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estadisticoIntervalo.HeaderText = "Estadistico del Intervalo";
            this.estadisticoIntervalo.Name = "estadisticoIntervalo";
            this.estadisticoIntervalo.Width = 144;
            // 
            // estaditicoAcumulado
            // 
            this.estaditicoAcumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estaditicoAcumulado.HeaderText = "Estadictico Acumulado";
            this.estaditicoAcumulado.Name = "estaditicoAcumulado";
            this.estaditicoAcumulado.Width = 140;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(867, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 49);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1240, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiarMuestra
            // 
            this.btnLimpiarMuestra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMuestra.Location = new System.Drawing.Point(979, 287);
            this.btnLimpiarMuestra.Name = "btnLimpiarMuestra";
            this.btnLimpiarMuestra.Size = new System.Drawing.Size(101, 49);
            this.btnLimpiarMuestra.TabIndex = 12;
            this.btnLimpiarMuestra.Text = "Limpiar Muestra";
            this.btnLimpiarMuestra.UseVisualStyleBackColor = true;
            this.btnLimpiarMuestra.Click += new System.EventHandler(this.btnLimpiarMuestra_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 672);
            this.Controls.Add(this.btnLimpiarMuestra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvIntervalos);
            this.Controls.Add(this.gbConclucion);
            this.Controls.Add(this.gbHipotesis);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.btnGenerarHistograma);
            this.Controls.Add(this.graficoHistograma);
            this.Controls.Add(this.gbIngresoMuestra);
            this.Name = "PantallaInicio";
            this.Text = "Pantalla Inicio - Prueba de Chi Cuadrado a Muestra";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            this.gbIngresoMuestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbHipotesis.ResumeLayout(false);
            this.gbConclucion.ResumeLayout(false);
            this.gbConclucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIngresoMuestra;
        private System.Windows.Forms.GroupBox gbIngresoMuestra;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistograma;
        private System.Windows.Forms.Button btnGenerarHistograma;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.MaskedTextBox txtCantIntervalos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHipotesis;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.GroupBox gbConclucion;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblComparacion;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblEstTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvIntervalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDeClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadisticoIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estaditicoAcumulado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarMuestra;
    }
}

