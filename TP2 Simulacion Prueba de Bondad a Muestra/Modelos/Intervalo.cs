using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
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
            marcaDeClase = Math.Round(((limiteInferior + limiteSuperior) / 2), 4);
        }
    }
}
