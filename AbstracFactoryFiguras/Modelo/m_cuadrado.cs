using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFactoryFiguras
{
    class m_cuadrado
    {
        double aarea;
        double peri;
        double lado;

        public double Aarea { get => aarea; set => aarea = value; }
        public double Peri { get => peri; set => peri = value; }
        public double Lado { get => lado; set => lado = value; }

        public double calcular_area()
        {
            Aarea = Math.Pow(Lado, 2);
            return Aarea;
        }

        public double calcular_perimetro()
        {
            Peri = 4 * Lado;
            return Peri;
        }

        public string mostrar_descripcion()
        {
            return "\"CUADRADO\"\n" + "\nÁrea: " + Aarea + " cm2\nPerimetro: " + Peri + " cm";
        }
    }
}
