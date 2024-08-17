using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
            
        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            
            double valorFabrica = Convert.ToDouble(tbValorFabrica.Text);
            int añoACalcular = Convert.ToInt32(nupAñoCalcular.Value);

            Moto vehiculo = new Moto(marca, modelo, valorFabrica);

            Evaluador ev=null;

            if (rbLineal.Checked == true)
            {
                int vidaUtil = Convert.ToInt32(tbValorFabrica.Text);

                ev = new EvaluadorLineal(vehiculo, añoACalcular, vidaUtil);
            }
            else if (rbAnual.Checked == true)
            {
                double tasaDepreciacion = Convert.ToDouble(tbValorFabrica.Text);

                ev = new EvaluadorAnual(vehiculo, añoACalcular, tasaDepreciacion);
               
            }                       

            if (ev != null)
            {
                FormVer fVer = new FormVer();

                fVer.tbResultados.Text=ev.VerDescripcion();//polimorfismmo!

                fVer.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbTasaDepreciacion.Enabled= rbLineal.Checked;
            tbTasaDepreciacion.Enabled = rbAnual.Checked;
        }
    }
}
