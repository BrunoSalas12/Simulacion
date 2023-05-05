using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class DistribucionUniforme : IDistribucion
    {
        public double calcularFrecuenciaEsperada(int N, double k)
        {
            double fe = Math.Round((N / k), 4);
            return fe;
        }
        public double obtenerEstadistico(double k, double significancia)
        {
            //Se obtiene el estadistico tabulado para los grados de libertad pertinentes y para una significancia del 0.95 a traves de una funcion del Nuget MathNet
            double v = k - 1;
            ChiSquared tabla = new ChiSquared(v);
            return Math.Round((tabla.InverseCumulativeDistribution(significancia)), 4);
        }
    }
}
