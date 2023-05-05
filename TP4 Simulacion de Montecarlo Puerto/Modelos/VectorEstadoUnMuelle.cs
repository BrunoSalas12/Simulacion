using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.Modelos
{
    class VectorEstadoUnMuelle
    {
        public long iteracion { get; set; }
        public double RNDLlegada { get; set; }
        public int cantLlegadas { get; set; }
        public double RNDDescargas { get; set; }
        public int cantDescargas { get; set; }
        public long barcosPendientes { get; set; }
        public long barcosDescConRet { get; set; }
        public long diasMuelleOcupado { get; set; }
        public double porcentajeOcupacionMuelle { get; set; }
        public double gananciasDescargaBarcos { get; set; }
        public double costosBarcosPendientes { get; set; }
        public double costosMuelleVacio { get; set; }
        public double utilidadesTotales { get; set; }
        public double utilidadesAcumuladas { get; set; }

    }
}
