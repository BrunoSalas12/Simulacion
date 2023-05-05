using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class PruebaChiCuadrado
    {
        private int cantidadNumeros;
        private double cantidadIntervalos;
        private IGenerador generadorSeleccionado;
        private IDistribucion distribucionSeleccionada;
        private List<Intervalo> intervalos;
        private double estadisticoCalculado;
        private double estadisticoTabulado;
        private double media;
        private double varianza;
        PantallaPruebaChiCuadrado _pantalla;
        public PruebaChiCuadrado(int cantNum, int cantInt, IGenerador genSelc, IDistribucion dist, PantallaPruebaChiCuadrado pant)
        {
            cantidadIntervalos = cantInt;
            cantidadNumeros = cantNum;
            generadorSeleccionado = genSelc;
            distribucionSeleccionada = dist;
            _pantalla = pant;
        }

        public void realizarPruebaChiCuadrado()
        {
            //Se realizan los pasos necesarios para hacer la prueba
            generarIntervalos();
            obtenerFrecuenciaObservada();
            obtenerMediaYVarianza();
            calcularFrecuenciaEsperada();
            calcularEstadistico();
            obtenerEstadisticoTabulado();
        }

        private void generarIntervalos()
        {
            //Se calcula el tamaño de cada intervalo
            double tamañoInt = 1 / cantidadIntervalos;
            double limite = 0;
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

        private void calcularFrecuenciaEsperada()
        {
            //Se calcula la frecuencia esperada con la distribucion seleccionada y se la asigna a los intervalos
            foreach (Intervalo inter in intervalos)
            {
                inter.frecuenciaEsperada = distribucionSeleccionada.calcularFrecuenciaEsperada(cantidadNumeros,cantidadIntervalos);
            }
        }

        private void obtenerFrecuenciaObservada()
        {
            //Se realiza la generacion de los randoms y se observa el intervalo al que pertenecen y se guarda la lista en un archivo de texto
            TextWriter serie = new StreamWriter("SerieGeneradaEnPrueba.txt");//Se crea el manejo del archivo de texto, se guarda en bin/Debug/ de la carpeta del proyecto
            for (int i = 0; i < cantidadNumeros; i++)
            {
                //Se utiliza el generador seleccionado para generar el random
                double[] random = generadorSeleccionado.generarRandom();
                foreach (Intervalo inter in intervalos)
                {
                    //Se comprueba si pertenece al intervalo
                    if (inter.perteneceAIntervalo(random[2]))
                    {
                        //Se le suma 1 a la frecuencia observada del intervalo al que pertenesca
                        inter.frecuenciaObservada += 1;
                        break;//Se sale del foreach si encontro el intervalo al que pertenece
                    }
                }
                //Se guarda el random en el archivo de texto y se aumenta la progress bar
                serie.WriteLine(random[2].ToString());
                _pantalla.progressBar(i);
            }
            serie.Close();//Se cierra el archivo de texto
        }
        private void obtenerMediaYVarianza()
        {
            //Se calcula la media y la varianza
            double suma = 0;
            foreach (var interv in intervalos)
            {
                suma += interv.marcaDeClase * interv.frecuenciaObservada;
            }
            media = Math.Round((suma / cantidadNumeros),4);

            suma = 0;
            foreach (var interv in intervalos)
            {
                suma += (Math.Pow(interv.marcaDeClase, 2) * interv.frecuenciaObservada);
            }
            double agg = suma - (cantidadNumeros * Math.Pow(media, 2));
            varianza = Math.Round((agg / (cantidadNumeros - 1)), 4);
        }
        private void calcularEstadistico()
        {
            //Con los datos de Fe y Fo de los intervalos se calcula es estadistico para la prueba de Chi Cuadrado
            estadisticoCalculado = 0;
            foreach (Intervalo inter in intervalos)
            {
                inter.estadisticoIntervalo = Math.Round((Math.Pow((inter.frecuenciaObservada - inter.frecuenciaEsperada), 2) / inter.frecuenciaEsperada),4);
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
