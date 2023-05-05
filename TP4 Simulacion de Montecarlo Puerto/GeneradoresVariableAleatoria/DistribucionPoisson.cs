using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria
{
    class DistribucionPoisson : IDistribucion
    {
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado
        private double pos;
        
        public DistribucionPoisson()
        {
            pos = 0;
        }

        public bool validarParametros(string[] parametros)
        {
            //Se validan los parametros para la generacion de la variable aleatoria
            if (parametros[0] == "")
            {
                throw new ApplicationException("Debe ingresar el Lambda");
            }
            double lambda = Convert.ToDouble(parametros[0]);
            if (lambda <= 0)
            {
                throw new ApplicationException("El Lambda no puede ser negativo");
            }
            return true;
        }
        public double[] generarVariableAleatoria(string[] parametros)
        {
            double lamda = Convert.ToDouble(parametros[0]);
            //Se utiliza el algoritmo para la generacion de variables aleatorias de Poisson
            double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
            double p = 1;
            double x = -1;
            double a = Math.Exp(-lamda);
            if (a == 0)
                throw new ApplicationException("El lambda es demasiado grande y por lo tanto e^-lambda da como resultado 0 por lo que se rompe el algoritmo");
            while (p >= a)
            {
                double[] rnd = generador.generarRandom();//Se obtiene el random para el algoritmo para generar la variable
                double u = rnd[2];
                p = p * u;
                x = x + 1;
            }
            varAleat[0] = pos;//Se guarda la posicion de la variable
            varAleat[1] = x;//Se guarda la variable aleatoria obtenida con el algoritmo
            pos++;
            return varAleat;
        }
    }
}
