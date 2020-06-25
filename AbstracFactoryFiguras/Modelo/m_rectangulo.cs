using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFactoryFiguras
{
    class m_rectangulo
    {
        double aarea;
        double peri;

        double basee;
        double altura;

        public double Basee { get => basee; set => basee = value; }
        public double Altura { get => altura; set => altura = value; }

        public double calcular_area()
        {
            aarea = Basee * Altura;
            return aarea;
        }

        public double calcular_perimetro()
        {
            peri = (2 * Basee) + (2 * Altura);
            return peri;
        }

        public string mostrar_descripcion()
        {
            return "\"RECTANGULO\"\n" + "\nÁrea: " + aarea + " cm2\nPerimetro: " + peri + " cm";
        }

    }
}
