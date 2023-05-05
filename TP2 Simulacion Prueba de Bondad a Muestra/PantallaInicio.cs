using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra
{
    public partial class PantallaInicio : Form
    {
        private string[] separadores;
        private double[] muestra;
        private double tamañoMuestra;
        PruebaChiCuadrado _prueba;
        private int m;
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            DefinirSeparadores(new List<string>() { " ", "\n" });
            lblMedia.Text = "";
            lblVarianza.Text = "";
            lblComparacion.Text = "";
            lblConclusion.Text = "";
            lblEstCalc.Text = "";
            lblEstTab.Text = "";
            gbHipotesis.Enabled = false;
            btnLimpiar.Enabled = false;
            btnLimpiarMuestra.Enabled = false;

        }

        private void btnGenerarHistograma_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarParams())
                {
                    obtenerArrayMuestra();
                    int min = Convert.ToInt32(txtMinimo.Text);
                    int max = Convert.ToInt32(txtMaximo.Text);
                    int cantInt = Convert.ToInt32(txtCantIntervalos.Text);
                    gbHipotesis.Enabled = true;
                    btnPrueba.Enabled = false;
                    btnLimpiar.Enabled = true;
                    btnLimpiarMuestra.Enabled = true;
                    gbIngresoMuestra.Enabled = false;
                    gbParametros.Enabled = false;
                    btnGenerarHistograma.BackColor = Color.LightCyan;
                    btnGenerarHistograma.Enabled = false;
                    _prueba = new PruebaChiCuadrado(min, max, cantInt, muestra);
                    _prueba.generarHistograma();
                    cargarHistograma();
                    cargarGrilla();
                }
            }
            catch (ApplicationException msg)
            {
                MessageBox.Show(msg.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validarParams()
        {
            //Se valida el ingreso de la Muestra, el minimo, el maximo y la cantidad de intervalos
            if (txtIngresoMuestra.Text == "")
            {
                txtIngresoMuestra.Focus();
                throw new ApplicationException("Debe Ingresar la Muestra");
            }
            if (txtMinimo.Text == "")
            {
                txtMinimo.Focus();
                throw new ApplicationException("Debe singresar el valor minimo");
            }
            if (txtMaximo.Text == "")
            {
                txtMaximo.Focus();
                throw new ApplicationException("Debe ingresar el valor maximo");
            }
            int cantInt = Convert.ToInt32(txtCantIntervalos.Text);
            if (txtCantIntervalos.Text == "" || cantInt <= 3)
            {
                txtCantIntervalos.Focus();
                throw new ApplicationException("Debe ingresar la cantidad de intervalos a generar y debe ser mayor a 3");
            }
            int max = Convert.ToInt32(txtMaximo.Text);
            int min = Convert.ToInt32(txtMinimo.Text);
            if (min >= max)
            {
                txtMinimo.Focus();
                throw new ApplicationException("El Minimo no puede ser superior o igual al Maximo");
            }
            return true;
        }

        private void obtenerArrayMuestra()
        {
            string[] muestraString = txtIngresoMuestra.Text.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
            muestra = new double[muestraString.Length];
            int cont = 0;
            foreach (var valor in muestraString)
            {
                double val = Convert.ToDouble(valor);
                muestra.SetValue(val, cont);
                cont++;
            }
            tamañoMuestra = muestra.Length;
        }
        private void cargarHistograma()
        {
            List<Intervalo> intervalos = _prueba.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                string marca = interv.marcaDeClase.ToString();
                graficoHistograma.Series["FO"].Points.AddXY(marca, interv.frecuenciaObservada);
            }
        }
        private void cargarGrilla()
        {
            dgvIntervalos.Rows.Clear();
            List<Intervalo> intervalos = _prueba.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                var fila = new string[]
                {
                    interv.limiteInferior.ToString(),
                    interv.limiteSuperior.ToString(),
                    interv.marcaDeClase.ToString(),
                    interv.frecuenciaObservada.ToString(),
                    interv.frecuenciaEsperada.ToString(),
                    interv.estadisticoIntervalo.ToString(),
                    interv.estadisticoAcumulado.ToString()
                };
                dgvIntervalos.Rows.Add(fila);
            }
        }
        private void btnUniforme_Click(object sender, EventArgs e)
        {
            btnUniforme.BackColor = Color.LightCyan;
            btnNormal.BackColor = Color.Transparent;
            btnExponencial.BackColor = Color.Transparent;
            btnPoisson.BackColor = Color.Transparent;
            btnPrueba.Enabled = true;
            lblVarianza.Visible = true;
            label10.Visible = true;
            label8.Text = "x̄:";
            IDistribucion distSelec = new DistribucionUniforme() { m = 0 };
            _prueba.obtenerFrecuenciasEsperadas(distSelec);
            cargarFrecuenciasEsperadas();
            cargarGrilla();
            cargarMediaYVarianza();
        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnUniforme.BackColor = Color.Transparent;
            btnNormal.BackColor = Color.LightCyan;
            btnExponencial.BackColor = Color.Transparent;
            btnPoisson.BackColor = Color.Transparent;
            btnPrueba.Enabled = true;
            lblVarianza.Visible = true;
            label10.Visible = true;
            label8.Text = "x̄:";
            IDistribucion distSelec = new DistribucionNormal() { m = 2 };
            _prueba.obtenerFrecuenciasEsperadas(distSelec);
            cargarFrecuenciasEsperadas();
            cargarGrilla();
            cargarMediaYVarianza();
        }
        private void btnExponencial_Click(object sender, EventArgs e)
        {
            btnUniforme.BackColor = Color.Transparent;
            btnNormal.BackColor = Color.Transparent;
            btnExponencial.BackColor = Color.LightCyan;
            btnPoisson.BackColor = Color.Transparent;
            btnPrueba.Enabled = true;
            lblVarianza.Visible = false;
            label10.Visible = false;
            label8.Text = "λ:";
            IDistribucion distSelec = new DistribucionExponencial() { m = 1 };
            _prueba.obtenerFrecuenciasEsperadas(distSelec);
            cargarFrecuenciasEsperadas();
            cargarGrilla();
            cargarMediaYVarianza();
        }
        private void btnPoisson_Click(object sender, EventArgs e)
        {
            btnUniforme.BackColor = Color.Transparent;
            btnNormal.BackColor = Color.Transparent;
            btnExponencial.BackColor = Color.Transparent;
            btnPoisson.BackColor = Color.LightCyan;
            btnPrueba.Enabled = true;
            lblVarianza.Visible = false;
            label10.Visible = false;
            label8.Text = "λ:";
            IDistribucion distSelec = new DistribucionPoisson() { m = 1 };
            _prueba.obtenerFrecuenciasEsperadas(distSelec);
            cargarFrecuenciasEsperadas();
            cargarGrilla();
            cargarMediaYVarianza();
        }
        private void cargarFrecuenciasEsperadas()
        {
            graficoHistograma.Series["FE"].Points.Clear();
            List<Intervalo> intervalos = _prueba.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                string marca = interv.marcaDeClase.ToString();
                graficoHistograma.Series["FE"].Points.AddXY(marca, interv.frecuenciaEsperada);
            }
        }
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            try
            {
                btnPrueba.BackColor = Color.LightCyan;
                gbHipotesis.Enabled = false;
                _prueba.realizarPruebaDeBondad();
                cargarGrilla();
                generarConclusion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarMediaYVarianza()
        {
            //Utilizando los datos generados en la prueba carga la media y la varianza en las labels correspondientes de la conclusion
            if (btnExponencial.BackColor == Color.LightCyan)
            {
                double lamda = Math.Round((1 / _prueba.getMedia), 4);
                lblMedia.Text = lamda.ToString();
            }
            else
            {
                lblMedia.Text = _prueba.getMedia.ToString();
            }
            lblVarianza.Text = _prueba.getVarianza.ToString();
        }
        public void generarConclusion()
        {
            //Utilizando los datos generados en la prueba carga los estadisticos en las labels correspondientes de la conclusion
            lblEstCalc.Text = _prueba.getEstadisticoCalculado.ToString();
            lblEstTab.Text = _prueba.getEstadisticoTabulado.ToString();

            //Se comprueba si se rechaza o no la hipotesis nula y carga el resultado en la label correspondiente de la conclusion
            if (_prueba.getEstadisticoCalculado <= _prueba.getEstadisticoTabulado)
            {
                lblComparacion.Text = lblEstCalc.Text + " ≤ " + lblEstTab.Text;
                lblConclusion.Text = "No se rechaza \n la Hipotesis Nula";
            }
            else
            {
                lblComparacion.Text = lblEstCalc.Text + " > " + lblEstTab.Text;
                lblConclusion.Text = "Se rechaza \n la Hipotesis Nula";
            }
        }

            private void DefinirSeparadores(List<string> seps)
        {
            int tamaño = seps.Count();
            separadores = new string[tamaño];
            int cont = 0;
            foreach (var s in seps)
            {
                separadores.SetValue(s, cont);
                cont++;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gbIngresoMuestra.Enabled = true;
            gbParametros.Enabled = true;
            txtMinimo.Text = "";
            txtMaximo.Text = "";
            txtCantIntervalos.Text = "";
            btnGenerarHistograma.Enabled = true;
            btnGenerarHistograma.BackColor = Color.Transparent;
            gbHipotesis.Enabled = false;
            btnUniforme.BackColor = Color.Transparent;
            btnNormal.BackColor = Color.Transparent;
            btnExponencial.BackColor = Color.Transparent;
            btnPoisson.BackColor = Color.Transparent;
            btnPrueba.BackColor = Color.Transparent;
            graficoHistograma.Series["FE"].Points.Clear();
            graficoHistograma.Series["FO"].Points.Clear();
            dgvIntervalos.Rows.Clear();
            lblEstCalc.Text = "";
            lblComparacion.Text = "";
            lblEstTab.Text = "";
            lblConclusion.Text = "";
            lblMedia.Text = "";
            lblVarianza.Text = "";
            lblVarianza.Visible = true;
            label10.Visible = true;
            label8.Text = "x̄:";
            txtMinimo.Focus();
            btnLimpiar.Enabled = false;

        }

        private void btnLimpiarMuestra_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Esta Seguro de Limpiar la Muestra?", "Limpiar Muestra", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.OK)
            {
                btnLimpiar_Click("n", new EventArgs());
                txtIngresoMuestra.Text = "";
                btnLimpiarMuestra.Enabled = false;
            }

        }

        private void txtIngresoMuestra_TextChanged(object sender, EventArgs e)
        {
            string[] muestraString = txtIngresoMuestra.Text.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
            double min = 100000;
            double max = -100000;
            foreach (var valor in muestraString)
            {
                if (Convert.ToDouble(valor) <= min)
                {
                    txtMinimo.Text = valor;
                    min = Convert.ToDouble(valor);
                }
                if (Convert.ToDouble(valor) >= max)
                {
                    txtMaximo.Text = valor;
                    max = Convert.ToDouble(valor + 1);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
