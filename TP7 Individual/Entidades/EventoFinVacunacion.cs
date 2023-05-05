using Runge_Kutta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    internal class EventoFinVacunacion
    {
        public string nombreEvento { get; set; }
        public double tiempoEvento { get; set; }
        public Enfermero empeladoEvento { get; set; }
        public List<ClienteGripe> clientesGripe { get; set; }
        public List<ClienteCOVID> clientesCOVID { get; set; }
        public EventoFinVacunacion()
        {
            clientesGripe = new List<ClienteGripe>();
            clientesCOVID = new List<ClienteCOVID>();
        }

        public void generarFinVacunacion(VectorSimulacion vectorActual, double cantidad)
        {
            vectorActual.tiempoVacunacion = ((22 * cantidad) / 60);
            tiempoEvento = vectorActual.reloj + vectorActual.tiempoVacunacion;
        }

        public void ejecutarEvento(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior, IRungeKutta RKCaja, double paso, List<int> numerosDeColOcups)
        {
            //this.tiempoEvento = 0;
            vectorActual.cantidadVacunadosGripe = vectorAnterior.cantidadVacunadosGripe + clientesGripe.Count;
            List<int> indicesGripe = new List<int>();
            List<int> indicesCOVID = new List<int>();
            int index = 0;
            foreach (var clieGripe in vectorActual.clientesGrie)
            {
                if (clientesGripe.Contains(clieGripe))
                {
                    numerosDeColOcups.Remove(clieGripe.columnaSalida);
                    indicesGripe.Add(index);
                }
                index++;
            }
            index = 0;
            foreach (var clieCOVID in vectorActual.clientesCOVID)
            {
                if (clientesCOVID.Contains(clieCOVID))
                {
                    numerosDeColOcups.Remove(clieCOVID.columnaSalida);
                    indicesCOVID.Add(index);
                }
                index++;
            }
            indicesGripe.Reverse();
            indicesCOVID.Reverse();
            foreach (var indi in indicesGripe)
            {
                if (vectorActual.clientesGrie.Count != 0)
                {
                    vectorActual.clientesGrie.RemoveAt(indi);
                }                
            }
            foreach (var indi in indicesCOVID)
            {
                if (vectorActual.clientesCOVID.Count != 0)
                {
                    vectorActual.clientesCOVID.RemoveAt(indi);
                }                
            }
            this.clientesGripe.Clear();
            this.clientesCOVID.Clear();

            if (empeladoEvento.estadoEnfermero == "VG") //Pregunta si lo ultimo que vacuno fue Gripe
            { //Lo ultimo que vacuno fue Gripe

                if (vectorAnterior.colaCOVID >= 5) //Pregunta si hay suficientes clientes COVID
                {//Si hay suficientes
                    vacunarCOVID(vectorActual, vectorAnterior);
                }
                else
                {//No hay suficientes

                    if (vectorAnterior.colaGripe != 0) //Pregunta si hay clientes para Gripe
                    {//Si hay clientes para Gripe
                        vacunarGripe(vectorActual, vectorAnterior, RKCaja, paso);
                    }
                    else
                    {//No hay clientes para Gripe
                        pasarALibre(vectorActual, vectorAnterior);
                    }
                }
            }
            else if (empeladoEvento.estadoEnfermero == "VC") //Pregunta si lo ultimo que vacuno fue COVID
            {//Lo ultimo que vacuno fue COVID

                if (vectorAnterior.colaGripe != 0) //Pregunta si hay clientes para Gripe
                {//Si hay clientes para Gripe
                    vacunarGripe(vectorActual, vectorAnterior, RKCaja, paso);
                }
                else
                {//No hay clientes para Gripe

                    if (vectorAnterior.colaCOVID >= 5) //Pregunta si hay suficientes clientes COVID
                    {//Si hay suficientes
                        vacunarCOVID(vectorActual, vectorAnterior);
                    }
                    else
                    {//No hay suficientes
                        pasarALibre(vectorActual, vectorAnterior);
                    }
                }
            }
            else //LLegar aqui es un error
            {
                throw new ApplicationException("Nande core wa, como es que se llego hasta aqui, hay algun error por ahi");
            }

            copiarCosasNoCambiadas(vectorActual, vectorAnterior);
        }
        private void pasarALibre(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            empeladoEvento.estadoEnfermero = "Libre";

            vectorActual.tiempoVacunacion = 0;
            this.tiempoEvento = 0;
            vectorActual.vencimientoVac.tiempoVencimiento = 0;
            vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
            vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
            vectorActual.colaGripe = vectorAnterior.colaGripe;
            vectorActual.colaCOVID = vectorAnterior.colaCOVID;
            vectorActual.cantidadNoVacunadosCOVID = vectorAnterior.cantidadNoVacunadosCOVID;
            vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
            vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe;
            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
            vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
            vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
        }
        private void vacunarCOVID(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
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
            this.generarFinVacunacion(vectorActual, 5);
            this.clientesCOVID = clientesAtend;
            this.clientesGripe.Clear();
            empeladoEvento.estadoEnfermero = "VC";
            vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID + 5;
            vectorActual.colaCOVID = vectorAnterior.colaCOVID - 5;
            vectorActual.cantidadNoVacunadosCOVID = vectorActual.colaCOVID;
            vectorActual.colaGripe = vectorAnterior.colaGripe;
            vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe;
            vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
            vectorActual.vencimientoVac.tiempoVencimiento = 0;
            vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
            vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
            vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
        }
        private void vacunarGripe(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior, IRungeKutta RKCaja, double paso)
        {
            vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe; 
            if (vectorActual.cajasVacunasGripe.Count >= 1) //Pregunta si hay caja abierta
            {//Si hay caja abierta
                CajaVacunas cajaVac = cajaConDosis(vectorAnterior);
                if (cajaVac.dosisCaja >= vectorAnterior.colaGripe) //Pregunta si hay suficientes dosis en esa caja
                {//Si hay suficientes dosis

                    cajaVac.dosisCaja -= vectorAnterior.colaGripe; //Resta dosis
                    this.generarFinVacunacion(vectorActual, vectorAnterior.colaGripe); //Genera Fin Vacunacion
                    empeladoEvento.estadoEnfermero = "VG"; //Cambio estado enfermero
                    foreach (var clieGripe in vectorActual.clientesGrie)
                    {
                        if (clieGripe.estadoGripe == "EV")
                        {
                            clieGripe.estadoGripe = "SV";
                            clieGripe.posicionColaGripe = 0;
                            vectorActual.acumuladorTiempoEsperaGripe += vectorActual.reloj - clieGripe.tiempoLlegadaColaGripe;
                            clieGripe.tiempoLlegadaColaGripe = 0;
                            this.clientesGripe.Add(clieGripe);
                        }

                    }
                    this.clientesCOVID.Clear();
                    vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
                    vectorActual.vencimientoVac.tiempoVencimiento = 0;
                    vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
                    vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
                }
                else
                {//No hay suficientes dosis
                    CajaVacunas nuevaCaja = new CajaVacunas();
                    double cantFaltante = vectorAnterior.colaGripe - cajaVac.dosisCaja;
                    cajaVac.dosisCaja = 0; //Resta dosis
                    while (cantFaltante >= 10) //de necesitar mas de una caja se abren las necesarias
                    {
                        nuevaCaja = abrirCaja(vectorAnterior, vectorActual, RKCaja, paso); //Se abre una caja nueva
                        nuevaCaja.dosisCaja -= 10; //Se descuentan las dosis
                        vectorActual.cajasVacunasGripe.Add(nuevaCaja);
                        cantFaltante -= 10;
                    }
                    if (cantFaltante != 0)
                    {
                        nuevaCaja = abrirCaja(vectorAnterior, vectorActual, RKCaja, paso); //Se abre una caja nueva
                        nuevaCaja.dosisCaja -= cantFaltante; //Se descuentan las dosis
                    }
                    this.generarFinVacunacion(vectorActual, vectorAnterior.colaGripe); //Genera Fin Vacunacion
                    empeladoEvento.estadoEnfermero = "VG"; //Cambio estado enfermero
                    foreach (var clieGripe in vectorActual.clientesGrie)
                    {
                        if (clieGripe.estadoGripe == "EV")
                        {
                            clieGripe.estadoGripe = "SV";
                            clieGripe.posicionColaGripe = 0;
                            vectorActual.acumuladorTiempoEsperaGripe += vectorActual.reloj - clieGripe.tiempoLlegadaColaGripe;
                            clieGripe.tiempoLlegadaColaGripe = 0;
                            this.clientesGripe.Add(clieGripe);
                        }
                    }
                    this.clientesCOVID.Clear();
                    vectorActual.cajasVacunasGripe.Add(nuevaCaja);
                }
            }
            else
            {//No hay caja abierta
                CajaVacunas nuevaCaja = new CajaVacunas();
                double cantFaltante = vectorAnterior.colaGripe;
                while (cantFaltante >= 10) //de necesitar mas de una caja se abren las necesarias
                {
                    nuevaCaja = abrirCaja(vectorAnterior, vectorActual, RKCaja, paso); //Se abre una caja nueva
                    nuevaCaja.dosisCaja -= 10; //Se descuentan las dosis
                    vectorActual.cajasVacunasGripe.Add(nuevaCaja);
                    cantFaltante -= 10;
                }
                if (cantFaltante != 0)
                {
                    nuevaCaja = abrirCaja(vectorAnterior, vectorActual, RKCaja, paso); //Se abre una caja nueva
                    nuevaCaja.dosisCaja -= cantFaltante; //Se descuentan las dosis
                }
                this.generarFinVacunacion(vectorActual, vectorAnterior.colaGripe); //Genera Fin Vacunacion
                empeladoEvento.estadoEnfermero = "VG"; //Cambio estado enfermero
                foreach (var clieGripe in vectorActual.clientesGrie)
                {
                    if (clieGripe.estadoGripe == "EV")
                    {
                        clieGripe.estadoGripe = "SV";
                        clieGripe.posicionColaGripe = 0;
                        vectorActual.acumuladorTiempoEsperaGripe += vectorActual.reloj - clieGripe.tiempoLlegadaColaGripe;
                        clieGripe.tiempoLlegadaColaGripe = 0;

                    }
                    this.clientesCOVID.Clear();
                vectorActual.cajasVacunasGripe.Add(nuevaCaja);
            }
            vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe + vectorAnterior.colaGripe;
            vectorActual.colaGripe = 0;
            vectorActual.colaCOVID = vectorAnterior.colaCOVID;
            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
            vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
            vectorActual.cantidadNoVacunadosCOVID = vectorAnterior.cantidadNoVacunadosCOVID;
        }
        private CajaVacunas cajaConDosis(VectorSimulacion vectorAnterior)
        {
            foreach (var caja in vectorAnterior.cajasVacunasGripe)
            {
                if (caja.dosisCaja != 0)
                    return caja;
            }
            return new CajaVacunas();
        }
        private CajaVacunas abrirCaja(VectorSimulacion vectorAnterior, VectorSimulacion vectorActual, IRungeKutta RKCaja, double paso)
        {
            CajaVacunas nueva = new CajaVacunas()
            {
                numeroCaja = vectorAnterior.cantidadCajasAbrieron + 1,
                nombreCaja = " - Caja",
                estadoCaja = "Abierta",
                dosisCaja = 10
            };
            vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron + 1;
            vectorActual.vencimientoVac.generarVencimiento(RKCaja, paso, vectorActual, nueva);
            return nueva;
        }
        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.llegadaClientesGripe.RNDLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoEvento = vectorAnterior.llegadaClientesGripe.tiempoEvento;
            vectorActual.llegadaClientesCOVID.RNDLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoEvento = vectorAnterior.llegadaClientesCOVID.tiempoEvento;
            vectorActual.rndCantidad = 0;
            vectorActual.CantidadClientes = 0;
            vectorActual.dosisVencidas = vectorAnterior.dosisVencidas;
            vectorActual.cantidadGripeLlegaronSistema = vectorAnterior.cantidadGripeLlegaronSistema;
            vectorActual.cantidadCOVIDLlegaronSistema = vectorAnterior.cantidadCOVIDLlegaronSistema;
            //vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
        }
    }
}

