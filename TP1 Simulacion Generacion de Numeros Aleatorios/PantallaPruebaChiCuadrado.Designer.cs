namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    partial class PantallaPruebaChiCuadrado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.graficaSalida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.cbCantidadIntervalos = new System.Windows.Forms.ComboBox();
            this.txtCantidadNumeros = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCongMixto = new System.Windows.Forms.Button();
            this.btnMetodoLenguaje = new System.Windows.Forms.Button();
            this.gbCongMixto = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.MaskedTextBox();
            this.txtModulo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMultiplicador = new System.Windows.Forms.MaskedTextBox();
            this.txtSemilla = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.pgbGeneracion = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.graficaSalida)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.gbCongMixto.SuspendLayout();
            this.gbConclucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // graficaSalida
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30 | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45)));
            chartArea1.Name = "ChartArea1";
            this.graficaSalida.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficaSalida.Legends.Add(legend1);
            this.graficaSalida.Location = new System.Drawing.Point(13, 127);
            this.graficaSalida.Name = "graficaSalida";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "FE";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "FO";
            this.graficaSalida.Series.Add(series1);
            this.graficaSalida.Series.Add(series2);
            this.graficaSalida.Size = new System.Drawing.Size(885, 357);
            this.graficaSalida.TabIndex = 0;
            this.graficaSalida.TabStop = false;
            this.graficaSalida.Text = "chart1";
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.cbCantidadIntervalos);
            this.gbParametros.Controls.Add(this.txtCantidadNumeros);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(13, 13);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(384, 108);
            this.gbParametros.TabIndex = 1;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Ingrese los parametros";
            // 
            // cbCantidadIntervalos
            // 
            this.cbCantidadIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCantidadIntervalos.FormattingEnabled = true;
            this.cbCantidadIntervalos.Location = new System.Drawing.Point(248, 65);
            this.cbCantidadIntervalos.Name = "cbCantidadIntervalos";
            this.cbCantidadIntervalos.Size = new System.Drawing.Size(130, 26);
            this.cbCantidadIntervalos.TabIndex = 2;
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(248, 28);
            this.txtCantidadNumeros.Mask = "999999999";
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.PromptChar = ' ';
            this.txtCantidadNumeros.Size = new System.Drawing.Size(130, 26);
            this.txtCantidadNumeros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Numeros a Generar";
            // 
            // btnCongMixto
            // 
            this.btnCongMixto.BackColor = System.Drawing.Color.Transparent;
            this.btnCongMixto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongMixto.Location = new System.Drawing.Point(569, 26);
            this.btnCongMixto.Name = "btnCongMixto";
            this.btnCongMixto.Size = new System.Drawing.Size(131, 81);
            this.btnCongMixto.TabIndex = 4;
            this.btnCongMixto.Text = "Metodo Congruencial Mixto";
            this.btnCongMixto.UseVisualStyleBackColor = false;
            this.btnCongMixto.Click += new System.EventHandler(this.btnCongMixto_Click);
            // 
            // btnMetodoLenguaje
            // 
            this.btnMetodoLenguaje.BackColor = System.Drawing.Color.Transparent;
            this.btnMetodoLenguaje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoLenguaje.Location = new System.Drawing.Point(426, 26);
            this.btnMetodoLenguaje.Name = "btnMetodoLenguaje";
            this.btnMetodoLenguaje.Size = new System.Drawing.Size(128, 81);
            this.btnMetodoLenguaje.TabIndex = 3;
            this.btnMetodoLenguaje.Text = "Metodo Provisto por el Lenguaje";
            this.btnMetodoLenguaje.UseVisualStyleBackColor = false;
            this.btnMetodoLenguaje.Click += new System.EventHandler(this.btnMetodoLenguaje_Click);
            // 
            // gbCongMixto
            // 
            this.gbCongMixto.Controls.Add(this.btnGenerar);
            this.gbCongMixto.Controls.Add(this.txtIncremento);
            this.gbCongMixto.Controls.Add(this.txtModulo);
            this.gbCongMixto.Controls.Add(this.label5);
            this.gbCongMixto.Controls.Add(this.label6);
            this.gbCongMixto.Controls.Add(this.txtMultiplicador);
            this.gbCongMixto.Controls.Add(this.txtSemilla);
            this.gbCongMixto.Controls.Add(this.label3);
            this.gbCongMixto.Controls.Add(this.label4);
            this.gbCongMixto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCongMixto.Location = new System.Drawing.Point(904, 13);
            this.gbCongMixto.Name = "gbCongMixto";
            this.gbCongMixto.Size = new System.Drawing.Size(255, 217);
            this.gbCongMixto.TabIndex = 5;
            this.gbCongMixto.TabStop = false;
            this.gbCongMixto.Text = "Ingrese las constantes";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(79, 169);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(99, 42);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(125, 137);
            this.txtIncremento.Mask = "999999999";
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.PromptChar = ' ';
            this.txtIncremento.Size = new System.Drawing.Size(100, 26);
            this.txtIncremento.TabIndex = 8;
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(125, 100);
            this.txtModulo.Mask = "999999999";
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.PromptChar = ' ';
            this.txtModulo.Size = new System.Drawing.Size(100, 26);
            this.txtModulo.TabIndex = 7;
            this.txtModulo.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Incremento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modulo";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(125, 65);
            this.txtMultiplicador.Mask = "999999999";
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.PromptChar = ' ';
            this.txtMultiplicador.Size = new System.Drawing.Size(100, 26);
            this.txtMultiplicador.TabIndex = 6;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(125, 28);
            this.txtSemilla.Mask = "999999999";
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.PromptChar = ' ';
            this.txtSemilla.Size = new System.Drawing.Size(100, 26);
            this.txtSemilla.TabIndex = 5;
            this.txtSemilla.ValidatingType = typeof(int);
            this.txtSemilla.Enter += new System.EventHandler(this.txtSemilla_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Multiplicador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Semilla";
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
            this.gbConclucion.Location = new System.Drawing.Point(904, 236);
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
            this.dgvIntervalos.Location = new System.Drawing.Point(13, 490);
            this.dgvIntervalos.MultiSelect = false;
            this.dgvIntervalos.Name = "dgvIntervalos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervalos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntervalos.RowHeadersWidth = 10;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntervalos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIntervalos.Size = new System.Drawing.Size(885, 305);
            this.dgvIntervalos.TabIndex = 9;
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
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(906, 663);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1081, 750);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 39);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(983, 750);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 39);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pgbGeneracion
            // 
            this.pgbGeneracion.Location = new System.Drawing.Point(13, 127);
            this.pgbGeneracion.Name = "pgbGeneracion";
            this.pgbGeneracion.Size = new System.Drawing.Size(868, 23);
            this.pgbGeneracion.TabIndex = 0;
            this.pgbGeneracion.Visible = false;
            // 
            // PantallaPruebaChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 800);
            this.Controls.Add(this.pgbGeneracion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvIntervalos);
            this.Controls.Add(this.gbConclucion);
            this.Controls.Add(this.gbCongMixto);
            this.Controls.Add(this.btnMetodoLenguaje);
            this.Controls.Add(this.btnCongMixto);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.graficaSalida);
            this.Name = "PantallaPruebaChiCuadrado";
            this.Text = "PantallaPruebaChiCuadrado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPruebaChiCuadrado_FormClosing);
            this.Load += new System.EventHandler(this.PantallaPruebaChiCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficaSalida)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbCongMixto.ResumeLayout(false);
            this.gbCongMixto.PerformLayout();
            this.gbConclucion.ResumeLayout(false);
            this.gbConclucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficaSalida;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.MaskedTextBox txtCantidadNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCongMixto;
        private System.Windows.Forms.Button btnMetodoLenguaje;
        private System.Windows.Forms.GroupBox gbCongMixto;
        private System.Windows.Forms.MaskedTextBox txtIncremento;
        private System.Windows.Forms.MaskedTextBox txtModulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtMultiplicador;
        private System.Windows.Forms.MaskedTextBox txtSemilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbConclucion;
        private System.Windows.Forms.Label lblComparacion;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblEstTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvIntervalos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ProgressBar pgbGeneracion;
        private System.Windows.Forms.ComboBox cbCantidadIntervalos;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDeClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadisticoIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estaditicoAcumulado;
    }
}