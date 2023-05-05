using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria;

namespace TP3_Generacion_de_Variable_Aleatoria.Modelos
{
    class GeneradorHistograma
    {
        private double max;
        private double min;
        private int cantIntervalos;
        private List<double> listaVariableAlaeatoria;
        private IDistribucion distribucionSeleccionada;
        private List<Intervalo> intervalos;
        private double media;
        private double desvEst;

        public GeneradorHistograma(IDistribucion distSelec, List<double[]> varsAleats, int cantInt, string param1, string param2)
        {
            //Al crearse se llena con todos los datos y las mousekeherramientas que nos ayudaran mas tarde 
            distribucionSeleccionada = distSelec;
            cantIntervalos = cantInt;
            media = Convert.ToDouble(param1);
            if (param2 != "")
            {
                desvEst = Convert.ToDouble(param2);
            }
            else
            {
                desvEst = 0;
            }
            listaVariableAlaeatoria = new List<double>();
            guardarLista(varsAleats);
            obtenerMaximo();
            obtenerMinimo();
        }

        private void guardarLista(List<double[]> varsAleats)
        {
            //Se transforma la lista de vectores en simples doubles para facilitar su manejo y porque nadie quiere a la posicion
            foreach (double[] varAleat in varsAleats)
            {
                double variable = varAleat[1];
                listaVariableAlaeatoria.Add(variable);
            }
        }
        private void obtenerMaximo()
        {
            max = listaVariableAlaeatoria[0];
            foreach (var variable in listaVariableAlaeatoria)
            {
                if (max < variable)
                {
                    max = variable;
                }
            }
        }
        private void obtenerMinimo()
        {
            min = listaVariableAlaeatoria[0];
            foreach (var variable in listaVariableAlaeatoria)
            {
                if (min > variable)
                {
                    min = variable;
                }
            }
        }
        public void generarHistograma()
        {
            //Se realizan los pasos necesarios para poder realizar un histograma
            generarIntervalos();
            obtenerFrecuenciaObservada();
            //obtenerMediaYVarianza();
            calcularFrecuenciaEsperada();
        }

        private void generarIntervalos()
        {
            //La generacion de intervalos depende si es una distribucion continua o discreta, de ahi que se utilce la distribucion seleccionada en este caso
            intervalos = distribucionSeleccionada.generarIntervalos(max, min, cantIntervalos);
        }

        private void obtenerFrecuenciaObservada()
        {
            //Se calculan las frecuencias observadas para cada intervalo
            foreach (var variable in listaVariableAlaeatoria)
            {
                foreach (var interv in intervalos)
                {
                    if (interv.perteneceAIntervalo(variable))//Perteneces a este intervalo pequeña variable?
                    {//si
                        interv.frecuenciaObservada += 1;//entonces sumale uno a este intervalo
                        break;//y deja de comprobar pues no estaras en otro mas
                    }//no
                    //pues a por el siguiente intervalo
                }
            }
        }
        private void calcularFrecuenciaEsperada()
        {
            //Se calculan las frecuencias esperadas, pues se hace directamente la hipotesis de que tendra una distribucion segun la distribucion ya seleccionada para la generacion de las variables
            //raro seria que diera algo completamente diferente, eso seria que esta todo muy mal programado o que el codigo se volvio loco y la variable aleatoria rompio todo
            foreach (Intervalo inter in intervalos)
            {
                //Pues como el calculo de la frecuencia depende de la distribucion se le designa esa noble tarea a la distribucion seleccionada y a su metodo pasandole los parametros necesarios
                inter.frecuenciaEsperada = distribucionSeleccionada.calcularFrecuenciaEsperada(listaVariableAlaeatoria.Count, inter, media, desvEst, cantIntervalos);
            }
        }

        public List<Intervalo> getIntervalos //Para poder trabajar con los intervalos en la carga de datos del grafico y grilla
        {
            get => intervalos;
        }
    }
}
