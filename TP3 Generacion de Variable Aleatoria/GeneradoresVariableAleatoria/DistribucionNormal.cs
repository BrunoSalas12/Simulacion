using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria
{
    class DistribucionNormal : IDistribucion
    {
        public int m { get; set; }//Se guarda la cantidad de datos empiricos que utiliza esta distribucion, en caso de Normal m=2
        public int metodo { get; set; }//metodo 1 es Box-Müeller y el metodo 2 es Convolucional
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado
        private double random1;//Se guardan los randoms necesarios para generar con el metodo de Box-Müler, se hace asi porque si no por algun motivo
        private double random2;//se sobreescribe el valor de rnd1 con el de rnd2 y por lo tanto se rompe todo
        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double desviacion, double cero)
        {
            //Se calcula la frecuencia esperada para un intervalo, en caso de Normal se utiliza el Nuget MathNet para obtener los valores de su funcion de acumulacion (CDF)
            double esperada = ((Normal.CDF(media, desviacion, interv.limiteSuperior)) - (Normal.CDF(media, desviacion, interv.limiteInferior))) * N;
            return Math.Round(esperada, 4);
        }
        public double obtenerEstadistico(double k, double significancia)
        {
            //Se utiliza el Nuget MathNet para obtener el valor tabulado de Chi-Cuadrado
            double v = k - 1 - m;
            if (v <= 0)
                throw new ApplicationException("Grados de libertad negativos o 0 \nGenere mas variables aleatorias para realizar la prueba de Chi-Cuadrado");
            ChiSquared tabla = new ChiSquared(v);
            return Math.Round((tabla.InverseCumulativeDistribution(significancia)), 4);
        }
        public bool validarParametros(string[] parametros)
        {
            //Se validan los parametros para la generacion de la variable aleatoria
            if (parametros[0] == "" || Convert.ToInt32(parametros[0]) <= 0)
            {
                throw new ApplicationException("Debe ingresar la cantidad a generar");
            }
            if (parametros[1] == "")
            {
                throw new ApplicationException("Debe ingresar la media");
            }
            if (parametros[2] == "")
            {
                throw new ApplicationException("Debe ingresar la desviacion estandar");
            }
            return true;
        }
        public List<double[]> generarVariablesAleatorias(string[] parametros, PantallaVariableAleatoria pgb)
        {
            //Se realiza la generacion de la lista de variables aleatorias
            PantallaVariableAleatoria progressBar = pgb;
            long cantidad = Convert.ToInt64(parametros[0]);
            double media = Convert.ToDouble(parametros[1]);
            double desvEst = Convert.ToDouble(parametros[2]);
            List<double[]> listaVariables = new List<double[]>();
            //Se verifica el metodo seleccionado
            if (metodo == 1)//Box-Müller
            {
                //Se realiza el metodo para la generacion de una variable aleatoria Normal(media,desvEst)
                for (int i = 0; i < cantidad; i++)
                {
                    double[] rnd1 = generador.generarRandom();//Se obtiene el primer random para la generacion de la variable
                    random1 = rnd1[2];//Se guarda para que no se sobreescriba
                    double[] rnd2 = generador.generarRandom();//Se obtiene el segundo random para la generacion de la variable
                    random2 = rnd2[2];//Se guarda para que no se sobreescriba
                    double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
                    varAleat[0] = i+1;//Se guarda la posicion de la variable
                    varAleat[1] = Math.Round(( ( Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2) ) * desvEst + media), 4);//Se realiza el calculo de la variable
                                                                                                                                            //con la priemra formula de Box-Müller y se guarda
                    listaVariables.Add(varAleat);//Se carga la variable en la lista de variables
                    progressBar.progressBar(i);
                    i++;//Se cuenta la generacion de la primera variable
                    if (i < cantidad)//Se verifica si todas las variables han sido generadas
                    {
                        //Se realiza el calculo de la siguiente variable con los mismos randoms generados anteriormente pero con la siguiente formula
                        double[] varAleat2 = new double[2];//Se utiliza otro vector para guardar la posicion[0] y la variable[1] porque patata (los secretos de la programacion estan mas alla de nuestro entendimiento)
                        varAleat2[0] = i + 1;//Se guarda la posicion de la variable
                        varAleat2[1] = Math.Round(((Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2)) * desvEst + media), 4);//Se realiza el calculo de la variable
                                                                                                                                            //con la segunda formula de Box-Müller y se guarda
                        listaVariables.Add(varAleat2);//Se carga la variable en la lista de variables
                        progressBar.progressBar(i);
                    }
                }
                return listaVariables;
            }
            else if (metodo == 2)//Convolucional
            {
                //Se realiza el metodo para la generacion de una variable aleatoria Normal(media,desvEst)
                for (int i = 0; i < cantidad; i++)
                {
                    double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
                    double suma = 0;//Se utiliza para la sumatoria
                    for (int j = 0; j < 12; j++)
                    {
                        double[] rnd = generador.generarRandom();//Se obtiene el random para la generacion de la variable
                        suma += rnd[2];//y se suma su valor a la sumatoria
                    }
                    varAleat[0] = i+1;//Se guarda la posicion de la variable
                    varAleat[1] = Math.Round(((suma - 6) * desvEst + media), 4);//Se realiza el calculo de la variable con la formula del metodo Convolucional y se guarda
                    listaVariables.Add(varAleat);//Se carga la variable en la lista de variables
                    progressBar.progressBar(i);
                }
                return listaVariables;

            }
            return listaVariables;
        }
        public List<Intervalo> generarIntervalos(double max, double min, int cantIntervalos)
        {
            //Se generan los intervalos para una distribucion continua
            double tamañoInt = (max - min) / cantIntervalos;
            double limite = min;
            List<Intervalo> intervalos = new List<Intervalo>();
            for (int i = 0; i < cantIntervalos; i++)
            {
                //Se crean los intervalos y se les asigna los valores de sus limites inferior y superior y se calcula su marca de clase
                Intervalo interv = new Intervalo();
                interv.limiteInferior = Math.Round(limite, 4);
                limite += tamañoInt;
                interv.limiteSuperior = Math.Round(limite, 4);
                if (i == cantIntervalos - 1)
                {
                    //Al ultimo intervalo se le suma 0,0001 para que la variable con el valor maximo este dentro de este, ya que en el calculo de pertenencia se utiliza < para el limite superior
                    interv.limiteSuperior = Math.Round((max + 0.0001), 4);
                }
                interv.calcularMarcaDeClase();
                intervalos.Add(interv);
            }
            return intervalos;
        }
    }
}
