using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class VectorSimulacion
    {
        public VectorSimulacion()
        {
            finCaseta = new List<EventoFinCaseta>();
            finRevision = new List<EventoFinRevision>();
            finOficina = new List<EventoFinOficina>();
            EmpleadosCaseta = new List<EmpleadoCaseta>();
            CircuitosRevision = new List<CircuitoRevision>();
            EmpleadosOficina = new List<EmpleadoOficina>();
            Clientes = new List<Cliente>();
        }

        public string evento { get; set; } //Nombre del evento
        public double reloj { get; set; } //Tiempo de simulacion

        //Evento de Llegada Cliente
        public EventoLlegadaCliente llegadaCliente { get; set; }

        //Eventos del Bloqueo
        public EventoLlegadaBloqueo llegadaBloqueo { get; set; }
        public EventoFinBloqueo finBloqueo { get; set; }

        //Evento de Fin Caseta
        //public double RNDCaseta { get; set; }
        //public double tiempoCaseta { get; set; }
        //Esto se mete dentro de cada evento puesto que puede haber varios al mismo momento
        public List<EventoFinCaseta> finCaseta { get; set; }

        //Evento de Fin Revision
        public double RNDRevision { get; set; }
        public double tiempoRevision { get; set; }
        public List<EventoFinRevision> finRevision { get; set; }

        //Evento de Fin Oficina
        public double RNDOficina { get; set; }
        public double tiempoOficina { get; set; }
        public List<EventoFinOficina> finOficina { get; set; }
        public double tiempoRestanteOficinaBloqueada { get; set; }

        //Objetos Permanentes
        public Bloqueo empleadoBloqueo { get; set; }
        public int colaBloqueo { get; set; }
        public List<EmpleadoCaseta> EmpleadosCaseta { get; set; }
        public int colaCaseta { get; set; }
        public List<CircuitoRevision> CircuitosRevision { get; set; }
        public int colaRevision { get; set; }
        public List<EmpleadoOficina> EmpleadosOficina { get; set; }
        public int colaOficina { get; set; }
        
        //Estadisticas
        public double longitudPromedioColaRevision { get; set; } //Aqui se guarda el resultado de la division del contador por el tiempo de la simulacion
        public int contadorClientesEnColaRevision { get; set; } //Se cuentan los clientes que pasan por la cola de la revision

        public double tiempoPromedioQuePasanEnLaOficina { get; set; } //Aqui se guarda el resutado de la division del acumulador por el contador
        public double acumuladorDeTiemposDeOficina { get; set; } //Se acumula el tiempo que los clientes pasaron en la oficina, cola y atencion incluidos
        
        public double tiempoPromedioEnElSistema { get; set; } //Aqui se guarda el resultado de la division del acumulador por el contador
        public double acumuladorTiemposEnSistema { get; set; } //Se acumula el tiempo que pasaron los clientes en el sistema

        public int contadorClientesOficinaYSistema { get; set; } //Se cuentan los clientes que terminaron su paso, fin atencion, por la oficina y que por ende salieron del sistema y por lo tanto es el mismo acumulador

        public int cantidadGenteIngresoAlSistema { get; set; } //Se cuenta la gente que logro ingresar al sistema (A)
        public double cantidadGenteNoAtendida { get; set; } //Se cuenta la cantidad de gente que no pudo ingresar al sistema por estar la cola llena (B)
        public double porcentajeClientesNoAtendidos { get; set; } //Aqui se guarda el resultado de B/(A+B)

        //El porcentaje de ocupacion de los servidores de la caseta y la oficina lo manejan esos objetos

        public double tiempoColaDeCasetaLlena { get; set; } //Aqui se guarda la acumulacion de tiempos en la que la cola de caseta es igual a 15
        public int longitudMaximaColaCaseta { get; set; } //Aqui se guarda el maximo valor alcanzado por la cola de la caseta
        public int longitudMaximaColaRevision { get; set; } //Aqui se guarda el maximo valor alcanzado por la cola de revision
        public int longitudMaximaColaOficina { get; set; } //Aqui se guarda el maximo valor alcanzado por la cola de revision

        //Objetos Temporales
        public List<Cliente> Clientes { get; set; } 
    }
}
