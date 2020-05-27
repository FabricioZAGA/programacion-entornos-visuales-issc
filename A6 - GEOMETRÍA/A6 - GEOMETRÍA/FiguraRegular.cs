using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6___GEOMETRÍA
{
    public class FiguraRegular
    {
        public int NumLados { get; set; }
        public double Radio { get; set; }
        public double LongLado { get; set; }
        public string Nombre { get; set; }
        public FiguraRegular()
        {

        }
        
        public double GetArea()
        {
            double theta = 360 / (2 * NumLados);
            double apotema = Math.Sqrt(Math.Pow(Radio, 2) - Math.Pow((LongLado / 2), 2));
            double ex = LongLado * apotema / 2;
            return ex * NumLados;
        }
        public double GetPerimetro()
        {
            double perimetro = NumLados * LongLado;
            return perimetro;
        }
    }
}
