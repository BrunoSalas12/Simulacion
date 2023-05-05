using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria
{
    class DistribucionUniforme : IDistribucion
    {
        public int m { get; set; }//Se guarda la cantidad de datos empiricos que utiliza esta distribucion, en caso de Uniforme m=0
        public IGenerador generador { get; set; }//Se guarda el generador seleccionado

        public double calcularFrecuenciaEsperada(int N, Intervalo interv, double zero, double cero, double cantInt)
        {
            //Se calcula la frecuencia esperada para un intervalo, en caso de Uniforme se utiliza la cantidad de nuemros sobre la cantidad de intervalos, todos los intervalos iguales
            double esperada = Math.Round((N / cantInt), 4);
            return esperada;
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
                throw new ApplicationException("Debe ingresar el parametro 'a'");
            }
            if (parametros[2] == "") 
            {
                throw new ApplicationException("Debe ingresar el parametro 'b'");
            }
            double a = Convert.ToDouble(parametros[1]);
            double b = Convert.ToDouble(parametros[2]);
            if (b <= a)
            {
                throw new ApplicationException("El parametro 'b' no puede ser menor al parametro 'a'");
            }
            return true;
        }
        public List<double[]> generarVariablesAleatorias(string[] parametros, PantallaVariableAleatoria pgb)
        {
            //Se realiza la generacion de la lista de variables aleatorias
            PantallaVariableAleatoria progressBar = pgb;
            long cantidad = Convert.ToInt64(parametros[0]);
            double a = Convert.ToDouble(parametros[1]);
            double b = Convert.ToDouble(parametros[2]);
            List<double[]> listaVariables = new List<double[]>();
            //Se realiza el metodo para la generacion de una variable aleatoria Uniforme(a,b)
            for (int i = 0; i < cantidad; i++)
            {
                double[] rnd = generador.generarRandom();//Se obtiene el random para generar la variable
                double[] varAleat = new double[2];//Se utiliza un vector para guardar la posicion[0] y la variable[1]
                varAleat[0] = rnd[0];//Se guarda la posicion de la variable
                varAleat[1] = Math.Round((a + (rnd[2] * (b - a))), 4);//Se realiza el calculo de la variable con la formula de Uniforme y se guarda
                listaVariables.Add(varAleat);//Se carga la variable en la lista de variables
                progressBar.progressBar(i);
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
