using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class Cliente
    {
        public int numeroCliente { get; set; }
        public string estado { get; set; }
        public int posicionCola { get; set; }
        public double tiempoLlegadaSistema { get; set; }
        public double tiempoLlegadaOficina { get; set; }

        public int columnaSalida { get; set; }
    }
}
