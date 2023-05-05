using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresVariableAleatoria
{
    interface IDistribucion
    {
        //Se utiliza una interfaz para manejar las diferentes distribuciones
        bool validarParametros(string[] parametros);
        double[] generarVariableAleatoria(string[] parametros);
    }
}
