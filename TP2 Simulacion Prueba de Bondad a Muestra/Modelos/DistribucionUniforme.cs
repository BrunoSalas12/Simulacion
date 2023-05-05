using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
{
    class DistribucionUniforme : IDistribucion
    {
        public int m { get; set; }
        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double zero, double cero, double cantInt)
        {
            double esperada = Math.Round((N / cantInt), 4);
            return esperada;
        }
        public double obtenerEstadistico(double k, double significancia)
        {
            double v = k - 1 - m;
            ChiSquared tabla = new ChiSquared(v);
            return Math.Round((tabla.InverseCumulativeDistribution(significancia)), 4);
        }
    }
}
