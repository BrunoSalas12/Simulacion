using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class GeneradorCongruencialMixto : IGenerador
    {
        private int semilla;
        private int multiplicador;
        private double modulo;
        private int incremento;
        private double ultimoXn; //se guarda el ultimo Xn para poder continuar con la serie de numeros

        public GeneradorCongruencialMixto(int X0, int a, int m, int c)
        {
            semilla = X0;
            multiplicador = a;
            modulo = m;
            incremento = c;
        }
        public List<double> generarListaNumeros()
        {
            //Genera y devuelve una lista con los primeros 20 randoms
            List<double> lista = new List<double>();
            double Xi = semilla;
            for (int i = 0; i < 20; i++)
            {
                double Xn = (multiplicador * Xi + incremento) % modulo;
                double rnd = obtenerRandom(Xn);
                lista.Add(rnd);
                Xi = Xn;
            }
            ultimoXn = Xi;
            return lista;
        }
        public double generarSiguienteNumero()
        {
            //Genera el siguiente random de la serie
            double Xn = (multiplicador * ultimoXn + incremento) % modulo;
            double rnd = obtenerRandom(Xn);
            ultimoXn = Xn;
            return rnd;
        }

        private double obtenerRandom(double Xn)
        {
            //Realiza la division para obtener el random y lo redondea a 4 decimales
            double random = (Xn / modulo);
            return Math.Round(random, 4);
        }
        public List<double> generarSerieParaPrueba(int cantidad)
        {
            //Genera y devuelve una lista con la cantidad de randoms pasada por parametro para realizar la prueba de chi cuadrado
            List<double> lista = new List<double>();
            double Xi = semilla;
            for (int i = 0; i < cantidad; i++)
            {
                double Xn = (multiplicador * Xi + incremento) % modulo;
                double rnd = obtenerRandom(Xn);
                lista.Add(rnd);
            }
            return lista;
        }
    }
}
