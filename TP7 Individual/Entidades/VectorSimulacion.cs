using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class VectorSimulacion
    {
        public VectorSimulacion()
        {
            enfemeros = new List<Enfermero>();
            finVacunacion = new List<EventoFinVacunacion>();
            clientesGrie = new List<ClienteGripe>();
            clientesCOVID = new List<ClienteCOVID>();
            cajasVacunasGripe = new List<CajaVacunas>();
        }
        public string evento { get; set; } //Nombre del evento
        public double reloj { get; set; } //Tiempo de simulacion

        //Evento de Llegada Cliente
        public EventoLlegadaGripe llegadaClientesGripe { get; set; }
        public EventoLlegadaCOVID llegadaClientesCOVID { get; set; }
        public double rndCantidad { get; set; }
        public double CantidadClientes { get; set; }


        //Evento Fin Vacunacion
        public double tiempoVacunacion { get; set; }
        public List<EventoFinVacunacion> finVacunacion { get; set; }

        //Evento Vencimiento Vacunas
        public EventoVencimientoVac vencimientoVac { get; set; }
        public double cantidadCajasAbrieron { get; set; }

        //Objetos permanenetas
        public List<Enfermero> enfemeros { get; set; }
        public double colaGripe { get; set; }
        public double colaCOVID { get; set; }

        //Estadisticas
        public double dosisVencidas { get; set; }
        public double cantidadVacunadosGripe { get; set; }
        public double cantidadNoVacunadosCOVID { get; set; }
        public double porcentajeClientesGripe { get; set; }
        public double porcentajeClientesCOVID { get; set; }
        public double cantidadGripeLlegaronSistema { get; set; }
        public double cantidadCOVIDLlegaronSistema { get; set; }
        public double tiempoPromedioEsperaGripe { get; set; }
        public double acumuladorTiempoEsperaGripe { get; set; }
        public double cantidadEsperaronGripe { get; set; }
        public double tiempoPromedioEsperaCOVID { get; set; }
        public double acumuladorTiempoEsperaCOVID { get; set; }
        public double cantidadEsperaronCOVID { get; set; }


        //Objetos temporales
        public List<ClienteGripe> clientesGrie { get; set; }
        public List<ClienteCOVID> clientesCOVID { get; set; }
        public List<CajaVacunas> cajasVacunasGripe { get; set; }
    }
}
