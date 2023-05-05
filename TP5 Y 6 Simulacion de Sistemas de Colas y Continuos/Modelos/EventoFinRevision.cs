using GeneradoresVariableAleatoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoFinRevision
    {
        public string nombreEvento { get; set; }
        public double tiempoEvento { get; set; }
        public CircuitoRevision circuitoRevision { get; set; }
        public Cliente cliente { get; set; }

        public void generarFinRevision(IDistribucion dist, string[] ps, VectorSimulacion vectorActual)
        {
            double[] varAleat = dist.generarVariableAleatoria(ps);
            vectorActual.RNDRevision = varAleat[0];
            vectorActual.tiempoRevision = varAleat[1];
            tiempoEvento = Math.Round(vectorActual.reloj + vectorActual.tiempoRevision,2);
        }

        public void ejecutarEvento(IDistribucion distRevision, string[] paramsDistRevision, IDistribucion distOficina, string[] paramsDistOficina, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            Cliente nuevo = new Cliente();
            if (vectorAnterior.colaRevision == 0) //Pregunta si pregunta si hay clientes en cola
            { //No hay clientes en cola

                circuitoRevision.estadoRevision = "Libre";
                vectorActual.RNDRevision = 0;
                vectorActual.tiempoRevision = 0;
                this.tiempoEvento = 0;
                vectorActual.colaRevision = vectorAnterior.colaRevision;
                //operaciones estadisticas

            }
            else //Si hay clientes en cola
            {
                foreach (var cliente in vectorAnterior.Clientes)
                {
                    if (cliente.posicionCola == 1 && cliente.estado == "ECRevision")
                    {
                        cliente.posicionCola = 0;
                        cliente.estado = "A" + circuitoRevision.nombre.Trim();
                        nuevo = cliente;
                        break;
                    }
                }
                circuitoRevision.estadoRevision = "Ocupado";
                vectorActual.colaRevision = vectorAnterior.colaRevision - 1;
                this.generarFinRevision(distRevision, paramsDistRevision, vectorActual);
                //operaciones estadisticas
            }
            moverClientesEnCola(vectorActual);

            object[] empLibre = empleadoLibre(vectorAnterior); //Pregunta si hay alguna oficina libre
            if ((bool)empLibre[0])
            { //Si hay oficina libre

                EmpleadoOficina emp = (EmpleadoOficina)empLibre[1];
                EventoFinOficina ev = new EventoFinOficina();
                foreach (var evento in vectorActual.finOficina)
                {
                    if (evento.empleadoOficina == emp)
                    {
                        ev = evento;
                        break;
                    }
                }
                //Calcula el tiempo de Fin Oficina
                ev.generarFinOficina(distOficina, paramsDistOficina, vectorActual);
                vectorActual.colaOficina = vectorAnterior.colaOficina;
                //Cambia y setea estados
                emp.estadoOficina = "Ocupado";
                cliente.estado = "A" + emp.nombre.Trim();
                cliente.posicionCola = 0;
                ev.cliente = cliente;
                //operaciones estadisticas
            }
            else //No hay oficina libre
            {
                vectorActual.colaOficina = vectorAnterior.colaOficina + 1;
                cliente.posicionCola = vectorActual.colaOficina;
                cliente.estado = "ECOficina";
                vectorActual.RNDOficina = 0;
                vectorActual.tiempoOficina = 0;
                //operaciones estadisticas
            }
            cliente.tiempoLlegadaOficina = vectorActual.reloj;
            cliente = nuevo;
            esMaximoColaOficina(vectorActual, vectorAnterior);

            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }

        private object[] empleadoLibre(VectorSimulacion vectorAnterior)
        {
            object[] resultado = new object[2];
            resultado[0] = false;
            resultado[1] = null;
            foreach (var oficina in vectorAnterior.EmpleadosOficina)
            {
                if (oficina.estadoOficina == "Libre")
                {
                    resultado[0] = true;
                    resultado[1] = oficina;
                    break;
                }
            }
            return resultado;
        }
        private void esMaximoColaOficina(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            if (vectorActual.colaOficina > vectorAnterior.longitudMaximaColaOficina)
            {
                vectorActual.longitudMaximaColaOficina = vectorActual.colaOficina;
            }
            else
            {
                vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;
            }
        }
        private void moverClientesEnCola(VectorSimulacion vectorActual)
        {
            if (!(vectorActual.colaRevision == 0))
            {
                foreach (var cliente in vectorActual.Clientes)
                {
                    if (cliente.estado == "ECRevision")
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
                finCaseta.RNDCaseta = 0;
                finCaseta.tiempoCaseta = 0;
            }
            vectorActual.llegadaBloqueo.RNDBeta = 0;
            vectorActual.llegadaBloqueo.tiempoLlegadaBloq = 0;
            vectorActual.finBloqueo.RNDTipo = 0;
            vectorActual.finBloqueo.tipo = "";
            vectorActual.finBloqueo.tiempoBloqueo = 0;
            vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
            vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            vectorActual.colaCaseta = vectorAnterior.colaCaseta;
            vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina;
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema;
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema;
            vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
            vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
            vectorActual.longitudMaximaColaCaseta = vectorAnterior.longitudMaximaColaCaseta;
            vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
        }
    }
}
