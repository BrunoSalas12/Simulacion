using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Simulacion_de_Montecarlo_Puerto.PantallasParametros
{
    public partial class HorasLlegada : Form
    {
        TP4MontecarloPuerto _pant;
        public HorasLlegada(TP4MontecarloPuerto pant)
        {
            InitializeComponent();
            _pant = pant;
            txtCantHoras.Text = _pant.cantHoras.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar())
                {
                    _pant.cantHoras = Convert.ToInt32(txtCantHoras.Text);
                    cerrarVentana();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarVentana();
        }

        private void HorasLlegada_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarVentana();
        }
        private bool verificar()
        {
            txtCantHoras.Focus();
            if (txtCantHoras.Text == "")
                throw new ApplicationException("Debe Ingresar la cantidad de horas");
            int cant = Convert.ToInt32(txtCantHoras.Text);
            if (cant <= 0)
                throw new ApplicationException("Las horas deben ser mayor a 0");
            if (cant > 24)
                throw new ApplicationException("Las horas no deben ser mayor a 24");
            return true;
        }
        private void cerrarVentana()
        {
            _pant.Enabled = true;
            this.Dispose();
        }
    }
}
