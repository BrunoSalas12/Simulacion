using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria
{
    class GeneradorDelLenguaje : IGenerador
    {
        //Se utiliza el metodo provisto por el leguaje para la generacion de los numeros randoms
        Random metodoLenguaje;
        double[] rnd;
        double posicion;
        public GeneradorDelLenguaje()
        {
            metodoLenguaje = new Random();
            rnd = new double[3];
            posicion = 1;
        }
        public double[] generarRandom()
        {
            rnd[0] = posicion;
            double random = metodoLenguaje.NextDouble();
            rnd[2] = Math.Round(random, 2);
            posicion += 1;
            return rnd;
        }
    }
}
