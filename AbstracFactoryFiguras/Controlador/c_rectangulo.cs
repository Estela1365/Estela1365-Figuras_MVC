using AbstracFactoryFiguras.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstracFactoryFiguras.Controlador
{
    class c_rectangulo
    {
        frmRectangulo frm_rectangulo;
        m_rectangulo rectangulo;


        private static c_rectangulo instancia;

        private c_rectangulo()
        {
            frm_rectangulo = new frmRectangulo();
            listening();

        }
        public frmRectangulo getFormulario()
        {
            return frm_rectangulo;
        }
        public static c_rectangulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new c_rectangulo();
            }
            return instancia;
        }
        private void listening()
        {
            frm_rectangulo.btnCalcular.Click += new EventHandler(btnCalcular_Click);
            frm_rectangulo.FormClosing += new FormClosingEventHandler(frmRectangulo_FormClosing);
        }
        private void frmRectangulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rectangulo = new m_rectangulo();

            rectangulo.Basee = Convert.ToDouble(frm_rectangulo.txtBase.Text);
            rectangulo.Altura = Convert.ToDouble(frm_rectangulo.txtAltura.Text);

            frm_rectangulo.labelArea.Text = rectangulo.calcular_area().ToString();
            frm_rectangulo.labelPerimetro.Text = rectangulo.calcular_perimetro().ToString();
            frm_rectangulo.labelDecripcion.Text = rectangulo.mostrar_descripcion().ToString();
        }
    }
}
