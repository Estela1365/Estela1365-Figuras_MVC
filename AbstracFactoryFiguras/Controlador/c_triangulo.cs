using AbstracFactoryFiguras.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstracFactoryFiguras.Controlador
{
    class c_triangulo
    {
        frmTriangulo frm_triangulo;
        m_triangulo triangulo;

        private static c_triangulo instancia;

        private c_triangulo()
        {
            frm_triangulo = new frmTriangulo();
            listening();

        }
        public frmTriangulo getFormulario()
        {
            return frm_triangulo;
        }
        public static c_triangulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new c_triangulo();
            }
            return instancia;
        }
        private void listening()
        {
            frm_triangulo.btnCalcular.Click += new EventHandler(btnCalcular_Click);
            frm_triangulo.FormClosing += new FormClosingEventHandler(frmTriangulo_FormClosing);
        }
        private void frmTriangulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            triangulo = new m_triangulo();

            triangulo.Basee = Convert.ToDouble(frm_triangulo.txtBase.Text);
            triangulo.Altura = Convert.ToDouble(frm_triangulo.txtAltura.Text);

            frm_triangulo.labelArea.Text = triangulo.calcular_area().ToString();
            frm_triangulo.labelPerimetro.Text = triangulo.calcular_perimetro().ToString();
            frm_triangulo.labelDecripcion.Text = triangulo.mostrar_descripcion().ToString();
        }
    }
}
