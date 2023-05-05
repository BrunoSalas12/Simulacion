﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria
{
    class GeneradorCongruencialMixto : IGenerador
    {
        //Constantes del metodo
        private long semilla;
        private long multiplicador;
        private double modulo;
        private long incremento;
        //Utiliza dos vectores para conservar y generar el random anterior y siguiente
        private double[] rnd1;
        private double[] rnd2;
        private double posicion;
        private int unoOdos; //Se utiliza para saber cual es el random anterior y en cual guardar el nuevo generado

        public GeneradorCongruencialMixto(long X0, long a, long m, long c)
        {
            //Se cargan las constantes con los valores pasados por parametros
            semilla = X0;
            multiplicador = a;
            modulo = m;
            incremento = c;
            unoOdos = 0;
            //Se inicializan los vectores randoms con tres espacios: la posicion [0], Xn [1], random [2]
            rnd1 = new double[3];
            rnd2 = new double[3];
        }
        public double[] generarRandom()
        {
            //Carga el vector random correspondiente con la posicion, el Xn, y el random generado utilizando el vector random con el Xn anterior
            if (unoOdos == 0)
            {
                posicion = 1;
                rnd1[0] = posicion;
                double Xn = (multiplicador * semilla + incremento) % modulo;
                rnd1[1] = Xn;
                rnd1[2] = obtenerRandom(rnd1[1]);
                posicion += 1;
                unoOdos = 1;
                return rnd1;
            }
            else if (unoOdos == 1)
            {
                rnd2[0] = posicion;
                double Xn = (multiplicador * rnd1[1] + incremento) % modulo;
                rnd2[1] = Xn;
                rnd2[2] = obtenerRandom(rnd2[1]);
                posicion += 1;
                unoOdos = 2;
                return rnd2;
            }
            else if (unoOdos == 2)
            {
                rnd1[0] = posicion;
                double Xn = (multiplicador * rnd2[1] + incremento) % modulo;
                rnd1[1] = Xn;
                rnd1[2] = obtenerRandom(rnd1[1]);
                posicion += 1;
                unoOdos = 1;
                return rnd1;
            }
            return rnd1;

        }
        private double obtenerRandom(double Xn)
        {
            //Obtiene el random y redondea a 4 decimales
            double random = Xn / modulo;
            return Math.Round(random, 2);
        }
    }
}