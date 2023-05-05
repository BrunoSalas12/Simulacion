namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    partial class PantallaInicio
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
            this.btnGeneracionAleatoria = new System.Windows.Forms.Button();
            this.btnPruebaChiCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneracionAleatoria
            // 
            this.btnGeneracionAleatoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneracionAleatoria.Location = new System.Drawing.Point(88, 61);
            this.btnGeneracionAleatoria.Name = "btnGeneracionAleatoria";
            this.btnGeneracionAleatoria.Size = new System.Drawing.Size(135, 79);
            this.btnGeneracionAleatoria.TabIndex = 0;
            this.btnGeneracionAleatoria.Text = "Generadores de Numeros Aleatorios";
            this.btnGeneracionAleatoria.UseVisualStyleBackColor = true;
            this.btnGeneracionAleatoria.Click += new System.EventHandler(this.btnGeneracionAleatoria_Click);
            // 
            // btnPruebaChiCuadrado
            // 
            this.btnPruebaChiCuadrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaChiCuadrado.Location = new System.Drawing.Point(357, 61);
            this.btnPruebaChiCuadrado.Name = "btnPruebaChiCuadrado";
            this.btnPruebaChiCuadrado.Size = new System.Drawing.Size(135, 79);
            this.btnPruebaChiCuadrado.TabIndex = 1;
            this.btnPruebaChiCuadrado.Text = "Prueba de Chi Cuadrado";
            this.btnPruebaChiCuadrado.UseVisualStyleBackColor = true;
            this.btnPruebaChiCuadrado.Click += new System.EventHandler(this.btnPruebaChiCuadrado_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 199);
            this.Controls.Add(this.btnPruebaChiCuadrado);
            this.Controls.Add(this.btnGeneracionAleatoria);
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneracionAleatoria;
        private System.Windows.Forms.Button btnPruebaChiCuadrado;
    }
}