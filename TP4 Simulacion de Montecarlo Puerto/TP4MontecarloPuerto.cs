using System;
using System.Windows.Forms;
using TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria;
using TP4_Simulacion_de_Montecarlo_Puerto.Modelos;
using TP4_Simulacion_de_Montecarlo_Puerto.PantallasParametros;

namespace TP4_Simulacion_de_Montecarlo_Puerto
{
    public partial class TP4MontecarloPuerto : Form
    {
        private IGenerador generadorParaNormal;
        private IGenerador generadorParaLlegadas;
        private IGenerador generadorParaDescargas;
        private IDistribucion normalGanancias;
        private string[] parametrosParaNormal;
        private VectorEstadoUnMuelle vector1;
        private VectorEstadoUnMuelle vector2;

        IGenerador generadorParaPoisson;
        IGenerador generadorParaUniforme;
        IDistribucion poissonLlegadas;
        IDistribucion uniformeDescargas;
        private string[] parametroParaPoisson;
        private string[] parametrosParaUniforme;
        //private VectorEstadoDosMuelles vector1Dos;
        //private VectorEstadoDosMuelles vector2Dos;

        private long cantidadSimular;
        private long filaDesde;
        private long filaHasta;
        private int unoODos;
        public int cantHoras { get; set; }

        private long costoPorNoche;
        private long costoPorVacio;

        public TP4MontecarloPuerto()
        {
            InitializeComponent();
        }
        private void TP4MontecarloPuerto_Load(object sender, EventArgs e)
        {
            txtCostoMuelleVacio.Text = "3200";
            txtCostoPasarNoche.Text = "1500";
            txtMediaNormalGanancia.Text = "800";
            txtDesviacionNormalGanancia.Text = "120";
            txtLambdaPoissonLlegadas.Text = "2";
            txtAUniformeDescargas.Text = "0";
            txtBUniformeDescargas.Text = "9";
            unoODos = 1;
            pgbSimulacion.Visible = false;
            dgvResultadosDosM.Visible = false;
            cantHoras = 9;
        }

