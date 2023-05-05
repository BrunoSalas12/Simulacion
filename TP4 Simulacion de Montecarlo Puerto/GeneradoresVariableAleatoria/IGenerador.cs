using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria
{
    interface IGenerador
    {
        //Se utiliza una interfaz para manejar los diferentes generadores
        double[] generarRandom();
    }
}
