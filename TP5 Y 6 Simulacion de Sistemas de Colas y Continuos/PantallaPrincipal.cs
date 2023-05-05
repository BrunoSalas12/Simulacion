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
using TP5_Simulacion_de_Sistemas_de_Colas.Modelos;

namespace TP5_Simulacion_de_Sistemas_de_Colas
{
    public partial class PantallaPrincipal : Form
    {
        private IDistribucion ExponencialLlegadas;
        private string[] parametrosLlegadas;
        private int semillaLlegadas;
        private IDistribucion ExponencialCaseta;
        private string[] parametrosCaseta;
        private int semillaCaseta;
        private IDistribucion ExponencialRevision;
        private string[] parametrosRevision;
        private int semillaRevision;
        private IDistribucion ExponencialOficina;
        private string[] parametrosOficina;
        private int semillaOficina;

        private IRungeKutta EcDifLlegadaBloqueo;
        private IRungeKutta EcDifBloqueoLlegadas;
        private IRungeKutta EcDifBloqueoOficina;
        private IGenerador generadorParaTipoBloq;
        private IGenerador generadorParaBeta;
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

        private int cantidadCasetas;
        private int cantidadRevision;
        private int cantidadOficinas;

        ConvertirTiempos converetidor;
        public int colComFinCasetas;
        public int colComFinRevisiones;
        public int colComFinOficinas;
        public int colComEstadoBloqueo;
        public int colComEstadosCaseta;
        public int colComEstadosRevision;
        public int colComEstadosOficina;
        public int colComEstadisticas;
        public int colComEstadisticas2;
        public int colComPorcentajesDeOcupacionCasetas;
        public int colComPorcentajesDeOcupacionOficinas;
        public int colComObjetosTransitorios;
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            txtCantidadCaseta.Text = "1";
            txtCantidadCaseta.Enabled = false;
            cbCaseta.Checked = true;
            txtCantidadOficina.Text = "2";
            txtCantidadOficina.Enabled = false;
            cbOficina.Checked = true;
            txtLambdaPoissonLlegadas.Text = "1,05";
            txtLambdaPoissonLlegadas.Enabled = false;
            cbPoissonLlegadas.Checked = true;
            txtMediaExponencialCaseta.Text = "1";
            txtMediaExponencialCaseta.Enabled = false;
            cbExponencialCaseta.Checked = true;
            txtLambdaExponencialRevision.Text = "1,33";
            txtLambdaExponencialRevision.Enabled = false;
            cbExponencialRevision.Checked = true;
            txtMediaExponencialOficina.Text = "2";
            txtMediaExponencialOficina.Enabled = false;
            cbExponencialOficina.Checked = true;
            txtH.Text = "0,1";
            txtH.Enabled = false;
            cbH.Checked = true;
            btnGuardar.Enabled = false;
            cantidadRevision = 2;
            contadorMostrar = 0;
            converetidor = new ConvertirTiempos();
            parametrosLlegadas = new string[1];
            parametrosCaseta = new string[1];
            parametrosRevision = new string[1];
            parametrosOficina = new string[1];
            progressBar1.Visible = false;
        }

        #region Comportamiento de la pantalla

