using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria
{
    class DistribucionExponencial : IDistribucion
    {
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado

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
            double lambda = Convert.ToDouble(parametros[0]);
            //Se realiza el metodo para la generacion de una variable aleatoria Exponencial(lambda)
            double[] rnd = generador.generarRandom();//Se obtiene el random para generar la variable
            double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
            varAleat[0] = rnd[0];//Se guarda la posicion de la variable
            varAleat[1] = Math.Round(((-1 / lambda) * (Math.Log(1 - rnd[2]))), 2);//Se realiza el calculo de la variable con la formula de Exponencial y se guarda
            return varAleat;
        }
    }
}
