using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.PruebasDeBondad
{
    class PruebaKS : IPrueba
    {
        private List<Intervalo> intervalosPrueba;
        private int cantidadNumeros;
        private double estadisticoTabulado;
        private double estadisticoCalculado;
        private List<double[]> tabla;
        public PruebaKS(List<Intervalo> intervalos, int cantNums)
        {
            intervalosPrueba = intervalos;
            cantidadNumeros = cantNums;
            cargarTabla();
        }
        private void cargarTabla()
        {
            tabla = new List<double[]>();
            double[] kst1 = new double[2];
            kst1[0] = 1;
            kst1[1] = 0.9750;
            tabla.Add(kst1);
            double[] kst2 = new double[2];
            kst2[0] = 2;
            kst2[1] = 0.8418;
            tabla.Add(kst2);
            double[] kst3 = new double[2];
            kst3[0] = 3;
            kst3[1] = 0.7076;
            tabla.Add(kst3);
            double[] kst4 = new double[2];
            kst4[0] = 4;
            kst4[1] = 0.6239;
            tabla.Add(kst4);
            double[] kst5 = new double[2];
            kst5[0] = 5;
            kst5[1] = 0.5623;
            tabla.Add(kst5);
            double[] kst6 = new double[2];
            kst6[0] = 6;
            kst6[1] = 0.5192;
            tabla.Add(kst6);
            double[] kst7 = new double[2];
            kst7[0] = 7;
            kst7[1] = 0.4834;
            tabla.Add(kst7);
            double[] kst8 = new double[2];
            kst8[0] = 8;
            kst8[1] = 0.4542;
            tabla.Add(kst8);
            double[] kst9 = new double[2];
            kst9[0] = 9;
            kst9[1] = 0.4300;
            tabla.Add(kst9);
            double[] kst10 = new double[2];
            kst10[0] = 10;
            kst10[1] = 0.4092;
            tabla.Add(kst10);
            double[] kst11 = new double[2];
            kst11[0] = 11;
            kst11[1] = 0.3912;
            tabla.Add(kst11);
            double[] kst12 = new double[2];
            kst12[0] = 12;
            kst12[1] = 0.3754;
            tabla.Add(kst12);
            double[] kst13 = new double[2];
            kst13[0] = 13;
            kst13[1] = 0.3614;
            tabla.Add(kst13);
            double[] kst14 = new double[2];
            kst14[0] = 14;
            kst14[1] = 0.3489;
            tabla.Add(kst14);
            double[] kst15 = new double[2];
            kst15[0] = 15;
            kst15[1] = 0.3375;
            tabla.Add(kst15);
            double[] kst16 = new double[2];
            kst16[0] = 16;
            kst16[1] = 0.3273;
            tabla.Add(kst16);
            double[] kst17 = new double[2];
            kst17[0] = 17;//Te quiero Luz
            kst17[1] = 0.3179;
            tabla.Add(kst17);
            double[] kst18 = new double[2];
            kst18[0] = 18;
            kst18[1] = 0.3093;
            tabla.Add(kst18);
            double[] kst19 = new double[2];
            kst19[0] = 19;
            kst19[1] = 0.3014;
            tabla.Add(kst19);
            double[] kst20 = new double[2];
            kst20[0] = 20;
            kst20[1] = 0.2940;
            tabla.Add(kst20);
            double[] kst21 = new double[2];
            kst21[0] = 21;
            kst21[1] = 0.2872;
            tabla.Add(kst21);
            double[] kst22 = new double[2];
            kst22[0] = 22;
            kst22[1] = 0.2808;
            tabla.Add(kst22);
            double[] kst23 = new double[2];
            kst23[0] = 23;
            kst23[1] = 0.2749;
            tabla.Add(kst23);
            double[] kst24 = new double[2];
            kst24[0] = 24;
            kst24[1] = 0.2693;
            tabla.Add(kst24);
            double[] kst25 = new double[2];
            kst25[0] = 25;
            kst25[1] = 0.2640;
            tabla.Add(kst25);
            double[] kst26 = new double[2];
            kst26[0] = 26;
            kst26[1] = 0.2590;
            tabla.Add(kst26);
            double[] kst27 = new double[2];
            kst27[0] = 27;
            kst27[1] = 0.2543;
            tabla.Add(kst27);
            double[] kst28 = new double[2];
            kst28[0] = 28;
            kst28[1] = 0.2499;
            tabla.Add(kst28);
            double[] kst29 = new double[2];
            kst29[0] = 29;
            kst29[1] = 0.2457;
            tabla.Add(kst29);
            double[] kst30 = new double[2];
            kst30[0] = 30;
            kst30[1] = 0.2417;
            tabla.Add(kst30);

        }//Aqui dentro se ocultan muchas lineas de codigo puestas para cargar una tabla de valores puesto que no estamos utilizando una BD, de hecho se hacen muchas operaciones
                                     //porque si se tratase de optimizar utilizando el mismo vector para ir sumandolo a la lista este sobreescribiria los valores de la lista tambien y es una M&#%@$!!
        public void realizarPrueba()
        {
            //Se llaman a los pasos para realizar la prueba, o por lo menos los finales pues los otros datos ya han sido obtenidos para el histograma
            calcularProbabilidadObservada();
            calcularProbabilidadEsperada();
            calcularDifAbsPoYPe();
            obtenerEstadisticoCalculado();
            obtenerEstadisticoTabulado();
        }
        private void calcularProbabilidadObservada()
        {
            //Se calcula la probabilidad de la frecuencia observada para cada intervalo
            foreach (var interv in intervalosPrueba)
            {
                double prob = Math.Round(( interv.frecuenciaObservada/cantidadNumeros ),4);//Se divie la Fo por la cantidad de numeros generados y se redondea a 4 decimales
                interv.probabilidadObservada = prob;//Se guarda en el intervalo para utilizarla mas tarde
            }
        }
        private void calcularProbabilidadEsperada()
        {
            //Se calcula la probabilidad de la frecuencia esperada para cada intervalo
            foreach (var interv in intervalosPrueba)
            {
                double prob = Math.Round((interv.frecuenciaEsperada / cantidadNumeros), 4);//Se divie la Fe por la cantidad de numeros generados y se redondea a 4 decimales
                interv.probabilidadEsperada = prob;//Se guarda en el intervalo para utilizarla mas tarde
            }
        }
        private void calcularDifAbsPoYPe()
        {
            //Se calcula la diferencia absoluta entre las probabilidades observadas y esperadas
            foreach (var interv in intervalosPrueba)
            {
                double c = Math.Round(Math.Abs(interv.probabilidadObservada-interv.probabilidadEsperada),4);
                interv.estadisticoIntervalo = c;//Se guarda en un lugar conveniente del intervalo
            }
        }
        private void obtenerEstadisticoCalculado()
        {
            //Se obtiene el maximo de las diferencias absolutas, tambien conocido como estadistico calculado
            intervalosPrueba[0].estadisticoAcumulado = intervalosPrueba[0].estadisticoIntervalo;
            double maxC = intervalosPrueba[0].estadisticoAcumulado;
            foreach (var interv in intervalosPrueba)
            {
                if (interv.estadisticoIntervalo > maxC)
                {
                    maxC = interv.estadisticoIntervalo;
                    interv.estadisticoAcumulado = maxC;
                }
                else
                {
                    interv.estadisticoAcumulado = maxC;
                }
            }
            estadisticoCalculado = maxC;//Si este de aqui
        }
        private void obtenerEstadisticoTabulado()
        {
            //Se obtiene el estadistico tabulado
            if (cantidadNumeros > 30)//Si estas utilizando esta prueba de mala forma, con mas de 30 muestras, pues se utiliza la funcion provista en la tabla para generar su estadistico tabulado
            {
                estadisticoTabulado = Math.Round(( 1.36/Math.Sqrt(cantidadNumeros) ), 4);
            }
            else//en caso contrario pues se busca en la tabla que conincidan la cantidad de numeros, que tambien son los grados de libertad, para obtener el estadistico con "mayor precision"(creo)
            {
                foreach (var valor in tabla)
                {
                    if (cantidadNumeros == valor[0])
                    {
                        estadisticoTabulado = valor[1];
                        break;
                    }
                }
            }
        }
        public List<Intervalo> getIntervalos() //Para poder trabajar con los intervalos en la carga de datos del grafico y grilla
        {
            return intervalosPrueba;
        }
        public double getEstCalc() //Para poder tarbajar con el estadistico calculado en la conclusion
        {
            return estadisticoCalculado;
        }
        public double getEstTab() //Para poder tarbajar con el estadistico tabulado en la conclusion
        {
            return estadisticoTabulado;
        }
    }
}
