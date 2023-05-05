using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta
{
    interface IRungeKutta
    {
        double obtenerTiempo(double X0, double Y0, double paso);
    }
}
