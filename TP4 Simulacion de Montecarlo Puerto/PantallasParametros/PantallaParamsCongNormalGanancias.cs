using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_Simulacion_de_Montecarlo_Puerto.GeneradoresVariableAleatoria;

namespace TP4_Simulacion_de_Montecarlo_Puerto.PantallasParametros
{
    public partial class PantallaParamsCongNormalGanancias : Form
    {
        TP4MontecarloPuerto _pant;
        public PantallaParamsCongNormalGanancias(TP4MontecarloPuerto pant)
        {
            InitializeComponent();
            _pant = pant;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _pant.Enabled = true;
            _pant.paramsBorrados(1);
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtSemilla.Focus();
                var semilla = Convert.ToInt64(txtSemilla.Text);
                txtMultiplicador.Focus();
                var multiplicador = Convert.ToInt64(txtMultiplicador.Text);
                txtModulo.Focus();
                var modulo = Convert.ToInt64(txtModulo.Text);
                txtIncremento.Focus();
                var incremento = Convert.ToInt64(txtIncremento.Text);
                long[] parametros = new long[4];
                parametros[0] = semilla;
                parametros[1] = multiplicador;
                parametros[2] = modulo;
                parametros[3] = incremento;
                if (verificarParams(parametros))
                {
                    _pant.guardarParametrosCongNormal(parametros);
                    _pant.Enabled = true;
                    this.Close();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool verificarParams(long[] p)
        {
            if (p[0] < 0)
            {
                txtSemilla.Focus();
                throw new ApplicationException("La Semilla no debe ser negativa");
            }
            if (p[1] < 0)
            {
                txtMultiplicador.Focus();
                throw new ApplicationException("El Multiplicador no debe ser negativo");
            }
            if (p[2] < 0)
            {
                txtModulo.Focus();
                throw new ApplicationException("El Modulo no debe ser negativo");
            }
            if (p[3] < 0)
            {
                txtIncremento.Focus();
                throw new ApplicationException("El Incremento no debe ser negativo");
            }
            return true;
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtSemilla.Text = random.Next(1500, 8000).ToString();
            txtMultiplicador.Text = (1 + 4*random.Next(1,10)).ToString();
            int rnd = random.Next(7, 11);
            txtModulo.Text = (Math.Pow(2,rnd)).ToString();
            txtIncremento.Text = "13";
        }
    }
}
