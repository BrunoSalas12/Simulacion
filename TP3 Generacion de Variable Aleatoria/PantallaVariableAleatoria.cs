using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;
using TP3_Generacion_de_Variable_Aleatoria.PruebasDeBondad;

namespace TP3_Generacion_de_Variable_Aleatoria
{
    public partial class PantallaVariableAleatoria : Form
    {
        private IDistribucion distribucionSeleccionada; //Se guarda la distribucion seleccionada para poder trabajar con ella
        private GeneradorHistograma histograma; //Se guarda el generador del histograma para poder conseguir los datos para cargar el grafico y la grilla
        private IPrueba pruebaSeleccionada;//Se guarda la prueba seleccionada para poder trabajar con ella y conseguir los datos para cargar la grilla y la conclusion
        private List<double[]> listaVariables;//Se guardan las variables aleatorias generadas
        public PantallaVariableAleatoria()
        {
            InitializeComponent();
        }

        private void PantallaVariableAleatoria_Load(object sender, EventArgs e)
        {
            //Se activan y descativan los recursos pertinentes
            cargarComboBox();
            gbHistogramaYPrueba.Enabled = false;
            dgvPruebaKS.Visible = false;
            gbParametros.Enabled = false;
            lblParamUno.Text = "Media:";
            lblParamDos.Text = "Desv. Est.:";
            btnGenerar.Enabled = false;
            btnLimpiar.Enabled = false;
            lblMedia.Text = "";
            lblDesvEst.Text = "";
            lblEstCalc.Text = "";
            lblEstTab.Text = "";
            lblComparacion.Text = "";
            lblConclusion.Text = "";
            pgbGeneracion.Visible = false;
        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            //Se crea la distribucion seleccionada
            distribucionSeleccionada = new DistribucionUniforme() { m = 0, generador = new GeneradorDelLenguaje() }; //Se hardcodea el generador del lenguaje, m = 0 porque no se utilizan datos empiricos
            //Se activan y desactivan las opciones pertinentes
            btnUniforme.BackColor = Color.LightCyan;
            gbDistribucion.Enabled = false;
            gbParametros.Enabled = true;
            lblParamDos.Visible = true;
            txtParamDos.Visible = true;
            lblParamUno.Text = "a:";
            lblParamDos.Text = "b";
            btnLimpiar.Enabled = true;
            btnGenerar.Enabled = true;
            txtCantNums.Focus();
            //Se espera la carga de datos para la generacion
        }

        private void btnNormalBoxMuller_Click(object sender, EventArgs e)
        {
            //Se crea la distribucion seleccionada
            distribucionSeleccionada = new DistribucionNormal() { m = 2, metodo = 1, generador = new GeneradorDelLenguaje() };//Se hardcodea el generador del lenguaje, m = 2 porque se utilizan como datos empiricos la media y la desviacion estandar,
                                                                                                                              //metodo = 1 para identificar el metodo Box-Müller
            //Se activan y desactivan las opciones pertinentes
            btnNormalBoxMuller.BackColor = Color.LightCyan;
            gbDistribucion.Enabled = false;
            gbParametros.Enabled = true;
            lblParamDos.Visible = true;
            txtParamDos.Visible = true;
            btnLimpiar.Enabled = true;
            btnGenerar.Enabled = true;
            txtCantNums.Focus();
            //Se espera la carga de datos para la generacion
        }

