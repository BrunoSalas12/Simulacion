using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Generacion_de_Variable_Aleatoria.Modelos
{
    class Intervalo
    {
        public double limiteInferior { get; set; }
        public double limiteSuperior { get; set; }
        public double frecuenciaEsperada { get; set; }
        public double frecuenciaObservada { get; set; }
        public double marcaDeClase { get; set; }
        public double estadisticoIntervalo { get; set; }
        public double estadisticoAcumulado { get; set; }
        public double probabilidadObservada { get; set; }
        public double probabilidadEsperada { get; set; }

        public bool perteneceAIntervalo(double rnd)
        {
            //Se prueba si el random pasado por parametro pertenece a este intervalo
            if (rnd >= limiteInferior && rnd < limiteSuperior)//al utilizarse < con el limite superior no se contabiliza como dentro de este intervalo al valor del limite
            {
                return true;
            }
            return false;
        }
        public void calcularMarcaDeClase()
        {
            //Se calcula la marca de clase con los limites de este intervalo
            marcaDeClase = Math.Round(((limiteInferior + limiteSuperior) / 2), 4);
        }
        public bool frecEspMenorA5()
        {
            //Se comprueba si este intervalo tiene una frecuencia esperada menor a 5
            if (frecuenciaEsperada < 5)
            {
                return true;
            }
            return false;
        }
    }
}
