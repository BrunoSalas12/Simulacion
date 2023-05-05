using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria
{
    interface IGenerador
    {
        //Se utiliza una interfaz para manejar los diferentes generadores
        double[] generarRandom();
    }
}