        private void btnNormalCnvolucion_Click(object sender, EventArgs e)
        {
            //Se crea la distribucion seleccionada
            distribucionSeleccionada = new DistribucionNormal() { m = 2, metodo = 2, generador = new GeneradorDelLenguaje() };//Se hardcodea el generador del lenguaje, m = 2 porque se utilizan como datos empiricos la media y la desviacion estandar,
                                                                                                                              //metodo = 2 para identificar el metodo Convolucional
            //Se activan y desactivan las opciones pertinentes
            btnNormalConvolucion.BackColor = Color.LightCyan;
            gbDistribucion.Enabled = false;
            gbParametros.Enabled = true;
            lblParamDos.Visible = true;
            txtParamDos.Visible = true;
            btnLimpiar.Enabled = true;
            btnGenerar.Enabled = true;
            txtCantNums.Focus();
            //Se espera la carga de datos para la generacion
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            //Se crea la distribucion seleccionada
            distribucionSeleccionada = new DistribucionExponencial() { m = 1, generador = new GeneradorDelLenguaje() };//Se hardcodea el generador del lenguaje, m = 1 porque se utiliza como dato empirico lambda
            //Se activan y desactivan las opciones pertinentes
            btnExponencial.BackColor = Color.LightCyan;
            gbDistribucion.Enabled = false;
            gbParametros.Enabled = true;
            lblParamUno.Text = "λ:";
            lblParamDos.Visible = false;
            txtParamDos.Visible = false;
            btnLimpiar.Enabled = true;
            btnGenerar.Enabled = true;
            txtCantNums.Focus();
            //Se espera la carga de datos para la generacion
        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            //Se crea la distribucion seleccionada
            distribucionSeleccionada = new DistribucionPoisson() { m = 1, generador = new GeneradorDelLenguaje() };//Se hardcodea el generador del lenguaje, m = 1 porque se utiliza como dato empirico lambda
            //Se activan y desactivan las opciones pertinentes
            btnPoisson.BackColor = Color.LightCyan;
            gbDistribucion.Enabled = false;
            gbParametros.Enabled = true;
            lblParamUno.Text = "λ:";
            lblParamDos.Visible = false;
            txtParamDos.Visible = false;
            btnLimpiar.Enabled = true;
            btnGenerar.Enabled = true;
            txtCantNums.Focus();
            //Se espera la carga de datos para la generacion
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Se utiliza un try-catch para el manejo del ingreso de los parametros
            try
            {
                string[] parametros = new string[3];
                parametros[0] = txtCantNums.Text;
                parametros[1] = txtParamUno.Text;
                parametros[2] = txtParamDos.Text;
                if (distribucionSeleccionada.validarParametros(parametros))//Como las condiciones de los parametros dependen de la distribucion seleccionada se envian a ella para que los valide
                {
                    //Se activan y desactivan las opciones pertinentes
                    dgvListaNumeros.Rows.Clear();
                    var cant = Convert.ToInt32(parametros[0]);
                    pgbGeneracion.Maximum = cant;
                    btnGenerar.BackColor = Color.LightCyan;
                    btnGenerar.Enabled = false;
                    gbParametros.Enabled = false;
                    //Como la formula para generar las variables depende de la distribucion se le pasan los parametros a la distribucion seleccionada y se generan las variables aleatorias pertinentes
                    listaVariables = distribucionSeleccionada.generarVariablesAleatorias(parametros, this);//Se le pasa la pantalla para manejar la progress bar
                    //Se carga la grilla con la lista de variables aleatorias generadas
                    cargarGrillaVariables(listaVariables);
                    pgbGeneracion.Visible = false;
                    //Se activa la opcion para seleccionar los intervalor y generar el histograma
                    activarHistogramaYPrueba();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cargarGrillaVariables(List<double[]> varsAleats)
        {//Se realiza la carga de la grilla
            foreach (var varAleat in varsAleats)
            {
                var fila = new string[]
                {
                    varAleat[0].ToString(),
                    varAleat[1].ToString()
                };
                dgvListaNumeros.Rows.Add(fila);
            }

        }
        private void activarHistogramaYPrueba()
        {
            //Se activan y desactivan las opciones pertinentes
            gbHistogramaYPrueba.Enabled = true;
            btnPruebaChiCuadrado.Enabled = false;
            btnPruebaKS.Enabled = false;
            btnLimpiar2.Enabled = false;
        }
        private void cargarComboBox()
        {
            //Se utiliza para cargar la combo box con las cantidades de intervalos preestablecidas
            string[] cants = new string[] { "Seleccionar", "8", "10", "15", "20" };
            var conector = new BindingSource();
            conector.DataSource = cants;
            cbCantidadIntervalos.DataSource = conector;
            var tipoRolDefault = cants.First();
            cbCantidadIntervalos.SelectedItem = tipoRolDefault;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpian los campos de la seccion de generacion de la variable aleatoria, volviendo a un estado inicial para poder generar otra distribucion
            gbHistogramaYPrueba.Enabled = false;
            gbParametros.Enabled = false;
            gbDistribucion.Enabled = true;
            lblParamUno.Text = "Media:";
            lblParamDos.Text = "Desv. Est.:";
            lblParamDos.Visible = true;
            btnGenerar.Enabled = false;
            txtCantNums.Text = "";
            txtParamDos.Text = "";
            txtParamDos.Visible = true;
            txtParamUno.Text = "";
            btnUniforme.BackColor = Color.Transparent;
            btnNormalBoxMuller.BackColor = Color.Transparent;
            btnNormalConvolucion.BackColor = Color.Transparent;
            btnExponencial.BackColor = Color.Transparent;
            btnPoisson.BackColor = Color.Transparent;
            btnGenerar.BackColor = Color.Transparent;
            dgvListaNumeros.Rows.Clear();
            btnLimpiar.Enabled = false;
        }

        private void btnGenerarHistograma_Click(object sender, EventArgs e)
        {
            //Se utiliza un bloque try-catch para el manejo del ingreso de parametros y excepciones
            try
            {
                if (validInter())//Se valida que se haya seleccionado la cantidad de intervalos
                {
                    //Se activan y desactivan las opciones pertinentes
                    btnLimpiar.Enabled = false;
                    dgvListaNumeros.Enabled = true;
                    btnGenerarHistograma.BackColor = Color.LightCyan;
                    btnGenerarHistograma.Enabled = false;
                    cbCantidadIntervalos.Enabled = false;
                    btnPruebaChiCuadrado.Enabled = true;
                    btnPruebaKS.Enabled = true;
                    btnLimpiar2.Enabled = true;
                    int cantidadIntervalos = Convert.ToInt32(cbCantidadIntervalos.SelectedItem);
                    //Se utiliza un generador de histograma para que realice todos los pasos necesarios
                    histograma = new GeneradorHistograma(distribucionSeleccionada, listaVariables, cantidadIntervalos, txtParamUno.Text, txtParamDos.Text);
                    histograma.generarHistograma();//Se llama a la funcion para que se realicen los pasos de generacion del histograma
                    //Se carga el grafico con los datos del generador del histograma
                    cargarHistograma();
                    //Se carga la grilla con los datos del generador del histograma
                    cargarGrillaHistograma();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool validInter()
        {
            //Se valida que se haya seleccionado una cantidad de intervalos
            if (cbCantidadIntervalos.Text == "Seleccionar")
            {
                cbCantidadIntervalos.Focus();
                throw new ApplicationException("Debe seleccionar la cantidad de intervalos a generar");
            }
            return true;
        }
        private void cargarHistograma()
        {
            //Se carga el grafico con los datos de los intervalos obtenidos en el generador del histograma
            List<Intervalo> intervalos = histograma.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                string marca = interv.marcaDeClase.ToString();
                graficoHistograma.Series["FE"].Points.AddXY(marca, interv.frecuenciaEsperada);
                graficoHistograma.Series["FO"].Points.AddXY(marca, interv.frecuenciaObservada);
            }
        }
        private void cargarGrillaHistograma()
        {
            //Se carga la grilla con los datos de los intervalos obtenidos en el generador del histograma
            List<Intervalo> intervalos = histograma.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                var fila = new string[]
                {
                    interv.limiteInferior.ToString(),
                    interv.limiteSuperior.ToString(),
                    interv.marcaDeClase.ToString(),
                    interv.frecuenciaObservada.ToString(),
                    interv.frecuenciaEsperada.ToString(),
                };
                dgvHistograma.Rows.Add(fila);
            }
        }

        private void btnPruebaChiCuadrado_Click(object sender, EventArgs e)
        {
            //Se utiliza un bloque try-catch para el manejo de excepciones
            try
            {
                //Se activan y desactivan las opciones pertinentes
                dgvPruebaChi.Visible = true;
                dgvPruebaKS.Visible = false;
                btnPruebaChiCuadrado.Enabled = false;
                btnPruebaChiCuadrado.BackColor = Color.LightCyan;
                btnPruebaKS.Enabled = false;
                //Se utiliza una prueba seleccionada para que realice los pasos necesarios para hacer la prueba de bondad de ajuste
                pruebaSeleccionada = new PruebaChiCuadrado(histograma.getIntervalos, distribucionSeleccionada);//Se crea la prueba de Chi-Cuadrado
                pruebaSeleccionada.realizarPrueba();//Se llama a la funcion para que se realicen los pasos de la prueba de bondad
                //Se carga la grilla para la prueba de Chi-Cuadrado con los datos obtenidos en la prueba seleccionada
                cargarGrillaPruebaChi();
                //Se carga la conclucion con los datos obtenidos en la prueba seleccionada
                cargarConclusion();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cargarGrillaPruebaChi()
        {
            //Se carga la grilla con los datos de los intervalos obtenidos en la prueba seleccionada
            dgvPruebaChi.Rows.Clear();
            List<Intervalo> intervalos = pruebaSeleccionada.getIntervalos();
            foreach (Intervalo interv in intervalos)
            {
                var fila = new string[]
                {
                    interv.limiteInferior.ToString(),
                    interv.limiteSuperior.ToString(),
                    interv.frecuenciaObservada.ToString(),
                    interv.frecuenciaEsperada.ToString(),
                    interv.estadisticoIntervalo.ToString(),
                    interv.estadisticoAcumulado.ToString()
                };
                dgvPruebaChi.Rows.Add(fila);
            }
        }

        private void btnPruebaKS_Click(object sender, EventArgs e)
        {
            //Se activan y desactivan las opciones pertinentes
            dgvPruebaChi.Visible = false;
            dgvPruebaKS.Visible = true;
            btnPruebaChiCuadrado.Enabled = false;
            btnPruebaKS.Enabled = false;
            btnPruebaKS.BackColor = Color.LightCyan;
            //Se utiliza una prueba seleccionada para que realice los pasos necesarios para hacer la prueba de bondad de ajuste
            pruebaSeleccionada = new PruebaKS(histograma.getIntervalos, Convert.ToInt32(txtCantNums.Text));//Se crea la prueba de Kolmogorov-Smirnov
            pruebaSeleccionada.realizarPrueba();//Se llama a la funcion para que se realicen los pasos de la prueba de bondad
            //Se carga la grilla para la prueba de KS con los datos obtenidos en la prueba seleccionada
            cargarGrillaPruebaKS();
            //Se carga la conclucion con los datos obtenidos en la prueba seleccionada
            cargarConclusion();
        }
        private void cargarGrillaPruebaKS()
        {
            //Se carga la grilla con los datos de los intervalos obtenidos en la prueba seleccionada
            dgvPruebaKS.Rows.Clear();
            List<Intervalo> intervalos = pruebaSeleccionada.getIntervalos();
            foreach (Intervalo interv in intervalos)
            {
                var fila = new string[]
                {
                    interv.limiteInferior.ToString(),
                    interv.limiteSuperior.ToString(),
                    interv.frecuenciaObservada.ToString(),
                    interv.frecuenciaEsperada.ToString(),
                    interv.probabilidadObservada.ToString(),
                    interv.probabilidadEsperada.ToString(),
                    interv.estadisticoIntervalo.ToString(),
                    interv.estadisticoAcumulado.ToString()
                };
                dgvPruebaKS.Rows.Add(fila);
            }
        }
        private void cargarConclusion()
        {
            //Se carga la conclucion con los datos obtenidos en la prueba, y se realiza la comprobacion para saber si no se rechaza o si se rechaza la hipotesis nula
            double estCalc = pruebaSeleccionada.getEstCalc();
            double estTab = pruebaSeleccionada.getEstTab();
            lblEstCalc.Text = estCalc.ToString();
            lblEstTab.Text = estTab.ToString();
            if (estCalc <= estTab)
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
        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            //Se limpian los campos de la seccion de histograma y prueba, volviendo a un estado inicial para poder generar otro histograma y/u otra prueba
            dgvPruebaKS.Rows.Clear();
            dgvPruebaKS.Visible = false;
            dgvPruebaChi.Rows.Clear();
            dgvPruebaChi.Visible = true;
            btnPruebaChiCuadrado.Enabled = false;
            btnPruebaChiCuadrado.BackColor = Color.Transparent;
            btnPruebaKS.Enabled = false;
            btnPruebaKS.BackColor = Color.Transparent;
            lblMedia.Text = "";
            lblDesvEst.Text = "";
            lblEstCalc.Text = "";
            lblEstTab.Text = "";
            lblComparacion.Text = "";
            lblConclusion.Text = "";
            label8.Text = "x̄:";
            label10.Text = "σ:";
            dgvHistograma.Rows.Clear();
            graficoHistograma.Series["FO"].Points.Clear();
            graficoHistograma.Series["FE"].Points.Clear();
            btnGenerarHistograma.Enabled = true;
            btnGenerarHistograma.BackColor = Color.Transparent;
            cbCantidadIntervalos.Enabled = true;
            cbCantidadIntervalos.Focus();
            btnLimpiar.Enabled = true;
            btnLimpiar2.Enabled = false;
        }
        public void progressBar(int i)
        {
            //Se aumenta el valor de la progress bar
            pgbGeneracion.Visible = true;
            pgbGeneracion.Value = i;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
