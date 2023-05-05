﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
{
    class DistribucionExponencial : IDistribucion
    {
        public int m { get; set; }
        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double cero, double zero)
        {
            double lamda = 1 / media;
            double esperada = ((Exponential.CDF(lamda, interv.limiteSuperior)) - (Exponential.CDF(lamda,interv.limiteInferior))) * N;
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
