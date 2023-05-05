using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.GeneradoresVariableAleatoria;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.PruebasDeBondad
{
    class PruebaChiCuadrado : IPrueba
    {
        private List<Intervalo> intervalosHistograma;
        private List<Intervalo> intervalosPrueba;
        private IDistribucion distribucionSeleccionada;
        private double estadisticoTabulado;
        private double estadisticoCalculado;
        public PruebaChiCuadrado(List<Intervalo> intsHisto, IDistribucion distSelec)
        {
            intervalosHistograma = intsHisto;
            distribucionSeleccionada = distSelec;
        }
        public void realizarPrueba()
        {
            //Se llaman a los pasos para realizar la prueba, o por lo menos los finales pues los otros datos ya han sido obtenidos para el histograma
            obtenerIntervalosPrueba();
            calcularEstadistico();
            obtenerEstadisticoTabulado();
        }
        private void obtenerIntervalosPrueba()
        {
            //Se utiliza un bloque try-catch para el manejo de excepciones
            try
            {
                //Se obtienen los intervalos para la prueba de Chi-Cuadrado, esto es que tengan una frecuencia esperada mayor o igual a 5
                int acum = 0;
                intervalosPrueba = new List<Intervalo>();
                Intervalo intPrueba = null;
                foreach (var intHist in intervalosHistograma)
                {
                    if (acum == 1)//En caso de que el intervalo anterior tenga Fe menor a 5 se acumula con el actual
                    {
                        intervalosPrueba[intervalosPrueba.Count - 1].limiteSuperior = intHist.limiteSuperior;
                        intervalosPrueba[intervalosPrueba.Count - 1].frecuenciaObservada += intHist.frecuenciaObservada;
                        intervalosPrueba[intervalosPrueba.Count - 1].frecuenciaEsperada += intHist.frecuenciaEsperada;
                        if (!intervalosPrueba[intervalosPrueba.Count - 1].frecEspMenorA5())//Si se llega a Fe de 5 se deja de acumular
                        {
                            acum = 0;
                        }
                    }
                    else
                    {
                        intervalosPrueba.Add(intHist);//Se agrega el intervalo pertinente a la lista
                        if (intervalosPrueba[intervalosPrueba.Count - 1].frecEspMenorA5())//y se comprueba si tiene Fe de 5 o mas, en caso de que si se pasa al siguiente que tambien se agregara,
                                                                                          //en caso de que no se pasa a la acumulacion
                        {
                            acum = 1;
                            if (intHist == intervalosHistograma[intervalosHistograma.Count - 1])
                            {
                                //Esta parte es para la normal y la exponencial para que el ultimo intervalo no quede con menos de 5
                                intervalosPrueba[intervalosPrueba.Count - 2].limiteSuperior = intHist.limiteSuperior;
                                intervalosPrueba[intervalosPrueba.Count - 2].frecuenciaObservada += intHist.frecuenciaObservada;
                                intervalosPrueba[intervalosPrueba.Count - 2].frecuenciaEsperada += intHist.frecuenciaEsperada;
                                intervalosPrueba.RemoveAt(intervalosPrueba.Count - 1);
                            }
                        }
                    }
                }
                if (intervalosPrueba[intervalosPrueba.Count - 1].frecEspMenorA5())
                {
                    //Y esta otra parte es para que la de poisson no quede con un ultimo intervalo con menos de 5 de Fe, no es genial la programacion como algo funciona para algunos casos y para otros no
                    //literalmente si le sacamos esta parte la de poisson no lo hace bien y si se saca la parte de arriba la normal y exponencial no lo hacer bien xD
                    //lo mejor de todo es que ambas partes del codigo coexisten y no se interfieren, es como magia que cada una haga su trabajo sin afectar al del otro
                    Intervalo intPrueb = intervalosPrueba[intervalosPrueba.Count - 1];
                    intervalosPrueba[intervalosPrueba.Count - 2].limiteSuperior = intPrueb.limiteSuperior;
                    intervalosPrueba[intervalosPrueba.Count - 2].frecuenciaObservada += intPrueb.frecuenciaObservada;
                    intervalosPrueba[intervalosPrueba.Count - 2].frecuenciaEsperada += intPrueb.frecuenciaEsperada;
                    intPrueba = intPrueb;
                }
                intervalosPrueba.Remove(intPrueba);
            }
            catch (Exception)
            {
                throw new ApplicationException("No se pudo obtener intervalos con frecuencias mayores o iguales a 5, genere mas numeros o utilice KS");
            }
        }
        private void calcularEstadistico()
        {
            //Se calcula el estadistico para cada intervalo
            estadisticoCalculado = 0;
            foreach (Intervalo inter in intervalosPrueba)
            {
                inter.estadisticoIntervalo = Math.Round((Math.Pow((inter.frecuenciaObservada - inter.frecuenciaEsperada), 2) / inter.frecuenciaEsperada), 4);//Se realiza la formula de Chi-Cuadrado para el estadistico y se guarda
                estadisticoCalculado += inter.estadisticoIntervalo;
                inter.estadisticoAcumulado = estadisticoCalculado;
            }
        }
        private void obtenerEstadisticoTabulado()
        {
            //Se obtiene el estadistico tabulado, se utiliza la distribucion pues los grados de libertad dependen de los datos empiricos que dependen de la distribucion
            estadisticoTabulado = distribucionSeleccionada.obtenerEstadistico(intervalosPrueba.Count, 0.95);
        }
        public List<Intervalo> getIntervalos() //Para poder trabajar con los intervalos en la carga de datos del grafico y grilla
        {
            return intervalosPrueba;
        }
        public double getEstCalc() //Para poder tarbajar con el estadistico calculado en la conclusion
        {
            return estadisticoCalculado;
        }
        public double getEstTab() //Para poder trabajar con el estadistico tabulado en la conclusion
        {
            return estadisticoTabulado;
        }
    }
}
