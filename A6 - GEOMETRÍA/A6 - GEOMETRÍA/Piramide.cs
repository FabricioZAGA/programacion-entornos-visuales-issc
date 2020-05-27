using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6___GEOMETRÍA
{
    class Piramide : FiguraRegular
    {
        public double Altura { get; set; }
        public Piramide()
        {

        }
        public double GetVolumen()
        {
            return GetArea() * this.Altura / 3;
        }
        public double GetAreaPiramide()
        {
            double theta = 360 / (2 * NumLados);
            double Apotema = LongLado / (2 * Math.Tan(theta * (Math.PI / 180)));
            double AlturaCara = Math.Sqrt(Math.Pow(Apotema, 2) + Math.Pow(Altura, 2));
            return (LongLado * AlturaCara * NumLados / 2) + GetArea();
        }
    }
}
