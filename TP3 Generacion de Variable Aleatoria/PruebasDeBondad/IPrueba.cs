using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Generacion_de_Variable_Aleatoria.Modelos;

namespace TP3_Generacion_de_Variable_Aleatoria.PruebasDeBondad
{
    interface IPrueba
    {
        //Se utiliza una interfaz para manejar las diferentes pruebas
        double getEstCalc();
        double getEstTab();
        List<Intervalo> getIntervalos();
        void realizarPrueba();

    }
}