        #region Comportamiento del formulario
        private void cbParamsNormalGanancia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbParamsNormalGanancia.Checked)
                {
                    string[] param = new string[2];
                    param[0] = txtMediaNormalGanancia.Text;
                    param[1] = txtDesviacionNormalGanancia.Text;
                    IDistribucion distValidadoraxD = new DistribucionNormal();
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtMediaNormalGanancia.Enabled = false;
                        txtDesviacionNormalGanancia.Enabled = false;
                    }
                }
                else
                {
                    txtMediaNormalGanancia.Enabled = true;
                    txtDesviacionNormalGanancia.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtMediaNormalGanancia.Focus();
                cbParamsNormalGanancia.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtMediaNormalGanancia.Focus();
                cbParamsNormalGanancia.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbParamCostoNoche_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParamCostoNoche.Checked)
            {
                txtCostoPasarNoche.Enabled = false;
            }
            else
            {
                txtCostoPasarNoche.Enabled = true;
            }

        }

        private void cbCostoMuelleVacio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCostoMuelleVacio.Checked)
            {
                txtCostoMuelleVacio.Enabled = false;
            }
            else
            {
                txtCostoMuelleVacio.Enabled = true;
            }
        }

        private void cbParamPoissonLlegadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbParamPoissonLlegadas.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtLambdaPoissonLlegadas.Text;
                    IDistribucion distValidadoraxD = new DistribucionPoisson();
                    if (validarParamsDist(param, distValidadoraxD))
                        txtLambdaPoissonLlegadas.Enabled = false;
                }
                else
                {
                    txtLambdaPoissonLlegadas.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtLambdaPoissonLlegadas.Focus();
                cbParamPoissonLlegadas.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtLambdaPoissonLlegadas.Focus();
                cbParamPoissonLlegadas.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbParamsUniformeDescargas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbParamsUniformeDescargas.Checked)
                {
                    string[] param = new string[2];
                    param[0] = txtAUniformeDescargas.Text;
                    param[1] = txtBUniformeDescargas.Text;
                    IDistribucion distValidadoraxD = new DistribucionUniforme();
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtAUniformeDescargas.Enabled = false;
                        txtBUniformeDescargas.Enabled = false;
                    }
                }
                else
                {
                    txtAUniformeDescargas.Enabled = true;
                    txtBUniformeDescargas.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtAUniformeDescargas.Focus();
                cbParamsUniformeDescargas.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtAUniformeDescargas.Focus();
                cbParamsUniformeDescargas.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool validarParamsDist(string[] p, IDistribucion dist)
        {
            return dist.validarParametros(p);
        }
        public void paramsBorrados(int numCb)
        {
            if (numCb == 1)
                cbCargarCongNormal.Checked = false;
            if (numCb == 2)
                cbCargarCongLlegadas.Checked = false;
            if (numCb == 3)
                cbCargarCongDescargas.Checked = false;
            if (numCb == 4)
                cbCargarCongPoisson.Checked = false;
            if (numCb == 5)
                cbCargarCongUniforme.Checked = false;
        }
        #endregion

        #region Carga de Parametros para Generadores Congruenciales
        private void btnCargarCongNormal_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PantallaParamsCongNormalGanancias p = new PantallaParamsCongNormalGanancias(this);
            p.Show();
        }
        public void guardarParametrosCongNormal(long[] parametros)
        {
            generadorParaNormal = new GeneradorCongruencialMixto(parametros[0], parametros[1], parametros[2], parametros[3]);
            cbCargarCongNormal.Checked = true;
        }

        private void btnCargarCongLlegadas_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PantallaParamsCongLlegadas p = new PantallaParamsCongLlegadas(this);
            p.Show();
        }
        public void guardarParametrosCongLlegadas(long[] parametros)
        {
            generadorParaLlegadas = new GeneradorCongruencialMixto(parametros[0], parametros[1], parametros[2], parametros[3]);
            cbCargarCongLlegadas.Checked = true;
        }

        private void btnCargarCongDescargas_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PantallaParamsCongDescargas p = new PantallaParamsCongDescargas(this);
            p.Show();
        }
        public void guardarParametrosCongDescargas(long[] parametros)
        {
            generadorParaDescargas = new GeneradorCongruencialMixto(parametros[0], parametros[1], parametros[2], parametros[3]);
            cbCargarCongDescargas.Checked = true;
        }

        private void btnCargarCongPoisson_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PantallaParamsCongPoissonLlegadas p = new PantallaParamsCongPoissonLlegadas(this);
            p.Show();
        }
        public void guardarParametrosCongPoisson(long[] parametros)
        {
            generadorParaPoisson = new GeneradorCongruencialMixto(parametros[0], parametros[1], parametros[2], parametros[3]);
            cbCargarCongPoisson.Checked = true;
        }

        private void btnCargarCongUniforme_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PantallaParamsCongUniformeDescargas p = new PantallaParamsCongUniformeDescargas(this);
            p.Show();
        }
        public void guardarParametrosCongUniforme(long[] parametros)
        {
            generadorParaUniforme = new GeneradorCongruencialMixto(parametros[0], parametros[1], parametros[2], parametros[3]);
            cbCargarCongUniforme.Checked = true;
        }
        #endregion

        #region Simulacion de Un Muelle
        private void btnSimularUnMuelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarParametrosParaAmbos() && verificarParametrosUnMuelle())
                {

                    parametrosParaNormal = new string[2];
                    parametrosParaNormal[0] = txtMediaNormalGanancia.Text;
                    parametrosParaNormal[1] = txtDesviacionNormalGanancia.Text;
                    normalGanancias = new DistribucionNormal() { metodo = 1, generador = generadorParaNormal};
                    unoODos = 1;
                    dgvResultados.Visible = true;
                    dgvResultadosDosM.Visible = false;
                    simularUnMuelle();
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

        private bool verificarParametrosParaAmbos()
        {
            txtCantidadSimular.Focus();
            cantidadSimular = Convert.ToInt64(txtCantidadSimular.Text);
            if (txtCantidadSimular.Text == "" || cantidadSimular <= 0)
                throw new ApplicationException("Debe ingresar la Cantidad a Simular \n O debe ser Positiva");
            txtFilaMostrar.Focus();
            filaDesde = Convert.ToInt64(txtFilaMostrar.Text);
            if (txtFilaMostrar.Text == "")
                throw new ApplicationException("Debe ingresar la Fila a partir de la cual se mostraran 400 resultados");
            if (filaDesde < 0)
                throw new ApplicationException("La Fila desde no puede ser negativa");
            filaHasta = filaDesde + 400;
            txtCostoPasarNoche.Focus();
            costoPorNoche = Convert.ToInt64(txtCostoPasarNoche.Text);
            if (txtCostoPasarNoche.Text == "")
                throw new ApplicationException("Debe ingresar el Costo por pasar la Noche");
            txtCostoMuelleVacio.Focus();
            costoPorVacio = Convert.ToInt64(txtCostoMuelleVacio.Text);
            if (txtCostoMuelleVacio.Text == "")
                throw new ApplicationException("Debe ingresar el Costo de Muelle vacio");
            if (!cbParamsNormalGanancia.Checked)
                throw new ApplicationException("Debe Confirmar los parametros de la distribucion Normal");
            if (!cbCargarCongNormal.Checked)
                throw new ApplicationException("Debe Cargar los parametros del Generador Congruente para la distribucion Normal");
            return true;
        }

        private bool verificarParametrosUnMuelle()
        {
            if (!cbCargarCongLlegadas.Checked)
                throw new ApplicationException("Debe Cargar los parametros del Generador Congruente para las Llegadas");
            if (!cbCargarCongDescargas.Checked)
                throw new ApplicationException("Debe Cargar los parametros del Generador Congruente para las Descargas");
            return true;
        }

        private void simularUnMuelle()
        {
            dgvResultados.Rows.Clear();
            pgbSimulacion.Value = 0;
            pgbSimulacion.Maximum = Convert.ToInt32(cantidadSimular);
            pgbSimulacion.Visible = true;
            vector1 = new VectorEstadoUnMuelle() { barcosPendientes = 0, barcosDescConRet = 0, diasMuelleOcupado = 0};
            vector2 = new VectorEstadoUnMuelle() { barcosPendientes = 0, barcosDescConRet = 0, diasMuelleOcupado = 0};
            for (long i = 0; i < cantidadSimular; i++)
            {
                //Pasos Simulacion
                cargarIteracion(i+1);
                obtenerRandomLlegada();
                obtenerCantidadLlegadas();
                obtenerRandomDescarga();
                obtenerCantidadDescargas();
                calcularBarcosPendientes();
                acumularBarcosDescargadosConRetraso();
                estuvoMuelleOcupado();
                calcularPorcentajeDeOcupacion();
                calcularGanancias();
                calcularCostosPendientes();
                calcularCostosVacio();
                calcularUtilidadesTotales();
                acumularUtilidadesTotales();

                CargarFila();
                if (unoODos == 1)
                {
                    unoODos = 2;
                }
                else if (unoODos == 2)
                {
                    unoODos = 1;
                }
                pgbSimulacion.Value = Convert.ToInt32(i);
            }
            pgbSimulacion.Visible = false;
        }
        private void cargarIteracion(long i)
        {
            if (unoODos == 1)
            {
                vector1.iteracion = i;
            }
            else if (unoODos == 2)
            {
                vector2.iteracion = i;
            }
        }
        private void obtenerRandomLlegada()
        {
            double[] rndLl = generadorParaLlegadas.generarRandom();
            if (unoODos == 1)
            {
                vector1.RNDLlegada = rndLl[2];
            }
            else if (unoODos == 2)
            {
                vector2.RNDLlegada = rndLl[2];
            }
        }
        private void obtenerCantidadLlegadas()
        {
            if (unoODos == 1)
            {
                if (vector1.RNDLlegada < 0.13)
                {
                    vector1.cantLlegadas = 0;
                }
                else if (vector1.RNDLlegada < 0.30)
                {
                    vector1.cantLlegadas = 1;
                }
                else if (vector1.RNDLlegada < 0.45)
                {
                    vector1.cantLlegadas = 2;
                }
                else if (vector1.RNDLlegada < 0.70)
                {
                    vector1.cantLlegadas = 3;
                }
                else if (vector1.RNDLlegada < 0.90)
                {
                    vector1.cantLlegadas = 4;
                }
                else
                {
                    vector1.cantLlegadas = 5;
                }

            }
            else if (unoODos == 2)
            {
                if (vector2.RNDLlegada < 0.13)
                {
                    vector2.cantLlegadas = 0;
                }
                else if (vector2.RNDLlegada < 0.30)
                {
                    vector2.cantLlegadas = 1;
                }
                else if (vector2.RNDLlegada < 0.45)
                {
                    vector2.cantLlegadas = 2;
                }
                else if (vector2.RNDLlegada < 0.70)
                {
                    vector2.cantLlegadas = 3;
                }
                else if (vector2.RNDLlegada < 0.90)
                {
                    vector2.cantLlegadas = 4;
                }
                else
                {
                    vector2.cantLlegadas = 5;
                }
            }
        }
        private void obtenerRandomDescarga()
        {
            double[] rndDes = generadorParaDescargas.generarRandom();
            if (unoODos == 1)
            {
                vector1.RNDDescargas = rndDes[2];
            }
            else if (unoODos == 2)
            {
                vector2.RNDDescargas = rndDes[2];
            }
        }
        private void obtenerCantidadDescargas()
        {
            if (unoODos == 1)
            {
                if (vector1.RNDDescargas < 0.05)
                {
                    vector1.cantDescargas = 1;
                }
                else if (vector1.RNDDescargas < 0.20)
                {
                    vector1.cantDescargas = 2;
                }
                else if (vector1.RNDDescargas < 0.70)
                {
                    vector1.cantDescargas = 3;
                }
                else if (vector1.RNDDescargas < 0.90)
                {
                    vector1.cantDescargas = 4;
                }
                else
                {
                    vector1.cantDescargas = 5;
                }

            }
            else if (unoODos == 2)
            {
                if (vector2.RNDDescargas < 0.05)
                {
                    vector2.cantDescargas = 1;
                }
                else if (vector2.RNDDescargas < 0.20)
                {
                    vector2.cantDescargas = 2;
                }
                else if (vector2.RNDDescargas < 0.70)
                {
                    vector2.cantDescargas = 3;
                }
                else if (vector2.RNDDescargas < 0.90)
                {
                    vector2.cantDescargas = 4;
                }
                else
                {
                    vector2.cantDescargas = 5;
                }
            }
        }
        private void calcularBarcosPendientes()
        {
            if (unoODos == 1)
            {
                long pendientes = vector2.barcosPendientes + vector1.cantLlegadas - vector1.cantDescargas;
                if (pendientes < 0)
                {
                    vector1.barcosPendientes = 0;
                }
                else
                {
                    vector1.barcosPendientes = pendientes;
                }
            }
            else if (unoODos == 2)
            {
                long pendientes = vector1.barcosPendientes + vector2.cantLlegadas - vector2.cantDescargas;
                if (pendientes < 0)
                {
                    vector2.barcosPendientes = 0;
                }
                else
                {
                    vector2.barcosPendientes = pendientes;
                }
            }
        }
        private void acumularBarcosDescargadosConRetraso()
        {
            if (unoODos == 1)
            {
                vector1.barcosDescConRet = vector2.barcosDescConRet + vector1.barcosPendientes;
            }
            else if (unoODos == 2)
            {
                vector2.barcosDescConRet = vector1.barcosDescConRet + vector2.barcosPendientes;
            }
        }
        private void estuvoMuelleOcupado()
        {
            if (unoODos == 1)
            {
                if (vector2.barcosPendientes + vector1.cantLlegadas == 0)
                {
                    vector1.diasMuelleOcupado = vector2.diasMuelleOcupado;
                }
                else
                {
                    vector1.diasMuelleOcupado = vector2.diasMuelleOcupado + 1;
                }
            }
            else if (unoODos == 2)
            {
                if (vector1.barcosPendientes + vector2.cantLlegadas == 0)
                {
                    vector2.diasMuelleOcupado = vector1.diasMuelleOcupado;
                }
                else
                {
                    vector2.diasMuelleOcupado = vector1.diasMuelleOcupado + 1;
                }
            }
        }
        private void calcularPorcentajeDeOcupacion()
        {
            if (unoODos == 1)
            {
                vector1.porcentajeOcupacionMuelle = Math.Round(((vector1.diasMuelleOcupado / Convert.ToDouble(vector1.iteracion)) * 100.0),2);
            }
            else if (unoODos == 2)
            {
                vector2.porcentajeOcupacionMuelle = Math.Round(((vector2.diasMuelleOcupado / Convert.ToDouble(vector2.iteracion)) * 100.0), 2);
            }
        }
        private void calcularGanancias()
        {
            long descargasEfectivas = 0;
            double gananciasDia = 0;
            if (unoODos == 1)
            {
                if (vector2.barcosPendientes + vector1.cantLlegadas - vector1.cantDescargas < 0)
                {
                    descargasEfectivas = vector1.cantDescargas + (vector2.barcosPendientes + vector1.cantLlegadas - vector1.cantDescargas);
                }
                else
                {
                    descargasEfectivas = vector1.cantDescargas;
                }
                for (int i = 0; i < descargasEfectivas; i++)
                {
                    double[] varAlea = normalGanancias.generarVariableAleatoria(parametrosParaNormal);
                    if (variableValida(varAlea))
                        gananciasDia += varAlea[1];
                    else
                        i--;
                }
                vector1.gananciasDescargaBarcos = gananciasDia;
            }
            else if (unoODos == 2)
            {
                if (vector1.barcosPendientes + vector2.cantLlegadas - vector2.cantDescargas < 0)
                {
                    descargasEfectivas = vector2.cantDescargas + (vector1.barcosPendientes + vector2.cantLlegadas - vector2.cantDescargas);
                }
                else
                {
                    descargasEfectivas = vector2.cantDescargas;
                }
                for (int i = 0; i < descargasEfectivas; i++)
                {
                    double[] varAlea = normalGanancias.generarVariableAleatoria(parametrosParaNormal);
                    if (variableValida(varAlea))
                        gananciasDia += varAlea[1];
                    else
                        i--;
                }
                vector2.gananciasDescargaBarcos = gananciasDia;
            }
        }
        private bool variableValida(double[] varAlea)
        {
            if (Double.IsInfinity(varAlea[1]) || Double.IsNaN(varAlea[1]) || varAlea[1] < 0)
                return false;
            return true;
        }
        private void calcularCostosPendientes()
        {
            if (unoODos == 1)
            {
                vector1.costosBarcosPendientes = vector1.barcosPendientes * costoPorNoche;
            }
            else if (unoODos == 2)
            {
                vector2.costosBarcosPendientes = vector2.barcosPendientes * costoPorNoche;
            }
        }
        private void calcularCostosVacio()
        {
            if (unoODos == 1)
            {
                if (vector1.diasMuelleOcupado == vector2.diasMuelleOcupado)
                {
                    vector1.costosMuelleVacio = costoPorVacio;
                }
                else
                {
                    vector1.costosMuelleVacio = 0;
                }
            }
            else if (unoODos == 2)
            {
                if (vector2.diasMuelleOcupado == vector1.diasMuelleOcupado)
                {
                    vector2.costosMuelleVacio = costoPorVacio;
                }
                else
                {
                    vector2.costosMuelleVacio = 0;
                }
            }
        }
        private void calcularUtilidadesTotales()
        {
            if (unoODos == 1)
            {
                vector1.utilidadesTotales = vector1.gananciasDescargaBarcos - vector1.costosMuelleVacio - vector1.costosBarcosPendientes;
            }
            else if (unoODos == 2)
            {
                vector2.utilidadesTotales = vector2.gananciasDescargaBarcos - vector2.costosMuelleVacio - vector2.costosBarcosPendientes;
            }
        }
        private void acumularUtilidadesTotales()
        {
            if (unoODos == 1)
            {
                vector1.utilidadesAcumuladas = Math.Round((vector2.utilidadesAcumuladas + vector1.utilidadesTotales), 4);
            }
            else if (unoODos == 2)
            {
                vector2.utilidadesAcumuladas = Math.Round((vector1.utilidadesAcumuladas + vector2.utilidadesTotales), 4);
            }
        }


        private void CargarFila()
        {
            if (unoODos == 1)
            {
                if ((vector1.iteracion >= filaDesde && vector1.iteracion <= filaHasta) || vector1.iteracion == cantidadSimular)
                {
                    var fila = new string[]
                    {
                        vector1.iteracion.ToString(),
                        vector1.RNDLlegada.ToString(),
                        vector1.cantLlegadas.ToString(),
                        vector1.RNDDescargas.ToString(),
                        vector1.cantDescargas.ToString(),
                        vector1.barcosPendientes.ToString(),
                        vector1.barcosDescConRet.ToString(),
                        vector1.diasMuelleOcupado.ToString(),
                        vector1.porcentajeOcupacionMuelle.ToString(),
                        vector1.gananciasDescargaBarcos.ToString(),
                        vector1.costosBarcosPendientes.ToString(),
                        vector1.costosMuelleVacio.ToString(),
                        vector1.utilidadesTotales.ToString(),
                        vector1.utilidadesAcumuladas.ToString()
                    };
                    dgvResultados.Rows.Add(fila);
                }
            }
            else if (unoODos == 2)
            {
                if ((vector2.iteracion >= filaDesde && vector2.iteracion <= filaHasta) || vector2.iteracion == cantidadSimular)
                {
                    var fila = new string[]
                    {
                        vector2.iteracion.ToString(),
                        vector2.RNDLlegada.ToString(),
                        vector2.cantLlegadas.ToString(),
                        vector2.RNDDescargas.ToString(),
                        vector2.cantDescargas.ToString(),
                        vector2.barcosPendientes.ToString(),
                        vector2.barcosDescConRet.ToString(),
                        vector2.diasMuelleOcupado.ToString(),
                        vector2.porcentajeOcupacionMuelle.ToString(),
                        vector2.gananciasDescargaBarcos.ToString(),
                        vector2.costosBarcosPendientes.ToString(),
                        vector2.costosMuelleVacio.ToString(),
                        vector2.utilidadesTotales.ToString(),
                        vector2.utilidadesAcumuladas.ToString()
                    };
                    dgvResultados.Rows.Add(fila);
                }
            }
        }
        #endregion

        #region Siumulacion de Dos Muelles
        private void btnSimularDosMuelles_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarParametrosParaAmbos() && verificarParametrosDosMuelles())
                {
                    parametroParaPoisson = new string[1];
                    parametrosParaUniforme = new string[2];
                    parametroParaPoisson[0] = txtLambdaPoissonLlegadas.Text;
                    parametrosParaUniforme[0] = txtAUniformeDescargas.Text;
                    parametrosParaUniforme[1] = txtBUniformeDescargas.Text;
                    parametrosParaNormal = new string[2];
                    parametrosParaNormal[0] = txtMediaNormalGanancia.Text;
                    parametrosParaNormal[1] = txtDesviacionNormalGanancia.Text;
                    normalGanancias = new DistribucionNormal() { metodo = 1, generador = generadorParaNormal };
                    poissonLlegadas = new DistribucionPoisson() { generador = generadorParaPoisson };
                    uniformeDescargas = new DistribucionUniforme() { generador = generadorParaUniforme };
                    unoODos = 1;
                    dgvResultados.Visible = false;
                    dgvResultadosDosM.Visible = true;
                    simularDosMuelles();
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
        private bool verificarParametrosDosMuelles()
        {
            if (!cbParamPoissonLlegadas.Checked)
                throw new ApplicationException("Debe Confirmar los parametros de la distribucion Poisson");
            if (!cbCargarCongPoisson.Checked)
                throw new ApplicationException("Debe Cargar los parametros del Generador Congruente para la distribucion Poisson");
            if (!cbParamsUniformeDescargas.Checked)
                throw new ApplicationException("Debe Confirmar los parametros de la distribucion Uniforme");
            if (!cbCargarCongUniforme.Checked)
                throw new ApplicationException("Debe Cargar los parametros del Generador Congruente para la distribucion Uniforme");
            return true;
        }
        private void simularDosMuelles()
        {
            dgvResultadosDosM.Rows.Clear();
            pgbSimulacion.Value = 0;
            pgbSimulacion.Maximum = Convert.ToInt32(cantidadSimular);
            pgbSimulacion.Visible = true;
            vector1 = new VectorEstadoUnMuelle() { barcosPendientes = 0, barcosDescConRet = 0, diasMuelleOcupado = 0 };
            vector2 = new VectorEstadoUnMuelle() { barcosPendientes = 0, barcosDescConRet = 0, diasMuelleOcupado = 0 };
            for (long i = 0; i < cantidadSimular; i++)
            {
                //Pasos Simulacion
                cargarIteracion(i + 1);
                obtenerPoissonLlegadas();
                obtenerUniformeDescargas();
                calcularBarcosPendientes();
                acumularBarcosDescargadosConRetraso();
                estuvoMuelleOcupado();
                calcularPorcentajeDeOcupacion();
                calcularGanancias();
                calcularCostosPendientes();
                calcularCostosVacio();
                calcularUtilidadesTotales();
                acumularUtilidadesTotales();

                CargarFilaDos();
                if (unoODos == 1)
                {
                    unoODos = 2;
                }
                else if (unoODos == 2)
                {
                    unoODos = 1;
                }
                pgbSimulacion.Value = Convert.ToInt32(i);
            }
            pgbSimulacion.Visible = false;
        }
        private void obtenerPoissonLlegadas()
        {
            if (unoODos == 1)
            {
                int cantidadLlegadas = 0;
                for (int i = 0; i < cantHoras; i++)
                {
                    double[] varAle = poissonLlegadas.generarVariableAleatoria(parametroParaPoisson);
                    cantidadLlegadas += Convert.ToInt32(varAle[1]);
                }
                vector1.cantLlegadas = cantidadLlegadas;
            }
            else if (unoODos == 2)
            {
                int cantidadLlegadas = 0;
                for (int i = 0; i < cantHoras; i++)
                {
                    double[] varAle = poissonLlegadas.generarVariableAleatoria(parametroParaPoisson);
                    cantidadLlegadas += Convert.ToInt32(varAle[1]);
                }
                vector2.cantLlegadas = cantidadLlegadas;
            }
        }
        private void obtenerUniformeDescargas()
        {
            if (unoODos == 1)
            {
                double[] varAle = uniformeDescargas.generarVariableAleatoria(parametrosParaUniforme);
                vector1.cantDescargas = Convert.ToInt32(varAle[1]);
            }
            else if (unoODos == 2)
            {
                double[] varAle = uniformeDescargas.generarVariableAleatoria(parametrosParaUniforme);
                vector2.cantDescargas = Convert.ToInt32(varAle[1]);
            }
        }

        private void CargarFilaDos()
        {
            if (unoODos == 1)
            {
                if ((vector1.iteracion >= filaDesde && vector1.iteracion <= filaHasta) || vector1.iteracion == cantidadSimular)
                {
                    var fila = new string[]
                    {
                        vector1.iteracion.ToString(),
                        vector1.cantLlegadas.ToString(),
                        vector1.cantDescargas.ToString(),
                        vector1.barcosPendientes.ToString(),
                        vector1.barcosDescConRet.ToString(),
                        vector1.diasMuelleOcupado.ToString(),
                        vector1.porcentajeOcupacionMuelle.ToString(),
                        vector1.gananciasDescargaBarcos.ToString(),
                        vector1.costosBarcosPendientes.ToString(),
                        vector1.costosMuelleVacio.ToString(),
                        vector1.utilidadesTotales.ToString(),
                        vector1.utilidadesAcumuladas.ToString()
                    };
                    dgvResultadosDosM.Rows.Add(fila);
                }
            }
            else if (unoODos == 2)
            {
                if ((vector2.iteracion >= filaDesde && vector2.iteracion <= filaHasta) || vector2.iteracion == cantidadSimular)
                {
                    var fila = new string[]
                    {
                        vector2.iteracion.ToString(),
                        vector2.cantLlegadas.ToString(),
                        vector2.cantDescargas.ToString(),
                        vector2.barcosPendientes.ToString(),
                        vector2.barcosDescConRet.ToString(),
                        vector2.diasMuelleOcupado.ToString(),
                        vector2.porcentajeOcupacionMuelle.ToString(),
                        vector2.gananciasDescargaBarcos.ToString(),
                        vector2.costosBarcosPendientes.ToString(),
                        vector2.costosMuelleVacio.ToString(),
                        vector2.utilidadesTotales.ToString(),
                        vector2.utilidadesAcumuladas.ToString()
                    };
                    dgvResultadosDosM.Rows.Add(fila);
                }
            }
        }

        private void btnHorasLlegada_Click(object sender, EventArgs e)
        {
            HorasLlegada hrslleg = new HorasLlegada(this);
            hrslleg.Show();
            this.Enabled = false;
        }
        #endregion
    }
}
