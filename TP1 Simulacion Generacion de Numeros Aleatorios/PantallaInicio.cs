using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Simulacion_Generacion_de_Numeros_Aleatorios
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void btnGeneracionAleatoria_Click(object sender, EventArgs e)
        {
            //Crea y muestra la pantalla para el punto A y oculta la pantalla inicio
            PantallaGeneracionAleatoria genAleat = new PantallaGeneracionAleatoria(this);
            genAleat.Show();
            this.Hide();
        }

        private void btnPruebaChiCuadrado_Click(object sender, EventArgs e)
        {
            //Crea y muestra la pantalla para el punto B y C y oculta la pantalla inicio
            PantallaPruebaChiCuadrado chiCuadrado = new PantallaPruebaChiCuadrado(this);
            chiCuadrado.Show();
            this.Hide();
        }
    }
}
