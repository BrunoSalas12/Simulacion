using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    public partial class PantallaGeneracionAleatoria : Form
    {
        private IGenerador generadorSeleccionado; //Se guarda el generador seleccionado para poder continuar con la secuencia de numeros
        private PantallaInicio _pantallaInicio;
        public PantallaGeneracionAleatoria(PantallaInicio pantIni)
        {
            _pantallaInicio = pantIni;
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            //Se inicializa la pantalla desabilitando botones que no se requieren al principio
            btnGenerarSiguiente.Enabled = false;
            btnLimpiar.Enabled = false;
            pgbGeneracion.Visible = false;
            txtCantidadAGenerar.Select();

        }

        private void btnCongMixto_Click(object sender, EventArgs e)
        {
            //Se utiliza un try-catch para manejar la validacion del ingreso de las constantes
            try
            {
                if (validarCongMixto())
                {
                    //Se toman los valores ingresados
                    int semilla = Convert.ToInt32(txtSemilla.Text);
                    int multiplicador = Convert.ToInt32(txtMultiplicador.Text);
                    int modulo = Convert.ToInt32(txtModulo.Text);
                    int incremento = Convert.ToInt32(txtIncremento.Text);
                    int cantidad = Convert.ToInt32(txtCantidadAGenerar.Text);
                    //Se activan y desactivan las opciones pertinentes
                    btnCongMixto.BackColor = Color.LightCyan;
                    groupBox1.Enabled = false;
                    btnGenerarSiguiente.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnCongMult.Enabled = false;
                    btnCongMixto.Enabled = false;
                    txtCantidadAGenerar.Enabled = false;
                    //Se crea el generador pertinente y se genera la lista de N randoms
                    generadorSeleccionado = new GeneradorCongruencialMixto(semilla, multiplicador, modulo, incremento);
                    generarSerieRandoms(cantidad);
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
        private void generarSerieRandoms(int cant) 
        {
            dgvListaNumeros.Rows.Clear(); //Limpia la grilla
            pgbGeneracion.Visible = true;
            pgbGeneracion.Maximum = cant;
            //Con la cantidad pasada por parametro genera los randoms con el metodo seleccionado y los va mostrando en la grilla
            for (int i = 0; i < cant; i++)
            {
                double[] random = generadorSeleccionado.generarRandom();
                cargarGrilla(random);
                progressBar(i);
            }
            pgbGeneracion.Visible = false;
        }
        private void cargarGrilla(double[] rnd)
        {
            //Se carga en la grilla la posicion y el random pasados por parametro
            var fila = new string[]
            {
                rnd[0].ToString(),
                rnd[2].ToString(),
            };
            dgvListaNumeros.Rows.Add(fila);
        }
        
        private void btnGenerarSiguiente_Click(object sender, EventArgs e)
        {
            //Se utiliza el generador selecionado para hacer el siguiente random y se muestra por la grilla
            double[] random = generadorSeleccionado.generarRandom();
            cargarGrilla(random);
            dgvListaNumeros.FirstDisplayedScrollingRowIndex = dgvListaNumeros.RowCount - 1;
        }

        private void btnCongMult_Click(object sender, EventArgs e)
        {
            //se utiliza un try-catch para manejar la validacion del ingreso de las constantes
            try
            {
                if (validarCongMult())
                {
                    //Se toman los valores ingresados
                    int semilla = Convert.ToInt32(txtSemilla.Text);
                    int multiplicador = Convert.ToInt32(txtMultiplicador.Text);
                    int modulo = Convert.ToInt32(txtModulo.Text);
                    int cantidad = Convert.ToInt32(txtCantidadAGenerar.Text);
                    //Se activan y desactivan las opciones pertinentes
                    btnCongMult.BackColor = Color.LightCyan;
                    groupBox1.Enabled = false;
                    btnGenerarSiguiente.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnCongMult.Enabled = false;
                    btnCongMixto.Enabled = false;
                    txtCantidadAGenerar.Enabled = false;
                    //Se crea el generador pertinente y se genera la lista de N randoms
                    generadorSeleccionado = new GeneradorCongruencialMultiplicativo(semilla, multiplicador, modulo);
                    generarSerieRandoms(cantidad);
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
            //Verifica que los datos necesarios para el congruencial mixto hayan sido ingresadas, en caso de que no tira un mensaje de cual es el error
            if (txtCantidadAGenerar.Text == "")
            {
                txtCantidadAGenerar.Focus();
                throw new ApplicationException("Debe introducir la cantidad de randoms a generar");
            }
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
        private bool validarCongMult()
        {
            //Verifica que los datos necesarios para el congruencial multiplicativo hayan sido ingresadas, en caso de que no tira un mensaje de cual es el error
            if (txtCantidadAGenerar.Text == "")
            {
                txtCantidadAGenerar.Focus();
                throw new ApplicationException("Debe introducir la cantidad de randoms a generar");
            }
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
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //reinicia la pantalla activando y desactivando las opciones pertinentes
            dgvListaNumeros.Rows.Clear();
            btnGenerarSiguiente.Enabled = false;
            btnCongMixto.Enabled = true;
            btnCongMixto.BackColor = Color.Transparent;
            btnCongMult.Enabled = true;
            btnCongMult.BackColor = Color.Transparent;
            groupBox1.Enabled = true;
            txtCantidadAGenerar.Enabled = true;
            txtCantidadAGenerar.Text = "";
            txtSemilla.Text = "";
            txtMultiplicador.Text = "";
            txtModulo.Text = "";
            txtIncremento.Text = "";
            txtCantidadAGenerar.Focus();
            btnLimpiar.Enabled = false;
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

        private void PantallaGeneracionAleatoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Vuelve a la pantalla inicial
            cerrarVentana();
        }
        private void cerrarVentana()
        {
            //Vuelve a la pantalla inicial
            _pantallaInicio.Show();
            this.Dispose();
        }
        private void progressBar(int valor)
        {
            //Realiza la carga de la progress bar para que se pueda visualizar el avance de la generacion de los numeros en caso de demora
            pgbGeneracion.Visible = true;
            pgbGeneracion.Value = valor;
        }
    }
}
