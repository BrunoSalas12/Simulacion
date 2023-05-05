using GeneradoresVariableAleatoria;
using Runge_Kutta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7_Individual.Entidades;

namespace TP7_Individual
{
    public partial class PantallaPrincipal : Form
    {
        private IDistribucion ExponencialLlegadasGripe;
        private string[] parametrosLlegadasGripe;
        private int semillaLlegadasGripe;
        private IDistribucion ExponencialLlegadasCOVID;
        private string[] parametrosLlegadasCOVID;
        private int semillaLlegadasCOVID;
        private IDistribucion UniformeCantidad;
        private string[] parametrosCantidad;
        private int semillaParaCantidad;

        private IRungeKutta RKvencimientoVacGripe;
        private double hache;

        private int diasSimular;
        private int horasSimular;
        private int minutosSimular;
        private double tiempoSimular;

        private int diasMostrar;
        private int horasMostrar;
        private int minutosMostar;
        private double tiempoMostrar;
        private int contadorMostrar;

        private VectorSimulacion vector1;
        private VectorSimulacion vector2;
        private int unoOdos;
        private double tiempoSimulacion;

        private int cantidadEnfermeros;

        private ConvertirTiempos convertidor;
        public int colComFinVac;
        public int colComVencVac;
        public int colComEstadosEnf;
        public int colComColas;
        public int colComEstadisticas;
        public int colComObjetosTransitorios;
        public List<int> numerosDeColOcups;
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            txtCantidadEnfermero.Text = "1";
            txtCantidadEnfermero.Enabled = false;
            cbEnfermero.Checked = true;
            txtMediaLlegadaGripe.Text = "5";
            txtMediaLlegadaGripe.Enabled = false;
            cbLlegadaGripe.Checked = true;
            txtMediaLlegadaCOVID.Text = "3,75";
            txtMediaLlegadaCOVID.Enabled = false;
            cbLlegadaCOVID.Checked = true;
            txtH.Text = "0,005";
            txtH.Enabled = false;
            cbH.Checked = true;
            contadorMostrar = 0;
            convertidor = new ConvertirTiempos();
            numerosDeColOcups = new List<int>();
            parametrosLlegadasGripe = new string[1];
            parametrosLlegadasCOVID = new string[1];
            parametrosCantidad = new string[2];
            parametrosCantidad[0] = "1";
            parametrosCantidad[1] = "5";
            progressBar1.Visible = false;
        }
        #region Comportamiento de la pantalla
        private void cbLlegadaGripe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLlegadaGripe.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtMediaLlegadaGripe.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtMediaLlegadaGripe.Enabled = false;
                    }
                }
                else
                {
                    txtMediaLlegadaGripe.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtMediaLlegadaGripe.Focus();
                cbLlegadaGripe.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtMediaLlegadaGripe.Focus();
                cbLlegadaGripe.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbLlegadaCOVID_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLlegadaCOVID.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtMediaLlegadaCOVID.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtMediaLlegadaCOVID.Enabled = false;
                    }
                }
                else
                {
                    txtMediaLlegadaCOVID.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtMediaLlegadaCOVID.Focus();
                cbLlegadaCOVID.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtMediaLlegadaCOVID.Focus();
                cbLlegadaCOVID.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbEnfermero_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEnfermero.Checked)
                {
                    double verif = Convert.ToDouble(txtCantidadEnfermero.Text);
                    if (!(verif <= 0))
                    {
                        txtCantidadEnfermero.Enabled = false;
                    }
                    else
                    {
                        throw new ApplicationException("El paso no puede ser negativo o 0");
                    }
                }
                else
                {
                    txtCantidadEnfermero.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtCantidadEnfermero.Focus();
                cbEnfermero.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtCantidadEnfermero.Focus();
                cbEnfermero.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbH_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbH.Checked)
                {
                    double verif = Convert.ToDouble(txtH.Text);
                    if (!(verif <= 0) && !(verif > 0.09))
                    {
                        txtH.Enabled = false;
                    }
                    else
                    {
                        throw new ApplicationException("El paso no puede ser negativo o 0\nNi tampoco superar el 0.09");
                    }
                }
                else
                {
                    txtH.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtH.Focus();
                cbH.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtH.Focus();
                cbH.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool validarParamsDist(string[] p, IDistribucion dist)
        {
            return dist.validarParametros(p);
        }
        private void cbSemilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSemilla.Checked)
            {
                var rand = new Random();
                semillaLlegadasGripe = DateTime.Now.Millisecond + rand.Next(0, 159752);
                semillaLlegadasCOVID = DateTime.Now.Minute + rand.Next(0, 159752);
                semillaParaCantidad = DateTime.Now.Hour + rand.Next(0, 159752);
            }
        }


        #endregion

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.Rows.Clear();
                dgvResultados.Columns.Clear();
                //Verificacion de parametros
                if (verificarParams())
                {
                    gbParametros.Enabled = false;
                    cantidadEnfermeros = Convert.ToInt32(txtCantidadEnfermero.Text);
                    parametrosLlegadasGripe[0] = txtMediaLlegadaGripe.Text;
                    parametrosLlegadasCOVID[0] = txtMediaLlegadaCOVID.Text;
                    hache = Convert.ToDouble(txtH.Text);
                    numerosDeColOcups.Clear();

                    unoOdos = 1;
                    tiempoSimular = convertidor.deTiempoADouble(diasSimular, horasSimular, minutosSimular, 0);
                    tiempoMostrar = convertidor.deTiempoADouble(diasMostrar, horasMostrar, minutosMostar, 0);
                    TextWriter textoCaja = new StreamWriter("RK-VencimientoCajas.txt");
                    string renglon = "Simulacion iniciada en: " + DateTime.Now.ToString();
                    textoCaja.Write(renglon);
                    textoCaja.Close();

                    //Creacion de Objetos
                    vector1 = new VectorSimulacion();
                    vector2 = new VectorSimulacion();
                    crearEnfermeros();

                    vector1.llegadaClientesGripe = new EventoLlegadaGripe();
                    vector1.llegadaClientesCOVID = new EventoLlegadaCOVID();
                    vector2.llegadaClientesGripe = new EventoLlegadaGripe();
                    vector2.llegadaClientesCOVID = new EventoLlegadaCOVID();
                    vector1.vencimientoVac = new EventoVencimientoVac() { nombreEvento = "Vencimiento Vac" };
                    vector2.vencimientoVac = new EventoVencimientoVac() { nombreEvento = "Vencimiento Vac" };
                    if (cbSemilla.Checked)
                    {
                        ExponencialLlegadasGripe = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaLlegadasGripe), lambdaOMedia = 2 };
                        ExponencialLlegadasCOVID = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaLlegadasCOVID), lambdaOMedia = 2 };
                        UniformeCantidad = new DistribucionUniforme() { generador = new GeneradorDelLenguaje(semillaParaCantidad) };
                    }
                    else
                    {
                        ExponencialLlegadasGripe = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(DateTime.Now.Millisecond), lambdaOMedia = 2 };
                        ExponencialLlegadasCOVID = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(DateTime.Now.Minute), lambdaOMedia = 2 };
                        UniformeCantidad = new DistribucionUniforme() { generador = new GeneradorDelLenguaje(DateTime.Now.Second) };
                    }

                    RKvencimientoVacGripe = new RKVencimientoCaja();

                    cargarGrillaConObjetosPermamentes();
                    contadorMostrar = 0;
                    //Comenzar Simulacion
                    estadoInicial();
                    tiempoSimulacion = vector1.reloj;
                    simular();
                    gbParametros.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbParametros.Enabled = true;
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbParametros.Enabled = true;
                progressBar1.Visible = false;
            }
        }

        private bool verificarParams()
        {
            if (txtDiasSimular.Text == "")
                diasSimular = 0;
            else
                diasSimular = Convert.ToInt32(txtDiasSimular.Text);
            if (txtHorasSimular.Text == "")
                horasSimular = 0;
            else
                horasSimular = Convert.ToInt32(txtHorasSimular.Text);
            if (txtMinutosSimular.Text == "")
                minutosSimular = 0;
            else
                minutosSimular = Convert.ToInt32(txtMinutosSimular.Text);
            if ((diasSimular == 0 && horasSimular == 0 && minutosSimular == 0) || diasSimular < 0 || horasSimular < 0 || minutosSimular < 0)
                throw new ApplicationException("Debe ingresar un tiempo a simular valido");
            if (txtDiasMostrar.Text == "")
                diasMostrar = 0;
            else
                diasMostrar = Convert.ToInt32(txtDiasMostrar.Text);
            if (txtHorasMostrar.Text == "")
                horasMostrar = 0;
            else
                horasMostrar = Convert.ToInt32(txtHorasMostrar.Text);
            if (txtMinutosMostrar.Text == "")
                minutosMostar = 0;
            else
                minutosMostar = Convert.ToInt32(txtMinutosMostrar.Text);
            if (diasMostrar < 0 || horasMostrar < 0 || minutosMostar < 0)
                throw new ApplicationException("Debe ingresar un tiempo a mostrar valido");
            if (!cbEnfermero.Checked)
                throw new ApplicationException("Debe confirmar la cantidad de enfermeros");
            if (!cbLlegadaGripe.Checked)
                throw new ApplicationException("Debe confirmar el parametro de Llegadas de Gripe");
            if (!cbLlegadaCOVID.Checked)
                throw new ApplicationException("Debe confirmar el parametro de Llegadas COVID");
            if (!cbH.Checked)
                throw new ApplicationException("Debe confirmar el Paso de Integracion");
            return true;
        }

        private void crearEnfermeros()
        {
            for (int i = 0; i < cantidadEnfermeros; i++)
            {
                Enfermero emp = new Enfermero();
                emp.nombreEnfermero = "Enfermero " + (i + 1).ToString();
                EventoFinVacunacion ev = new EventoFinVacunacion();
                ev.nombreEvento = "Fin Vacunacion " + (i + 1).ToString();
                ev.empeladoEvento = emp;
                vector1.enfemeros.Add(emp);
                vector1.finVacunacion.Add(ev);
                vector2.enfemeros.Add(emp);
                vector2.finVacunacion.Add(ev);
            }
        }

        private void estadoInicial()
        {
            vector1.evento = "Estado Inicial";
            vector1.reloj = 0;
            vector1.llegadaClientesGripe.generarTiempoLlegada(ExponencialLlegadasGripe, parametrosLlegadasGripe, vector1);
            vector1.llegadaClientesCOVID.generarTiempoLlegada(ExponencialLlegadasCOVID, parametrosLlegadasCOVID, vector1);
            foreach (var enf in vector1.enfemeros)
            {
                enf.estadoEnfermero = "Libre";
            }
            vector1.colaGripe = 0;
            vector1.colaCOVID = 0;

            vector1.dosisVencidas = 0;
            vector1.cantidadVacunadosGripe = 0;
            vector1.cantidadNoVacunadosCOVID = 0;
            vector1.porcentajeClientesGripe = 0;
            vector1.porcentajeClientesCOVID = 0;
            vector1.cantidadGripeLlegaronSistema = 0;
            vector1.cantidadCOVIDLlegaronSistema = 0;
            vector1.tiempoPromedioEsperaGripe = 0;
            vector1.acumuladorTiempoEsperaGripe = 0;
            vector1.cantidadEsperaronGripe = 0;
            vector1.tiempoPromedioEsperaCOVID = 0;
            vector1.acumuladorTiempoEsperaCOVID = 0;
            vector1.cantidadEsperaronCOVID = 0;

            unoOdos = 2;
            if (vector1.reloj >= tiempoMostrar && contadorMostrar <= 400)
            {
                cargarFilaGrilla(vector1);
                contadorMostrar++;
            }
        }

        private void simular()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            while (tiempoSimulacion < tiempoSimular)
            {
                progressBar1.Value = Convert.ToInt32((tiempoSimulacion * 100) / tiempoSimular);
                if (unoOdos == 1)
                {
                    object[] proximoEvento = calcularProximoEvento(vector2);
                    if ((double)proximoEvento[0] >= tiempoSimular)
                    {
                        tiempoSimulacion = (double)proximoEvento[0];
                        break;
                    }
                    vector1.reloj = (double)proximoEvento[0];
                    vector1.evento = (string)proximoEvento[1];

                    ejecutarEvento(proximoEvento, vector2, vector1);
                    tiempoSimulacion = vector1.reloj;

                    vector1.porcentajeClientesCOVID = Math.Round((vector1.cantidadCOVIDLlegaronSistema / (vector1.cantidadCOVIDLlegaronSistema + vector1.cantidadGripeLlegaronSistema)) * 100, 2);
                    vector1.porcentajeClientesGripe = Math.Round((vector1.cantidadGripeLlegaronSistema / (vector1.cantidadCOVIDLlegaronSistema + vector1.cantidadGripeLlegaronSistema)) * 100, 2);
                    if (vector1.cantidadEsperaronCOVID == 0)
                    {
                        vector1.tiempoPromedioEsperaCOVID = 0;
                    }
                    else
                    {
                        vector1.tiempoPromedioEsperaCOVID = Math.Round((vector1.acumuladorTiempoEsperaCOVID / vector1.cantidadEsperaronCOVID), 2);
                    }
                    if (vector1.cantidadEsperaronGripe == 0)
                    {
                        vector1.tiempoPromedioEsperaGripe = 0;
                    }
                    else
                    {
                        vector1.tiempoPromedioEsperaGripe = Math.Round((vector1.acumuladorTiempoEsperaGripe / vector1.cantidadEsperaronGripe), 2);
                    }

                    vector2.clientesGrie = vector1.clientesGrie;
                    vector2.clientesCOVID = vector1.clientesCOVID;
                    vector2.cajasVacunasGripe = vector1.cajasVacunasGripe;

                    unoOdos = 2;
                }
                else if (unoOdos == 2)
                {
                    object[] proximoEvento = calcularProximoEvento(vector1);
                    if ((double)proximoEvento[0] >= tiempoSimular)
                    {
                        tiempoSimulacion = (double)proximoEvento[0];
                        break;
                    }
                    vector2.reloj = (double)proximoEvento[0];
                    vector2.evento = (string)proximoEvento[1];

                    ejecutarEvento(proximoEvento, vector1, vector2);
                    tiempoSimulacion = vector2.reloj;

                    vector2.porcentajeClientesCOVID = Math.Round((vector2.cantidadCOVIDLlegaronSistema / (vector2.cantidadCOVIDLlegaronSistema + vector2.cantidadGripeLlegaronSistema) * 100), 2);
                    vector2.porcentajeClientesGripe = Math.Round((vector2.cantidadGripeLlegaronSistema / (vector2.cantidadCOVIDLlegaronSistema + vector2.cantidadGripeLlegaronSistema) * 100), 2);
                    if (vector2.cantidadEsperaronCOVID == 0)
                    {
                        vector2.tiempoPromedioEsperaCOVID = 0;
                    }
                    else
                    {
                        vector2.tiempoPromedioEsperaCOVID = Math.Round((vector2.acumuladorTiempoEsperaCOVID / vector2.cantidadEsperaronCOVID), 2);
                    }
                    if (vector2.cantidadEsperaronGripe == 0)
                    {
                        vector2.tiempoPromedioEsperaGripe = 0;
                    }
                    else
                    {
                        vector2.tiempoPromedioEsperaGripe = Math.Round((vector2.acumuladorTiempoEsperaGripe / vector2.cantidadEsperaronGripe), 2);
                    }

                    vector1.clientesGrie = vector2.clientesGrie;
                    vector1.clientesCOVID = vector2.clientesCOVID;
                    vector1.cajasVacunasGripe = vector2.cajasVacunasGripe;

                    unoOdos = 1;
                }

                if (tiempoSimulacion >= tiempoMostrar && contadorMostrar < 400)
                {
                    if (unoOdos == 1)
                    {
                        cargarFilaGrilla(vector2);
                    }
                    else
                    {
                        cargarFilaGrilla(vector1);
                    }
                    contadorMostrar++;
                }
                if (unoOdos == 1)
                {
                    List<int> indices = new List<int>();
                    int index = 0;
                    foreach (var caja in vector1.cajasVacunasGripe)
                    {
                        if (caja.dosisCaja <= 0)
                        {
                            numerosDeColOcups.Remove(caja.columnaSalida);
                            indices.Add(index);
                        }
                        index++;
                    }
                    indices.Reverse();
                    foreach (var indi in indices)
                    {
                        if (vector1.cajasVacunasGripe.Count != 0)
                        {
                            vector1.cajasVacunasGripe.RemoveAt(indi);
                        }
                    }
                    if (vector1.cajasVacunasGripe.Count == 0)
                    {
                        vector2.vencimientoVac.tiempoVencimiento = 0;
                        vector2.vencimientoVac.tiempoEvento = 0;
                    }
                }
                else
                {
                    List<int> indices = new List<int>();
                    int index = 0;
                    foreach (var caja in vector2.cajasVacunasGripe)
                    {
                        if (caja.dosisCaja <= 0)
                        {
                            numerosDeColOcups.Remove(caja.columnaSalida);
                            indices.Add(index);
                        }
                        index++;
                    }
                    indices.Reverse();
                    foreach (var indi in indices)
                    {
                        if (vector2.cajasVacunasGripe.Count != 0)
                        {
                            vector2.cajasVacunasGripe.RemoveAt(indi);
                        }
                    }
                    if (vector2.cajasVacunasGripe.Count == 0)
                    {
                        vector1.vencimientoVac.tiempoVencimiento = 0;
                        vector1.vencimientoVac.tiempoEvento = 0;
                    }
                }
                
            }
            progressBar1.Visible = false;
            //evento es hora de terminar la simulacion
            if (unoOdos == 1)
            {
                vector2.evento = "Es Hora de terminar la Simulacion";
                vector2.reloj = tiempoSimular;
                cargarFilaGrilla(vector2);
            }
            else
            {
                vector1.evento = "Es Hora de terminar la Simulacion";
                vector1.reloj = tiempoSimular;
                cargarFilaGrilla(vector1);
            }
        }
        private object[] calcularProximoEvento(VectorSimulacion vectorAnterior)
        {
            object[] proxEvent = new object[2];
            if (vectorAnterior.llegadaClientesGripe.tiempoEvento != 0)
            {
                proxEvent[0] = vectorAnterior.llegadaClientesGripe.tiempoEvento;
                proxEvent[1] = vectorAnterior.llegadaClientesGripe.nombreEvento;
            }
            if (vectorAnterior.llegadaClientesCOVID.tiempoEvento != 0)
            {
                if (vectorAnterior.llegadaClientesCOVID.tiempoEvento < (double)proxEvent[0])
                {
                    proxEvent[0] = vectorAnterior.llegadaClientesCOVID.tiempoEvento;
                    proxEvent[1] = vectorAnterior.llegadaClientesCOVID.nombreEvento;
                }
            }
            foreach (var finVac in vectorAnterior.finVacunacion)
            {
                if (finVac.tiempoEvento != 0)
                {
                    if (finVac.tiempoEvento < (double)proxEvent[0])
                    {
                        proxEvent[0] = finVac.tiempoEvento;
                        proxEvent[1] = finVac.nombreEvento;
                    }
                }
            }
            if (vectorAnterior.vencimientoVac.tiempoEvento != 0)
            {
                if (vectorAnterior.vencimientoVac.tiempoEvento < (double)proxEvent[0])
                {
                    proxEvent[0] = vectorAnterior.vencimientoVac.tiempoEvento;
                    proxEvent[1] = vectorAnterior.vencimientoVac.nombreEvento;
                }
            }
            return proxEvent;
        }
        private void ejecutarEvento(object[] proxEvent, VectorSimulacion vectorAnterior, VectorSimulacion vectorActual)
        {
            if ((string)proxEvent[1] == "Llegada Gripe")
            {
                vectorActual.llegadaClientesGripe.ejecutarEvento(ExponencialLlegadasGripe, parametrosLlegadasGripe,UniformeCantidad, parametrosCantidad, vectorActual, vectorAnterior, RKvencimientoVacGripe, hache);
                return;
            }
            if ((string)proxEvent[1] == "Llegada COVID")
            {
                vectorActual.llegadaClientesCOVID.ejecutarEvento(ExponencialLlegadasCOVID, parametrosLlegadasCOVID, UniformeCantidad, parametrosCantidad, vectorActual, vectorAnterior);
                return;
            }
            foreach (var finVac in vectorActual.finVacunacion)
            {
                if (finVac.nombreEvento == (string)proxEvent[1])
                {
                    finVac.ejecutarEvento(vectorActual, vectorAnterior,RKvencimientoVacGripe, hache, numerosDeColOcups);
                    return;
                }
            }
            if ((string)proxEvent[1] == "Vencimiento Vac")
            {
                vectorActual.vencimientoVac.ejecutarEvento(vectorActual, vectorAnterior, numerosDeColOcups);
                return;
            }
        }

        #region Manejo de Data Grid
        private void cargarGrillaConObjetosPermamentes()
        {
            //En este metodo se cargan las columnas de la grilla de la siguiente forma:
            //1º Se utiliza el dgv.Columns.Add() pues agrega una columna al final, por ende debe hacerse en el orden que se quieren que aparezcan
            //2º Se utiliza un contador de columnas para ir guardando los valores del indice de columnas, para poder manejar numeros de columnas variables
            //3º Se comienzan con las columnas fijas iniciales, en caso de tener que se variables empezaria con un loop, y se realiza un conteo de su cantidad con 'contCols'
            //4º Se guardan con el 'contCols' en otra variable el indice donde empezarian las columnas variables, y se maneja con un loop la creacion de estas
            //5º Se repite con alternancia la creacion de columnas que siempre van a ser iguales y las variables en cantidad.

            var contCols = 0; //Se utiliza para contar las columnas que se van creando para representar su indice para guardarlo en las variables globales 'colCom...'

            //Columnas iniciales fijas
            dgvResultados.Columns.Add("Evento", "Evento");
            dgvResultados.Columns.Add("Reloj", "Reloj (DD-hh:mm:ss)");
            dgvResultados.Columns.Add("RNDLlegadaGripe", "RND Llegada Gripe");
            dgvResultados.Columns.Add("TiempoLlegadaGripe", "Tiempo Llegada Gripe");
            dgvResultados.Columns.Add("LlegadaClientesGripe", "Llegada Cliente Gripe");
            dgvResultados.Columns.Add("RNDLlegadaCOVID", "RND Llegada COVID");
            dgvResultados.Columns.Add("TiempoLlegadaCOVID", "Tiempo Llegada COVID");
            dgvResultados.Columns.Add("LlegadaClientesCOVID", "Llegada Cliente COVID");
            dgvResultados.Columns.Add("RNDCantidad", "RND Cantidad");
            dgvResultados.Columns.Add("CantidadLleg", "Cantidad Clientes Llegaron");
            dgvResultados.Columns.Add("TiempoVac", "Tiempo Vacunacion");
            contCols = 11;
            colComFinVac = contCols;
            foreach (var finVac in vector1.finVacunacion)  //Se cargan los fin Vacunacion
            {
                dgvResultados.Columns.Add(finVac.nombreEvento.Trim(), finVac.nombreEvento);
                contCols++;
            }
            colComVencVac = contCols;
            //Se carga el vencimiento de las vacunas
            dgvResultados.Columns.Add("TiempoVenVacs", "Tiempo Vencimiento");
            dgvResultados.Columns.Add(vector1.vencimientoVac.nombreEvento.Trim(), vector1.vencimientoVac.nombreEvento);
            contCols += 2;
            colComEstadosEnf = contCols;
            foreach (var enf in vector1.enfemeros) //Se cargan los enfermeros
            {
                dgvResultados.Columns.Add("estado" + enf.nombreEnfermero.Trim(), "Estado " + enf.nombreEnfermero);
                contCols++;
            }
            colComColas = contCols;
            //Se cargan las colas
            dgvResultados.Columns.Add("ColaGripe", "Cola Gripe"); 
            dgvResultados.Columns.Add("ColaCOVID", "Cola COVID"); 
            contCols += 2;

            //Se cargan las columnas de las estadisticas
            colComEstadisticas = contCols;
            dgvResultados.Columns.Add("dosisVencidas", "Cantidad de Dosis Vencidas");
            dgvResultados.Columns.Add("vacunadosGripe", "Cantidad Vacunados Gripe");
            dgvResultados.Columns.Add("vacunadosCOVID", "Cantidad que Quedaron para COVID");
            dgvResultados.Columns.Add("porcentajeGripe", "Porcentaje clientes que vinieron por Gripe");
            dgvResultados.Columns.Add("porcentajeCOVID", "Porcentaje clientes que vinieron por COVID");
            dgvResultados.Columns.Add("contadorGripe", "Cantidad de clientes Gripe");
            dgvResultados.Columns.Add("contadorCOVID", "Cantidad de clientes COVID");
            dgvResultados.Columns.Add("promedioEsperaGripe", "Tiempo promedio de espera por Gripe");
            dgvResultados.Columns.Add("acumuladorEsperaGripe", "Acumulador tiempos de espera Gripe");
            dgvResultados.Columns.Add("cantidadAtendGripe", "Cantidad de atendidos por Gripe");
            dgvResultados.Columns.Add("promedioEsperaCOVID", "Tiempo promedio de espera por COVID");
            dgvResultados.Columns.Add("acumuladorEsperaCOVID", "Acumulador tiempos de espera COVID");
            dgvResultados.Columns.Add("cantidadAtendCOVID", "Cantidad de atendidos por COVID");

            contCols += 13;
            colComObjetosTransitorios = contCols;
            //Se crean las columnas para el primer objeto transitorio
            dgvResultados.Columns.Add("NumObjeto", "Numero de Objeto Nº");
            dgvResultados.Columns.Add("EstadoObjeto", "Estado de Objeto Nº");
            dgvResultados.Columns.Add("AtributoUno", "Atributo 1 de Objeto Nº");
            dgvResultados.Columns.Add("AtributoDos", "Atributo 2 de Objeto Nº");
            //v0.00000000000000000000000003 por Bruno Salas
        }

        private void cargarFilaGrilla(VectorSimulacion vectorActual)
        {
            //La logica de funcionamiento de todo esto es:
            //1º se crea la fila vacia,
            //2º luego se utiliza el contador de filas que se estan mostrando pues ese sera el indice de esta nueva fila creada
            //3º las columnas dentro de esta fila se acceden por la celda, y su indice, como las primeras 6 columnas son siempre constantes se utilizan numeros fijos
            //4º con la ayuda de la variable i y de las variables colCom (que representan el numero de columna donde comienzan ese tipo de columnas) se van añadiendo los valores en las columnas variables.
            // Luego se hace el manejo de los clientes.

            var i = 0; //Se utiliza para las i cantidades de los objetos variables

            dgvResultados.Rows.Add();
            dgvResultados.Rows[contadorMostrar].Cells[0].Value = vectorActual.evento;
            dgvResultados.Rows[contadorMostrar].Cells[1].Value = convertidor.deDoubleATiempo(vectorActual.reloj);
            if (vectorActual.llegadaClientesGripe.RNDLlegada != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[2].Value = vectorActual.llegadaClientesGripe.RNDLlegada.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[2].Value = "";
            if (vectorActual.llegadaClientesGripe.tiempoLlegada != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[3].Value = convertidor.deDoubleATiempo(vectorActual.llegadaClientesGripe.tiempoLlegada);
            else
                dgvResultados.Rows[contadorMostrar].Cells[3].Value = "";
            dgvResultados.Rows[contadorMostrar].Cells[4].Value = convertidor.deDoubleATiempo(vectorActual.llegadaClientesGripe.tiempoEvento);
            if (vectorActual.llegadaClientesCOVID.RNDLlegada != 0)
                dgvResultados.Rows[contadorMostrar].Cells[5].Value = vectorActual.llegadaClientesCOVID.RNDLlegada.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[5].Value = "";
            if (vectorActual.llegadaClientesCOVID.tiempoLlegada != 0)
                dgvResultados.Rows[contadorMostrar].Cells[6].Value = convertidor.deDoubleATiempo(vectorActual.llegadaClientesCOVID.tiempoLlegada);
            else
                dgvResultados.Rows[contadorMostrar].Cells[6].Value = "";
            dgvResultados.Rows[contadorMostrar].Cells[7].Value = convertidor.deDoubleATiempo(vectorActual.llegadaClientesCOVID.tiempoEvento);
            if (vectorActual.rndCantidad != 0)
                dgvResultados.Rows[contadorMostrar].Cells[8].Value = vectorActual.rndCantidad.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[8].Value = "";
            if (vectorActual.CantidadClientes != 0)
                dgvResultados.Rows[contadorMostrar].Cells[9].Value = vectorActual.CantidadClientes.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[9].Value = "";
            if (vectorActual.tiempoVacunacion != 0)
                dgvResultados.Rows[contadorMostrar].Cells[10].Value = convertidor.deDoubleATiempo(vectorActual.tiempoVacunacion);
            else
                dgvResultados.Rows[contadorMostrar].Cells[10].Value = "";
            i = 0;
            foreach (var finVac in vectorActual.finVacunacion) //Con este loop se cargan los i fin vacunacion
            {
                if (finVac.tiempoEvento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinVac + i].Value = convertidor.deDoubleATiempo(finVac.tiempoEvento);
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinVac + i].Value = "";
                i++;
            }
            if (vectorActual.vencimientoVac.tiempoVencimiento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComVencVac].Value = convertidor.deDoubleATiempo(vectorActual.vencimientoVac.tiempoVencimiento);
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComVencVac].Value = "";
            if (vectorActual.vencimientoVac.tiempoEvento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComVencVac + 1].Value = convertidor.deDoubleATiempo(vectorActual.vencimientoVac.tiempoEvento);
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComVencVac + 1].Value = "";
            i = 0;
            foreach (var enf in vectorActual.enfemeros) //Con este loop se cargan los i enfermeros
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComEstadosEnf + i].Value = enf.estadoEnfermero;
                i++;
            }
            dgvResultados.Rows[contadorMostrar].Cells[colComColas].Value = vectorActual.colaGripe.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComColas + 1].Value = vectorActual.colaCOVID.ToString();

            //En esta seccion se cargan las estadisticas fijas, aquellas que no dependen de cuantos servidores haya de su tipo
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas].Value = vectorActual.dosisVencidas.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 1].Value = vectorActual.cantidadVacunadosGripe.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 2].Value = vectorActual.cantidadNoVacunadosCOVID.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 3].Value = vectorActual.porcentajeClientesGripe.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 4].Value = vectorActual.porcentajeClientesCOVID.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 5].Value = vectorActual.cantidadGripeLlegaronSistema.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 6].Value = vectorActual.cantidadCOVIDLlegaronSistema.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 7].Value = convertidor.deDoubleATiempo(vectorActual.tiempoPromedioEsperaGripe);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 8].Value = convertidor.deDoubleATiempo(vectorActual.acumuladorTiempoEsperaGripe);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 9].Value = vectorActual.cantidadEsperaronGripe.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 10].Value = convertidor.deDoubleATiempo(vectorActual.tiempoPromedioEsperaCOVID);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 11].Value = convertidor.deDoubleATiempo(vectorActual.acumuladorTiempoEsperaCOVID);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 12].Value = vectorActual.cantidadEsperaronCOVID.ToString();

            //En esta seccion se maneja la carga de los clientes, ya sea metiendolos siempre es su mismo grupo de columnas o creando nuevas de ser necesarias para ese cliente
            foreach (var caja in vectorActual.cajasVacunasGripe) //Se realiza el loop para recorrer todos los clientes
            {
                if (caja.columnaSalida == 0) //Se pregunta si el cliente ya tiene asignada una columna de salida
                { //En caso de que no (=0) pues se pasa a asignarla
                    asignarColumna(caja);
                }
                else
                { //En caso de que si, se utiliza ese atributo de los clientes para escribir sus valores en las mismas columnas donde ya estaba, aplicando la misma logica que antes
                    //usando el contadorMostrar para entrar en la fila actual y en la celda con el indice correspondiente a su columna
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida].Value = caja.numeroCaja.ToString() + caja.nombreCaja;
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 1].Value = caja.estadoCaja;
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 2].Value = caja.dosisCaja.ToString();
                }
            }
            foreach (var clieGripe in vectorActual.clientesGrie) //Se realiza el loop para recorrer todos los clientes
            {
                if (clieGripe.columnaSalida == 0) //Se pregunta si el cliente ya tiene asignada una columna de salida
                { //En caso de que no (=0) pues se pasa a asignarla
                    asignarColumna(clieGripe);
                }
                else
                { //En caso de que si, se utiliza ese atributo de los clientes para escribir sus valores en las mismas columnas donde ya estaba, aplicando la misma logica que antes
                    //usando el contadorMostrar para entrar en la fila actual y en la celda con el indice correspondiente a su columna
                    dgvResultados.Rows[contadorMostrar].Cells[clieGripe.columnaSalida].Value = clieGripe.numeroGripe.ToString() + clieGripe.nombreGripe;
                    dgvResultados.Rows[contadorMostrar].Cells[clieGripe.columnaSalida + 1].Value = clieGripe.estadoGripe;
                    dgvResultados.Rows[contadorMostrar].Cells[clieGripe.columnaSalida + 2].Value = clieGripe.posicionColaGripe.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[clieGripe.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clieGripe.tiempoLlegadaColaGripe);
                }
            }
            foreach (var clieCOVID in vectorActual.clientesCOVID) //Se realiza el loop para recorrer todos los clientes
            {
                if (clieCOVID.columnaSalida == 0) //Se pregunta si el cliente ya tiene asignada una columna de salida
                { //En caso de que no (=0) pues se pasa a asignarla
                    asignarColumna(clieCOVID);
                }
                else
                { //En caso de que si, se utiliza ese atributo de los clientes para escribir sus valores en las mismas columnas donde ya estaba, aplicando la misma logica que antes
                    //usando el contadorMostrar para entrar en la fila actual y en la celda con el indice correspondiente a su columna
                    dgvResultados.Rows[contadorMostrar].Cells[clieCOVID.columnaSalida].Value = clieCOVID.numeroCOVID.ToString() + clieCOVID.nombreCOVID;
                    dgvResultados.Rows[contadorMostrar].Cells[clieCOVID.columnaSalida + 1].Value = clieCOVID.estadoCOVID;
                    dgvResultados.Rows[contadorMostrar].Cells[clieCOVID.columnaSalida + 2].Value = clieCOVID.posicionColaCOVID.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[clieCOVID.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clieCOVID.tiempoLlegadaColaCOVID);
                }
            }

            //v0.00000000000000000000000003 por Bruno Salas
        }

        private void asignarColumna(CajaVacunas caja)
        {
            //Para asignarle una columna al cliente:
            //1º Se asigna la columna tentativa como la primera donde comenzarian los clientes, guardado con anterioridad cuando se crearon todas las columnas de objetos permanentes
            //2º Despues se asume que se deberan crear las columnas necesarias para el cliente por estar todas las demas en uso y ocupadas
            //3º Luego se recorren las columnas para ver si hay algun espacio libre, de haberlo se guarda ahi, de no haberlo se crean las columnas necesarias
            var columnaAAsignar = colComObjetosTransitorios;
            var crearColumnas = true;

            while (columnaAAsignar < dgvResultados.Columns.Count) //Con este loop se recorren las columnas donde comienzan cada cliente (numero cliente) hasta el final de las columnas de la data grid view
            {
                if (!numerosDeColOcups.Contains(columnaAAsignar)) //Se pregunta si esa columna no tiene valor   dgvResultados.Rows[contadorMostrar].Cells[columnaAAsignar].Value == null ||
                { //De no tener valor se le asigna al cliente esa(s) columna(s) y se cargan sus datos
                    caja.columnaSalida = columnaAAsignar;
                    numerosDeColOcups.Add(caja.columnaSalida);
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida].Value = caja.numeroCaja.ToString() + caja.nombreCaja;
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 1].Value = caja.estadoCaja;
                    dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 2].Value = caja.dosisCaja.ToString();
                    //Se cambia la bandera para que no se creen las columnas nuevas y se sale del loop pues ya no es necesario seguir buscando
                    crearColumnas = false;
                    break;
                }
                else
                { //En caso de que si hubiese tenido valor se suman 4 al valor tentativo de la columna a asignar para que la proxima comparacion la haga con el proximo hueco de columnas de un cliente
                    columnaAAsignar += 4;
                }
            } //En caso de que no encuentre ninguna columna vacia, cuando el asignar columna cae fuera de la cantidad de columnas existentes de la data grid,
              // como se asumio que se devian crear las columnas pasara el proximo if

            if (crearColumnas) //Dependiendo de la bandera de crear columnas
            { //Añadira las 4 columnas necesarias
                dgvResultados.Columns.Add("NumObjeto" + caja.numeroCaja.ToString().Trim(), "Numero de Objeto Nº");
                dgvResultados.Columns.Add("EstadoObjeto" + caja.numeroCaja.ToString().Trim(), "Estado de Objeto Nº");
                dgvResultados.Columns.Add("AtributoUno" + caja.numeroCaja.ToString().Trim(), "Atributo 1 de Objeto Nº");
                dgvResultados.Columns.Add("AtributoDos" + caja.numeroCaja.ToString().Trim(), "Atributo 2 de Objeto Nº");
                //Y le asignara esa(s) columna(s) al cliente para que luego se sigan utilizando igual, y se cargan sus datos en las columnas recien creadas
                caja.columnaSalida = columnaAAsignar;
                numerosDeColOcups.Add(caja.columnaSalida);
                dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida].Value = caja.numeroCaja.ToString() + caja.nombreCaja;
                dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 1].Value = caja.estadoCaja;
                dgvResultados.Rows[contadorMostrar].Cells[caja.columnaSalida + 2].Value = caja.dosisCaja.ToString();

            } //De no tener que crear simplemente no se realizara lo que esta dentro del if y se pasara al siguiente cliente.


            //v0.00000000000000000000000003 por Bruno Salas
        }
        private void asignarColumna(ClienteGripe clienteGripe)
        {
            //Para asignarle una columna al cliente:
            //1º Se asigna la columna tentativa como la primera donde comenzarian los clientes, guardado con anterioridad cuando se crearon todas las columnas de objetos permanentes
            //2º Despues se asume que se deberan crear las columnas necesarias para el cliente por estar todas las demas en uso y ocupadas
            //3º Luego se recorren las columnas para ver si hay algun espacio libre, de haberlo se guarda ahi, de no haberlo se crean las columnas necesarias
            var columnaAAsignar = colComObjetosTransitorios;
            var crearColumnas = true;

            while (columnaAAsignar < dgvResultados.Columns.Count) //Con este loop se recorren las columnas donde comienzan cada cliente (numero cliente) hasta el final de las columnas de la data grid view
            {
                if (!numerosDeColOcups.Contains(columnaAAsignar)) //Se pregunta si esa columna no tiene valor   dgvResultados.Rows[contadorMostrar].Cells[columnaAAsignar].Value == null ||
                { //De no tener valor se le asigna al cliente esa(s) columna(s) y se cargan sus datos
                    clienteGripe.columnaSalida = columnaAAsignar;
                    numerosDeColOcups.Add(clienteGripe.columnaSalida);
                    dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida].Value = clienteGripe.numeroGripe.ToString() + clienteGripe.nombreGripe;
                    dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 1].Value = clienteGripe.estadoGripe;
                    dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 2].Value = clienteGripe.posicionColaGripe.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clienteGripe.tiempoLlegadaColaGripe);
                    //Se cambia la bandera para que no se creen las columnas nuevas y se sale del loop pues ya no es necesario seguir buscando
                    crearColumnas = false;
                    break;
                }
                else
                { //En caso de que si hubiese tenido valor se suman 5 al valor tentativo de la columna a asignar para que la proxima comparacion la haga con el proximo hueco de columnas de un cliente
                    columnaAAsignar += 4;
                }
            } //En caso de que no encuentre ninguna columna vacia, cuando el asignar columna cae fuera de la cantidad de columnas existentes de la data grid,
              // como se asumio que se devian crear las columnas pasara el proximo if

            if (crearColumnas) //Dependiendo de la bandera de crear columnas
            { //Añadira las 5 columnas necesarias
                dgvResultados.Columns.Add("NumObjeto" + clienteGripe.numeroGripe.ToString().Trim(), "Numero de Objeto Nº");
                dgvResultados.Columns.Add("EstadoObjeto" + clienteGripe.numeroGripe.ToString().Trim(), "Estado de Objeto Nº");
                dgvResultados.Columns.Add("AtributoUno" + clienteGripe.numeroGripe.ToString().Trim(), "Atributo 1 de Objeto Nº");
                dgvResultados.Columns.Add("AtributoDos" + clienteGripe.numeroGripe.ToString().Trim(), "Atributo 2 de Objeto Nº");
                //Y le asignara esa(s) columna(s) al cliente para que luego se sigan utilizando igual, y se cargan sus datos en las columnas recien creadas
                clienteGripe.columnaSalida = columnaAAsignar;
                numerosDeColOcups.Add(clienteGripe.columnaSalida);
                dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida].Value = clienteGripe.numeroGripe.ToString() + clienteGripe.nombreGripe;
                dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 1].Value = clienteGripe.estadoGripe;
                dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 2].Value = clienteGripe.posicionColaGripe.ToString();
                dgvResultados.Rows[contadorMostrar].Cells[clienteGripe.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clienteGripe.tiempoLlegadaColaGripe);

            } //De no tener que crear simplemente no se realizara lo que esta dentro del if y se pasara al siguiente cliente.


            //v0.00000000000000000000000003 por Bruno Salas
        }
        private void asignarColumna(ClienteCOVID clienteCOVID)
        {
            //Para asignarle una columna al cliente:
            //1º Se asigna la columna tentativa como la primera donde comenzarian los clientes, guardado con anterioridad cuando se crearon todas las columnas de objetos permanentes
            //2º Despues se asume que se deberan crear las columnas necesarias para el cliente por estar todas las demas en uso y ocupadas
            //3º Luego se recorren las columnas para ver si hay algun espacio libre, de haberlo se guarda ahi, de no haberlo se crean las columnas necesarias
            var columnaAAsignar = colComObjetosTransitorios;
            var crearColumnas = true;

            while (columnaAAsignar < dgvResultados.Columns.Count) //Con este loop se recorren las columnas donde comienzan cada cliente (numero cliente) hasta el final de las columnas de la data grid view
            {
                if (!numerosDeColOcups.Contains(columnaAAsignar)) //Se pregunta si esa columna no tiene valor  dgvResultados.Rows[contadorMostrar].Cells[columnaAAsignar].Value == null ||
                { //De no tener valor se le asigna al cliente esa(s) columna(s) y se cargan sus datos
                    clienteCOVID.columnaSalida = columnaAAsignar;
                    numerosDeColOcups.Add(clienteCOVID.columnaSalida);
                    dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida].Value = clienteCOVID.numeroCOVID.ToString() + clienteCOVID.nombreCOVID;
                    dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 1].Value = clienteCOVID.estadoCOVID;
                    dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 2].Value = clienteCOVID.posicionColaCOVID.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clienteCOVID.tiempoLlegadaColaCOVID);
                    //Se cambia la bandera para que no se creen las columnas nuevas y se sale del loop pues ya no es necesario seguir buscando
                    crearColumnas = false;
                    break;
                }
                else
                { //En caso de que si hubiese tenido valor se suman 5 al valor tentativo de la columna a asignar para que la proxima comparacion la haga con el proximo hueco de columnas de un cliente
                    columnaAAsignar += 4;
                }
            } //En caso de que no encuentre ninguna columna vacia, cuando el asignar columna cae fuera de la cantidad de columnas existentes de la data grid,
              // como se asumio que se devian crear las columnas pasara el proximo if

            if (crearColumnas) //Dependiendo de la bandera de crear columnas
            { //Añadira las 5 columnas necesarias
                dgvResultados.Columns.Add("NumObjeto" + clienteCOVID.numeroCOVID.ToString().Trim(), "Numero de Objeto Nº");
                dgvResultados.Columns.Add("EstadoObjeto" + clienteCOVID.numeroCOVID.ToString().Trim(), "Estado de Objeto Nº");
                dgvResultados.Columns.Add("AtributoUno" + clienteCOVID.numeroCOVID.ToString().Trim(), "Atributo 1 de Objeto Nº");
                dgvResultados.Columns.Add("AtributoDos" + clienteCOVID.numeroCOVID.ToString().Trim(), "Atributo 2 de Objeto Nº");
                //Y le asignara esa(s) columna(s) al cliente para que luego se sigan utilizando igual, y se cargan sus datos en las columnas recien creadas
                clienteCOVID.columnaSalida = columnaAAsignar;
                numerosDeColOcups.Add(clienteCOVID.columnaSalida);
                dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida].Value = clienteCOVID.numeroCOVID.ToString() + clienteCOVID.nombreCOVID;
                dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 1].Value = clienteCOVID.estadoCOVID;
                dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 2].Value = clienteCOVID.posicionColaCOVID.ToString();
                dgvResultados.Rows[contadorMostrar].Cells[clienteCOVID.columnaSalida + 3].Value = convertidor.deDoubleATiempo(clienteCOVID.tiempoLlegadaColaCOVID);

            } //De no tener que crear simplemente no se realizara lo que esta dentro del if y se pasara al siguiente cliente.


            //v0.00000000000000000000000003 por Bruno Salas
        }

        #endregion
    }
}
