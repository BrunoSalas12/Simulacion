using Runge_Kutta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class EventoVencimientoVac
    {
        public string nombreEvento { get; set; }
        public double tiempoVencimiento { get; set; }
        public double tiempoEvento { get; set; }
        public CajaVacunas cajaVencimiento { get; set; }

        public void generarVencimiento(IRungeKutta rkVenc, double paso, VectorSimulacion vectorActual, CajaVacunas caja)
        {
            nombreEvento = "Vencimiento Vac";
            tiempoVencimiento = rkVenc.obtenerTiempo(0, 0.076, paso);
            tiempoEvento = tiempoVencimiento + vectorActual.reloj;
            cajaVencimiento = caja;
        }

        public void ejecutarEvento(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior, List<int> numerosDeColOcups)
        {
            vectorActual.dosisVencidas = vectorAnterior.dosisVencidas + cajaVencimiento.dosisCaja;
            numerosDeColOcups.Remove(cajaVencimiento.columnaSalida);
            vectorActual.cajasVacunasGripe.Remove(cajaVencimiento);
            this.tiempoVencimiento = 0;
            this.tiempoEvento = 0;
            copiarCosasNoCambiadas(vectorActual,vectorAnterior);
        }
        private void copiarCosasNoCambiadas(VectorSimulacion vectorActual, VectorSimulacion vectorAnterior)
        {
            vectorActual.llegadaClientesGripe.RNDLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoLlegada = 0;
            vectorActual.llegadaClientesGripe.tiempoEvento = vectorAnterior.llegadaClientesGripe.tiempoEvento;
            vectorActual.llegadaClientesCOVID.RNDLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoLlegada = 0;
            vectorActual.llegadaClientesCOVID.tiempoEvento = vectorAnterior.llegadaClientesCOVID.tiempoEvento;
            vectorActual.tiempoVacunacion = 0;
            vectorActual.rndCantidad = 0;
            vectorActual.CantidadClientes = 0;
            vectorActual.cantidadCajasAbrieron = vectorAnterior.cantidadCajasAbrieron;
            vectorActual.colaGripe = vectorAnterior.colaGripe;
            vectorActual.colaCOVID = vectorAnterior.colaCOVID;
            vectorActual.cantidadVacunadosGripe = vectorAnterior.cantidadVacunadosGripe;
            vectorActual.cantidadNoVacunadosCOVID = vectorAnterior.cantidadNoVacunadosCOVID;
            vectorActual.cantidadGripeLlegaronSistema = vectorAnterior.cantidadGripeLlegaronSistema;
            vectorActual.cantidadCOVIDLlegaronSistema = vectorAnterior.cantidadCOVIDLlegaronSistema;
            vectorActual.acumuladorTiempoEsperaGripe = vectorAnterior.acumuladorTiempoEsperaGripe;
            vectorActual.cantidadEsperaronGripe = vectorAnterior.cantidadEsperaronGripe;
            vectorActual.acumuladorTiempoEsperaCOVID = vectorAnterior.acumuladorTiempoEsperaCOVID;
            vectorActual.cantidadEsperaronCOVID = vectorAnterior.cantidadEsperaronCOVID;
        }
    }
}
