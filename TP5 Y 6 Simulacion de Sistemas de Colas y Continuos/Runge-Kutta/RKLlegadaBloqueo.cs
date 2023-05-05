using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta
{
    class RKLlegadaBloqueo : IRungeKutta
    {
        private double t;
        private double A;
        private double h;
        private double beta;
        private double corte;
        private double t_mas_1;
        private double A_mas_1;
        private double K1;
        private double K2;
        private double K3;
        private double K4;
        private string renglon;

        //La funcion es dA/dt = Beta * A
        public double obtenerTiempo(double t0, double A0, double paso, double[] parametrosExtra)
        {
            StreamWriter texto = File.AppendText("R_K_Llegada_Bloqueo.txt");
            t = t0;
            A = A0;
            corte = A * 2;
            h = paso;
            beta = parametrosExtra[1];
            renglon = "\n\nCalculo numero:\t" + parametrosExtra[0].ToString() + "\n"
                + "t inicial=\t0\nA inicial=\t" + A.ToString() + "\nA final=\t" + corte.ToString() + "\nh=\t" + h.ToString() + "\nβ=\t" + beta.ToString() + "\n";
            renglon += "\ttn\tAn\tK1\tK2\tK3\tK4\tt+1\tA+1\tTiempo en mins\n";
            while (A < corte)
            {
                K1 = funcion(t, A);
                K2 = funcion(t + (h / 2), A + ((h / 2) * K1));
                K3 = funcion(t + (h / 2), A + ((h / 2) * K2));
                K4 = funcion(t + h, A + (h * K1));
                t_mas_1 = t + h;
                A_mas_1 = A + ((h / 6) * (K1 + 2 * K2 + 2 * K3 + K4));
                renglon += "\t" + t.ToString() + "\t" + A.ToString() + "\t" + K1.ToString() + "\t" + K2.ToString() + "\t"
                    + K3.ToString() + "\t" + K4.ToString() + "\t" + t_mas_1.ToString() + "\t" + A_mas_1.ToString() + "\t" + (t_mas_1*9).ToString();
                texto.WriteLine(renglon);
                t = t_mas_1;
                A = A_mas_1;
                renglon = "";
            }
            texto.Close();
            return Math.Round(t*9, 2);
        }

        private double funcion(double t, double A)
        {
            return Math.Round(beta * A,2);
        }
    }
}
