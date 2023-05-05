using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    public partial class PantallaPruebaChiCuadrado : Form
    {
        private PantallaInicio _pantallaInicio;
        private IGenerador generadorSeleccionado; //Se guarda el generador seleccionado para poder pasarlo a la prueba
        private PruebaChiCuadrado prueba; //Se guarda la prueba para poder obtener de ella los intervalos con sus datos y los estadisticos
        public PantallaPruebaChiCuadrado(PantallaInicio pantIni)
        {
            _pantallaInicio = pantIni;
            InitializeComponent();
        }

        private void PantallaPruebaChiCuadrado_Load(object sender, EventArgs e)
        {
            //Se inicializa la pantalla desabilitando las opciones que no se requieren al principio
            gbCongMixto.Enabled = false;
            btnLimpiar.Enabled = false;
            lblConclusion.Text = "";
            lblEstCalc.Text = "";
            lblComparacion.Text = "";
            lblEstTab.Text = "";
            lblMedia.Text = "";
            lblVarianza.Text = "";
            cargarComboBox();
            txtCantidadNumeros.Select();
        }
        private void cargarComboBox()
        {
            string[] cants = new string[] { "Seleccionar", "5","8","10","12"};
            var conector = new BindingSource();
            conector.DataSource = cants;
            cbCantidadIntervalos.DataSource = conector;
            var tipoRolDefault = cants.First();
            cbCantidadIntervalos.SelectedItem = tipoRolDefault;
        }

        private void btnMetodoLenguaje_Click(object sender, EventArgs e)
        {
            //se utiliza un try-catch para manejar la validacion del ingreso de los parametros
            try
            {
                if (validarParams())
                {
                    //Se toman los valores ingresados
                    int cantidadIntervalos = Convert.ToInt32(cbCantidadIntervalos.SelectedItem);
                    int cantidadNumeros = Convert.ToInt32(txtCantidadNumeros.Text);
                    //Se activan y desactivan las opciones pertinentes
                    btnMetodoLenguaje.BackColor = Color.LightCyan;
                    gbParametros.Enabled = false;
                    btnLimpiar.Enabled = true;
                    btnMetodoLenguaje.Enabled = false;
                    btnCongMixto.Enabled = false;
                    pgbGeneracion.Maximum = cantidadNumeros;
                    //Se crea el generador pertinente
                    generadorSeleccionado = new GeneradorDelLenguaje();
                    //Se llama a la funcion para que realice la prueba de Chi Cuadrado
                    realizarPruebaChiCuadrado(cantidadIntervalos, cantidadNumeros);
                    //Se muestran los datos por el grafico y la grilla 
                    cargarGrafico();
                    cargarGrilla();
                    //Se muestra la conclucion por pantalla
                    generarConclusion();
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

        private void btnCongMixto_Click(object sender, EventArgs e)
        {
            //se utiliza un try-catch para manejar la validacion del ingreso de las constantes
            try
            {
                if (validarParams())
                {
                    //Se activan y desactivan las opciones pertinentes
                    btnCongMixto.BackColor = Color.LightCyan;
                    gbParametros.Enabled = false;
                    btnLimpiar.Enabled = true;
                    btnMetodoLenguaje.Enabled = false;
                    btnCongMixto.Enabled = false;
                    gbCongMixto.Enabled = true;
                    txtSemilla.Focus();
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
            //Se valida el ingreso de la cantidad de numeros a generar y la cantidad de intervalos
            if (txtCantidadNumeros.Text == "")
            {
                txtCantidadNumeros.Focus();
                throw new ApplicationException("Debe introducir la cantidad de numeros a generar");
            }
            if (cbCantidadIntervalos.Text == "Seleccionar")
            {
                cbCantidadIntervalos.Focus();
                throw new ApplicationException("Debe seleccionar la cantidad de intervalos a generar");
            }
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //se utiliza un try-catch para manejar la validacion del ingreso de las constantes
            try
            {
                if (validarCongMixto())
                {
                    //Se toman los valores ingresados
                    int semilla = Convert.ToInt32(txtSemilla.Text);
                    int multiplicador = Convert.ToInt32(txtMultiplicador.Text);
                    int modulo = Convert.ToInt32(txtModulo.Text);
                    int incremento = Convert.ToInt32(txtIncremento.Text);
                    int cantidadIntervalos = Convert.ToInt32(cbCantidadIntervalos.SelectedItem);
                    int cantidadNumeros = Convert.ToInt32(txtCantidadNumeros.Text);
                    gbCongMixto.Enabled = false;
                    pgbGeneracion.Maximum = cantidadNumeros;
                    //Se crea el generador pertinente
                    generadorSeleccionado = new GeneradorCongruencialMixto(semilla, multiplicador, modulo, incremento);
                    //Se llama a la funcion para que realice la prueba de Chi Cuadrado
                    realizarPruebaChiCuadrado(cantidadIntervalos, cantidadNumeros);
                    //Se muestran los datos por el grafico y la grilla 
                    cargarGrafico();
                    cargarGrilla();
                    //Se muestra la conclucion por pantalla
                    generarConclusion();
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
        private bool validarCongMixto()
        {
            //Verifica que las constantes necesarias para el congruencial mixto hayan sido ingresadas, en caso de que no tira un mensaje de cual es el error
            if (txtSemilla.Text == "")
            {
                txtSemilla.Focus();
                throw new ApplicationException("Debe introducir la semilla");
            }
            if (txtMultiplicador.Text == "")
            {
                txtMultiplicador.Focus();
                throw new ApplicationException("Debe introducir el multiplicador");
            }
            if (txtModulo.Text == "")
            {
                txtModulo.Focus();
                throw new ApplicationException("Debe introducir el modulo");
            }
            if (txtIncremento.Text == "")
            {
                txtIncremento.Focus();
                throw new ApplicationException("Debe introducir el incremento");
            }
            return true;
        }
        private void realizarPruebaChiCuadrado(int cantInt, int cantNums)
        {
            //Crea el objeto que realizara la pruba de Chi Cuadrado y llama a su funcion para realizarla
            IDistribucion uniforme = new DistribucionUniforme();
            prueba = new PruebaChiCuadrado(cantNums, cantInt, generadorSeleccionado, uniforme, this);
            prueba.realizarPruebaChiCuadrado();
            pgbGeneracion.Visible = false;
        }
        private void cargarGrafico()
        {
            //Utilizando los intervalos generados en la prueba carga sus datos en el grafico
            List<Intervalo> intervalos = prueba.getIntervalos;
            foreach (Intervalo interv in intervalos)
            {
                string marca = interv.marcaDeClase.ToString();
                graficaSalida.Series["FE"].Points.AddXY(marca, interv.frecuenciaEsperada);
                graficaSalida.Series["FO"].Points.AddXY(marca, interv.frecuenciaObservada);
            }
        }
        private void cargarGrilla()
        {
            //Utilizando los intervalos generados en la prueba carga sus datos en la grilla
            List<Intervalo> intervalos = prueba.getIntervalos;
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
        public void generarConclusion()
        {
            //Utilizando los datos generados en la prueba carga los estadisticos en las labels correspondientes de la conclusion
            lblEstCalc.Text = prueba.getEstadisticoCalculado.ToString();
            lblEstTab.Text = prueba.getEstadisticoTabulado.ToString();
            //Utilizando los datos generados en la prueba carga la media y la varianza en las labels correspondientes de la conclusion
            lblMedia.Text = prueba.getMedia.ToString();
            lblVarianza.Text = prueba.getVarianza.ToString();
            //Se comprueba si se rechaza o no la hipotesis nula y carga el resultado en la label correspondiente de la conclusion
            if (prueba.getEstadisticoCalculado <= prueba.getEstadisticoTabulado)
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Reinicia los campos para realizar una nueva prueba
            gbParametros.Enabled = true;
            txtCantidadNumeros.Text = "";
            cbCantidadIntervalos.SelectedItem = "Seleccionar";
            btnMetodoLenguaje.Enabled = true;
            btnMetodoLenguaje.BackColor = Color.Transparent;
            btnCongMixto.Enabled = true;
            btnCongMixto.BackColor = Color.Transparent;
            txtSemilla.Text = "";
            txtMultiplicador.Text = "";
            txtModulo.Text = "";
            txtIncremento.Text = "";
            gbCongMixto.Enabled = false;
            lblEstCalc.Text = "";
            lblComparacion.Text = "";
            lblEstTab.Text = "";
            lblConclusion.Text = "";
            lblMedia.Text = "";
            lblVarianza.Text = "";
            graficaSalida.Series["FE"].Points.Clear();
            graficaSalida.Series["FO"].Points.Clear();
            dgvIntervalos.Rows.Clear();
            btnLimpiar.Enabled = false;
            txtCantidadNumeros.Focus();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Vuelve a la pantalla inicial
            cerrarVentana();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra toda la aplicacion
            this.Dispose();
            _pantallaInicio.Dispose();
        }
        private void cerrarVentana()
        {
            //Vuelve a la pantalla inicial
            _pantallaInicio.Show();
            this.Dispose();
        }

        private void PantallaPruebaChiCuadrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Vuelve a la pantalla inicial
            cerrarVentana();
        }
        public void progressBar(int valor)
        {
            //Realiza la carga de la progress bar para que se pueda visualizar el avance de la generacion de los numeros en caso de demora
            pgbGeneracion.Visible = true;
            pgbGeneracion.Value = valor;
        }

        private void txtSemilla_Enter(object sender, EventArgs e)
        {
            var derp = "";
            EventArgs f = new EventArgs();
            btnGenerar_Click(derp, f);
        }
    }
}
