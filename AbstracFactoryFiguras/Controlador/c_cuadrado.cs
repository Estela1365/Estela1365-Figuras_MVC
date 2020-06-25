using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstracFactoryFiguras.Controlador
{
    class c_cuadrado
    {
        
        frmCuadrado frm_cuadrado;
        m_cuadrado cuadrado;
        private static c_cuadrado instancia;

        private c_cuadrado()
        {
            frm_cuadrado = new frmCuadrado();
            listening();

        }
        public frmCuadrado getFormulario()
        {
            return frm_cuadrado;
        }
        public static c_cuadrado getInstancia()
        {
            if (instancia == null)
            {
                instancia = new c_cuadrado();
            }
            return instancia;
        }

        private void listening()
        {
            frm_cuadrado.btnCalcular.Click += new EventHandler(btnCalcular_Click);
            frm_cuadrado.FormClosing += new FormClosingEventHandler(frmCuadrado_FormClosing);
        }
        private void frmCuadrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cuadrado = new m_cuadrado();
            cuadrado.Lado =Convert.ToDouble(frm_cuadrado.txtLado.Text);

            frm_cuadrado.labelArea.Text = cuadrado.calcular_area().ToString();
            frm_cuadrado.labelPerimetro.Text = cuadrado.calcular_perimetro().ToString();
            frm_cuadrado.labelDecripcion.Text = cuadrado.mostrar_descripcion().ToString();
        }
    }
}
