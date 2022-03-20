using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class GeneradorCongruencialMultiplicativo : IGenerador
    {

        private int semilla;
        private int multiplicador;
        private double modulo;
        private double ultimoXn; //se guarda el ultimo Xn para poder continuar con la serie de numeros

        public GeneradorCongruencialMultiplicativo(int X0, int a, int m)
        {
            semilla = X0;
            multiplicador = a;
            modulo = m;
        }

        public List<double> generarListaNumeros()
        {
            //Genera y devuelve una lista con los primeros 20 randoms
            List<double> lista = new List<double>();
            double Xi = semilla;
            for (int i = 0; i < 20; i++)
            {
                double Xn = (multiplicador * Xi) % modulo;
                double random = obtenerRandom(Xn);
                lista.Add(random);
                Xi = Xn;

            }
            ultimoXn = Xi;
            return lista;
        }
        public double generarSiguienteNumero()
        {
            //Genera el siguiente random de la serie
            double Xn = (ultimoXn * multiplicador) % modulo;
            double random = obtenerRandom(Xn);
            ultimoXn = Xn;
            return random;
        }

        private double obtenerRandom(double Xn) 
        {
            //Realiza la division para obtener el random y lo redondea a 4 decimales
            double rnd = Xn / modulo;
            return Math.Round(rnd, 4);
        }
        public List<double> generarSerieParaPrueba(int cantidad)
        {
            //No se utiliza este metodo para este generador
            return null;
        }
    }
}
