using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta
{
    class RKFinBloqLlegadas : IRungeKutta
    {
        private double t;
        private double L;
        private double h;
        private double t_mas_1;
        private double L_mas_1;
        private double L_ant;
        private double K1;
        private double K2;
        private double K3;
        private double K4;
        private string renglon;

        //La funcion es dL/dt = -((L/0.8)*t^2)-L
        public double obtenerTiempo(double t0, double L0, double paso, double[] parametrosExtra)
        {
            StreamWriter texto = File.AppendText("R-K_Bloqueo_Llegadas.txt");
            t = t0;
            L = L0;
            h = paso;
            renglon = "\n\nCalculo numero:\t" + parametrosExtra[0].ToString() + "\n"
                + "t inicial=\t0\nL inicial=\t" + L.ToString() + "\nL final=\tHasta que la diferencia entre L y L+1 sea menor a 1" + "\nh=\t" + h.ToString() + "\n";
            renglon += "\ttn\tLn\tK1\tK2\tK3\tK4\tt+1\tL+1\tTiempo en mins\n";

            K1 = funcion(t, L);
            K2 = funcion(t + (h / 2), L + ((h / 2) * K1));
            K3 = funcion(t + (h / 2), L + ((h / 2) * K2));
            K4 = funcion(t + h, L + (h * K1));
            t_mas_1 = t + h;
            L_mas_1 = L + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
            renglon += "\t" + t.ToString() + "\t" + L.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + L_mas_1.ToString() + "\t" + (t_mas_1 * 5).ToString();
            texto.WriteLine(renglon);
            t = t_mas_1;
            L_ant = L;
            L = L_mas_1;
            renglon = "";

            while ((L_ant - L) > 1)
            {
                K1 = funcion(t, L);
                K2 = funcion(t + (h / 2), L + ((h / 2) * K1));
                K3 = funcion(t + (h / 2), L + ((h / 2) * K2));
                K4 = funcion(t + h, L + (h * K1));
                t_mas_1 = t + h;
                L_mas_1 = L + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
                renglon += "\t" + t.ToString() + "\t" + L.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                    + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + L_mas_1.ToString() + "\t" + (t_mas_1 * 5).ToString();
                texto.WriteLine(renglon);
                t = t_mas_1;
                L_ant = L;
                L = L_mas_1;
                renglon = "";
            }
            texto.Close();
            return Math.Round(t * 5, 2);
        }

        private double funcion(double t, double L)
        {
            double res = -((L / 0.8) * Math.Pow(t, 2)) - L;
            return Math.Round(res, 2);
        }
    }
}
