using GeneradoresVariableAleatoria;
using Runge_Kutta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EventoFinBloqueo
    {
        public string nombreEvento { get; set; }
        public double RNDTipo { get; set; }
        public string tipo { get; set; }
        public double tiempoBloqueo { get; set; }
        public double tiempoEvento { get; set; }
        public Bloqueo empleadoEvento { get; set; }
        private int numeroEventoBL;
        private int numeroEventoBO;
        
        public void generarFinBloqueo(IRungeKutta ecBloqLlegada, IRungeKutta ecBloqOficina, IGenerador genParaRnd, double paso, VectorSimulacion vectorActual)
        {
            RNDTipo = genParaRnd.generarRandom()[2];
            if (RNDTipo < 0.70)
            {
                numeroEventoBL += 1;
                tipo = "Bloqueo Llegadas";
                var parametros = new double[1];
                parametros[0] = numeroEventoBL;
                tiempoBloqueo = ecBloqLlegada.obtenerTiempo(0, vectorActual.reloj, paso, parametros);
            }
            else
            {
                numeroEventoBO += 1;
                tipo = "Bloqueo Oficina";
                var parametros = new double[1];
                parametros[0] = numeroEventoBO;
                tiempoBloqueo = ecBloqOficina.obtenerTiempo(0, vectorActual.reloj, paso, parametros);
            }
            tiempoEvento = Math.Round(vectorActual.reloj + tiempoBloqueo, 2);
        }

        public void ejecutarEvento(IRungeKutta ecLlegada, IGenerador genParaRnd, double paso, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior, IDistribucion distFinCaseta, string[] paramsCaseta, IDistribucion distFinOficina, string[] paramsOficina)
        {
            vectorActual.llegadaBloqueo.generarLlegadaBloqueo(ecLlegada, genParaRnd, vectorActual, paso);
            RNDTipo = 0;
            tipo = "";
            tiempoBloqueo = 0;
            tiempoEvento = 0;
            if (vectorActual.empleadoBloqueo.estado == "BloqOficina") //Pregunta si estaba Bloqueando Oficina
            {//Si esta Bloquando Oficina
                if (vectorAnterior.tiempoRestanteOficinaBloqueada > 0) //Pregunta si hay un servicio interrumpido
                {//Si hay servicio Interrumpido
                    vectorActual.finOficina[0].tiempoEvento = vectorAnterior.tiempoRestanteOficinaBloqueada + vectorActual.reloj;
                    vectorActual.tiempoRestanteOficinaBloqueada = 0;
                    vectorActual.EmpleadosOficina[0].estadoOficina = "Ocupado";
                    vectorActual.finOficina[0].cliente.estado = "A" + vectorActual.finOficina[0].empleadoOficina.nombre.Trim();
                    vectorActual.RNDOficina = 0;
                    vectorActual.tiempoOficina = 0;
                    vectorActual.colaOficina = vectorAnterior.colaOficina;
                }
                else
                {//No hay servicio Interrumpido
                    if (vectorAnterior.colaOficina == 0) //Pregunta si hay clientes en cola
                    {//No hay clientes en cola
                        vectorActual.EmpleadosOficina[0].estadoOficina = "Libre";
                        vectorActual.RNDOficina = 0;
                        vectorActual.tiempoOficina = 0;
                        vectorActual.colaOficina = vectorAnterior.colaOficina;
                    }
                    else
                    {//Si hay clientes en cola
                        vectorActual.finOficina[0].generarFinOficina(distFinOficina, paramsOficina, vectorActual);
                        foreach (var cliente in vectorAnterior.Clientes)
                        {
                            if (cliente.posicionCola == 1 && cliente.estado == "ECOficina")
                            {
                                cliente.posicionCola = 0;
                                cliente.estado = "A" + vectorActual.EmpleadosOficina[0].nombre.Trim();
                                vectorActual.finOficina[0].cliente = cliente;
                                break;
                            }
                        }
                        vectorActual.EmpleadosOficina[0].estadoOficina = "Ocupado";
                        vectorActual.colaOficina = vectorAnterior.colaOficina - 1;
                        moverClientesEnCola(vectorActual);
                    }

                    vectorActual.tiempoRestanteOficinaBloqueada = 0;
                }
                foreach (var finCaseta in vectorActual.finCaseta)
                {
                    finCaseta.RNDCaseta = 0;
                    finCaseta.tiempoCaseta = 0;
                }
                vectorActual.colaCaseta = vectorAnterior.colaCaseta;
                vectorActual.colaBloqueo = vectorAnterior.colaBloqueo;
            }
            else if(vectorActual.empleadoBloqueo.estado == "BloqLlegadas") //No esta Bloqueando Oficina, pregunta si Esta Bloqueando Llegadas
            {//Si esta Bloqueando Llegadas
                if (vectorAnterior.colaBloqueo != 0)
                {
                    foreach (var cliente in vectorAnterior.Clientes)
                    {
                        if (cliente.estado == "ECBloqueo")
                        {
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
                                ev.generarFinCaseta(distFinCaseta, paramsCaseta, vectorActual);
                                //vectorActual.colaCaseta = vectorAnterior.colaCaseta; //Revisar
                                //Cambia y setea estados
                                emp.estadoCaseta = "Ocupado";
                                cliente.estado = "A" + emp.nombre.Trim();
                                cliente.posicionCola = 0;
                                ev.cliente = cliente;
                                //operaciones estadisticas

                            }
                            else //No hay empleado libre
                            {
                                vectorActual.colaCaseta = vectorAnterior.colaCaseta + 1;
                                vectorAnterior.colaCaseta += 1;
                                cliente.posicionCola = vectorActual.colaCaseta;
                                cliente.estado = "ECCaseta";
                            }
                        }
                    }
                }
                vectorActual.tiempoRestanteOficinaBloqueada = vectorAnterior.tiempoRestanteOficinaBloqueada;
                vectorActual.colaBloqueo = 0;
                vectorActual.RNDOficina = 0;
                vectorActual.tiempoOficina = 0;
                vectorActual.colaOficina = vectorAnterior.colaOficina;
            }
            else //No estaba Bloqueando Llegadas, y paso algo raro si llega por aca, por suerte eso ya no pasa, porque si llego a pasar una vez xD
            {
                throw new ApplicationException("Nande core wa, como es que se llego hasta aqui, hay algun error por ahi");
            }
            vectorActual.empleadoBloqueo.estado = "FueraSistema";
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
        private void esMaximoColaCaseta(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
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
            vectorActual.llegadaCliente.RNDLlegada = 0;
            vectorActual.llegadaCliente.tiempoLlegada = 0;
            vectorActual.llegadaCliente.tiempoEvento = vectorAnterior.llegadaCliente.tiempoEvento;
            vectorActual.RNDRevision = 0;
            vectorActual.tiempoRevision = 0;
//            vectorActual.RNDOficina = 0;
//            vectorActual.tiempoOficina = 0;
            vectorActual.colaRevision = vectorAnterior.colaRevision;
//            vectorActual.colaOficina = vectorAnterior.colaOficina;
            vectorActual.contadorClientesEnColaRevision = vectorAnterior.contadorClientesEnColaRevision;
            vectorActual.acumuladorDeTiemposDeOficina = vectorAnterior.acumuladorDeTiemposDeOficina;
            vectorActual.acumuladorTiemposEnSistema = vectorAnterior.acumuladorTiemposEnSistema;
            vectorActual.contadorClientesOficinaYSistema = vectorAnterior.contadorClientesOficinaYSistema;
            vectorActual.cantidadGenteIngresoAlSistema = vectorAnterior.cantidadGenteIngresoAlSistema;
            vectorActual.cantidadGenteNoAtendida = vectorAnterior.cantidadGenteNoAtendida;
            vectorActual.longitudMaximaColaRevision = vectorAnterior.longitudMaximaColaRevision;
            vectorActual.longitudMaximaColaOficina = vectorAnterior.longitudMaximaColaOficina;

        }
    }
}
