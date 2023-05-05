using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria
{
    class DistribucionPoisson : IDistribucion
    {
        public int m { get; set; }//Se guarda la cantidad de datos empiricos que utiliza esta distribucion, en caso de Poisson m=1
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado
        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double media, double cero, double zero)
        {
            //Se calcula la frecuencia esperada para un intervalo, en caso de Poisson se utiliza la funcion de densidad para cada valor de X
            double lamda = media;
            double esperada = ( ( (Math.Pow(lamda,interv.limiteInferior)) * (Math.Exp(-lamda)) ) / (factorial(interv.limiteInferior)) ) * N;
            return Math.Round(esperada, 4);
        }
        private double factorial(double x)
        {
            //Calculo del factorial para la funcion de densidad
            if (x == 0 || x == 1)
                return 1;
            return x * factorial(x - 1);
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
                throw new ApplicationException("Debe ingresar el Lambda");
            }
            double lambda = Convert.ToDouble(parametros[1]);
            if (lambda <= 0)
            {
                throw new ApplicationException("El Lambda no puede ser negativo");
            }
            return true;
        }
        public List<double[]> generarVariablesAleatorias(string[] parametros, PantallaVariableAleatoria pgb)
        {
            //Se realiza la generacion de la lista de variables aleatorias
            PantallaVariableAleatoria progressBar = pgb;
            long cantidad = Convert.ToInt64(parametros[0]);
            double lamda = Convert.ToDouble(parametros[1]);
            List<double[]> listaVariables = new List<double[]>();
            //Se utiliza el algoritmo para la generacion de variables aleatorias de Poisson
            for (int i = 0; i < cantidad; i++)
            {
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
                varAleat[0] = i+1;//Se guarda la posicion de la variable
                varAleat[1] = x;//Se guarda la variable aleatoria obtenida con el algoritmo
                listaVariables.Add(varAleat);//Se añade la variable a la lista de variables
                progressBar.progressBar(i);
            }
            return listaVariables;
        }
        public List<Intervalo> generarIntervalos(double max, double min, int cantIntervalos)
        {
            //Se generan los intervalos para una distribucion discreta
            double limite = min;
            double cantidadInterv = max - min + 1;
            List<Intervalo> intervalos = new List<Intervalo>();
            for (int i = 0; i < cantidadInterv; i++)
            {
                //Se crean los intervalos y se les asigna los valores de sus limites inferior y superior y se calcula su marca de clase
                Intervalo interv = new Intervalo();
                interv.limiteInferior = Math.Round(limite, 4);
                interv.limiteSuperior = Math.Round(limite+0.0001, 4);//A los limites superiores se les suma 0.0001 ya que en el calculo de pertenencia se utiliza < para el limite superior
                                                                     //y con esto se consigue que el valor entre en el intervalo, no afecta a ningun calulo pues no se uttiliza
                limite += 1;
                interv.calcularMarcaDeClase();
                intervalos.Add(interv);
            }
            return intervalos;
        }
    }
}
