using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_Individual.Entidades
{
    class ConvertirTiempos
    {
        public double deTiempoADouble(int dias, int horas, int minutos, int segundos)
        {
            double cantidad = 0;
            cantidad += (dias * 1440);
            cantidad += (horas * 60);
            cantidad += minutos;
            cantidad += ((segundos * 100) / 60);
            return cantidad;
        }

        public string deDoubleATiempo(double cant)
        {
            int dias = 0;
            int horas = 0;
            int minutos = 0;
            int segudos = 0;
            dias = Convert.ToInt32(Math.Truncate(cant / 1440));
            cant = cant % 1440;
            horas = Convert.ToInt32(Math.Truncate(cant / 60));
            cant = cant % 60;
            minutos = Convert.ToInt32(Math.Truncate(cant));
            cant = (cant - minutos) * 100;
            segudos = Convert.ToInt32((cant * 60) / 100);
            return dias.ToString() + "-" + horas.ToString() + ":" + minutos.ToString() + ":" + segudos.ToString();

        }
    }
}
