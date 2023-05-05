using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
{
    class DistribucionNormal : IDistribucion
    {
        public int m { get; set; }
        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double varianza, double cero)
        {
            double desviacion = Math.Sqrt(varianza);
            double esperada = ((Normal.CDF(media, desviacion, interv.limiteSuperior)) - (Normal.CDF(media, desviacion, interv.limiteInferior))) * N;
            return Math.Round(esperada, 4);
        }
        public double obtenerEstadistico(double k, double significancia)
        {
            double v = k - 1 - m;
            ChiSquared tabla = new ChiSquared(v);
            return Math.Round((tabla.InverseCumulativeDistribution(significancia)), 4);
        }
    }
}
