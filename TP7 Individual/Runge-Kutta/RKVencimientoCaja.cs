using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta
{
    class RKVencimientoCaja : IRungeKutta
    {
        private double t;
        private double R;
        private double h;
        private double t_mas_1;
        private double R_mas_1;
        private double R_ant;
        private double K1;
        private double K2;
        private double K3;
        private double K4;
        private string renglon;

        public double obtenerTiempo(double t0, double R0, double paso)
        {
            StreamWriter texto = File.AppendText("RK-VencimientoCajas.txt");
            t = t0;
            R = R0;
            h = paso;
            renglon = "\n\n" + "t inicial=\t0\nR inicial=\t" + R.ToString() + "\nR final=\tHasta que no crezca mas" + "\nh=\t" + h.ToString() + "\n";
            renglon += "\ttn\tLn\tK1\tK2\tK3\tK4\tt+1\tR+1\tTiempo en mins\n";

            K1 = funcion(t, R);
            K2 = funcion(t + (h / 2), R + ((h / 2) * K1));
            K3 = funcion(t + (h / 2), R + ((h / 2) * K2));
            K4 = funcion(t + h, R + (h * K1));
            t_mas_1 = t + h;
            R_mas_1 = R + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
            renglon += "\t" + t.ToString() + "\t" + R.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + R_mas_1.ToString() + "\t" + (R_mas_1/60).ToString();
            texto.WriteLine(renglon);
            t = t_mas_1;
            R_ant = R;
            R = R_mas_1;
            renglon = "";

            while ((R_ant - R) != 0)
            {
                K1 = funcion(t, R);
                K2 = funcion(t + (h / 2), R + ((h / 2) * K1));
                K3 = funcion(t + (h / 2), R + ((h / 2) * K2));
                K4 = funcion(t + h, R + (h * K1));
                t_mas_1 = t + h;
                R_mas_1 = R + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
                renglon += "\t" + t.ToString() + "\t" + R.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                    + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + R_mas_1.ToString() + "\t" + (R_mas_1/60).ToString();
                texto.WriteLine(renglon);
                t = t_mas_1;
                R_ant = R;
                R = R_mas_1;
                renglon = "";
            }
            texto.Close();
            double tiempoMins = R / 60;
            return Math.Round(tiempoMins, 2);
        }
         // La funcion es dR/dt = 41,4*R - 0.0575*R^2
        private double funcion(double t, double R)
        {
            double res = (41.4 * R) - (0.0575 * Math.Pow(R,2));
            return Math.Round(res, 6);
        }
    }
}
