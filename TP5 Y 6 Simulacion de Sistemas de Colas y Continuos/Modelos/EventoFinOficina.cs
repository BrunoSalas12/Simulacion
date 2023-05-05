using GeneradoresVariableAleatoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoFinOficina
    {
        public string nombreEvento { get; set; }
        public double tiempoEvento { get; set; }
        public EmpleadoOficina empleadoOficina { get; set; }
        public Cliente cliente { get; set; }

        public void generarFinOficina(IDistribucion dist, string[] ps, VectorSimulacion vectorActual)
        {
            double[] varAleat = dist.generarVariableAleatoria(ps);
            vectorActual.RNDOficina = varAleat[0];
            vectorActual.tiempoOficina = varAleat[1];
            tiempoEvento = Math.Round(vectorActual.reloj + vectorActual.tiempoOficina,2);
        }

        public void ejecutarEvento(IDistribucion distOficina, string[] paramsDistOficina, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            Cliente nuevo = new Cliente();
            if (vectorAnterior.colaOficina == 0) //Pregunta si pregunta si hay clientes en cola
            { //No hay clientes en cola

                empleadoOficina.estadoOficina = "Libre";
                vectorActual.RNDOficina = 0;
                vectorActual.tiempoOficina = 0;
                this.tiempoEvento = 0;
                vectorActual.colaOficina = vectorAnterior.colaOficina;
                //operaciones estadisticas

            }
            else //Si hay clientes en cola
            {
                foreach (var cliente in vectorAnterior.Clientes)
                {
                    if (cliente.posicionCola == 1 && cliente.estado == "ECOficina")
                    {
                        cliente.posicionCola = 0;
                        cliente.estado = "A" + empleadoOficina.nombre.Trim();
                        nuevo = cliente;
                        break;
                    }
                }
                empleadoOficina.estadoOficina = "Ocupado";
                vectorActual.colaOficina = vectorAnterior.colaOficina - 1;
                this.generarFinOficina(distOficina, paramsDistOficina, vectorActual);
                //operaciones estadisticas
            }
            moverClientesEnCola(vectorActual);
            //operaciones estadisticas
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina + (vectorActual.reloj - cliente.tiempoLlegadaOficina);
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema + (vectorActual.reloj - cliente.tiempoLlegadaSistema);
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema + 1;
            vectorActual.Clientes.Remove(cliente);

            cliente = nuevo;

            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }

        private void moverClientesEnCola(VectorSimulacion vectorActual)
        {
            if (!(vectorActual.colaOficina == 0))
            {
                foreach (var cliente in vectorActual.Clientes)
                {
                    if (cliente.estado == "ECOficina")
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
            vectorActual.RNDRevision = 0;
            vectorActual.tiempoRevision = 0;
            vectorActual.llegadaBloqueo.RNDBeta = 0;
            vectorActual.llegadaBloqueo.tiempoLlegadaBloq = 0;
            vectorActual.finBloqueo.RNDTipo = 0;
            vectorActual.finBloqueo.tipo = "";
            vectorActual.finBloqueo.tiempoBloqueo = 0;
            vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
            vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            vectorActual.colaCaseta = vectorAnterior.colaCaseta;
            vectorActual.colaRevision = vectorAnterior.colaRevision;
            vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
            vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
            vectorActual.longitudMaximaColaCaseta = vectorAnterior.longitudMaximaColaCaseta;
            vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
            vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;
        }
    }
}
