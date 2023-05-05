using GeneradoresVariableAleatoria;
using Runge_Kutta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class EventoLlegadaGripe
    {
        public string nombreEvento { get; set; }
        public double RNDLlegada { get; set; }
        public double tiempoLlegada { get; set; }
        public double tiempoEvento { get; set; }
        public EventoLlegadaGripe()
        {
            nombreEvento = "Llegada Gripe";
        }

        public void generarTiempoLlegada(IDistribucion dist, string[] ps, VectorSimulacion vectorActual)
        {
            nombreEvento = "Llegada Gripe";
            double[] varAleat = dist.generarVariableAleatoria(ps);
            RNDLlegada = varAleat[0];
            tiempoLlegada = varAleat[1];
            tiempoEvento = Math.Round(vectorActual.reloj + tiempoLlegada, 2);
        }

        public void ejecutarEvento(IDistribucion distGripe, string[] paramsGripe,IDistribucion distCant, string[] paramsCant, VectorSimulacion vectorActual, VectorSimulacion vectorAnterior, IRungeKutta RKCaja, double paso)
        {
            this.generarTiempoLlegada(distGripe, paramsGripe, vectorActual);
            double[] varAletaCant = distCant.generarVariableAleatoria(paramsCant);
            vectorActual.rndCantidad = varAletaCant[0];
            vectorActual.CantidadClientes = Math.Truncate(varAletaCant[1]);
            List<ClienteGripe> clientesNuevos = new List<ClienteGripe>();

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
                if (vectorActual.cajasVacunasGripe.Count >= 1) //Pregunta si hay caja abierta
                {//Si hay caja abierta
                    CajaVacunas cajaVac = cajaConDosis(vectorAnterior);
                    if (cajaVac.dosisCaja >= vectorActual.CantidadClientes) //Pregunta si hay suficientes dosis en esa caja
                    {//Si hay suficientes dosis

                        cajaVac.dosisCaja -= vectorActual.CantidadClientes; //Resta dosis
                        ev.generarFinVacunacion(vectorActual, vectorActual.CantidadClientes); //Genera Fin Vacunacion
                        emp.estadoEnfermero = "VG"; //Cambio estado enfermero
                        for (int i = 0; i < vectorActual.CantidadClientes; i++) //Crea los Clientes
                        {
                            ClienteGripe clie = new ClienteGripe();
                            clie.numeroGripe = vectorAnterior.cantidadGripeLlegaronSistema + 1 + i;
                            clie.nombreGripe = " - Gripe";
                            clie.estadoGripe = "SV";
                            clie.posicionColaGripe = 0;
                            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID + 0;
                            clientesNuevos.Add(clie);
                        }
                        ev.clientesGripe = clientesNuevos;
                        ev.clientesCOVID.Clear();
                        vectorActual.clientesGrie.AddRange(clientesNuevos);
                        vectorActual.vencimientoVac.tiempoVencimiento = 0;
                        vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
                        vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
                        vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
                    }
                    else
                    {//No hay suficientes dosis
                        CajaVacunas nuevaCaja = new CajaVacunas();
                        double cantFaltante = vectorActual.CantidadClientes - cajaVac.dosisCaja;
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
                        ev.generarFinVacunacion(vectorActual, vectorActual.CantidadClientes); //Genera Fin Vacunacion
                        emp.estadoEnfermero = "VG"; //Cambio estado enfermero
                        for (int i = 0; i < vectorActual.CantidadClientes; i++) //Crea los Clientes
                        {
                            ClienteGripe clie = new ClienteGripe();
                            clie.numeroGripe = vectorAnterior.cantidadGripeLlegaronSistema + 1 + i;
                            clie.nombreGripe = " - Gripe";
                            clie.estadoGripe = "SV";
                            clie.posicionColaGripe = 0;
                            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID + 0;
                            clientesNuevos.Add(clie);
                        }
                        ev.clientesGripe = clientesNuevos;
                        ev.clientesCOVID.Clear();
                        vectorActual.clientesGrie.AddRange(clientesNuevos);
                        vectorActual.cajasVacunasGripe.Add(nuevaCaja);
                    }                    
                }
                else
                {//No hay caja abierta
                    CajaVacunas nuevaCaja = abrirCaja(vectorAnterior, vectorActual, RKCaja, paso); //Se abre una caja nueva
                    nuevaCaja.dosisCaja -= vectorActual.CantidadClientes; //Se descuentan las dosis
                    ev.generarFinVacunacion(vectorActual, vectorActual.CantidadClientes); //Genera Fin Vacunacion
                    emp.estadoEnfermero = "VG"; //Cambio estado enfermero
                    for (int i = 0; i < vectorActual.CantidadClientes; i++) //Crea los Clientes
                    {
                        ClienteGripe clie = new ClienteGripe();
                        clie.numeroGripe = vectorAnterior.cantidadGripeLlegaronSistema + 1 + i;
                        clie.nombreGripe = " - Gripe";
                        clie.estadoGripe = "SV";
                        clie.posicionColaGripe = 0;
                        clientesNuevos.Add(clie);
                    }
                    ev.clientesGripe = clientesNuevos;
                    ev.clientesCOVID.Clear();
                    vectorActual.clientesGrie.AddRange(clientesNuevos);
                    vectorActual.cajasVacunasGripe.Add(nuevaCaja);
                }
                vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe + vectorActual.CantidadClientes;
                vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
                vectorActual.colaGripe = vectorAnterior.colaGripe;
            }
            else //No hay enfermero libre
            {
                for (int i = 0; i < vectorActual.CantidadClientes; i++)
                {
                    ClienteGripe clie = new ClienteGripe();
                    clie.numeroGripe = vectorAnterior.cantidadGripeLlegaronSistema + 1 + i;
                    clie.nombreGripe = " - Gripe";
                    clie.estadoGripe = "EV";
                    clie.posicionColaGripe = vectorAnterior.colaGripe + 1 + i;
                    clie.tiempoLlegadaColaGripe = vectorActual.reloj;
                    clientesNuevos.Add(clie);
                }
                vectorActual.colaGripe = vectorAnterior.colaGripe + vectorActual.CantidadClientes;
                vectorActual.clientesGrie.AddRange(clientesNuevos);
                vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe;
                vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
                vectorActual.tiempoVacunacion = 0;
                vectorActual.vencimientoVac.tiempoVencimiento = 0;
                vectorActual.vencimientoVac.tiempoEvento = vectorAnterior.vencimientoVac.tiempoEvento;
                vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
                vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
            }
            vectorActual.cantidadGripeLlegaronSistema = vectorAnterior.cantidadGripeLlegaronSistema + vectorActual.CantidadClientes;
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
            vectorActual.llegadaClientesCOVID.RNDLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoEvento = vectorAnterior.llegadaClientesCOVID.tiempoEvento;
            vectorActual.cantidadCOVIDLlegaronSistema = vectorAnterior.cantidadCOVIDLlegaronSistema;
            vectorActual.colaCOVID = vectorAnterior.colaCOVID;
            vectorActual.dosisVencidas = vectorAnterior.dosisVencidas;
            vectorActual.cantidadVacunadosGripe = vectorAnterior.cantidadVacunadosGripe;
            vectorActual.cantidadNoVacunadosCOVID = vectorAnterior.cantidadNoVacunadosCOVID;
            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
            vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
            //vectorActual.vencimientoVac.cajaVencimiento = vectorAnterior.vencimientoVac.cajaVencimiento;
        }
    }
}
