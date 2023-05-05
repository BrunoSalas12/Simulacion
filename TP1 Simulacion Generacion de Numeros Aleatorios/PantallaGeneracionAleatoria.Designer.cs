namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    partial class PantallaGeneracionAleatoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCongMixto = new System.Windows.Forms.Button();
            this.dgvListaNumeros = new System.Windows.Forms.DataGridView();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCongMult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIncremento = new System.Windows.Forms.MaskedTextBox();
            this.txtModulo = new System.Windows.Forms.MaskedTextBox();
            this.txtMultiplicador = new System.Windows.Forms.MaskedTextBox();
            this.txtSemilla = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantidadAGenerar = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pgbGeneracion = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNumeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCongMixto
            // 
            this.btnCongMixto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCongMixto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongMixto.Location = new System.Drawing.Point(232, 53);
            this.btnCongMixto.Name = "btnCongMixto";
            this.btnCongMixto.Size = new System.Drawing.Size(125, 73);
            this.btnCongMixto.TabIndex = 6;
            this.btnCongMixto.Text = "Metodo Congruencial Mixto";
            this.btnCongMixto.UseVisualStyleBackColor = false;
            this.btnCongMixto.Click += new System.EventHandler(this.btnCongMixto_Click);
            // 
            // dgvListaNumeros
            // 
            this.dgvListaNumeros.AllowUserToAddRows = false;
            this.dgvListaNumeros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaNumeros.ColumnHeadersHeight = 30;
            this.dgvListaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pos,
            this.rnd});
            this.dgvListaNumeros.Location = new System.Drawing.Point(520, 12);
            this.dgvListaNumeros.MultiSelect = false;
            this.dgvListaNumeros.Name = "dgvListaNumeros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaNumeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaNumeros.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaNumeros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaNumeros.Size = new System.Drawing.Size(339, 321);
            this.dgvListaNumeros.TabIndex = 1;
            this.dgvListaNumeros.TabStop = false;
            // 
            // pos
            // 
            this.pos.HeaderText = "Posicion";
            this.pos.Name = "pos";
            // 
            // rnd
            // 
            this.rnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rnd.HeaderText = "Random";
            this.rnd.Name = "rnd";
            // 
            // btnGenerarSiguiente
            // 
            this.btnGenerarSiguiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarSiguiente.Location = new System.Drawing.Point(414, 12);
            this.btnGenerarSiguiente.Name = "btnGenerarSiguiente";
            this.btnGenerarSiguiente.Size = new System.Drawing.Size(100, 54);
            this.btnGenerarSiguiente.TabIndex = 7;
            this.btnGenerarSiguiente.Text = "Generar Siguiente";
            this.btnGenerarSiguiente.UseVisualStyleBackColor = true;
            this.btnGenerarSiguiente.Click += new System.EventHandler(this.btnGenerarSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Semilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Multiplicador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Incremento";
            // 
            // btnCongMult
            // 
            this.btnCongMult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongMult.Location = new System.Drawing.Point(232, 197);
            this.btnCongMult.Name = "btnCongMult";
            this.btnCongMult.Size = new System.Drawing.Size(125, 76);
            this.btnCongMult.TabIndex = 7;
            this.btnCongMult.Text = "Metodo Congruencial Multiplicativo";
            this.btnCongMult.UseVisualStyleBackColor = true;
            this.btnCongMult.Click += new System.EventHandler(this.btnCongMult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.txtModulo);
            this.groupBox1.Controls.Add(this.txtMultiplicador);
            this.groupBox1.Controls.Add(this.txtSemilla);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introducir constantes";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(108, 169);
            this.txtIncremento.Mask = "999999999";
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.PromptChar = ' ';
            this.txtIncremento.Size = new System.Drawing.Size(80, 26);
            this.txtIncremento.TabIndex = 5;
            this.txtIncremento.ValidatingType = typeof(int);
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(108, 118);
            this.txtModulo.Mask = "999999999";
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.PromptChar = ' ';
            this.txtModulo.Size = new System.Drawing.Size(80, 26);
            this.txtModulo.TabIndex = 4;
            this.txtModulo.ValidatingType = typeof(int);
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(108, 72);
            this.txtMultiplicador.Mask = "999999999";
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.PromptChar = ' ';
            this.txtMultiplicador.Size = new System.Drawing.Size(80, 26);
            this.txtMultiplicador.TabIndex = 3;
            this.txtMultiplicador.ValidatingType = typeof(int);
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(108, 28);
            this.txtSemilla.Mask = "999999999";
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.PromptChar = ' ';
            this.txtSemilla.Size = new System.Drawing.Size(80, 26);
            this.txtSemilla.TabIndex = 2;
            this.txtSemilla.ValidatingType = typeof(int);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(414, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 49);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 308);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 39);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(110, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 39);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantidadAGenerar
            // 
            this.txtCantidadAGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadAGenerar.Location = new System.Drawing.Point(180, 12);
            this.txtCantidadAGenerar.Mask = "999999999";
            this.txtCantidadAGenerar.Name = "txtCantidadAGenerar";
            this.txtCantidadAGenerar.PromptChar = ' ';
            this.txtCantidadAGenerar.Size = new System.Drawing.Size(80, 26);
            this.txtCantidadAGenerar.TabIndex = 1;
            this.txtCantidadAGenerar.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad a Generar";
            // 
            // pgbGeneracion
            // 
            this.pgbGeneracion.Location = new System.Drawing.Point(12, 279);
            this.pgbGeneracion.Name = "pgbGeneracion";
            this.pgbGeneracion.Size = new System.Drawing.Size(502, 23);
            this.pgbGeneracion.TabIndex = 0;
            // 
            // PantallaGeneracionAleatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 354);
            this.Controls.Add(this.pgbGeneracion);
            this.Controls.Add(this.txtCantidadAGenerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCongMult);
            this.Controls.Add(this.btnGenerarSiguiente);
            this.Controls.Add(this.dgvListaNumeros);
            this.Controls.Add(this.btnCongMixto);
            this.Name = "PantallaGeneracionAleatoria";
            this.Text = "TP1 SIM Numeros Aleatorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaGeneracionAleatoria_FormClosing);
            this.Load += new System.EventHandler(this.Pantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNumeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCongMixto;
        private System.Windows.Forms.DataGridView dgvListaNumeros;
        private System.Windows.Forms.Button btnGenerarSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCongMult;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox txtSemilla;
        private System.Windows.Forms.MaskedTextBox txtIncremento;
        private System.Windows.Forms.MaskedTextBox txtModulo;
        private System.Windows.Forms.MaskedTextBox txtMultiplicador;
        private System.Windows.Forms.MaskedTextBox txtCantidadAGenerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pgbGeneracion;
    }
}

