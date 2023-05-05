using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulacion_Prueba_de_Bondad_a_Muestra.Modelos
{
    class PruebaChiCuadrado
    {
        private int minimo;
        private int maximo;
        private double cantidadIntervalos;
        private double[] muestra;
        private IDistribucion distribucionSeleccionada;
        private List<Intervalo> intervalos;
        private double estadisticoCalculado;
        private double estadisticoTabulado;
        private double media;
        private double varianza;
        public PruebaChiCuadrado(int min, int max, int cantInt, double[] muest)
        {
            cantidadIntervalos = cantInt;
            minimo = min;
            maximo = max;
            muestra = muest;
        }

        public void generarHistograma()
        {
            generarIntervalos();
            obtenerFrecuenciaObservada();
        }

        private void generarIntervalos()
        {
            //Se calcula el tamaño de cada intervalo
            double tamañoInt = (maximo - minimo) / cantidadIntervalos;
            double limite = minimo;
            intervalos = new List<Intervalo>();
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                //Se crean los intervalos y se les asigna los valores de sus limites inferior y superior y se calcula su marca de clase
                Intervalo interv = new Intervalo();
                interv.limiteInferior = Math.Round(limite, 4);
                limite += tamañoInt;
                interv.limiteSuperior = Math.Round(limite, 4);
                interv.calcularMarcaDeClase();
                intervalos.Add(interv);
            }
        }
        private void obtenerFrecuenciaObservada()
        {
            foreach (var valor in muestra)
            {
                foreach (Intervalo inter in intervalos)
                {
                    //Se comprueba si pertenece al intervalo
                    if (inter.perteneceAIntervalo(valor))
                    {
                        //Se le suma 1 a la frecuencia observada del intervalo al que pertenesca
                        inter.frecuenciaObservada += 1;
                        break;//Se sale del foreach si encontro el intervalo al que pertenece
                    }
                }
            }
        }
        public void obtenerFrecuenciasEsperadas(IDistribucion dist)
        {
            distribucionSeleccionada = dist;
            obtenerMediaYVarianza();
            calcularFrecuenciaEsperada();
        }

        private void obtenerMediaYVarianza()
        {
            //Se calcula la media y la varianza
            double suma = 0;
            foreach (var interv in intervalos)
            {
                suma += interv.marcaDeClase * interv.frecuenciaObservada;
            }
            media = Math.Round((suma / muestra.Length), 4);

            suma = 0;
            foreach (var interv in intervalos)
            {
                suma += (Math.Pow(interv.marcaDeClase, 2) * interv.frecuenciaObservada);
            }
            double agg = suma - (muestra.Length * Math.Pow(media, 2));
            varianza = Math.Round((agg / (muestra.Length - 1)), 4);
        }
        private void calcularFrecuenciaEsperada()
        {
            //Se calcula la frecuencia esperada con la distribucion seleccionada y se la asigna a los intervalos
            foreach (Intervalo inter in intervalos)
            {
                inter.frecuenciaEsperada = distribucionSeleccionada.calcularFrecuenciaEsperada(muestra.Length, inter, media, varianza, cantidadIntervalos);
            }
        }
        public void realizarPruebaDeBondad()
        {
            calcularEstadistico();
            obtenerEstadisticoTabulado();
        }
        private void calcularEstadistico()
        {
            //Con los datos de Fe y Fo de los intervalos se calcula es estadistico para la prueba de Chi Cuadrado
            estadisticoCalculado = 0;
            foreach (Intervalo inter in intervalos)
            {
                inter.estadisticoIntervalo = Math.Round((Math.Pow((inter.frecuenciaObservada - inter.frecuenciaEsperada), 2) / inter.frecuenciaEsperada), 4);
                estadisticoCalculado += inter.estadisticoIntervalo;
                inter.estadisticoAcumulado = estadisticoCalculado;
            }
        }
        private void obtenerEstadisticoTabulado()
        {
            //Se obtiene el estadistico tabulado para los grados de libertad pertinentes y para una significancia del 0.95
            estadisticoTabulado = distribucionSeleccionada.obtenerEstadistico(cantidadIntervalos, 0.95);
        }

        public List<Intervalo> getIntervalos //Para poder trabajar con los intervalos en la carga de datos del grafico y grilla
        {
            get => intervalos;
        }
        public double getEstadisticoCalculado //Para poder trabajar con el estadistico calculado en la conclusion
        {
            get => estadisticoCalculado;
        }
        public double getEstadisticoTabulado //Para poder trabajar con el estadistico tabulado en la conclusion
        {
            get => estadisticoTabulado;
        }
        public double getMedia //Para poder trabajar con la media en la conclusion
        {
            get => media;
        }
        public double getVarianza //Para poder trabajar con la varianza en la conclusion
        {
            get => varianza;
        }
    }
}
