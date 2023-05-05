using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
{
    interface IDistribucion
    {
        double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double varianza, double cantInt);
        double obtenerEstadistico(double k, double significancia);
    }
}
