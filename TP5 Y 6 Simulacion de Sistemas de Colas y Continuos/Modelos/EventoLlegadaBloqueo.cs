using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresVariableAleatoria;
using Runge_Kutta;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoLlegadaBloqueo
    {
        public string nombreEvento { get; set; }
        public double RNDBeta { get; set; }
        public double tiempoLlegadaBloq { get; set; }
        public double tiempoEvento { get; set; }
        public Bloqueo empleadoEvento { get; set; }
        private int numeroEvento;

        public void generarLlegadaBloqueo(IRungeKutta ecuacion, IGenerador genParaRnd, VectorSimulacion vectorActual, double paso)
        {
            numeroEvento += 1;
            RNDBeta = genParaRnd.generarRandom()[2];
            if (RNDBeta == 0)
            {
                RNDBeta = 0.01;
            }
            var parametros = new double[2];
            parametros[0] = numeroEvento;
            parametros[1] = RNDBeta;
            tiempoLlegadaBloq = ecuacion.obtenerTiempo(0, 152.71, paso, parametros);
            tiempoEvento = Math.Round(vectorActual.reloj + tiempoLlegadaBloq, 2);
        }

        public void ejecutarEvento(IRungeKutta ecBloqLegadas, IRungeKutta ecBloqOficina, IGenerador genParaRnd, double paso, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.finBloqueo.generarFinBloqueo(ecBloqLegadas, ecBloqOficina, genParaRnd, paso, vectorActual);
            RNDBeta = 0;
            tiempoLlegadaBloq = 0;
            tiempoEvento = 0;
            if (vectorActual.finBloqueo.tipo == "Bloqueo Llegadas") //Pregunta si esta bloqueando las llegadas
            {//Esta bloqueando las Llegadas
                vectorActual.empleadoBloqueo.estado = "BloqLlegadas";

                vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;

            }
            else
            {//Esta bloqueando Oficina
                if (empleadoLibre(vectorAnterior)) //Pregunta si la oficina esta libre
                {//Si esta libre
                    vectorActual.EmpleadosOficina[0].estadoOficina = "SBloqueada";

                    vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
                }
                else
                {//No esta libre
                    vectorActual.tiempoRestanteOficinaBloqueada = vectorActual.finOficina[0].tiempoEvento - vectorActual.reloj;
                    if (vectorActual.tiempoRestanteOficinaBloqueada == 0)
                    {
                        vectorActual.tiempoRestanteOficinaBloqueada = 0.01;
                    }
                    vectorActual.finOficina[0].tiempoEvento = 0;
                    vectorActual.EmpleadosOficina[0].estadoOficina = "SBloqueada";
                    vectorActual.finOficina[0].cliente.estado = "ServInterrumpido";
                }
                vectorActual.empleadoBloqueo.estado = "BloqOficina";
            }
            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }

        private bool empleadoLibre(VectorSimulacion vectorAnterior)
        {
            bool resultado = false;
            if (vectorAnterior.EmpleadosOficina[0].estadoOficina == "Libre")
            {
                resultado = true;
            }
            return resultado;
        }

        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.llegadaCliente.RNDLlegada = 0;
            vectorActual.llegadaCliente.tiempoLlegada = 0;
            vectorActual.llegadaCliente.tiempoEvento = vectorAnterior.llegadaCliente.tiempoEvento;
            foreach (var finCaseta in vectorActual.finCaseta)
            {
                finCaseta.RNDCaseta = 0;
                finCaseta.tiempoCaseta = 0;
            }
            vectorActual.RNDRevision = 0;
            vectorActual.tiempoRevision = 0;
            vectorActual.RNDOficina = 0;
            vectorActual.tiempoOficina = 0;
            vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            vectorActual.colaCaseta = vectorAnterior.colaCaseta;
            vectorActual.colaRevision = vectorAnterior.colaRevision;
            vectorActual.colaOficina = vectorAnterior.colaOficina;
            vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina;
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema;
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema;
            vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
            vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
            vectorActual.longitudMaximaColaCaseta = vectorAnterior.longitudMaximaColaCaseta;
            vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
            vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;

        }
    }
}
