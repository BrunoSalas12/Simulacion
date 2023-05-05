using GeneradoresVariableAleatoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoLlegadaCliente
    {
        public string nombreEvento { get; set; }
        public double RNDLlegada { get; set; }
        public double tiempoLlegada { get; set; }
        public double tiempoEvento { get; set; }
        public Cliente empleadoEvento { get; set; }
        private int i;

        public void generarTiempoLlegada(IDistribucion dist, string[] ps, double tiempoSim)
        {
            nombreEvento = "Llegada Cliente";
            double[] varAleat = dist.generarVariableAleatoria(ps);
            RNDLlegada = varAleat[0];
            tiempoLlegada = varAleat[1];
            tiempoEvento = Math.Round(tiempoSim + tiempoLlegada,2);
        }

        public void ejecutarEvento(IDistribucion distLlegadas, string[] paramsDistLlegadas, IDistribucion distCaseta, string[] paramsDistCaseta, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            this.generarTiempoLlegada(distLlegadas, paramsDistLlegadas, vectorActual.reloj);
            if (!(vectorAnterior.empleadoBloqueo.estado == "BloqLlegadas")) //Pregunta si estan siendo Bloqueadas las llegadas
            { //No estan siendo Bloqueadas
                if (vectorAnterior.colaCaseta == 15) //Pregunta si la cola esta llena
                { //Esta la cola llena

                    vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida + 1;

                    vectorActual.colaCaseta = vectorAnterior.colaCaseta;
                    foreach (var finCaseta in vectorActual.finCaseta)
                    {
                        finCaseta.RNDCaseta = 0;
                        finCaseta.tiempoCaseta = 0;
                    }
                    vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
                }
                else //No esta la cola llena
                {
                    Cliente nuevoClie = new Cliente() { tiempoLlegadaSistema = vectorActual.reloj };
                    object[] empLibre = empleadoLibre(vectorAnterior); //Pregunta si hay algun empleado libre
                    if ((bool)empLibre[0])
                    { // Si hay un empleado libre
                        EmpleadoCaseta emp = (EmpleadoCaseta)empLibre[1];
                        EventoFinCaseta ev = new EventoFinCaseta();
                        foreach (var evento in vectorActual.finCaseta)
                        {
                            if (evento.empleadoCaseta == emp)
                            {
                                ev = evento;
                                break;
                            }
                        }
                        //Calcula el tiempo de Fin Casta
                        ev.generarFinCaseta(distCaseta, paramsDistCaseta, vectorActual);
                        vectorActual.colaCaseta = vectorAnterior.colaCaseta;
                        //Cambia y setea estados
                        emp.estadoCaseta = "Ocupado";
                        nuevoClie.estado = "A" + emp.nombre.Trim();
                        nuevoClie.numeroCliente = vectorAnterior.cantidadGenteIngresoAlSistema + 1;
                        nuevoClie.posicionCola = 0;
                        ev.cliente = nuevoClie;
                        //operaciones estadisticas

                    }
                    else //No hay empleado libre
                    {
                        vectorActual.colaCaseta = vectorAnterior.colaCaseta + 1;
                        nuevoClie.posicionCola = vectorActual.colaCaseta;
                        nuevoClie.estado = "ECCaseta";
                        nuevoClie.numeroCliente = vectorAnterior.cantidadGenteIngresoAlSistema + 1;

                        foreach (var finCaseta in vectorActual.finCaseta)
                        {
                            finCaseta.RNDCaseta = 0;
                            finCaseta.tiempoCaseta = 0;
                        }

                    }
                    vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema + 1;
                    vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
                    vectorActual.Clientes.Add(nuevoClie);
                }
                vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            }
            else
            {//Si estan siendo Bloqueadas
                if ((vectorAnterior.colaBloqueo + vectorAnterior.colaCaseta)==15) //Pregunta si las colas estan llenas
                {//Si estan llenas
                    vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida + 1;

                    vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
                    vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
                }
                else
                {//No estan llenas
                    Cliente nuevoClie = new Cliente() { tiempoLlegadaSistema = vectorActual.reloj };
                    vectorActual.colaBloqueo = vectorAnterior.colaBloqueo + 1;
                    nuevoClie.estado = "ECBloqueo";
                    nuevoClie.numeroCliente = vectorAnterior.cantidadGenteIngresoAlSistema + 1;
                    nuevoClie.posicionCola = vectorActual.colaBloqueo;
                    vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema + 1;
                    vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
                    vectorActual.Clientes.Add(nuevoClie);
                }
                vectorActual.colaCaseta = vectorAnterior.colaCaseta;
                foreach (var finCaseta in vectorActual.finCaseta)
                {
                    finCaseta.RNDCaseta = 0;
                    finCaseta.tiempoCaseta = 0;
                }
            }
            esMaximoColaCaseta(vectorActual, vectorAnterior);

            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }
        private object[] empleadoLibre(VectorSimulacion vectorAnterior)
        {
            object[] resultado = new object[2];
            resultado[0] = false;
            resultado[1] = null;
            foreach (var caseta in vectorAnterior.EmpleadosCaseta)
            {
                if (caseta.estadoCaseta == "Libre")
                {
                    resultado[0] = true;
                    resultado[1] = caseta;
                    break;
                }
            }
            return resultado;
        }

        private void esMaximoColaCaseta (VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            if (vectorActual.colaCaseta > vectorAnterior.longitudMaximaColaCaseta)
            {
                vectorActual.longitudMaximaColaCaseta = vectorActual.colaCaseta;
            }
            else
            {
                vectorActual.longitudMaximaColaCaseta = vectorAnterior.longitudMaximaColaCaseta;
            }
        }
        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.RNDRevision = 0;
            vectorActual.tiempoRevision = 0;
            vectorActual.RNDOficina = 0;
            vectorActual.tiempoOficina = 0;
            vectorActual.llegadaBloqueo.RNDBeta = 0;
            vectorActual.llegadaBloqueo.tiempoLlegadaBloq = 0;
            vectorActual.finBloqueo.RNDTipo = 0;
            vectorActual.finBloqueo.tipo = "";
            vectorActual.finBloqueo.tiempoBloqueo = 0;
            vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
            vectorActual.colaRevision = vectorAnterior.colaRevision;
            vectorActual.colaOficina = vectorAnterior.colaOficina;
            vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina;
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema;
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema;
            vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
            vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;
        }
    }
}
