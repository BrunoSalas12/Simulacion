using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresVariableAleatoria
{
    class DistribucionNormal : IDistribucion
    {
        private long pos;
        public int metodo { get; set; }//metodo 1 es Box-Müeller y el metodo 2 es Convolucional
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado
        private double random1;//Se guardan los randoms necesarios para generar con el metodo de Box-Müler, se hace asi porque si no por algun motivo
        private double random2;//se sobreescribe el valor de rnd1 con el de rnd2 y por lo tanto se rompe todo

        private int bmUnoODos;

        public DistribucionNormal()
        {
            pos = 0;
            bmUnoODos = 1;
        }
        public bool validarParametros(string[] parametros)
        {
            //Se validan los parametros para la generacion de la variable aleatoria
            if (parametros[0] == "")
            {
                throw new ApplicationException("Debe ingresar la media");
            }
            if (parametros[1] == "")
            {
                throw new ApplicationException("Debe ingresar la desviacion estandar");
            }
            int intento1 = Convert.ToInt32(parametros[0]);
            int intento2 = Convert.ToInt32(parametros[1]);
            return true;
        }
        public double[] generarVariableAleatoria(string[] parametros)
        {
            double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
            double media = Convert.ToDouble(parametros[0]);
            double desvEst = Convert.ToDouble(parametros[1]);
            //Se verifica el metodo seleccionado
            if (metodo == 1)//Box-Müller
            {
                //Se realiza el metodo para la generacion de una variable aleatoria Normal(media,desvEst)
                if (bmUnoODos == 1)
                {
                    double[] rnd1 = generador.generarRandom();//Se obtiene el primer random para la generacion de la variable
                    random1 = rnd1[2];//Se guarda para que no se sobreescriba
                    double[] rnd2 = generador.generarRandom();//Se obtiene el segundo random para la generacion de la variable
                    random2 = rnd2[2];//Se guarda para que no se sobreescriba

                    varAleat[0] = pos;//Se guarda la posicion de la variable
                    varAleat[1] = Math.Round(((Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2)) * desvEst + media), 2);//Se realiza el calculo de la variable
                                                                                                                                           //con la priemra formula de Box-Müller y se guarda
                    bmUnoODos = 2;
                    pos++;
                    return varAleat;
                }
                if (bmUnoODos == 2)
                {
                    //Se realiza el calculo de la siguiente variable con los mismos randoms generados anteriormente pero con la siguiente formula
                    varAleat[0] = pos;//Se guarda la posicion de la variable
                    varAleat[1] = Math.Round(((Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2)) * desvEst + media), 2);//Se realiza el calculo de la variable
                                                                                                                                           //con la segunda formula de Box-Müller y se guarda
                    bmUnoODos = 1;
                    pos++;
                    return varAleat;
                }
            }
            else if (metodo == 2)//Convolucional
            {
                //Se realiza el metodo para la generacion de una variable aleatoria Normal(media,desvEst)
                double suma = 0;//Se utiliza para la sumatoria
                for (int j = 0; j < 12; j++)
                {
                    double[] rnd = generador.generarRandom();//Se obtiene el random para la generacion de la variable
                    suma += rnd[2];//y se suma su valor a la sumatoria
                }
                varAleat[0] = pos;//Se guarda la posicion de la variable
                varAleat[1] = Math.Round(((suma - 6) * desvEst + media), 2);//Se realiza el calculo de la variable con la formula del metodo Convolucional y se guarda
                pos++;
                return varAleat;
            }
            else
            {
                throw new ApplicationException("Metodo de generacion de variable Normal incorrectamente definido");
            }
            return varAleat;
        }
    }
}
