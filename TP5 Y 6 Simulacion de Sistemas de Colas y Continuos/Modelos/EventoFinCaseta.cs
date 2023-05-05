using GeneradoresVariableAleatoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoFinCaseta
    {
        public string nombreEvento { get; set; }
        public double RNDCaseta { get; set; }
        public double tiempoCaseta { get; set; }
        public double tiempoEvento { get; set; }
        public EmpleadoCaseta empleadoCaseta { get; set; }
        public Cliente cliente { get; set; }

        public void generarFinCaseta(IDistribucion dist, string[] ps, VectorSimulacion vectorActual)
        {
            double[] varAleat = dist.generarVariableAleatoria(ps);
            RNDCaseta = varAleat[0];
            tiempoCaseta = varAleat[1];
            tiempoEvento = Math.Round(vectorActual.reloj + tiempoCaseta,2);
        }

        public void ejecutarEvento(IDistribucion distCaseta, string[] paramsDistCaseta, IDistribucion distRevision, string[] paramsDistRevision, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            Cliente nuevo = new Cliente();
            if (vectorAnterior.colaCaseta == 0) //Pregunta si pregunta si hay clientes en cola
            { //No hay clientes en cola

                empleadoCaseta.estadoCaseta = "Libre";
                RNDCaseta = 0;
                tiempoCaseta = 0;
                this.tiempoEvento = 0;
                vectorActual.colaCaseta = vectorAnterior.colaCaseta;
                //operaciones estadisticas

            }
            else //Si hay clientes en cola
            {
                foreach (var cliente in vectorActual.Clientes)
                {
                    if (cliente.posicionCola == 1 && cliente.estado == "ECCaseta")
                    {
                        cliente.posicionCola = 0;
                        cliente.estado = "A" + empleadoCaseta.nombre.Trim();
                        nuevo = cliente;
                        break;
                    }
                }
                empleadoCaseta.estadoCaseta = "Ocupado";
                vectorActual.colaCaseta = vectorAnterior.colaCaseta - 1;
                this.generarFinCaseta(distCaseta, paramsDistCaseta, vectorActual);
                //operaciones estadisticas
            }
            moverClientesEnCola(vectorActual);

            object[] empLibre = empleadoLibre(vectorAnterior); //Pregunta si hay alguna revision libre
            if ((bool)empLibre[0])
            { //Si hay revision libre
                
                CircuitoRevision emp = (CircuitoRevision)empLibre[1];
                EventoFinRevision ev = new EventoFinRevision();
                foreach (var evento in vectorActual.finRevision)
                {
                    if (evento.circuitoRevision == emp)
                    {
                        ev = evento;
                        break;
                    }
                }
                //Calcula el tiempo de Fin Revision
                ev.generarFinRevision(distRevision, paramsDistRevision, vectorActual);
                vectorActual.colaRevision = vectorAnterior.colaRevision;
                //Cambia y setea estados
                emp.estadoRevision = "Ocupado";
                cliente.estado = "A" + emp.nombre.Trim();
                cliente.posicionCola = 0;
                ev.cliente = cliente;
                //operaciones estadisticas
                vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            }
            else //No hay revision libre
            {
                vectorActual.colaRevision = vectorAnterior.colaRevision + 1;
                cliente.posicionCola = vectorActual.colaRevision;
                cliente.estado = "ECRevision";
                vectorActual.RNDRevision = 0;
                vectorActual.tiempoRevision = 0;
                //operaciones estadisticas
                vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision + 1;
            }
            cliente = nuevo;
            esMaximoColaRevision(vectorActual, vectorAnterior);

            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }

        private object[] empleadoLibre(VectorSimulacion vectorAnterior)
        {
            object[] resultado = new object[2];
            resultado[0] = false;
            resultado[1] = null;
            foreach (var revision in vectorAnterior.CircuitosRevision)
            {
                if (revision.estadoRevision == "Libre")
                {
                    resultado[0] = true;
                    resultado[1] = revision;
                    break;
                }
            }
            return resultado;
        }
        private void esMaximoColaRevision(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            if (vectorActual.colaRevision > vectorAnterior.longitudMaximaColaRevision)
            {
                vectorActual.longitudMaximaColaRevision = vectorActual.colaRevision;
            }
            else
            {
                vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
            }
        }
        private void moverClientesEnCola(VectorSimulacion vectorActual)
        {
            if (!(vectorActual.colaCaseta == 0)) 
            {
                foreach (var cliente in vectorActual.Clientes)
                {
                    if (cliente.estado == "ECCaseta")
                    {
                        cliente.posicionCola -= 1;
                    }
                }
            }
        }

        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.llegadaCliente.RNDLlegada = 0;
            vectorActual.llegadaCliente.tiempoLlegada = 0;
            vectorActual.llegadaCliente.tiempoEvento = vectorAnterior.llegadaCliente.tiempoEvento;
            foreach (var finCaseta in vectorActual.finCaseta)
            {
                if (finCaseta != this)
                {
                    finCaseta.RNDCaseta = 0;
                    finCaseta.tiempoCaseta = 0;
                }
            }
            vectorActual.RNDOficina = 0;
            vectorActual.tiempoOficina = 0;
            vectorActual.llegadaBloqueo.RNDBeta = 0;
            vectorActual.llegadaBloqueo.tiempoLlegadaBloq = 0;
            vectorActual.finBloqueo.RNDTipo = 0;
            vectorActual.finBloqueo.tipo = "";
            vectorActual.finBloqueo.tiempoBloqueo = 0;
            vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
            vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            vectorActual.colaOficina = vectorAnterior.colaOficina;
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina;
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema;
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema;
            vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
            vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
            vectorActual.longitudMaximaColaCaseta = vectorAnterior.longitudMaximaColaCaseta;
            vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;
        }
    }
}
