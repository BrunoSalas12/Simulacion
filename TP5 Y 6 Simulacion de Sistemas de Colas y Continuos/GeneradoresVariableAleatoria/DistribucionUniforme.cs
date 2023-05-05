using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresVariableAleatoria
{
    class DistribucionUniforme : IDistribucion
    {
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado

        public bool validarParametros(string[] parametros)
        {
            //Se validan los parametros para la generacion de la variable aleatoria
            if (parametros[0] == "")
            {
                throw new ApplicationException("Debe ingresar el parametro 'a'");
            }
            if (parametros[1] == "") 
            {
                throw new ApplicationException("Debe ingresar el parametro 'b'");
            }
            double a = Convert.ToDouble(parametros[0]);
            double b = Convert.ToDouble(parametros[1]);
            if (b <= a)
            {
                throw new ApplicationException("El parametro 'b' no puede ser menor al parametro 'a'");
            }
            return true;
        }
        public double[] generarVariableAleatoria(string[] parametros)
        {
            double a = Convert.ToDouble(parametros[0]);
            double b = Convert.ToDouble(parametros[1]);
            //Se realiza el metodo para la generacion de una variable aleatoria Uniforme(a,b)
            double[] rnd = generador.generarRandom();//Se obtiene el random para generar la variable
            double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
            varAleat[0] = rnd[0];//Se guarda la posicion de la variable
            varAleat[1] = Math.Round((a + (rnd[2] * (b - a))), 0);//Se realiza el calculo de la variable con la formula de Uniforme y se guarda
            return varAleat;
        }
    }
}
