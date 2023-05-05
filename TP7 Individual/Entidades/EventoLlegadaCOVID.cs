using GeneradoresVariableAleatoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class EventoLlegadaCOVID
    {
        public string nombreEvento { get; set; }
        public double RNDLlegada { get; set; }
        public double tiempoLlegada { get; set; }
        public double tiempoEvento { get; set; }

        public EventoLlegadaCOVID()
        {
            nombreEvento = "Llegada COVID";
        }

        public void generarTiempoLlegada(IDistribucion dist, string[] ps, VectorSimulacion vectorActual)
        {
            nombreEvento = "Llegada COVID";
            double[] varAleat = dist.generarVariableAleatoria(ps);
            RNDLlegada = varAleat[0];
            tiempoLlegada = varAleat[1];
            tiempoEvento = Math.Round(vectorActual.reloj + tiempoLlegada, 2);
        }

        public void ejecutarEvento(IDistribucion ditsCOVID, string[] paramsCOVID, IDistribucion distCant, string[] paramsCant, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            this.generarTiempoLlegada(ditsCOVID, paramsCOVID, vectorActual);
            double[] varAletaCant = distCant.generarVariableAleatoria(paramsCant);
            vectorActual.rndCantidad = varAletaCant[0];
            vectorActual.CantidadClientes = Math.Truncate(varAletaCant[1]);
            List<ClienteCOVID> clientesNuevos = new List<ClienteCOVID>();

            object[] empLibre = empleadoLibre(vectorAnterior); //Pregunta si hay algun enfermero libre
            if ((bool)empLibre[0])
            { // Si hay un enfermero libre
                Enfermero emp = (Enfermero)empLibre[1];
                EventoFinVacunacion ev = new EventoFinVacunacion();
                foreach (var evento in vectorActual.finVacunacion)
                {
                    if (evento.empeladoEvento == emp)
                    {
                        ev = evento;
                        break;
                    }
                }
                if ((vectorAnterior.colaCOVID + vectorActual.CantidadClientes) >= 5) //Pregunta si hay suficientes para vacunar COVID
                {//Si hay suficientes

                    for (int i = 0; i < vectorActual.CantidadClientes; i++)
                    {
                        ClienteCOVID clie = new ClienteCOVID();
                        clie.numeroCOVID = vectorAnterior.cantidadCOVIDLlegaronSistema + 1 + i;
                        clie.nombreCOVID = " - COVID";
                        clie.estadoCOVID = "EV";
                        clie.posicionColaCOVID = vectorAnterior.colaCOVID + 1 + i;
                        clie.tiempoLlegadaColaCOVID = vectorActual.reloj;
                        clientesNuevos.Add(clie);
                    }
                    vectorActual.colaCOVID = vectorAnterior.colaCOVID + vectorActual.CantidadClientes;
                    vectorActual.clientesCOVID.AddRange(clientesNuevos);
                    List<ClienteCOVID> clientesAtend = new List<ClienteCOVID>();
                    vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
                    foreach (var clieCOV in vectorActual.clientesCOVID)
                    {
                        if (clieCOV.estadoCOVID == "EV")
                        {
                            if (clieCOV.posicionColaCOVID <= 5)
                            {
                                clieCOV.estadoCOVID = "SV";
                                clieCOV.posicionColaCOVID = 0;
                                vectorActual.acumuladorTiempoEsperaCOVID += (vectorActual.reloj - clieCOV.tiempoLlegadaColaCOVID);
                                clieCOV.tiempoLlegadaColaCOVID = 0;
                                clientesAtend.Add(clieCOV);
                            }
                            else
                            {
                                clieCOV.estadoCOVID = "EV";
                                clieCOV.posicionColaCOVID -= 5;
                            }
                        }
                    }
                    ev.generarFinVacunacion(vectorActual, 5);
                    ev.clientesCOVID = clientesAtend;
                    ev.clientesGripe.Clear();
                    emp.estadoEnfermero = "VC";
                    vectorActual.colaCOVID -= 5;
                    vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID + 5;
                    vectorActual.cantidadNoVacunadosCOVID = vectorActual.colaCOVID;

                }
                else
                {//No hay suficientes

                    for (int i = 0; i < vectorActual.CantidadClientes; i++)
                    {
                        ClienteCOVID clie = new ClienteCOVID();
                        clie.numeroCOVID = vectorAnterior.cantidadCOVIDLlegaronSistema + 1 + i;
                        clie.nombreCOVID = " - COVID";
                        clie.estadoCOVID = "EV";
                        clie.posicionColaCOVID = vectorAnterior.colaCOVID + 1 + i;
                        clie.tiempoLlegadaColaCOVID = vectorActual.reloj;
                        clientesNuevos.Add(clie);
                    }
                    vectorActual.colaCOVID = vectorAnterior.colaCOVID + vectorActual.CantidadClientes;
                    vectorActual.cantidadNoVacunadosCOVID = vectorActual.colaCOVID;
                    vectorActual.clientesCOVID.AddRange(clientesNuevos);
                    vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
                    vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
                    vectorActual.tiempoVacunacion = 0;
                }
            }
            else //No hay enfermero libre
            {
                for (int i = 0; i < vectorActual.CantidadClientes; i++)
                {
                    ClienteCOVID clie = new ClienteCOVID();
                    clie.numeroCOVID = vectorAnterior.cantidadCOVIDLlegaronSistema + 1 + i;
                    clie.nombreCOVID = " - COVID";
                    clie.estadoCOVID = "EV";
                    clie.posicionColaCOVID = vectorAnterior.colaCOVID + 1 + i;
                    clie.tiempoLlegadaColaCOVID = vectorActual.reloj;
                    clientesNuevos.Add(clie);
                }
                vectorActual.colaCOVID = vectorAnterior.colaCOVID + vectorActual.CantidadClientes;
                vectorActual.cantidadNoVacunadosCOVID = vectorActual.colaCOVID;
                vectorActual.clientesCOVID.AddRange(clientesNuevos);
                vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
                vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
                vectorActual.tiempoVacunacion = 0;
            }
            vectorActual.cantidadCOVIDLlegaronSistema = vectorAnterior.cantidadCOVIDLlegaronSistema + vectorActual.CantidadClientes;
            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }
        private object[] empleadoLibre(VectorSimulacion vectorAnterior)
        {
            object[] resultado = new object[2];
            resultado[0] = false;
            resultado[1] = null;
            foreach (var enf in vectorAnterior.enfemeros)
            {
                if (enf.estadoEnfermero == "Libre")
                {
                    resultado[0] = true;
                    resultado[1] = enf;
                    break;
                }
            }
            return resultado;
        }
        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.llegadaClientesGripe.RNDLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoEvento = vectorAnterior.llegadaClientesGripe.tiempoEvento;
            vectorActual.vencimientoVac.tiempoVencimiento = 0;
            vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
            vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
            vectorActual.colaGripe = vectorAnterior.colaGripe;
            vectorActual.dosisVencidas = vectorAnterior.dosisVencidas;
            vectorActual.cantidadVacunadosGripe = vectorAnterior.cantidadVacunadosGripe;
            vectorActual.cantidadGripeLlegaronSistema = vectorAnterior.cantidadGripeLlegaronSistema;
            vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
            vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe;
            vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
        }
    }
}
