using AbstracFactoryFiguras.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstracFactoryFiguras.Controlador
{
    class c_mdi
    {
        frmMDI frm;

        public c_mdi()
        {
            frm = new frmMDI();
            listening();
            frm.ShowDialog();
           
        }
        private void listening()
        {
            frm.cuadradoToolStripMenuItem.Click += new EventHandler(cuadradoToolStripMenuItem_Click);
            frm.circuloToolStripMenuItem.Click += new EventHandler(circuloToolStripMenuItem_Click);
            frm.trinaguloToolStripMenuItem.Click += new EventHandler(trianguloToolStripMenuItem_Click);
            frm.rectanguloToolStripMenuItem.Click += new EventHandler(rectanguloToolStripMenuItem_Click);
        }
        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_cuadrado cuadrado = c_cuadrado.getInstancia();
            frmCuadrado frm_cuadrado= cuadrado.getFormulario();
            frm_cuadrado.MdiParent = frm;
            frm_cuadrado.Show();
        }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_circulo circulo = c_circulo.getInstancia();
            frmCirculo frm_circulo = circulo.getFormulario();
            frm_circulo.MdiParent = frm;
            frm_circulo.Show();
        }
        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_triangulo triangulo = c_triangulo.getInstancia();
            frmTriangulo frm_triangulo = triangulo.getFormulario();
            frm_triangulo.MdiParent = frm;
            frm_triangulo.Show();
        }
        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_rectangulo rectangulo = c_rectangulo.getInstancia();
            frmRectangulo frm_rectangulo = rectangulo.getFormulario();
            frm_rectangulo.MdiParent = frm;
            frm_rectangulo.Show();
        }

    }
}
