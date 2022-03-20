using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios.Modelos
{
    interface IGenerador
    {
        //Se utiliza una interfaz para poder generalizar los generadorSeleccionado
        List<double> generarListaNumeros();
        double generarSiguienteNumero();
        List<double> generarSerieParaPrueba(int cantidad);
    }
}
