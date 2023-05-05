using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class ClienteGripe
    {
        public double numeroGripe { get; set; }
        public string nombreGripe { get; set; }
        public string estadoGripe { get; set; }
        public double posicionColaGripe { get; set; }
        public double tiempoLlegadaColaGripe { get; set; }
        public int columnaSalida { get; set; }
    }
}
