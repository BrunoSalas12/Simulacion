using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    interface IDistribucion
    {
        double calcularFrecuenciaEsperada(int N, double k);
        double obtenerEstadistico(double k, double significancia);
    }
}
