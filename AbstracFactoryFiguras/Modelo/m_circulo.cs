using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFactoryFiguras
{
    class m_circulo
    {
        double aarea;
        double peri;
        double radio;

        public double Aarea { get => aarea; set => aarea = value; }
        public double Peri { get => peri; set => peri = value; }
        public double Radio { get => radio; set => radio = value; }

        public double calcular_area()
        {
            Aarea = Math.PI * Math.Pow(Radio, 2);
            return Aarea;
        }
        public double calcular_perimetro()
        {
            Peri = 2 * Math.PI * Radio;
            return Peri;
        }
         public string mostrar_descripcion()
        {
            return "\"CIRCULO\"\n"+"\nÁrea: " + Aarea + " cm2\nPerimetro: "+Peri+" cm";
        }
    }

}
