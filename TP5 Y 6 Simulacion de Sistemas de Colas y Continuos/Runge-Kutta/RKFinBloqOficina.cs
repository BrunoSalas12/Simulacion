using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta
{
    class RKFinBloqOficina : IRungeKutta
    {
        private double t;
        private double S;
        private double h;
        private double corte;
        private double t_mas_1;
        private double S_mas_1;
        private double K1;
        private double K2;
        private double K3;
        private double K4;
        private string renglon;

        //La funcion es dS/dt = (0.2*S)+3-t
        public double obtenerTiempo(double t0, double S0, double paso, double[] parametrosExtra)
        {
            StreamWriter texto = File.AppendText("R_K_Bloqueo_Oficina.txt");

            t = t0;
            S = S0;
            corte = S * 1.35;
            h = paso;
            renglon = "\n\nCalculo numero:\t" + parametrosExtra[0].ToString() + "\n"
                + "t inicial=\t0\nS inicial=\t" + S.ToString() + "\nS final=\t" + corte.ToString() + "\nh=\t" + h.ToString() + "\n" ;
            renglon += "\ttn\tSn\tK1\tK2\tK3\tK4\tt+1\tS+1\tTiempo en mins\n";
            while (S < corte)
            {
                K1 = funcion(t, S);
                K2 = funcion(t + (h / 2), S + ((h / 2) * K1));
                K3 = funcion(t + (h / 2), S + ((h / 2) * K2));
                K4 = funcion(t + h, S + (h * K1));
                t_mas_1 = t + h;
                S_mas_1 = S + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
                renglon += "\t" + t.ToString() + "\t" + S.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                    + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + S_mas_1.ToString() + "\t" + (t_mas_1 * 2).ToString();
                texto.WriteLine(renglon);
                t = t_mas_1;
                S = S_mas_1;
                renglon = "";
            }
            texto.Close();
            return Math.Round(t * 2, 2);
        }

        private double funcion(double t, double S)
        {
            double res = (0.2 * S) + 3 - t;
            return Math.Round(res, 2);
        }
    }
}
