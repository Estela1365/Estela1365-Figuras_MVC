using AbstracFactoryFiguras.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstracFactoryFiguras.Controlador
{
    class c_circulo
    {
        frmCirculo frm_circulo;
        m_circulo circulo;

        private static c_circulo instancia;

        private c_circulo()
        {
            frm_circulo = new frmCirculo();
            listening();

        }
        public frmCirculo getFormulario()
        {
            return frm_circulo;
        }
        public static c_circulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new c_circulo();
            }
            return instancia;
        }
        private void listening()
        {
            frm_circulo.btnCalcular.Click += new EventHandler(btnCalcular_Click);
            frm_circulo.FormClosing += new FormClosingEventHandler(frmCirculo_FormClosing);
        }
        private void frmCirculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            circulo = new m_circulo();
            circulo.Radio = Convert.ToDouble(frm_circulo.txtRadio.Text);

            frm_circulo.labelArea.Text = circulo.calcular_area().ToString();
            frm_circulo.labelPerimetro.Text = circulo.calcular_perimetro().ToString();
            frm_circulo.labelDecripcion.Text = circulo.mostrar_descripcion().ToString();
        }
    }
}
