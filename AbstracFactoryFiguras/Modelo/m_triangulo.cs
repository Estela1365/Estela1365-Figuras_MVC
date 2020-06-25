using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFactoryFiguras
{
    class m_triangulo
    {
        double aarea;
        double peri;
        double basee;
        double altura;

        public double Aarea { get => aarea; set => aarea = value; }
        public double Peri { get => peri; set => peri = value; }
        public double Basee { get => basee; set => basee = value; }
        public double Altura { get => altura; set => altura = value; }

        public double calcular_area()
        {
            Aarea = Basee * Altura / 2;
            return Aarea;
        }

        public double calcular_perimetro()
        {
            Peri = 3 * Basee;
            return Peri;
        }

        public string mostrar_descripcion()
        {
            return "\"TRIANGULO\"\n" + "\nÁrea: " + Aarea + " cm2\nPerimetro: " + Peri + " cm";
        }

    }
}
