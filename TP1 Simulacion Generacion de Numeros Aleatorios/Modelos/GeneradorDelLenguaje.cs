﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    class GeneradorDelLenguaje : IGenerador
    {
        Random metodoLenguaje;
        double[] rnd;
        double posicion;
        public GeneradorDelLenguaje()
        {
            metodoLenguaje = new Random();
            rnd = new double[3];
            posicion = 1;
        }
        public double[] generarRandom()
        {
            rnd[0] = posicion;
            double random = metodoLenguaje.NextDouble();
            rnd[2] = Math.Round(random, 4);
            posicion += 1;
            return rnd;
        }
    }
}
