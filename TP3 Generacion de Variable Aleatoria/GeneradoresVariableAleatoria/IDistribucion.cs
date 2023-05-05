using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria
{
    interface IDistribucion
    {
        //Se utiliza una interfaz para manejar las diferentes distribuciones
        double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double desvEst, double cantInt);
        double obtenerEstadistico(double k, double significancia);
        bool validarParametros(string[] parametros);
        List<double[]> generarVariablesAleatorias(string[] parametros, PantallaVariableAleatoria progressBar);
        List<Intervalo> generarIntervalos(double max, double min, int cantIntervalos);
    }
}
