using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion_de_Sistemas_de_Colas.Modelos
{
    class EmpleadoCaseta
    {
        public string nombre { get; set; }
        public string estadoCaseta { get; set; }

        public double porcentajeDeOcupacionDeLaCaseta { get; set; } //Aqui se guarda el resultado de (acumulador*100)/relojSim
        public double acumuladorTiempoServidorOcupado { get; set; } //Se acumula el tiempo en el que servidor estuvo ocupado

    }
}
