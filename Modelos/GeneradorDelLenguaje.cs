using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class GeneradorDelLenguaje : IGenerador
    {
        Random metodoLenguaje;
        public GeneradorDelLenguaje()
        {
            metodoLenguaje = new Random();
        }
        public List<double> generarListaNumeros()
        {
            //no se utiliza este metodo para este generador
            return null;
        }
        public double generarSiguienteNumero()
        {
            //no se utiliza este metodo para este generador
            return 0;
        }

        public List<double> generarSerieParaPrueba(int cantidad)
        {
            //Genera la cantidad pasada por parametro de randoms con el metodo provisto por el lenguaje para realizar la prueba de chi cuadrado
            List<double> lista = new List<double>();
            for (int i = 0; i < cantidad; i++)
            {
                double random = metodoLenguaje.NextDouble();
                double rnd = Math.Round(random, 4);
                lista.Add(rnd);
            }
            return lista;
        }
    }
}