        private void cbCaseta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCaseta.Checked && validarCantidad(txtCantidadCaseta.Text))
                {
                    txtCantidadCaseta.Enabled = false;
                }
                else
                {
                    txtCantidadCaseta.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtCantidadCaseta.Focus();
                cbCaseta.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtCantidadCaseta.Focus();
                cbCaseta.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbOficina_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbOficina.Checked && validarCantidad(txtCantidadOficina.Text))
                {
                    txtCantidadOficina.Enabled = false;
                }
                else
                {
                    txtCantidadOficina.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtCantidadOficina.Focus();
                cbOficina.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtCantidadOficina.Focus();
                cbOficina.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool validarCantidad(string cant)
        {
            if (cant == "")
                throw new ApplicationException("Debe ingresar una Cantidad");
            int cantidad = Convert.ToInt32(cant);
            if (cantidad <= 0)
                throw new ApplicationException("La Cantidad no puede ser Negativa o Cero");
            return true;
        }

        private void cbPoissonLlegadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPoissonLlegadas.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtLambdaPoissonLlegadas.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtLambdaPoissonLlegadas.Enabled = false;
                    }
                }
                else
                {
                    txtLambdaPoissonLlegadas.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtLambdaPoissonLlegadas.Focus();
                cbPoissonLlegadas.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtLambdaPoissonLlegadas.Focus();
                cbPoissonLlegadas.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbExponencialCaseta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbExponencialCaseta.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtMediaExponencialCaseta.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtMediaExponencialCaseta.Enabled = false;
                    }
                }
                else
                {
                    txtMediaExponencialCaseta.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtMediaExponencialCaseta.Focus();
                cbExponencialCaseta.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtMediaExponencialCaseta.Focus();
                cbExponencialCaseta.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbExponencialRevision_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbExponencialRevision.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtLambdaExponencialRevision.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtLambdaExponencialRevision.Enabled = false;
                    }
                }
                else
                {
                    txtLambdaExponencialRevision.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtLambdaExponencialRevision.Focus();
                cbExponencialRevision.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtLambdaExponencialRevision.Focus();
                cbExponencialRevision.Checked = false;
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbExponencialOficina_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbExponencialOficina.Checked)
                {
                    string[] param = new string[1];
                    param[0] = txtMediaExponencialOficina.Text;
                    IDistribucion distValidadoraxD = new DistribucionExponencial() { lambdaOMedia = 2 };
                    if (validarParamsDist(param, distValidadoraxD))
                    {
                        txtMediaExponencialOficina.Enabled = false;
                    }
                }
                else
                {
                    txtMediaExponencialOficina.Enabled = true;
                }
            }
            catch (ApplicationException aex)
            {
                txtMediaExponencialOficina.Focus();
                cbExponencialOficina.Checked = false;
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                txtMediaExponencialOficina.Focus();
                cbExponencialOficina.Checked = false;
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
                    if (!(verif <= 0))
                    {
                        txtH.Enabled = false;
                    }
                    else
                    {
                        throw new ApplicationException("El paso no puede ser negativo o 0");
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
                semillaLlegadas = DateTime.Now.Millisecond + rand.Next(0, 159752);
                semillaCaseta = DateTime.Now.Day + rand.Next(0, 159752);
                semillaOficina = DateTime.Now.Month + rand.Next(0, 159752);
                semillaRevision = DateTime.Now.Minute + rand.Next(0, 159752);
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
                    cantidadCasetas = Convert.ToInt32(txtCantidadCaseta.Text);
                    cantidadOficinas = Convert.ToInt32(txtCantidadOficina.Text);
                    parametrosLlegadas[0] = txtLambdaPoissonLlegadas.Text;
                    parametrosCaseta[0] = txtMediaExponencialCaseta.Text;
                    parametrosRevision[0] = txtLambdaExponencialRevision.Text;
                    parametrosOficina[0] = txtMediaExponencialOficina.Text;
                    hache = Convert.ToDouble(txtH.Text);

                    unoOdos = 1;
                    tiempoSimular = converetidor.deTiempoADouble(diasSimular, horasSimular, minutosSimular, 0);
                    tiempoMostrar = converetidor.deTiempoADouble(diasMostrar, horasMostrar, minutosMostar, 0);
                    TextWriter textoLlegada = new StreamWriter("R_K_Llegada_Bloqueo.txt");
                    TextWriter textoBloqLleg = new StreamWriter("R-K_Bloqueo_Llegadas.txt");
                    TextWriter textoBloqOf = new StreamWriter("R_K_Bloqueo_Oficina.txt");
                    string renglon = "Simulacion iniciada en: " + DateTime.Now.ToString();
                    textoLlegada.Write(renglon);
                    textoBloqLleg.Write(renglon);
                    textoBloqOf.Write(renglon);
                    textoLlegada.Close();
                    textoBloqLleg.Close();
                    textoBloqOf.Close();

                    //Creacion de Objetos
                    vector1 = new VectorSimulacion();
                    vector2 = new VectorSimulacion();
                    crearCasetas();
                    crearRevision();
                    crearOficinas();
                    crearBloqueo();
                    vector1.llegadaCliente = new EventoLlegadaCliente();
                    vector2.llegadaCliente = new EventoLlegadaCliente();
                    if (cbSemilla.Checked) 
                    {
                        ExponencialLlegadas = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaLlegadas), lambdaOMedia = 2 };
                        ExponencialCaseta = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaCaseta), lambdaOMedia = 2 };
                        ExponencialRevision = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaRevision), lambdaOMedia = 2 };
                        ExponencialOficina = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(semillaOficina), lambdaOMedia = 2 };
                    }
                    else
                    {
                        ExponencialLlegadas = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(), lambdaOMedia = 2 };
                        ExponencialCaseta = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(), lambdaOMedia = 2 };
                        ExponencialRevision = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(), lambdaOMedia = 2 };
                        ExponencialOficina = new DistribucionExponencial() { generador = new GeneradorDelLenguaje(), lambdaOMedia = 2 };
                    }
                    EcDifLlegadaBloqueo = new RKLlegadaBloqueo();
                    EcDifBloqueoLlegadas = new RKFinBloqLlegadas();
                    EcDifBloqueoOficina = new RKFinBloqOficina();
                    generadorParaTipoBloq = new GeneradorDelLenguaje();
                    generadorParaBeta = new GeneradorDelLenguaje();
                    cargarGrillaConObjetosPermamentes();
                    contadorMostrar = 0;
                    //Comenzar Simulacion
                    estadoInicial();
                    tiempoSimulacion = vector1.reloj;
                    simular();
                    gbParametros.Enabled = true;
                    btnGuardar.Enabled = true;
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
            if (!cbCaseta.Checked)
                throw new ApplicationException("Debe confirmar la cantidad de empleados de caseta");
            if (!cbOficina.Checked)
                throw new ApplicationException("Debe confirmar la cantidad de empleados de oficina");
            if (!cbPoissonLlegadas.Checked)
                throw new ApplicationException("Debe confirmar el parametro del Llegada Cliente");
            if (!cbExponencialCaseta.Checked)
                throw new ApplicationException("Debe confirmar el parametro del Fin Caseta");
            if (!cbExponencialRevision.Checked)
                throw new ApplicationException("Debe confirmar el parametro del Fin Revision");
            if (!cbExponencialOficina.Checked)
                throw new ApplicationException("Debe confirmar el parametro del Fin Oficina");
            if (!cbH.Checked)
                throw new ApplicationException("Debe confirmar el Paso de Integracion");
            return true;
        }

        private void crearCasetas()
        {
            for (int i = 0; i < cantidadCasetas; i++)
            {
                EmpleadoCaseta emp = new EmpleadoCaseta();
                emp.nombre = "Caseta " + (i+1).ToString();
                EventoFinCaseta ev = new EventoFinCaseta();
                ev.nombreEvento = "Fin Caseta " + (i + 1).ToString();
                ev.empleadoCaseta = emp;
                vector1.EmpleadosCaseta.Add(emp);
                vector1.finCaseta.Add(ev);
                vector2.EmpleadosCaseta.Add(emp);
                vector2.finCaseta.Add(ev);
            }
        }
        private void crearRevision()
        {
            for (int i = 0; i < cantidadRevision; i++)
            {
                CircuitoRevision emp = new CircuitoRevision();
                emp.nombre = "Revision " + (i + 1).ToString();
                EventoFinRevision ev = new EventoFinRevision();
                ev.nombreEvento = "Fin Revision " + (i + 1).ToString();
                ev.circuitoRevision = emp;
                vector1.CircuitosRevision.Add(emp);
                vector1.finRevision.Add(ev);
                vector2.CircuitosRevision.Add(emp);
                vector2.finRevision.Add(ev);
            }
        }
        private void crearOficinas()
        {
            for (int i = 0; i < cantidadOficinas; i++)
            {
                EmpleadoOficina emp = new EmpleadoOficina();
                emp.nombre = "Oficina " + (i + 1).ToString();
                EventoFinOficina ev = new EventoFinOficina();
                ev.nombreEvento = "Fin Oficina " + (i + 1).ToString();
                ev.empleadoOficina = emp;
                vector1.EmpleadosOficina.Add(emp);
                vector1.finOficina.Add(ev);
                vector2.EmpleadosOficina.Add(emp);
                vector2.finOficina.Add(ev);
            }
        }
        private void crearBloqueo()
        {
            Bloqueo objetoBloqueo = new Bloqueo() { estado = "FueraSistema", nombre = "Bloqueo" };
            vector1.empleadoBloqueo = objetoBloqueo;
            vector2.empleadoBloqueo = objetoBloqueo;
            EventoLlegadaBloqueo llegBloq = new EventoLlegadaBloqueo() { nombreEvento = "Llegada Bloqueo" };
            vector1.llegadaBloqueo = llegBloq;
            vector2.llegadaBloqueo = llegBloq;
            EventoFinBloqueo finBloq = new EventoFinBloqueo() { nombreEvento = "Fin Bloqueo" };
            vector1.finBloqueo = finBloq;
            vector2.finBloqueo = finBloq;
        }

        private void estadoInicial()
        {
            vector1.evento = "Estado Inicial";
            vector1.reloj = 0;
            vector1.llegadaCliente.generarTiempoLlegada(ExponencialLlegadas, parametrosLlegadas, vector1.reloj);
            vector1.llegadaBloqueo.generarLlegadaBloqueo(EcDifLlegadaBloqueo, generadorParaBeta, vector1, hache);
            foreach (var caseta in vector1.EmpleadosCaseta)
            {
                caseta.estadoCaseta = "Libre";
                caseta.acumuladorTiempoServidorOcupado = 0;
                caseta.porcentajeDeOcupacionDeLaCaseta = 0;
            }
            foreach (var revision in vector1.CircuitosRevision)
            {
                revision.estadoRevision = "Libre";
            }
            foreach (var oficina in vector1.EmpleadosOficina)
            {
                oficina.estadoOficina = "Libre";
                oficina.acumuladorTiempoServidorOcupado = 0;
                oficina.porcentajeDeOcupacionDeLaOficina = 0;
            }
            vector1.colaBloqueo = 0;
            vector1.colaCaseta = 0;
            vector1.colaRevision = 0;
            vector1.colaOficina = 0;

            vector1.longitudPromedioColaRevision = 0;
            vector1.contadorClientesEnColaRevision = 0;
            vector1.tiempoPromedioQuePasanEnLaOficina = 0;
            vector1.acumuladorDeTiemposDeOficina = 0;
            vector1.contadorClientesOficinaYSistema = 0;
            vector1.tiempoPromedioEnElSistema = 0;
            vector1.acumuladorTiemposEnSistema = 0;
            vector1.cantidadGenteIngresoAlSistema = 0;
            vector1.cantidadGenteNoAtendida = 0;
            vector1.porcentajeClientesNoAtendidos = 0;
            vector1.tiempoColaDeCasetaLlena = 0;
            vector1.longitudMaximaColaCaseta = 0;
            vector1.longitudMaximaColaRevision = 0;
            vector1.longitudMaximaColaOficina = 0;

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

                    foreach (var caseta in vector2.EmpleadosCaseta)
                    {
                        if (caseta.estadoCaseta == "Ocupado")
                        {
                            caseta.acumuladorTiempoServidorOcupado += Math.Round((vector1.reloj - vector2.reloj), 2);
                            caseta.porcentajeDeOcupacionDeLaCaseta = Math.Round((caseta.acumuladorTiempoServidorOcupado * 100) / vector1.reloj, 2);
                        }
                    }
                    foreach (var oficina in vector2.EmpleadosOficina)
                    {
                        if (oficina.estadoOficina == "Ocupado")
                        {
                            oficina.acumuladorTiempoServidorOcupado += Math.Round((vector1.reloj - vector2.reloj), 2);
                            oficina.porcentajeDeOcupacionDeLaOficina = Math.Round((oficina.acumuladorTiempoServidorOcupado * 100) / vector1.reloj, 2);
                        }
                    }

                    ejecutarEvento(proximoEvento, vector2, vector1);
                    tiempoSimulacion = vector1.reloj;
                    vector1.longitudPromedioColaRevision = Math.Round(vector1.contadorClientesEnColaRevision / vector1.reloj,2);
                    if (vector1.contadorClientesOficinaYSistema == 0)
                    {
                        vector1.tiempoPromedioQuePasanEnLaOficina = 0;
                        vector1.tiempoPromedioEnElSistema = 0;
                    }
                    else
                    {
                        vector1.tiempoPromedioQuePasanEnLaOficina = Math.Round(vector1.acumuladorDeTiemposDeOficina / vector1.contadorClientesOficinaYSistema,2);
                        vector1.tiempoPromedioEnElSistema = Math.Round(vector1.acumuladorTiemposEnSistema / vector1.contadorClientesOficinaYSistema,2);
                    }
                    vector1.porcentajeClientesNoAtendidos = Math.Round((vector1.cantidadGenteNoAtendida / (vector1.cantidadGenteNoAtendida + vector1.cantidadGenteIngresoAlSistema)) * 100, 2);
                    if (vector2.colaCaseta == 15)
                    {
                        vector1.tiempoColaDeCasetaLlena = Math.Round(vector2.tiempoColaDeCasetaLlena + (vector1.reloj - vector2.reloj),2);
                    }

                    vector2.Clientes = vector1.Clientes;
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

                    foreach (var caseta in vector1.EmpleadosCaseta)
                    {
                        if (caseta.estadoCaseta == "Ocupado")
                        {
                            caseta.acumuladorTiempoServidorOcupado += Math.Round((vector2.reloj - vector1.reloj), 2);
                            caseta.porcentajeDeOcupacionDeLaCaseta = Math.Round((caseta.acumuladorTiempoServidorOcupado * 100) / vector2.reloj, 2);
                        }
                    }
                    foreach (var oficina in vector1.EmpleadosOficina)
                    {
                        if (oficina.estadoOficina == "Ocupado")
                        {
                            oficina.acumuladorTiempoServidorOcupado += Math.Round((vector2.reloj - vector1.reloj), 2);
                            oficina.porcentajeDeOcupacionDeLaOficina = Math.Round((oficina.acumuladorTiempoServidorOcupado * 100) / vector2.reloj);
                        }
                    }

                    ejecutarEvento(proximoEvento, vector1, vector2);
                    tiempoSimulacion = vector2.reloj;
                    vector2.longitudPromedioColaRevision = Math.Round(vector2.contadorClientesEnColaRevision / vector2.reloj,2);
                    if (vector2.contadorClientesOficinaYSistema == 0)
                    {
                        vector2.tiempoPromedioQuePasanEnLaOficina = 0;
                        vector2.tiempoPromedioEnElSistema = 0;
                    }
                    else
                    {
                        vector2.tiempoPromedioQuePasanEnLaOficina = Math.Round(vector2.acumuladorDeTiemposDeOficina / vector2.contadorClientesOficinaYSistema,2);
                        vector2.tiempoPromedioEnElSistema = Math.Round(vector2.acumuladorTiemposEnSistema / vector2.contadorClientesOficinaYSistema,2);
                    }
                    vector2.porcentajeClientesNoAtendidos = Math.Round((vector2.cantidadGenteNoAtendida / (vector2.cantidadGenteNoAtendida + vector2.cantidadGenteIngresoAlSistema)) * 100, 2);
                    if (vector1.colaCaseta == 15)
                    {
                        vector2.tiempoColaDeCasetaLlena = Math.Round(vector1.tiempoColaDeCasetaLlena + (vector2.reloj - vector1.reloj),2);
                    }
 
                    vector1.Clientes = vector2.Clientes;
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
            if (vectorAnterior.llegadaCliente.tiempoEvento != 0)
            {
                proxEvent[0] = vectorAnterior.llegadaCliente.tiempoEvento;
                proxEvent[1] = vectorAnterior.llegadaCliente.nombreEvento;
            }
            if(vectorAnterior.llegadaBloqueo.tiempoEvento != 0)
            {
                if (vectorAnterior.llegadaBloqueo.tiempoEvento < (double)proxEvent[0])
                {
                    proxEvent[0] = vectorAnterior.llegadaBloqueo.tiempoEvento;
                    proxEvent[1] = vectorAnterior.llegadaBloqueo.nombreEvento;
                }
            }
            if (vectorAnterior.finBloqueo.tiempoEvento != 0)
            {
                if (vectorAnterior.finBloqueo.tiempoEvento < (double)proxEvent[0])
                {
                    proxEvent[0] = vectorAnterior.finBloqueo.tiempoEvento;
                    proxEvent[1] = vectorAnterior.finBloqueo.nombreEvento;
                }
            }
            foreach (var fincaseta in vectorAnterior.finCaseta)
            {
                if (fincaseta.tiempoEvento != 0)
                {
                    if (fincaseta.tiempoEvento < (double)proxEvent[0])
                    {
                        proxEvent[0] = fincaseta.tiempoEvento;
                        proxEvent[1] = fincaseta.nombreEvento;
                    }
                }
            }
            foreach (var finrev in vectorAnterior.finRevision)
            {
                if (finrev.tiempoEvento != 0)
                {
                    if (finrev.tiempoEvento < (double)proxEvent[0])
                    {
                        proxEvent[0] = finrev.tiempoEvento;
                        proxEvent[1] = finrev.nombreEvento;
                    }
                }
            }
            foreach (var finoficina in vectorAnterior.finOficina)
            {
                if (finoficina.tiempoEvento != 0)
                {
                    if (finoficina.tiempoEvento < (double)proxEvent[0])
                    {
                        proxEvent[0] = finoficina.tiempoEvento;
                        proxEvent[1] = finoficina.nombreEvento;
                    }
                }
            }
            return proxEvent;
        }
        private void ejecutarEvento(object[] proxEvent, VectorSimulacion vectorAnterior, VectorSimulacion vectorActual)
        {
            if ((string)proxEvent[1] == "Llegada Cliente")
            {
                vectorActual.llegadaCliente.ejecutarEvento(ExponencialLlegadas, parametrosLlegadas, ExponencialCaseta, parametrosCaseta, vectorActual, vectorAnterior);
                return;
            }
            if ((string)proxEvent[1] == "Llegada Bloqueo")
            {
                vectorActual.llegadaBloqueo.ejecutarEvento(EcDifBloqueoLlegadas, EcDifBloqueoOficina, generadorParaTipoBloq, hache, vectorActual, vectorAnterior);
                return;
            }
            if ((string)proxEvent[1] == "Fin Bloqueo")
            {
                vectorActual.finBloqueo.ejecutarEvento(EcDifLlegadaBloqueo, generadorParaBeta, hache, vectorActual, vectorAnterior, ExponencialCaseta, parametrosCaseta, ExponencialOficina, parametrosOficina);
                return;
            }            
            foreach (var fincaseta in vectorActual.finCaseta)
            {
                if (fincaseta.nombreEvento == (string)proxEvent[1])
                {
                    fincaseta.ejecutarEvento(ExponencialCaseta, parametrosCaseta, ExponencialRevision, parametrosRevision, vectorActual, vectorAnterior);
                    return;
                }
            }
            foreach (var finrevision in vectorActual.finRevision)
            {
                if (finrevision.nombreEvento == (string)proxEvent[1])
                {
                    finrevision.ejecutarEvento(ExponencialRevision, parametrosRevision, ExponencialOficina, parametrosOficina, vectorActual, vectorAnterior);
                    return;
                }
            }
            foreach (var finoficina in vectorActual.finOficina)
            {
                if (finoficina.nombreEvento == (string)proxEvent[1])
                {
                    finoficina.ejecutarEvento(ExponencialOficina, parametrosOficina, vectorActual, vectorAnterior);
                    return;
                }
            }
        }

        //Esta parte del manejo de la grilla no es necesariamente parte de la evaluacion de la materia, por lo tanto copienla,
        //modifiquenla, y utilicenla sabiamente para cuando tengan que programar el trabajo individual, ya sea para aprobacion total o para el final
        //porque eso es lo que se hace en la industria, reutilizar software por mas que no termines de entender como funciona del todo.
        #region Manejo de la grilla
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
            dgvResultados.Columns.Add("RNDLlegada", "RND Llegada");
            dgvResultados.Columns.Add("TiempoLlegada", "Tiempo Llegada");
            dgvResultados.Columns.Add("LlegadaCliente", "Llegada Cliente");
            dgvResultados.Columns.Add("BetaEcDif", "Beta Ec.Dif.");
            dgvResultados.Columns.Add("TiempoLlegBloq", "Tiempo Llegada Bloqueo");
            dgvResultados.Columns.Add("LlegadaBloqueo", "Llegada Bloqueo");
            dgvResultados.Columns.Add("RNDTipo", "RND Tipo Bloqueo");
            dgvResultados.Columns.Add("TipoBloqueo", "Tipo Bloqueo");
            dgvResultados.Columns.Add("TiempoBloq", "Tiempo Bloqueo");
            dgvResultados.Columns.Add("FinBloqueo", "Fin Bloqueo");
            //dgvResultados.Columns.Add("RNDCaseta", "RND Caseta");
            //dgvResultados.Columns.Add("TiempoCaseta", "Tiempo Caseta");
            //contCols = 7; //son 7 columnas, su indice seria 6 por empezar en 0, y por lo tanto los fin casetas comenzarian en el incide 7
            contCols = 12; //Ahora son 12 columnas
            colComFinCasetas = contCols; //Esto ahora cuenta donde empiezan las columnas de todo lo que tiene un fin caseta
            foreach (var fincaseta in vector1.finCaseta) //Se cargan las columnas de los fin Caseta i
            {
                dgvResultados.Columns.Add("RND" + fincaseta.nombreEvento.Trim(), "RND " + fincaseta.nombreEvento);
                dgvResultados.Columns.Add("Tiempo" + fincaseta.nombreEvento.Trim(), "Tiempo " + fincaseta.nombreEvento);
                dgvResultados.Columns.Add(fincaseta.nombreEvento.Trim(), fincaseta.nombreEvento);
                contCols += 3; //Como el primer indice de este grupo de columnas ya esta contemplado con anterioridad aca se cuenta en indice de la siguiente columna
            }
            dgvResultados.Columns.Add("RNDRevision", "RND Revision");
            dgvResultados.Columns.Add("TiempoRevision", "Tiempo Revision");
            contCols += 2; //Se le suma dos porque, uno para la primera columna (RNDRevision) se sumo dentro del ultimo loop de las fin caseta, luego se suma una columna extra (Tiempo Revision),
                           //y por lo tanto el indice de las fin revision seria pues el siguiente, por lo tanto hay que sumar otro numero
            colComFinRevisiones = contCols;
            foreach (var finrev in vector1.finRevision) //Se cargan las columnas de los fin Revision i
            {
                dgvResultados.Columns.Add(finrev.nombreEvento.Trim(), finrev.nombreEvento);
                contCols++;
            }
            dgvResultados.Columns.Add("RNDOficina", "RND Oficina"); //El indice de esta columna es el ultimo contCols++ del foreach
            dgvResultados.Columns.Add("TiempoOficina", "Tiempo Oficina"); //Este seria otro contCols +1
            contCols += 2; //y por lo tanto el indice de la siguiente columna tiene otro +1, siendo entonces contCols + 2
            colComFinOficinas = contCols;
            foreach (var finoficina in vector1.finOficina) //Se cargan las columnas de los fin Oficina i
            {
                dgvResultados.Columns.Add(finoficina.nombreEvento.Trim(), finoficina.nombreEvento);
                contCols++;
            }
            dgvResultados.Columns.Add("tiempoRestante", "Tiempo Restante Oficina Bloqueada");
            contCols++;
            colComEstadoBloqueo = contCols;
            dgvResultados.Columns.Add("estadoBloq", "Estado Bloqueo");
            dgvResultados.Columns.Add("colaBloq", "Cola Llegadas Bloqueadas");
            contCols += 2;
            colComEstadosCaseta = contCols;
            foreach (var caseta in vector1.EmpleadosCaseta) //Se cargan las columnas de los estados de las casetas i
            {
                dgvResultados.Columns.Add("estado" + caseta.nombre.Trim(), "Estado " + caseta.nombre);
                contCols++;
            }
            dgvResultados.Columns.Add("ColaCaseta", "Cola Caseta");
            contCols += 1;
            colComEstadosRevision = contCols;
            foreach (var revision in vector1.CircuitosRevision) //Se cargan las columnas los estados de las revisiones i
            {
                dgvResultados.Columns.Add("estado" + revision.nombre.Trim(), "Estado " + revision.nombre);
                contCols++;
            }
            dgvResultados.Columns.Add("ColaRevision", "Cola Revision");
            contCols += 1;
            colComEstadosOficina = contCols;
            foreach (var oficina in vector1.EmpleadosOficina) //Se cargan las columnas los estados de las oficinas i
            {
                dgvResultados.Columns.Add("estado" + oficina.nombre.Trim(), "Estado " + oficina.nombre);
                contCols++;
            }
            dgvResultados.Columns.Add("ColaOficina", "Cola Oficina");

            //Se cargan las columnas de las estadisticas fijas
            contCols += 1;
            colComEstadisticas = contCols;
            dgvResultados.Columns.Add("LongPromColaRev", "Longitud Promedio Cola Revision");
            dgvResultados.Columns.Add("ConClieColaRev", "Contador Clientes que pasaron por Cola Revision");
            dgvResultados.Columns.Add("TiempoPromOficina", "Tiempo Promedio de los Clientes en la Oficina");
            dgvResultados.Columns.Add("AcumTiemposOficina", "Acumulador de Tiempos de los Clientes en la Oficina");
            dgvResultados.Columns.Add("TiempoPromSistema", "Tiempo Promedio de los Clientes en el Sistema");
            dgvResultados.Columns.Add("AcumTiemposSistema", "Acumulador de Tiempos de los Clientes en el Sistema");
            dgvResultados.Columns.Add("ContClieOfYSist", "Contador Clientes Fin Oficina y Sistema");
            dgvResultados.Columns.Add("PorcentClieNoAtend", "Porcentaje de Clientes no Atendidos");
            dgvResultados.Columns.Add("CantCliesIngSist", "Cantidad de Clientes que Ingresaron al Sistema");
            dgvResultados.Columns.Add("CantClieNoAtend", "Cantidad de Clientes no Atendidos");

            contCols += 10;
            colComPorcentajesDeOcupacionCasetas = contCols;
            foreach (var caseta in vector1.EmpleadosCaseta) //Se cargan las columnas de las estadisticas de los porcentajes de ocupacion de las casetas
            {
                dgvResultados.Columns.Add("PorcentOcup" + caseta.nombre.Trim(), "Porcentaje de Ocupacion de " + caseta.nombre);
                dgvResultados.Columns.Add("AcumTiempoOcup" + caseta.nombre.Trim(), "Acumulador de Tiempo Ocupado de " + caseta.nombre);
                contCols += 2;
            }
            colComPorcentajesDeOcupacionOficinas = contCols;
            foreach (var oficina in vector1.EmpleadosOficina) //Se cargan las columnas de las estadisticas de los porcentajes de ocupacion de las oficinas
            {
                dgvResultados.Columns.Add("PorcentOcup" + oficina.nombre.Trim(), "Porcentaje de Ocupacion de " + oficina.nombre);
                dgvResultados.Columns.Add("AcumTeimpoOcup" + oficina.nombre.Trim(), "Acumuladr de Tiempo Ocupado de " + oficina.nombre);
                contCols += 2;
            }

            colComEstadisticas2 = contCols;
            //Se cargan las columnas del resto de estadisticas fijas
            dgvResultados.Columns.Add("TiempoColCasLlena", "Tiempo que pasa la Cola de la Caseta Llena");
            dgvResultados.Columns.Add("LongMaxColaCas", "Longitud Maxima Cola de la Caseta");
            dgvResultados.Columns.Add("LongMaxColaRev", "Longitud Maxima Cola de Revision");
            dgvResultados.Columns.Add("LongMaxColaOfi", "Longitud Maxima Cola de la Oficina");

            contCols += 4;
            colComObjetosTransitorios = contCols;
            //Se agregan las primeras columnas para un cliente
            dgvResultados.Columns.Add("NumClie", "Numero de Cliente");
            dgvResultados.Columns.Add("EstadoClie", "Estado de Cliente");
            dgvResultados.Columns.Add("PosColaClie", "Posicion en la Cola de Cliente");
            dgvResultados.Columns.Add("TiempoLlegadaSisClie", "Tiempo de Llegada al sistema de Cliente");
            dgvResultados.Columns.Add("TiempoLlegadaOfClie", "Tiempo de Llegada a la oficina de Cliente");
            //v0.00000000000000000000000002 por Bruno Salas
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
            dgvResultados.Rows[contadorMostrar].Cells[1].Value = converetidor.deDoubleATiempo(vectorActual.reloj);
            if (vectorActual.llegadaCliente.RNDLlegada != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[2].Value = vectorActual.llegadaCliente.RNDLlegada.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[2].Value = "";
            if (vectorActual.llegadaCliente.tiempoLlegada != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[3].Value = converetidor.deDoubleATiempo(vectorActual.llegadaCliente.tiempoLlegada);
            else
                dgvResultados.Rows[contadorMostrar].Cells[3].Value = "";
            dgvResultados.Rows[contadorMostrar].Cells[4].Value = converetidor.deDoubleATiempo(vectorActual.llegadaCliente.tiempoEvento);
            if (vectorActual.llegadaBloqueo.RNDBeta != 0)
                dgvResultados.Rows[contadorMostrar].Cells[5].Value = vectorActual.llegadaBloqueo.RNDBeta.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[5].Value = "";
            if (vectorActual.llegadaBloqueo.tiempoLlegadaBloq != 0)
                dgvResultados.Rows[contadorMostrar].Cells[6].Value = converetidor.deDoubleATiempo(vectorActual.llegadaBloqueo.tiempoLlegadaBloq);
            else
                dgvResultados.Rows[contadorMostrar].Cells[6].Value = "";
            if (vectorActual.llegadaBloqueo.tiempoEvento != 0)
                dgvResultados.Rows[contadorMostrar].Cells[7].Value = converetidor.deDoubleATiempo(vectorActual.llegadaBloqueo.tiempoEvento);
            else
                dgvResultados.Rows[contadorMostrar].Cells[7].Value = "";
            if (vectorActual.finBloqueo.RNDTipo != 0)
                dgvResultados.Rows[contadorMostrar].Cells[8].Value = vectorActual.finBloqueo.RNDTipo.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[8].Value = "";
            dgvResultados.Rows[contadorMostrar].Cells[9].Value = vectorActual.finBloqueo.tipo;
            if (vectorActual.finBloqueo.tiempoBloqueo != 0)
                dgvResultados.Rows[contadorMostrar].Cells[10].Value = converetidor.deDoubleATiempo(vectorActual.finBloqueo.tiempoBloqueo);
            else
                dgvResultados.Rows[contadorMostrar].Cells[10].Value = "";
            if (vectorActual.finBloqueo.tiempoEvento != 0)
                dgvResultados.Rows[contadorMostrar].Cells[11].Value = converetidor.deDoubleATiempo(vectorActual.finBloqueo.tiempoEvento);
            else
                dgvResultados.Rows[contadorMostrar].Cells[11].Value = "";
            //if (vectorActual.RNDCaseta != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
            //    dgvResultados.Rows[contadorMostrar].Cells[5].Value = vectorActual.RNDCaseta.ToString();
            //else
            //    dgvResultados.Rows[contadorMostrar].Cells[5].Value = "";
            //if (vectorActual.tiempoCaseta != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
            //    dgvResultados.Rows[contadorMostrar].Cells[6].Value = converetidor.deDoubleATiempo(vectorActual.tiempoCaseta);
            //else
            //    dgvResultados.Rows[contadorMostrar].Cells[6].Value = "";
            i = 0;
            foreach (var fincaseta in vectorActual.finCaseta) //Con este loop se cargan los i fin caseta
            {
                if (fincaseta.RNDCaseta != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = fincaseta.RNDCaseta.ToString();
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = "";
                i++;
                if (fincaseta.tiempoCaseta != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = converetidor.deDoubleATiempo(fincaseta.tiempoCaseta);
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = "";
                i++;
                if (fincaseta.tiempoEvento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = converetidor.deDoubleATiempo(fincaseta.tiempoEvento);
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinCasetas + i].Value = "";
                i++;
            }
            if (vectorActual.RNDRevision != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones - 2].Value = vectorActual.RNDRevision.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones - 2].Value = "";
            if (vectorActual.tiempoRevision != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones - 1].Value = converetidor.deDoubleATiempo(vectorActual.tiempoRevision);
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones - 1].Value = "";
            i = 0;
            foreach (var finrev in vectorActual.finRevision) //Con este loop se cargan los i fin revision
            {
                if (finrev.tiempoEvento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones + i].Value = converetidor.deDoubleATiempo(finrev.tiempoEvento);
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinRevisiones + i].Value = "";
                i++;
            }
            if (vectorActual.RNDOficina != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas - 2].Value = vectorActual.RNDOficina.ToString();
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas - 2].Value = "";
            if (vectorActual.tiempoOficina != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas - 1].Value = converetidor.deDoubleATiempo(vectorActual.tiempoOficina);
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas - 1].Value = "";
            i = 0;
            foreach (var finoficina in vectorActual.finOficina) //Con este loop se cargan los i fin oficina
            {
                if (finoficina.tiempoEvento != 0) //Con esto se maneja que si un valor es 0 se ponga un espacio vacio
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas + i].Value = converetidor.deDoubleATiempo(finoficina.tiempoEvento);
                else
                    dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas + i].Value = "";
                i++;
            }
            if (vectorActual.tiempoRestanteOficinaBloqueada != 0)
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas + i].Value = converetidor.deDoubleATiempo(vectorActual.tiempoRestanteOficinaBloqueada);
            else
                dgvResultados.Rows[contadorMostrar].Cells[colComFinOficinas + i].Value = "";
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadoBloqueo].Value = vectorActual.empleadoBloqueo.estado;
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadoBloqueo + 1].Value = vectorActual.colaBloqueo.ToString();
            i = 0;
            foreach (var caseta in vectorActual.EmpleadosCaseta) //Con este loop se cargan los i empleados de caseta
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComEstadosCaseta + i].Value = caseta.estadoCaseta;
                i++;
            }
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadosCaseta + i].Value = vectorActual.colaCaseta.ToString();
            i = 0;
            foreach (var revision in vectorActual.CircuitosRevision) //Con este loop se cargan los i circuitos de revision
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComEstadosRevision + i].Value = revision.estadoRevision;
                i++;
            }
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadosRevision + i].Value = vectorActual.colaRevision.ToString();
            i = 0;
            foreach (var oficina in vectorActual.EmpleadosOficina) //Con este loop se cargan los i empleados de oficina
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComEstadosOficina + i].Value = oficina.estadoOficina;
                i++;
            }
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadosOficina + i].Value = vectorActual.colaOficina.ToString();

            //En esta seccion se cargan las estadisticas fijas, aquellas que no dependen de cuantos servidores haya de su tipo
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas].Value = vectorActual.longitudPromedioColaRevision.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 1].Value = vectorActual.contadorClientesEnColaRevision.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 2].Value = converetidor.deDoubleATiempo(vectorActual.tiempoPromedioQuePasanEnLaOficina);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 3].Value = converetidor.deDoubleATiempo(vectorActual.acumuladorDeTiemposDeOficina);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 4].Value = converetidor.deDoubleATiempo(vectorActual.tiempoPromedioEnElSistema);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 5].Value = converetidor.deDoubleATiempo(vectorActual.acumuladorTiemposEnSistema);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 6].Value = vectorActual.contadorClientesOficinaYSistema.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 7].Value = vectorActual.porcentajeClientesNoAtendidos.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 8].Value = vectorActual.cantidadGenteIngresoAlSistema.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas + 9].Value = vectorActual.cantidadGenteNoAtendida.ToString();
            i = 0;

            foreach (var caseta in vectorActual.EmpleadosCaseta) //Como estas estadisticas son manejadas dentro de cada caseta pues se hace este loop para agregar las i estadisticas dependientes
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComPorcentajesDeOcupacionCasetas + i].Value = caseta.porcentajeDeOcupacionDeLaCaseta.ToString();
                i++;
                dgvResultados.Rows[contadorMostrar].Cells[colComPorcentajesDeOcupacionCasetas + i].Value = converetidor.deDoubleATiempo(caseta.acumuladorTiempoServidorOcupado);
                i++;
            }
            i = 0;
            foreach (var oficina in vectorActual.EmpleadosOficina) //Como estas estadisticas son manejadas dentro de cada oficina pues se hace este loop para agregar las i estadisticas dependientes
            {
                dgvResultados.Rows[contadorMostrar].Cells[colComPorcentajesDeOcupacionOficinas + i].Value = oficina.porcentajeDeOcupacionDeLaOficina.ToString();
                i++;
                dgvResultados.Rows[contadorMostrar].Cells[colComPorcentajesDeOcupacionOficinas + i].Value = converetidor.deDoubleATiempo(oficina.acumuladorTiempoServidorOcupado);
                i++;
            }
            //Aca hay otra seccion de estadisticas que no dependen de la cantidad de servidores
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas2].Value = converetidor.deDoubleATiempo(vectorActual.tiempoColaDeCasetaLlena);
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas2 + 1].Value = vectorActual.longitudMaximaColaCaseta.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas2 + 2].Value = vectorActual.longitudMaximaColaRevision.ToString();
            dgvResultados.Rows[contadorMostrar].Cells[colComEstadisticas2 + 3].Value = vectorActual.longitudMaximaColaOficina.ToString();

            //En esta seccion se maneja la carga de los clientes, ya sea metiendolos siempre es su mismo grupo de columnas o creando nuevas de ser necesarias para ese cliente
            foreach (var cliente in vectorActual.Clientes) //Se realiza el loop para recorrer todos los clientes
            {
                if (cliente.columnaSalida == 0) //Se pregunta si el cliente ya tiene asignada una columna de salida
                { //En caso de que no (=0) pues se pasa a asignarla
                    asignarColumna(cliente);
                }
                else
                { //En caso de que si, se utiliza ese atributo de los clientes para escribir sus valores en las mismas columnas donde ya estaba, aplicando la misma logica que antes
                    //usando el contadorMostrar para entrar en la fila actual y en la celda con el indice correspondiente a su columna
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida].Value = cliente.numeroCliente.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 1].Value = cliente.estado;
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 2].Value = cliente.posicionCola.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 3].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaSistema);
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 4].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaOficina);
                }
            }

            //v0.00000000000000000000000002 por Bruno Salas
        }

        private void asignarColumna(Cliente cliente)
        {
            //Para asignarle una columna al cliente:
            //1º Se asigna la columna tentativa como la primera donde comenzarian los clientes, guardado con anterioridad cuando se crearon todas las columnas de objetos permanentes
            //2º Despues se asume que se deberan crear las columnas necesarias para el cliente por estar todas las demas en uso y ocupadas
            //3º Luego se recorren las columnas para ver si hay algun espacio libre, de haberlo se guarda ahi, de no haberlo se crean las columnas necesarias
            var columnaAAsignar = colComObjetosTransitorios;
            var crearColumnas = true;

            while (columnaAAsignar < dgvResultados.Columns.Count) //Con este loop se recorren las columnas donde comienzan cada cliente (numero cliente) hasta el final de las columnas de la data grid view
            {
                if (dgvResultados.Rows[contadorMostrar].Cells[columnaAAsignar].Value == null) //Se pregunta si esa columna no tiene valor
                { //De no tener valor se le asigna al cliente esa(s) columna(s) y se cargan sus datos
                    cliente.columnaSalida = columnaAAsignar;
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida].Value = cliente.numeroCliente.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 1].Value = cliente.estado;
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 2].Value = cliente.posicionCola.ToString();
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 3].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaSistema);
                    dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 4].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaOficina);
                    //Se cambia la bandera para que no se creen las columnas nuevas y se sale del loop pues ya no es necesario seguir buscando
                    crearColumnas = false;
                    break;
                }
                else
                { //En caso de que si hubiese tenido valor se suman 5 al valor tentativo de la columna a asignar para que la proxima comparacion la haga con el proximo hueco de columnas de un cliente
                    columnaAAsignar += 5;
                }
            } //En caso de que no encuentre ninguna columna vacia, cuando el asignar columna cae fuera de la cantidad de columnas existentes de la data grid,
              // como se asumio que se devian crear las columnas pasara el proximo if

            if (crearColumnas) //Dependiendo de la bandera de crear columnas
            { //Añadira las 5 columnas necesarias
                dgvResultados.Columns.Add("NumClie" + cliente.numeroCliente.ToString(), "Numero de Cliente");
                dgvResultados.Columns.Add("EstadoClie" + cliente.numeroCliente.ToString(), "Estado de Cliente");
                dgvResultados.Columns.Add("PosColaClie" + cliente.numeroCliente.ToString(), "Posicion en la Cola de Cliente");
                dgvResultados.Columns.Add("TiempoLlegadaSisClie" + cliente.numeroCliente.ToString(), "Tiempo de Llegada al sistema de Cliente");
                dgvResultados.Columns.Add("TiempoLlegadaOfClie" + cliente.numeroCliente.ToString(), "Tiempo de Llegada a la oficina de Cliente");
                //Y le asignara esa(s) columna(s) al cliente para que luego se sigan utilizando igual, y se cargan sus datos en las columnas recien creadas
                cliente.columnaSalida = columnaAAsignar;
                dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida].Value = cliente.numeroCliente.ToString();
                dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 1].Value = cliente.estado;
                dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 2].Value = cliente.posicionCola.ToString();
                dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 3].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaSistema);
                dgvResultados.Rows[contadorMostrar].Cells[cliente.columnaSalida + 4].Value = converetidor.deDoubleATiempo(cliente.tiempoLlegadaOficina);

            } //De no tener que crear simplemente no se realizara lo que esta dentro del if y se pasara al siguiente cliente.


            //v0.00000000000000000000000001 por Bruno Salas
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (unoOdos == 1)
            {
                añadirAtxt(vector2);
            }
            else
            {
                añadirAtxt(vector1);
            }
        }

        private void añadirAtxt(VectorSimulacion vectorFinal)
        {
            StreamWriter texto = File.AppendText("Comparacion.txt");
            string comp = "Parametros de la prueba\n\n" +
                          "Tiempo de Simulacion:\t" + converetidor.deDoubleATiempo(vectorFinal.reloj) + "\n" +
                          "Cantidad de Empeleados Caseta:\t" + vectorFinal.EmpleadosCaseta.Count + "\n" +
                          "Cantidad de Circuitos de Revision:\t" + vectorFinal.CircuitosRevision.Count + "\n" +
                          "Cantidad de Empleados Oficina:\t" + vectorFinal.EmpleadosOficina.Count + "\n" +
                          "Media de Llegadas:\t" + parametrosLlegadas[0] + " minutos\n" +
                          "Media de Atencion Caseta:\t" + parametrosCaseta[0] + " minutos\n" +
                          "Media de Revision:\t" + parametrosRevision[0] + " miutos\n" +
                          "Media de Atencion Oficina:\t" + parametrosOficina[0] + " minutos\n\n" +
                          "Resultados\n\n" +
                          "Cantidad de Clientes que Llegaron\tTiempo Promedio en Sistema\tPorcentaje de Clientes no Atendidos";
            foreach (var caseta in vectorFinal.EmpleadosCaseta)
            {
                comp += "\tPorcentaje de Ocupacion Empleado " + caseta.nombre;
            }
            foreach (var oficina in vectorFinal.EmpleadosOficina)
            {
                comp += "\tPorcentaje de Ocupacion Empleado " + oficina.nombre;
            }
            var suma = vectorFinal.cantidadGenteIngresoAlSistema + vectorFinal.cantidadGenteNoAtendida;
            comp += "\n" + suma.ToString() + "\t" + converetidor.deDoubleATiempo(vectorFinal.tiempoPromedioEnElSistema) + "\t"  + vectorFinal.porcentajeClientesNoAtendidos.ToString();
            foreach (var caseta in vectorFinal.EmpleadosCaseta)
            {
                comp += "\t" + caseta.porcentajeDeOcupacionDeLaCaseta;
            }
            foreach (var oficina in vectorFinal.EmpleadosOficina)
            {
                comp += "\t" + oficina.porcentajeDeOcupacionDeLaOficina;
            }
            comp += "\n\n'--Siguiente Prueba--\n";
            texto.WriteLine(comp);
            texto.Close();
            MessageBox.Show("Se guardo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
